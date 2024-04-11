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
            label13.Location = new Point(83, 17);
            label13.Name = "label13";
            label13.Size = new Size(385, 32);
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
            panel3.Location = new Point(1, 2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1212, 80);
            panel3.TabIndex = 46;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(-1, 73);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1257, 795);
            flowLayoutPanel1.TabIndex = 47;
            // 
            // ucYeuThich1
            // 
            ucYeuThich1.Location = new Point(131, 188);
            ucYeuThich1.Name = "ucYeuThich1";
            ucYeuThich1.Size = new Size(262, 406);
            ucYeuThich1.TabIndex = 47;
            // 
            // ucYeuThich2
            // 
            ucYeuThich2.Location = new Point(465, 188);
            ucYeuThich2.Name = "ucYeuThich2";
            ucYeuThich2.Size = new Size(264, 406);
            ucYeuThich2.TabIndex = 48;
            // 
            // ucYeuThich3
            // 
            ucYeuThich3.Location = new Point(794, 188);
            ucYeuThich3.Name = "ucYeuThich3";
            ucYeuThich3.Size = new Size(265, 406);
            ucYeuThich3.TabIndex = 49;
            // 
            // ucYeuThich4
            // 
            ucYeuThich4.Location = new Point(128, 650);
            ucYeuThich4.Name = "ucYeuThich4";
            ucYeuThich4.Size = new Size(265, 400);
            ucYeuThich4.TabIndex = 50;
            // 
            // FYeuThich
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1205, 742);
            Controls.Add(ucYeuThich4);
            Controls.Add(ucYeuThich3);
            Controls.Add(ucYeuThich2);
            Controls.Add(ucYeuThich1);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
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