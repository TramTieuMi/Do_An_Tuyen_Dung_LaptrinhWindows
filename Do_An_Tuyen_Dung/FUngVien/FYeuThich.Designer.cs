namespace Do_An_Tuyen_Dung.FUngVien
{
    partial class FYeuThich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FYeuThich));
            label1 = new Label();
            fpnHT = new FlowLayoutPanel();
            panel1 = new Panel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(196, 32);
            label1.Name = "label1";
            label1.Size = new Size(515, 41);
            label1.TabIndex = 1;
            label1.Text = "Những Công Việc Bạn Đã Yêu Thích";
            // 
            // fpnHT
            // 
            fpnHT.BackColor = Color.Transparent;
            fpnHT.Location = new Point(0, 89);
            fpnHT.Name = "fpnHT";
            fpnHT.Size = new Size(1181, 558);
            fpnHT.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1179, 80);
            panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(57, 19);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(518, 43);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Những Công Việc Yêu Thích Của Bạn";
            // 
            // FYeuThich
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1181, 651);
            Controls.Add(panel1);
            Controls.Add(fpnHT);
            Controls.Add(label1);
            Name = "FYeuThich";
            Text = "FYeuThich";
            Load += FYeuThich_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel fpnHT;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}