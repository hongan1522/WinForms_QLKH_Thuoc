namespace FormQLKH
{
    partial class UC_QLDonNhap
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
            tlpQLDN = new TableLayoutPanel();
            grbQLDN_TT = new GroupBox();
            cbQLDN_MaNCC = new ComboBox();
            cbQLDN_MaThuoc = new ComboBox();
            txtQLDN_TenDN = new TextBox();
            cbQLDN_MaNV = new ComboBox();
            dtpQLDN_NgayNhap = new DateTimePicker();
            lbQLDN_TenDN = new Label();
            txtQLDN_MaDN = new TextBox();
            lbQLDN_NgayNhap = new Label();
            lbQLDN_MaThuoc = new Label();
            lbQLDN_MaNCC = new Label();
            lbQLDN_MaNV = new Label();
            lbQLDN_MaDN = new Label();
            pnQLDN = new Panel();
            lbQLDN = new Label();
            grbQLDN_HT = new GroupBox();
            dgvQLDN = new DataGridView();
            splQLDN_TK_CN = new SplitContainer();
            grbQLDN_TK = new GroupBox();
            cbQLDN_TK_MaDN = new ComboBox();
            cbQLDN_TK_MaNV = new ComboBox();
            lbQLDN_TK_MaNV = new Label();
            lbQLDN_TK_MaDN = new Label();
            grbQLDN_CN = new GroupBox();
            btnQLDN_Export = new Button();
            btnQLDN_Import = new Button();
            btnQLDN_Xoa = new Button();
            btnQLDN_Sua = new Button();
            btnQLDN_Them = new Button();
            DNhap_ID = new DataGridViewTextBoxColumn();
            Thuoc_ID = new DataGridViewTextBoxColumn();
            NV_ID = new DataGridViewTextBoxColumn();
            NCC_ID = new DataGridViewTextBoxColumn();
            DN_Name = new DataGridViewTextBoxColumn();
            DN_Datetime = new DataGridViewTextBoxColumn();
            tlpQLDN.SuspendLayout();
            grbQLDN_TT.SuspendLayout();
            pnQLDN.SuspendLayout();
            grbQLDN_HT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLDN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splQLDN_TK_CN).BeginInit();
            splQLDN_TK_CN.Panel1.SuspendLayout();
            splQLDN_TK_CN.Panel2.SuspendLayout();
            splQLDN_TK_CN.SuspendLayout();
            grbQLDN_TK.SuspendLayout();
            grbQLDN_CN.SuspendLayout();
            SuspendLayout();
            // 
            // tlpQLDN
            // 
            tlpQLDN.BackColor = SystemColors.Control;
            tlpQLDN.ColumnCount = 1;
            tlpQLDN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpQLDN.Controls.Add(grbQLDN_TT, 0, 2);
            tlpQLDN.Controls.Add(pnQLDN, 0, 0);
            tlpQLDN.Controls.Add(grbQLDN_HT, 0, 1);
            tlpQLDN.Controls.Add(splQLDN_TK_CN, 0, 3);
            tlpQLDN.Dock = DockStyle.Fill;
            tlpQLDN.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            tlpQLDN.Location = new Point(0, 0);
            tlpQLDN.Name = "tlpQLDN";
            tlpQLDN.RowCount = 4;
            tlpQLDN.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tlpQLDN.RowStyles.Add(new RowStyle(SizeType.Absolute, 503F));
            tlpQLDN.RowStyles.Add(new RowStyle(SizeType.Absolute, 257F));
            tlpQLDN.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tlpQLDN.Size = new Size(1448, 1082);
            tlpQLDN.TabIndex = 1;
            // 
            // grbQLDN_TT
            // 
            grbQLDN_TT.BackgroundImage = Properties.Resources.bg;
            grbQLDN_TT.Controls.Add(cbQLDN_MaNCC);
            grbQLDN_TT.Controls.Add(cbQLDN_MaThuoc);
            grbQLDN_TT.Controls.Add(txtQLDN_TenDN);
            grbQLDN_TT.Controls.Add(cbQLDN_MaNV);
            grbQLDN_TT.Controls.Add(dtpQLDN_NgayNhap);
            grbQLDN_TT.Controls.Add(lbQLDN_TenDN);
            grbQLDN_TT.Controls.Add(txtQLDN_MaDN);
            grbQLDN_TT.Controls.Add(lbQLDN_NgayNhap);
            grbQLDN_TT.Controls.Add(lbQLDN_MaThuoc);
            grbQLDN_TT.Controls.Add(lbQLDN_MaNCC);
            grbQLDN_TT.Controls.Add(lbQLDN_MaNV);
            grbQLDN_TT.Controls.Add(lbQLDN_MaDN);
            grbQLDN_TT.Dock = DockStyle.Fill;
            grbQLDN_TT.Location = new Point(3, 584);
            grbQLDN_TT.Name = "grbQLDN_TT";
            grbQLDN_TT.Size = new Size(1442, 251);
            grbQLDN_TT.TabIndex = 6;
            grbQLDN_TT.TabStop = false;
            grbQLDN_TT.Text = "Thông tin";
            // 
            // cbQLDN_MaNCC
            // 
            cbQLDN_MaNCC.FormattingEnabled = true;
            cbQLDN_MaNCC.Location = new Point(1036, 49);
            cbQLDN_MaNCC.Name = "cbQLDN_MaNCC";
            cbQLDN_MaNCC.Size = new Size(329, 45);
            cbQLDN_MaNCC.TabIndex = 35;
            // 
            // cbQLDN_MaThuoc
            // 
            cbQLDN_MaThuoc.FormattingEnabled = true;
            cbQLDN_MaThuoc.Location = new Point(1036, 188);
            cbQLDN_MaThuoc.Name = "cbQLDN_MaThuoc";
            cbQLDN_MaThuoc.Size = new Size(329, 45);
            cbQLDN_MaThuoc.TabIndex = 34;
            // 
            // txtQLDN_TenDN
            // 
            txtQLDN_TenDN.Location = new Point(313, 117);
            txtQLDN_TenDN.Name = "txtQLDN_TenDN";
            txtQLDN_TenDN.Size = new Size(381, 43);
            txtQLDN_TenDN.TabIndex = 30;
            // 
            // cbQLDN_MaNV
            // 
            cbQLDN_MaNV.FormattingEnabled = true;
            cbQLDN_MaNV.Location = new Point(1036, 117);
            cbQLDN_MaNV.Name = "cbQLDN_MaNV";
            cbQLDN_MaNV.Size = new Size(329, 45);
            cbQLDN_MaNV.TabIndex = 33;
            // 
            // dtpQLDN_NgayNhap
            // 
            dtpQLDN_NgayNhap.CustomFormat = "dd/MM/yyyy";
            dtpQLDN_NgayNhap.Format = DateTimePickerFormat.Custom;
            dtpQLDN_NgayNhap.Location = new Point(313, 184);
            dtpQLDN_NgayNhap.Name = "dtpQLDN_NgayNhap";
            dtpQLDN_NgayNhap.Size = new Size(381, 43);
            dtpQLDN_NgayNhap.TabIndex = 32;
            // 
            // lbQLDN_TenDN
            // 
            lbQLDN_TenDN.AutoSize = true;
            lbQLDN_TenDN.BackColor = SystemColors.Control;
            lbQLDN_TenDN.BorderStyle = BorderStyle.Fixed3D;
            lbQLDN_TenDN.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLDN_TenDN.Location = new Point(59, 115);
            lbQLDN_TenDN.Name = "lbQLDN_TenDN";
            lbQLDN_TenDN.Size = new Size(186, 39);
            lbQLDN_TenDN.TabIndex = 22;
            lbQLDN_TenDN.Text = "Tên đơn nhập";
            // 
            // txtQLDN_MaDN
            // 
            txtQLDN_MaDN.Location = new Point(313, 48);
            txtQLDN_MaDN.Name = "txtQLDN_MaDN";
            txtQLDN_MaDN.Size = new Size(381, 43);
            txtQLDN_MaDN.TabIndex = 29;
            // 
            // lbQLDN_NgayNhap
            // 
            lbQLDN_NgayNhap.AutoSize = true;
            lbQLDN_NgayNhap.BackColor = SystemColors.Control;
            lbQLDN_NgayNhap.BorderStyle = BorderStyle.Fixed3D;
            lbQLDN_NgayNhap.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLDN_NgayNhap.Location = new Point(59, 185);
            lbQLDN_NgayNhap.Name = "lbQLDN_NgayNhap";
            lbQLDN_NgayNhap.Size = new Size(153, 39);
            lbQLDN_NgayNhap.TabIndex = 23;
            lbQLDN_NgayNhap.Text = "Ngày nhập";
            // 
            // lbQLDN_MaThuoc
            // 
            lbQLDN_MaThuoc.AutoSize = true;
            lbQLDN_MaThuoc.BackColor = SystemColors.Control;
            lbQLDN_MaThuoc.BorderStyle = BorderStyle.Fixed3D;
            lbQLDN_MaThuoc.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLDN_MaThuoc.Location = new Point(779, 188);
            lbQLDN_MaThuoc.Name = "lbQLDN_MaThuoc";
            lbQLDN_MaThuoc.Size = new Size(136, 39);
            lbQLDN_MaThuoc.TabIndex = 20;
            lbQLDN_MaThuoc.Text = "Mã thuốc";
            // 
            // lbQLDN_MaNCC
            // 
            lbQLDN_MaNCC.AutoSize = true;
            lbQLDN_MaNCC.BackColor = SystemColors.Control;
            lbQLDN_MaNCC.BorderStyle = BorderStyle.Fixed3D;
            lbQLDN_MaNCC.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLDN_MaNCC.Location = new Point(782, 45);
            lbQLDN_MaNCC.Name = "lbQLDN_MaNCC";
            lbQLDN_MaNCC.Size = new Size(229, 39);
            lbQLDN_MaNCC.TabIndex = 19;
            lbQLDN_MaNCC.Text = "Mã nhà cung cấp";
            // 
            // lbQLDN_MaNV
            // 
            lbQLDN_MaNV.AutoSize = true;
            lbQLDN_MaNV.BackColor = SystemColors.Control;
            lbQLDN_MaNV.BorderStyle = BorderStyle.Fixed3D;
            lbQLDN_MaNV.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLDN_MaNV.Location = new Point(779, 117);
            lbQLDN_MaNV.Name = "lbQLDN_MaNV";
            lbQLDN_MaNV.Size = new Size(185, 39);
            lbQLDN_MaNV.TabIndex = 18;
            lbQLDN_MaNV.Text = "Mã nhân viên";
            // 
            // lbQLDN_MaDN
            // 
            lbQLDN_MaDN.AutoSize = true;
            lbQLDN_MaDN.BackColor = SystemColors.Control;
            lbQLDN_MaDN.BorderStyle = BorderStyle.Fixed3D;
            lbQLDN_MaDN.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLDN_MaDN.Location = new Point(59, 49);
            lbQLDN_MaDN.Name = "lbQLDN_MaDN";
            lbQLDN_MaDN.Size = new Size(183, 39);
            lbQLDN_MaDN.TabIndex = 17;
            lbQLDN_MaDN.Text = "Mã đơn nhập";
            // 
            // pnQLDN
            // 
            pnQLDN.BackColor = Color.FromArgb(15, 142, 219);
            pnQLDN.Controls.Add(lbQLDN);
            pnQLDN.Dock = DockStyle.Fill;
            pnQLDN.Location = new Point(3, 3);
            pnQLDN.Name = "pnQLDN";
            pnQLDN.Size = new Size(1442, 72);
            pnQLDN.TabIndex = 0;
            // 
            // lbQLDN
            // 
            lbQLDN.AutoSize = true;
            lbQLDN.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLDN.ForeColor = SystemColors.ButtonHighlight;
            lbQLDN.Location = new Point(515, 13);
            lbQLDN.Name = "lbQLDN";
            lbQLDN.Size = new Size(392, 50);
            lbQLDN.TabIndex = 0;
            lbQLDN.Text = "QUẢN LÝ ĐƠN NHẬP";
            lbQLDN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grbQLDN_HT
            // 
            grbQLDN_HT.BackColor = Color.Transparent;
            grbQLDN_HT.BackgroundImage = Properties.Resources.bg;
            grbQLDN_HT.Controls.Add(dgvQLDN);
            grbQLDN_HT.Dock = DockStyle.Fill;
            grbQLDN_HT.Location = new Point(3, 81);
            grbQLDN_HT.Name = "grbQLDN_HT";
            grbQLDN_HT.Size = new Size(1442, 497);
            grbQLDN_HT.TabIndex = 7;
            grbQLDN_HT.TabStop = false;
            grbQLDN_HT.Text = "Hiển thị";
            // 
            // dgvQLDN
            // 
            dgvQLDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLDN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvQLDN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvQLDN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLDN.Columns.AddRange(new DataGridViewColumn[] { DNhap_ID, Thuoc_ID, NV_ID, NCC_ID, DN_Name, DN_Datetime });
            dgvQLDN.Dock = DockStyle.Fill;
            dgvQLDN.Location = new Point(3, 39);
            dgvQLDN.Name = "dgvQLDN";
            dgvQLDN.RowHeadersWidth = 82;
            dgvQLDN.RowTemplate.Height = 41;
            dgvQLDN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQLDN.Size = new Size(1436, 455);
            dgvQLDN.TabIndex = 0;
            dgvQLDN.RowPostPaint += dgvQLDN_RowPostPaint;
            dgvQLDN.SelectionChanged += dgvQLDN_SelectionChanged;
            // 
            // splQLDN_TK_CN
            // 
            splQLDN_TK_CN.BackgroundImage = Properties.Resources.bg;
            splQLDN_TK_CN.Dock = DockStyle.Bottom;
            splQLDN_TK_CN.Location = new Point(3, 841);
            splQLDN_TK_CN.Name = "splQLDN_TK_CN";
            // 
            // splQLDN_TK_CN.Panel1
            // 
            splQLDN_TK_CN.Panel1.BackColor = Color.Transparent;
            splQLDN_TK_CN.Panel1.Controls.Add(grbQLDN_TK);
            // 
            // splQLDN_TK_CN.Panel2
            // 
            splQLDN_TK_CN.Panel2.BackColor = Color.Transparent;
            splQLDN_TK_CN.Panel2.Controls.Add(grbQLDN_CN);
            splQLDN_TK_CN.Size = new Size(1442, 238);
            splQLDN_TK_CN.SplitterDistance = 684;
            splQLDN_TK_CN.TabIndex = 8;
            // 
            // grbQLDN_TK
            // 
            grbQLDN_TK.Controls.Add(cbQLDN_TK_MaDN);
            grbQLDN_TK.Controls.Add(cbQLDN_TK_MaNV);
            grbQLDN_TK.Controls.Add(lbQLDN_TK_MaNV);
            grbQLDN_TK.Controls.Add(lbQLDN_TK_MaDN);
            grbQLDN_TK.Dock = DockStyle.Fill;
            grbQLDN_TK.Location = new Point(0, 0);
            grbQLDN_TK.Name = "grbQLDN_TK";
            grbQLDN_TK.Size = new Size(684, 238);
            grbQLDN_TK.TabIndex = 0;
            grbQLDN_TK.TabStop = false;
            grbQLDN_TK.Text = "Tìm kiếm";
            // 
            // cbQLDN_TK_MaDN
            // 
            cbQLDN_TK_MaDN.FormattingEnabled = true;
            cbQLDN_TK_MaDN.Location = new Point(295, 74);
            cbQLDN_TK_MaDN.Name = "cbQLDN_TK_MaDN";
            cbQLDN_TK_MaDN.Size = new Size(329, 45);
            cbQLDN_TK_MaDN.TabIndex = 37;
            // 
            // cbQLDN_TK_MaNV
            // 
            cbQLDN_TK_MaNV.FormattingEnabled = true;
            cbQLDN_TK_MaNV.Location = new Point(295, 158);
            cbQLDN_TK_MaNV.Name = "cbQLDN_TK_MaNV";
            cbQLDN_TK_MaNV.Size = new Size(329, 45);
            cbQLDN_TK_MaNV.TabIndex = 36;
            // 
            // lbQLDN_TK_MaNV
            // 
            lbQLDN_TK_MaNV.AutoSize = true;
            lbQLDN_TK_MaNV.BackColor = SystemColors.Control;
            lbQLDN_TK_MaNV.BorderStyle = BorderStyle.Fixed3D;
            lbQLDN_TK_MaNV.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLDN_TK_MaNV.Location = new Point(34, 169);
            lbQLDN_TK_MaNV.Name = "lbQLDN_TK_MaNV";
            lbQLDN_TK_MaNV.Size = new Size(185, 39);
            lbQLDN_TK_MaNV.TabIndex = 20;
            lbQLDN_TK_MaNV.Text = "Mã nhân viên";
            // 
            // lbQLDN_TK_MaDN
            // 
            lbQLDN_TK_MaDN.AutoSize = true;
            lbQLDN_TK_MaDN.BackColor = SystemColors.Control;
            lbQLDN_TK_MaDN.BorderStyle = BorderStyle.Fixed3D;
            lbQLDN_TK_MaDN.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLDN_TK_MaDN.Location = new Point(34, 68);
            lbQLDN_TK_MaDN.Name = "lbQLDN_TK_MaDN";
            lbQLDN_TK_MaDN.Size = new Size(183, 39);
            lbQLDN_TK_MaDN.TabIndex = 19;
            lbQLDN_TK_MaDN.Text = "Mã đơn nhập";
            // 
            // grbQLDN_CN
            // 
            grbQLDN_CN.Controls.Add(btnQLDN_Export);
            grbQLDN_CN.Controls.Add(btnQLDN_Import);
            grbQLDN_CN.Controls.Add(btnQLDN_Xoa);
            grbQLDN_CN.Controls.Add(btnQLDN_Sua);
            grbQLDN_CN.Controls.Add(btnQLDN_Them);
            grbQLDN_CN.Dock = DockStyle.Fill;
            grbQLDN_CN.Location = new Point(0, 0);
            grbQLDN_CN.Name = "grbQLDN_CN";
            grbQLDN_CN.Size = new Size(754, 238);
            grbQLDN_CN.TabIndex = 10;
            grbQLDN_CN.TabStop = false;
            grbQLDN_CN.Text = "Chức năng";
            // 
            // btnQLDN_Export
            // 
            btnQLDN_Export.BackColor = SystemColors.ButtonHighlight;
            btnQLDN_Export.FlatAppearance.BorderColor = Color.Gainsboro;
            btnQLDN_Export.FlatAppearance.BorderSize = 0;
            btnQLDN_Export.FlatStyle = FlatStyle.Popup;
            btnQLDN_Export.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDN_Export.Image = Properties.Resources.export;
            btnQLDN_Export.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDN_Export.Location = new Point(434, 160);
            btnQLDN_Export.Name = "btnQLDN_Export";
            btnQLDN_Export.Size = new Size(169, 58);
            btnQLDN_Export.TabIndex = 4;
            btnQLDN_Export.Text = "Export";
            btnQLDN_Export.UseVisualStyleBackColor = false;
            // 
            // btnQLDN_Import
            // 
            btnQLDN_Import.BackColor = SystemColors.ButtonHighlight;
            btnQLDN_Import.FlatAppearance.BorderColor = Color.Gainsboro;
            btnQLDN_Import.FlatAppearance.BorderSize = 0;
            btnQLDN_Import.FlatStyle = FlatStyle.Popup;
            btnQLDN_Import.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDN_Import.Image = Properties.Resources.import;
            btnQLDN_Import.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDN_Import.Location = new Point(167, 160);
            btnQLDN_Import.Name = "btnQLDN_Import";
            btnQLDN_Import.Size = new Size(169, 58);
            btnQLDN_Import.TabIndex = 3;
            btnQLDN_Import.Text = "Import";
            btnQLDN_Import.UseVisualStyleBackColor = false;
            // 
            // btnQLDN_Xoa
            // 
            btnQLDN_Xoa.BackColor = SystemColors.ButtonHighlight;
            btnQLDN_Xoa.FlatAppearance.BorderColor = Color.Gainsboro;
            btnQLDN_Xoa.FlatAppearance.BorderSize = 0;
            btnQLDN_Xoa.FlatStyle = FlatStyle.Popup;
            btnQLDN_Xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDN_Xoa.Image = Properties.Resources.delete;
            btnQLDN_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDN_Xoa.Location = new Point(546, 68);
            btnQLDN_Xoa.Name = "btnQLDN_Xoa";
            btnQLDN_Xoa.Size = new Size(169, 58);
            btnQLDN_Xoa.TabIndex = 2;
            btnQLDN_Xoa.Text = "Xóa";
            btnQLDN_Xoa.UseVisualStyleBackColor = false;
            // 
            // btnQLDN_Sua
            // 
            btnQLDN_Sua.BackColor = SystemColors.ButtonHighlight;
            btnQLDN_Sua.FlatAppearance.BorderColor = Color.Gainsboro;
            btnQLDN_Sua.FlatAppearance.BorderSize = 0;
            btnQLDN_Sua.FlatStyle = FlatStyle.Popup;
            btnQLDN_Sua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDN_Sua.Image = Properties.Resources.update;
            btnQLDN_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDN_Sua.Location = new Point(294, 68);
            btnQLDN_Sua.Name = "btnQLDN_Sua";
            btnQLDN_Sua.Size = new Size(169, 58);
            btnQLDN_Sua.TabIndex = 1;
            btnQLDN_Sua.Text = "Sửa";
            btnQLDN_Sua.UseVisualStyleBackColor = false;
            // 
            // btnQLDN_Them
            // 
            btnQLDN_Them.BackColor = SystemColors.ButtonHighlight;
            btnQLDN_Them.FlatAppearance.BorderColor = Color.Gainsboro;
            btnQLDN_Them.FlatAppearance.BorderSize = 0;
            btnQLDN_Them.FlatStyle = FlatStyle.Popup;
            btnQLDN_Them.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDN_Them.Image = Properties.Resources.add;
            btnQLDN_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDN_Them.Location = new Point(42, 68);
            btnQLDN_Them.Name = "btnQLDN_Them";
            btnQLDN_Them.Size = new Size(169, 58);
            btnQLDN_Them.TabIndex = 0;
            btnQLDN_Them.Text = " Thêm";
            btnQLDN_Them.UseVisualStyleBackColor = false;
            // 
            // DNhap_ID
            // 
            DNhap_ID.DataPropertyName = "DNhap_ID";
            DNhap_ID.HeaderText = "Mã đơn nhập";
            DNhap_ID.MinimumWidth = 10;
            DNhap_ID.Name = "DNhap_ID";
            // 
            // Thuoc_ID
            // 
            Thuoc_ID.DataPropertyName = "Thuoc_ID";
            Thuoc_ID.HeaderText = "Mã thuốc";
            Thuoc_ID.MinimumWidth = 10;
            Thuoc_ID.Name = "Thuoc_ID";
            // 
            // NV_ID
            // 
            NV_ID.DataPropertyName = "NV_ID";
            NV_ID.HeaderText = "Mã NV";
            NV_ID.MinimumWidth = 10;
            NV_ID.Name = "NV_ID";
            // 
            // NCC_ID
            // 
            NCC_ID.DataPropertyName = "NCC_ID";
            NCC_ID.HeaderText = "Mã NCC";
            NCC_ID.MinimumWidth = 10;
            NCC_ID.Name = "NCC_ID";
            // 
            // DN_Name
            // 
            DN_Name.DataPropertyName = "DN_Name";
            DN_Name.HeaderText = "Tên đơn";
            DN_Name.MinimumWidth = 10;
            DN_Name.Name = "DN_Name";
            // 
            // DN_Datetime
            // 
            DN_Datetime.DataPropertyName = "DN_Datetime";
            DN_Datetime.HeaderText = "Ngày nhập ";
            DN_Datetime.MinimumWidth = 10;
            DN_Datetime.Name = "DN_Datetime";
            // 
            // UC_QLDonNhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpQLDN);
            Name = "UC_QLDonNhap";
            Size = new Size(1448, 1082);
            tlpQLDN.ResumeLayout(false);
            grbQLDN_TT.ResumeLayout(false);
            grbQLDN_TT.PerformLayout();
            pnQLDN.ResumeLayout(false);
            pnQLDN.PerformLayout();
            grbQLDN_HT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLDN).EndInit();
            splQLDN_TK_CN.Panel1.ResumeLayout(false);
            splQLDN_TK_CN.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLDN_TK_CN).EndInit();
            splQLDN_TK_CN.ResumeLayout(false);
            grbQLDN_TK.ResumeLayout(false);
            grbQLDN_TK.PerformLayout();
            grbQLDN_CN.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpQLDN;
        private GroupBox grbQLDN_TT;
        private Panel pnQLDN;
        private Label lbQLDN;
        private GroupBox grbQLDN_HT;
        private DataGridView dgvQLDN;
        private SplitContainer splQLDN_TK_CN;
        private GroupBox grbQLDN_TK;
        private GroupBox grbQLDN_CN;
        private Button btnQLDN_Export;
        private Button btnQLDN_Import;
        private Button btnQLDN_Xoa;
        private Button btnQLDN_Sua;
        private Button btnQLDN_Them;
        private DateTimePicker dtpQLDN_NgayNhap;
        private TextBox txtQLDN_TenDN;
        private TextBox txtQLDN_MaDN;
        private Label lbQLDN_NgayNhap;
        private Label lbQLDN_TenDN;
        private Label lbQLDN_MaThuoc;
        private Label lbQLDN_MaNCC;
        private Label lbQLDN_MaNV;
        private Label lbQLDN_MaDN;
        private Label lbQLDN_TK_MaNV;
        private Label lbQLDN_TK_MaDN;
        private ComboBox cbQLDN_MaNV;
        private ComboBox cbQLDN_MaNCC;
        private ComboBox cbQLDN_MaThuoc;
        private ComboBox cbQLDN_TK_MaDN;
        private ComboBox cbQLDN_TK_MaNV;
        private DataGridViewTextBoxColumn DNhap_ID;
        private DataGridViewTextBoxColumn Thuoc_ID;
        private DataGridViewTextBoxColumn NV_ID;
        private DataGridViewTextBoxColumn NCC_ID;
        private DataGridViewTextBoxColumn DN_Name;
        private DataGridViewTextBoxColumn DN_Datetime;
    }
}
