using System.Windows.Forms;

namespace DO_AN
{
    partial class Taomatkhaumoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbmkmoi = new System.Windows.Forms.TextBox();
            this.btxacnhan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnhaplaimkmoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btquaylai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(225, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO MẬT KHẨU MỚI";
            // 
            // tbmkmoi
            // 
            this.tbmkmoi.Location = new System.Drawing.Point(225, 114);
            this.tbmkmoi.Name = "tbmkmoi";
            this.tbmkmoi.Size = new System.Drawing.Size(238, 20);
            this.tbmkmoi.TabIndex = 1;
            // 
            // btxacnhan
            // 
            this.btxacnhan.Location = new System.Drawing.Point(293, 248);
            this.btxacnhan.Name = "btxacnhan";
            this.btxacnhan.Size = new System.Drawing.Size(77, 20);
            this.btxacnhan.TabIndex = 3;
            this.btxacnhan.Text = "Xác nhận";
            this.btxacnhan.UseVisualStyleBackColor = true;
            this.btxacnhan.Click += new System.EventHandler(this.btxacnhan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(58, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // tbnhaplaimkmoi
            // 
            this.tbnhaplaimkmoi.Location = new System.Drawing.Point(225, 180);
            this.tbnhaplaimkmoi.Name = "tbnhaplaimkmoi";
            this.tbnhaplaimkmoi.Size = new System.Drawing.Size(238, 20);
            this.tbnhaplaimkmoi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(58, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // btquaylai
            // 
            this.btquaylai.Location = new System.Drawing.Point(598, 10);
            this.btquaylai.Name = "btquaylai";
            this.btquaylai.Size = new System.Drawing.Size(77, 20);
            this.btquaylai.TabIndex = 8;
            this.btquaylai.Text = "Quay lại";
            this.btquaylai.UseVisualStyleBackColor = true;
            this.btquaylai.Click += new System.EventHandler(this.btquaylai_Click);
            // 
            // Taomatkhaumoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.btquaylai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbnhaplaimkmoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btxacnhan);
            this.Controls.Add(this.tbmkmoi);
            this.Controls.Add(this.label1);
            this.Name = "Taomatkhaumoi";
            this.Text = "Taomatkhaumoi";
            this.Load += new System.EventHandler(this.Taomatkhaumoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbmkmoi;
        private Button btxacnhan;
        private Label label3;
        private TextBox tbnhaplaimkmoi;
        private Label label4;
        private Button btquaylai;
    }
}