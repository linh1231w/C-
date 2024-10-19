namespace DO_AN
{
    partial class Cau4
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLop = new System.Windows.Forms.TextBox();
            this.BtNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LopColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.LopColumn});
            this.dgvKhachHang.Location = new System.Drawing.Point(12, 12);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(776, 200);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(50, 230);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(50, 260);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbLop
            // 
            this.tbLop.Location = new System.Drawing.Point(50, 290);
            this.tbLop.Name = "tbLop";
            this.tbLop.Size = new System.Drawing.Size(100, 20);
            this.tbLop.TabIndex = 3;
            // 
            // BtNew
            // 
            this.BtNew.Location = new System.Drawing.Point(200, 230);
            this.BtNew.Name = "BtNew";
            this.BtNew.Size = new System.Drawing.Size(75, 23);
            this.BtNew.TabIndex = 4;
            this.BtNew.Text = "Thêm";
            this.BtNew.UseVisualStyleBackColor = true;
            this.BtNew.Click += new System.EventHandler(this.BtNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(300, 230);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(400, 230);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 6;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(500, 230);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(75, 23);
            this.btRead.TabIndex = 7;
            this.btRead.Text = "Đọc";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(600, 230);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 233);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 13);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "Mã";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 263);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(26, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Tên";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(12, 293);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(25, 13);
            this.lblLop.TabIndex = 11;
            this.lblLop.Text = "Lớp";
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Mã";
            this.IdColumn.Name = "IdColumn";
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Tên";
            this.NameColumn.Name = "NameColumn";
            // 
            // LopColumn
            // 
            this.LopColumn.HeaderText = "Lớp";
            this.LopColumn.Name = "LopColumn";
            // 
            // Cau4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.BtNew);
            this.Controls.Add(this.tbLop);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.dgvKhachHang);
            this.Name = "Cau4";
            this.Text = "Cau4";
            this.Load += new System.EventHandler(this.Cau4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLop;
        private System.Windows.Forms.Button BtNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LopColumn;
    }
}