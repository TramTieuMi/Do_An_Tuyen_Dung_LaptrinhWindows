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

namespace Do_An_Ung_Dung_Tim_Viec
{
    public partial class FXemUV : Form
    {
        SqlConnection connStr = Connection.GetSqlConnection();
        Modify modify = new Modify();
        public FXemUV()
        {
            InitializeComponent();
        }
        public FXemUV(string tenCTy, string tenCV)
        {
            InitializeComponent();
            txtNganh.Text = tenCV;
            LoadDanhSach(tenCTy, tenCV);
        }
        public void LoadDanhSach(string tenCTy, string tenCV)
        {
            List<XemUV> list = new List<XemUV>();
            try
            {
                string query = "SELECT * FROM TinhTrangCV ";
                SqlCommand command = new SqlCommand(query, connStr);
                connStr.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (tenCTy == reader["TenCTy"].ToString() && tenCV == reader["TenCongViec"].ToString())
                    {
                        string hoten = reader["TenUV"].ToString();
                        string email = reader["EmailUV"].ToString();
                        string emailHR = reader["EmailHR"].ToString();
                        XemUV xem = new XemUV(hoten, email, emailHR);

                        list.Add(xem);
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
            foreach (XemUV x in list)
            {
                UCXemUV ucXem = new UCXemUV(x);
                int dis = (fpn_HienThi.Height - (6 * ucXem.Height)) / 10;
                ucXem.Margin = new Padding(0, dis, 0, 0);
                fpn_HienThi.Controls.Add(ucXem);
            }

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Combobox_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FXemUV_Load(object sender, EventArgs e)
        {

        }

        private void fpn_HienThi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        bool liked = false;
        //like
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Hide();
            pictureBox2.Show();

        }

        //unlike
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.pictureBox2.Hide();
            pictureBox1.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fpnHT_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
