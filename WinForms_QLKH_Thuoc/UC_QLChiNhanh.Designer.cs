﻿namespace FormQLKH
{
    partial class UC_QLChiNhanh
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_QLChiNhanh));
            tlpQLCN = new TableLayoutPanel();
            pnQLCN = new Panel();
            lbQLCN = new Label();
            splQLCN_HT_CN = new SplitContainer();
            grbQLCN_HT = new GroupBox();
            dgvQLCN = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            grbQLCN_CN = new GroupBox();
            splQLCN_TK_TT = new SplitContainer();
            grbQLCN_TK = new GroupBox();
            btnQLCN_Tim = new Button();
            txtQLCN_TK_MaNV = new TextBox();
            txtQLCN_TK_MaCN = new TextBox();
            rdbQLCN_MaNV = new RadioButton();
            rdbQLCN_MaCN = new RadioButton();
            grbQLCN_TT = new GroupBox();
            txtQLCN_MaNV = new TextBox();
            txtQLCN_TenCN = new TextBox();
            txtQLCN_DiaChi = new TextBox();
            txtQLCN_MaCN = new TextBox();
            lbQLCN_DiaChi = new Label();
            lbQLCN_TenCN = new Label();
            lbQLCN_MaNV = new Label();
            lbQLCN_MaCN = new Label();
            btnQLCN_Thoat = new Button();
            btnQLCN_Export = new Button();
            btnQLCN_Import = new Button();
            btnQLCN_Xoa = new Button();
            btnQLCN_Sua = new Button();
            btnQLCN_Them = new Button();
            tlpQLCN.SuspendLayout();
            pnQLCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splQLCN_HT_CN).BeginInit();
            splQLCN_HT_CN.Panel1.SuspendLayout();
            splQLCN_HT_CN.Panel2.SuspendLayout();
            splQLCN_HT_CN.SuspendLayout();
            grbQLCN_HT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLCN).BeginInit();
            grbQLCN_CN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splQLCN_TK_TT).BeginInit();
            splQLCN_TK_TT.Panel1.SuspendLayout();
            splQLCN_TK_TT.Panel2.SuspendLayout();
            splQLCN_TK_TT.SuspendLayout();
            grbQLCN_TK.SuspendLayout();
            grbQLCN_TT.SuspendLayout();
            SuspendLayout();
            // 
            // tlpQLCN
            // 
            tlpQLCN.BackColor = SystemColors.Control;
            tlpQLCN.ColumnCount = 1;
            tlpQLCN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpQLCN.Controls.Add(pnQLCN, 0, 0);
            tlpQLCN.Controls.Add(splQLCN_HT_CN, 0, 1);
            tlpQLCN.Controls.Add(splQLCN_TK_TT, 0, 2);
            tlpQLCN.Dock = DockStyle.Fill;
            tlpQLCN.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            tlpQLCN.Location = new Point(0, 0);
            tlpQLCN.Margin = new Padding(2, 2, 2, 2);
            tlpQLCN.Name = "tlpQLCN";
            tlpQLCN.RowCount = 3;
            tlpQLCN.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tlpQLCN.RowStyles.Add(new RowStyle(SizeType.Absolute, 534F));
            tlpQLCN.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tlpQLCN.Size = new Size(1092, 781);
            tlpQLCN.TabIndex = 1;
            // 
            // pnQLCN
            // 
            pnQLCN.BackColor = Color.FromArgb(63, 139, 208);
            pnQLCN.Controls.Add(lbQLCN);
            pnQLCN.Dock = DockStyle.Fill;
            pnQLCN.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            pnQLCN.Location = new Point(2, 2);
            pnQLCN.Margin = new Padding(2, 2, 2, 2);
            pnQLCN.Name = "pnQLCN";
            pnQLCN.Size = new Size(1088, 62);
            pnQLCN.TabIndex = 0;
            // 
            // lbQLCN
            // 
            lbQLCN.AutoSize = true;
            lbQLCN.ForeColor = SystemColors.ButtonHighlight;
            lbQLCN.Location = new Point(425, 14);
            lbQLCN.Margin = new Padding(2, 0, 2, 0);
            lbQLCN.Name = "lbQLCN";
            lbQLCN.Size = new Size(307, 38);
            lbQLCN.TabIndex = 0;
            lbQLCN.Text = "QUẢN LÝ CHI NHÁNH";
            // 
            // splQLCN_HT_CN
            // 
            splQLCN_HT_CN.Dock = DockStyle.Fill;
            splQLCN_HT_CN.Location = new Point(2, 68);
            splQLCN_HT_CN.Margin = new Padding(2, 2, 2, 2);
            splQLCN_HT_CN.Name = "splQLCN_HT_CN";
            // 
            // splQLCN_HT_CN.Panel1
            // 
            splQLCN_HT_CN.Panel1.Controls.Add(grbQLCN_HT);
            // 
            // splQLCN_HT_CN.Panel2
            // 
            splQLCN_HT_CN.Panel2.Controls.Add(grbQLCN_CN);
            splQLCN_HT_CN.Size = new Size(1088, 530);
            splQLCN_HT_CN.SplitterDistance = 894;
            splQLCN_HT_CN.SplitterWidth = 3;
            splQLCN_HT_CN.TabIndex = 1;
            // 
            // grbQLCN_HT
            // 
            grbQLCN_HT.Controls.Add(dgvQLCN);
            grbQLCN_HT.Dock = DockStyle.Fill;
            grbQLCN_HT.Location = new Point(0, 0);
            grbQLCN_HT.Margin = new Padding(2, 2, 2, 2);
            grbQLCN_HT.Name = "grbQLCN_HT";
            grbQLCN_HT.Padding = new Padding(2, 2, 2, 2);
            grbQLCN_HT.Size = new Size(894, 530);
            grbQLCN_HT.TabIndex = 0;
            grbQLCN_HT.TabStop = false;
            grbQLCN_HT.Text = "Hiển thị";
            // 
            // dgvQLCN
            // 
            dgvQLCN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLCN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvQLCN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLCN.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvQLCN.DefaultCellStyle = dataGridViewCellStyle2;
            dgvQLCN.Dock = DockStyle.Fill;
            dgvQLCN.Location = new Point(2, 29);
            dgvQLCN.Margin = new Padding(2, 2, 2, 2);
            dgvQLCN.Name = "dgvQLCN";
            dgvQLCN.RowHeadersWidth = 82;
            dgvQLCN.RowTemplate.Height = 41;
            dgvQLCN.Size = new Size(890, 499);
            dgvQLCN.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã CN";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã NV";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Tên CN";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Địa chỉ";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            // 
            // grbQLCN_CN
            // 
            grbQLCN_CN.Controls.Add(btnQLCN_Thoat);
            grbQLCN_CN.Controls.Add(btnQLCN_Them);
            grbQLCN_CN.Controls.Add(btnQLCN_Export);
            grbQLCN_CN.Controls.Add(btnQLCN_Sua);
            grbQLCN_CN.Controls.Add(btnQLCN_Import);
            grbQLCN_CN.Controls.Add(btnQLCN_Xoa);
            grbQLCN_CN.Dock = DockStyle.Fill;
            grbQLCN_CN.Location = new Point(0, 0);
            grbQLCN_CN.Margin = new Padding(2, 2, 2, 2);
            grbQLCN_CN.Name = "grbQLCN_CN";
            grbQLCN_CN.Padding = new Padding(2, 2, 2, 2);
            grbQLCN_CN.Size = new Size(191, 530);
            grbQLCN_CN.TabIndex = 0;
            grbQLCN_CN.TabStop = false;
            grbQLCN_CN.Text = "Chức năng";
            // 
            // splQLCN_TK_TT
            // 
            splQLCN_TK_TT.Dock = DockStyle.Fill;
            splQLCN_TK_TT.Location = new Point(2, 602);
            splQLCN_TK_TT.Margin = new Padding(2, 2, 2, 2);
            splQLCN_TK_TT.Name = "splQLCN_TK_TT";
            // 
            // splQLCN_TK_TT.Panel1
            // 
            splQLCN_TK_TT.Panel1.Controls.Add(grbQLCN_TK);
            // 
            // splQLCN_TK_TT.Panel2
            // 
            splQLCN_TK_TT.Panel2.Controls.Add(grbQLCN_TT);
            splQLCN_TK_TT.Size = new Size(1088, 177);
            splQLCN_TK_TT.SplitterDistance = 430;
            splQLCN_TK_TT.SplitterWidth = 3;
            splQLCN_TK_TT.TabIndex = 2;
            // 
            // grbQLCN_TK
            // 
            grbQLCN_TK.Controls.Add(btnQLCN_Tim);
            grbQLCN_TK.Controls.Add(txtQLCN_TK_MaNV);
            grbQLCN_TK.Controls.Add(txtQLCN_TK_MaCN);
            grbQLCN_TK.Controls.Add(rdbQLCN_MaNV);
            grbQLCN_TK.Controls.Add(rdbQLCN_MaCN);
            grbQLCN_TK.Dock = DockStyle.Fill;
            grbQLCN_TK.Location = new Point(0, 0);
            grbQLCN_TK.Margin = new Padding(2, 2, 2, 2);
            grbQLCN_TK.Name = "grbQLCN_TK";
            grbQLCN_TK.Padding = new Padding(2, 2, 2, 2);
            grbQLCN_TK.Size = new Size(430, 177);
            grbQLCN_TK.TabIndex = 0;
            grbQLCN_TK.TabStop = false;
            grbQLCN_TK.Text = "Tìm kiếm";
            // 
            // btnQLCN_Tim
            // 
            btnQLCN_Tim.BackColor = SystemColors.ButtonHighlight;
            btnQLCN_Tim.FlatAppearance.BorderSize = 0;
            btnQLCN_Tim.FlatStyle = FlatStyle.Flat;
            btnQLCN_Tim.Image = Properties.Resources.glass;
            btnQLCN_Tim.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLCN_Tim.Location = new Point(321, 76);
            btnQLCN_Tim.Margin = new Padding(2, 2, 2, 2);
            btnQLCN_Tim.Name = "btnQLCN_Tim";
            btnQLCN_Tim.Size = new Size(90, 40);
            btnQLCN_Tim.TabIndex = 4;
            btnQLCN_Tim.Text = "Tìm";
            btnQLCN_Tim.TextAlign = ContentAlignment.MiddleRight;
            btnQLCN_Tim.UseVisualStyleBackColor = false;
            // 
            // txtQLCN_TK_MaNV
            // 
            txtQLCN_TK_MaNV.Location = new Point(147, 108);
            txtQLCN_TK_MaNV.Margin = new Padding(2, 2, 2, 2);
            txtQLCN_TK_MaNV.Name = "txtQLCN_TK_MaNV";
            txtQLCN_TK_MaNV.Size = new Size(155, 34);
            txtQLCN_TK_MaNV.TabIndex = 3;
            // 
            // txtQLCN_TK_MaCN
            // 
            txtQLCN_TK_MaCN.Location = new Point(147, 53);
            txtQLCN_TK_MaCN.Margin = new Padding(2, 2, 2, 2);
            txtQLCN_TK_MaCN.Name = "txtQLCN_TK_MaCN";
            txtQLCN_TK_MaCN.Size = new Size(155, 34);
            txtQLCN_TK_MaCN.TabIndex = 2;
            // 
            // rdbQLCN_MaNV
            // 
            rdbQLCN_MaNV.AutoSize = true;
            rdbQLCN_MaNV.Location = new Point(36, 109);
            rdbQLCN_MaNV.Margin = new Padding(2, 2, 2, 2);
            rdbQLCN_MaNV.Name = "rdbQLCN_MaNV";
            rdbQLCN_MaNV.Size = new Size(103, 34);
            rdbQLCN_MaNV.TabIndex = 1;
            rdbQLCN_MaNV.TabStop = true;
            rdbQLCN_MaNV.Text = "Mã NV";
            rdbQLCN_MaNV.UseVisualStyleBackColor = true;
            // 
            // rdbQLCN_MaCN
            // 
            rdbQLCN_MaCN.AutoSize = true;
            rdbQLCN_MaCN.Location = new Point(36, 53);
            rdbQLCN_MaCN.Margin = new Padding(2, 2, 2, 2);
            rdbQLCN_MaCN.Name = "rdbQLCN_MaCN";
            rdbQLCN_MaCN.Size = new Size(103, 34);
            rdbQLCN_MaCN.TabIndex = 0;
            rdbQLCN_MaCN.TabStop = true;
            rdbQLCN_MaCN.Text = "Mã CN";
            rdbQLCN_MaCN.UseVisualStyleBackColor = true;
            // 
            // grbQLCN_TT
            // 
            grbQLCN_TT.Controls.Add(txtQLCN_MaNV);
            grbQLCN_TT.Controls.Add(txtQLCN_TenCN);
            grbQLCN_TT.Controls.Add(txtQLCN_DiaChi);
            grbQLCN_TT.Controls.Add(txtQLCN_MaCN);
            grbQLCN_TT.Controls.Add(lbQLCN_DiaChi);
            grbQLCN_TT.Controls.Add(lbQLCN_TenCN);
            grbQLCN_TT.Controls.Add(lbQLCN_MaNV);
            grbQLCN_TT.Controls.Add(lbQLCN_MaCN);
            grbQLCN_TT.Dock = DockStyle.Fill;
            grbQLCN_TT.Location = new Point(0, 0);
            grbQLCN_TT.Margin = new Padding(2, 2, 2, 2);
            grbQLCN_TT.Name = "grbQLCN_TT";
            grbQLCN_TT.Padding = new Padding(2, 2, 2, 2);
            grbQLCN_TT.Size = new Size(655, 177);
            grbQLCN_TT.TabIndex = 0;
            grbQLCN_TT.TabStop = false;
            grbQLCN_TT.Text = "Thông tin";
            // 
            // txtQLCN_MaNV
            // 
            txtQLCN_MaNV.Location = new Point(107, 109);
            txtQLCN_MaNV.Margin = new Padding(2, 2, 2, 2);
            txtQLCN_MaNV.Name = "txtQLCN_MaNV";
            txtQLCN_MaNV.Size = new Size(155, 34);
            txtQLCN_MaNV.TabIndex = 7;
            // 
            // txtQLCN_TenCN
            // 
            txtQLCN_TenCN.Location = new Point(409, 45);
            txtQLCN_TenCN.Margin = new Padding(2, 2, 2, 2);
            txtQLCN_TenCN.Name = "txtQLCN_TenCN";
            txtQLCN_TenCN.Size = new Size(194, 34);
            txtQLCN_TenCN.TabIndex = 6;
            // 
            // txtQLCN_DiaChi
            // 
            txtQLCN_DiaChi.Location = new Point(409, 107);
            txtQLCN_DiaChi.Margin = new Padding(2, 2, 2, 2);
            txtQLCN_DiaChi.Multiline = true;
            txtQLCN_DiaChi.Name = "txtQLCN_DiaChi";
            txtQLCN_DiaChi.Size = new Size(194, 47);
            txtQLCN_DiaChi.TabIndex = 5;
            // 
            // txtQLCN_MaCN
            // 
            txtQLCN_MaCN.Location = new Point(107, 45);
            txtQLCN_MaCN.Margin = new Padding(2, 2, 2, 2);
            txtQLCN_MaCN.Name = "txtQLCN_MaCN";
            txtQLCN_MaCN.Size = new Size(155, 34);
            txtQLCN_MaCN.TabIndex = 4;
            // 
            // lbQLCN_DiaChi
            // 
            lbQLCN_DiaChi.AutoSize = true;
            lbQLCN_DiaChi.Location = new Point(305, 113);
            lbQLCN_DiaChi.Margin = new Padding(2, 0, 2, 0);
            lbQLCN_DiaChi.Name = "lbQLCN_DiaChi";
            lbQLCN_DiaChi.Size = new Size(77, 30);
            lbQLCN_DiaChi.TabIndex = 3;
            lbQLCN_DiaChi.Text = "Địa chỉ";
            // 
            // lbQLCN_TenCN
            // 
            lbQLCN_TenCN.AutoSize = true;
            lbQLCN_TenCN.Location = new Point(305, 47);
            lbQLCN_TenCN.Margin = new Padding(2, 0, 2, 0);
            lbQLCN_TenCN.Name = "lbQLCN_TenCN";
            lbQLCN_TenCN.Size = new Size(80, 30);
            lbQLCN_TenCN.TabIndex = 2;
            lbQLCN_TenCN.Text = "Tên CN";
            // 
            // lbQLCN_MaNV
            // 
            lbQLCN_MaNV.AutoSize = true;
            lbQLCN_MaNV.Location = new Point(20, 109);
            lbQLCN_MaNV.Margin = new Padding(2, 0, 2, 0);
            lbQLCN_MaNV.Name = "lbQLCN_MaNV";
            lbQLCN_MaNV.Size = new Size(78, 30);
            lbQLCN_MaNV.TabIndex = 1;
            lbQLCN_MaNV.Text = "Mã NV";
            // 
            // lbQLCN_MaCN
            // 
            lbQLCN_MaCN.AutoSize = true;
            lbQLCN_MaCN.Location = new Point(20, 43);
            lbQLCN_MaCN.Margin = new Padding(2, 0, 2, 0);
            lbQLCN_MaCN.Name = "lbQLCN_MaCN";
            lbQLCN_MaCN.Size = new Size(78, 30);
            lbQLCN_MaCN.TabIndex = 0;
            lbQLCN_MaCN.Text = "Mã CN";
            // 
            // btnQLCN_Thoat
            // 
            btnQLCN_Thoat.BackColor = Color.Red;
            btnQLCN_Thoat.FlatAppearance.BorderSize = 0;
            btnQLCN_Thoat.FlatStyle = FlatStyle.Flat;
            btnQLCN_Thoat.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLCN_Thoat.Image = (Image)resources.GetObject("btnQLCN_Thoat.Image");
            btnQLCN_Thoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLCN_Thoat.Location = new Point(25, 413);
            btnQLCN_Thoat.Margin = new Padding(2);
            btnQLCN_Thoat.Name = "btnQLCN_Thoat";
            btnQLCN_Thoat.Size = new Size(140, 45);
            btnQLCN_Thoat.TabIndex = 11;
            btnQLCN_Thoat.Text = "Thoát";
            btnQLCN_Thoat.UseVisualStyleBackColor = false;
            // 
            // btnQLCN_Export
            // 
            btnQLCN_Export.BackColor = SystemColors.ButtonHighlight;
            btnQLCN_Export.FlatAppearance.BorderSize = 0;
            btnQLCN_Export.FlatStyle = FlatStyle.Flat;
            btnQLCN_Export.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLCN_Export.Image = Properties.Resources.export;
            btnQLCN_Export.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLCN_Export.Location = new Point(25, 345);
            btnQLCN_Export.Margin = new Padding(2);
            btnQLCN_Export.Name = "btnQLCN_Export";
            btnQLCN_Export.Size = new Size(140, 45);
            btnQLCN_Export.TabIndex = 10;
            btnQLCN_Export.Text = "Export";
            btnQLCN_Export.UseVisualStyleBackColor = false;
            // 
            // btnQLCN_Import
            // 
            btnQLCN_Import.BackColor = SystemColors.ButtonHighlight;
            btnQLCN_Import.FlatAppearance.BorderSize = 0;
            btnQLCN_Import.FlatStyle = FlatStyle.Flat;
            btnQLCN_Import.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLCN_Import.Image = Properties.Resources.import;
            btnQLCN_Import.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLCN_Import.Location = new Point(25, 277);
            btnQLCN_Import.Margin = new Padding(2);
            btnQLCN_Import.Name = "btnQLCN_Import";
            btnQLCN_Import.Size = new Size(140, 45);
            btnQLCN_Import.TabIndex = 9;
            btnQLCN_Import.Text = "Import";
            btnQLCN_Import.UseVisualStyleBackColor = false;
            // 
            // btnQLCN_Xoa
            // 
            btnQLCN_Xoa.BackColor = SystemColors.ButtonHighlight;
            btnQLCN_Xoa.FlatAppearance.BorderSize = 0;
            btnQLCN_Xoa.FlatStyle = FlatStyle.Flat;
            btnQLCN_Xoa.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLCN_Xoa.Image = Properties.Resources.Delete;
            btnQLCN_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLCN_Xoa.Location = new Point(25, 209);
            btnQLCN_Xoa.Margin = new Padding(2);
            btnQLCN_Xoa.Name = "btnQLCN_Xoa";
            btnQLCN_Xoa.Size = new Size(140, 45);
            btnQLCN_Xoa.TabIndex = 8;
            btnQLCN_Xoa.Text = "Xóa";
            btnQLCN_Xoa.UseVisualStyleBackColor = false;
            // 
            // btnQLCN_Sua
            // 
            btnQLCN_Sua.BackColor = SystemColors.ButtonHighlight;
            btnQLCN_Sua.FlatAppearance.BorderSize = 0;
            btnQLCN_Sua.FlatStyle = FlatStyle.Flat;
            btnQLCN_Sua.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLCN_Sua.Image = Properties.Resources.Edit;
            btnQLCN_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLCN_Sua.Location = new Point(25, 141);
            btnQLCN_Sua.Margin = new Padding(2);
            btnQLCN_Sua.Name = "btnQLCN_Sua";
            btnQLCN_Sua.Size = new Size(140, 45);
            btnQLCN_Sua.TabIndex = 7;
            btnQLCN_Sua.Text = "Sửa";
            btnQLCN_Sua.UseVisualStyleBackColor = false;
            // 
            // btnQLCN_Them
            // 
            btnQLCN_Them.BackColor = SystemColors.ButtonHighlight;
            btnQLCN_Them.FlatAppearance.BorderSize = 0;
            btnQLCN_Them.FlatStyle = FlatStyle.Flat;
            btnQLCN_Them.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLCN_Them.Image = Properties.Resources.New;
            btnQLCN_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLCN_Them.Location = new Point(25, 73);
            btnQLCN_Them.Margin = new Padding(2);
            btnQLCN_Them.Name = "btnQLCN_Them";
            btnQLCN_Them.Size = new Size(140, 45);
            btnQLCN_Them.TabIndex = 6;
            btnQLCN_Them.Text = "Thêm";
            btnQLCN_Them.UseVisualStyleBackColor = false;
            // 
            // UC_QLChiNhanh
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpQLCN);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UC_QLChiNhanh";
            Size = new Size(1092, 781);
            tlpQLCN.ResumeLayout(false);
            pnQLCN.ResumeLayout(false);
            pnQLCN.PerformLayout();
            splQLCN_HT_CN.Panel1.ResumeLayout(false);
            splQLCN_HT_CN.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLCN_HT_CN).EndInit();
            splQLCN_HT_CN.ResumeLayout(false);
            grbQLCN_HT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLCN).EndInit();
            grbQLCN_CN.ResumeLayout(false);
            splQLCN_TK_TT.Panel1.ResumeLayout(false);
            splQLCN_TK_TT.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLCN_TK_TT).EndInit();
            splQLCN_TK_TT.ResumeLayout(false);
            grbQLCN_TK.ResumeLayout(false);
            grbQLCN_TK.PerformLayout();
            grbQLCN_TT.ResumeLayout(false);
            grbQLCN_TT.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpQLCN;
        private Panel pnQLCN;
        private Label lbQLCN;
        private SplitContainer splQLCN_HT_CN;
        private GroupBox grbQLCN_HT;
        private DataGridView dgvQLCN;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private GroupBox grbQLCN_CN;
        private SplitContainer splQLCN_TK_TT;
        private GroupBox grbQLCN_TK;
        private Button btnQLCN_Tim;
        private TextBox txtQLCN_TK_MaNV;
        private TextBox txtQLCN_TK_MaCN;
        private RadioButton rdbQLCN_MaNV;
        private RadioButton rdbQLCN_MaCN;
        private GroupBox grbQLCN_TT;
        private TextBox txtQLCN_MaNV;
        private TextBox txtQLCN_TenCN;
        private TextBox txtQLCN_DiaChi;
        private TextBox txtQLCN_MaCN;
        private Label lbQLCN_DiaChi;
        private Label lbQLCN_TenCN;
        private Label lbQLCN_MaNV;
        private Label lbQLCN_MaCN;
        private Button btnQLCN_Thoat;
        private Button btnQLCN_Them;
        private Button btnQLCN_Export;
        private Button btnQLCN_Sua;
        private Button btnQLCN_Import;
        private Button btnQLCN_Xoa;
    }
}
