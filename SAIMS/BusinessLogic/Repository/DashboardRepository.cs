using Microsoft.Data.SqlClient;
using SAIMS.Model;

namespace SAIMS.BusinessLogic.Repository
{
    internal class DashboardRepository
    {
        private const string ConnStr = DbConfig.ConnStr;

        public DashboardSummaryModel GetSummary()
        {
            const string sql = @"
                SELECT
                    (SELECT COUNT(*) FROM tblSuppliers WHERE IsActive = 1)        AS ActiveSuppliers,
                    (SELECT COUNT(*) FROM tblProduct)                             AS ProductsInStore,
                    (SELECT COUNT(*) FROM tblProduct WHERE Stock <= ReorderLevel) AS LowStockCount,
                    ISNULL((SELECT SUM(Stock * CostPrice) FROM tblProduct), 0)    AS InventoryValue";

            var summary = new DashboardSummaryModel();
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(sql, conn);
            conn.Open();
            using var r = cmd.ExecuteReader();
            if (r.Read())
            {
                summary.ActiveSuppliers = r.GetInt32(0);
                summary.ProductsInStore = r.GetInt32(1);
                summary.LowStockCount = r.GetInt32(2);
                summary.InventoryValue = r.GetDecimal(3);
            }
            return summary;
        }

        // The products furthest below their reorder level
        public List<ProductModel> GetLowStock(int top)
        {
            const string sql = @"
                SELECT TOP (@top) sp.ItemName, p.Stock, p.ReorderLevel
                FROM tblProduct p
                JOIN tblSupplierProduct sp ON sp.SupplierProductID = p.SupplierProductID
                WHERE p.Stock <= p.ReorderLevel
                ORDER BY (p.Stock - p.ReorderLevel), sp.ItemName";

            var list = new List<ProductModel>();
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@top", top);
            conn.Open();
            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(new ProductModel
                {
                    ItemName = r.GetString(0),
                    Stock = r.GetInt32(1),
                    ReorderLevel = r.GetInt32(2)
                });
            }
            return list;
        }

        // The latest restocks (and opening stocks) recorded in tblPurchase
        public List<RecentStockModel> GetRecentStocks(int top)
        {
            const string sql = @"
                SELECT TOP (@top) pu.PurchaseDate, sp.ItemName, pu.Quantity
                FROM tblPurchase pu
                JOIN tblProduct p          ON p.ProductID = pu.ProductID
                JOIN tblSupplierProduct sp ON sp.SupplierProductID = p.SupplierProductID
                ORDER BY pu.PurchaseDate DESC, pu.PurchaseID DESC";

            var list = new List<RecentStockModel>();
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@top", top);
            conn.Open();
            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(new RecentStockModel
                {
                    PurchaseDate = r.GetDateTime(0),
                    ItemName = r.GetString(1),
                    Quantity = r.GetInt32(2)
                });
            }
            return list;
        }
        // Numbers for one cashier, for today
        public CashierSummaryModel GetCashierSummary(int cashierId)
        {
            const string sql = @"
                SELECT
                    ISNULL((SELECT SUM(Total) FROM tblSale
                            WHERE CashierID=@cid AND SaleDate >= @start AND SaleDate < @end), 0),
                    (SELECT COUNT(*) FROM tblSale
                            WHERE CashierID=@cid AND SaleDate >= @start AND SaleDate < @end),
                    ISNULL((SELECT SUM(si.Quantity) FROM tblSaleItem si
                            JOIN tblSale s ON s.SaleID = si.SaleID
                            WHERE s.CashierID=@cid AND s.SaleDate >= @start AND s.SaleDate < @end), 0),
                    (SELECT COUNT(*) FROM tblProduct WHERE Stock <= ReorderLevel)";

            var summary = new CashierSummaryModel();
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cid", cashierId);
            cmd.Parameters.AddWithValue("@start", DateTime.Today);
            cmd.Parameters.AddWithValue("@end", DateTime.Today.AddDays(1));
            conn.Open();
            using var r = cmd.ExecuteReader();
            if (r.Read())
            {
                summary.SalesToday = r.GetDecimal(0);
                summary.TransactionsToday = r.GetInt32(1);
                summary.ItemsSold = r.GetInt32(2);
                summary.LowStockCount = r.GetInt32(3);
            }
            return summary;
        }

        // The cashier's latest sales today, newest first
        public List<SaleSummaryModel> GetTodaySales(int cashierId, int top)
        {
            const string sql = @"
                SELECT TOP (@top) s.SaleID, s.SaleDate, s.Total, s.AmountPaid, s.ChangeAmount,
                       ISNULL((SELECT SUM(si.Quantity) FROM tblSaleItem si
                               WHERE si.SaleID = s.SaleID), 0) AS ItemCount
                FROM tblSale s
                WHERE s.CashierID=@cid AND s.SaleDate >= @start AND s.SaleDate < @end
                ORDER BY s.SaleID DESC";

            var list = new List<SaleSummaryModel>();
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@top", top);
            cmd.Parameters.AddWithValue("@cid", cashierId);
            cmd.Parameters.AddWithValue("@start", DateTime.Today);
            cmd.Parameters.AddWithValue("@end", DateTime.Today.AddDays(1));
            conn.Open();
            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(new SaleSummaryModel
                {
                    SaleID = r.GetInt32(r.GetOrdinal("SaleID")),
                    SaleDate = r.GetDateTime(r.GetOrdinal("SaleDate")),
                    Total = r.GetDecimal(r.GetOrdinal("Total")),
                    AmountPaid = r.GetDecimal(r.GetOrdinal("AmountPaid")),
                    ChangeAmount = r.GetDecimal(r.GetOrdinal("ChangeAmount")),
                    ItemCount = Convert.ToInt32(r["ItemCount"])
                });
            }
            return list;
        }
    }
}