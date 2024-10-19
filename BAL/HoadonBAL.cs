using DO_AN.DAL;
using DO_AN.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.BAL
{
    internal class HoadonBAL
    {
        HoadonDAL dal = new HoadonDAL();
        public List<HoaDonNhapBEL> ReadHD()
        {
            List<HoaDonNhapBEL> lstsp = dal.ReadHD();
            return lstsp;
        }



        public List<HoaDonNhapBEL> FindHoaDonBySoHoaDon(string SoHoaDon)
        {
            return dal.FindHoaDonBySoHoaDon(SoHoaDon);
        }







        public List<HoaDonNhapBEL> GetHoaDonFromExcel(string filePath)
        {
            return dal.ReadHoaDonFromExcel(filePath);
        }
        public bool HoaDonExists(string SoHoaDon)
        {
            return dal.HoaDonExists(SoHoaDon);
        }

        public bool SaveHoaDon(HoaDonNhapBEL SoHoaDon)
        {
            // Kiểm tra xem mã hóa đơn đã tồn tại trong cơ sở dữ liệu
            if (HoaDonExists(SoHoaDon.SoHoaDon))
            {
                return false; // Mã hóa đơn đã tồn tại, không lưu
            }

            return dal.SaveHoaDon(SoHoaDon);
        }



        public List<HoaDonNhapBEL> GetAllHoadon()
        {
            DataTable dataTable = dal.GetAllHoadon();
            List<HoaDonNhapBEL> hoadonList = new List<HoaDonNhapBEL>();

            foreach (DataRow row in dataTable.Rows)
            {
                HoaDonNhapBEL hoadon = new HoaDonNhapBEL();
                hoadon.SoHoaDon = row["SoHoaDon"].ToString();
                hoadon.NgayNhap = Convert.ToDateTime(row["NgayNhap"]);
                hoadon.NgayXuat = Convert.ToDateTime(row["NgayXuat"]);
                hoadon.NhaCungCap = row["NhaCungCap"].ToString();
                hoadon.SoLuong = Convert.ToInt32(row["SoLuong"]);
                hoadon.Gia = Convert.ToDecimal(row["Gia"]);
                hoadon.TongTien = Convert.ToDecimal(row["TongTien"]);

                hoadonList.Add(hoadon);
            }

            return hoadonList;
        }






        public bool DeleteInvoice(HoaDonNhapBEL hd)
        {
            return dal.DeleteInvoice(hd);
        }

        public bool AddNewInvoice(HoaDonNhapBEL hd)
        {
            return dal.AddNewInvoice(hd);
        }

        public bool UpdateInvoice(HoaDonNhapBEL hd)
        {
            return dal.UpdateInvoice(hd);
        }

    }
}