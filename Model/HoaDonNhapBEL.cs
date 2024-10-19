using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.Model
{
    internal class HoaDonNhapBEL
    {
        public string SoHoaDon { get; set; }
        public DateTime NgayNhap { get; set; }
        public DateTime NgayXuat { get; set; }
        public string NhaCungCap { get; set; }
        public int SoLuong { get; set; }
        public decimal Gia { get; set; }
        public decimal TongTien { get; set; }


        public KhachHangBEL Kh { get; set; }
        public string KhName
        {
            get { return Kh.Ten; }
        }

    }
}