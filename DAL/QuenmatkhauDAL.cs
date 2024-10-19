using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.DAL
{
    internal class QuenmatkhauDAL : DBConection
    {
        public bool IsEmailExists(string email)
        {
            bool emailExists = false;
            // Kiểm tra xem email có tồn tại trong CSDL hay không.
            // Trả về true nếu email tồn tại, ngược lại trả về false.
            string connectionString = "Data Source=DESKTOP-F61L4C7\\SQLEXPRESS;Initial Catalog=QLBHC#;User ID=sa;Password=sa";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Nguoidung WHERE Email=@Email";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Truyền giá trị vào 
                    cmd.Parameters.AddWithValue("@Email", email);

                    int count = (int)cmd.ExecuteScalar(); // Trả về giá trị duy nhất
                    if (count == 1)
                    {
                        emailExists = true;
                    }
                }
            }
            return emailExists;
        }
    }
}
