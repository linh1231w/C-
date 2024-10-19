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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            giaodien giaodien = new giaodien();
            giaodien.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhanvien Nhanvien = new Nhanvien();
            Nhanvien.ShowDialog();
        }

        private void hoáĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //HoaDonn HoaDonn = new HoaDonn();
            //HoaDonn.ShowDialog();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonNhap HoaDonNhap = new HoaDonNhap();
            HoaDonNhap.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang KhachHang = new KhachHang();
            KhachHang.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}