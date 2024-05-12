using Do_An_Ung_Dung_Tim_Viec.FORM_NTD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection stringConnection = Connection.GetSqlConnection();
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
                SqlConnection connection = (stringConnection);
                MessageBox.Show("Đăng kí thành công!");
                this.Hide();
                FDangBai_NTD dangbai = new FDangBai_NTD();
                dangbai.ShowDialog();
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đăng kí thất bại do lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng kí thất bại do lỗi không xác định: " + ex.Message);
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
