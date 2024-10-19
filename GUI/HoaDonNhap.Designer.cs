using System.Windows.Forms;

namespace DO_AN
{
    partial class HoaDonNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.luu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvHDBanHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // luu
            // 
            this.luu.Location = new System.Drawing.Point(352, 373);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(89, 32);
            this.luu.TabIndex = 39;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1112, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 38;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvHDBanHang
            // 
            this.dgvHDBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBanHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column6,
            this.Column5});
            this.dgvHDBanHang.Location = new System.Drawing.Point(0, 178);
            this.dgvHDBanHang.Name = "dgvHDBanHang";
            this.dgvHDBanHang.RowHeadersWidth = 51;
            this.dgvHDBanHang.RowTemplate.Height = 24;
            this.dgvHDBanHang.Size = new System.Drawing.Size(764, 463);
            this.dgvHDBanHang.TabIndex = 95;
            this.dgvHDBanHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDBanHang_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Hóa Đơn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày Tạo Hóa Đơn";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Xuất Hóa Đơn";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tên Khách Hàng";
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Giá Tiền";
            this.Column7.Name = "Column7";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Số Lượng";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tổng Tiền";
            this.Column5.Name = "Column5";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1219, 24);
            this.menuStrip1.TabIndex = 112;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flieToolStripMenuItem
            // 
            this.flieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpExcelToolStripMenuItem,
            this.xuấtExcelToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.flieToolStripMenuItem.Name = "flieToolStripMenuItem";
            this.flieToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.flieToolStripMenuItem.Text = "Flie";
            // 
            // nhậpExcelToolStripMenuItem
            // 
            this.nhậpExcelToolStripMenuItem.Name = "nhậpExcelToolStripMenuItem";
            this.nhậpExcelToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.nhậpExcelToolStripMenuItem.Text = "Nhập Excel";
            this.nhậpExcelToolStripMenuItem.Click += new System.EventHandler(this.nhậpExcelToolStripMenuItem_Click);
            // 
            // xuấtExcelToolStripMenuItem
            // 
            this.xuấtExcelToolStripMenuItem.Name = "xuấtExcelToolStripMenuItem";
            this.xuấtExcelToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.xuấtExcelToolStripMenuItem.Text = "Xuất Excel";
            this.xuấtExcelToolStripMenuItem.Click += new System.EventHandler(this.xuấtExcelToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.luu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(778, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 474);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(173, 170);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(235, 29);
            this.textBox5.TabIndex = 126;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 29);
            this.textBox1.TabIndex = 114;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(173, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 29);
            this.comboBox1.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 120;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 125;
            this.label7.Text = "Giá Tiền";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(20, 373);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(89, 32);
            this.btnTimKiem.TabIndex = 35;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(173, 282);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(235, 29);
            this.textBox6.TabIndex = 116;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(173, 212);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(235, 29);
            this.textBox7.TabIndex = 124;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(173, 52);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(235, 29);
            this.textBox4.TabIndex = 114;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 21);
            this.label11.TabIndex = 117;
            this.label11.Text = "Mã Hóa Đơn ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 123;
            this.label3.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 121;
            this.label5.Text = "Tổng Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 119;
            this.label2.Text = "Ngày Xuất Hóa Đơn";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(173, 247);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(235, 29);
            this.textBox3.TabIndex = 122;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 118;
            this.label1.Text = "Ngày Tạo Hóa Đơn";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(0, 647);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1219, 67);
            this.panel3.TabIndex = 96;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1080, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 34);
            this.button5.TabIndex = 3;
            this.button5.Text = "Xóa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(577, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 34);
            this.button3.TabIndex = 1;
            this.button3.Text = "Cập Nhật";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(578, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 31);
            this.label6.TabIndex = 114;
            this.label6.Text = "HÓA ĐƠN";
            // 
            // HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1219, 762);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvHDBanHang);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HoaDonNhap";
            this.Text = "HoaDonNhap";
            this.Load += new System.EventHandler(this.HoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvHDBanHang;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem flieToolStripMenuItem;
        private ToolStripMenuItem nhậpExcelToolStripMenuItem;
        private ToolStripMenuItem xuấtExcelToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Button luu;
        private GroupBox groupBox1;
        private Label label4;
        private Label label7;
        private Button btnTimKiem;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox4;
        private Label label11;
        private Label label3;
        private Label label5;
        private Label label2;
        private TextBox textBox3;
        private Label label1;
        private Panel panel3;
        private Button button3;
        private Button button2;
        private Button button5;
        private ComboBox comboBox1;
        private DateTimePicker textBox5;
        private DateTimePicker textBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private Label label6;
    }
}