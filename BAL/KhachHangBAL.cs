using DO_AN.DAL;
using DO_AN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.BAL
{
    internal class KhachHangBAL
    {

        KhachHangDAL dal = new KhachHangDAL();
        public List<KhachHangBEL> ReadAreaList()
        {
            List<KhachHangBEL> lstArea = dal.ReadAreaList();
            return lstArea;
        }

        public bool CheckKhachHangExists(string maKhachHang)
        {
            return dal.CheckKhachHangExists(maKhachHang);
        }


        public List<KhachHangBEL> ReadSP()
        {
            List<KhachHangBEL> lstsp = dal.ReadSP();
            return lstsp;
        }


        public void NewNV(KhachHangBEL nv)
        {
            dal.NewNV(nv);
        }
        public void DeletNV(KhachHangBEL nv)
        {
            dal.DeleteNV(nv);
        }
        public void EditNV(KhachHangBEL nv)
        {
            dal.EditNV(nv);
        }


    }
}










