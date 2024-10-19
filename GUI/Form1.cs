using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  // This line is essential for connecting to SQL Server
using System.Data;

namespace DO_AN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            // Connection string and establishment
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-F61L4C7\SQLEXPRESS;Initial Catalog=QLBH;User ID=sa;Password=sa");
            try
            {
                conn.Open();
                // Get username and password from text boxes
                string tk = txtDN.Text;
                string mk = txtMK.Text;
                // Build SQL query to select from NguoiDung table
                string sql = "select * from NguoiDung where TaiKhoan='" + tk + "' and MatKhau='" + mk + "'";
                // Create SqlCommand object and execute reader
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                // Check if a record is found
                if (dta.Read() == true)
                {
                    MessageBox.Show("Dang nhap thanh cong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information); // Login successful

                    // Open the new form
                    Cau05 cau05 = new Cau05();
                    cau05.Show();
                    this.Hide(); // Hide the current form
                }
                else
                {
                    MessageBox.Show("Dang nhap that bai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Close the reader
                dta.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi ket noi"); // Connection error message
            }
            finally
            {
                // Ensure connection is closed even if an exception occurs
                conn.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtDN_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
