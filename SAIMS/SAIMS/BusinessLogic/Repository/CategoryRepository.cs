using Microsoft.Data.SqlClient;
using SAIMS.Model;
using System.Data;

namespace SAIMS.BusinessLogic.Repository
{
    internal class CategoryRepository
    {
        private const string ConnStr =
            @"Data Source=DESKTOP-LSU5CF3\SQLEXPRESS;Initial Catalog=TanTryDB;Integrated Security=True;Trust Server Certificate=True";

        public DataTable GetAll()
        {
            using var conn = new SqlConnection(ConnStr);
            using var sda = new SqlDataAdapter("SELECT Id, Name FROM tblCategory ORDER BY Name", conn);
            var dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public bool Exists(string name)
        {
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand("SELECT COUNT(*) FROM tblCategory WHERE Name=@name", conn);
            cmd.Parameters.AddWithValue("@name", name);
            conn.Open();
            return (int)cmd.ExecuteScalar() > 0;
        }

        public void Add(string name)
        {
            using var conn = new SqlConnection(ConnStr);
            using var cmd = new SqlCommand("INSERT INTO tblCategory (Name) VALUES (@name)", conn);
            cmd.Parameters.AddWithValue("@name", name);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
        public bool Exists(string name, int excludeId)
        {
            using SqlConnection conn = new SqlConnection(ConnStr);
            using SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM tblCategory WHERE CategoryName=@name AND Id<>@id", conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@id", excludeId);
            conn.Open();
            return (int)cmd.ExecuteScalar() > 0;
        }

        public bool Update(CategoryModel category)
        {
            using SqlConnection conn = new SqlConnection(ConnStr);
            using SqlCommand cmd = new SqlCommand(
                "UPDATE tblCategory SET CategoryName=@name WHERE Id=@id", conn);
            cmd.Parameters.AddWithValue("@name", category.Name);
            cmd.Parameters.AddWithValue("@id", category.Id);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(int id)
        {
            using SqlConnection conn = new SqlConnection(ConnStr);
            using SqlCommand cmd = new SqlCommand(
                "DELETE FROM tblCategory WHERE Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}