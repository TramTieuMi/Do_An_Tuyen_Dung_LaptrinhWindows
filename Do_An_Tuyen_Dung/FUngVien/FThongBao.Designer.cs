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
            panel1 = new Panel();
            label1 = new Label();
            fpnHT = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1039, 90);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 27);
            label1.Name = "label1";
            label1.Size = new Size(495, 38);
            label1.TabIndex = 0;
            label1.Text = "Thông Báo Về Đơn XIn Việc Của Bạn";
            // 
            // fpnHT
            // 
            fpnHT.Location = new Point(0, 90);
            fpnHT.Name = "fpnHT";
            fpnHT.Size = new Size(1039, 357);
            fpnHT.TabIndex = 1;
            // 
            // FThongBao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 450);
            Controls.Add(fpnHT);
            Controls.Add(panel1);
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