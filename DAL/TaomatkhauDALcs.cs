using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.DAL
{
    internal class TaomatkhauDAL : DBConection
    {
        internal void UpdatePasswordInDatabase(string email, string Password)
        {
            string connectionString = @"Data Source=DESKTOP-F61L4C7\SQLEXPRESS;Initial Catalog=QLBHC#;User ID=sa;Password=sa";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE NguoiDung SET Password = @Password WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Email", email);

                    command.ExecuteNonQuery();
                }
            }

        }








    }
}
