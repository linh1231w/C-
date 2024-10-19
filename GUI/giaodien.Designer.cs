using System.Windows.Forms;

namespace DO_AN
{
    partial class giaodien
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
            this.btMo = new System.Windows.Forms.Button();
            this.tbtenanh = new System.Windows.Forms.TextBox();
            this.PicAnh = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbdongiaban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbdongianhap = new System.Windows.Forms.TextBox();
            this.tbhangton = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbtenhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbmh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvqlsp = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btNew = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Lghichu = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.PicAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlsp)).BeginInit();
            this.SuspendLayout();
            // 
            // btMo
            // 
            this.btMo.Location = new System.Drawing.Point(664, 97);
            this.btMo.Name = "btMo";
            this.btMo.Size = new System.Drawing.Size(56, 25);
            this.btMo.TabIndex = 34;
            this.btMo.Text = "Mở";
            this.btMo.UseVisualStyleBackColor = true;
            this.btMo.Click += new System.EventHandler(this.btMo_Click);
            // 
            // tbtenanh
            // 
            this.tbtenanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtenanh.Location = new System.Drawing.Point(534, 97);
            this.tbtenanh.Name = "tbtenanh";
            this.tbtenanh.Size = new System.Drawing.Size(123, 26);
            this.tbtenanh.TabIndex = 33;
            // 
            // PicAnh
            // 
            this.PicAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicAnh.Location = new System.Drawing.Point(763, 97);
            this.PicAnh.Name = "PicAnh";
            this.PicAnh.Size = new System.Drawing.Size(205, 148);
            this.PicAnh.TabIndex = 32;
            this.PicAnh.TabStop = false;
            this.PicAnh.Click += new System.EventHandler(this.PicAnh_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ảnh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Đơn giá bán";
            // 
            // tbdongiaban
            // 
            this.tbdongiaban.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbdongiaban.Location = new System.Drawing.Point(133, 221);
            this.tbdongiaban.Name = "tbdongiaban";
            this.tbdongiaban.Size = new System.Drawing.Size(191, 26);
            this.tbdongiaban.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Đơn giá nhập";
            // 
            // tbdongianhap
            // 
            this.tbdongianhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbdongianhap.Location = new System.Drawing.Point(133, 190);
            this.tbdongianhap.Name = "tbdongianhap";
            this.tbdongianhap.Size = new System.Drawing.Size(191, 26);
            this.tbdongianhap.TabIndex = 24;
            // 
            // tbhangton
            // 
            this.tbhangton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbhangton.Location = new System.Drawing.Point(133, 159);
            this.tbhangton.Name = "tbhangton";
            this.tbhangton.Size = new System.Drawing.Size(191, 26);
            this.tbhangton.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Số lượng";
            // 
            // lbtenhang
            // 
            this.lbtenhang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbtenhang.Location = new System.Drawing.Point(133, 128);
            this.lbtenhang.Name = "lbtenhang";
            this.lbtenhang.Size = new System.Drawing.Size(191, 26);
            this.lbtenhang.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên sản phẩm";
            // 
            // lbmh
            // 
            this.lbmh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbmh.Location = new System.Drawing.Point(133, 97);
            this.lbmh.Name = "lbmh";
            this.lbmh.Size = new System.Drawing.Size(191, 26);
            this.lbmh.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(385, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 32);
            this.label9.TabIndex = 36;
            this.label9.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // dgvqlsp
            // 
            this.dgvqlsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqlsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8});
            this.dgvqlsp.Location = new System.Drawing.Point(37, 299);
            this.dgvqlsp.Name = "dgvqlsp";
            this.dgvqlsp.RowTemplate.Height = 25;
            this.dgvqlsp.Size = new System.Drawing.Size(933, 205);
            this.dgvqlsp.TabIndex = 37;
            this.dgvqlsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvqlsp_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TênSP";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số Lượng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn Giá Nhập";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Đơn Giá Bán";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ảnh";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ghi Chú";
            this.Column8.Name = "Column8";
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(37, 531);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(86, 25);
            this.btNew.TabIndex = 38;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(153, 531);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(86, 25);
            this.btEdit.TabIndex = 39;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(278, 531);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(86, 25);
            this.btDelete.TabIndex = 40;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(883, 531);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 25);
            this.button5.TabIndex = 42;
            this.button5.Text = "Quay Lại";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Lghichu
            // 
            this.Lghichu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lghichu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Lghichu.Location = new System.Drawing.Point(549, 214);
            this.Lghichu.Name = "Lghichu";
            this.Lghichu.Size = new System.Drawing.Size(141, 29);
            this.Lghichu.TabIndex = 43;
            this.Lghichu.TextChanged += new System.EventHandler(this.Lghichu_TextChanged);
            // 
            // giaodien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 569);
            this.Controls.Add(this.Lghichu);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.dgvqlsp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btMo);
            this.Controls.Add(this.tbtenanh);
            this.Controls.Add(this.PicAnh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbdongiaban);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbdongianhap);
            this.Controls.Add(this.tbhangton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbtenhang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbmh);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "giaodien";
            this.Text = "giaodien";
            this.Load += new System.EventHandler(this.giaodien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btMo;
        private TextBox tbtenanh;
        private PictureBox PicAnh;
        private Label label8;
        private Label label7;
        private Label label5;
        private TextBox tbdongiaban;
        private Label label4;
        private TextBox tbdongianhap;
        private TextBox tbhangton;
        private Label label3;
        private TextBox lbtenhang;
        private Label label2;
        private TextBox lbmh;
        private Label label1;
        private Label label9;
        private DataGridView dgvqlsp;
        private Button btNew;
        private Button btEdit;
        private Button btDelete;
        private Button button5;
        private TextBox Lghichu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}