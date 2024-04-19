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
    public partial class UCThongBao : UserControl
    {
        ThongBao thongBao;
        public UCThongBao()
        {
            InitializeComponent();
        }
        public UCThongBao(ThongBao thongBao)
        {
            InitializeComponent();
            this.thongBao = thongBao;
            txtNganh.Text = "Ngành : " + thongBao.Tencv;
            txtTenCTy.Text = "Công Ty : " + thongBao.Tencty;
            txtTB.Text = "Đơn Xin Việc Của Bạn " + thongBao.TrangThai;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_TB_Click(object sender, EventArgs e)
        {

        }
    }
}
