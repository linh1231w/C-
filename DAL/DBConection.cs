using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DO_AN.DAL
{
    internal class DBConection
    {
        public DBConection()
        {
        }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-F61L4C7\SQLEXPRESS;Initial Catalog=QLBHC#;User ID=sa;Password=sa";
            return conn;
        }
    }
}
