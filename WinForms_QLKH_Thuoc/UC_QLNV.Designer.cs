﻿namespace FormQLKH
{
    partial class UC_QLNV
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tlpQLNV = new TableLayoutPanel();
            pnQLNV = new Panel();
            lbQLNV = new Label();
            grbQLNV_HT = new GroupBox();
            dgvNV = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            pnQLNV_TT = new Panel();
            grbQLNV_TT = new GroupBox();
            lbQLNV_GioiTinh = new Label();
            gboxGioiTinh = new GroupBox();
            rdbQLNV_Nam = new RadioButton();
            rdbQLNV_Nu = new RadioButton();
            dtpQLNV_NgaySinh = new DateTimePicker();
            txtQLNV_HoTen = new TextBox();
            txtQLNV_Email = new TextBox();
            txtQLNV_DiaChi = new TextBox();
            txtQLNV_SDT = new TextBox();
            txtQLNV_UserID = new TextBox();
            txtQLNV_MaCN = new TextBox();
            txtQLNV_MaNV = new TextBox();
            lbQLNV_DiaChi = new Label();
            lbQLNV_Email = new Label();
            lbQLNV_SDT = new Label();
            lbQLNV_NgaySinh = new Label();
            lbQLNV_HoTen = new Label();
            lbQLNV_MaCN = new Label();
            lbQLNV_UserID = new Label();
            lbQLNV_MaNV = new Label();
            splQLNV_TK_CN = new SplitContainer();
            grbQLNV_TK = new GroupBox();
            lbQLNV_TK_HoTen = new Label();
            lbQLNV_TK_MaNV = new Label();
            txtQLNV_TK_TenNV = new TextBox();
            txtQLNV_TK_MaNV = new TextBox();
            grbQLNV_CN = new GroupBox();
            btnQLNV_Export = new Button();
            btnQLNV_Them = new Button();
            btnQLNV_Import = new Button();
            btnQLNV_Sua = new Button();
            btnQLNV_Xoa = new Button();
            tlpQLNV.SuspendLayout();
            pnQLNV.SuspendLayout();
            grbQLNV_HT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNV).BeginInit();
            pnQLNV_TT.SuspendLayout();
            grbQLNV_TT.SuspendLayout();
            gboxGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splQLNV_TK_CN).BeginInit();
            splQLNV_TK_CN.Panel1.SuspendLayout();
            splQLNV_TK_CN.Panel2.SuspendLayout();
            splQLNV_TK_CN.SuspendLayout();
            grbQLNV_TK.SuspendLayout();
            grbQLNV_CN.SuspendLayout();
            SuspendLayout();
            // 
            // tlpQLNV
            // 
            tlpQLNV.BackColor = SystemColors.Control;
            tlpQLNV.ColumnCount = 1;
            tlpQLNV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpQLNV.Controls.Add(pnQLNV, 0, 0);
            tlpQLNV.Controls.Add(grbQLNV_HT, 0, 1);
            tlpQLNV.Controls.Add(pnQLNV_TT, 0, 2);
            tlpQLNV.Controls.Add(splQLNV_TK_CN, 0, 3);
            tlpQLNV.Dock = DockStyle.Fill;
            tlpQLNV.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            tlpQLNV.Location = new Point(0, 0);
            tlpQLNV.Name = "tlpQLNV";
            tlpQLNV.RowCount = 4;
            tlpQLNV.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tlpQLNV.RowStyles.Add(new RowStyle(SizeType.Absolute, 378F));
            tlpQLNV.RowStyles.Add(new RowStyle(SizeType.Absolute, 307F));
            tlpQLNV.RowStyles.Add(new RowStyle(SizeType.Absolute, 14F));
            tlpQLNV.Size = new Size(1420, 1000);
            tlpQLNV.TabIndex = 1;
            // 
            // pnQLNV
            // 
            pnQLNV.BackColor = Color.FromArgb(63, 139, 208);
            pnQLNV.Controls.Add(lbQLNV);
            pnQLNV.Dock = DockStyle.Fill;
            pnQLNV.Location = new Point(3, 3);
            pnQLNV.Name = "pnQLNV";
            pnQLNV.Size = new Size(1414, 76);
            pnQLNV.TabIndex = 0;
            // 
            // lbQLNV
            // 
            lbQLNV.AutoSize = true;
            lbQLNV.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLNV.ForeColor = SystemColors.ButtonHighlight;
            lbQLNV.Location = new Point(552, 18);
            lbQLNV.Name = "lbQLNV";
            lbQLNV.Size = new Size(399, 50);
            lbQLNV.TabIndex = 0;
            lbQLNV.Text = "QUẢN LÝ NHÂN VIÊN";
            lbQLNV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grbQLNV_HT
            // 
            grbQLNV_HT.Controls.Add(dgvNV);
            grbQLNV_HT.Dock = DockStyle.Fill;
            grbQLNV_HT.Location = new Point(3, 85);
            grbQLNV_HT.Name = "grbQLNV_HT";
            grbQLNV_HT.Size = new Size(1414, 372);
            grbQLNV_HT.TabIndex = 3;
            grbQLNV_HT.TabStop = false;
            grbQLNV_HT.Text = "Hiển thị";
            // 
            // dgvNV
            // 
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dgvNV.Dock = DockStyle.Fill;
            dgvNV.Location = new Point(3, 39);
            dgvNV.Name = "dgvNV";
            dgvNV.RowHeadersWidth = 82;
            dgvNV.RowTemplate.Height = 41;
            dgvNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNV.Size = new Size(1408, 330);
            dgvNV.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Mã NV";
            dataGridViewTextBoxColumn1.MinimumWidth = 10;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "UserID";
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Mã chi nhánh";
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Họ tên";
            dataGridViewTextBoxColumn4.MinimumWidth = 10;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Ngày sinh";
            dataGridViewTextBoxColumn5.MinimumWidth = 10;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Giới tính";
            dataGridViewTextBoxColumn6.MinimumWidth = 10;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "SĐT";
            dataGridViewTextBoxColumn7.MinimumWidth = 10;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Email";
            dataGridViewTextBoxColumn8.MinimumWidth = 10;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Địa chỉ";
            dataGridViewTextBoxColumn9.MinimumWidth = 10;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // pnQLNV_TT
            // 
            pnQLNV_TT.Controls.Add(grbQLNV_TT);
            pnQLNV_TT.Dock = DockStyle.Fill;
            pnQLNV_TT.Location = new Point(3, 463);
            pnQLNV_TT.Name = "pnQLNV_TT";
            pnQLNV_TT.Size = new Size(1414, 301);
            pnQLNV_TT.TabIndex = 4;
            // 
            // grbQLNV_TT
            // 
            grbQLNV_TT.BackColor = Color.Transparent;
            grbQLNV_TT.BackgroundImage = Properties.Resources.bg1;
            grbQLNV_TT.Controls.Add(lbQLNV_GioiTinh);
            grbQLNV_TT.Controls.Add(gboxGioiTinh);
            grbQLNV_TT.Controls.Add(dtpQLNV_NgaySinh);
            grbQLNV_TT.Controls.Add(txtQLNV_HoTen);
            grbQLNV_TT.Controls.Add(txtQLNV_Email);
            grbQLNV_TT.Controls.Add(txtQLNV_DiaChi);
            grbQLNV_TT.Controls.Add(txtQLNV_SDT);
            grbQLNV_TT.Controls.Add(txtQLNV_UserID);
            grbQLNV_TT.Controls.Add(txtQLNV_MaCN);
            grbQLNV_TT.Controls.Add(txtQLNV_MaNV);
            grbQLNV_TT.Controls.Add(lbQLNV_DiaChi);
            grbQLNV_TT.Controls.Add(lbQLNV_Email);
            grbQLNV_TT.Controls.Add(lbQLNV_SDT);
            grbQLNV_TT.Controls.Add(lbQLNV_NgaySinh);
            grbQLNV_TT.Controls.Add(lbQLNV_HoTen);
            grbQLNV_TT.Controls.Add(lbQLNV_MaCN);
            grbQLNV_TT.Controls.Add(lbQLNV_UserID);
            grbQLNV_TT.Controls.Add(lbQLNV_MaNV);
            grbQLNV_TT.Dock = DockStyle.Fill;
            grbQLNV_TT.Location = new Point(0, 0);
            grbQLNV_TT.Name = "grbQLNV_TT";
            grbQLNV_TT.Size = new Size(1414, 301);
            grbQLNV_TT.TabIndex = 0;
            grbQLNV_TT.TabStop = false;
            grbQLNV_TT.Text = "Thông tin";
            // 
            // lbQLNV_GioiTinh
            // 
            lbQLNV_GioiTinh.AutoSize = true;
            lbQLNV_GioiTinh.BackColor = SystemColors.Control;
            lbQLNV_GioiTinh.BorderStyle = BorderStyle.Fixed3D;
            lbQLNV_GioiTinh.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLNV_GioiTinh.Location = new Point(496, 229);
            lbQLNV_GioiTinh.Name = "lbQLNV_GioiTinh";
            lbQLNV_GioiTinh.Size = new Size(125, 39);
            lbQLNV_GioiTinh.TabIndex = 20;
            lbQLNV_GioiTinh.Text = "Giới tính";
            // 
            // gboxGioiTinh
            // 
            gboxGioiTinh.Controls.Add(rdbQLNV_Nam);
            gboxGioiTinh.Controls.Add(rdbQLNV_Nu);
            gboxGioiTinh.Location = new Point(678, 206);
            gboxGioiTinh.Margin = new Padding(4);
            gboxGioiTinh.Name = "gboxGioiTinh";
            gboxGioiTinh.Padding = new Padding(4);
            gboxGioiTinh.Size = new Size(242, 82);
            gboxGioiTinh.TabIndex = 19;
            gboxGioiTinh.TabStop = false;
            // 
            // rdbQLNV_Nam
            // 
            rdbQLNV_Nam.AutoSize = true;
            rdbQLNV_Nam.Checked = true;
            rdbQLNV_Nam.Location = new Point(21, 31);
            rdbQLNV_Nam.Name = "rdbQLNV_Nam";
            rdbQLNV_Nam.Size = new Size(105, 41);
            rdbQLNV_Nam.TabIndex = 17;
            rdbQLNV_Nam.TabStop = true;
            rdbQLNV_Nam.Text = "Nam";
            rdbQLNV_Nam.UseVisualStyleBackColor = true;
            // 
            // rdbQLNV_Nu
            // 
            rdbQLNV_Nu.AutoSize = true;
            rdbQLNV_Nu.Location = new Point(151, 33);
            rdbQLNV_Nu.Name = "rdbQLNV_Nu";
            rdbQLNV_Nu.Size = new Size(84, 41);
            rdbQLNV_Nu.TabIndex = 18;
            rdbQLNV_Nu.TabStop = true;
            rdbQLNV_Nu.Text = "Nữ";
            rdbQLNV_Nu.UseVisualStyleBackColor = true;
            // 
            // dtpQLNV_NgaySinh
            // 
            dtpQLNV_NgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpQLNV_NgaySinh.Format = DateTimePickerFormat.Custom;
            dtpQLNV_NgaySinh.Location = new Point(678, 133);
            dtpQLNV_NgaySinh.Name = "dtpQLNV_NgaySinh";
            dtpQLNV_NgaySinh.Size = new Size(242, 43);
            dtpQLNV_NgaySinh.TabIndex = 16;
            // 
            // txtQLNV_HoTen
            // 
            txtQLNV_HoTen.Location = new Point(154, 204);
            txtQLNV_HoTen.Multiline = true;
            txtQLNV_HoTen.Name = "txtQLNV_HoTen";
            txtQLNV_HoTen.Size = new Size(284, 82);
            txtQLNV_HoTen.TabIndex = 15;
            // 
            // txtQLNV_Email
            // 
            txtQLNV_Email.Location = new Point(1103, 124);
            txtQLNV_Email.Name = "txtQLNV_Email";
            txtQLNV_Email.Size = new Size(290, 43);
            txtQLNV_Email.TabIndex = 14;
            // 
            // txtQLNV_DiaChi
            // 
            txtQLNV_DiaChi.Location = new Point(1103, 204);
            txtQLNV_DiaChi.Multiline = true;
            txtQLNV_DiaChi.Name = "txtQLNV_DiaChi";
            txtQLNV_DiaChi.Size = new Size(290, 86);
            txtQLNV_DiaChi.TabIndex = 13;
            // 
            // txtQLNV_SDT
            // 
            txtQLNV_SDT.Location = new Point(1103, 49);
            txtQLNV_SDT.Name = "txtQLNV_SDT";
            txtQLNV_SDT.Size = new Size(290, 43);
            txtQLNV_SDT.TabIndex = 12;
            // 
            // txtQLNV_UserID
            // 
            txtQLNV_UserID.Location = new Point(154, 127);
            txtQLNV_UserID.Name = "txtQLNV_UserID";
            txtQLNV_UserID.Size = new Size(284, 43);
            txtQLNV_UserID.TabIndex = 11;
            // 
            // txtQLNV_MaCN
            // 
            txtQLNV_MaCN.Location = new Point(678, 49);
            txtQLNV_MaCN.Name = "txtQLNV_MaCN";
            txtQLNV_MaCN.Size = new Size(242, 43);
            txtQLNV_MaCN.TabIndex = 10;
            // 
            // txtQLNV_MaNV
            // 
            txtQLNV_MaNV.Location = new Point(154, 51);
            txtQLNV_MaNV.Name = "txtQLNV_MaNV";
            txtQLNV_MaNV.Size = new Size(284, 43);
            txtQLNV_MaNV.TabIndex = 9;
            // 
            // lbQLNV_DiaChi
            // 
            lbQLNV_DiaChi.AutoSize = true;
            lbQLNV_DiaChi.BackColor = SystemColors.Control;
            lbQLNV_DiaChi.BorderStyle = BorderStyle.Fixed3D;
            lbQLNV_DiaChi.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLNV_DiaChi.Location = new Point(989, 219);
            lbQLNV_DiaChi.Name = "lbQLNV_DiaChi";
            lbQLNV_DiaChi.Size = new Size(102, 39);
            lbQLNV_DiaChi.TabIndex = 8;
            lbQLNV_DiaChi.Text = "Địa chỉ";
            // 
            // lbQLNV_Email
            // 
            lbQLNV_Email.AutoSize = true;
            lbQLNV_Email.BackColor = SystemColors.Control;
            lbQLNV_Email.BorderStyle = BorderStyle.Fixed3D;
            lbQLNV_Email.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLNV_Email.Location = new Point(989, 133);
            lbQLNV_Email.Name = "lbQLNV_Email";
            lbQLNV_Email.Size = new Size(85, 39);
            lbQLNV_Email.TabIndex = 7;
            lbQLNV_Email.Text = "Email";
            // 
            // lbQLNV_SDT
            // 
            lbQLNV_SDT.AutoSize = true;
            lbQLNV_SDT.BackColor = SystemColors.Control;
            lbQLNV_SDT.BorderStyle = BorderStyle.Fixed3D;
            lbQLNV_SDT.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLNV_SDT.Location = new Point(989, 47);
            lbQLNV_SDT.Name = "lbQLNV_SDT";
            lbQLNV_SDT.Size = new Size(68, 39);
            lbQLNV_SDT.TabIndex = 6;
            lbQLNV_SDT.Text = "SĐT";
            // 
            // lbQLNV_NgaySinh
            // 
            lbQLNV_NgaySinh.AutoSize = true;
            lbQLNV_NgaySinh.BackColor = SystemColors.Control;
            lbQLNV_NgaySinh.BorderStyle = BorderStyle.Fixed3D;
            lbQLNV_NgaySinh.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLNV_NgaySinh.Location = new Point(500, 140);
            lbQLNV_NgaySinh.Name = "lbQLNV_NgaySinh";
            lbQLNV_NgaySinh.Size = new Size(142, 39);
            lbQLNV_NgaySinh.TabIndex = 5;
            lbQLNV_NgaySinh.Text = "Ngày sinh";
            // 
            // lbQLNV_HoTen
            // 
            lbQLNV_HoTen.AutoSize = true;
            lbQLNV_HoTen.BackColor = SystemColors.Control;
            lbQLNV_HoTen.BorderStyle = BorderStyle.Fixed3D;
            lbQLNV_HoTen.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLNV_HoTen.Location = new Point(35, 204);
            lbQLNV_HoTen.Name = "lbQLNV_HoTen";
            lbQLNV_HoTen.Size = new Size(102, 39);
            lbQLNV_HoTen.TabIndex = 3;
            lbQLNV_HoTen.Text = "Họ tên";
            // 
            // lbQLNV_MaCN
            // 
            lbQLNV_MaCN.AutoSize = true;
            lbQLNV_MaCN.BackColor = SystemColors.Control;
            lbQLNV_MaCN.BorderStyle = BorderStyle.Fixed3D;
            lbQLNV_MaCN.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLNV_MaCN.Location = new Point(496, 51);
            lbQLNV_MaCN.Name = "lbQLNV_MaCN";
            lbQLNV_MaCN.Size = new Size(186, 39);
            lbQLNV_MaCN.TabIndex = 2;
            lbQLNV_MaCN.Text = "Mã chi nhánh";
            // 
            // lbQLNV_UserID
            // 
            lbQLNV_UserID.AutoSize = true;
            lbQLNV_UserID.BackColor = SystemColors.Control;
            lbQLNV_UserID.BorderStyle = BorderStyle.Fixed3D;
            lbQLNV_UserID.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLNV_UserID.Location = new Point(32, 125);
            lbQLNV_UserID.Name = "lbQLNV_UserID";
            lbQLNV_UserID.Size = new Size(101, 39);
            lbQLNV_UserID.TabIndex = 1;
            lbQLNV_UserID.Text = "UserID";
            // 
            // lbQLNV_MaNV
            // 
            lbQLNV_MaNV.AutoSize = true;
            lbQLNV_MaNV.BackColor = SystemColors.Control;
            lbQLNV_MaNV.BorderStyle = BorderStyle.Fixed3D;
            lbQLNV_MaNV.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLNV_MaNV.Location = new Point(32, 47);
            lbQLNV_MaNV.Name = "lbQLNV_MaNV";
            lbQLNV_MaNV.Size = new Size(103, 39);
            lbQLNV_MaNV.TabIndex = 0;
            lbQLNV_MaNV.Text = "Mã NV";
            // 
            // splQLNV_TK_CN
            // 
            splQLNV_TK_CN.BackColor = Color.Transparent;
            splQLNV_TK_CN.BackgroundImage = Properties.Resources.bg1;
            splQLNV_TK_CN.Dock = DockStyle.Fill;
            splQLNV_TK_CN.Location = new Point(3, 770);
            splQLNV_TK_CN.Name = "splQLNV_TK_CN";
            // 
            // splQLNV_TK_CN.Panel1
            // 
            splQLNV_TK_CN.Panel1.Controls.Add(grbQLNV_TK);
            // 
            // splQLNV_TK_CN.Panel2
            // 
            splQLNV_TK_CN.Panel2.Controls.Add(grbQLNV_CN);
            splQLNV_TK_CN.Size = new Size(1414, 227);
            splQLNV_TK_CN.SplitterDistance = 577;
            splQLNV_TK_CN.TabIndex = 5;
            // 
            // grbQLNV_TK
            // 
            grbQLNV_TK.Controls.Add(lbQLNV_TK_HoTen);
            grbQLNV_TK.Controls.Add(lbQLNV_TK_MaNV);
            grbQLNV_TK.Controls.Add(txtQLNV_TK_TenNV);
            grbQLNV_TK.Controls.Add(txtQLNV_TK_MaNV);
            grbQLNV_TK.Dock = DockStyle.Fill;
            grbQLNV_TK.Location = new Point(0, 0);
            grbQLNV_TK.Name = "grbQLNV_TK";
            grbQLNV_TK.Size = new Size(577, 227);
            grbQLNV_TK.TabIndex = 0;
            grbQLNV_TK.TabStop = false;
            grbQLNV_TK.Text = "Tìm kiếm";
            // 
            // lbQLNV_TK_HoTen
            // 
            lbQLNV_TK_HoTen.AutoSize = true;
            lbQLNV_TK_HoTen.BackColor = SystemColors.Control;
            lbQLNV_TK_HoTen.BorderStyle = BorderStyle.Fixed3D;
            lbQLNV_TK_HoTen.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLNV_TK_HoTen.Location = new Point(32, 135);
            lbQLNV_TK_HoTen.Name = "lbQLNV_TK_HoTen";
            lbQLNV_TK_HoTen.Size = new Size(102, 39);
            lbQLNV_TK_HoTen.TabIndex = 26;
            lbQLNV_TK_HoTen.Text = "Họ tên";
            // 
            // lbQLNV_TK_MaNV
            // 
            lbQLNV_TK_MaNV.AutoSize = true;
            lbQLNV_TK_MaNV.BackColor = SystemColors.Control;
            lbQLNV_TK_MaNV.BorderStyle = BorderStyle.Fixed3D;
            lbQLNV_TK_MaNV.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLNV_TK_MaNV.Location = new Point(29, 61);
            lbQLNV_TK_MaNV.Name = "lbQLNV_TK_MaNV";
            lbQLNV_TK_MaNV.Size = new Size(103, 39);
            lbQLNV_TK_MaNV.TabIndex = 25;
            lbQLNV_TK_MaNV.Text = "Mã NV";
            // 
            // txtQLNV_TK_TenNV
            // 
            txtQLNV_TK_TenNV.Location = new Point(182, 132);
            txtQLNV_TK_TenNV.Multiline = true;
            txtQLNV_TK_TenNV.Name = "txtQLNV_TK_TenNV";
            txtQLNV_TK_TenNV.Size = new Size(296, 71);
            txtQLNV_TK_TenNV.TabIndex = 24;
            // 
            // txtQLNV_TK_MaNV
            // 
            txtQLNV_TK_MaNV.Location = new Point(182, 62);
            txtQLNV_TK_MaNV.Name = "txtQLNV_TK_MaNV";
            txtQLNV_TK_MaNV.Size = new Size(296, 43);
            txtQLNV_TK_MaNV.TabIndex = 22;
            // 
            // grbQLNV_CN
            // 
            grbQLNV_CN.Controls.Add(btnQLNV_Export);
            grbQLNV_CN.Controls.Add(btnQLNV_Them);
            grbQLNV_CN.Controls.Add(btnQLNV_Import);
            grbQLNV_CN.Controls.Add(btnQLNV_Sua);
            grbQLNV_CN.Controls.Add(btnQLNV_Xoa);
            grbQLNV_CN.Dock = DockStyle.Fill;
            grbQLNV_CN.Location = new Point(0, 0);
            grbQLNV_CN.Name = "grbQLNV_CN";
            grbQLNV_CN.Size = new Size(833, 227);
            grbQLNV_CN.TabIndex = 11;
            grbQLNV_CN.TabStop = false;
            grbQLNV_CN.Text = "Chức năng";
            // 
            // btnQLNV_Export
            // 
            btnQLNV_Export.BackColor = SystemColors.ButtonHighlight;
            btnQLNV_Export.FlatAppearance.BorderColor = Color.Gainsboro;
            btnQLNV_Export.FlatAppearance.BorderSize = 0;
            btnQLNV_Export.FlatStyle = FlatStyle.Flat;
            btnQLNV_Export.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLNV_Export.Image = Properties.Resources.export;
            btnQLNV_Export.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLNV_Export.Location = new Point(467, 145);
            btnQLNV_Export.Name = "btnQLNV_Export";
            btnQLNV_Export.Size = new Size(169, 58);
            btnQLNV_Export.TabIndex = 11;
            btnQLNV_Export.Text = "Export";
            btnQLNV_Export.UseVisualStyleBackColor = false;
            // 
            // btnQLNV_Them
            // 
            btnQLNV_Them.BackColor = SystemColors.ButtonHighlight;
            btnQLNV_Them.FlatAppearance.BorderColor = Color.Gainsboro;
            btnQLNV_Them.FlatAppearance.BorderSize = 0;
            btnQLNV_Them.FlatStyle = FlatStyle.Flat;
            btnQLNV_Them.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLNV_Them.Image = Properties.Resources.New;
            btnQLNV_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLNV_Them.Location = new Point(45, 56);
            btnQLNV_Them.Name = "btnQLNV_Them";
            btnQLNV_Them.Size = new Size(169, 58);
            btnQLNV_Them.TabIndex = 7;
            btnQLNV_Them.Text = " Thêm";
            btnQLNV_Them.UseVisualStyleBackColor = false;
            // 
            // btnQLNV_Import
            // 
            btnQLNV_Import.BackColor = SystemColors.ButtonHighlight;
            btnQLNV_Import.FlatAppearance.BorderColor = Color.Gainsboro;
            btnQLNV_Import.FlatAppearance.BorderSize = 0;
            btnQLNV_Import.FlatStyle = FlatStyle.Flat;
            btnQLNV_Import.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLNV_Import.Image = Properties.Resources.import;
            btnQLNV_Import.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLNV_Import.Location = new Point(184, 145);
            btnQLNV_Import.Name = "btnQLNV_Import";
            btnQLNV_Import.Size = new Size(169, 58);
            btnQLNV_Import.TabIndex = 10;
            btnQLNV_Import.Text = "Import";
            btnQLNV_Import.UseVisualStyleBackColor = false;
            // 
            // btnQLNV_Sua
            // 
            btnQLNV_Sua.BackColor = SystemColors.ButtonHighlight;
            btnQLNV_Sua.FlatAppearance.BorderColor = Color.Gainsboro;
            btnQLNV_Sua.FlatAppearance.BorderSize = 0;
            btnQLNV_Sua.FlatStyle = FlatStyle.Flat;
            btnQLNV_Sua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLNV_Sua.Image = Properties.Resources.Edit;
            btnQLNV_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLNV_Sua.Location = new Point(322, 56);
            btnQLNV_Sua.Name = "btnQLNV_Sua";
            btnQLNV_Sua.Size = new Size(169, 58);
            btnQLNV_Sua.TabIndex = 8;
            btnQLNV_Sua.Text = "Sửa";
            btnQLNV_Sua.UseVisualStyleBackColor = false;
            // 
            // btnQLNV_Xoa
            // 
            btnQLNV_Xoa.BackColor = SystemColors.ButtonHighlight;
            btnQLNV_Xoa.FlatAppearance.BorderColor = Color.Gainsboro;
            btnQLNV_Xoa.FlatAppearance.BorderSize = 0;
            btnQLNV_Xoa.FlatStyle = FlatStyle.Flat;
            btnQLNV_Xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLNV_Xoa.Image = Properties.Resources.Delete;
            btnQLNV_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLNV_Xoa.Location = new Point(599, 56);
            btnQLNV_Xoa.Name = "btnQLNV_Xoa";
            btnQLNV_Xoa.Size = new Size(169, 58);
            btnQLNV_Xoa.TabIndex = 9;
            btnQLNV_Xoa.Text = "Xóa";
            btnQLNV_Xoa.UseVisualStyleBackColor = false;
            // 
            // UC_QLNV
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpQLNV);
            Name = "UC_QLNV";
            Size = new Size(1420, 1000);
            tlpQLNV.ResumeLayout(false);
            pnQLNV.ResumeLayout(false);
            pnQLNV.PerformLayout();
            grbQLNV_HT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNV).EndInit();
            pnQLNV_TT.ResumeLayout(false);
            grbQLNV_TT.ResumeLayout(false);
            grbQLNV_TT.PerformLayout();
            gboxGioiTinh.ResumeLayout(false);
            gboxGioiTinh.PerformLayout();
            splQLNV_TK_CN.Panel1.ResumeLayout(false);
            splQLNV_TK_CN.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLNV_TK_CN).EndInit();
            splQLNV_TK_CN.ResumeLayout(false);
            grbQLNV_TK.ResumeLayout(false);
            grbQLNV_TK.PerformLayout();
            grbQLNV_CN.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpQLNV;
        private Panel pnQLNV;
        private Label lbQLNV;
        private GroupBox grbQLNV_HT;
        private DataGridView dgvNV;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private Panel pnQLNV_TT;
        private GroupBox grbQLNV_TT;
        private Label lbQLNV_GioiTinh;
        private GroupBox gboxGioiTinh;
        private RadioButton rdbQLNV_Nam;
        private RadioButton rdbQLNV_Nu;
        private DateTimePicker dtpQLNV_NgaySinh;
        private TextBox txtQLNV_HoTen;
        private TextBox txtQLNV_Email;
        private TextBox txtQLNV_DiaChi;
        private TextBox txtQLNV_SDT;
        private TextBox txtQLNV_UserID;
        private TextBox txtQLNV_MaCN;
        private TextBox txtQLNV_MaNV;
        private Label lbQLNV_DiaChi;
        private Label lbQLNV_Email;
        private Label lbQLNV_SDT;
        private Label lbQLNV_NgaySinh;
        private Label lbQLNV_HoTen;
        private Label lbQLNV_MaCN;
        private Label lbQLNV_UserID;
        private Label lbQLNV_MaNV;
        private SplitContainer splQLNV_TK_CN;
        private GroupBox grbQLNV_TK;
        private TextBox txtQLNV_TK_TenNV;
        private TextBox txtQLNV_TK_MaNV;
        private GroupBox grbQLNV_CN;
        private Button btnQLNV_Export;
        private Button btnQLNV_Them;
        private Button btnQLNV_Import;
        private Button btnQLNV_Sua;
        private Button btnQLNV_Xoa;
        private Label lbQLNV_TK_HoTen;
        private Label lbQLNV_TK_MaNV;
    }
}
