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

namespace Do_An_Tuyen_Dung
{
    public partial class UCTimKiem : UserControl
    {
        TimKiem timKiem;
        string nganh;
        public UCTimKiem()
        {
            InitializeComponent();
        }
        public UCTimKiem(TimKiem timKiem)
        {
            InitializeComponent();
            this.timKiem = timKiem;
            nganh = timKiem.Nganh;
            txtNganh1.Text = "Ngành : " + timKiem.Nganh;
            txtDiaDiem1.Text = "Địa Điểm : " + timKiem.Diadiem;
            txtLuong1.Text = "Lương : " + timKiem.Luong;
            txtKinhNghiem1.Text = "Kinh Nghiệm : " + timKiem.KinhNghiem;
        }
        public string UCTimKiem1()
        {
            return this.nganh;
        }
        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            string nganhDuocChon = nganh;
            FMoTa_YeuCau_QuyenLoi fMoTa_YeuCau_QuyenLoi = new FMoTa_YeuCau_QuyenLoi(nganhDuocChon);
            fMoTa_YeuCau_QuyenLoi.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
