using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.SqlClient;
using System.Configuration;

namespace Do_An_Tuyen_Dung.FUngVien
{
    public partial class FNhapThongTin_UV : Form
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=backUp4;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public FNhapThongTin_UV()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();

        private string sqlConnection;


        private void FNhapThongTin_UV_Load(object sender, EventArgs e)
        {

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

            string tenUV = this.txtHoTen.Text;
            string noiSinh = this.txtNoiSinh.Text;
            DateTime ngayThang = this.dateNgayThangNamSinh.Value;
            string thanhPho = this.Combobox_Tinh_TP.Text;
            string huyen = this.Combobox_Quan_Huyen.Text;
            string xa = this.Combobox_Xa_Phuong.Text;
            string soNha = this.txtSoNha.Text;
            string fileCV = this.txtFileCV.Text;
            //string gioiTinh = this.txtGioiTinh.Text;
            try
            {
                // Use parameterized query for security and clarity
                string query = "INSERT INTO NhapThongTinUV (HoTenUV, NgayThangNamSinh, NoiSinh, FileCV, Tinh_TP, Quan_Huyen, Xa_Phuong, GioiTinh, SoNha) VALUES (@HoTenUV, @NgayThangNamSinh, @NoiSinh, @FileCV, @Tinh_TP, @Quan_Huyen, @Xa_Phuong, @GioiTinh, @SoNha)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters for security
                        command.Parameters.AddWithValue("@HoTenUV", tenUV);
                        command.Parameters.AddWithValue("@NgayThangNamSinh", ngayThang);
                        command.Parameters.AddWithValue("@NoiSinh", noiSinh);
                        command.Parameters.AddWithValue("@FileCV", fileCV);
                        command.Parameters.AddWithValue("@Tinh_TP", thanhPho);
                        command.Parameters.AddWithValue("@Quan_Huyen", huyen);
                        command.Parameters.AddWithValue("@Xa_Phuong", xa);
                        //command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        command.Parameters.AddWithValue("@SoNha", soNha);
                        // ... (add parameters for other fields)

                        connection.Open();
                        command.ExecuteNonQuery(); // Use ExecuteNonQuery for INSERT

                        MessageBox.Show("Đăng ungvien thành công!");
                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đăng việc thất bại do lỗi SQL: " + ex.Message);
            }
            catch (Exception ex) // Catch any other exceptions
            {
                MessageBox.Show("Đăng việc thất bại do lỗi không xác định: " + ex.Message);
            }


        }

        private void btn_TroLai_Click(object sender, EventArgs e)
        {
            Hide();
            FCreateAccount frm = new FCreateAccount();
            frm.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Combobox_Quan_Huyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
