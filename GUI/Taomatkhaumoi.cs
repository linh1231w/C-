using DO_AN.BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN
{
    public partial class Taomatkhaumoi : Form
    {
        private string email;
        TaomatkhauBAL dal = new TaomatkhauBAL();
        public Taomatkhaumoi(string email)
        {
            InitializeComponent();
            this.email = email;

        }

        private void Taomatkhaumoi_Load(object sender, EventArgs e)
        {

        }

        private void btxacnhan_Click(object sender, EventArgs e)
        {
            string Password = tbmkmoi.Text;
            dal.UpdatePasswordInDatabase(email, Password);

            MessageBox.Show("Mật khẩu đã được đặt lại thành công!");
            this.Close();


        }

        private void btquaylai_Click(object sender, EventArgs e)
        {

        }
    }
}
