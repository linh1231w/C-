namespace DO_AN
{
    partial class Form1
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
            this.Ten = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDN = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btnDN = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ten
            // 
            this.Ten.AutoSize = true;
            this.Ten.Location = new System.Drawing.Point(133, 46);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(84, 13);
            this.Ten.TabIndex = 0;
            this.Ten.Text = "Tên Đăng Nhập";
            this.Ten.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật Khẩu";
            // 
            // txtDN
            // 
            this.txtDN.Location = new System.Drawing.Point(270, 46);
            this.txtDN.Name = "txtDN";
            this.txtDN.Size = new System.Drawing.Size(185, 20);
            this.txtDN.TabIndex = 2;
            this.txtDN.TextChanged += new System.EventHandler(this.txtDN_TextChanged);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(270, 91);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(185, 20);
            this.txtMK.TabIndex = 3;
            this.txtMK.TextChanged += new System.EventHandler(this.txtMK_TextChanged);
            // 
            // btnDN
            // 
            this.btnDN.Location = new System.Drawing.Point(270, 153);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(75, 23);
            this.btnDN.TabIndex = 4;
            this.btnDN.Text = "Đăng Nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(389, 153);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtDN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Button btnThoat;
    }
}

