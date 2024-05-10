namespace Do_An_Tuyen_Dung.FUngVien
{
    partial class FThongBao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FThongBao));
            panel1 = new Panel();
            label1 = new Label();
            fpnHT = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1205, 93);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 21);
            label1.Name = "label1";
            label1.Size = new Size(525, 41);
            label1.TabIndex = 0;
            label1.Text = "Thông Báo Về Đơn Xin Việc Của Bạn";
            // 
            // fpnHT
            // 
            fpnHT.BackColor = Color.Transparent;
            fpnHT.Location = new Point(0, 99);
            fpnHT.Name = "fpnHT";
            fpnHT.Size = new Size(1223, 651);
            fpnHT.TabIndex = 1;
            fpnHT.Paint += fpnHT_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1078, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FThongBao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1205, 701);
            Controls.Add(panel1);
            Controls.Add(fpnHT);
            Name = "FThongBao";
            Text = "FThongBao";
            Load += FThongBao_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel fpnHT;
        private Label label1;
        private PictureBox pictureBox1;
    }
}