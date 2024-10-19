using System.Windows.Forms;

namespace DO_AN
{
    partial class KhachHang
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
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvkhach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbmh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbtenhang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbhangton = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhach)).BeginInit();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(244, 469);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 31);
            this.btDelete.TabIndex = 63;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(134, 469);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 31);
            this.btEdit.TabIndex = 62;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(30, 469);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(75, 30);
            this.btNew.TabIndex = 61;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(695, 469);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 31);
            this.button5.TabIndex = 65;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvkhach
            // 
            this.dgvkhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvkhach.Location = new System.Drawing.Point(30, 232);
            this.dgvkhach.Name = "dgvkhach";
            this.dgvkhach.RowTemplate.Height = 25;
            this.dgvkhach.Size = new System.Drawing.Size(740, 192);
            this.dgvkhach.TabIndex = 60;
            this.dgvkhach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhach_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Khách";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Khách";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Điện Thoại";
            this.Column4.Name = "Column4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(267, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(287, 32);
            this.label9.TabIndex = 59;
            this.label9.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(46, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "Mã Khách";
            // 
            // lbmh
            // 
            this.lbmh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbmh.Location = new System.Drawing.Point(134, 87);
            this.lbmh.Name = "lbmh";
            this.lbmh.Size = new System.Drawing.Size(167, 24);
            this.lbmh.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tên Khách";
            // 
            // lbtenhang
            // 
            this.lbtenhang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbtenhang.Location = new System.Drawing.Point(134, 124);
            this.lbtenhang.Name = "lbtenhang";
            this.lbtenhang.Size = new System.Drawing.Size(167, 24);
            this.lbtenhang.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "Địa Chỉ";
            // 
            // tbhangton
            // 
            this.tbhangton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbhangton.Location = new System.Drawing.Point(532, 87);
            this.tbhangton.Name = "tbhangton";
            this.tbhangton.Size = new System.Drawing.Size(167, 24);
            this.tbhangton.TabIndex = 49;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(532, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 24);
            this.textBox1.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 68;
            this.label5.Text = "Số Điện Thoại";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 548);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgvkhach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbhangton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbtenhang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbmh);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btDelete;
        private Button btEdit;
        private Button btNew;
        private Button button5;
        private DataGridView dgvkhach;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label9;
        private Label label1;
        private TextBox lbmh;
        private Label label2;
        private TextBox lbtenhang;
        private Label label3;
        private TextBox tbhangton;
        private TextBox textBox1;
        private Label label5;
    }
}