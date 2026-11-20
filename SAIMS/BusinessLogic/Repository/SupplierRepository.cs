using Microsoft.Data.SqlClient;
using SAIMS.Model;

namespace SAIMS.BusinessLogic.Repository
{
    internal class SupplierRepository
    {
        private const string ConnStr = DbConfig.ConnStr;

        public List<SupplierModel> GetAll(string? search = null)
        {
            const string sql = @"
                SELECT s.SupplierID, s.Name, s.Email, s.Phone, s.Address, s.IsActive,
                       COUNT(sp.SupplierProductID) AS ItemCount
                FROM tblSuppliers s
                LEFT JOIN tblSupplierProduct sp ON sp.SupplierID = s.SupplierID
                WHERE (@search IS NULL
                       OR s.Name    LIKE '%' + @search + '%'
                       OR s.Email   LIKE '%' + @search + '%'
                       OR s.Phone   LIKE '%' + @search + '%'
                       OR s.Address LIKE '%' + @search + '%')
                GROUP BY s.SupplierID, s.Name, s.Email, s.Phone, s.Address, s.IsActive
                ORDER BY s.Name";

            var list = new List<SupplierModel>();
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@search",
                string.IsNullOrWhiteSpace(search) ? DBNull.Value : search.Trim());

            conn.Open();
            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(new SupplierModel
                {
                    SupplierID = r.GetInt32(r.GetOrdinal("SupplierID")),
                    Name = r["Name"].ToString() ?? "",
                    Email = r["Email"].ToString() ?? "",
                    Phone = r["Phone"].ToString() ?? "",
                    Address = r["Address"].ToString() ?? "",
                    IsActive = r.GetBoolean(r.GetOrdinal("IsActive")),
                    ItemCount = r.GetInt32(r.GetOrdinal("ItemCount"))
                });
            }
            return list;
        }

        public bool Exists(string email)
        {
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(
                "SELECT COUNT(*) FROM tblSuppliers WHERE Email=@email", conn);
            cmd.Parameters.AddWithValue("@email", email);
            conn.Open();
            return (int)cmd.ExecuteScalar() > 0;
        }

        public bool Exists(string email, int excludeId)
        {
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(
                "SELECT COUNT(*) FROM tblSuppliers WHERE Email=@email AND SupplierID<>@id", conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@id", excludeId);
            conn.Open();
            return (int)cmd.ExecuteScalar() > 0;
        }

        public void Add(SupplierModel s)
        {
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(
                @"INSERT INTO tblSuppliers (Name, Email, Phone, Address, IsActive)
                  VALUES (@name, @email, @phone, @address, 1)", conn);
            cmd.Parameters.AddWithValue("@name", s.Name);
            cmd.Parameters.AddWithValue("@email", s.Email);
            cmd.Parameters.AddWithValue("@phone", s.Phone);
            cmd.Parameters.AddWithValue("@address", s.Address);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public bool Update(SupplierModel s)
        {
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(
                @"UPDATE tblSuppliers
                  SET Name=@name, Email=@email, Phone=@phone, Address=@address, IsActive=@active
                  WHERE SupplierID=@id", conn);
            cmd.Parameters.AddWithValue("@name", s.Name);
            cmd.Parameters.AddWithValue("@email", s.Email);
            cmd.Parameters.AddWithValue("@phone", s.Phone);
            cmd.Parameters.AddWithValue("@address", s.Address);
            cmd.Parameters.AddWithValue("@active", s.IsActive);
            cmd.Parameters.AddWithValue("@id", s.SupplierID);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool HasProducts(int id)
        {
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(
                "SELECT COUNT(*) FROM tblSupplierProduct WHERE SupplierID=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            return (int)cmd.ExecuteScalar() > 0;
        }

        public void Deactivate(int id)
        {
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand(
                "UPDATE tblSuppliers SET IsActive=0 WHERE SupplierID=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public bool Delete(int id)
        {
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand("DELETE FROM tblSuppliers WHERE SupplierID=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}