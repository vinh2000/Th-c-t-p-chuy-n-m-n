﻿namespace QuanLyBanSach
{
    partial class ChiTietSach
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
            this.BT_Huy = new System.Windows.Forms.Button();
            this.TB_MoTa = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PTB_AnhBia = new System.Windows.Forms.PictureBox();
            this.BT_Luu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_MaSoSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_ThemAnhBia = new System.Windows.Forms.Button();
            this.CBB_TheLoai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_TacGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_SoTrang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_NhaXuatBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_NamXuatBan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_DonGia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_TenSach = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PTB_AnhBia)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_Huy
            // 
            this.BT_Huy.Location = new System.Drawing.Point(710, 595);
            this.BT_Huy.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Huy.Name = "BT_Huy";
            this.BT_Huy.Size = new System.Drawing.Size(116, 32);
            this.BT_Huy.TabIndex = 17;
            this.BT_Huy.Text = "Hủy bỏ";
            this.BT_Huy.UseVisualStyleBackColor = true;
            this.BT_Huy.Click += new System.EventHandler(this.BT_Huy_Click);
            // 
            // TB_MoTa
            // 
            this.TB_MoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_MoTa.Location = new System.Drawing.Point(20, 389);
            this.TB_MoTa.Margin = new System.Windows.Forms.Padding(2);
            this.TB_MoTa.Name = "TB_MoTa";
            this.TB_MoTa.Size = new System.Drawing.Size(452, 165);
            this.TB_MoTa.TabIndex = 15;
            this.TB_MoTa.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 420);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mô tả: ";
            // 
            // PTB_AnhBia
            // 
            this.PTB_AnhBia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PTB_AnhBia.Location = new System.Drawing.Point(0, 0);
            this.PTB_AnhBia.Margin = new System.Windows.Forms.Padding(2);
            this.PTB_AnhBia.Name = "PTB_AnhBia";
            this.PTB_AnhBia.Size = new System.Drawing.Size(198, 248);
            this.PTB_AnhBia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PTB_AnhBia.TabIndex = 0;
            this.PTB_AnhBia.TabStop = false;
            // 
            // BT_Luu
            // 
            this.BT_Luu.Location = new System.Drawing.Point(833, 595);
            this.BT_Luu.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Luu.Name = "BT_Luu";
            this.BT_Luu.Size = new System.Drawing.Size(116, 32);
            this.BT_Luu.TabIndex = 16;
            this.BT_Luu.Text = "Lưu lại";
            this.BT_Luu.UseVisualStyleBackColor = true;
            this.BT_Luu.Click += new System.EventHandler(this.BT_Luu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách: ";
            // 
            // TB_MaSoSach
            // 
            this.TB_MaSoSach.Enabled = false;
            this.TB_MaSoSach.Location = new System.Drawing.Point(11, 55);
            this.TB_MaSoSach.Margin = new System.Windows.Forms.Padding(2);
            this.TB_MaSoSach.Name = "TB_MaSoSach";
            this.TB_MaSoSach.Size = new System.Drawing.Size(432, 27);
            this.TB_MaSoSach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số sách: ";
            // 
            // BT_ThemAnhBia
            // 
            this.BT_ThemAnhBia.Location = new System.Drawing.Point(162, 508);
            this.BT_ThemAnhBia.Margin = new System.Windows.Forms.Padding(2);
            this.BT_ThemAnhBia.Name = "BT_ThemAnhBia";
            this.BT_ThemAnhBia.Size = new System.Drawing.Size(138, 32);
            this.BT_ThemAnhBia.TabIndex = 7;
            this.BT_ThemAnhBia.Text = "Thêm ảnh bìa";
            this.BT_ThemAnhBia.UseVisualStyleBackColor = true;
            this.BT_ThemAnhBia.Click += new System.EventHandler(this.BT_ThemAnhBia_Click);
            // 
            // CBB_TheLoai
            // 
            this.CBB_TheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBB_TheLoai.FormattingEnabled = true;
            this.CBB_TheLoai.Location = new System.Drawing.Point(11, 251);
            this.CBB_TheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.CBB_TheLoai.Name = "CBB_TheLoai";
            this.CBB_TheLoai.Size = new System.Drawing.Size(432, 28);
            this.CBB_TheLoai.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thể loại:";
            // 
            // TB_TacGia
            // 
            this.TB_TacGia.Location = new System.Drawing.Point(11, 185);
            this.TB_TacGia.Margin = new System.Windows.Forms.Padding(2);
            this.TB_TacGia.Name = "TB_TacGia";
            this.TB_TacGia.Size = new System.Drawing.Size(432, 27);
            this.TB_TacGia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tác giả (ngăn cách bằng dầu \",\"): ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PTB_AnhBia);
            this.panel1.Location = new System.Drawing.Point(128, 238);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 250);
            this.panel1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 292);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Đơn giá:";
            // 
            // TB_SoTrang
            // 
            this.TB_SoTrang.Location = new System.Drawing.Point(11, 178);
            this.TB_SoTrang.Margin = new System.Windows.Forms.Padding(2);
            this.TB_SoTrang.Name = "TB_SoTrang";
            this.TB_SoTrang.Size = new System.Drawing.Size(432, 27);
            this.TB_SoTrang.TabIndex = 5;
            this.TB_SoTrang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_SoTrang_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số trang: ";
            // 
            // TB_NhaXuatBan
            // 
            this.TB_NhaXuatBan.Location = new System.Drawing.Point(11, 118);
            this.TB_NhaXuatBan.Margin = new System.Windows.Forms.Padding(2);
            this.TB_NhaXuatBan.Name = "TB_NhaXuatBan";
            this.TB_NhaXuatBan.Size = new System.Drawing.Size(432, 27);
            this.TB_NhaXuatBan.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhà xuất bản: ";
            // 
            // TB_NamXuatBan
            // 
            this.TB_NamXuatBan.Location = new System.Drawing.Point(11, 55);
            this.TB_NamXuatBan.Margin = new System.Windows.Forms.Padding(2);
            this.TB_NamXuatBan.Name = "TB_NamXuatBan";
            this.TB_NamXuatBan.Size = new System.Drawing.Size(432, 27);
            this.TB_NamXuatBan.TabIndex = 1;
            this.TB_NamXuatBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NamXuatBan_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Năm xuất bản: ";
            // 
            // TB_DonGia
            // 
            this.TB_DonGia.Location = new System.Drawing.Point(11, 315);
            this.TB_DonGia.Margin = new System.Windows.Forms.Padding(2);
            this.TB_DonGia.Name = "TB_DonGia";
            this.TB_DonGia.Size = new System.Drawing.Size(432, 27);
            this.TB_DonGia.TabIndex = 10;
            this.TB_DonGia.Text = "0";
            this.TB_DonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TB_DonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_DonGia_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_DonGia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CBB_TheLoai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TB_TacGia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_TenSach);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_MaSoSach);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(451, 352);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cơ bản";
            // 
            // TB_TenSach
            // 
            this.TB_TenSach.Location = new System.Drawing.Point(11, 118);
            this.TB_TenSach.Margin = new System.Windows.Forms.Padding(2);
            this.TB_TenSach.Name = "TB_TenSach";
            this.TB_TenSach.Size = new System.Drawing.Size(432, 27);
            this.TB_TenSach.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BT_ThemAnhBia);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.TB_SoTrang);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TB_NhaXuatBan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TB_NamXuatBan);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(498, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(451, 555);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin bổ sung";
            // 
            // ChiTietSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 647);
            this.Controls.Add(this.BT_Huy);
            this.Controls.Add(this.TB_MoTa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BT_Luu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ChiTietSach";
            this.Text = "ChiTietSach";
            this.Load += new System.EventHandler(this.ChiTietSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PTB_AnhBia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BT_Huy;
        public System.Windows.Forms.RichTextBox TB_MoTa;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.PictureBox PTB_AnhBia;
        public System.Windows.Forms.Button BT_Luu;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TB_MaSoSach;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BT_ThemAnhBia;
        public System.Windows.Forms.ComboBox CBB_TheLoai;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TB_TacGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox TB_SoTrang;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TB_NhaXuatBan;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TB_NamXuatBan;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox TB_DonGia;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox TB_TenSach;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}