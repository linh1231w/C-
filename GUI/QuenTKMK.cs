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
    public partial class QuenTKMK : Form
    {
        QuenmatkhauBAL dal = new QuenmatkhauBAL();
        public QuenTKMK()
        {
            InitializeComponent();
        }



        private void QuenTKMK_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string email = tbtk.Text;
            if (dal.IsEmail(email))
            {
                Taomatkhaumoi Taomatkhaumoi = new Taomatkhaumoi(email);
                Taomatkhaumoi.ShowDialog();

                this.Close();

            }
            else
            {
                MessageBox.Show("Email khong ton tai trong he thong!");
            }
        }

        private void QuenTKMK_Load_1(object sender, EventArgs e)
        {
           

            // Thiết lập hình ảnh cho PictureBox từ file bên ngoài
            this.pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\user\Desktop\DO AN\DO AN\Resources\th.jpg");
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
