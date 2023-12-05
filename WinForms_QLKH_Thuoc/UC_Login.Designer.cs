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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            txtLogin_Password = new TextBox();
            label3 = new Label();
            txtLogin_UserName = new TextBox();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.2809F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.7191F));
            tableLayoutPanel1.Size = new Size(864, 897);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bgThuoc1;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 220);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 59);
            label1.Name = "label1";
            label1.Size = new Size(290, 106);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(txtLogin_Password);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtLogin_UserName);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(858, 665);
            panel2.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(568, 425);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(206, 113);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.bgThuoc2;
            pictureBox1.Location = new Point(-3, 282);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(646, 386);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(64, 171);
            label3.Name = "label3";
            label3.Size = new Size(153, 45);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtLogin_UserName
            // 
            txtLogin_UserName.Location = new Point(324, 63);
            txtLogin_UserName.Multiline = true;
            txtLogin_UserName.Name = "txtLogin_UserName";
            txtLogin_UserName.Size = new Size(423, 54);
            txtLogin_UserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(64, 60);
            label2.Name = "label2";
            label2.Size = new Size(169, 45);
            label2.TabIndex = 0;
            label2.Text = "UserName";
            // 
            // UC_Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Login";
            Size = new Size(864, 897);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox txtLogin_Password;
        private Label label3;
        private TextBox txtLogin_UserName;
        private Label label2;
        private Button btnLogin;
    }
}
