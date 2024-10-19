using DO_AN.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.DAL
{
    internal class sanphamDAL : DBConection

    {
        public bool CheckProductIdExists(int Masanpham1)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM sanpham WHERE MaSanPham = @Masanpham1", conn);
                cmd.Parameters.AddWithValue("@Masanpham1", Masanpham1);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        public List<sanpham> ReadSP()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from SanPham", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<sanpham> lstsp = new List<sanpham>();

            while (reader.Read())
            {
                sanpham sp = new sanpham();
                sp.MaSanPham = int.Parse(reader["MaSanPham"].ToString());
                sp.TenSanPham = reader["TenSanPham"].ToString();
                sp.DonGia = decimal.Parse(reader["DonGia"].ToString());
                sp.Dongiaban = decimal.Parse(reader["Dongiaban"].ToString());
                sp.SoLuongTrongKho = int.Parse(reader["SoLuongTrongKho"].ToString());
                sp.Image = reader["Image"].ToString();
                sp.GhiChu = reader["GhiChu"].ToString();

                lstsp.Add(sp);
            }
            conn.Close();
            return lstsp;
        }

        public void DeleteCustomer(sanpham sp)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete  from SanPham where MaSanPham = @MaSanPham", conn);
            cmd.Parameters.Add(new SqlParameter("@MaSanPham", sp.MaSanPham));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void NewCustomer(sanpham sp)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO SanPham (TenSanPham, DonGia, Dongiaban, SoLuongTrongKho, Image, GhiChu) VALUES (@TenSanPham, @DonGia, @Dongiaban, @SoLuongTrongKho, @Image, @GhiChu)", conn);
                cmd.Parameters.Add(new SqlParameter("@TenSanPham", SqlDbType.NVarChar) { Value = sp.TenSanPham });
                cmd.Parameters.Add(new SqlParameter("@DonGia", SqlDbType.Decimal) { Value = sp.DonGia });
                cmd.Parameters.Add(new SqlParameter("@Dongiaban", SqlDbType.Decimal) { Value = sp.Dongiaban });
                cmd.Parameters.Add(new SqlParameter("@SoLuongTrongKho", SqlDbType.Int) { Value = sp.SoLuongTrongKho });
                cmd.Parameters.Add(new SqlParameter("@Image", SqlDbType.NVarChar) { Value = sp.Image });
                cmd.Parameters.Add(new SqlParameter("@GhiChu", SqlDbType.NVarChar) { Value = sp.GhiChu });

                cmd.ExecuteNonQuery();
            } // Khi khối using kết thúc, kết nối sẽ tự động được đóng
        }

        public void EditCustomer(sanpham sp)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update SanPham set  TenSanPham = @TenSanPham, DonGia = @DonGia, Dongiaban = @Dongiaban, SoLuongTrongKho = @SoLuongTrongKho, Image = @Image, GhiChu = @GhiChu where MaSanPham = @MaSanPham", conn);
            cmd.Parameters.Add(new SqlParameter("@MaSanPham", sp.MaSanPham)); // Fix this line
            cmd.Parameters.Add(new SqlParameter("@TenSanPham", sp.TenSanPham));
            cmd.Parameters.Add(new SqlParameter("@DonGia", sp.DonGia));
            cmd.Parameters.Add(new SqlParameter("@Dongiaban", sp.Dongiaban));
            cmd.Parameters.Add(new SqlParameter("@SoLuongTrongKho", sp.SoLuongTrongKho));
            cmd.Parameters.Add(new SqlParameter("@Image", sp.Image));
            cmd.Parameters.Add(new SqlParameter("@GhiChu", sp.GhiChu));

            cmd.ExecuteNonQuery();
            conn.Close();
        }




    }
}
