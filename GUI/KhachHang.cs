using DO_AN.BAL;
using DO_AN.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DO_AN
{
    public partial class KhachHang : Form
    {
        KhachHangBAL KHBAL = new KhachHangBAL();

        public KhachHang()
        {
            InitializeComponent();
            dgvkhach.CellClick += dgvkhach_CellClick;
            dgvkhach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            RefreshDataGridView(); // Load data into DataGridView
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            KhachHangBEL khachHang = new KhachHangBEL
            {
                MaKhachHang = lbmh.Text,
                Ten = lbtenhang.Text,
                DiaChi = tbhangton.Text,
                DienThoai = textBox1.Text
            };

            // OpenFileDialog logic if you're uploading files (e.g., images)
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Handle file path (optional)
                string selectedFilePath = openFileDialog.FileName;
                // You can use this file path to save the file information in the database, if needed.
            }

            KHBAL.NewNV(khachHang);

            // Refresh the DataGridView
            RefreshDataGridView();

            // Clear input fields
            ClearInputFields();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvkhach.CurrentRow;
            if (row != null)
            {
                string currentMaKhachHang = row.Cells[0].Value.ToString();
                string inputMaKhachHang = lbmh.Text;

                // Prevent changing the customer ID
                if (inputMaKhachHang != currentMaKhachHang)
                {
                    MessageBox.Show("Không thể thay đổi mã khách hàng.");
                    return;
                }

                KhachHangBEL khachHang = new KhachHangBEL
                {
                    MaKhachHang = inputMaKhachHang,
                    Ten = lbtenhang.Text,
                    DiaChi = tbhangton.Text,
                    DienThoai = textBox1.Text
                };

                KHBAL.EditNV(khachHang);

                // Refresh the DataGridView
                RefreshDataGridView();

                // Clear input fields
                ClearInputFields();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvkhach.CurrentRow;
            if (row != null)
            {
                string maKhachHang = lbmh.Text;

                KhachHangBEL khachHang = new KhachHangBEL
                {
                    MaKhachHang = maKhachHang
                };

                KHBAL.DeletNV(khachHang);

                int idx = dgvkhach.CurrentCell.RowIndex;
                if (idx >= 0)
                {
                    dgvkhach.Rows.RemoveAt(idx);
                }

                // Refresh the DataGridView
                RefreshDataGridView();

                // Clear input fields
                ClearInputFields();
            }
        }

        private void dgvkhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvkhach.Rows.Count)
            {
                DataGridViewRow row = dgvkhach.Rows[e.RowIndex];
                lbmh.Text = row.Cells[0].Value?.ToString() ?? string.Empty;
                lbtenhang.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                tbhangton.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                textBox1.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        // Utility method to refresh DataGridView
        private void RefreshDataGridView()
        {
            dgvkhach.Rows.Clear();
            List<KhachHangBEL> allCustomers = KHBAL.ReadSP();
            foreach (KhachHangBEL customer in allCustomers)
            {
                dgvkhach.Rows.Add(customer.MaKhachHang, customer.Ten, customer.DiaChi, customer.DienThoai);
            }
        }

        // Utility method to clear input fields
        private void ClearInputFields()
        {
            lbmh.Clear();
            lbtenhang.Clear();
            tbhangton.Clear();
            textBox1.Clear();
        }
        private void dgvkhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You can leave this empty or add some logic if needed
        }

    }
}
