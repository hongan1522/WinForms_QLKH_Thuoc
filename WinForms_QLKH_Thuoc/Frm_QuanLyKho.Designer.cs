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
            uC_QuanLyKho1 = new GUI.UC_QuanLyKho();
            SuspendLayout();
            // 
            // uC_QuanLyKho1
            // 
            uC_QuanLyKho1.Dock = DockStyle.Fill;
            uC_QuanLyKho1.Location = new Point(0, 0);
            uC_QuanLyKho1.Name = "uC_QuanLyKho1";
            uC_QuanLyKho1.Size = new Size(1326, 682);
            uC_QuanLyKho1.TabIndex = 0;
            // 
            // Frm_QuanLyKho
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 682);
            Controls.Add(uC_QuanLyKho1);
            Name = "Frm_QuanLyKho";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private GUI.UC_QuanLyKho uC_QuanLyKho1;
    }
}