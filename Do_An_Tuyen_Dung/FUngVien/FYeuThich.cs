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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Do_An_Tuyen_Dung.FUngVien
{
    public partial class FYeuThich : Form
    {
        Modify modify = new Modify();
        SqlConnection connStr = Connection.GetSqlConnection();
        public FYeuThich()
        {
            InitializeComponent();
            LoadData();
        }

        private void FYeuThich_Load(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            List<YeuThich> list = new List<YeuThich>();
            try
            {
                string em = Email(FLogin.TenTaiKhoan);
                string query = "SELECT * FROM YeuThich";
                SqlCommand command = new SqlCommand(query, connStr);
                connStr.Open();
                SqlDataReader reader = command.ExecuteReader();
                fpnHT.Controls.Clear();
                while (reader.Read())
                {
                    if (reader["EmailUV"].ToString() == em)
                    {
                        string nganh = reader["TenCV"].ToString();
                        string tenCTy = reader["TenCTy"].ToString();
                        YeuThich lich = new YeuThich(tenCTy, nganh);

                        list.Add(lich);
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
            foreach (YeuThich l in list)
            {
                ucYeuThich ucyt = new ucYeuThich(l);
                int dis = (fpnHT.Height - (6 * ucyt.Height)) / 10;
                ucyt.Margin = new Padding(0, 0, 0, 0);
                fpnHT.Controls.Add(ucyt);
            }
        }

        public string Email(string chuoi)
        {
            string em = string.Empty;
            DataTable dataTable1 = new DataTable();
            string sqlQuery1 = "SELECT TenTaiKhoan,Email FROM TaoTaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
            modify.TaiDuLieu(dataTable1, sqlQuery1, "@TenTaiKhoan", chuoi);
            if (dataTable1.Rows.Count > 0)
            {
                foreach (DataRow row1 in dataTable1.Rows)
                {
                    string TenTK = row1["TenTaiKhoan"].ToString();
                    if (TenTK == chuoi)
                    {
                        em = row1["Email"].ToString();
                    }
                }
            }
            return em;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
