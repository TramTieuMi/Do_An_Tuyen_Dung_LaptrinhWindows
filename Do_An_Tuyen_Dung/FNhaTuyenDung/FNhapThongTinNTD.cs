﻿using Do_An_Tuyen_Dung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Ung_Dung_Tim_Viec.FORM_NTD
{
    public partial class FNhapThongTinNTD : Form
    {
        private string connectionString = @"Data Source=KHANG\TEST1;Initial Catalog=backUp2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public FNhapThongTinNTD()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        NhapThongTinNTD nhapThongTin;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void NhapThongTin()
        {
            string tenCty = txtTenCTy.Text;
            string tinh_TP = Combobox_Tinh_TP.Text;
            string quan_Huyen = Combobox_Quan_Huyen.Text;
            string xa_Phuong = Combobox_Xa_Phuong.Text;
            string sonha = txtSoNha.Text;
            string fileGiayPhep = txtFileCV.Text;
            string tenHR = txtTenHR.Text;
            string emailHR = txtEmailHR.Text;
            string sDTHR = txtSDTHR.Text;
            string query = "INSERT INTO ThongTinCTy_Chinh VALUES (N'" + tenCty + "', N'" + tinh_TP + "', N'" + quan_Huyen + "', N'" + xa_Phuong + "', N'" + sonha + "', N'" + fileGiayPhep + "', N'" + tenHR + "', N'" + emailHR + "', N'" + sDTHR + "' )";
            try
            {

                MessageBox.Show("Nhập Thành Công");
                modify.Command(query);
            }
            catch
            {
                MessageBox.Show("Lỗi Khi Nhập");
            }
            nhapThongTin = new NhapThongTinNTD(tenCty, tinh_TP, quan_Huyen, xa_Phuong, sonha, fileGiayPhep, tenHR, emailHR, sDTHR);
        }
        public string TenCTY()
        {
            return txtTenCTy.Text;
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            Hide();
            FDangBai_NTD fDangBai_NTD = new FDangBai_NTD();
            fDangBai_NTD.ShowDialog();
        }

        private void FNhapThongTinNTD_Load(object sender, EventArgs e)
        {

        }

        private void btn_TroLai_Click(object sender, EventArgs e)
        {
            Hide();
            FCreateAccount fCreateAccount = new FCreateAccount();
            fCreateAccount.ShowDialog();
        }
    }
}
