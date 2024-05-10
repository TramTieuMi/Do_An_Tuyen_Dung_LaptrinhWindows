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

namespace Do_An_Tuyen_Dung
{
    public partial class ucYeuThich : UserControl
    {
        YeuThich yeuThich;
        SqlConnection connStr = Connection.GetSqlConnection();
        public ucYeuThich()
        {
            InitializeComponent();
        }
        public ucYeuThich(YeuThich yeuThich)
        {
            InitializeComponent();
            this.yeuThich = yeuThich;
            txtcty.Text = yeuThich.Tencty;
            txtcv.Text = yeuThich.Tencv;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //this.pictureBox2.Hide();
            //pictureBox3.Show();
        }

        

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcv_Click(object sender, EventArgs e)
        {

        }

        private void txtcty_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Hide unfavorite button and show favorite button
            this.pictureBox1.Visible = true;
            this.pictureBox2.Visible = false;
            pictureBox1.Show();

            try
            {
                // Use parameterized query for security
                string query = "DELETE FROM YeuThich WHERE TenCV = @TenCV AND TenCTy = @TenCTy";
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenCV", txtcv.Text);
                        command.Parameters.AddWithValue("@TenCTy", txtcty.Text);

                        connection.Open();
                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Xóa thành công (Delete successful)");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mục yêu thích (Favorite not found)");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Yêu thích thất bại do lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yêu thích thất bại do lỗi không xác định: " + ex.Message);
            }
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}