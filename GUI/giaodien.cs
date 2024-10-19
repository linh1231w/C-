using DO_AN.BAL;
using DO_AN.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN
{
    public partial class giaodien : Form
    {
        sanphamBAL SPBAL = new sanphamBAL();

        public giaodien()
        {
            InitializeComponent();
            dgvqlsp.CellClick += dgvqlsp_CellClick;
            dgvqlsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void giaodien_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            lbmh.Visible = false;
            List<sanpham> lstsp = SPBAL.ReadSP();
            foreach (sanpham cus in lstsp)
            {
                dgvqlsp.Rows.Add(cus.MaSanPham, cus.TenSanPham, cus.SoLuongTrongKho, cus.DonGia, cus.Dongiaban, cus.Image, cus.GhiChu);


            }

        }

        private void btNew_Click(object sender, EventArgs e)
        {
            sanpham sp = new sanpham();

            sp.TenSanPham = lbtenhang.Text;
            sp.SoLuongTrongKho = int.Parse(tbhangton.Text);
            sp.DonGia = decimal.Parse(tbdongianhap.Text);
            sp.Dongiaban = decimal.Parse(tbdongiaban.Text);
            sp.Image = tbtenanh.Text;





            sp.GhiChu = Lghichu.Text;

            OpenFileDialog openFileDialog = new OpenFileDialog();


            SPBAL.NewCustomer(sp);



            // Xóa toàn bộ dòng trong DataGridView để chuẩn bị load lại danh sách sản phẩm
            dgvqlsp.Rows.Clear();

            // Lấy danh sách tất cả sản phẩm từ cơ sở dữ liệu bằng cách gọi phương thức GetAllProducts() từ lớp SPBAL
            List<sanpham> allProducts = SPBAL.ReadSP();


            // Thêm lại tất cả sản phẩm vào DataGridView
            foreach (sanpham product in allProducts)
            {
                dgvqlsp.Rows.Add(product.MaSanPham, product.TenSanPham, product.SoLuongTrongKho, product.DonGia, product.Dongiaban, product.Image, product.GhiChu);
            }

        }




        private void btDelete_Click(object sender, EventArgs e)
        {
            sanpham sp = new sanpham();
            sp.MaSanPham = int.Parse(lbmh.Text);
            sp.TenSanPham = lbtenhang.Text;
            sp.SoLuongTrongKho = int.Parse(tbhangton.Text);
            sp.DonGia = decimal.Parse(tbdongianhap.Text);
            sp.Dongiaban = decimal.Parse(tbdongiaban.Text);
            sp.Image = tbtenanh.Text;



            sp.GhiChu = Lghichu.Text;
            SPBAL.DeletECustomer(sp);


            int idx = dgvqlsp.CurrentCell.RowIndex;
            dgvqlsp.Rows.RemoveAt(idx);
            // Xóa toàn bộ dòng trong DataGridView để chuẩn bị load lại danh sách sản phẩm
            dgvqlsp.Rows.Clear();

            // Lấy danh sách tất cả sản phẩm từ cơ sở dữ liệu bằng cách gọi phương thức GetAllProducts() từ lớp SPBAL
            List<sanpham> allProducts = SPBAL.ReadSP();


            // Thêm lại tất cả sản phẩm vào DataGridView
            foreach (sanpham product in allProducts)
            {
                dgvqlsp.Rows.Add(product.MaSanPham, product.TenSanPham, product.SoLuongTrongKho, product.DonGia, product.Dongiaban, product.Image, product.GhiChu);
            }

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvqlsp.CurrentRow;
            if (row != null)
            {
                // Get the ID (MaSanPham) of the product from the first cell of the selected row
                int Masanpham1 = Convert.ToInt32(row.Cells[0].Value);

                int newMaSanPham = int.Parse(lbmh.Text); // Example: replace tbxNewMaSanPham with the actual UI control you're using

                if (newMaSanPham != Masanpham1)
                {
                    MessageBox.Show("Bạn không được phép thay đổi mã sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new sanpham object and populate it with the updated values from UI controls
                sanpham sp = new sanpham
                {

                    MaSanPham = Masanpham1, // Keep the original Product ID without modification
                    TenSanPham = lbtenhang.Text,
                    SoLuongTrongKho = int.Parse(tbhangton.Text),
                    DonGia = decimal.Parse(tbdongianhap.Text),
                    Dongiaban = decimal.Parse(tbdongiaban.Text),
                    Image = tbtenanh.Text,
                    GhiChu = Lghichu.Text
                };


                // Call the EditCustomer method in SPBAL to update the product in the database
                SPBAL.EditCustomer(sp);

                // Clear the DataGridView and repopulate it with the updated data
                dgvqlsp.Rows.Clear();
                List<sanpham> allProducts = SPBAL.ReadSP();
                foreach (sanpham product in allProducts)
                {

                    dgvqlsp.Rows.Add(product.MaSanPham, product.TenSanPham, product.SoLuongTrongKho, product.DonGia, product.Dongiaban, product.Image, product.GhiChu);
                }
            }
        }

        private void dgvqlsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvqlsp_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView dgv && dgv.CurrentRow != null)
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvqlsp.Rows.Count)
                {
                    DataGridViewRow row = dgvqlsp.Rows[e.RowIndex];

                    if (!string.IsNullOrEmpty(row.Cells[0].Value?.ToString()))
                    {
                        lbmh.Text = row.Cells[0].Value?.ToString();
                        lbmh.Visible = true; // Hiển thị TextBox ID
                        label1.Visible = true;                // Hiển thị thông tin của dòng được chọn lên các điều khiển khác
                        lbtenhang.Text = row.Cells[1].Value?.ToString();
                        tbhangton.Text = row.Cells[2].Value?.ToString();
                        tbdongianhap.Text = row.Cells[3].Value?.ToString();
                        tbdongiaban.Text = row.Cells[4].Value?.ToString();
                        tbtenanh.Text = row.Cells[5].Value?.ToString();
                        Lghichu.Text = row.Cells[6].Value?.ToString();
                        // Lấy tên tệp ảnh từ cột "TenAnh" của hàng hiện tại
                        string selectedImageFileName = row.Cells["Column7"].Value?.ToString();

                        // Nếu tên tệp ảnh không rỗng, hiển thị hình ảnh trong PictureBox
                        if (!string.IsNullOrEmpty(selectedImageFileName))
                        {
                            string imagePath = @"C:\Users\nghie\Desktop\LeQuocNghiem_2121110155_C#\Imgae\" + selectedImageFileName;// Thay đổi đường dẫn ở đây
                            if (File.Exists(imagePath))
                            {
                                PicAnh.Image = Image.FromFile(imagePath);
                                PicAnh.SizeMode = PictureBoxSizeMode.Zoom; // You can adjust the picturebox size mode as needed
                            }
                            else
                            {
                                // Nếu không tìm thấy tệp ảnh, xóa hình ảnh trong PictureBox
                                PicAnh.Image = null;
                            }
                        }
                        else
                        {
                            // Nếu không có tên tệp ảnh, xóa hình ảnh trong PictureBox
                            PicAnh.Image = null;
                        }
                    }
                    else
                    {
                        label1.Visible = false;
                        lbmh.Visible = false; // Ẩn TextBox ID
                        lbmh.Clear();
                        lbtenhang.Clear();
                        tbhangton.Clear();
                        tbdongianhap.Clear();
                        tbdongiaban.Clear();
                        tbtenanh.Clear();
                        Lghichu.Clear();
                        PicAnh.Image = null;

                    }
                }


            }
        }

        private void btMo_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại mở tệp
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                tbtenanh.Text = openFileDialog.SafeFileName;

                // Kiểm tra xem tệp được chọn có phải là tệp ảnh hợp lệ hay không
                string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
                string fileExtension = Path.GetExtension(selectedImagePath).ToLower();

                if (allowedExtensions.Contains(fileExtension))
                {
                    // Kiểm tra xem kích thước tệp có lớn hơn 500KB không
                    long fileSize = new FileInfo(selectedImagePath).Length;
                    long maxSize = 500 * 1024; // 500 KB trong byte

                    if (fileSize <= maxSize)
                    {
                        PicAnh.Image = Image.FromFile(selectedImagePath);
                        PicAnh.SizeMode = PictureBoxSizeMode.Zoom;

                        string targetFolderPath = @"C:\Users\user\Desktop\DO AN\DO AN\Resources\";
                        if (!Directory.Exists(targetFolderPath))
                        {
                            Directory.CreateDirectory(targetFolderPath);
                        }

                        string targetImagePath = Path.Combine(targetFolderPath, tbtenanh.Text);

                        int count = 1;
                        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(tbtenanh.Text);

                        while (File.Exists(targetImagePath))
                        {
                            tbtenanh.Text = $"{fileNameWithoutExtension}_{count}{fileExtension}";
                            targetImagePath = Path.Combine(targetFolderPath, tbtenanh.Text);
                            count++;
                        }

                        File.Copy(selectedImagePath, targetImagePath);
                    }
                    else
                    {
                        MessageBox.Show("Kích thước tệp quá lớn. Kích thước tối đa cho phép là 500KB.");
                    }
                }
                else
                {
                    MessageBox.Show("Tệp được chọn không phải là hình ảnh hợp lệ.");
                }
            }
        }



        private void Lghichu_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicAnh_Click(object sender, EventArgs e)
        {

        }
    }
}