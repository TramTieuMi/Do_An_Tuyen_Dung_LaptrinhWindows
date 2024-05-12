namespace Do_An_Tuyen_Dung
{
    partial class FXemDanhGia_NTD
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fpnHT = new FlowLayoutPanel();
            txtTenCVvaCTy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // fpnHT
            // 
            fpnHT.Location = new Point(21, 97);
            fpnHT.Name = "fpnHT";
            fpnHT.Size = new Size(1025, 400);
            fpnHT.TabIndex = 0;
            // 
            // txtTenCVvaCTy
            // 
            txtTenCVvaCTy.BackColor = Color.Transparent;
            txtTenCVvaCTy.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtTenCVvaCTy.ForeColor = Color.White;
            txtTenCVvaCTy.Location = new Point(242, 26);
            txtTenCVvaCTy.Name = "txtTenCVvaCTy";
            txtTenCVvaCTy.Size = new Size(545, 43);
            txtTenCVvaCTy.TabIndex = 1;
            txtTenCVvaCTy.Text = "Những Đánh Giá Của Ngành ở CôngTy \r\n";
            // 
            // FXemDanhGia_NTD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 509);
            Controls.Add(txtTenCVvaCTy);
            Controls.Add(fpnHT);
            Name = "FXemDanhGia_NTD";
            Text = "FXemDanhGia_NTD";
            Load += FXemDanhGia_NTD_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel fpnHT;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtTenCVvaCTy;
    }
}