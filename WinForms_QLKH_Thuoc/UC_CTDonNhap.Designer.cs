namespace FormQLKH
{
    partial class UC_CTDonNhap
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
            grbCTDN_TT = new GroupBox();
            btnCTDN_Sua = new Button();
            txtCTDN_GhiChu = new TextBox();
            txtCTDN_MaLo = new TextBox();
            txtCTDN_MaDN = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            grbCTDN_TT.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(grbCTDN_TT, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.0520229F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.9479752F));
            tableLayoutPanel1.Size = new Size(649, 556);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 128, 160);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 88);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(149, 15);
            label1.Name = "label1";
            label1.Size = new Size(382, 50);
            label1.TabIndex = 0;
            label1.Text = "CHI TIẾT ĐƠN NHẬP";
            // 
            // grbCTDN_TT
            // 
            grbCTDN_TT.BackColor = SystemColors.ControlLight;
            grbCTDN_TT.Controls.Add(btnCTDN_Sua);
            grbCTDN_TT.Controls.Add(txtCTDN_GhiChu);
            grbCTDN_TT.Controls.Add(txtCTDN_MaLo);
            grbCTDN_TT.Controls.Add(txtCTDN_MaDN);
            grbCTDN_TT.Controls.Add(label4);
            grbCTDN_TT.Controls.Add(label3);
            grbCTDN_TT.Controls.Add(label2);
            grbCTDN_TT.Dock = DockStyle.Fill;
            grbCTDN_TT.Location = new Point(3, 97);
            grbCTDN_TT.Name = "grbCTDN_TT";
            grbCTDN_TT.Size = new Size(643, 456);
            grbCTDN_TT.TabIndex = 1;
            grbCTDN_TT.TabStop = false;
            grbCTDN_TT.Text = "Thông tin";
            // 
            // btnCTDN_Sua
            // 
            btnCTDN_Sua.BackColor = SystemColors.ActiveCaption;
            btnCTDN_Sua.Location = new Point(443, 364);
            btnCTDN_Sua.Name = "btnCTDN_Sua";
            btnCTDN_Sua.Size = new Size(150, 46);
            btnCTDN_Sua.TabIndex = 6;
            btnCTDN_Sua.Text = "Sửa";
            btnCTDN_Sua.UseVisualStyleBackColor = false;
            // 
            // txtCTDN_GhiChu
            // 
            txtCTDN_GhiChu.Location = new Point(247, 236);
            txtCTDN_GhiChu.Multiline = true;
            txtCTDN_GhiChu.Name = "txtCTDN_GhiChu";
            txtCTDN_GhiChu.Size = new Size(284, 99);
            txtCTDN_GhiChu.TabIndex = 5;
            // 
            // txtCTDN_MaLo
            // 
            txtCTDN_MaLo.Location = new Point(247, 151);
            txtCTDN_MaLo.Name = "txtCTDN_MaLo";
            txtCTDN_MaLo.Size = new Size(284, 39);
            txtCTDN_MaLo.TabIndex = 4;
            // 
            // txtCTDN_MaDN
            // 
            txtCTDN_MaDN.Location = new Point(247, 72);
            txtCTDN_MaDN.Name = "txtCTDN_MaDN";
            txtCTDN_MaDN.Size = new Size(284, 39);
            txtCTDN_MaDN.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 236);
            label4.Name = "label4";
            label4.Size = new Size(96, 32);
            label4.TabIndex = 2;
            label4.Text = "Ghi chú";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 148);
            label3.Name = "label3";
            label3.Size = new Size(75, 32);
            label3.TabIndex = 1;
            label3.Text = "Mã lô";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 65);
            label2.Name = "label2";
            label2.Size = new Size(158, 32);
            label2.TabIndex = 0;
            label2.Text = "Mã đơn nhập";
            // 
            // UC_CTDonNhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_CTDonNhap";
            Size = new Size(649, 556);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbCTDN_TT.ResumeLayout(false);
            grbCTDN_TT.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private GroupBox grbCTDN_TT;
        private Button btnCTDN_Sua;
        private TextBox txtCTDN_GhiChu;
        private TextBox txtCTDN_MaLo;
        private TextBox txtCTDN_MaDN;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
