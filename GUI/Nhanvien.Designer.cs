using System.Drawing;
using System.Windows.Forms;

namespace DO_AN
{
    partial class Nhanvien
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
            btDelete = new Button();
            btEdit = new Button();
            btNew = new Button();
            button5 = new Button();
            dgvqlsp = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label9 = new Label();
            tbtenanh = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            tbdongiaban = new TextBox();
            label4 = new Label();
            lbtenhang = new TextBox();
            label2 = new Label();
            lbmh = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvqlsp).BeginInit();
            SuspendLayout();
            // 
            // btDelete
            // 
            btDelete.Location = new Point(309, 648);
            btDelete.Margin = new Padding(4);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(96, 31);
            btDelete.TabIndex = 63;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(168, 648);
            btEdit.Margin = new Padding(4);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(96, 31);
            btEdit.TabIndex = 62;
            btEdit.Text = "Sửa";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btNew
            // 
            btNew.Location = new Point(37, 648);
            btNew.Margin = new Padding(4);
            btNew.Name = "btNew";
            btNew.Size = new Size(96, 31);
            btNew.TabIndex = 61;
            btNew.Text = "Thêm";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // button5
            // 
            button5.Location = new Point(892, 648);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(96, 31);
            button5.TabIndex = 65;
            button5.Text = "Quay Lại";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dgvqlsp
            // 
            dgvqlsp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvqlsp.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7 });
            dgvqlsp.Location = new Point(37, 357);
            dgvqlsp.Margin = new Padding(4);
            dgvqlsp.Name = "dgvqlsp";
            dgvqlsp.RowTemplate.Height = 25;
            dgvqlsp.Size = new Size(951, 256);
            dgvqlsp.TabIndex = 60;
            dgvqlsp.CellContentClick += dgvqlsp_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã Nhân Viên";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên Nhân Viên";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Ngày Sinh";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Giới Tính";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Số Điện Thoại";
            Column5.Name = "Column5";
            // 
            // Column7
            // 
            Column7.HeaderText = "Địa Chỉ";
            Column7.Name = "Column7";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(375, 12);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(261, 32);
            label9.TabIndex = 59;
            label9.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // tbtenanh
            // 
            tbtenanh.BorderStyle = BorderStyle.FixedSingle;
            tbtenanh.Location = new Point(738, 105);
            tbtenanh.Margin = new Padding(4);
            tbtenanh.Name = "tbtenanh";
            tbtenanh.Size = new Size(206, 27);
            tbtenanh.TabIndex = 57;
            tbtenanh.TextChanged += tbtenanh_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(642, 168);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 55;
            label8.Text = "Giới Tính";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(609, 108);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 54;
            label7.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(652, 219);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 53;
            label5.Text = "Địa Chỉ";
            // 
            // tbdongiaban
            // 
            tbdongiaban.BorderStyle = BorderStyle.FixedSingle;
            tbdongiaban.Location = new Point(738, 208);
            tbdongiaban.Margin = new Padding(4);
            tbdongiaban.Name = "tbdongiaban";
            tbdongiaban.Size = new Size(206, 27);
            tbdongiaban.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 229);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 51;
            label4.Text = "Ngày Sinh";
            // 
            // lbtenhang
            // 
            lbtenhang.BorderStyle = BorderStyle.FixedSingle;
            lbtenhang.Location = new Point(147, 155);
            lbtenhang.Margin = new Padding(4);
            lbtenhang.Name = "lbtenhang";
            lbtenhang.Size = new Size(214, 27);
            lbtenhang.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 168);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 46;
            label2.Text = "Tên Nhân Viên";
            // 
            // lbmh
            // 
            lbmh.BorderStyle = BorderStyle.FixedSingle;
            lbmh.Location = new Point(145, 105);
            lbmh.Margin = new Padding(4);
            lbmh.Name = "lbmh";
            lbmh.Size = new Size(214, 27);
            lbmh.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(15, 116);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 44;
            label1.Text = "Mã Nhân Viên";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(145, 219);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 27);
            dateTimePicker1.TabIndex = 67;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(738, 168);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(61, 24);
            checkBox1.TabIndex = 68;
            checkBox1.Text = "Nam";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Nhanvien
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1029, 700);
            Controls.Add(checkBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(btDelete);
            Controls.Add(btEdit);
            Controls.Add(btNew);
            Controls.Add(button5);
            Controls.Add(dgvqlsp);
            Controls.Add(label9);
            Controls.Add(tbtenanh);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(tbdongiaban);
            Controls.Add(label4);
            Controls.Add(lbtenhang);
            Controls.Add(label2);
            Controls.Add(lbmh);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.Highlight;
            Margin = new Padding(4);
            Name = "Nhanvien";
            Text = "Nhanvien";
            Load += Nhanvien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvqlsp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btDelete;
        private Button btEdit;
        private Button btNew;
        private Button button5;
        private DataGridView dgvqlsp;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private Label label9;
        private TextBox tbtenanh;
        private Label label8;
        private Label label7;
        private Label label5;
        private TextBox tbdongiaban;
        private Label label4;
        private TextBox lbtenhang;
        private Label label2;
        private TextBox lbmh;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
    }
}