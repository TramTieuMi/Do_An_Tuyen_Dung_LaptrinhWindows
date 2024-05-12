using Do_An_Tuyen_Dung.FNhaTuyenDung;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Do_An_Tuyen_Dung
{
    public partial class UCXemUV : UserControl
    {
        
        Modify modify = new Modify();
        SqlConnection connStr = Connection.GetSqlConnection();
        XemUV xemUV = new XemUV();
        string EmailHR = string.Empty;
        string EmailUV = string.Empty;
        public UCXemUV()
        {
            InitializeComponent();
            
        }
        public UCXemUV(XemUV xemUV)
        {
            InitializeComponent();
            this.xemUV = xemUV;
            txtTen.Text = "Họ và Tên : " + xemUV.Ten;
            EmailUV = xemUV.Email;
            EmailHR = xemUV.EmailHR;
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FThongTin_UV fThongTin_UV = new FThongTin_UV(txtTen.Text, EmailUV);
            fThongTin_UV.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
            try
            {
                // Use parameterized query for security and clarity
       
                string query1 = "UPDATE TinhTrangCV " +
                                "SET TrangThai = 'Được Chấp Nhận' " +
                                "WHERE EmailHR = @EmailHR AND EmailUV = @EmailUV";

               
                {
                    using (SqlCommand command = new SqlCommand(query1, connStr))
                    {
                        // Add parameters for security
                     
                        command.Parameters.AddWithValue("@EmailHR", EmailHR);
                        command.Parameters.AddWithValue("@EmailUV", EmailUV);

                        connStr.Open();
                        int rowsAffected = command.ExecuteNonQuery(); // Use ExecuteNonQuery for UPDATE

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Chấp nhận thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Chấp nhận thất bại: EmailHR và EmailUV đã tồn tại.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Chấp nhận thất bại do lỗi SQL: " + ex.Message);
            }
            catch (Exception ex) // Catch any other exceptions
            {
                MessageBox.Show("Chấp nhận thất bại do lỗi không xác định: " + ex.Message);
            }
            FLichHen fLichHen = new FLichHen(EmailHR, EmailUV);
            fLichHen.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string TrangThai = "Bị Loại";


            try
            {
                // Use parameterized query for security and clarity
                string query = @"UPDATE TinhTrangCV
                SET TrangThai = 'Bị Loại'
                WHERE EmailHR = @EmailHR AND EmailUV = @EmailUV";

                
                {
                    using (SqlCommand command = new SqlCommand(query, connStr))
                    {
                        // Add parameters for security
                       
                        command.Parameters.AddWithValue("@EmailHR", EmailHR);
                        command.Parameters.AddWithValue("@EmailUV", EmailUV);


                        connStr.Open();
                        command.ExecuteNonQuery(); // Use ExecuteNonQuery for INSERT

                        MessageBox.Show("Loại thành công!");

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loại thất bại do lỗi SQL: " + ex.Message);
            }
            catch (Exception ex) // Catch any other exceptions
            {
                MessageBox.Show("Loại thất bại do lỗi không xác định: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pictureBox2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            pictureBox1.Show(); 
        }
        
    }
}
