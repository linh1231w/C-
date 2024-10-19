using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DO_AN.DAL
{
    internal class dangnhapDAL : DBConection
    {
        public class DataAccessLayer
        {
            public static bool ValidateLoginCredentials(string username, string password)
            {
                string connectionString = "Data Source=DESKTOP-F61L4C7\\SQLEXPRESS;Initial Catalog=QLBHC#;User ID=sa;Password=sa";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Nguoidung WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0;
                    }
                }
            }
            private string connectionString = "Data Source=DESKTOP-F61L4C7\\SQLEXPRESS;Initial Catalog=QLBHC#;User ID=sa;Password=sa";

            public string GetUserRole(string username)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Role FROM NguoiDung WHERE Username = @Username", connection);
                    cmd.Parameters.AddWithValue("@Username", username);
                    return (string)cmd.ExecuteScalar();
                }
            }
        }






    }
}
