using DO_AN.Model;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.DAL
{
    internal class HoadonDAL : DBConection
    {
        public List<HoaDonNhapBEL> ReadHD()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Orders.*, KhachHang.Ten FROM Orders INNER JOIN KhachHang ON Orders.NhaCungCap = KhachHang.MaKhachHang", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<HoaDonNhapBEL> lstsp = new List<HoaDonNhapBEL>();
            KhachHangDAL khachHangDAL = new KhachHangDAL();

            while (reader.Read())
            {
                HoaDonNhapBEL nv = new HoaDonNhapBEL();

                nv.SoHoaDon = reader["SoHoaDon"].ToString();
                nv.NgayNhap = DateTime.Parse(reader["NgayNhap"].ToString());
                nv.NgayXuat = DateTime.Parse(reader["NgayXuat"].ToString());

                // Lấy tên khách hàng từ cột "Ten"
                nv.NhaCungCap = reader["Ten"].ToString();



                nv.SoLuong = int.Parse(reader["SoLuong"].ToString());
                nv.Gia = decimal.Parse(reader["Gia"].ToString());
                nv.TongTien = decimal.Parse(reader["TongTien"].ToString());
                lstsp.Add(nv);
            }
            conn.Close();
            return lstsp;
        }



        public List<HoaDonNhapBEL> FindHoaDonBySoHoaDon(string SoHoaDon)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Orders WHERE SoHoaDon = @SoHoaDon", conn);
            cmd.Parameters.AddWithValue("@SoHoaDon", SoHoaDon);

            SqlDataReader reader = cmd.ExecuteReader();
            List<HoaDonNhapBEL> searchResults = new List<HoaDonNhapBEL>();

            while (reader.Read())
            {
                HoaDonNhapBEL hoaDon = new HoaDonNhapBEL
                {
                    SoHoaDon = reader["SoHoaDon"].ToString(),
                    NgayNhap = DateTime.Parse(reader["NgayNhap"].ToString()),
                    NhaCungCap = reader["NhaCungCap"].ToString(),
                    SoLuong = int.Parse(reader["SoLuong"].ToString()),
                    Gia = decimal.Parse(reader["Gia"].ToString()),
                    TongTien = decimal.Parse(reader["TongTien"].ToString())
                };

                searchResults.Add(hoaDon);
            }

            conn.Close();
            return searchResults;
        }





        public List<HoaDonNhapBEL> ReadHoaDonFromExcel(string filePath)
        {
            List<HoaDonNhapBEL> hoaDonList = new List<HoaDonNhapBEL>();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    string SoHoaDon = worksheet.Cells[row, 1].Value?.ToString();
                    DateTime? ngayNhap = worksheet.Cells[row, 2].GetValue<DateTime?>(); // Sử dụng GetValue để đọc ngày tháng từ ô Excel
                    DateTime? ngayXuat = worksheet.Cells[row, 3].GetValue<DateTime?>();

                    if (ngayNhap.HasValue && ngayXuat.HasValue)
                    {
                        string NhaCungCap = worksheet.Cells[row, 4].Value?.ToString();
                        int soLuong = int.TryParse(worksheet.Cells[row, 5].Value?.ToString(), out int parsedSoLuong) ? parsedSoLuong : 0;
                        decimal gia = decimal.TryParse(worksheet.Cells[row, 6].Value?.ToString(), out decimal parsedGia) ? parsedGia : 0;
                        decimal tongTien = decimal.TryParse(worksheet.Cells[row, 7].Value?.ToString(), out decimal parsedTongTien) ? parsedTongTien : 0;

                        hoaDonList.Add(new HoaDonNhapBEL
                        {
                            SoHoaDon = SoHoaDon,
                            NgayNhap = ngayNhap.Value,
                            NgayXuat = ngayXuat.Value,
                            NhaCungCap = NhaCungCap,
                            SoLuong = soLuong,
                            Gia = gia,
                            TongTien = tongTien
                        });
                    }
                }

                return hoaDonList;
            }
        }



        public bool HoaDonExists(string SoHoaDon)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();


            string query = "SELECT COUNT(*) FROM Orders WHERE SoHoaDon = @SoHoaDon";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@SoHoaDon", SoHoaDon);

            int count = Convert.ToInt32(command.ExecuteScalar());
            return count > 0;

        }

        public bool SaveHoaDon(HoaDonNhapBEL SoHoaDon)
        {

            // Kiểm tra giá trị ngày nhập và ngày xuất

            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();

                string query = "INSERT INTO Orders (SoHoaDon, NgayNhap, NgayXuat, NhaCungCap, Gia, SoLuong, TongTien) " +
                               "VALUES (@SoHoaDon, @NgayNhap, @NgayXuat, @NhaCungCap, @Gia, @SoLuong, @TongTien)";

                using (SqlCommand command = new SqlCommand(query, conn))
                {

                    command.Parameters.AddWithValue("@SoHoaDon", SoHoaDon.SoHoaDon);
                    if (SoHoaDon.NgayNhap != DateTime.MinValue)
                    {
                        DateTime Ngaynhap = SoHoaDon.NgayNhap;
                        string NgayNhapFormatted = Ngaynhap.ToString("yyyy-MM-dd");
                        command.Parameters.AddWithValue("@NgayNhap", NgayNhapFormatted);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@NgayNhap", DBNull.Value);
                    }

                    if (SoHoaDon.NgayXuat != DateTime.MinValue)
                    {
                        DateTime ngayXuat = SoHoaDon.NgayXuat;
                        string ngayXuatFormatted = ngayXuat.ToString("yyyy-MM-dd");
                        command.Parameters.AddWithValue("@NgayXuat", ngayXuatFormatted);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@NgayXuat", DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@NhaCungCap", SoHoaDon.NhaCungCap);
                    command.Parameters.AddWithValue("@Gia", SoHoaDon.Gia);
                    command.Parameters.AddWithValue("@SoLuong", SoHoaDon.SoLuong);
                    command.Parameters.AddWithValue("@TongTien", SoHoaDon.TongTien);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

        }


        public DataTable GetAllHoadon()
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Orders", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }




        public bool DeleteInvoice(HoaDonNhapBEL hd)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Orders WHERE SoHoaDon = @SoHoaDon", conn);
            cmd.Parameters.Add(new SqlParameter("@SoHoaDon", hd.SoHoaDon));

            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
        }

        public bool AddNewInvoice(HoaDonNhapBEL hd)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Orders (SoHoaDon, NgayNhap, NgayXuat, NhaCungCap, SoLuong, Gia, TongTien) VALUES (@SoHoaDon, @NgayNhap, @NgayXuat, @NhaCungCap, @SoLuong, @Gia, @TongTien)", conn);
                cmd.Parameters.Add(new SqlParameter("@SoHoaDon", SqlDbType.NVarChar) { Value = hd.SoHoaDon });
                if (hd.NgayNhap != DateTime.MinValue)
                {
                    DateTime Ngaynhap = hd.NgayNhap;
                    string NgayNhapFormatted = Ngaynhap.ToString("yyyy-MM-dd");
                    cmd.Parameters.AddWithValue("@NgayNhap", NgayNhapFormatted);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NgayNhap", DBNull.Value);
                }

                if (hd.NgayXuat != DateTime.MinValue)
                {
                    DateTime ngayXuat = hd.NgayXuat;
                    string ngayXuatFormatted = ngayXuat.ToString("yyyy-MM-dd");
                    cmd.Parameters.AddWithValue("@NgayXuat", ngayXuatFormatted);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NgayXuat", DBNull.Value);
                }
                cmd.Parameters.Add(new SqlParameter("@NhaCungCap", SqlDbType.NVarChar) { Value = hd.Kh.MaKhachHang });
                cmd.Parameters.Add(new SqlParameter("@SoLuong", SqlDbType.Int) { Value = hd.SoLuong });
                cmd.Parameters.Add(new SqlParameter("@Gia", SqlDbType.Decimal) { Value = hd.Gia });
                cmd.Parameters.Add(new SqlParameter("@TongTien", SqlDbType.Decimal) { Value = hd.TongTien });

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            } // Khi khối using kết thúc, kết nối sẽ tự động được đóng
        }

        public bool UpdateInvoice(HoaDonNhapBEL hd)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Orders SET NgayNhap = @NgayNhap, NgayXuat = @NgayXuat, NhaCungCap = @NhaCungCap, SoLuong = @SoLuong, Gia = @Gia, TongTien = @TongTien WHERE SoHoaDon = @SoHoaDon", conn);
                cmd.Parameters.AddWithValue("@NgayNhap", hd.NgayNhap);
                cmd.Parameters.AddWithValue("@NgayXuat", hd.NgayXuat);
                cmd.Parameters.AddWithValue("@NhaCungCap", hd.Kh.MaKhachHang);
                cmd.Parameters.AddWithValue("@SoLuong", hd.SoLuong);
                cmd.Parameters.AddWithValue("@Gia", hd.Gia);
                cmd.Parameters.AddWithValue("@TongTien", hd.TongTien);
                cmd.Parameters.AddWithValue("@SoHoaDon", hd.SoHoaDon);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }






    }
}