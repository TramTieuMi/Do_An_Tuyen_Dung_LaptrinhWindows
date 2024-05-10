namespace Do_An_Tuyen_Dung
{
    partial class ucYeuThich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucYeuThich));
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            txtcv = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtcty = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox4 = new PictureBox();
            guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = SystemColors.Control;
            guna2ShadowPanel1.Controls.Add(pictureBox2);
            guna2ShadowPanel1.Controls.Add(pictureBox1);
            guna2ShadowPanel1.Controls.Add(guna2HtmlLabel3);
            guna2ShadowPanel1.Controls.Add(panel1);
            guna2ShadowPanel1.Controls.Add(pictureBox4);
            guna2ShadowPanel1.FillColor = SystemColors.Control;
            guna2ShadowPanel1.Location = new Point(2, 1);
            guna2ShadowPanel1.Margin = new Padding(3, 2, 3, 2);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Transparent;
            guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            guna2ShadowPanel1.Size = new Size(226, 302);
            guna2ShadowPanel1.TabIndex = 0;
            guna2ShadowPanel1.Paint += guna2ShadowPanel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(194, 324);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(194, 324);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Location = new Point(42, 331);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(115, 17);
            guna2HtmlLabel3.TabIndex = 3;
            guna2HtmlLabel3.Text = "Thời Hạn: 20/12/2033";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(txtcv);
            panel1.Controls.Add(txtcty);
            panel1.Location = new Point(3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 251);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 41);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(225, 225);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 76;
            pictureBox5.TabStop = false;
            // 
            // txtcv
            // 
            txtcv.BackColor = Color.Transparent;
            txtcv.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtcv.ForeColor = Color.Black;
            txtcv.Location = new Point(88, 14);
            txtcv.Name = "txtcv";
            txtcv.Size = new Size(26, 23);
            txtcv.TabIndex = 0;
            txtcv.Text = "DA";
            txtcv.TextAlignment = ContentAlignment.TopCenter;
            txtcv.Click += txtcv_Click;
            // 
            // txtcty
            // 
            txtcty.BackColor = Color.Transparent;
            txtcty.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtcty.ForeColor = Color.Black;
            txtcty.Location = new Point(86, 229);
            txtcty.Margin = new Padding(3, 2, 3, 2);
            txtcty.Name = "txtcty";
            txtcty.Size = new Size(25, 21);
            txtcty.TabIndex = 2;
            txtcty.Text = "TEE";
            txtcty.TextAlignment = ContentAlignment.BottomCenter;
            txtcty.Click += txtcty_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(155, 262);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 75;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // ucYeuThich
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2ShadowPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucYeuThich";
            Size = new Size(228, 305);
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtcty;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtcv;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
