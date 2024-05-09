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
using Image = System.Drawing.Image;

namespace Do_An_Tuyen_Dung.FNhaTuyenDung
{
    public partial class FThongTin_NTD : Form
    {
        Modify modify = new Modify();
        string tenTaiKhoan;
        public FThongTin_NTD()
        {
            InitializeComponent();
        }
        public FThongTin_NTD(string chuoi)
        {
            tenTaiKhoan = chuoi;
            InitializeComponent();
            ThucThi(tenTaiKhoan);
        }
        public void ThucThi(string tenTaiKhoan)
        {
            string em = "VanKien@gmail.com";

            DataTable dataTable = new DataTable();
            string sqlQuery = "SELECT TenCTy,Tinh_TP, Quan_Huyen, Xa_Phuong,SoNha, FileGiayPhep,TenHR, EmailHR,SDTHR FROM ThongTinCTy_Chinh WHERE EmailHR = @EmailHR";


            DataTable dataTable1 = new DataTable();
            string sqlQuery1 = "SELECT TenTaiKhoan,Email FROM TaoTaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
            modify.TaiDuLieu(dataTable1, sqlQuery1, "@TenTaiKhoan", tenTaiKhoan);
            if (dataTable1.Rows.Count > 0)
            {
                foreach (DataRow row1 in dataTable1.Rows)
                {
                    string TenTK = row1["TenTaiKhoan"].ToString();
                    if (TenTK == tenTaiKhoan)
                    {
                        em = row1["Email"].ToString();
                    }
                }
            }


            modify.TaiDuLieu(dataTable, sqlQuery, "@EmailHR", em);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string email = row["EmailHR"].ToString();
                    if (email == em)
                    {
                        txtTenCTy.Text = row["TenCTy"].ToString();
                        txtTinh_TP.Text = row["Tinh_TP"].ToString();
                        txtQuan_Huyen.Text = row["Quan_Huyen"].ToString();
                        txtXa_Phuong.Text = row["Xa_Phuong"].ToString();
                        txtSoNha.Text = row["SoNha"].ToString();
                        txtlinkFileCV.Text = row["FileGiayPhep"].ToString();
                        txtTenHR.Text = row["TenHR"].ToString();
                        txtEmailHR.Text = em;
                        txtSDTHR.Text = row["SDTHR"].ToString();

                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FThongTin_NTD_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTest_Click(object sender, EventArgs e)
        {

        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtlinkFileCV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1. Choose the picture file
            string picturePath = "C:\\Users\\nguye\\Source\\Repos\\Do_An_Tuyen_Dung_44\\Do_An_Tuyen_Dung\\Resources\\mau-giay-phep-dang-ky-kinh-doanh-ho-gia-dinh-744x1030.jpg"; // Replace with the actual path to your picture

            // 2. Check if the file exists
            if (!File.Exists(picturePath))
            {
                MessageBox.Show("Error: The picture file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Create a new Form to display the picture
            Form pictureForm = new Form();
            pictureForm.Text = "Picture";
            pictureForm.Size = new Size(744, 1030); // Adjust the size as needed

            // 4. Add a PictureBox to the Form
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = Image.FromFile(picturePath);
            pictureForm.Controls.Add(pictureBox);

            // 5. Show the Form
            pictureForm.ShowDialog();
        }
    }
}
