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
            RS_danhgia = new Guna.UI2.WinForms.Guna2RatingStar();
            SuspendLayout();
            // 
            // txtThoiGian
            // 
            txtThoiGian.BackColor = Color.Transparent;
            txtThoiGian.Font = new Font("Segoe UI", 10.2F);
            txtThoiGian.Location = new Point(54, 41);
            txtThoiGian.Margin = new Padding(3, 2, 3, 2);
            txtThoiGian.Name = "txtThoiGian";
            txtThoiGian.Size = new Size(224, 21);
            txtThoiGian.TabIndex = 7;
            txtThoiGian.Text = "Thời gian đã đánh giá: 20/022/2022";
            // 
            // txtNoiDung
            // 
            txtNoiDung.BackColor = Color.Transparent;
            txtNoiDung.Font = new Font("Segoe UI", 10.2F);
            txtNoiDung.Location = new Point(377, 26);
            txtNoiDung.Margin = new Padding(3, 2, 3, 2);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(204, 21);
            txtNoiDung.TabIndex = 6;
            txtNoiDung.Text = "nội dung đánh giá truyền vô đây";
            // 
            // txtTenUV
            // 
            txtTenUV.BackColor = Color.Transparent;
            txtTenUV.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtTenUV.Location = new Point(55, 13);
            txtTenUV.Margin = new Padding(3, 2, 3, 2);
            txtTenUV.Name = "txtTenUV";
            txtTenUV.Size = new Size(180, 21);
            txtTenUV.TabIndex = 5;
            txtTenUV.Text = "truyền tên người đánh giá:";
            // 
            // RS_danhgia
            // 
            RS_danhgia.FillColor = Color.DarkGray;
            RS_danhgia.FocusedColor = Color.DarkGray;
            RS_danhgia.Location = new Point(768, 26);
            RS_danhgia.Margin = new Padding(3, 2, 3, 2);
            RS_danhgia.Name = "RS_danhgia";
            RS_danhgia.Size = new Size(105, 21);
            RS_danhgia.TabIndex = 0;
            RS_danhgia.ValueChanged += RS_danhgia_ValueChanged_1;
            // 
            // UC_DanhGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(RS_danhgia);
            Controls.Add(txtThoiGian);
            Controls.Add(txtNoiDung);
            Controls.Add(txtTenUV);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_DanhGia";
            Size = new Size(912, 75);
            Load += UC_DanhGia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel txtThoiGian;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtNoiDung;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtTenUV;
        private Guna.UI2.WinForms.Guna2RatingStar RS_danhgia;
    }
}
