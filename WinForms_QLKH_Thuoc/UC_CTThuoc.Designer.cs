namespace FormQLKH
{
    partial class UC_CTThuoc
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
            grbCCT_TT = new GroupBox();
            btnCTT_Sua = new Button();
            numCTT_SoLuong = new NumericUpDown();
            txtCTT_GhiChu = new TextBox();
            txtCTT_MaThuoc = new TextBox();
            txtCTT_MaLo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            grbCCT_TT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCTT_SoLuong).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(grbCCT_TT, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.545454F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.4545441F));
            tableLayoutPanel1.Size = new Size(634, 642);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(628, 119);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(161, 33);
            label1.Name = "label1";
            label1.Size = new Size(309, 50);
            label1.TabIndex = 0;
            label1.Text = "CHI TIẾT THUỐC";
            // 
            // grbCCT_TT
            // 
            grbCCT_TT.BackColor = SystemColors.ControlLightLight;
            grbCCT_TT.Controls.Add(btnCTT_Sua);
            grbCCT_TT.Controls.Add(numCTT_SoLuong);
            grbCCT_TT.Controls.Add(txtCTT_GhiChu);
            grbCCT_TT.Controls.Add(txtCTT_MaThuoc);
            grbCCT_TT.Controls.Add(txtCTT_MaLo);
            grbCCT_TT.Controls.Add(label5);
            grbCCT_TT.Controls.Add(label4);
            grbCCT_TT.Controls.Add(label3);
            grbCCT_TT.Controls.Add(label2);
            grbCCT_TT.Dock = DockStyle.Fill;
            grbCCT_TT.Location = new Point(3, 128);
            grbCCT_TT.Name = "grbCCT_TT";
            grbCCT_TT.Size = new Size(628, 511);
            grbCCT_TT.TabIndex = 1;
            grbCCT_TT.TabStop = false;
            grbCCT_TT.Text = "Thông tin";
            // 
            // btnCTT_Sua
            // 
            btnCTT_Sua.Location = new Point(444, 432);
            btnCTT_Sua.Name = "btnCTT_Sua";
            btnCTT_Sua.Size = new Size(150, 46);
            btnCTT_Sua.TabIndex = 8;
            btnCTT_Sua.Text = "Sửa";
            btnCTT_Sua.UseVisualStyleBackColor = true;
            // 
            // numCTT_SoLuong
            // 
            numCTT_SoLuong.Location = new Point(216, 239);
            numCTT_SoLuong.Name = "numCTT_SoLuong";
            numCTT_SoLuong.Size = new Size(167, 39);
            numCTT_SoLuong.TabIndex = 7;
            // 
            // txtCTT_GhiChu
            // 
            txtCTT_GhiChu.Location = new Point(216, 310);
            txtCTT_GhiChu.Multiline = true;
            txtCTT_GhiChu.Name = "txtCTT_GhiChu";
            txtCTT_GhiChu.Size = new Size(378, 76);
            txtCTT_GhiChu.TabIndex = 6;
            // 
            // txtCTT_MaThuoc
            // 
            txtCTT_MaThuoc.Location = new Point(216, 165);
            txtCTT_MaThuoc.Name = "txtCTT_MaThuoc";
            txtCTT_MaThuoc.Size = new Size(378, 39);
            txtCTT_MaThuoc.TabIndex = 5;
            // 
            // txtCTT_MaLo
            // 
            txtCTT_MaLo.Location = new Point(216, 88);
            txtCTT_MaLo.Name = "txtCTT_MaLo";
            txtCTT_MaLo.Size = new Size(378, 39);
            txtCTT_MaLo.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 326);
            label5.Name = "label5";
            label5.Size = new Size(96, 32);
            label5.TabIndex = 3;
            label5.Text = "Ghi chú";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 168);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 2;
            label4.Text = "Mã thuốc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 246);
            label3.Name = "label3";
            label3.Size = new Size(110, 32);
            label3.TabIndex = 1;
            label3.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 87);
            label2.Name = "label2";
            label2.Size = new Size(75, 32);
            label2.TabIndex = 0;
            label2.Text = "Mã lô";
            // 
            // UC_CTThuoc
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_CTThuoc";
            Size = new Size(634, 646);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbCCT_TT.ResumeLayout(false);
            grbCCT_TT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCTT_SoLuong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private GroupBox grbCCT_TT;
        private Button btnCTT_Sua;
        private NumericUpDown numCTT_SoLuong;
        private TextBox txtCTT_GhiChu;
        private TextBox txtCTT_MaThuoc;
        private TextBox txtCTT_MaLo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
