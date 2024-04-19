namespace Do_An_Tuyen_Dung
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
            label13 = new Label();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ucYeuThich1 = new ucYeuThich();
            ucYeuThich2 = new ucYeuThich();
            ucYeuThich3 = new ucYeuThich();
            ucYeuThich4 = new ucYeuThich();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AllowDrop = true;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(398, 32);
            label13.Name = "label13";
            label13.Size = new Size(472, 41);
            label13.TabIndex = 0;
            label13.Text = "Các Công Việc Mà Bạn Yêu Thích";
            // 
            // panel3
            // 
            panel3.AllowDrop = true;
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(label13);
            panel3.Location = new Point(1, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1385, 106);
            panel3.TabIndex = 46;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(-1, 97);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1437, 1060);
            flowLayoutPanel1.TabIndex = 47;
            // 
            // ucYeuThich1
            // 
            ucYeuThich1.Location = new Point(150, 251);
            ucYeuThich1.Margin = new Padding(3, 4, 3, 4);
            ucYeuThich1.Name = "ucYeuThich1";
            ucYeuThich1.Size = new Size(299, 541);
            ucYeuThich1.TabIndex = 47;
            // 
            // ucYeuThich2
            // 
            ucYeuThich2.Location = new Point(531, 251);
            ucYeuThich2.Margin = new Padding(3, 4, 3, 4);
            ucYeuThich2.Name = "ucYeuThich2";
            ucYeuThich2.Size = new Size(302, 541);
            ucYeuThich2.TabIndex = 48;
            // 
            // ucYeuThich3
            // 
            ucYeuThich3.Location = new Point(907, 251);
            ucYeuThich3.Margin = new Padding(3, 4, 3, 4);
            ucYeuThich3.Name = "ucYeuThich3";
            ucYeuThich3.Size = new Size(303, 541);
            ucYeuThich3.TabIndex = 49;
            // 
            // ucYeuThich4
            // 
            ucYeuThich4.Location = new Point(146, 867);
            ucYeuThich4.Margin = new Padding(3, 4, 3, 4);
            ucYeuThich4.Name = "ucYeuThich4";
            ucYeuThich4.Size = new Size(303, 533);
            ucYeuThich4.TabIndex = 50;
            // 
            // FYeuThich
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1377, 989);
            Controls.Add(ucYeuThich4);
            Controls.Add(ucYeuThich3);
            Controls.Add(ucYeuThich2);
            Controls.Add(ucYeuThich1);
            Controls.Add(panel3);
            Name = "FYeuThich";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FYeuThich";
            Load += FYeuThich_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label13;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private ucYeuThich ucYeuThich1;
        private ucYeuThich ucYeuThich2;
        private ucYeuThich ucYeuThich3;
        private ucYeuThich ucYeuThich4;
    }
}