namespace DO_AN
{
    partial class KH
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
            this.drvKhachHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // drvKhachHang
            // 
            this.drvKhachHang.AllowUserToAddRows = false;
            this.drvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.drvKhachHang.Location = new System.Drawing.Point(21, 30);
            this.drvKhachHang.Name = "drvKhachHang";
            this.drvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drvKhachHang.Size = new System.Drawing.Size(440, 160);
            this.drvKhachHang.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Mã";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Tên";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(83, 214);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(75, 23);
            this.tbId.TabIndex = 3;
            this.tbId.UseVisualStyleBackColor = true;
            this.tbId.Click += new System.EventHandler(this.tbId_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(83, 248);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(378, 23);
            this.tbName.TabIndex = 4;
            this.tbName.UseVisualStyleBackColor = true;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(131, 301);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(62, 22);
            this.btNew.TabIndex = 5;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(221, 301);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(62, 22);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(310, 301);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(62, 22);
            this.btEdit.TabIndex = 7;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(399, 301);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(62, 22);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drvKhachHang);
            this.Name = "KH";
            this.Text = "KH";
            ((System.ComponentModel.ISupportInitialize)(this.drvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView drvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tbId;
        private System.Windows.Forms.Button tbName;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btExit;
    }
}