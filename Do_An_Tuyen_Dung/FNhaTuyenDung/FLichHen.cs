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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Do_An_Tuyen_Dung.FNhaTuyenDung
{
    public partial class FLichHen : Form
    {
        Modify modify = new Modify();
        SqlConnection connStr = Connection.GetSqlConnection();
        string EmailHR = string.Empty;
        string EmailUV = string.Empty;

        public FLichHen()
        {
            InitializeComponent();
            
        }
        public FLichHen(string emHR, string em)
        {
            InitializeComponent();
            LoadData(emHR, em);
            EmailHR = emHR;
            EmailUV = em;
        }
        private void FLichHen_Load_1(object sender, EventArgs e)
        {

        }
        public void LoadData(string emHR, string em)
        {
            try
            {
                string query = "SELECT * FROM TinhTrangCV";
                SqlCommand command = new SqlCommand(query, connStr);
                connStr.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["EmailHR"].ToString() == emHR && reader["EmailUV"].ToString() == em)
                    {
                        txtTenUV.Text = reader["TenUV"].ToString();
                        txtCVvaVItri.Text = reader["TenCTy"].ToString() + " cho vị trí " + reader["TenCongViec"].ToString();
                        break;
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



        private void btn_Luu_Click(object sender, EventArgs e)
        {
            // Hide unfavorite button and show favorite button
            DateTime ThoiGian = this.dtpThoiGian.Value;
            string DiaDiemGap = this.txtDiaDiemGap.Text;


            try
            {
                // Use parameterized query for security
                string query = "UPDATE TinhTrangCV SET ThoiGian = @ThoiGian, DiaDiemGap = @DiaDiemGap WHERE EmailHR = @EmailHR AND EmailUV = @EmailUV";
                {
                    using (SqlCommand command = new SqlCommand(query, connStr))
                    {
                        command.Parameters.AddWithValue("@ThoiGian", ThoiGian);
                        command.Parameters.AddWithValue("@DiaDiemGap", DiaDiemGap);
                        command.Parameters.AddWithValue("@EmailHR", EmailHR);
                        command.Parameters.AddWithValue("@EmailUV", EmailUV);

                        connStr.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Lưu thành công!");
                        this.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lưu thích thất bại do lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại do lỗi không xác định: " + ex.Message);
            }
        }

        private void txtCVvaVItri_Click(object sender, EventArgs e)
        {

        }

        private void dtpThoiGian_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaDiemGap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
