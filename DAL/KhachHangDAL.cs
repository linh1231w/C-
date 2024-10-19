using DO_AN.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.DAL
{
    internal class KhachHangDAL : DBConection
    {


        public List<KhachHangBEL> ReadAreaList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from KhachHang", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<KhachHangBEL> lstArea = new List<KhachHangBEL>();
            while (reader.Read())
            {
                KhachHangBEL area = new KhachHangBEL();
                area.MaKhachHang = reader["MaKhachHang"].ToString();
                area.Ten = reader["Ten"].ToString();
                lstArea.Add(area);
            }
            conn.Close();
            return lstArea;
        }
        public KhachHangBEL ReadArea(int id)
        {
            KhachHangBEL area = new KhachHangBEL();

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang WHERE MaKhachHang = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows && reader.Read())
                        {
                            area.MaKhachHang = reader["MaKhachHang"].ToString();
                            area.Ten = reader["Ten"].ToString();
                        }
                    }
                }
            }

            return area;
        }

        public bool CheckKhachHangExists(string maKhachHang)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM KhachHang WHERE MaKhachHang = @MaKhachHang", conn);
                cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }






        /// <summary>
        /// /////////
        /// </summary>
        /// <returns></returns>

        public List<KhachHangBEL> ReadSP()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<KhachHangBEL> lstsp = new List<KhachHangBEL>();

            while (reader.Read())
            {
                KhachHangBEL nv = new KhachHangBEL();
                nv.MaKhachHang = reader["MaKhachHang"].ToString();
                nv.Ten = reader["Ten"].ToString();

                nv.DiaChi = reader["DiaChi"].ToString();
                nv.DienThoai = reader["DienThoai"].ToString();
                lstsp.Add(nv);
            }
            conn.Close();
            return lstsp;
        }




        public void DeleteNV(KhachHangBEL nv)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete  from KhachHang where MaKhachHang = @MaKhachHang", conn);
            cmd.Parameters.Add(new SqlParameter("@MaKhachHang", nv.MaKhachHang));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void NewNV(KhachHangBEL nv)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO KhachHang (MaKhachHang,Ten, DienThoai, DiaChi) VALUES (@MaKhachHang,@Ten, @DienThoai, @DiaChi)", conn);
            cmd.Parameters.Add(new SqlParameter("@MaKhachHang", nv.MaKhachHang));
            cmd.Parameters.Add(new SqlParameter("@Ten", nv.Ten));

            cmd.Parameters.Add(new SqlParameter("@DienThoai", nv.DienThoai));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", nv.DiaChi));

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EditNV(KhachHangBEL nv)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update KhachHang set  @MaKhachHang=MaKhachHang,  Ten = @Ten, DiaChi = @DiaChi, DienThoai = @DienThoai where MaKhachHang= @MaKhachHang", conn);
            cmd.Parameters.Add(new SqlParameter("@MaKhachHang", nv.MaKhachHang)); // Fix this line
            cmd.Parameters.Add(new SqlParameter("@Ten", nv.Ten));


            cmd.Parameters.Add(new SqlParameter("@DienThoai", nv.DienThoai));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", nv.DiaChi));

            cmd.ExecuteNonQuery();
            conn.Close();
        }







    }
}
