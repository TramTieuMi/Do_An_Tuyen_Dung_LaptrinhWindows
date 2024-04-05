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
    public partial class FForgotPassword : Form
    {
        public FForgotPassword()
        {
            InitializeComponent();
            txtBoxResult.Text = "";
        }
        Modify modify = new Modify();

        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            string email = txtBoxEmail.Text;
            if (email.Trim() == "") { MessageBox.Show("Vui lòng nhập chính xác email đã đăng kí!"); }
            else
            {
                string query = "SELECT * FROM DangNhap WHERE Email = '" + email + "'";
                if (modify.taiKhoans(query).Count != 0)
                {
                    txtBoxResult.ForeColor = Color.Black;
                    txtBoxResult.Text = modify.taiKhoans(query)[0].MatKhau;
                }
                else
                {
                    txtBoxResult.ForeColor = Color.Red;
                    txtBoxResult.Text = "Email này không chính xác hoăc chưa được đăng kí!";
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin login = new FLogin();
            login.ShowDialog();
            this.Close();
        }

        private void FForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
