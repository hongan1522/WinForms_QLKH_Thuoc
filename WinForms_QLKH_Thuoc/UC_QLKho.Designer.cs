﻿namespace FormQLKH
{
    partial class UC_QLKho
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
            tlpQLK = new TableLayoutPanel();
            pnQLK = new Panel();
            lbQLK = new Label();
            splQLK_HT_CN = new SplitContainer();
            grbQLK_HT = new GroupBox();
            dgvQLK = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            grbQLK_CN = new GroupBox();
            btnQLK_Thoat = new Button();
            btnQLK_Export = new Button();
            btnQLK_Import = new Button();
            btnQLK_Xoa = new Button();
            btnQLK_Sua = new Button();
            btnQLK_Them = new Button();
            splQLK_TK_TT = new SplitContainer();
            grbQLK_TK = new GroupBox();
            btnQLK_Tim = new Button();
            txtQLK_TK_TenKho = new TextBox();
            txtQLK_TK_MaKho = new TextBox();
            rdbQLK_TenKho = new RadioButton();
            rdbQLK_MaKho = new RadioButton();
            grbQLK_TT = new GroupBox();
            txtQLK_MaCN = new TextBox();
            lbQLK_MaCN = new Label();
            txtQLK_DiaChi = new TextBox();
            lbQLK_DiaChi = new Label();
            txtQLK_TenKho = new TextBox();
            lbQLK_TenKho = new Label();
            txtQLK_MaKho = new TextBox();
            lbQLK_MaKho = new Label();
            tlpQLK.SuspendLayout();
            pnQLK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splQLK_HT_CN).BeginInit();
            splQLK_HT_CN.Panel1.SuspendLayout();
            splQLK_HT_CN.Panel2.SuspendLayout();
            splQLK_HT_CN.SuspendLayout();
            grbQLK_HT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLK).BeginInit();
            grbQLK_CN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splQLK_TK_TT).BeginInit();
            splQLK_TK_TT.Panel1.SuspendLayout();
            splQLK_TK_TT.Panel2.SuspendLayout();
            splQLK_TK_TT.SuspendLayout();
            grbQLK_TK.SuspendLayout();
            grbQLK_TT.SuspendLayout();
            SuspendLayout();
            // 
            // tlpQLK
            // 
            tlpQLK.ColumnCount = 1;
            tlpQLK.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpQLK.Controls.Add(pnQLK, 0, 0);
            tlpQLK.Controls.Add(splQLK_HT_CN, 0, 1);
            tlpQLK.Controls.Add(splQLK_TK_TT, 0, 2);
            tlpQLK.Dock = DockStyle.Fill;
            tlpQLK.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            tlpQLK.Location = new Point(0, 0);
            tlpQLK.Name = "tlpQLK";
            tlpQLK.RowCount = 3;
            tlpQLK.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpQLK.RowStyles.Add(new RowStyle(SizeType.Absolute, 622F));
            tlpQLK.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tlpQLK.Size = new Size(1420, 1000);
            tlpQLK.TabIndex = 0;
            // 
            // pnQLK
            // 
            pnQLK.BackColor = Color.FromArgb(63, 139, 208);
            pnQLK.Controls.Add(lbQLK);
            pnQLK.Dock = DockStyle.Fill;
            pnQLK.Location = new Point(3, 3);
            pnQLK.Name = "pnQLK";
            pnQLK.Size = new Size(1414, 74);
            pnQLK.TabIndex = 0;
            // 
            // lbQLK
            // 
            lbQLK.AutoSize = true;
            lbQLK.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLK.ForeColor = SystemColors.ButtonHighlight;
            lbQLK.Location = new Point(582, 13);
            lbQLK.Name = "lbQLK";
            lbQLK.Size = new Size(271, 50);
            lbQLK.TabIndex = 0;
            lbQLK.Text = "QUẢN LÝ KHO";
            // 
            // splQLK_HT_CN
            // 
            splQLK_HT_CN.Dock = DockStyle.Fill;
            splQLK_HT_CN.Location = new Point(3, 83);
            splQLK_HT_CN.Name = "splQLK_HT_CN";
            // 
            // splQLK_HT_CN.Panel1
            // 
            splQLK_HT_CN.Panel1.Controls.Add(grbQLK_HT);
            // 
            // splQLK_HT_CN.Panel2
            // 
            splQLK_HT_CN.Panel2.Controls.Add(grbQLK_CN);
            splQLK_HT_CN.Size = new Size(1414, 616);
            splQLK_HT_CN.SplitterDistance = 1176;
            splQLK_HT_CN.TabIndex = 1;
            // 
            // grbQLK_HT
            // 
            grbQLK_HT.Controls.Add(dgvQLK);
            grbQLK_HT.Dock = DockStyle.Fill;
            grbQLK_HT.Location = new Point(0, 0);
            grbQLK_HT.Name = "grbQLK_HT";
            grbQLK_HT.Size = new Size(1176, 616);
            grbQLK_HT.TabIndex = 0;
            grbQLK_HT.TabStop = false;
            grbQLK_HT.Text = "Hiển thị";
            // 
            // dgvQLK
            // 
            dgvQLK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLK.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvQLK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLK.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column4 });
            dgvQLK.Dock = DockStyle.Fill;
            dgvQLK.Location = new Point(3, 39);
            dgvQLK.Name = "dgvQLK";
            dgvQLK.RowHeadersWidth = 82;
            dgvQLK.RowTemplate.Height = 41;
            dgvQLK.Size = new Size(1170, 574);
            dgvQLK.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã kho";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            // 
            // Column3
            // 
            Column3.HeaderText = "Mã chi nhánh";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên kho";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.HeaderText = "Địa chỉ";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            // 
            // grbQLK_CN
            // 
            grbQLK_CN.Controls.Add(btnQLK_Thoat);
            grbQLK_CN.Controls.Add(btnQLK_Export);
            grbQLK_CN.Controls.Add(btnQLK_Import);
            grbQLK_CN.Controls.Add(btnQLK_Xoa);
            grbQLK_CN.Controls.Add(btnQLK_Sua);
            grbQLK_CN.Controls.Add(btnQLK_Them);
            grbQLK_CN.Dock = DockStyle.Fill;
            grbQLK_CN.Location = new Point(0, 0);
            grbQLK_CN.Name = "grbQLK_CN";
            grbQLK_CN.Size = new Size(234, 616);
            grbQLK_CN.TabIndex = 1;
            grbQLK_CN.TabStop = false;
            grbQLK_CN.Text = "Chức năng";
            // 
            // btnQLK_Thoat
            // 
            btnQLK_Thoat.BackColor = SystemColors.ButtonHighlight;
            btnQLK_Thoat.FlatAppearance.BorderSize = 0;
            btnQLK_Thoat.FlatStyle = FlatStyle.Flat;
            btnQLK_Thoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLK_Thoat.Location = new Point(48, 531);
            btnQLK_Thoat.Name = "btnQLK_Thoat";
            btnQLK_Thoat.Size = new Size(123, 65);
            btnQLK_Thoat.TabIndex = 5;
            btnQLK_Thoat.Text = "Thoát";
            btnQLK_Thoat.UseVisualStyleBackColor = false;
            // 
            // btnQLK_Export
            // 
            btnQLK_Export.BackColor = SystemColors.ButtonHighlight;
            btnQLK_Export.FlatAppearance.BorderSize = 0;
            btnQLK_Export.FlatStyle = FlatStyle.Flat;
            btnQLK_Export.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLK_Export.Location = new Point(48, 435);
            btnQLK_Export.Name = "btnQLK_Export";
            btnQLK_Export.Size = new Size(123, 65);
            btnQLK_Export.TabIndex = 4;
            btnQLK_Export.Text = "Export";
            btnQLK_Export.UseVisualStyleBackColor = false;
            // 
            // btnQLK_Import
            // 
            btnQLK_Import.BackColor = SystemColors.ButtonHighlight;
            btnQLK_Import.FlatAppearance.BorderSize = 0;
            btnQLK_Import.FlatStyle = FlatStyle.Flat;
            btnQLK_Import.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLK_Import.Location = new Point(48, 339);
            btnQLK_Import.Name = "btnQLK_Import";
            btnQLK_Import.Size = new Size(123, 65);
            btnQLK_Import.TabIndex = 3;
            btnQLK_Import.Text = "Import";
            btnQLK_Import.UseVisualStyleBackColor = false;
            // 
            // btnQLK_Xoa
            // 
            btnQLK_Xoa.BackColor = SystemColors.ButtonHighlight;
            btnQLK_Xoa.FlatAppearance.BorderSize = 0;
            btnQLK_Xoa.FlatStyle = FlatStyle.Flat;
            btnQLK_Xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLK_Xoa.Location = new Point(48, 243);
            btnQLK_Xoa.Name = "btnQLK_Xoa";
            btnQLK_Xoa.Size = new Size(123, 65);
            btnQLK_Xoa.TabIndex = 2;
            btnQLK_Xoa.Text = "Xóa";
            btnQLK_Xoa.UseVisualStyleBackColor = false;
            // 
            // btnQLK_Sua
            // 
            btnQLK_Sua.BackColor = SystemColors.ButtonHighlight;
            btnQLK_Sua.FlatAppearance.BorderSize = 0;
            btnQLK_Sua.FlatStyle = FlatStyle.Flat;
            btnQLK_Sua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLK_Sua.Location = new Point(48, 147);
            btnQLK_Sua.Name = "btnQLK_Sua";
            btnQLK_Sua.Size = new Size(123, 65);
            btnQLK_Sua.TabIndex = 1;
            btnQLK_Sua.Text = "Sửa";
            btnQLK_Sua.UseVisualStyleBackColor = false;
            // 
            // btnQLK_Them
            // 
            btnQLK_Them.BackColor = SystemColors.ButtonHighlight;
            btnQLK_Them.FlatAppearance.BorderSize = 0;
            btnQLK_Them.FlatStyle = FlatStyle.Flat;
            btnQLK_Them.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLK_Them.Location = new Point(48, 51);
            btnQLK_Them.Name = "btnQLK_Them";
            btnQLK_Them.Size = new Size(123, 65);
            btnQLK_Them.TabIndex = 0;
            btnQLK_Them.Text = "Thêm";
            btnQLK_Them.UseVisualStyleBackColor = false;
            // 
            // splQLK_TK_TT
            // 
            splQLK_TK_TT.Dock = DockStyle.Fill;
            splQLK_TK_TT.Location = new Point(3, 705);
            splQLK_TK_TT.Name = "splQLK_TK_TT";
            // 
            // splQLK_TK_TT.Panel1
            // 
            splQLK_TK_TT.Panel1.Controls.Add(grbQLK_TK);
            // 
            // splQLK_TK_TT.Panel2
            // 
            splQLK_TK_TT.Panel2.Controls.Add(grbQLK_TT);
            splQLK_TK_TT.Size = new Size(1414, 292);
            splQLK_TK_TT.SplitterDistance = 535;
            splQLK_TK_TT.TabIndex = 2;
            // 
            // grbQLK_TK
            // 
            grbQLK_TK.Controls.Add(btnQLK_Tim);
            grbQLK_TK.Controls.Add(txtQLK_TK_TenKho);
            grbQLK_TK.Controls.Add(txtQLK_TK_MaKho);
            grbQLK_TK.Controls.Add(rdbQLK_TenKho);
            grbQLK_TK.Controls.Add(rdbQLK_MaKho);
            grbQLK_TK.Dock = DockStyle.Fill;
            grbQLK_TK.Location = new Point(0, 0);
            grbQLK_TK.Name = "grbQLK_TK";
            grbQLK_TK.Size = new Size(535, 292);
            grbQLK_TK.TabIndex = 0;
            grbQLK_TK.TabStop = false;
            grbQLK_TK.Text = "Tìm kiếm";
            // 
            // btnQLK_Tim
            // 
            btnQLK_Tim.BackColor = SystemColors.ButtonHighlight;
            btnQLK_Tim.FlatAppearance.BorderSize = 0;
            btnQLK_Tim.FlatStyle = FlatStyle.Flat;
            btnQLK_Tim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLK_Tim.Location = new Point(369, 211);
            btnQLK_Tim.Name = "btnQLK_Tim";
            btnQLK_Tim.Size = new Size(123, 65);
            btnQLK_Tim.TabIndex = 6;
            btnQLK_Tim.Text = "Tìm";
            btnQLK_Tim.UseVisualStyleBackColor = false;
            // 
            // txtQLK_TK_TenKho
            // 
            txtQLK_TK_TenKho.Location = new Point(216, 146);
            txtQLK_TK_TenKho.Name = "txtQLK_TK_TenKho";
            txtQLK_TK_TenKho.Size = new Size(276, 43);
            txtQLK_TK_TenKho.TabIndex = 3;
            // 
            // txtQLK_TK_MaKho
            // 
            txtQLK_TK_MaKho.Location = new Point(216, 75);
            txtQLK_TK_MaKho.Name = "txtQLK_TK_MaKho";
            txtQLK_TK_MaKho.Size = new Size(276, 43);
            txtQLK_TK_MaKho.TabIndex = 2;
            // 
            // rdbQLK_TenKho
            // 
            rdbQLK_TenKho.AutoSize = true;
            rdbQLK_TenKho.Location = new Point(31, 149);
            rdbQLK_TenKho.Name = "rdbQLK_TenKho";
            rdbQLK_TenKho.Size = new Size(139, 41);
            rdbQLK_TenKho.TabIndex = 1;
            rdbQLK_TenKho.TabStop = true;
            rdbQLK_TenKho.Text = "Tên kho";
            rdbQLK_TenKho.UseVisualStyleBackColor = true;
            // 
            // rdbQLK_MaKho
            // 
            rdbQLK_MaKho.AutoSize = true;
            rdbQLK_MaKho.Location = new Point(31, 75);
            rdbQLK_MaKho.Name = "rdbQLK_MaKho";
            rdbQLK_MaKho.Size = new Size(137, 41);
            rdbQLK_MaKho.TabIndex = 0;
            rdbQLK_MaKho.TabStop = true;
            rdbQLK_MaKho.Text = "Mã kho";
            rdbQLK_MaKho.UseVisualStyleBackColor = true;
            // 
            // grbQLK_TT
            // 
            grbQLK_TT.Controls.Add(txtQLK_MaCN);
            grbQLK_TT.Controls.Add(lbQLK_MaCN);
            grbQLK_TT.Controls.Add(txtQLK_DiaChi);
            grbQLK_TT.Controls.Add(lbQLK_DiaChi);
            grbQLK_TT.Controls.Add(txtQLK_TenKho);
            grbQLK_TT.Controls.Add(lbQLK_TenKho);
            grbQLK_TT.Controls.Add(txtQLK_MaKho);
            grbQLK_TT.Controls.Add(lbQLK_MaKho);
            grbQLK_TT.Dock = DockStyle.Fill;
            grbQLK_TT.Location = new Point(0, 0);
            grbQLK_TT.Name = "grbQLK_TT";
            grbQLK_TT.Size = new Size(875, 292);
            grbQLK_TT.TabIndex = 0;
            grbQLK_TT.TabStop = false;
            grbQLK_TT.Text = "Thông tin";
            // 
            // txtQLK_MaCN
            // 
            txtQLK_MaCN.Location = new Point(217, 174);
            txtQLK_MaCN.Name = "txtQLK_MaCN";
            txtQLK_MaCN.Size = new Size(213, 43);
            txtQLK_MaCN.TabIndex = 9;
            // 
            // lbQLK_MaCN
            // 
            lbQLK_MaCN.AutoSize = true;
            lbQLK_MaCN.Location = new Point(18, 180);
            lbQLK_MaCN.Name = "lbQLK_MaCN";
            lbQLK_MaCN.Size = new Size(177, 37);
            lbQLK_MaCN.TabIndex = 8;
            lbQLK_MaCN.Text = "Mã chi nhánh";
            // 
            // txtQLK_DiaChi
            // 
            txtQLK_DiaChi.Location = new Point(578, 174);
            txtQLK_DiaChi.Multiline = true;
            txtQLK_DiaChi.Name = "txtQLK_DiaChi";
            txtQLK_DiaChi.Size = new Size(262, 92);
            txtQLK_DiaChi.TabIndex = 7;
            // 
            // lbQLK_DiaChi
            // 
            lbQLK_DiaChi.AutoSize = true;
            lbQLK_DiaChi.Location = new Point(455, 180);
            lbQLK_DiaChi.Name = "lbQLK_DiaChi";
            lbQLK_DiaChi.Size = new Size(98, 37);
            lbQLK_DiaChi.TabIndex = 6;
            lbQLK_DiaChi.Text = "Địa chỉ";
            // 
            // txtQLK_TenKho
            // 
            txtQLK_TenKho.Location = new Point(578, 75);
            txtQLK_TenKho.Multiline = true;
            txtQLK_TenKho.Name = "txtQLK_TenKho";
            txtQLK_TenKho.Size = new Size(262, 48);
            txtQLK_TenKho.TabIndex = 5;
            // 
            // lbQLK_TenKho
            // 
            lbQLK_TenKho.AutoSize = true;
            lbQLK_TenKho.Location = new Point(455, 80);
            lbQLK_TenKho.Name = "lbQLK_TenKho";
            lbQLK_TenKho.Size = new Size(108, 37);
            lbQLK_TenKho.TabIndex = 4;
            lbQLK_TenKho.Text = "Tên kho";
            // 
            // txtQLK_MaKho
            // 
            txtQLK_MaKho.Location = new Point(217, 74);
            txtQLK_MaKho.Name = "txtQLK_MaKho";
            txtQLK_MaKho.Size = new Size(213, 43);
            txtQLK_MaKho.TabIndex = 3;
            // 
            // lbQLK_MaKho
            // 
            lbQLK_MaKho.AutoSize = true;
            lbQLK_MaKho.Location = new Point(18, 75);
            lbQLK_MaKho.Name = "lbQLK_MaKho";
            lbQLK_MaKho.Size = new Size(106, 37);
            lbQLK_MaKho.TabIndex = 0;
            lbQLK_MaKho.Text = "Mã kho";
            // 
            // UC_QLKho
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpQLK);
            Name = "UC_QLKho";
            Size = new Size(1420, 1000);
            tlpQLK.ResumeLayout(false);
            pnQLK.ResumeLayout(false);
            pnQLK.PerformLayout();
            splQLK_HT_CN.Panel1.ResumeLayout(false);
            splQLK_HT_CN.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLK_HT_CN).EndInit();
            splQLK_HT_CN.ResumeLayout(false);
            grbQLK_HT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLK).EndInit();
            grbQLK_CN.ResumeLayout(false);
            splQLK_TK_TT.Panel1.ResumeLayout(false);
            splQLK_TK_TT.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLK_TK_TT).EndInit();
            splQLK_TK_TT.ResumeLayout(false);
            grbQLK_TK.ResumeLayout(false);
            grbQLK_TK.PerformLayout();
            grbQLK_TT.ResumeLayout(false);
            grbQLK_TT.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpQLK;
        private Panel pnQLK;
        private Label lbQLK;
        private SplitContainer splQLK_HT_CN;
        private GroupBox grbQLK_HT;
        private GroupBox grbQLK_CN;
        private DataGridView dgvQLK;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private Button btnQLK_Thoat;
        private Button btnQLK_Export;
        private Button btnQLK_Import;
        private Button btnQLK_Xoa;
        private Button btnQLK_Sua;
        private Button btnQLK_Them;
        private SplitContainer splQLK_TK_TT;
        private GroupBox grbQLK_TK;
        private GroupBox grbQLK_TT;
        private Button btnQLK_Tim;
        private TextBox txtQLK_TK_TenKho;
        private TextBox txtQLK_TK_MaKho;
        private RadioButton rdbQLK_TenKho;
        private RadioButton rdbQLK_MaKho;
        private TextBox txtQLK_MaCN;
        private Label lbQLK_MaCN;
        private TextBox txtQLK_DiaChi;
        private Label lbQLK_DiaChi;
        private TextBox txtQLK_TenKho;
        private Label lbQLK_TenKho;
        private TextBox txtQLK_MaKho;
        private Label lbQLK_MaKho;
    }
}