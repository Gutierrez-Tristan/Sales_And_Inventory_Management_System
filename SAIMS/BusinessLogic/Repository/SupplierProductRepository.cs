using Microsoft.Data.SqlClient;
using SAIMS.Model;

namespace SAIMS.BusinessLogic.Repository
{
    internal class SupplierProductRepository
    {
        private const string ConnStr = DbConfig.ConnStr;

        public List<CategoryModel> GetCategories()
        {
            var list = new List<CategoryModel>();
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(
                "SELECT CategoryID, Name FROM tblCategory ORDER BY Name", conn);
            conn.Open();
            using var r = cmd.ExecuteReader();
            while (r.Read())
                list.Add(new CategoryModel
                {
                    CategoryID = r.GetInt32(0),
                    Name = r.GetString(1)
                });
            return list;
        }
        // Finds a category by name, or creates it. Name matching ignores upper/lower case.
        public int GetOrCreateCategory(string name)
        {
            using var conn = new SqlConnection(ConnStr);
            conn.Open();

            using (var cmd = new SqlCommand(
                "SELECT CategoryID FROM tblCategory WHERE Name=@n", conn))
            {
                cmd.Parameters.AddWithValue("@n", name);
                object? found = cmd.ExecuteScalar();
                if (found != null) return (int)found;
            }

            try
            {
                using var cmd = new SqlCommand(
                    "INSERT INTO tblCategory (Name) OUTPUT INSERTED.CategoryID VALUES (@n)", conn);
                cmd.Parameters.AddWithValue("@n", name);
                return (int)cmd.ExecuteScalar();
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                // someone created it a moment ago, so just read it
                using var cmd = new SqlCommand(
                    "SELECT CategoryID FROM tblCategory WHERE Name=@n", conn);
                cmd.Parameters.AddWithValue("@n", name);
                return (int)cmd.ExecuteScalar();
            }
        }

        public List<SupplierProductModel> GetBySupplier(int supplierId, string? search = null)
        {
            const string sql = @"
                SELECT sp.SupplierProductID, sp.SupplierID, sp.ItemName, sp.UnitPrice, sp.Stock,
                       sp.CategoryID, ISNULL(c.Name, '') AS CategoryName
                FROM tblSupplierProduct sp
                LEFT JOIN tblCategory c ON c.CategoryID = sp.CategoryID
                WHERE sp.SupplierID = @sid
                  AND (@search IS NULL
                       OR sp.ItemName LIKE '%' + @search + '%'
                       OR c.Name      LIKE '%' + @search + '%')
                ORDER BY sp.ItemName";

            var list = new List<SupplierProductModel>();
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@sid", supplierId);
            cmd.Parameters.AddWithValue("@search",
                string.IsNullOrWhiteSpace(search) ? DBNull.Value : search.Trim());

            conn.Open();
            using var r = cmd.ExecuteReader();
            int catOrdinal = r.GetOrdinal("CategoryID");
            while (r.Read())
            {
                list.Add(new SupplierProductModel
                {
                    SupplierProductID = r.GetInt32(r.GetOrdinal("SupplierProductID")),
                    SupplierID = r.GetInt32(r.GetOrdinal("SupplierID")),
                    ItemName = r["ItemName"].ToString() ?? "",
                    UnitPrice = r.GetDecimal(r.GetOrdinal("UnitPrice")),
                    Stock = r.GetInt32(r.GetOrdinal("Stock")),
                    CategoryID = r.IsDBNull(catOrdinal) ? null : r.GetInt32(catOrdinal),
                    CategoryName = r["CategoryName"].ToString() ?? ""
                });
            }
            return list;
        }

        public bool Exists(int supplierId, string itemName, int excludeId)
        {
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(
                @"SELECT COUNT(*) FROM tblSupplierProduct
                  WHERE SupplierID=@sid AND ItemName=@name AND SupplierProductID<>@id", conn);
            cmd.Parameters.AddWithValue("@sid", supplierId);
            cmd.Parameters.AddWithValue("@name", itemName);
            cmd.Parameters.AddWithValue("@id", excludeId);
            conn.Open();
            return (int)cmd.ExecuteScalar() > 0;
        }

        public void Add(SupplierProductModel p)
        {
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(
                @"INSERT INTO tblSupplierProduct (SupplierID, CategoryID, ItemName, UnitPrice, Stock)
                  VALUES (@sid, @cat, @name, @price, @stock)", conn);
            cmd.Parameters.AddWithValue("@sid", p.SupplierID);
            cmd.Parameters.AddWithValue("@cat", (object?)p.CategoryID ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@name", p.ItemName);
            cmd.Parameters.AddWithValue("@price", p.UnitPrice);
            cmd.Parameters.AddWithValue("@stock", p.Stock);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public bool Update(SupplierProductModel p)
        {
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(
                @"UPDATE tblSupplierProduct
                  SET CategoryID=@cat, ItemName=@name, UnitPrice=@price, Stock=@stock
                  WHERE SupplierProductID=@id", conn);
            cmd.Parameters.AddWithValue("@cat", (object?)p.CategoryID ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@name", p.ItemName);
            cmd.Parameters.AddWithValue("@price", p.UnitPrice);
            cmd.Parameters.AddWithValue("@stock", p.Stock);
            cmd.Parameters.AddWithValue("@id", p.SupplierProductID);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(int id)
        {
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(
                "DELETE FROM tblSupplierProduct WHERE SupplierProductID=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}