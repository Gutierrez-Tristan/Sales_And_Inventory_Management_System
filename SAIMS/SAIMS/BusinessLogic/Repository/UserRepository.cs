using System.Data;
using Microsoft.Data.SqlClient;
using SAIMS.Model;

namespace SAIMS.BusinessLogic.Repository
{
    internal class UserRepository
    {
        private readonly SqlConnection conn = new SqlConnection(
 @"Data Source=DESKTOP-LSU5CF3\SQLEXPRESS;Initial Catalog=SalesInvenDB;Integrated Security=True;Trust Server Certificate=True");

        public UserModel ValidateUser(string username, string password)
        {
            string query = "SELECT Id, Role FROM tblUser WHERE Username=@user AND Password=@pass";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.Parameters.AddWithValue("@user", username);
            sda.SelectCommand.Parameters.AddWithValue("@pass", password);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                return new UserModel
                {
                    Id = Convert.ToInt32(dtable.Rows[0]["Id"]),
                    Username = username,
                    Password = password,
                    Role = dtable.Rows[0]["Role"].ToString()
                };
            }
            return null;
        }
    }
}
