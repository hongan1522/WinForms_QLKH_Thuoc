namespace WinFormsApp
{
    partial class Frm_QuanLyKho
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uC_qlChiNhanh1 = new FormQLKH.UC_QLChiNhanh();
            SuspendLayout();
            // 
            // uC_qlChiNhanh1
            // 
            uC_qlChiNhanh1.Dock = DockStyle.Fill;
            uC_qlChiNhanh1.Location = new Point(0, 0);
            uC_qlChiNhanh1.Name = "uC_qlChiNhanh1";
            uC_qlChiNhanh1.Size = new Size(1406, 992);
            uC_qlChiNhanh1.TabIndex = 0;
            // 
            // Frm_QuanLyKho
            // 
            ClientSize = new Size(1406, 992);
            Controls.Add(uC_qlChiNhanh1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Frm_QuanLyKho";
            ResumeLayout(false);
        }

        #endregion

        private FormQLKH.UC_QLChiNhanh uC_qlChiNhanh1;
    }
}