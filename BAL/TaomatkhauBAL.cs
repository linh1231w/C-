using DO_AN.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.BAL
{
    internal class TaomatkhauBAL
    {
        TaomatkhauDAL dal = new TaomatkhauDAL();

        internal void UpdatePasswordInDatabase(string email, string Password)
        {
            dal.UpdatePasswordInDatabase(email, Password);
        }
    }
}
