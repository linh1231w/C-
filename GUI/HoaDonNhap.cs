using DO_AN.BAL;
using DO_AN.Model;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DO_AN
{
    public partial class HoaDonNhap : Form
    {
        HoadonBAL HDBAL = new HoadonBAL();
        KhachHangBAL KHBAL = new KhachHangBAL();



        public HoaDonNhap()
        {
            InitializeComponent();
            dgvHDBanHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            luu.Visible = false;
            dgvHDBanHang.CellClick += dgvHDBanHang_CellClick;
        }

        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            List<HoaDonNhapBEL> lstsp = HDBAL.ReadHD();
            foreach (HoaDonNhapBEL cus in lstsp)
            {
                dgvHDBanHang.Rows.Add(cus.SoHoaDon, cus.NgayNhap, cus.NgayXuat, cus.NhaCungCap, cus.Gia, cus.SoLuong, cus.TongTien);


            }
            List<KhachHangBEL> lstArea = KHBAL.ReadAreaList();
            foreach (KhachHangBEL HoaDon in lstArea)
            {
                comboBox1.Items.Add(HoaDon.Ten);
            }


        }

        private void moform()
        {
            SearchForm searchForm = new SearchForm(this);
            searchForm.ShowDialog();
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            moform();
        }

        public void SearchHoaDon(string SoHoaDon)
        {
            List<HoaDonNhapBEL> searchResults = HDBAL.FindHoaDonBySoHoaDon(SoHoaDon);

            if (searchResults.Count > 0)
            {
                dgvHDBanHang.Rows.Clear();


                foreach (HoaDonNhapBEL cus in searchResults)
                {
                    dgvHDBanHang.Rows.Add(cus.SoHoaDon, cus.NgayNhap, cus.NgayXuat, cus.NhaCungCap, cus.Gia, cus.SoLuong, cus.TongTien);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn với mã đã nhập.");
                LoadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
            luu.Visible = false;
        }

        private void LoadData()
        {
            dgvHDBanHang.Rows.Clear();

            List<HoaDonNhapBEL> lstsp = HDBAL.ReadHD();
            foreach (HoaDonNhapBEL cus in lstsp)
            {
                dgvHDBanHang.Rows.Add(cus.SoHoaDon, cus.NgayNhap, cus.NgayXuat, cus.NhaCungCap, cus.Gia, cus.SoLuong, cus.TongTien);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private BindingList<HoaDonNhapBEL> hoaDonBindingList = new BindingList<HoaDonNhapBEL>();

        private void nhậpExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.Title = "Chọn tệp Excel";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Kiểm tra phần mở rộng của tệp
                string fileExtension = Path.GetExtension(filePath).ToLower();
                if (fileExtension != ".xls" && fileExtension != ".xlsx" && fileExtension != ".xlsm")
                {
                    MessageBox.Show("Vui lòng chọn tệp Excel có định dạng .xls, .xlsx hoặc .xlsm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<HoaDonNhapBEL> hoaDonList = HDBAL.GetHoaDonFromExcel(filePath);

                foreach (var hoaDon in hoaDonList)
                {
                    // Kiểm tra xem có giá trị null hoặc rỗng trong hàng dữ liệu hay không
                    if (hoaDon.NgayNhap == DateTime.MinValue || hoaDon.NgayXuat == DateTime.MinValue ||
                        string.IsNullOrWhiteSpace(hoaDon.SoHoaDon) || string.IsNullOrWhiteSpace(hoaDon.NhaCungCap))
                    {
                        MessageBox.Show("Hàng dữ liệu có giá trị NULL hoặc rỗng. Hãy kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue; // Bỏ qua dòng dữ liệu này và chuyển sang dòng tiếp theo
                    }

                    string newMaHoaDon = hoaDon.SoHoaDon;

                    // Kiểm tra xem mã hóa đơn đã tồn tại trong DataGridView chưa
                    if (MaHoaDonExists(newMaHoaDon))
                    {
                        // Mã đã tồn tại, bỏ qua dòng dữ liệu này
                        MessageBox.Show($"Mã hóa đơn '{newMaHoaDon}' đã tồn tại trong danh sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue; // Bỏ qua dòng dữ liệu trùng và chuyển sang dòng tiếp theo
                    }

                    // Mã không tồn tại và dữ liệu hợp lệ, thêm vào DataGridView
                    DataGridViewRow newRow = dgvHDBanHang.Rows[dgvHDBanHang.Rows.Add()];
                    // Ánh xạ tên cột từ Excel sang tên cột trong DataGridView
                    newRow.Cells["Column1"].Value = hoaDon.SoHoaDon;
                    newRow.Cells["Column2"].Value = hoaDon.NgayNhap;
                    newRow.Cells["Column3"].Value = hoaDon.NgayXuat;
                    newRow.Cells["Column4"].Value = hoaDon.NhaCungCap;
                    newRow.Cells["Column7"].Value = hoaDon.Gia;
                    newRow.Cells["Column6"].Value = hoaDon.SoLuong;
                    newRow.Cells["Column5"].Value = hoaDon.TongTien;
                }
                luu.Visible = true;
            }
        }




        // Kiểm tra xem mã hóa đơn đã tồn tại trong DataGridView chưa
        private bool MaHoaDonExists(string maHoaDon)
        {
            foreach (DataGridViewRow row in dgvHDBanHang.Rows)
            {
                if (row.Cells["Column1"].Value != null)
                {
                    string existingMaHoaDon = row.Cells["Column1"].Value.ToString();
                    if (existingMaHoaDon == maHoaDon)
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        private void luu_Click(object sender, EventArgs e)
        {
            int savedCount = 0;
            int skippedCount = -1;

            foreach (DataGridViewRow row in dgvHDBanHang.Rows)
            {
                object soHoaDonValue = row.Cells["Column1"].Value;
                string SoHoaDon = soHoaDonValue?.ToString() ?? string.Empty;

                // Kiểm tra xem mã hóa đơn đã tồn tại trong cơ sở dữ liệu chưa
                if (string.IsNullOrWhiteSpace(SoHoaDon) || HDBAL.HoaDonExists(SoHoaDon))
                {
                    skippedCount++;
                    continue;
                }

                DateTime ngayNhap = Convert.ToDateTime(row.Cells["Column2"].Value);
                DateTime ngayXuat = Convert.ToDateTime(row.Cells["Column3"].Value);

                object nhaCungCapValue = row.Cells["Column4"].Value;
                string nhaCungCap = nhaCungCapValue?.ToString() ?? string.Empty;

                // Kiểm tra xem mã nhà cung cấp có tồn tại trong bảng khách hàng không
                if (!KHBAL.CheckKhachHangExists(nhaCungCap))
                {
                    MessageBox.Show($"Mã nhà cung cấp '{nhaCungCap}' không tồn tại trong bảng khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    skippedCount++;
                    continue;
                }

                decimal gia = Convert.ToDecimal(row.Cells["Column7"].Value);
                int soLuong = Convert.ToInt32(row.Cells["Column6"].Value);
                decimal tongTien = Convert.ToDecimal(row.Cells["Column5"].Value);

                HoaDonNhapBEL hoaDon = new HoaDonNhapBEL
                {
                    SoHoaDon = SoHoaDon,
                    NgayNhap = ngayNhap,
                    NgayXuat = ngayXuat,
                    NhaCungCap = nhaCungCap,
                    Gia = gia,
                    SoLuong = soLuong,
                    TongTien = tongTien
                };

                if (HDBAL.SaveHoaDon(hoaDon))
                {
                    savedCount++;
                }
            }

            string message = $"Đã lưu {savedCount} dòng, bỏ qua {skippedCount} dòng.";
            MessageBox.Show(message);
        }


        private void xuấtExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("SoHoaDon");
                dataTable.Columns.Add("NgayNhap");
                dataTable.Columns.Add("NgayXuat");
                dataTable.Columns.Add("NhaCungCap");
                dataTable.Columns.Add("Gia");
                dataTable.Columns.Add("SoLuong");
                dataTable.Columns.Add("TongTien");

                foreach (DataGridViewRow row in dgvHDBanHang.Rows)
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < dgvHDBanHang.Columns.Count; i++)
                    {
                        dataRow[i] = row.Cells[i].Value;
                    }
                    dataTable.Rows.Add(dataRow);
                }

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Sheet1");
                    worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);
                    worksheet.Cells.AutoFitColumns();

                    FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                    package.SaveAs(excelFile);
                }

                MessageBox.Show("Xuất dữ liệu thành công.");
            }

        }


        //DataGridViewRow row = dvgCustomer.CurrentRow;
        //    if (row != null)
        //    {
        //        // Lấy thông tin từ hàng hiện tại và hiển thị lên các điều khiển
        //        tbId.Text = row.Cells[0].Value.ToString();
        //        tbName.Text = row.Cells[1].Value.ToString();
        //        cbArea.SelectedItem = row.Cells[2].Value;
        //    }


        private void dgvHDBanHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHDBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvHDBanHang.Rows.Count) // Đảm bảo không click vào header và có thể click vào empty row cuối cùng
            {
                DataGridViewRow row = dgvHDBanHang.Rows[e.RowIndex];

                if (!row.IsNewRow) // Kiểm tra xem có click vào empty row không
                {
                    // Lấy giá trị từ cột tương ứng trong dòng đã chọn
                    textBox4.Text = row.Cells[0].Value.ToString();

                    if (DateTime.TryParse(row.Cells[1].Value?.ToString(), out DateTime dateValue))
                    {
                        textBox1.Value = dateValue;
                    }

                    if (DateTime.TryParse(row.Cells[2].Value?.ToString(), out DateTime dateeValue))
                    {
                        textBox5.Value = dateeValue;
                    }


                    comboBox1.Text = row.Cells[3].Value.ToString();

                    int.TryParse(row.Cells[5].Value?.ToString(), out int soLuongValue);
                    textBox3.Text = soLuongValue.ToString();

                    decimal.TryParse(row.Cells[4].Value?.ToString(), out decimal giaValue);
                    textBox7.Text = giaValue.ToString();

                    decimal.TryParse(row.Cells[6].Value?.ToString(), out decimal tongTienValue);
                    textBox6.Text = tongTienValue.ToString("0.00");
                }
                else
                {
                    // Đặt các TextBox và ComboBox về giá trị trống để bạn có thể thêm dữ liệu mới
                    textBox4.Text = "";
                    textBox1.Text = "";
                    textBox5.Text = "";
                    comboBox1.Text = "";
                    textBox3.Text = "";
                    textBox7.Text = "";
                    textBox6.Text = "";
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HoaDonNhapBEL hd = new HoaDonNhapBEL();

            hd.SoHoaDon = textBox4.Text;

            string selectedTenKhachHang = comboBox1.SelectedItem.ToString();
            KhachHangBEL selectedKhachHang = KHBAL.ReadAreaList().FirstOrDefault(kh => kh.Ten == selectedTenKhachHang);

            if (selectedKhachHang != null)
            {
                hd.Kh = selectedKhachHang;
            }
            else
            {
                // Xử lý lỗi hoặc hiển thị thông báo nếu không tìm thấy đối tượng KhachHangBEL
                MessageBox.Show("Không tìm thấy thông tin khách hàng tương ứng.");
                return; // Ngừng xử lý tiếp
            }



            hd.NgayNhap = textBox1.Value;
            hd.NgayXuat = textBox5.Value;

            hd.SoLuong = Convert.ToInt32(textBox3.Text);
            hd.Gia = Convert.ToDecimal(textBox7.Text);
            hd.TongTien = hd.SoLuong * hd.Gia;

            // Gọi phương thức thêm hóa đơn từ BAL
            bool susses = HDBAL.AddNewInvoice(hd);
            if (susses)
            {
                MessageBox.Show("Thêm thành công!.");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!.");
            }
            // Làm mới danh sách hiển thị trong comboBox1
            comboBox1.DataSource = KHBAL.ReadAreaList();
            comboBox1.DisplayMember = "Ten";

            textBox6.Text = hd.TongTien.ToString("0.00");
        }






        private void UpdateTotalAmount()
        {
            if (!string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox7.Text))
            {
                int soLuong = Convert.ToInt32(textBox3.Text);
                decimal gia = Convert.ToDecimal(textBox7.Text);
                decimal tongTien = soLuong * gia;

                textBox6.Text = tongTien.ToString("0.00");
            }
            else
            {
                textBox6.Text = "0.00";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvHDBanHang.CurrentRow;
            HoaDonNhapBEL hd = new HoaDonNhapBEL();
            string currentSoHoaDon = textBox4.Text;

            string originalSoHoaDon = row.Cells[0].Value.ToString();


            // Kiểm tra xem mã hóa đơn có thay đổi không
            if (currentSoHoaDon != originalSoHoaDon) // originalSoHoaDon là mã hóa đơn ban đầu khi hiển thị lên
            {
                MessageBox.Show("Không thể thay đổi mã hóa đơn.");
                return;
            }
            hd.SoHoaDon = currentSoHoaDon;

            string selectedTenKhachHang = comboBox1.SelectedItem.ToString();
            KhachHangBEL selectedKhachHang = KHBAL.ReadAreaList().FirstOrDefault(kh => kh.Ten == selectedTenKhachHang);

            if (selectedKhachHang != null)
            {
                hd.Kh = selectedKhachHang;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng tương ứng.");
                return;
            }

            hd.NgayNhap = textBox1.Value;
            hd.NgayXuat = textBox5.Value;

            hd.SoLuong = Convert.ToInt32(textBox3.Text);
            hd.Gia = Convert.ToDecimal(textBox7.Text);
            hd.TongTien = hd.SoLuong * hd.Gia;

            bool success = HDBAL.UpdateInvoice(hd);

            if (success)
            {
                MessageBox.Show("Cập nhật thành công.");
                LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại.");
            }

            // Cập nhật lại danh sách hiển thị trong comboBox1
            comboBox1.DataSource = KHBAL.ReadAreaList();
            comboBox1.DisplayMember = "Ten";

            textBox6.Text = hd.TongTien.ToString("0.00");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            HoaDonNhapBEL hd = new HoaDonNhapBEL(); // Tạo đối tượng hd hoặc lấy thông tin hóa đơn từ giao diện
            hd.SoHoaDon = textBox4.Text;

            string selectedTenKhachHang = comboBox1.SelectedItem.ToString();
            KhachHangBEL selectedKhachHang = KHBAL.ReadAreaList().FirstOrDefault(kh => kh.Ten == selectedTenKhachHang);

            if (selectedKhachHang != null)
            {
                hd.Kh = selectedKhachHang;
            }
            else
            {
                // Xử lý lỗi hoặc hiển thị thông báo nếu không tìm thấy đối tượng KhachHangBEL
                MessageBox.Show("Không tìm thấy thông tin khách hàng tương ứng.");
                return; // Ngừng xử lý tiếp
            }





            bool susses = HDBAL.DeleteInvoice(hd);
            if (susses)
            {
                MessageBox.Show("Xóa  thành công!.");
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa  thất bại!.");
            }

            hd.NgayNhap = textBox1.Value;
            hd.NgayXuat = textBox5.Value;

            hd.SoLuong = Convert.ToInt32(textBox3.Text);
            hd.Gia = Convert.ToDecimal(textBox7.Text);
            hd.TongTien = hd.SoLuong * hd.Gia;





        }
    }
}