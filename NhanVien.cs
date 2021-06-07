﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
            CB_HienMatKhau.Checked = false;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void BT_Luu_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BT_Huy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CB_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_HienMatKhau.Checked)
                TB_MatKhau.PasswordChar = '\0';
            else
                TB_MatKhau.PasswordChar = '●';
        }
    }
}
