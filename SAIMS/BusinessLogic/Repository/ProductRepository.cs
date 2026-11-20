using Microsoft.Data.SqlClient;
using SAIMS.Model;

namespace SAIMS.BusinessLogic.Repository
{
    internal class ProductRepository
    {
        private const string ConnStr = DbConfig.ConnStr;
        // Every store product (including out of stock) for the Stock Inquiry screen
        public List<ProductModel> GetInventory(string? search = null)
        {
            const string sql = @"
                SELECT p.ProductID, sp.ItemName, ISNULL(c.Name, '') AS CategoryName,
                       p.SellingPrice, p.Stock, p.ReorderLevel
                FROM tblProduct p
                JOIN tblSupplierProduct sp ON sp.SupplierProductID = p.SupplierProductID
                LEFT JOIN tblCategory c    ON c.CategoryID = sp.CategoryID
                WHERE (@search IS NULL
                       OR sp.ItemName LIKE '%' + @search + '%'
                       OR c.Name      LIKE '%' + @search + '%')
                ORDER BY sp.ItemName";

            var list = new List<ProductModel>();
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@search",
                string.IsNullOrWhiteSpace(search) ? DBNull.Value : search.Trim());

            conn.Open();
            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(new ProductModel
                {
                    ProductID = r.GetInt32(r.GetOrdinal("ProductID")),
                    ItemName = r["ItemName"].ToString() ?? "",
                    CategoryName = r["CategoryName"].ToString() ?? "",
                    SellingPrice = r.GetDecimal(r.GetOrdinal("SellingPrice")),
                    Stock = r.GetInt32(r.GetOrdinal("Stock")),
                    ReorderLevel = r.GetInt32(r.GetOrdinal("ReorderLevel"))
                });
            }
            return list;
        }
        public List<ProductModel> GetAll(string? search = null)
        {
            const string sql = @"
                SELECT p.ProductID, p.SupplierProductID, sp.SupplierID, s.Name AS SupplierName,
                       sp.ItemName, sp.CategoryID, ISNULL(c.Name, '') AS CategoryName,
                       p.CostPrice, p.SellingPrice, p.Stock, p.ReorderLevel,
                       sp.Stock AS SupplierStock, sp.UnitPrice AS SupplierUnitPrice
                FROM tblProduct p
                JOIN tblSupplierProduct sp ON sp.SupplierProductID = p.SupplierProductID
                JOIN tblSuppliers s        ON s.SupplierID = sp.SupplierID
                LEFT JOIN tblCategory c    ON c.CategoryID = sp.CategoryID
                WHERE (@search IS NULL
                       OR sp.ItemName LIKE '%' + @search + '%'
                       OR c.Name      LIKE '%' + @search + '%'
                       OR s.Name      LIKE '%' + @search + '%')
                ORDER BY sp.ItemName";

            var list = new List<ProductModel>();
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@search",
                string.IsNullOrWhiteSpace(search) ? DBNull.Value : search.Trim());

            conn.Open();
            using var r = cmd.ExecuteReader();
            int catOrdinal = r.GetOrdinal("CategoryID");
            while (r.Read())
            {
                list.Add(new ProductModel
                {
                    ProductID = r.GetInt32(r.GetOrdinal("ProductID")),
                    SupplierProductID = r.GetInt32(r.GetOrdinal("SupplierProductID")),
                    SupplierID = r.GetInt32(r.GetOrdinal("SupplierID")),
                    SupplierName = r["SupplierName"].ToString() ?? "",
                    ItemName = r["ItemName"].ToString() ?? "",
                    CategoryID = r.IsDBNull(catOrdinal) ? null : r.GetInt32(catOrdinal),
                    CategoryName = r["CategoryName"].ToString() ?? "",
                    CostPrice = r.GetDecimal(r.GetOrdinal("CostPrice")),
                    SellingPrice = r.GetDecimal(r.GetOrdinal("SellingPrice")),
                    Stock = r.GetInt32(r.GetOrdinal("Stock")),
                    ReorderLevel = r.GetInt32(r.GetOrdinal("ReorderLevel")),
                    SupplierStock = r.GetInt32(r.GetOrdinal("SupplierStock")),
                    SupplierUnitPrice = r.GetDecimal(r.GetOrdinal("SupplierUnitPrice"))
                });
            }
            return list;
        }

        public bool Exists(int supplierProductId)
        {
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(
                "SELECT COUNT(*) FROM tblProduct WHERE SupplierProductID=@id", conn);
            cmd.Parameters.AddWithValue("@id", supplierProductId);
            conn.Open();
            return (int)cmd.ExecuteScalar() > 0;
        }

        // Adds the product to the store. If openingStock > 0 it is bought from the supplier:
        // supplier stock goes down, store stock goes up, and a purchase is recorded.
        public void AddWithOpeningStock(ProductModel p, int openingStock)
        {
            using var conn = new SqlConnection(ConnStr);
            conn.Open();
            using var tx = conn.BeginTransaction();   // rolls back automatically if not committed

            int supplierId, supplierStock;
            using (var cmd = new SqlCommand(
                @"SELECT SupplierID, Stock FROM tblSupplierProduct WITH (UPDLOCK)
                  WHERE SupplierProductID=@id", conn, tx))
            {
                cmd.Parameters.AddWithValue("@id", p.SupplierProductID);
                using var r = cmd.ExecuteReader();
                if (!r.Read()) throw new InvalidOperationException("Supplier item not found.");
                supplierId = r.GetInt32(0);
                supplierStock = r.GetInt32(1);
            }

            if (openingStock > supplierStock)
                throw new InvalidOperationException(
                    $"The supplier only has {supplierStock} in stock.");

            int productId;
            using (var cmd = new SqlCommand(
                @"INSERT INTO tblProduct (SupplierProductID, CostPrice, SellingPrice, Stock, ReorderLevel)
                  OUTPUT INSERTED.ProductID
                  VALUES (@spid, @cost, @sell, @stock, @reorder)", conn, tx))
            {
                cmd.Parameters.AddWithValue("@spid", p.SupplierProductID);
                cmd.Parameters.AddWithValue("@cost", p.CostPrice);
                cmd.Parameters.AddWithValue("@sell", p.SellingPrice);
                cmd.Parameters.AddWithValue("@stock", openingStock);
                cmd.Parameters.AddWithValue("@reorder", p.ReorderLevel);
                productId = (int)cmd.ExecuteScalar();
            }

            if (openingStock > 0)
            {
                DeductSupplierStock(conn, tx, p.SupplierProductID, openingStock);
                InsertPurchase(conn, tx, productId, supplierId, openingStock, p.CostPrice);
            }

            tx.Commit();
        }

        // Moves stock from supplier to store and records the purchase
        public void Restock(int productId, int qty, decimal costPerUnit)
        {
            using var conn = new SqlConnection(ConnStr);
            conn.Open();
            using var tx = conn.BeginTransaction();

            int spId, supplierId, supplierStock;
            using (var cmd = new SqlCommand(
                @"SELECT p.SupplierProductID, sp.SupplierID, sp.Stock
                  FROM tblProduct p
                  JOIN tblSupplierProduct sp WITH (UPDLOCK) ON sp.SupplierProductID = p.SupplierProductID
                  WHERE p.ProductID=@id", conn, tx))
            {
                cmd.Parameters.AddWithValue("@id", productId);
                using var r = cmd.ExecuteReader();
                if (!r.Read()) throw new InvalidOperationException("Product not found.");
                spId = r.GetInt32(0);
                supplierId = r.GetInt32(1);
                supplierStock = r.GetInt32(2);
            }

            if (qty > supplierStock)
                throw new InvalidOperationException(
                    $"The supplier only has {supplierStock} in stock.");

            DeductSupplierStock(conn, tx, spId, qty);

            using (var cmd = new SqlCommand(
                @"UPDATE tblProduct SET Stock = Stock + @qty, CostPrice = @cost
                  WHERE ProductID=@id", conn, tx))
            {
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@cost", costPerUnit);
                cmd.Parameters.AddWithValue("@id", productId);
                cmd.ExecuteNonQuery();
            }

            InsertPurchase(conn, tx, productId, supplierId, qty, costPerUnit);
            tx.Commit();
        }

        private static void DeductSupplierStock(SqlConnection conn, SqlTransaction tx, int spId, int qty)
        {
            using var cmd = new SqlCommand(
                "UPDATE tblSupplierProduct SET Stock = Stock - @qty WHERE SupplierProductID=@id", conn, tx);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@id", spId);
            cmd.ExecuteNonQuery();
        }

        private static void InsertPurchase(SqlConnection conn, SqlTransaction tx,
                                           int productId, int supplierId, int qty, decimal cost)
        {
            using var cmd = new SqlCommand(
                @"INSERT INTO tblPurchase (ProductID, SupplierID, Quantity, CostPerUnit, TotalCost)
                  VALUES (@pid, @sid, @qty, @cost, @total)", conn, tx);
            cmd.Parameters.AddWithValue("@pid", productId);
            cmd.Parameters.AddWithValue("@sid", supplierId);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@cost", cost);
            cmd.Parameters.AddWithValue("@total", cost * qty);
            cmd.ExecuteNonQuery();
        }
        // Products the cashier can sell: in stock only
        public List<ProductModel> GetForSale(string? search = null)
        {
            const string sql = @"
                SELECT p.ProductID, sp.ItemName, ISNULL(c.Name, '') AS CategoryName,
                       p.SellingPrice, p.Stock
                FROM tblProduct p
                JOIN tblSupplierProduct sp ON sp.SupplierProductID = p.SupplierProductID
                LEFT JOIN tblCategory c    ON c.CategoryID = sp.CategoryID
                WHERE p.Stock > 0
                  AND (@search IS NULL
                       OR sp.ItemName LIKE '%' + @search + '%'
                       OR c.Name      LIKE '%' + @search + '%')
                ORDER BY sp.ItemName";

            var list = new List<ProductModel>();
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@search",
                string.IsNullOrWhiteSpace(search) ? DBNull.Value : search.Trim());

            conn.Open();
            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(new ProductModel
                {
                    ProductID = r.GetInt32(r.GetOrdinal("ProductID")),
                    ItemName = r["ItemName"].ToString() ?? "",
                    CategoryName = r["CategoryName"].ToString() ?? "",
                    SellingPrice = r.GetDecimal(r.GetOrdinal("SellingPrice")),
                    Stock = r.GetInt32(r.GetOrdinal("Stock"))
                });
            }
            return list;
        }
    }
}