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
using AxAcroPDFLib;
using System.Net;

namespace Do_An_Tuyen_Dung.FUngVien
{
    public partial class FThongTin_UV : Form
    {
        Modify modify = new Modify();
        SqlConnection connStr = Connection.GetSqlConnection();
        public FThongTin_UV()
        {
            InitializeComponent();
            ThucThi(FLogin.TenTaiKhoan);
        }
        public FThongTin_UV(string tenUV, string email)
        {
            InitializeComponent();
            string tenTK = KiemTK(email);
            ThucThi(tenTK);
        }

        public string KiemTK(string email)
        {
            string tk = string.Empty;
            string query = "SELECT TenTaiKhoan,Email FROM TaoTaiKhoan";
            SqlCommand command = new SqlCommand(query, connStr);
            connStr.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["Email"].ToString() == email)
                {
                    tk = reader["TenTaiKhoan"].ToString();
                    break;
                }
            }
            return tk;
        }

        public void ThucThi(string tenTK)
        {
            FLogin fLogin = new FLogin();
            string em = "VanKien@gmail.com";
            DataTable dataTable = new DataTable();
            string sqlQuery = "SELECT HoTenUV, NgayThangNamSinh, NoiSinh, FileCV, Tinh_TP, Quan_Huyen, Xa_Phuong, SoNha,Email FROM NhapThongTinUV WHERE Email = @Email";


            DataTable dataTable1 = new DataTable();
            string sqlQuery1 = "SELECT TenTaiKhoan,Email FROM TaoTaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
            modify.TaiDuLieu(dataTable1, sqlQuery1, "@TenTaiKhoan", tenTK);
            if (dataTable1.Rows.Count > 0)
            {
                foreach (DataRow row1 in dataTable1.Rows)
                {
                    string TenTK = row1["TenTaiKhoan"].ToString();
                    if (TenTK == tenTK)
                    {
                        em = row1["Email"].ToString();
                    }
                }
            }

            modify.TaiDuLieu(dataTable, sqlQuery, "@Email", em);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string email = row["Email"].ToString();
                    if (email == em)
                    {
                        txtHoTen.Text = row["HoTenUV"].ToString();
                        txtNgayThangNamSinh.Text = row["NgayThangNamSinh"].ToString();
                        txtNoiSinh.Text = row["NoiSinh"].ToString();
                        txtTinh_TP.Text = row["Tinh_TP"].ToString();
                        txtQuan_Huyen.Text = row["Quan_Huyen"].ToString();
                        txtXa_Phuong.Text = row["Xa_Phuong"].ToString();
                        // txtGioiTinh.Text = row["GioiTinh"].ToString();
                        txtSoNha.Text = row["SoNha"].ToString();
                        txtlinkFileCV.Text = row["FileCV"].ToString();
                    }
                }
            }
        }

        private void FThongTin_UV_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtHoTen_Click(object sender, EventArgs e)
        {

        }

        private void txtlinkFileCV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FCV cv = new FCV();
            cv.ShowDialog();

            using (WebClient client = new WebClient())
            {
                try
                {
                    // Thay thế link dưới đây bằng đường dẫn tới file PDF bạn muốn download
                    string pdfUrl = "https://tenten.vn/tin-tuc/wp-content/uploads/2022/02/anh-cv-2-4.jpg\r\n";

                    // Thay đổi đường dẫn lưu file ở dưới đây
                    string savePath = "C:\\Users\\TieuMi\\Downloads";

                    client.DownloadFile(pdfUrl, savePath);
                    MessageBox.Show("Download completed!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void txtNgayThangNamSinh_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //// Create object of Open file dialog class  
            //{
            //    OpenFileDialog dlg = new OpenFileDialog();
            //    // set file filter of dialog   
            //    dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            //    dlg.ShowDialog();
            //    if (dlg.FileName != null)
            //    {
            //        // use the LoadFile(ByVal fileName As String) function for open the pdf in control  
            //        axAcropdf1.LoadFile(dlg.FileName);
            //    }
            //}
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF |*.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                axAcropdf1.src = ofd.FileName;
            }


        }

        private void axAcropdf1_Enter(object sender, EventArgs e)
        {

        }
    }
}
