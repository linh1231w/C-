using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.Model
{
    internal class KhachHangBEL
    {
        public string MaKhachHang { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }

        public override string ToString()
        {
            return Ten; // Trả về tên khách hàng để hiển thị trong ComboBox
        }
    }
}
