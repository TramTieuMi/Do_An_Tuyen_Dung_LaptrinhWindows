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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FXemDanhGia_NTD));
            fpnHT = new FlowLayoutPanel();
            txtTenCVvaCTy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel1 = new Panel();
            panel1.SuspendLayout();
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
            txtTenCVvaCTy.Location = new Point(80, 22);
            txtTenCVvaCTy.Name = "txtTenCVvaCTy";
            txtTenCVvaCTy.Size = new Size(545, 43);
            txtTenCVvaCTy.TabIndex = 1;
            txtTenCVvaCTy.Text = "Những Đánh Giá Của Ngành ở CôngTy \r\n";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(txtTenCVvaCTy);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 90);
            panel1.TabIndex = 2;
            // 
            // FXemDanhGia_NTD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1066, 509);
            Controls.Add(fpnHT);
            Controls.Add(panel1);
            Name = "FXemDanhGia_NTD";
            Text = "FXemDanhGia_NTD";
            Load += FXemDanhGia_NTD_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel fpnHT;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtTenCVvaCTy;
        private Panel panel1;
    }
}