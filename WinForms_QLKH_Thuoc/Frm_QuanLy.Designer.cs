namespace FormQLKH
{
    partial class Frm_QuanLy
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
            uC_qlChiNhanh1 = new UC_QLChiNhanh();
            SuspendLayout();
            // 
            // uC_qlChiNhanh1
            // 
            uC_qlChiNhanh1.Dock = DockStyle.Fill;
            uC_qlChiNhanh1.Location = new Point(0, 0);
            uC_qlChiNhanh1.Name = "uC_qlChiNhanh1";
            uC_qlChiNhanh1.Size = new Size(1411, 1080);
            uC_qlChiNhanh1.TabIndex = 0;
            // 
            // Frm_QuanLy
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1411, 1080);
            Controls.Add(uC_qlChiNhanh1);
            Name = "Frm_QuanLy";
            Text = "Frm_QuanLy";
            FormClosing += FrmQuanLy_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private UC_QLChiNhanh uC_qlChiNhanh1;
    }
}