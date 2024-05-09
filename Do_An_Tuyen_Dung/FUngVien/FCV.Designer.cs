namespace Do_An_Tuyen_Dung.FUngVien
{
    partial class FCV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCV));
            axAcropdf1 = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)axAcropdf1).BeginInit();
            SuspendLayout();
            // 
            // axAcropdf1
            // 
            axAcropdf1.Enabled = true;
            axAcropdf1.Location = new Point(231, 42);
            axAcropdf1.Name = "axAcropdf1";
            axAcropdf1.OcxState = (AxHost.State)resources.GetObject("axAcropdf1.OcxState");
            axAcropdf1.Size = new Size(319, 374);
            axAcropdf1.TabIndex = 0;
            // 
            // FCV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(axAcropdf1);
            Name = "FCV";
            Text = "FCV";
            Load += FCV_Load;
            ((System.ComponentModel.ISupportInitialize)axAcropdf1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcropdf1;
    }
}