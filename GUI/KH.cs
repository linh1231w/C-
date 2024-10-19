using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN
{
    public partial class KH : Form
    {
        public KH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KH_Load(object sender, EventArgs e)
        {
            // Khi form được load, đoạn code này sẽ chạy
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-F61L4C7\SQLEXPRESS;Initial Catalog=QLBH;User ID=sa;Password=sa");

            // Mở kết nối đến cơ sở dữ liệu
            conn.Open();

            // Tạo một đối tượng SqlCommand để thực thi câu truy vấn
            SqlCommand cmd = new SqlCommand("select * from KhachHang", conn);

            // Thực thi câu truy vấn và lưu kết quả vào một SqlDataReader
            SqlDataReader reader = cmd.ExecuteReader();

            // Kiểm tra xem có dữ liệu trả về không
            if (reader.HasRows)
            {
                // Nếu có dữ liệu, lặp qua từng dòng dữ liệu
                while (reader.Read())
                {
                    // Lấy giá trị từ các cột và thêm vào DataGridView
                    drvKhachHang.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }
            }

            // Đóng kết nối đến cơ sở dữ liệu
            conn.Close();
        }

        private void tbId_Click(object sender, EventArgs e)
        {

        }
    }
}
