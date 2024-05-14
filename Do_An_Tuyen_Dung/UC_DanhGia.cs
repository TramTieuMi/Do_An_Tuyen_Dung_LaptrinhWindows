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

            // Validate data before assigning to UI elements
            if (danhGia != null)
            {
                txtTenUV.Text = danhGia.Tenuv;

                // Convert Sosao to integer safely using TryParse
                float sosaoInt;
                if (float.TryParse(danhGia.Sosao, out sosaoInt))
                {
                    RS_danhgia.Value = sosaoInt;
                }

                txtThoiGian.Text = danhGia.Thoigian;

                // Ensure NoiDung is not null before assigning
                if (danhGia.Noidung != null)
                {
                    txtNoiDung.Text = danhGia.Noidung;
                }
            }
        }

        private void RS_danhgia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RS_danhgia_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
