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
        public UCXemUV()
        {
            InitializeComponent();
        }
        public UCXemUV(XemUV xemUV)
        {
            InitializeComponent();
            this.xemUV = xemUV;
            txtTen.Text = xemUV.Ten;
            em = xemUV.Email;
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FThongTin_UV fThongTin_UV = new FThongTin_UV(txtTen.Text,em);
            fThongTin_UV.ShowDialog();
        }
    }
}
