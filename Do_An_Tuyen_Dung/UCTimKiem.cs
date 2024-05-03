using Do_An_Tuyen_Dung.FUngVien;
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
using static System.Net.Mime.MediaTypeNames;

namespace Do_An_Tuyen_Dung
{
    public partial class UCTimKiem : UserControl
    {
        Modify modify = new Modify();
        SqlConnection connStr = Connection.GetSqlConnection();
        TimKiem timKiem;

       
        string dd;
        string luong2;
        string kn;

        string tenuv;

        // TenCV,tencty,emhr,emuv
        string TenCV;
        string tencty;
        string emhr;
        string emuv;



        public UCTimKiem()
        {
            InitializeComponent();
        }
        public UCTimKiem(TimKiem timKiem)
        {
            InitializeComponent();
            this.timKiem = timKiem;
            TenCV = timKiem.Nganh;
            txtNganh1.Text = "Ngành : " + timKiem.Nganh;
            dd = timKiem.Diadiem;
            txtDiaDiem1.Text = "Địa Điểm : " + timKiem.Diadiem;
            luong2 = timKiem.Luong;
            txtLuong1.Text = "Lương : " + timKiem.Luong;
            kn = timKiem.KinhNghiem;
            txtKinhNghiem1.Text = "Kinh Nghiệm : " + timKiem.KinhNghiem;
            ThongTinHR();
            ThongTinUV();
        }
        public string UCTimKiem1()
        {
            return this.TenCV;
        }
        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            string nganhDuocChon = TenCV;
            FMoTa_YeuCau_QuyenLoi fMoTa_YeuCau_QuyenLoi = new FMoTa_YeuCau_QuyenLoi(nganhDuocChon);
            fMoTa_YeuCau_QuyenLoi.Show();
        }


        public void ThongTinHR()
        {
            string query = "SELECT TenCongViec,Luong,KinhNghiem,Tinh_TP,TenCTy,DangBaiNTD.EmailHR FROM DangBaiNTD INNER JOIN ThongTinCTy_Chinh ON DangBaiNTD.EmailHR = ThongTinCTy_Chinh.EmailHR ";
            SqlCommand command = new SqlCommand(query, connStr);
            connStr.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string nganh = reader["TenCongViec"].ToString();
                string diaDiem = reader["Tinh_TP"].ToString();
                string luong = reader["Luong"].ToString();
                string kinhNghiem = reader["KinhNghiem"].ToString();
                if (nganh == TenCV && dd == diaDiem && luong == luong2 && kn == kinhNghiem)
                {
                    tencty = reader["TenCTy"].ToString();
                    emhr = reader["EmailHR"].ToString();
                }
            }
            connStr.Close();
        }

        public void ThongTinUV()
        {
            string query = "SELECT HoTenUV,TaoTaiKhoan.Email,TenTaiKhoan FROM TaoTaiKhoan INNER JOIN NhapThongTinUV ON TaoTaiKhoan.Email = NhapThongTinUV.Email";
            SqlCommand command = new SqlCommand(query, connStr);
            connStr.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string tk = reader["TenTaiKhoan"].ToString();
                if (tk == FLogin.TenTaiKhoan)
                {
                    tenuv = reader["HoTenUV"].ToString();
                    emuv = reader["Email"].ToString();
                }
            }
            connStr.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e) // hủy yêu thích
        {
            this.pictureBox2.Hide();
            pictureBox1.Show();

            try
            {
                string query = string.Format("DELETE FROM YeuThich WHERE TenCV = '{0}', EmailHR = '{1}' )", TenCV, emhr);
                SqlCommand command = new SqlCommand(query, connStr);

                connStr.Open();
                if (command.ExecuteNonQuery() > 0)
                    MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi : " + ex.Message);
            }
            finally
            {
                connStr.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) // thêm yêu thích
        {
            this.pictureBox1.Hide();
            pictureBox2.Show();
            //code
         
      
       
          

         

           
            try
            {
                // Use parameterized query for security and clarityVALUES (@TenCV,@TenCTy,@EmailHR,@email
                string query2 = "INSERT INTO YeuThich (TenCV,TenCTy,EmailHR,EmailUV) UV)";

                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        // Add parameters for security
                        command.Parameters.AddWithValue("@TenCV", TenCV);
                        command.Parameters.AddWithValue("@TenCTy", tencty);
                        command.Parameters.AddWithValue("@EmailHR", emhr);
                        command.Parameters.AddWithValue("@EmailUV", emuv);
                        
                        //label1.Text = DiaDiem;

                        connection.Open();
                        command.ExecuteNonQuery(); // Use ExecuteNonQuery for INSERT

                        MessageBox.Show("Yêu thích thành công!");
                        //this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Yêu thích thất bại do lỗi SQL: " + ex.Message);
            }
            catch (Exception ex) // Catch any other exceptions
            {
                MessageBox.Show("Yêu thích thất bại do lỗi không xác định: " + ex.Message);
            }

        }
    }
}
