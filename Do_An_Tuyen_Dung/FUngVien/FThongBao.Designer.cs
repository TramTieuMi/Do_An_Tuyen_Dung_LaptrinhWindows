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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1054, 59);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 16);
            label1.Name = "label1";
            label1.Size = new Size(428, 32);
            label1.TabIndex = 0;
            label1.Text = "Thông Báo Về Đơn Xin Việc Của Bạn";
            // 
            // fpnHT
            // 
            fpnHT.BackColor = Color.Transparent;
            fpnHT.Location = new Point(0, 74);
            fpnHT.Margin = new Padding(3, 2, 3, 2);
            fpnHT.Name = "fpnHT";
            fpnHT.Size = new Size(1070, 488);
            fpnHT.TabIndex = 1;
            fpnHT.Paint += fpnHT_Paint;
            // 
            // FThongBao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1054, 526);
            Controls.Add(panel1);
            Controls.Add(fpnHT);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FThongBao";
            Text = "FThongBao";
            Load += FThongBao_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel fpnHT;
        private Label label1;
    }
}