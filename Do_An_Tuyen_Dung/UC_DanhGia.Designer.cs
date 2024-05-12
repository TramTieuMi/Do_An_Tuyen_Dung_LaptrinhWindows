namespace Do_An_Tuyen_Dung
{
    partial class UC_DanhGia
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtThoiGian = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtNoiDung = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtTenUV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtSoSao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // txtThoiGian
            // 
            txtThoiGian.BackColor = Color.Transparent;
            txtThoiGian.Location = new Point(47, 114);
            txtThoiGian.Name = "txtThoiGian";
            txtThoiGian.Size = new Size(148, 22);
            txtThoiGian.TabIndex = 7;
            txtThoiGian.Text = "Thời gian đã đánh giá";
            // 
            // txtNoiDung
            // 
            txtNoiDung.BackColor = Color.Transparent;
            txtNoiDung.Location = new Point(272, 76);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(182, 22);
            txtNoiDung.TabIndex = 6;
            txtNoiDung.Text = "Nội dung đánh giá chỗ này";
            // 
            // txtTenUV
            // 
            txtTenUV.BackColor = Color.Transparent;
            txtTenUV.Location = new Point(47, 41);
            txtTenUV.Name = "txtTenUV";
            txtTenUV.Size = new Size(135, 22);
            txtTenUV.TabIndex = 5;
            txtTenUV.Text = "Tên người đánh giá:";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(478, 8);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(64, 22);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "Đánh Giá";
            // 
            // txtSoSao
            // 
            txtSoSao.BackColor = Color.Transparent;
            txtSoSao.Location = new Point(272, 48);
            txtSoSao.Name = "txtSoSao";
            txtSoSao.Size = new Size(237, 22);
            txtSoSao.TabIndex = 8;
            txtSoSao.Text = "chỗ này để làm đnash giá sao riêng";
            // 
            // UC_DanhGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSoSao);
            Controls.Add(txtThoiGian);
            Controls.Add(txtNoiDung);
            Controls.Add(txtTenUV);
            Controls.Add(guna2HtmlLabel1);
            Name = "UC_DanhGia";
            Size = new Size(1025, 150);
            Load += UC_DanhGia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel txtThoiGian;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtNoiDung;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtTenUV;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtSoSao;
    }
}
