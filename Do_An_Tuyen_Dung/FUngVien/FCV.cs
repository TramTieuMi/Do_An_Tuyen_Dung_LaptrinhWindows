using AxAcroPDFLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Tuyen_Dung.FUngVien
{
    public partial class FCV : Form
    {
        public FCV()
        {
            InitializeComponent();
        }

    private void btnDownload_Click(object sender, EventArgs e)
        {
        }
    

private void FCV_Load(object sender, EventArgs e)
        {


            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF |*.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //axAcropdf1.src = ofd.FileName;
            }
        }
    }
}
