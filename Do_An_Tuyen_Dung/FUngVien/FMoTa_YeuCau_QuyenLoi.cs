using Do_An_Tuyen_Dung;
using Do_An_Tuyen_Dung.FNhaTuyenDung;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Do_An_Tuyen_Dung.FUngVien
{
    public partial class FMoTa_YeuCau_QuyenLoi : Form
    {
        //private string connectionString = "Data Source=KHANG\\TEST1;Initial Catalog=\"DoAnNhom (2)\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connStr = Connection.GetSqlConnection();
        Modify modify = new Modify();
        string tenCV;
        string tencty;
        string DiaDiem = string.Empty;
        public FMoTa_YeuCau_QuyenLoi()
        {
            InitializeComponent();
        }
        public FMoTa_YeuCau_QuyenLoi(string nganhDuocChon)
        {

            InitializeComponent();
            tenCV = nganhDuocChon;
            LoadDuLieu(tenCV);
            AnNutNopDon(tenCV);
        }

        public void AnNutNopDon(string chuoi)
        {
            string query = "SELECT * FROM TinhTrangCV";
            SqlCommand command = new SqlCommand(query, connStr);
            connStr.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["TenCongViec"].ToString() == chuoi && reader["TenCTy"].ToString() == tencty)
                {
                    btn_NopDon.Visible = false;
                }
            }
            connStr.Close();
        }

        public void LoadDuLieu(string chuoi)
        {
            txtNganh.Text = chuoi;
            MoTaYeuCau moTaYeuCau = new MoTaYeuCau();
            try
            {
                DataTable dataTable = new DataTable();
                string query = "SELECT TenCongViec,Luong,KinhNghiem,HinhThuc,BHXH,BHYT,CoHoiThangTien,Luong13,MoTa,YeuCau,TenHR,EmailHR,SDTHR,ThoiGianBD,ThoiGianKT,GhiChu,QuyenLoiKhac FROM DangBaiNTD WHERE TenCongViec = @TenCongViec";
                modify.TaiDuLieu(dataTable, query, "@TenCongViec", chuoi);
                string em1 = string.Empty;
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string TenCV = row["TenCongViec"].ToString();
                        if (TenCV == chuoi)
                        {
                            txtLuong.Text = row["Luong"].ToString();
                            txtKinhNghiem.Text = row["KinhNghiem"].ToString();
                            txtHinhThuc.Text = row["HinhThuc"].ToString();
                            string chuoiQL = string.Empty;
                            if (row["BHXH"].ToString() == "True") chuoiQL = chuoiQL + "BHXH, ";
                            if (row["BHYT"].ToString() == "True") chuoiQL = chuoiQL + "BHYT, ";
                            if (row["CoHoiThangTien"].ToString() == "True") chuoiQL = chuoiQL + "Cơ Hội Thăng Tiến, ";
                            if (row["Luong13"].ToString() == "True") chuoiQL = chuoiQL + "Lương Tháng 13, ";
                            txtQuyenLoi.Text = chuoiQL + row["QuyenLoiKhac"].ToString();
                            txtMoTa.Text = row["MoTa"].ToString();
                            txtYeuCau.Text = row["YeuCau"].ToString();
                            txtTenHR.Text = row["TenHR"].ToString();
                            txtEmailHR.Text = row["EmailHR"].ToString();
                            em1 = txtEmailHR.Text;
                            txtSDTHR.Text = row["SDTHR"].ToString();
                            txtNgayBD.Text = row["ThoiGianBD"].ToString();
                            txtNgayKT.Text = row["ThoiGianKT"].ToString();
                            txtGhiChu.Text = row["GhiChu"].ToString();
                        }
                    }
                }

                DataTable dataTable1 = new DataTable();
                string query1 = "SELECT TenCTy,EmailHR,Tinh_TP FROM ThongTinCTy_Chinh WHERE EmailHR =@EmailHR";

                modify.TaiDuLieu(dataTable1, query1, "@EmailHR", em1);
                if (dataTable1.Rows.Count > 0)
                {
                    foreach (DataRow row1 in dataTable1.Rows)
                    {
                        string em = row1["EmailHR"].ToString();
                        if (em == em1)
                        {
                            txtCty.Text = row1["TenCTy"].ToString();
                            tencty = txtCty.Text;
                            DiaDiem = row1["Tinh_TP"].ToString();

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }
            finally
            {
                connStr.Close();
            }
        }
        public string LoadTenTK()
        {
            string eM = txtEmailHR.Text;
            DataTable dataTable = new DataTable();
            string query = "SELECT TenTaiKhoan,Email FROM TaoTaiKhoan WHERE Email = @Email";
            modify.TaiDuLieu(dataTable, query, "@Email", eM);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string em = row["Email"].ToString();
                    if (em == eM)
                    {
                        return row["TenTaiKhoan"].ToString();
                    }
                }
            }
            return ""; // Trả về chuỗi rỗng nếu không tìm thấy giá trị
        }
        private void FMoTa_YeuCau_QuyenLoi_Load(object sender, EventArgs e)
        {

        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            string tenTK1 = LoadTenTK();
            FThongTin_NTD fThongTin_NTD = new FThongTin_NTD(tenTK1);
            fThongTin_NTD.ShowDialog();
        }

        private void btn_NopDon_Click(object sender, EventArgs e)
        {
            string TenCongViec = txtNganh.Text;
            string TenCTy = txtCty.Text; // Set a default value if empty
            string EmailHR = txtEmailHR.Text;
            string TenUV = string.Empty;
            string EmailUV = string.Empty;
            DataTable dataTable1 = new DataTable();
            string query1 = "SELECT TenTaiKhoan,Email FROM TaoTaiKhoan Where TenTaiKhoan = @TenTaiKhoan";
            modify.TaiDuLieu(dataTable1, query1, "@TenTaiKhoan", FLogin.TenTaiKhoan);

            if (dataTable1.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable1.Rows)
                {
                    string tk = row["TenTaiKhoan"].ToString();
                    if (tk == FLogin.TenTaiKhoan)
                    {
                        EmailUV = row["Email"].ToString();
                    }
                }
            }

            DataTable dataTable = new DataTable();
            string query = "SELECT HoTenUV,Email FROM NhapThongTinUV Where Email = @Email";
            modify.TaiDuLieu(dataTable, query, "@Email", EmailUV);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string em1 = row["Email"].ToString();
                    if (em1 == EmailUV)
                    {
                        TenUV = row["HoTenUV"].ToString();

                    };
                }
            }
            try
            {
                // Use parameterized query for security and clarity
                string query2 = "INSERT INTO TinhTrangCV (TenCongViec,TenCTy,EmailHR,EmailUV,TenUV,DiaDiem) VALUES (@TenCongViec,@TenCTy,@EmailHR,@emailUV,@TenUV,@DiaDiem)";

                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        // Add parameters for security
                        command.Parameters.AddWithValue("@TenCongViec", TenCongViec);
                        command.Parameters.AddWithValue("@TenCTy", TenCTy);
                        command.Parameters.AddWithValue("@EmailHR", EmailHR);
                        command.Parameters.AddWithValue("@EmailUV", EmailUV);
                        command.Parameters.AddWithValue("@TenUV", TenUV);
                        command.Parameters.AddWithValue("@DiaDiem", DiaDiem);

                        connection.Open();
                        command.ExecuteNonQuery(); // Use ExecuteNonQuery for INSERT

                        MessageBox.Show("Nộp đơn thành công!");
                        //this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Nộp đơn thất bại do lỗi SQL: " + ex.Message);
            }
            catch (Exception ex) // Catch any other exceptions
            {
                MessageBox.Show("Nộp đơn thất bại do lỗi không xác định: " + ex.Message);
            }

        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCty_Click(object sender, EventArgs e)
        {

        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            FXemDanhGia_NTD fXemDanhGia_NTD = new FXemDanhGia_NTD(tenCV, tencty);
            fXemDanhGia_NTD.ShowDialog();
        }
    }
}
