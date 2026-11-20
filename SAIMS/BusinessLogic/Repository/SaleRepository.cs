using Microsoft.Data.SqlClient;
using SAIMS.Model;

namespace SAIMS.BusinessLogic.Repository
{
    internal class SaleRepository
    {
        private const string ConnStr = DbConfig.ConnStr;

        // Saves the sale + items and deducts store stock. All or nothing.
        public int Add(SaleModel sale)
        {
            using var conn = new SqlConnection(ConnStr);
            conn.Open();
            using var tx = conn.BeginTransaction();   // rolls back automatically if not committed

            int saleId;
            using (var cmd = new SqlCommand(
                @"INSERT INTO tblSale (CashierID, Subtotal, Discount, Total, AmountPaid, ChangeAmount)
                  OUTPUT INSERTED.SaleID
                  VALUES (@cashier, @sub, @disc, @total, @paid, @change)", conn, tx))
            {
                cmd.Parameters.AddWithValue("@cashier", sale.CashierID);
                cmd.Parameters.AddWithValue("@sub", sale.Subtotal);
                cmd.Parameters.AddWithValue("@disc", sale.Discount);
                cmd.Parameters.AddWithValue("@total", sale.Total);
                cmd.Parameters.AddWithValue("@paid", sale.AmountPaid);
                cmd.Parameters.AddWithValue("@change", sale.ChangeAmount);
                saleId = (int)cmd.ExecuteScalar();
            }

            foreach (var item in sale.Items)
            {
                // Deduct only if enough stock is left
                using (var cmd = new SqlCommand(
                    @"UPDATE tblProduct SET Stock = Stock - @qty
                      WHERE ProductID=@pid AND Stock >= @qty", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@qty", item.Quantity);
                    cmd.Parameters.AddWithValue("@pid", item.ProductID);
                    if (cmd.ExecuteNonQuery() == 0)
                        throw new InvalidOperationException($"Not enough stock for {item.ItemName}.");
                }

                using (var cmd = new SqlCommand(
                    @"INSERT INTO tblSaleItem (SaleID, ProductID, Quantity, UnitPrice, LineTotal)
                      VALUES (@sid, @pid, @qty, @price, @line)", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@sid", saleId);
                    cmd.Parameters.AddWithValue("@pid", item.ProductID);
                    cmd.Parameters.AddWithValue("@qty", item.Quantity);
                    cmd.Parameters.AddWithValue("@price", item.UnitPrice);
                    cmd.Parameters.AddWithValue("@line", item.LineTotal);
                    cmd.ExecuteNonQuery();
                }
            }

            tx.Commit();
            return saleId;
        }

        // =============== TRANSACTIONS ===============
        // NOTE: check the column names marked below against your tables:
        //   tblSale.SaleDate   (the date/time default column)
        //   Users.UserID       (the Users key column)
        public List<SaleSummaryModel> GetTransactions(string? search = null)
        {
            const string sql = @"
                SELECT s.SaleID, s.SaleDate, s.CashierID, ISNULL(u.Username, '') AS CashierName,
                       s.Subtotal, s.Discount, s.Total, s.AmountPaid, s.ChangeAmount,
                       ISNULL((SELECT SUM(si.Quantity) FROM tblSaleItem si
                               WHERE si.SaleID = s.SaleID), 0) AS ItemCount
                FROM tblSale s
                LEFT JOIN Users u ON u.Id = s.CashierID
                WHERE (@search IS NULL
                       OR CAST(s.SaleID AS VARCHAR(20)) LIKE '%' + @search + '%'
                       OR u.Username LIKE '%' + @search + '%')
                ORDER BY s.SaleID DESC";

            var list = new List<SaleSummaryModel>();
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@search",
                string.IsNullOrWhiteSpace(search) ? DBNull.Value : search.Trim());

            conn.Open();
            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(new SaleSummaryModel
                {
                    SaleID = r.GetInt32(r.GetOrdinal("SaleID")),
                    SaleDate = r.GetDateTime(r.GetOrdinal("SaleDate")),
                    CashierID = Convert.ToInt32(r["CashierID"]),
                    CashierName = r["CashierName"].ToString() ?? "",
                    Subtotal = r.GetDecimal(r.GetOrdinal("Subtotal")),
                    Discount = r.GetDecimal(r.GetOrdinal("Discount")),
                    Total = r.GetDecimal(r.GetOrdinal("Total")),
                    AmountPaid = r.GetDecimal(r.GetOrdinal("AmountPaid")),
                    ChangeAmount = r.GetDecimal(r.GetOrdinal("ChangeAmount")),
                    ItemCount = Convert.ToInt32(r["ItemCount"])
                });
            }
            return list;
        }

        // Rebuilds a saved sale (with its items) for reprinting the receipt
        public SaleModel? GetSale(int saleId)
        {
            const string headSql = @"SELECT CashierID, Subtotal, Discount, Total, AmountPaid, ChangeAmount
                                     FROM tblSale WHERE SaleID=@id";
            const string itemSql = @"
                SELECT si.ProductID, sp.ItemName, si.Quantity, si.UnitPrice
                FROM tblSaleItem si
                JOIN tblProduct p          ON p.ProductID = si.ProductID
                JOIN tblSupplierProduct sp ON sp.SupplierProductID = p.SupplierProductID
                WHERE si.SaleID=@id";

            using var conn = new SqlConnection(ConnStr);
            conn.Open();

            var sale = new SaleModel();
            using (var cmd = new SqlCommand(headSql, conn))
            {
                cmd.Parameters.AddWithValue("@id", saleId);
                using var r = cmd.ExecuteReader();
                if (!r.Read()) return null;
                sale.CashierID = Convert.ToInt32(r["CashierID"]);
                sale.Subtotal = r.GetDecimal(r.GetOrdinal("Subtotal"));
                sale.Discount = r.GetDecimal(r.GetOrdinal("Discount"));
                sale.Total = r.GetDecimal(r.GetOrdinal("Total"));
                sale.AmountPaid = r.GetDecimal(r.GetOrdinal("AmountPaid"));
                sale.ChangeAmount = r.GetDecimal(r.GetOrdinal("ChangeAmount"));
            }

            var items = new List<SaleItemModel>();
            using (var cmd = new SqlCommand(itemSql, conn))
            {
                cmd.Parameters.AddWithValue("@id", saleId);
                using var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    items.Add(new SaleItemModel
                    {
                        ProductID = r.GetInt32(0),
                        ItemName = r.GetString(1),
                        Quantity = r.GetInt32(2),
                        UnitPrice = r.GetDecimal(3)
                    });
                }
            }
            sale.Items = items;
            return sale;
        }
    }
}