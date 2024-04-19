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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 40);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 0;
            label1.Text = "Xin chào Anh/Chị";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(205, 40);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 1;
            label2.Text = "[Tên ứng viên],";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(59, 139);
            label3.Name = "label3";
            label3.Size = new Size(545, 25);
            label3.TabIndex = 2;
            label3.Text = "Chúc mừng Anh/Chị đã vượt qua vòng xét tuyển hồ sơ của công ty";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(600, 139);
            label4.Name = "label4";
            label4.Size = new Size(352, 25);
            label4.TabIndex = 3;
            label4.Text = "[Tên công ty] cho vị trí [Tên vị trí ứng tuyển]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(59, 194);
            label5.Name = "label5";
            label5.Size = new Size(915, 50);
            label5.TabIndex = 4;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(79, 293);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 5;
            label6.Text = "Thời Gian : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(79, 353);
            label7.Name = "label7";
            label7.Size = new Size(94, 25);
            label7.TabIndex = 6;
            label7.Text = "Địa Điểm :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F);
            textBox1.Location = new Point(188, 350);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(408, 31);
            textBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10.8F);
            dateTimePicker1.Location = new Point(188, 288);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 31);
            dateTimePicker1.TabIndex = 8;
            // 
            // FLichHen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1061, 459);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FLichHen";
            Text = "FLichHen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
    }
}