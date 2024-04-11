using Do_An_Tuyen_Dung;
using Do_An_Tuyen_Dung.FNhaTuyenDung;
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

namespace Do_An_Tuyen_Dung.FUngVien
{
    public partial class FThongBao : Form
    {
        SqlConnection connStr = Connection.GetSqlConnection();
        public FThongBao()
        {
            InitializeComponent();
            LoaDuDieu();
        }

        private void FThongBao_Load(object sender, EventArgs e)
        {

        }
        public void LoaDuDieu()
        {
            List<ThongBao> list = new List<ThongBao>();
            try
            {
                string query = "SELECT TenCongViec,TenCTy,TenTaiKhoan,TrangThai FROM TinhTrangCV JOIN TaoTaiKhoan ON TinhTrangCV.EmailUV = TaoTaiKhoan.Email ";
                SqlCommand command = new SqlCommand(query, connStr);
                connStr.Open();
                SqlDataReader reader = command.ExecuteReader();
                fpnHT.Controls.Clear();
                while (reader.Read())
                {
                    if (reader["TenTaiKhoan"].ToString() == FLogin.TenTaiKhoan)
                    {
                        string nganh = reader["TenCongViec"].ToString();
                        string tencty = reader["TenCTy"].ToString();
                        string trangthai;
                        if (reader["TrangThai"].ToString() != "NULL")
                        {
                            trangthai = reader["TrangThai"].ToString();
                            
                        }
                        else
                        {
                            trangthai = "Đang Được Xem Xét";
                        }
                        ThongBao TB = new ThongBao(tencty, nganh, trangthai);

                        list.Add(TB);
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
            foreach (ThongBao t in list)
            {
                UCThongBao ucTB = new UCThongBao(t);
                int dis = (fpnHT.Height - (6 * ucTB.Height)) / 10;
                ucTB.Margin = new Padding(0, dis, 0, 0);
                fpnHT.Controls.Add(ucTB);
            }
        }
    }
}
