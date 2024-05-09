using Do_An_Tuyen_Dung.FUngVien;
using Do_An_Ung_Dung_Tim_Viec;
using Do_An_Ung_Dung_Tim_Viec.FORM_NTD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Do_An_Tuyen_Dung
{
    public partial class UCTinhTrang : UserControl
    {
        TinhTrang tinhTrang;
        SqlConnection connStr = Connection.GetSqlConnection();
        string nganhdc = string.Empty;
        public UCTinhTrang()
        {
            InitializeComponent();
        }
        public UCTinhTrang(TinhTrang tinhTrang)
        {
            InitializeComponent();
            this.tinhTrang = tinhTrang;
            txtNganh.Text = "Ngành : " + tinhTrang.Nganh;
            nganhdc = tinhTrang.Nganh;
            txtDiaDiem.Text = "Địa Điểm : " + tinhTrang.DiaDiem;
            txtCTy.Text = "Tên Công Ty : " + tinhTrang.Cty;
        }
        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            string nganhDuocChon = nganhdc;
            FMoTa_YeuCau_QuyenLoi fMoTa_YeuCau_QuyenLoi = new FMoTa_YeuCau_QuyenLoi(nganhDuocChon);
            fMoTa_YeuCau_QuyenLoi.Show();
        }
        public void Xoa()
        {
            try
            {
                string query = string.Format("DELETE FROM TinhTrangCV WHERE TenCongViec = '{0}' AND TenCTy = '{1}'", txtNganh.Text, txtCTy.Text);
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
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    this.pictureBox1.Hide();
        //    pictureBox2.Show();
        //}

        //private void pictureBox2_Click(object sender, EventArgs e)
        //{
        //    this.pictureBox2.Hide();
        //    pictureBox1.Show();
        //}
    }
}
