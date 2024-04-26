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
    public partial class ucYeuThich : UserControl
    {
        YeuThich yeuThich;
        public ucYeuThich()
        {
            InitializeComponent();
        }
        public ucYeuThich(YeuThich yeuThich)
        {
            InitializeComponent ();
            this.yeuThich = yeuThich;
            txtcty.Text = yeuThich.Tencty;
            txtcv.Text = yeuThich.Tencv;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.pictureBox2.Hide();
            pictureBox3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.pictureBox3.Hide();
            pictureBox2.Show();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
