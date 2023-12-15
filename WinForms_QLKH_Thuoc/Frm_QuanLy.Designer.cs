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
            uC_qlKho1 = new UC_QLKho();
            SuspendLayout();
            // 
            // uC_qlKho1
            // 
            uC_qlKho1.Dock = DockStyle.Fill;
            uC_qlKho1.Location = new Point(0, 0);
            uC_qlKho1.Name = "uC_qlKho1";
            uC_qlKho1.Size = new Size(1404, 989);
            uC_qlKho1.TabIndex = 0;
            // 
            // Frm_QuanLy
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 989);
            Controls.Add(uC_qlKho1);
            Name = "Frm_QuanLy";
            Text = "Frm_QuanLy";
            ResumeLayout(false);
        }

        #endregion

        private UC_QLKho uC_qlKho1;
    }
}