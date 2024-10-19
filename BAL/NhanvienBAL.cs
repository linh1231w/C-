using DO_AN.DAL;
using DO_AN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.BAL
{
    internal class NhanvienBAL
    {
        NhanvienDAL dal = new NhanvienDAL();
        public List<NhanvienBEL> ReadSP()
        {
            List<NhanvienBEL> lstsp = dal.ReadSP();
            return lstsp;
        }


        public void NewNV(NhanvienBEL nv)
        {
            dal.NewNV(nv);
        }
        public void DeletNV(NhanvienBEL nv)
        {
            dal.DeleteNV(nv);
        }
        public void EditNV(NhanvienBEL nv)
        {
            dal.EditNV(nv);
        }
    }
}
