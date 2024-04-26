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

namespace Do_An_Tuyen_Dung
{
    public partial class UCXemUV : UserControl
    {
        XemUV xemUV = new XemUV();
        string em;
        string emHR;
        public UCXemUV()
        {
            InitializeComponent();
        }
        public UCXemUV(XemUV xemUV)
        {
            InitializeComponent();
            this.xemUV = xemUV;
            txtTen.Text = "Họ và Tên : " + xemUV.Ten;
            em = xemUV.Email;
            emHR = xemUV.EmailHR;
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FThongTin_UV fThongTin_UV = new FThongTin_UV(txtTen.Text, em);
            fThongTin_UV.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FLichHen fLichHen = new FLichHen(emHR, em);
            fLichHen.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

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
