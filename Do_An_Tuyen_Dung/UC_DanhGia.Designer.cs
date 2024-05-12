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
            txtThoiGian.Location = new Point(62, 55);
            txtThoiGian.Name = "txtThoiGian";
            txtThoiGian.Size = new Size(239, 22);
            txtThoiGian.TabIndex = 7;
            txtThoiGian.Text = "Thời gian đã đánh giá: 20/022/2022";
            // 
            // txtNoiDung
            // 
            txtNoiDung.BackColor = Color.Transparent;
            txtNoiDung.Location = new Point(431, 34);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(217, 22);
            txtNoiDung.TabIndex = 6;
            txtNoiDung.Text = "nội dung đánh giá truyền vô đây";
            // 
            // txtTenUV
            // 
            txtTenUV.BackColor = Color.Transparent;
            txtTenUV.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTenUV.Location = new Point(63, 17);
            txtTenUV.Name = "txtTenUV";
            txtTenUV.Size = new Size(219, 25);
            txtTenUV.TabIndex = 5;
            txtTenUV.Text = "truyền tên người đánh giá:";
            // 
            // RS_danhgia
            // 
            RS_danhgia.BorderColor = Color.SteelBlue;
            RS_danhgia.Location = new Point(782, 34);
            RS_danhgia.Name = "RS_danhgia";
            RS_danhgia.Size = new Size(223, 35);
            RS_danhgia.TabIndex = 146;
            RS_danhgia.ValueChanged += RS_danhgia_ValueChanged;
            // 
            // UC_DanhGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(RS_danhgia);
            Controls.Add(txtThoiGian);
            Controls.Add(txtNoiDung);
            Controls.Add(txtTenUV);
            Name = "UC_DanhGia";
            Size = new Size(1042, 100);
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
