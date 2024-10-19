

using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static DO_AN.BAL.dangnhap;

namespace DO_AN
{
    public partial class DangNhap : Form
    {
        private BusinessLogicLayer businessLogic;

        public DangNhap()
        {
            InitializeComponent();
            businessLogic = new BusinessLogicLayer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btTk.Text = Properties.Settings.Default.username;
            btMk.Text = Properties.Settings.Default.password;
            if (Properties.Settings.Default.username != "")
            {
                cluu.Checked = true;
            }


        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string username = btTk.Text;
            string password = btMk.Text;

            // kiem tra tk mk dung hay k 
            bool isAuthenticated = BusinessLogicLayer.ValidateLoginCredentials(username, password);

            if (isAuthenticated)
            {
                bool isAdmin = businessLogic.IsAdminAccount(username);
                if (isAdmin)
                {
                    MessageBox.Show("Đăng nhập thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // Login successful
                    Main Main = new Main();
                    Main.ShowDialog();
                }
                else
                {
                    Main Main = new Main();
                    Main.ShowDialog();

                    //giaodien giaodien = new giaodien();
                    //giaodien.ShowDialog();
                }



            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cluu_CheckedChanged(object sender, EventArgs e)
        {
            if (btTk.Text != "" && btMk.Text != "")
            {
                if (cluu.Checked == true)
                {
                    string users = btTk.Text;
                    string pwd = btMk.Text;
                    Properties.Settings.Default.username = users;
                    Properties.Settings.Default.password = pwd;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }

            }
        }

        private void lbqmk_Click(object sender, EventArgs e)
        {
            QuenTKMK QuenTKMK = new QuenTKMK();
            QuenTKMK.ShowDialog();


            this.Show();
        }

        private void btTk_TextChanged(object sender, EventArgs e)
        {

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}