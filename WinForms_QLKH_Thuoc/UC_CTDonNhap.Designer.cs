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
            tlpCTDN = new TableLayoutPanel();
            pnCTDN = new Panel();
            lbCTDN = new Label();
            grbCTDN_TT = new GroupBox();
            btnCTDN_Sua = new Button();
            txtCTDN_GhiChu = new TextBox();
            txtCTDN_MaLo = new TextBox();
            txtCTDN_MaDN = new TextBox();
            lbCTDN_GhiChu = new Label();
            lbCTDN_MaLo = new Label();
            lbCTDN_MaDN = new Label();
            tlpCTDN.SuspendLayout();
            pnCTDN.SuspendLayout();
            grbCTDN_TT.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCTDN
            // 
            tlpCTDN.ColumnCount = 1;
            tlpCTDN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCTDN.Controls.Add(pnCTDN, 0, 0);
            tlpCTDN.Controls.Add(grbCTDN_TT, 0, 1);
            tlpCTDN.Dock = DockStyle.Fill;
            tlpCTDN.Location = new Point(0, 0);
            tlpCTDN.Name = "tlpCTDN";
            tlpCTDN.RowCount = 2;
            tlpCTDN.RowStyles.Add(new RowStyle(SizeType.Percent, 17.0520229F));
            tlpCTDN.RowStyles.Add(new RowStyle(SizeType.Percent, 82.9479752F));
            tlpCTDN.Size = new Size(649, 556);
            tlpCTDN.TabIndex = 1;
            // 
            // pnCTDN
            // 
            pnCTDN.BackColor = Color.FromArgb(63, 139, 208);
            pnCTDN.Controls.Add(lbCTDN);
            pnCTDN.Dock = DockStyle.Fill;
            pnCTDN.Location = new Point(3, 3);
            pnCTDN.Name = "pnCTDN";
            pnCTDN.Size = new Size(643, 88);
            pnCTDN.TabIndex = 0;
            // 
            // lbCTDN
            // 
            lbCTDN.AutoSize = true;
            lbCTDN.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbCTDN.ForeColor = SystemColors.ButtonHighlight;
            lbCTDN.Location = new Point(149, 15);
            lbCTDN.Name = "lbCTDN";
            lbCTDN.Size = new Size(382, 50);
            lbCTDN.TabIndex = 0;
            lbCTDN.Text = "CHI TIẾT ĐƠN NHẬP";
            // 
            // grbCTDN_TT
            // 
            grbCTDN_TT.BackColor = SystemColors.Control;
            grbCTDN_TT.Controls.Add(btnCTDN_Sua);
            grbCTDN_TT.Controls.Add(txtCTDN_GhiChu);
            grbCTDN_TT.Controls.Add(txtCTDN_MaLo);
            grbCTDN_TT.Controls.Add(txtCTDN_MaDN);
            grbCTDN_TT.Controls.Add(lbCTDN_GhiChu);
            grbCTDN_TT.Controls.Add(lbCTDN_MaLo);
            grbCTDN_TT.Controls.Add(lbCTDN_MaDN);
            grbCTDN_TT.Dock = DockStyle.Fill;
            grbCTDN_TT.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            grbCTDN_TT.Location = new Point(3, 97);
            grbCTDN_TT.Name = "grbCTDN_TT";
            grbCTDN_TT.Size = new Size(643, 456);
            grbCTDN_TT.TabIndex = 1;
            grbCTDN_TT.TabStop = false;
            grbCTDN_TT.Text = "Thông tin";
            // 
            // btnCTDN_Sua
            // 
            btnCTDN_Sua.BackColor = SystemColors.Highlight;
            btnCTDN_Sua.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnCTDN_Sua.ForeColor = SystemColors.ControlLightLight;
            btnCTDN_Sua.Location = new Point(463, 364);
            btnCTDN_Sua.Name = "btnCTDN_Sua";
            btnCTDN_Sua.Size = new Size(130, 61);
            btnCTDN_Sua.TabIndex = 6;
            btnCTDN_Sua.Text = "Sửa";
            btnCTDN_Sua.UseVisualStyleBackColor = false;
            // 
            // txtCTDN_GhiChu
            // 
            txtCTDN_GhiChu.Location = new Point(247, 236);
            txtCTDN_GhiChu.Multiline = true;
            txtCTDN_GhiChu.Name = "txtCTDN_GhiChu";
            txtCTDN_GhiChu.Size = new Size(333, 99);
            txtCTDN_GhiChu.TabIndex = 5;
            // 
            // txtCTDN_MaLo
            // 
            txtCTDN_MaLo.Location = new Point(247, 151);
            txtCTDN_MaLo.Name = "txtCTDN_MaLo";
            txtCTDN_MaLo.Size = new Size(333, 43);
            txtCTDN_MaLo.TabIndex = 4;
            // 
            // txtCTDN_MaDN
            // 
            txtCTDN_MaDN.Location = new Point(247, 72);
            txtCTDN_MaDN.Name = "txtCTDN_MaDN";
            txtCTDN_MaDN.Size = new Size(333, 43);
            txtCTDN_MaDN.TabIndex = 3;
            // 
            // lbCTDN_GhiChu
            // 
            lbCTDN_GhiChu.AutoSize = true;
            lbCTDN_GhiChu.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            lbCTDN_GhiChu.Location = new Point(41, 236);
            lbCTDN_GhiChu.Name = "lbCTDN_GhiChu";
            lbCTDN_GhiChu.Size = new Size(107, 37);
            lbCTDN_GhiChu.TabIndex = 2;
            lbCTDN_GhiChu.Text = "Ghi chú";
            // 
            // lbCTDN_MaLo
            // 
            lbCTDN_MaLo.AutoSize = true;
            lbCTDN_MaLo.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            lbCTDN_MaLo.Location = new Point(41, 148);
            lbCTDN_MaLo.Name = "lbCTDN_MaLo";
            lbCTDN_MaLo.Size = new Size(85, 37);
            lbCTDN_MaLo.TabIndex = 1;
            lbCTDN_MaLo.Text = "Mã lô";
            // 
            // lbCTDN_MaDN
            // 
            lbCTDN_MaDN.AutoSize = true;
            lbCTDN_MaDN.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            lbCTDN_MaDN.Location = new Point(41, 65);
            lbCTDN_MaDN.Name = "lbCTDN_MaDN";
            lbCTDN_MaDN.Size = new Size(176, 37);
            lbCTDN_MaDN.TabIndex = 0;
            lbCTDN_MaDN.Text = "Mã đơn nhập";
            // 
            // UC_CTDonNhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpCTDN);
            Name = "UC_CTDonNhap";
            Size = new Size(649, 556);
            tlpCTDN.ResumeLayout(false);
            pnCTDN.ResumeLayout(false);
            pnCTDN.PerformLayout();
            grbCTDN_TT.ResumeLayout(false);
            grbCTDN_TT.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCTDN;
        private Panel pnCTDN;
        private Label lbCTDN;
        private GroupBox grbCTDN_TT;
        private Button btnCTDN_Sua;
        private TextBox txtCTDN_GhiChu;
        private TextBox txtCTDN_MaLo;
        private TextBox txtCTDN_MaDN;
        private Label lbCTDN_GhiChu;
        private Label lbCTDN_MaLo;
        private Label lbCTDN_MaDN;
    }
}
