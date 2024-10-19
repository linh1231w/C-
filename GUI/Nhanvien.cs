using DO_AN.BAL;
using DO_AN.DAL;
using DO_AN.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DO_AN
{
    public partial class Nhanvien : Form
    {
        NhanvienBAL NVBAL = new NhanvienBAL();
        public Nhanvien()
        {
            InitializeComponent();
            dgvqlsp.CellClick += dgvqlsp_CellClick;
            dgvqlsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            List<NhanvienBEL> lstsp = NVBAL.ReadSP();
            foreach (NhanvienBEL cus in lstsp)
            {
                dgvqlsp.Rows.Add(cus.MaNhanVien, cus.TenNhanVien, cus.GioiTinh, cus.NgaySinh, cus.SoDienThoai, cus.DiaChi);
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            NhanvienBEL nv = new NhanvienBEL();

            nv.TenNhanVien = lbtenhang.Text;
            nv.GioiTinh = checkBox1.Text;
            nv.NgaySinh = dateTimePicker1.Value;
            nv.SoDienThoai = tbtenanh.Text;
            nv.DiaChi = tbdongiaban.Text;




            OpenFileDialog openFileDialog = new OpenFileDialog();


            NVBAL.NewNV(nv);



            // Xóa toàn bộ dòng trong DataGridView để chuẩn bị load lại danh sách sản phẩm
            dgvqlsp.Rows.Clear();

            // Lấy danh sách tất cả sản phẩm từ cơ sở dữ liệu bằng cách gọi phương thức GetAllProducts() từ lớp SPBAL
            List<NhanvienBEL> allProducts = NVBAL.ReadSP();

            // Thêm lại tất cả sản phẩm vào DataGridView
            foreach (NhanvienBEL product in allProducts)
            {
                dgvqlsp.Rows.Add(product.MaNhanVien, product.TenNhanVien, product.GioiTinh, product.NgaySinh, product.SoDienThoai, product.DiaChi);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvqlsp.CurrentRow;
            if (row != null)
            {
                // Get the ID (MaNhanVien) of the employee from the first cell of the selected row
                int nvId = Convert.ToInt32(row.Cells[0].Value);

                string ID2 = lbmh.Text; // Giả sử ID2 là kiểu string chứa giá trị số
                int Id = Convert.ToInt32(ID2); // Ép kiểu string thành int


                // Create a new NhanvienBEL object and populate it with the updated values from UI controls
                if (Id != nvId)
                {
                    MessageBox.Show("Không thể thay đổi mã sinh viên.");
                    return;
                }

                // Create a new NhanvienBEL object and populate it with the updated values from UI controls
                NhanvienBEL nv = new NhanvienBEL();
                nv.MaNhanVien = Id;
                nv.TenNhanVien = lbtenhang.Text;
                if (checkBox1.Checked)
                {
                    nv.GioiTinh = "Nam";
                }
                else
                {
                    nv.GioiTinh = "Nữ";
                }
                nv.NgaySinh = dateTimePicker1.Value;
                nv.SoDienThoai = tbtenanh.Text;
                nv.DiaChi = tbdongiaban.Text;

                // Call the EditNV method in NVBAL to update the employee in the database
                NVBAL.EditNV(nv);

                // Clear the DataGridView and repopulate it with the updated data
                dgvqlsp.Rows.Clear();
                List<NhanvienBEL> allEmployees = NVBAL.ReadSP();
                foreach (NhanvienBEL employee in allEmployees)
                {
                    dgvqlsp.Rows.Add(employee.MaNhanVien, employee.TenNhanVien, employee.GioiTinh, employee.NgaySinh, employee.SoDienThoai, employee.DiaChi);
                }

                dateTimePicker1.Value = DateTime.Now;
                lbtenhang.Clear();
                tbtenanh.Clear();
                tbdongiaban.Clear();
                checkBox1.Checked = false;
                lbmh.Clear();
            }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {

            NhanvienBEL nv = new NhanvienBEL();
            nv.MaNhanVien = int.Parse(lbmh.Text);
            nv.TenNhanVien = lbtenhang.Text;
            nv.GioiTinh = checkBox1.Text;
            nv.NgaySinh = dateTimePicker1.Value;
            nv.SoDienThoai = tbtenanh.Text;
            nv.DiaChi = tbdongiaban.Text;





            NVBAL.DeletNV(nv);


            int idx = dgvqlsp.CurrentCell.RowIndex;
            dgvqlsp.Rows.RemoveAt(idx);


            dgvqlsp.Rows.Clear();

            // Lấy danh sách tất cả sản phẩm từ cơ sở dữ liệu bằng cách gọi phương thức GetAllProducts() từ lớp SPBAL
            List<NhanvienBEL> allProducts = NVBAL.ReadSP();

            // Thêm lại tất cả sản phẩm vào DataGridView
            foreach (NhanvienBEL product in allProducts)
            {
                dgvqlsp.Rows.Add(product.MaNhanVien, product.TenNhanVien, product.GioiTinh, product.NgaySinh, product.SoDienThoai, product.DiaChi);
            }

        }


        private void dgvqlsp_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView dgv && dgv.CurrentRow != null)
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv.Rows.Count)
                {
                    DataGridViewRow row = dgv.Rows[e.RowIndex];
                    // Lấy thông tin từ hàng hiện tại và hiển thị lên các điều khiển
                    lbmh.Text = row.Cells[0].Value?.ToString();
                    lbtenhang.Text = row.Cells[1].Value?.ToString();
                    checkBox1.Checked = (row.Cells[2].Value?.ToString() == "Nam");
                    // Chuyển đổi chuỗi ngày tháng thành kiểu DateTime và gán cho dateTimePicker1
                    if (DateTime.TryParse(row.Cells[3].Value?.ToString(), out DateTime dateValue))
                    {
                        dateTimePicker1.Value = dateValue;
                    }
                    tbtenanh.Text = row.Cells[4].Value?.ToString();
                    tbdongiaban.Text = row.Cells[5].Value?.ToString();



                }
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvqlsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbtenanh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
