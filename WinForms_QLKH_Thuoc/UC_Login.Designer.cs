namespace FormQLKH
{
    partial class UC_Login
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
            tlpLogin = new TableLayoutPanel();
            pnLogin = new Panel();
            lbLogin = new Label();
            pnLoginText = new Panel();
            btnLogin = new Button();
            picLogin = new PictureBox();
            txtLogin_Password = new TextBox();
            lbLogin_Password = new Label();
            txtLogin_UserName = new TextBox();
            lbLogin_UserName = new Label();
            tlpLogin.SuspendLayout();
            pnLogin.SuspendLayout();
            pnLoginText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogin).BeginInit();
            SuspendLayout();
            // 
            // tlpLogin
            // 
            tlpLogin.ColumnCount = 1;
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLogin.Controls.Add(pnLogin, 0, 0);
            tlpLogin.Controls.Add(pnLoginText, 0, 1);
            tlpLogin.Dock = DockStyle.Fill;
            tlpLogin.Location = new Point(0, 0);
            tlpLogin.Name = "tlpLogin";
            tlpLogin.RowCount = 2;
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 25.2809F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 74.7191F));
            tlpLogin.Size = new Size(864, 897);
            tlpLogin.TabIndex = 0;
            // 
            // pnLogin
            // 
            pnLogin.BackgroundImage = Properties.Resources.bgThuoc1;
            pnLogin.Controls.Add(lbLogin);
            pnLogin.Dock = DockStyle.Fill;
            pnLogin.Location = new Point(3, 3);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(858, 220);
            pnLogin.TabIndex = 0;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.BackColor = Color.Transparent;
            lbLogin.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lbLogin.Location = new Point(64, 59);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(290, 106);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "LOGIN";
            // 
            // pnLoginText
            // 
            pnLoginText.BackColor = SystemColors.Control;
            pnLoginText.Controls.Add(btnLogin);
            pnLoginText.Controls.Add(picLogin);
            pnLoginText.Controls.Add(txtLogin_Password);
            pnLoginText.Controls.Add(lbLogin_Password);
            pnLoginText.Controls.Add(txtLogin_UserName);
            pnLoginText.Controls.Add(lbLogin_UserName);
            pnLoginText.Dock = DockStyle.Fill;
            pnLoginText.Location = new Point(3, 229);
            pnLoginText.Name = "pnLoginText";
            pnLoginText.Size = new Size(858, 665);
            pnLoginText.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(568, 425);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(206, 113);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // picLogin
            // 
            picLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picLogin.Image = Properties.Resources.bgThuoc2;
            picLogin.Location = new Point(-3, 282);
            picLogin.Name = "picLogin";
            picLogin.Size = new Size(646, 386);
            picLogin.SizeMode = PictureBoxSizeMode.AutoSize;
            picLogin.TabIndex = 4;
            picLogin.TabStop = false;
            // 
            // txtLogin_Password
            // 
            txtLogin_Password.Location = new Point(324, 171);
            txtLogin_Password.Multiline = true;
            txtLogin_Password.Name = "txtLogin_Password";
            txtLogin_Password.PasswordChar = '*';
            txtLogin_Password.Size = new Size(423, 54);
            txtLogin_Password.TabIndex = 3;
            // 
            // lbLogin_Password
            // 
            lbLogin_Password.AutoSize = true;
            lbLogin_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLogin_Password.Location = new Point(64, 171);
            lbLogin_Password.Name = "lbLogin_Password";
            lbLogin_Password.Size = new Size(153, 45);
            lbLogin_Password.TabIndex = 2;
            lbLogin_Password.Text = "Password";
            // 
            // txtLogin_UserName
            // 
            txtLogin_UserName.Location = new Point(324, 63);
            txtLogin_UserName.Multiline = true;
            txtLogin_UserName.Name = "txtLogin_UserName";
            txtLogin_UserName.Size = new Size(423, 54);
            txtLogin_UserName.TabIndex = 1;
            // 
            // lbLogin_UserName
            // 
            lbLogin_UserName.AutoSize = true;
            lbLogin_UserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLogin_UserName.Location = new Point(64, 60);
            lbLogin_UserName.Name = "lbLogin_UserName";
            lbLogin_UserName.Size = new Size(169, 45);
            lbLogin_UserName.TabIndex = 0;
            lbLogin_UserName.Text = "UserName";
            // 
            // UC_Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpLogin);
            Name = "UC_Login";
            Size = new Size(864, 897);
            tlpLogin.ResumeLayout(false);
            pnLogin.ResumeLayout(false);
            pnLogin.PerformLayout();
            pnLoginText.ResumeLayout(false);
            pnLoginText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpLogin;
        private Panel pnLogin;
        private Label lbLogin;
        private Panel pnLoginText;
        private PictureBox picLogin;
        private TextBox txtLogin_Password;
        private Label lbLogin_Password;
        private TextBox txtLogin_UserName;
        private Label lbLogin_UserName;
        private Button btnLogin;
    }
}
