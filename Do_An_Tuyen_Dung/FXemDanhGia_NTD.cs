using Do_An_Tuyen_Dung;
using Do_An_Tuyen_Dung.FNhaTuyenDung;
using Do_An_Tuyen_Dung.FUngVien;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Do_An_Tuyen_Dung
{
    public partial class FXemDanhGia_NTD : Form
    {
        Modify modify = new Modify();
        SqlConnection connStr = Connection.GetSqlConnection();
        public FXemDanhGia_NTD()
        {
            InitializeComponent();
        }
        public FXemDanhGia_NTD(string tencv, string tencty)
        {
            InitializeComponent();
            LoadData(tencv, tencty);
        }
        private void FXemDanhGia_NTD_Load(object sender, EventArgs e)
        {

        }
        public void LoadData(string tencv, string tencty)
        {
            List<DanhGia> list = new List<DanhGia>();
            try
            {
                FYeuThich fYeuThich = new FYeuThich();
                string em = fYeuThich.Email(FLogin.TenTaiKhoan);
                string query = "SELECT * FROM TinhTrangCV";
                SqlCommand command = new SqlCommand(query, connStr);
                connStr.Open();
                SqlDataReader reader = command.ExecuteReader();
                fpnHT.Controls.Clear();
                while (reader.Read())
                {
                    if (reader["EmailUV"].ToString() == em && reader["TenCongViec"].ToString() == tencv)
                    {
                        string sosao = reader["SoSao"].ToString();
                        string noidung = reader["NoiDungDanhGia"].ToString();
                        string thoigian = reader["ThoiGianDanhGia"].ToString();
                        string tenuv = reader["TenUV"].ToString();
                        DanhGia danhGia = new DanhGia(tencty, sosao, noidung, thoigian, tenuv);

                        list.Add(danhGia);
                    }

                }
                txtTenCVvaCTy.Text = "Những Đánh Giá Cho Công Việc " + tencv + " Của Công Ty " + tencty;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }
            finally
            {
                connStr.Close();
            }
            foreach (DanhGia l in list)
            {
                UC_DanhGia ucdg = new UC_DanhGia(l);
                int dis = (fpnHT.Height - (6 * ucdg.Height)) / 10;
                ucdg.Margin = new Padding(0, dis, 0, 0);
                fpnHT.Controls.Add(ucdg);
            }
        }

        private void fpnHT_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
