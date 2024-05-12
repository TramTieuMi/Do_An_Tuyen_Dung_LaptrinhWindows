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
    public partial class UC_DanhGia : UserControl
    {
        SqlConnection connStr = Connection.GetSqlConnection();
        DanhGia danhGia;
        public UC_DanhGia()
        {
            InitializeComponent();
        }

        private void UC_DanhGia_Load(object sender, EventArgs e)
        {

        }
        public UC_DanhGia(DanhGia danhGia)
        {
            InitializeComponent();
            this.danhGia = danhGia;
            txtTenUV.Text = danhGia.Tenuv;
            txtSoSao.Text = Convert.ToString(danhGia.Sosao);
            txtThoiGian.Text = danhGia.Thoigian;
            txtNoiDung.Text = danhGia.Noidung;
        }
    }
}
