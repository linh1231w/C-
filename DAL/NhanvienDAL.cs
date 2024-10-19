using DO_AN.BAL;
using DO_AN.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.DAL
{
    internal class NhanvienDAL : DBConection
    {
        public List<NhanvienBEL> ReadSP()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<NhanvienBEL> lstsp = new List<NhanvienBEL>();

            while (reader.Read())
            {
                NhanvienBEL nv = new NhanvienBEL();
                nv.MaNhanVien = int.Parse(reader["MaNhanVien"].ToString());
                nv.TenNhanVien = reader["TenNhanVien"].ToString();
                nv.GioiTinh = reader["GioiTinh"].ToString();
                nv.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                nv.SoDienThoai = reader["SoDienThoai"].ToString();
                nv.DiaChi = reader["DiaChi"].ToString();
                lstsp.Add(nv);
            }
            conn.Close();
            return lstsp;
        }




        public void DeleteNV(NhanvienBEL nv)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete  from NhanVien where MaNhanVien = @MaNhanVien", conn);
            cmd.Parameters.Add(new SqlParameter("@MaNhanVien", nv.MaNhanVien));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void NewNV(NhanvienBEL nv)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien (TenNhanVien, GioiTinh, NgaySinh, SoDienThoai, DiaChi) VALUES (@TenNhanVien, @GioiTinh, @NgaySinh, @SoDienThoai, @DiaChi)", conn);
            cmd.Parameters.Add(new SqlParameter("@TenNhanVien", nv.TenNhanVien));
            cmd.Parameters.Add(new SqlParameter("@GioiTinh", nv.GioiTinh));
            cmd.Parameters.Add(new SqlParameter("@NgaySinh", nv.NgaySinh));
            cmd.Parameters.Add(new SqlParameter("@SoDienThoai", nv.SoDienThoai));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", nv.DiaChi));

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EditNV(NhanvienBEL nv)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update NhanVien set TenNhanVien = @TenNhanVien, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, SoDienThoai = @SoDienThoai, DiaChi = @DiaChi where MaNhanVien= @MaNhanVien", conn);
            cmd.Parameters.Add(new SqlParameter("@MaNhanVien", nv.MaNhanVien)); // Fix this line
            cmd.Parameters.Add(new SqlParameter("@TenNhanVien", nv.TenNhanVien));
            cmd.Parameters.Add(new SqlParameter("@GioiTinh", nv.GioiTinh));
            cmd.Parameters.Add(new SqlParameter("@NgaySinh", nv.NgaySinh));
            cmd.Parameters.Add(new SqlParameter("@SoDienThoai", nv.SoDienThoai));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", nv.DiaChi));

            cmd.ExecuteNonQuery();
            conn.Close();
        }


    }
}
