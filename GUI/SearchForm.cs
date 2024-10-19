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
    public partial class SearchForm : Form
    {
        private HoaDonNhap mainForm;

        public SearchForm(HoaDonNhap mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SoHoaDon = textBox1.Text;

            if (!string.IsNullOrEmpty(SoHoaDon))
            {
                mainForm.SearchHoaDon(SoHoaDon);
                this.Close();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn.");
            }
        }

        
        public SearchForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(SearchForm_Load); // Thêm dòng này
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\user\Desktop\DO AN\DO AN\Resources\hinh1.jpg");
        }


    }
}
