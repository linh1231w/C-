using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.Model
{
    internal class NhanvienBEL
    {
        public int MaNhanVien { get; set; }
        public string? TenNhanVien { get; set; }
        public string? GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string? SoDienThoai { get; set; }
        public string? DiaChi { get; set; }
    }
}
