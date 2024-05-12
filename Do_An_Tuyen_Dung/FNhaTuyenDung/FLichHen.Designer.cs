
namespace Do_An_Tuyen_Dung.FNhaTuyenDung
{
    partial class FLichHen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLichHen));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            txtTenUV = new Label();
            label3 = new Label();
            txtCVvaVItri = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtDiaDiemGap = new TextBox();
            dtpThoiGian = new DateTimePicker();
            btn_Luu = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(52, 30);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Xin chào Anh/Chị";
            // 
            // txtTenUV
            // 
            txtTenUV.AutoSize = true;
            txtTenUV.BackColor = Color.Transparent;
            txtTenUV.Font = new Font("Segoe UI", 10.8F);
            txtTenUV.ForeColor = Color.White;
            txtTenUV.Location = new Point(179, 30);
            txtTenUV.Name = "txtTenUV";
            txtTenUV.Size = new Size(106, 20);
            txtTenUV.TabIndex = 1;
            txtTenUV.Text = "[Tên ứng viên],";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(52, 104);
            label3.Name = "label3";
            label3.Size = new Size(446, 20);
            label3.TabIndex = 2;
            label3.Text = "Chúc mừng Anh/Chị đã vượt qua vòng xét tuyển hồ sơ của công ty";
            // 
            // txtCVvaVItri
            // 
            txtCVvaVItri.AutoSize = true;
            txtCVvaVItri.BackColor = Color.Transparent;
            txtCVvaVItri.Font = new Font("Segoe UI", 10.8F);
            txtCVvaVItri.ForeColor = Color.White;
            txtCVvaVItri.Location = new Point(525, 104);
            txtCVvaVItri.Name = "txtCVvaVItri";
            txtCVvaVItri.Size = new Size(296, 20);
            txtCVvaVItri.TabIndex = 3;
            txtCVvaVItri.Text = "[Tên công ty] cho vị trí [Tên vị trí ứng tuyển]";
            txtCVvaVItri.Click += txtCVvaVItri_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(52, 146);
            label5.Name = "label5";
            label5.Size = new Size(750, 40);
            label5.TabIndex = 4;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(69, 220);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 5;
            label6.Text = "Thời Gian : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(69, 265);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 6;
            label7.Text = "Địa Điểm :";
            // 
            // txtDiaDiemGap
            // 
            txtDiaDiemGap.Font = new Font("Segoe UI", 10.8F);
            txtDiaDiemGap.Location = new Point(164, 262);
            txtDiaDiemGap.Margin = new Padding(3, 2, 3, 2);
            txtDiaDiemGap.Name = "txtDiaDiemGap";
            txtDiaDiemGap.Size = new Size(358, 27);
            txtDiaDiemGap.TabIndex = 7;
            txtDiaDiemGap.TextChanged += txtDiaDiemGap_TextChanged;
            // 
            // dtpThoiGian
            // 
            dtpThoiGian.Font = new Font("Segoe UI", 10.8F);
            dtpThoiGian.Location = new Point(164, 216);
            dtpThoiGian.Margin = new Padding(3, 2, 3, 2);
            dtpThoiGian.Name = "dtpThoiGian";
            dtpThoiGian.Size = new Size(358, 27);
            dtpThoiGian.TabIndex = 8;
            dtpThoiGian.ValueChanged += dtpThoiGian_ValueChanged;
            // 
            // btn_Luu
            // 
            btn_Luu.AllowDrop = true;
            btn_Luu.BackColor = Color.Transparent;
            btn_Luu.BorderColor = Color.Transparent;
            btn_Luu.BorderRadius = 10;
            btn_Luu.BorderThickness = 2;
            btn_Luu.CustomizableEdges = customizableEdges1;
            btn_Luu.DisabledState.BorderColor = Color.DarkGray;
            btn_Luu.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Luu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Luu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Luu.FillColor = Color.FromArgb(42, 54, 78);
            btn_Luu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Luu.ForeColor = Color.White;
            btn_Luu.Location = new Point(458, 312);
            btn_Luu.Margin = new Padding(3, 2, 3, 2);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_Luu.Size = new Size(114, 30);
            btn_Luu.TabIndex = 83;
            btn_Luu.Text = "Lưu";
            btn_Luu.Click += btn_Luu_Click;
            // 
            // FLichHen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(928, 344);
            Controls.Add(btn_Luu);
            Controls.Add(dtpThoiGian);
            Controls.Add(txtDiaDiemGap);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCVvaVItri);
            Controls.Add(label3);
            Controls.Add(txtTenUV);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FLichHen";
            Text = "FLichHen";
            Load += FLichHen_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Label txtTenUV;
        private Label label3;
        private Label txtCVvaVItri;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtDiaDiemGap;
        private DateTimePicker dtpThoiGian;
        private Guna.UI2.WinForms.Guna2Button btn_Luu;
    }
}