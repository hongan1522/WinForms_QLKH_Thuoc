namespace FormQLKH
{
    partial class UC_QLThuoc
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
            tlpQLT = new TableLayoutPanel();
            pnQLT = new Panel();
            lbQLT = new Label();
            splQLT_TK_HT = new SplitContainer();
            grbQLT_TK = new GroupBox();
            btnQLT_Tim = new Button();
            txtQLT_TK_TenThuoc = new TextBox();
            txtQLT_TK_MaThuoc = new TextBox();
            rdbQLT_TenThuoc = new RadioButton();
            rdbQLT_MaThuoc = new RadioButton();
            grbQLT_HT = new GroupBox();
            dgvQLT = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            pnQLT_TT_CN = new Panel();
            splQLT_TT_CN = new SplitContainer();
            grbQLT_TT = new GroupBox();
            txtQLT_TenThuoc = new TextBox();
            txtQLT_MaNhom = new TextBox();
            txtQLT_MaDN = new TextBox();
            txtQLT_MaThuoc = new TextBox();
            lbQLT_MaDN = new Label();
            lbQLT_MaNhom = new Label();
            lbQLT_TenThuoc = new Label();
            lbQLT_MaThuoc = new Label();
            grbQLT_CN = new GroupBox();
            btnQLT_Sua = new Button();
            btnQLT_Thoat = new Button();
            btnQLT_Import = new Button();
            btnQLT_Export = new Button();
            btnQLT_Xoa = new Button();
            btnQLT_Them = new Button();
            tlpQLT.SuspendLayout();
            pnQLT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splQLT_TK_HT).BeginInit();
            splQLT_TK_HT.Panel1.SuspendLayout();
            splQLT_TK_HT.Panel2.SuspendLayout();
            splQLT_TK_HT.SuspendLayout();
            grbQLT_TK.SuspendLayout();
            grbQLT_HT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLT).BeginInit();
            pnQLT_TT_CN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splQLT_TT_CN).BeginInit();
            splQLT_TT_CN.Panel1.SuspendLayout();
            splQLT_TT_CN.Panel2.SuspendLayout();
            splQLT_TT_CN.SuspendLayout();
            grbQLT_TT.SuspendLayout();
            grbQLT_CN.SuspendLayout();
            SuspendLayout();
            // 
            // tlpQLT
            // 
            tlpQLT.BackColor = SystemColors.Control;
            tlpQLT.ColumnCount = 1;
            tlpQLT.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpQLT.Controls.Add(pnQLT, 0, 0);
            tlpQLT.Controls.Add(splQLT_TK_HT, 0, 1);
            tlpQLT.Controls.Add(pnQLT_TT_CN, 0, 2);
            tlpQLT.Dock = DockStyle.Fill;
            tlpQLT.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            tlpQLT.Location = new Point(0, 0);
            tlpQLT.Margin = new Padding(2, 2, 2, 2);
            tlpQLT.Name = "tlpQLT";
            tlpQLT.RowCount = 3;
            tlpQLT.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tlpQLT.RowStyles.Add(new RowStyle(SizeType.Absolute, 459F));
            tlpQLT.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tlpQLT.Size = new Size(1092, 781);
            tlpQLT.TabIndex = 1;
            // 
            // pnQLT
            // 
            pnQLT.BackColor = Color.FromArgb(63, 139, 208);
            pnQLT.Controls.Add(lbQLT);
            pnQLT.Dock = DockStyle.Fill;
            pnQLT.Location = new Point(2, 2);
            pnQLT.Margin = new Padding(2, 2, 2, 2);
            pnQLT.Name = "pnQLT";
            pnQLT.Size = new Size(1088, 58);
            pnQLT.TabIndex = 0;
            // 
            // lbQLT
            // 
            lbQLT.AutoSize = true;
            lbQLT.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLT.ForeColor = SystemColors.ButtonHighlight;
            lbQLT.Location = new Point(448, 12);
            lbQLT.Margin = new Padding(2, 0, 2, 0);
            lbQLT.Name = "lbQLT";
            lbQLT.Size = new Size(241, 38);
            lbQLT.TabIndex = 0;
            lbQLT.Text = "QUẢN LÝ THUỐC";
            lbQLT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splQLT_TK_HT
            // 
            splQLT_TK_HT.Dock = DockStyle.Fill;
            splQLT_TK_HT.Location = new Point(2, 64);
            splQLT_TK_HT.Margin = new Padding(2, 2, 2, 2);
            splQLT_TK_HT.Name = "splQLT_TK_HT";
            splQLT_TK_HT.Orientation = Orientation.Horizontal;
            // 
            // splQLT_TK_HT.Panel1
            // 
            splQLT_TK_HT.Panel1.Controls.Add(grbQLT_TK);
            // 
            // splQLT_TK_HT.Panel2
            // 
            splQLT_TK_HT.Panel2.Controls.Add(grbQLT_HT);
            splQLT_TK_HT.Size = new Size(1088, 455);
            splQLT_TK_HT.SplitterDistance = 93;
            splQLT_TK_HT.SplitterWidth = 3;
            splQLT_TK_HT.TabIndex = 1;
            // 
            // grbQLT_TK
            // 
            grbQLT_TK.Controls.Add(btnQLT_Tim);
            grbQLT_TK.Controls.Add(txtQLT_TK_TenThuoc);
            grbQLT_TK.Controls.Add(txtQLT_TK_MaThuoc);
            grbQLT_TK.Controls.Add(rdbQLT_TenThuoc);
            grbQLT_TK.Controls.Add(rdbQLT_MaThuoc);
            grbQLT_TK.Dock = DockStyle.Fill;
            grbQLT_TK.Location = new Point(0, 0);
            grbQLT_TK.Margin = new Padding(2, 2, 2, 2);
            grbQLT_TK.Name = "grbQLT_TK";
            grbQLT_TK.Padding = new Padding(2, 2, 2, 2);
            grbQLT_TK.Size = new Size(1088, 93);
            grbQLT_TK.TabIndex = 0;
            grbQLT_TK.TabStop = false;
            grbQLT_TK.Text = "Tìm kiếm";
            // 
            // btnQLT_Tim
            // 
            btnQLT_Tim.BackColor = SystemColors.ButtonHighlight;
            btnQLT_Tim.FlatAppearance.BorderSize = 0;
            btnQLT_Tim.FlatStyle = FlatStyle.Flat;
            btnQLT_Tim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLT_Tim.Image = Properties.Resources.glass;
            btnQLT_Tim.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLT_Tim.Location = new Point(931, 31);
            btnQLT_Tim.Margin = new Padding(2, 2, 2, 2);
            btnQLT_Tim.Name = "btnQLT_Tim";
            btnQLT_Tim.Size = new Size(120, 45);
            btnQLT_Tim.TabIndex = 4;
            btnQLT_Tim.Text = "Tìm";
            btnQLT_Tim.UseVisualStyleBackColor = false;
            // 
            // txtQLT_TK_TenThuoc
            // 
            txtQLT_TK_TenThuoc.Location = new Point(563, 43);
            txtQLT_TK_TenThuoc.Margin = new Padding(2, 2, 2, 2);
            txtQLT_TK_TenThuoc.Name = "txtQLT_TK_TenThuoc";
            txtQLT_TK_TenThuoc.Size = new Size(302, 34);
            txtQLT_TK_TenThuoc.TabIndex = 3;
            // 
            // txtQLT_TK_MaThuoc
            // 
            txtQLT_TK_MaThuoc.Location = new Point(165, 43);
            txtQLT_TK_MaThuoc.Margin = new Padding(2, 2, 2, 2);
            txtQLT_TK_MaThuoc.Name = "txtQLT_TK_MaThuoc";
            txtQLT_TK_MaThuoc.Size = new Size(191, 34);
            txtQLT_TK_MaThuoc.TabIndex = 2;
            // 
            // rdbQLT_TenThuoc
            // 
            rdbQLT_TenThuoc.AutoSize = true;
            rdbQLT_TenThuoc.Location = new Point(414, 43);
            rdbQLT_TenThuoc.Margin = new Padding(2, 2, 2, 2);
            rdbQLT_TenThuoc.Name = "rdbQLT_TenThuoc";
            rdbQLT_TenThuoc.Size = new Size(129, 34);
            rdbQLT_TenThuoc.TabIndex = 1;
            rdbQLT_TenThuoc.TabStop = true;
            rdbQLT_TenThuoc.Text = "Tên thuốc";
            rdbQLT_TenThuoc.UseVisualStyleBackColor = true;
            // 
            // rdbQLT_MaThuoc
            // 
            rdbQLT_MaThuoc.AutoSize = true;
            rdbQLT_MaThuoc.Location = new Point(34, 43);
            rdbQLT_MaThuoc.Margin = new Padding(2, 2, 2, 2);
            rdbQLT_MaThuoc.Name = "rdbQLT_MaThuoc";
            rdbQLT_MaThuoc.Size = new Size(127, 34);
            rdbQLT_MaThuoc.TabIndex = 0;
            rdbQLT_MaThuoc.TabStop = true;
            rdbQLT_MaThuoc.Text = "Mã thuốc";
            rdbQLT_MaThuoc.UseVisualStyleBackColor = true;
            // 
            // grbQLT_HT
            // 
            grbQLT_HT.Controls.Add(dgvQLT);
            grbQLT_HT.Dock = DockStyle.Fill;
            grbQLT_HT.Location = new Point(0, 0);
            grbQLT_HT.Margin = new Padding(2, 2, 2, 2);
            grbQLT_HT.Name = "grbQLT_HT";
            grbQLT_HT.Padding = new Padding(2, 2, 2, 2);
            grbQLT_HT.Size = new Size(1088, 359);
            grbQLT_HT.TabIndex = 0;
            grbQLT_HT.TabStop = false;
            grbQLT_HT.Text = "Hiển thị";
            // 
            // dgvQLT
            // 
            dgvQLT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLT.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvQLT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvQLT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLT.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column4, Column2 });
            dgvQLT.Dock = DockStyle.Fill;
            dgvQLT.Location = new Point(2, 29);
            dgvQLT.Margin = new Padding(2, 2, 2, 2);
            dgvQLT.Name = "dgvQLT";
            dgvQLT.RowHeadersWidth = 82;
            dgvQLT.RowTemplate.Height = 41;
            dgvQLT.Size = new Size(1084, 328);
            dgvQLT.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã thuốc";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            // 
            // Column3
            // 
            Column3.HeaderText = "Mã đơn nhập";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Mã nhóm thuốc";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên thuốc";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            // 
            // pnQLT_TT_CN
            // 
            pnQLT_TT_CN.Controls.Add(splQLT_TT_CN);
            pnQLT_TT_CN.Location = new Point(2, 523);
            pnQLT_TT_CN.Margin = new Padding(2, 2, 2, 2);
            pnQLT_TT_CN.Name = "pnQLT_TT_CN";
            pnQLT_TT_CN.Size = new Size(1088, 254);
            pnQLT_TT_CN.TabIndex = 2;
            // 
            // splQLT_TT_CN
            // 
            splQLT_TT_CN.Dock = DockStyle.Fill;
            splQLT_TT_CN.Location = new Point(0, 0);
            splQLT_TT_CN.Margin = new Padding(2, 2, 2, 2);
            splQLT_TT_CN.Name = "splQLT_TT_CN";
            // 
            // splQLT_TT_CN.Panel1
            // 
            splQLT_TT_CN.Panel1.Controls.Add(grbQLT_TT);
            // 
            // splQLT_TT_CN.Panel2
            // 
            splQLT_TT_CN.Panel2.Controls.Add(grbQLT_CN);
            splQLT_TT_CN.Size = new Size(1088, 254);
            splQLT_TT_CN.SplitterDistance = 599;
            splQLT_TT_CN.SplitterWidth = 3;
            splQLT_TT_CN.TabIndex = 3;
            // 
            // grbQLT_TT
            // 
            grbQLT_TT.Controls.Add(txtQLT_TenThuoc);
            grbQLT_TT.Controls.Add(txtQLT_MaNhom);
            grbQLT_TT.Controls.Add(txtQLT_MaDN);
            grbQLT_TT.Controls.Add(txtQLT_MaThuoc);
            grbQLT_TT.Controls.Add(lbQLT_MaDN);
            grbQLT_TT.Controls.Add(lbQLT_MaNhom);
            grbQLT_TT.Controls.Add(lbQLT_TenThuoc);
            grbQLT_TT.Controls.Add(lbQLT_MaThuoc);
            grbQLT_TT.Dock = DockStyle.Fill;
            grbQLT_TT.Location = new Point(0, 0);
            grbQLT_TT.Margin = new Padding(2, 2, 2, 2);
            grbQLT_TT.Name = "grbQLT_TT";
            grbQLT_TT.Padding = new Padding(2, 2, 2, 2);
            grbQLT_TT.Size = new Size(599, 254);
            grbQLT_TT.TabIndex = 0;
            grbQLT_TT.TabStop = false;
            grbQLT_TT.Text = "Thông tin";
            // 
            // txtQLT_TenThuoc
            // 
            txtQLT_TenThuoc.Location = new Point(206, 211);
            txtQLT_TenThuoc.Margin = new Padding(2, 2, 2, 2);
            txtQLT_TenThuoc.Name = "txtQLT_TenThuoc";
            txtQLT_TenThuoc.Size = new Size(339, 34);
            txtQLT_TenThuoc.TabIndex = 7;
            // 
            // txtQLT_MaNhom
            // 
            txtQLT_MaNhom.Location = new Point(206, 152);
            txtQLT_MaNhom.Margin = new Padding(2, 2, 2, 2);
            txtQLT_MaNhom.Name = "txtQLT_MaNhom";
            txtQLT_MaNhom.Size = new Size(339, 34);
            txtQLT_MaNhom.TabIndex = 6;
            // 
            // txtQLT_MaDN
            // 
            txtQLT_MaDN.Location = new Point(206, 92);
            txtQLT_MaDN.Margin = new Padding(2, 2, 2, 2);
            txtQLT_MaDN.Name = "txtQLT_MaDN";
            txtQLT_MaDN.Size = new Size(339, 34);
            txtQLT_MaDN.TabIndex = 5;
            // 
            // txtQLT_MaThuoc
            // 
            txtQLT_MaThuoc.Location = new Point(206, 33);
            txtQLT_MaThuoc.Margin = new Padding(2, 2, 2, 2);
            txtQLT_MaThuoc.Name = "txtQLT_MaThuoc";
            txtQLT_MaThuoc.Size = new Size(339, 34);
            txtQLT_MaThuoc.TabIndex = 4;
            // 
            // lbQLT_MaDN
            // 
            lbQLT_MaDN.AutoSize = true;
            lbQLT_MaDN.Location = new Point(32, 95);
            lbQLT_MaDN.Margin = new Padding(2, 0, 2, 0);
            lbQLT_MaDN.Name = "lbQLT_MaDN";
            lbQLT_MaDN.Size = new Size(139, 30);
            lbQLT_MaDN.TabIndex = 3;
            lbQLT_MaDN.Text = "Mã đơn nhập";
            // 
            // lbQLT_MaNhom
            // 
            lbQLT_MaNhom.AutoSize = true;
            lbQLT_MaNhom.Location = new Point(32, 152);
            lbQLT_MaNhom.Margin = new Padding(2, 0, 2, 0);
            lbQLT_MaNhom.Name = "lbQLT_MaNhom";
            lbQLT_MaNhom.Size = new Size(162, 30);
            lbQLT_MaNhom.TabIndex = 2;
            lbQLT_MaNhom.Text = "Mã nhóm thuốc";
            // 
            // lbQLT_TenThuoc
            // 
            lbQLT_TenThuoc.AutoSize = true;
            lbQLT_TenThuoc.Location = new Point(32, 210);
            lbQLT_TenThuoc.Margin = new Padding(2, 0, 2, 0);
            lbQLT_TenThuoc.Name = "lbQLT_TenThuoc";
            lbQLT_TenThuoc.Size = new Size(104, 30);
            lbQLT_TenThuoc.TabIndex = 1;
            lbQLT_TenThuoc.Text = "Tên thuốc";
            // 
            // lbQLT_MaThuoc
            // 
            lbQLT_MaThuoc.AutoSize = true;
            lbQLT_MaThuoc.Location = new Point(32, 37);
            lbQLT_MaThuoc.Margin = new Padding(2, 0, 2, 0);
            lbQLT_MaThuoc.Name = "lbQLT_MaThuoc";
            lbQLT_MaThuoc.Size = new Size(102, 30);
            lbQLT_MaThuoc.TabIndex = 0;
            lbQLT_MaThuoc.Text = "Mã thuốc";
            // 
            // grbQLT_CN
            // 
            grbQLT_CN.Controls.Add(btnQLT_Sua);
            grbQLT_CN.Controls.Add(btnQLT_Export);
            grbQLT_CN.Controls.Add(btnQLT_Thoat);
            grbQLT_CN.Controls.Add(btnQLT_Them);
            grbQLT_CN.Controls.Add(btnQLT_Import);
            grbQLT_CN.Controls.Add(btnQLT_Xoa);
            grbQLT_CN.Dock = DockStyle.Fill;
            grbQLT_CN.Location = new Point(0, 0);
            grbQLT_CN.Margin = new Padding(2, 2, 2, 2);
            grbQLT_CN.Name = "grbQLT_CN";
            grbQLT_CN.Padding = new Padding(2, 2, 2, 2);
            grbQLT_CN.Size = new Size(486, 254);
            grbQLT_CN.TabIndex = 0;
            grbQLT_CN.TabStop = false;
            grbQLT_CN.Text = "Chức năng";
            // 
            // btnQLT_Sua
            // 
            btnQLT_Sua.BackColor = SystemColors.ButtonHighlight;
            btnQLT_Sua.FlatAppearance.BorderSize = 0;
            btnQLT_Sua.FlatStyle = FlatStyle.Flat;
            btnQLT_Sua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLT_Sua.ForeColor = SystemColors.ControlText;
            btnQLT_Sua.Image = Properties.Resources.Edit;
            btnQLT_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLT_Sua.Location = new Point(89, 115);
            btnQLT_Sua.Margin = new Padding(2);
            btnQLT_Sua.Name = "btnQLT_Sua";
            btnQLT_Sua.Size = new Size(130, 50);
            btnQLT_Sua.TabIndex = 11;
            btnQLT_Sua.Text = "Sửa";
            btnQLT_Sua.UseVisualStyleBackColor = false;
            // 
            // btnQLT_Thoat
            // 
            btnQLT_Thoat.BackColor = Color.Red;
            btnQLT_Thoat.FlatAppearance.BorderSize = 0;
            btnQLT_Thoat.FlatStyle = FlatStyle.Flat;
            btnQLT_Thoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLT_Thoat.ForeColor = Color.White;
            btnQLT_Thoat.Image = Properties.Resources.Logout;
            btnQLT_Thoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLT_Thoat.Location = new Point(268, 183);
            btnQLT_Thoat.Margin = new Padding(2);
            btnQLT_Thoat.Name = "btnQLT_Thoat";
            btnQLT_Thoat.Size = new Size(130, 50);
            btnQLT_Thoat.TabIndex = 8;
            btnQLT_Thoat.Text = "Thoát";
            btnQLT_Thoat.UseVisualStyleBackColor = false;
            // 
            // btnQLT_Import
            // 
            btnQLT_Import.BackColor = SystemColors.ButtonHighlight;
            btnQLT_Import.FlatAppearance.BorderSize = 0;
            btnQLT_Import.FlatStyle = FlatStyle.Flat;
            btnQLT_Import.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLT_Import.ForeColor = SystemColors.ControlText;
            btnQLT_Import.Image = Properties.Resources.import;
            btnQLT_Import.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLT_Import.Location = new Point(268, 115);
            btnQLT_Import.Margin = new Padding(2);
            btnQLT_Import.Name = "btnQLT_Import";
            btnQLT_Import.Size = new Size(130, 50);
            btnQLT_Import.TabIndex = 10;
            btnQLT_Import.Text = "Import";
            btnQLT_Import.UseVisualStyleBackColor = false;
            // 
            // btnQLT_Export
            // 
            btnQLT_Export.BackColor = SystemColors.ButtonHighlight;
            btnQLT_Export.FlatAppearance.BorderSize = 0;
            btnQLT_Export.FlatStyle = FlatStyle.Flat;
            btnQLT_Export.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLT_Export.ForeColor = SystemColors.ControlText;
            btnQLT_Export.Image = Properties.Resources.export;
            btnQLT_Export.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLT_Export.Location = new Point(268, 47);
            btnQLT_Export.Margin = new Padding(2);
            btnQLT_Export.Name = "btnQLT_Export";
            btnQLT_Export.Size = new Size(130, 50);
            btnQLT_Export.TabIndex = 9;
            btnQLT_Export.Text = "Export";
            btnQLT_Export.UseVisualStyleBackColor = false;
            // 
            // btnQLT_Xoa
            // 
            btnQLT_Xoa.BackColor = SystemColors.ButtonHighlight;
            btnQLT_Xoa.FlatAppearance.BorderSize = 0;
            btnQLT_Xoa.FlatStyle = FlatStyle.Flat;
            btnQLT_Xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLT_Xoa.ForeColor = SystemColors.ControlText;
            btnQLT_Xoa.Image = Properties.Resources.Delete;
            btnQLT_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLT_Xoa.Location = new Point(89, 183);
            btnQLT_Xoa.Margin = new Padding(2);
            btnQLT_Xoa.Name = "btnQLT_Xoa";
            btnQLT_Xoa.Size = new Size(130, 50);
            btnQLT_Xoa.TabIndex = 7;
            btnQLT_Xoa.Text = "Xóa";
            btnQLT_Xoa.UseVisualStyleBackColor = false;
            // 
            // btnQLT_Them
            // 
            btnQLT_Them.BackColor = SystemColors.ButtonHighlight;
            btnQLT_Them.FlatAppearance.BorderSize = 0;
            btnQLT_Them.FlatStyle = FlatStyle.Flat;
            btnQLT_Them.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLT_Them.ForeColor = SystemColors.ControlText;
            btnQLT_Them.Image = Properties.Resources.New;
            btnQLT_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLT_Them.Location = new Point(89, 47);
            btnQLT_Them.Margin = new Padding(2);
            btnQLT_Them.Name = "btnQLT_Them";
            btnQLT_Them.Size = new Size(130, 50);
            btnQLT_Them.TabIndex = 6;
            btnQLT_Them.Text = "Thêm";
            btnQLT_Them.UseVisualStyleBackColor = false;
            // 
            // UC_QLThuoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpQLT);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UC_QLThuoc";
            Size = new Size(1092, 781);
            tlpQLT.ResumeLayout(false);
            pnQLT.ResumeLayout(false);
            pnQLT.PerformLayout();
            splQLT_TK_HT.Panel1.ResumeLayout(false);
            splQLT_TK_HT.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLT_TK_HT).EndInit();
            splQLT_TK_HT.ResumeLayout(false);
            grbQLT_TK.ResumeLayout(false);
            grbQLT_TK.PerformLayout();
            grbQLT_HT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLT).EndInit();
            pnQLT_TT_CN.ResumeLayout(false);
            splQLT_TT_CN.Panel1.ResumeLayout(false);
            splQLT_TT_CN.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLT_TT_CN).EndInit();
            splQLT_TT_CN.ResumeLayout(false);
            grbQLT_TT.ResumeLayout(false);
            grbQLT_TT.PerformLayout();
            grbQLT_CN.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpQLT;
        private Panel pnQLT;
        private Label lbQLT;
        private SplitContainer splQLT_TK_HT;
        private GroupBox grbQLT_TK;
        private Button btnQLT_Tim;
        private TextBox txtQLT_TK_TenThuoc;
        private TextBox txtQLT_TK_MaThuoc;
        private RadioButton rdbQLT_TenThuoc;
        private RadioButton rdbQLT_MaThuoc;
        private GroupBox grbQLT_HT;
        private DataGridView dgvQLT;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private Panel pnQLT_TT_CN;
        private SplitContainer splQLT_TT_CN;
        private GroupBox grbQLT_TT;
        private TextBox txtQLT_TenThuoc;
        private TextBox txtQLT_MaNhom;
        private TextBox txtQLT_MaDN;
        private TextBox txtQLT_MaThuoc;
        private Label lbQLT_MaDN;
        private Label lbQLT_MaNhom;
        private Label lbQLT_TenThuoc;
        private Label lbQLT_MaThuoc;
        private GroupBox grbQLT_CN;
        private Button btnQLT_Sua;
        private Button btnQLT_Export;
        private Button btnQLT_Thoat;
        private Button btnQLT_Them;
        private Button btnQLT_Import;
        private Button btnQLT_Xoa;
    }
}
