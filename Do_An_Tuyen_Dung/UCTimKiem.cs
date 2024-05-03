using Do_An_Tuyen_Dung.FUngVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Do_An_Tuyen_Dung
{
    public partial class UCTimKiem : UserControl
    {
        Modify modify = new Modify();
        SqlConnection connStr = Connection.GetSqlConnection();
        TimKiem timKiem;

        string nganh1;
        string dd;
        string luong2;
        string kn;

        string tencty;
        string emhr;
        string tenuv;
        string emuv;

        public UCTimKiem()
        {
            InitializeComponent();
        }
        public UCTimKiem(TimKiem timKiem)
        {
            InitializeComponent();
            this.timKiem = timKiem;
            nganh1 = timKiem.Nganh;
            txtNganh1.Text = "Ngành : " + timKiem.Nganh;
            dd = timKiem.Diadiem;
            txtDiaDiem1.Text = "Địa Điểm : " + timKiem.Diadiem;
            luong2 = timKiem.Luong;
            txtLuong1.Text = "Lương : " + timKiem.Luong;
            kn = timKiem.KinhNghiem;
            txtKinhNghiem1.Text = "Kinh Nghiệm : " + timKiem.KinhNghiem;
            ThongTinHR();
            ThongTinUV();
        }
        public string UCTimKiem1()
        {
            return this.nganh1;
        }
        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            string nganhDuocChon = nganh1;
            FMoTa_YeuCau_QuyenLoi fMoTa_YeuCau_QuyenLoi = new FMoTa_YeuCau_QuyenLoi(nganhDuocChon);
            fMoTa_YeuCau_QuyenLoi.Show();
        }


        public void ThongTinHR()
        {
            string query = "SELECT TenCongViec,Luong,KinhNghiem,Tinh_TP,TenCTy,EmailHR FROM DangBaiNTD INNER JOIN ThongTinCTy_Chinh on DangBaiNTD.EmailHR = ThongTinCTy_Chinh.EmailHR ";
            SqlCommand command = new SqlCommand(query, connStr);
            connStr.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string nganh = reader["TenCongViec"].ToString();
                string diaDiem = reader["Tinh_TP"].ToString();
                string luong = reader["Luong"].ToString();
                string kinhNghiem = reader["KinhNghiem"].ToString();
                if (nganh == nganh1 && dd == diaDiem && luong == luong2 && kn == kinhNghiem)
                {
                    tencty = reader["TenCTy"].ToString();
                    emhr = reader["EmailHR"].ToString();
                }
            }

        }

        public void ThongTinUV()
        {
            string query = "SELECT HoTenUV,Email,TenTaiKhoan FROM TaoTaiKhoan JOIN NhapThongTinUV WHERE TaoTaiKhoan.Email = NhapThongTinUV.Email";
            SqlCommand command = new SqlCommand(query, connStr);
            connStr.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string tk = reader["TenTaiKhoan"].ToString();
                if (tk == FLogin.TenTaiKhoan)
                {
                    tenuv = reader["HoTenUV"].ToString();
                    emuv = reader["Email"].ToString();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) // hủy yêu thích
        {
            this.pictureBox2.Hide();
            pictureBox1.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e) // thêm yêu thích
        {
            this.pictureBox1.Hide();
            pictureBox2.Show();

        }
    }
}
