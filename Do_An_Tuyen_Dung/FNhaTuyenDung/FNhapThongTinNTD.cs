using Do_An_Tuyen_Dung;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Do_An_Ung_Dung_Tim_Viec.FORM_NTD
{
    public partial class FNhapThongTinNTD : Form
    {
        SqlConnection stringConnection = Connection.GetSqlConnection();
        public FNhapThongTinNTD()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        NhapThongTinNTD nhapThongTin;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void NhapThongTin()
        {
            string tenCty = txtTenCTy.Text;
            string tinh_TP = Combobox_Tinh_TP.Text;
            string quan_Huyen = Combobox_Quan_Huyen.Text;
            string xa_Phuong = Combobox_Xa_Phuong.Text;
            string sonha = txtSoNha.Text;
            string fileGiayPhep = txtFileCV.Text; // Assuming fileGiayPhep stores the file path
            string tenHR = txtTenHR.Text;
            string emailHR = txtEmailHR.Text;
            int sDTHR = Convert.ToInt32(txtSDTHR.Text);

            // Validate input data (optional)
            // Add checks for empty fields, invalid formats, etc.

            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection()) // Use connection pooling
                {
                    connection.Open();

                    string query = "INSERT INTO ThongTinCTy_Chinh VALUES (N'" + tenCty + "', N'" + tinh_TP + "', N'" + quan_Huyen + "', N'" + xa_Phuong + "', N'" + sonha + "', N'" + fileGiayPhep + "', N'" + tenHR + "', N'" + emailHR + "', N'" + sDTHR + "' )";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@tenCty", tenCty);
                        command.Parameters.AddWithValue("@tinh_TP", tinh_TP);
                        command.Parameters.AddWithValue("@quan_Huyen", quan_Huyen);
                        command.Parameters.AddWithValue("@xa_Phuong", xa_Phuong);
                        command.Parameters.AddWithValue("@sonha", sonha);
                        command.Parameters.AddWithValue("@fileGiayPhep", fileGiayPhep);
                        command.Parameters.AddWithValue("@tenHR", tenHR);
                        command.Parameters.AddWithValue("@emailHR", emailHR);
                        command.Parameters.AddWithValue("@sDTHR", sDTHR);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Nhập Thành Công");
                            // Clear input fields (optional)
                            txtTenCTy.Text = "";
                            // ...
                        }
                        else
                        {
                            MessageBox.Show("Không có bản ghi nào được tạo.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: " + ex.Message);
            }

            // Consider creating a separate method for opening/closing connection for better separation of concerns

            nhapThongTin = new NhapThongTinNTD(tenCty, tinh_TP, quan_Huyen, xa_Phuong, sonha, fileGiayPhep, tenHR, emailHR, sDTHR); // Assuming this is for another purpose
        }


        private void FNhapThongTinNTD_Load(object sender, EventArgs e)
        {

        }

        private void btn_TroLai_Click(object sender, EventArgs e)
        {
            Hide();
            FCreateAccount fCreateAccount = new FCreateAccount();
            fCreateAccount.ShowDialog();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string tenCty = txtTenCTy.Text;
            string tinh_TP = Combobox_Tinh_TP.Text;
            string quan_Huyen = Combobox_Quan_Huyen.Text;
            string xa_Phuong = Combobox_Xa_Phuong.Text;
            string sonha = txtSoNha.Text;
            string fileGiayPhep = txtFileCV.Text; // Assuming fileGiayPhep stores the file path
            string tenHR = txtTenHR.Text;
            string emailHR = txtEmailHR.Text;
            int sDTHR = Convert.ToInt32(txtSDTHR.Text);

            // Validate input data (optional)
            // Add checks for empty fields, invalid formats, etc.

            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection()) // Use connection pooling
                {
                    connection.Open();

                    string query = "INSERT INTO ThongTinCTy_Chinh VALUES (N'" + tenCty + "', N'" + tinh_TP + "', N'" + quan_Huyen + "', N'" + xa_Phuong + "', N'" + sonha + "', N'" + fileGiayPhep + "', N'" + tenHR + "', N'" + emailHR + "', N'" + sDTHR + "' )";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@tenCty", tenCty);
                        command.Parameters.AddWithValue("@tinh_TP", tinh_TP);
                        command.Parameters.AddWithValue("@quan_Huyen", quan_Huyen);
                        command.Parameters.AddWithValue("@xa_Phuong", xa_Phuong);
                        command.Parameters.AddWithValue("@sonha", sonha);
                        command.Parameters.AddWithValue("@fileGiayPhep", fileGiayPhep);
                        command.Parameters.AddWithValue("@tenHR", tenHR);
                        command.Parameters.AddWithValue("@emailHR", emailHR);
                        command.Parameters.AddWithValue("@sDTHR", sDTHR);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Nhập Thành Công");
                            // Clear input fields (optional)
                          
                            // ...
                        }
                        else
                        {
                            MessageBox.Show("Không có bản ghi nào được tạo.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: " + ex.Message);
            }

            // Consider creating a separate method for opening/closing connection for better separation of concerns

            nhapThongTin = new NhapThongTinNTD(tenCty, tinh_TP, quan_Huyen, xa_Phuong, sonha, fileGiayPhep, tenHR, emailHR, sDTHR); // Assuming this is for another purpose
            Hide();
            FLogin fDangBai_NTD = new FLogin();
            fDangBai_NTD.ShowDialog();
        }
    }
}
