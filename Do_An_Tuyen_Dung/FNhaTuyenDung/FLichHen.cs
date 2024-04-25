using Do_An_Tuyen_Dung;
using Do_An_Tuyen_Dung.FNhaTuyenDung;
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


namespace Do_An_Tuyen_Dung.FNhaTuyenDung
{
    public partial class FLichHen : Form
    {
        Modify modify = new Modify();
        SqlConnection connStr = Connection.GetSqlConnection();
        public FLichHen()
        {
            InitializeComponent();

        }
        public FLichHen(string emHR, string em)
        {
            InitializeComponent();
            LoadData(emHR,em);
        }
        public void LoadData(string emHR, string em)
        {
            string query = "SELECT TenCongViec,TenCTy,EmailHR,EmailUV,TenUV FROM TinhTrangCV";
            SqlCommand command = new SqlCommand(query, connStr);
            connStr.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["EmailHR"].ToString() == emHR && reader["EmailUV"] == em)
                {
                    txtTenUV.Text = reader["TenUV"].ToString();
                    txtCVvaVItri.Text = reader["TenCTy"].ToString() + " cho vị trí " + reader["TenCongViec"].ToString;
                    break;
                }
            }           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
