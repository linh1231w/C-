using DO_AN.DAL;
using DO_AN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.BAL
{
    internal class sanphamBAL
    {
        sanphamDAL dal = new sanphamDAL();
        public List<sanpham> ReadSP()
        {
            List<sanpham> lstsp = dal.ReadSP();
            return lstsp;
        }
        public void NewCustomer(sanpham sp)
        {
            dal.NewCustomer(sp);
        }
        public void DeletECustomer(sanpham sp)
        {
            dal.DeleteCustomer(sp);
        }
        public void EditCustomer(sanpham sp)
        {
            dal.EditCustomer(sp);
        }
        public bool CheckProductIdExists(int Masanpham1)
        {
            return dal.CheckProductIdExists(Masanpham1);
        }


    }
}
