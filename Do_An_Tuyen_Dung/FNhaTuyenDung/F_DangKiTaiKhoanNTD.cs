using Do_An_Ung_Dung_Tim_Viec.FORM_NTD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Do_An_Tuyen_Dung
{
    public partial class F_DangKiTaiKhoanNTD : Form
    {
        private string connectionString = @"Data Source=DESKTOP-UR1R776\SQLEXPRESS;Initial Catalog=DoAnNhom264;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public F_DangKiTaiKhoanNTD()
        {
            InitializeComponent();
        }

        private void F_DangKiTaiKhoanNTD_Load(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();
        private void btXong_DKTK_Click(object sender, EventArgs e)
        {
            string TenCongTy = txtTenCongTy.Text;
            string QuocGia = txtQuocGia.Text;
            string DanhMucKinhDoanh = txtDanhMucKinhDoanh.Text;
            string MaBuuChinh = txtMaBuuChinh.Text;
            string URL = txtURL.Text;
            string MaSoThue = txtMaSoThue.Text;
            string DiaChiVanPhong = txtDiaChiVP.Text;

            try
            {
                string query = "Insert into TaoTaiKhoanNTD values ('" + TenCongTy + "','" + QuocGia + "','" + DanhMucKinhDoanh + "','" + MaBuuChinh + "','" + URL + "','" + MaSoThue + "','" + DiaChiVanPhong + "')";
                modify.Command(query);
                MessageBox.Show("Đăng kí thành công!");
                this.Hide();
                FDangBai_NTD dangbai = new FDangBai_NTD();
                dangbai.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Đăng kí thất bại!");
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FDangBai_NTD dangbai = new FDangBai_NTD();
                dangbai.ShowDialog();
                this.Close();
            }
            catch
            {

            }
        }
    }
}
