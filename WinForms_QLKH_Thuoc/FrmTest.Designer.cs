namespace FormQLKH
{
    partial class FrmTest
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
            uC_Loading1 = new UC_Loading();
            SuspendLayout();
            // 
            // uC_Loading1
            // 
            uC_Loading1.Dock = DockStyle.Fill;
            uC_Loading1.Location = new Point(0, 0);
            uC_Loading1.Name = "uC_Loading1";
            uC_Loading1.Size = new Size(1422, 1109);
            uC_Loading1.TabIndex = 0;
            // 
            // FrmTest
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 1109);
            Controls.Add(uC_Loading1);
            Name = "FrmTest";
            Text = "FrmTest";
            ResumeLayout(false);
        }

        #endregion

        private UC_Loading uC_Loading1;
    }
}