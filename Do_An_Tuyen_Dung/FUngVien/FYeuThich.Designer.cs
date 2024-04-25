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
            label1 = new Label();
            fpnHT = new FlowLayoutPanel();
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
            fpnHT.Location = new Point(1, 90);
            fpnHT.Name = "fpnHT";
            fpnHT.Size = new Size(963, 463);
            fpnHT.TabIndex = 2;
            // 
            // FYeuThich
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 565);
            Controls.Add(fpnHT);
            Controls.Add(label1);
            Name = "FYeuThich";
            Text = "FYeuThich";
            Load += FYeuThich_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel fpnHT;
    }
}