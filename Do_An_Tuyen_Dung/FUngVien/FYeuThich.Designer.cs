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
            label1.Location = new Point(172, 24);
            label1.Name = "label1";
            label1.Size = new Size(419, 32);
            label1.TabIndex = 1;
            label1.Text = "Những Công Việc Bạn Đã Yêu Thích";
            // 
            // fpnHT
            // 
            fpnHT.BackColor = Color.Transparent;
            fpnHT.Location = new Point(0, 67);
            fpnHT.Margin = new Padding(3, 2, 3, 2);
            fpnHT.Name = "fpnHT";
            fpnHT.Size = new Size(1033, 418);
            fpnHT.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Location = new Point(0, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1032, 60);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(50, 14);
            guna2HtmlLabel1.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(422, 34);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Những Công Việc Yêu Thích Của Bạn";
            // 
            // FYeuThich
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1033, 488);
            Controls.Add(panel1);
            Controls.Add(fpnHT);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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