using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DO_AN.DAL.dangnhapDAL;

namespace DO_AN.BAL
{
    internal class dangnhap
    {
        public class BusinessLogicLayer
        {
            private DataAccessLayer dataAccess;
            public static bool ValidateLoginCredentials(string username, string password)
            {
                // Perform any additional business logic here
                // Call Data Access Layer to validate credentials
                return DataAccessLayer.ValidateLoginCredentials(username, password);
            }


            public BusinessLogicLayer()
            {
                dataAccess = new DataAccessLayer();
            }

            public bool IsAdminAccount(string username)
            {
                string role = dataAccess.GetUserRole(username);
                return string.Equals(role, "admin", StringComparison.OrdinalIgnoreCase);
            }


        }
    }
}
