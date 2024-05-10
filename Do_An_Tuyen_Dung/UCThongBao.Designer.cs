namespace Do_An_Tuyen_Dung
{
    partial class UCThongBao
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCThongBao));
            btn_TB = new Guna.UI2.WinForms.Guna2Button();
            txtNganh = new Label();
            txtTenCTy = new Label();
            txtTB = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btn_TB
            // 
            btn_TB.BorderColor = Color.Transparent;
            btn_TB.BorderRadius = 10;
            btn_TB.BorderThickness = 2;
            btn_TB.CustomizableEdges = customizableEdges1;
            btn_TB.DisabledState.BorderColor = Color.DarkGray;
            btn_TB.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_TB.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_TB.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_TB.FillColor = Color.FromArgb(42, 54, 78);
            btn_TB.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TB.ForeColor = Color.White;
            btn_TB.Location = new Point(789, 24);
            btn_TB.Name = "btn_TB";
            btn_TB.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_TB.Size = new Size(190, 37);
            btn_TB.TabIndex = 67;
            btn_TB.Text = "Xem Lịch Hẹn";
            btn_TB.Click += btn_TB_Click;
            // 
            // txtNganh
            // 
            txtNganh.AutoSize = true;
            txtNganh.Font = new Font("Segoe UI", 10.2F);
            txtNganh.ForeColor = Color.White;
            txtNganh.Location = new Point(127, 60);
            txtNganh.Name = "txtNganh";
            txtNganh.Size = new Size(179, 23);
            txtNganh.TabIndex = 68;
            txtNganh.Text = "Ngành : Dev FrontEnd";
            // 
            // txtTenCTy
            // 
            txtTenCTy.AutoSize = true;
            txtTenCTy.Font = new Font("Segoe UI", 10.2F);
            txtTenCTy.ForeColor = Color.White;
            txtTenCTy.Location = new Point(127, 15);
            txtTenCTy.Name = "txtTenCTy";
            txtTenCTy.Size = new Size(148, 23);
            txtTenCTy.TabIndex = 69;
            txtTenCTy.Text = "Tên Công Ty : HKT";
            // 
            // txtTB
            // 
            txtTB.AutoSize = true;
            txtTB.Font = new Font("Segoe UI", 10.2F);
            txtTB.ForeColor = Color.White;
            txtTB.Location = new Point(387, 38);
            txtTB.Name = "txtTB";
            txtTB.Size = new Size(337, 23);
            txtTB.TabIndex = 70;
            txtTB.Text = "Đơn Xin Việc Của Bạn Đang Được Xem Xét";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(btn_TB);
            panel2.Controls.Add(txtTB);
            panel2.Controls.Add(txtTenCTy);
            panel2.Controls.Add(txtNganh);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1006, 100);
            panel2.TabIndex = 71;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 68);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 77;
            pictureBox3.TabStop = false;
            // 
            // UCThongBao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "UCThongBao";
            Size = new Size(1006, 100);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_TB;
        private Label txtNganh;
        private Label txtTenCTy;
        private Label txtTB;
        private Panel panel2;
        private PictureBox pictureBox3;
    }
}
