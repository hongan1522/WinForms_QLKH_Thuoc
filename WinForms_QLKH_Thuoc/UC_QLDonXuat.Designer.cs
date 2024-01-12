namespace FormQLKH
{
    partial class UC_QLDonXuat
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
            tlpQLDX = new TableLayoutPanel();
            pnQLDX = new Panel();
            lbQLDX = new Label();
            splQLDX_TT_TK = new SplitContainer();
            grbQLDX_TT = new GroupBox();
            linkQLDX = new LinkLabel();
            cbQLDX_MaNV = new ComboBox();
            dtpQLDX_NgayXuat = new DateTimePicker();
            txtQLDX_TenDX = new TextBox();
            txtQLDX_MaDX = new TextBox();
            lbQLDX_NgayXuat = new Label();
            lbQLDX_TenDX = new Label();
            lbQLDX_MaNV = new Label();
            lbQLDX_MaDX = new Label();
            grbQLDX_TK = new GroupBox();
            cbQLDX_TK_MaDX = new ComboBox();
            cbQLDX_TK_MaNV = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            splQLDX_CN_HT = new SplitContainer();
            grbQLDX_CN = new GroupBox();
            btnQLDX_Them = new Button();
            btnQLDX_Xoa = new Button();
            btnQLDX_Sua = new Button();
            grbQLDX_HT = new GroupBox();
            dgvQLDX = new DataGridView();
            DXuat_ID = new DataGridViewTextBoxColumn();
            NV_ID = new DataGridViewTextBoxColumn();
            DX_Name = new DataGridViewTextBoxColumn();
            DX_Datetime = new DataGridViewTextBoxColumn();
            tlpQLDX.SuspendLayout();
            pnQLDX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splQLDX_TT_TK).BeginInit();
            splQLDX_TT_TK.Panel1.SuspendLayout();
            splQLDX_TT_TK.Panel2.SuspendLayout();
            splQLDX_TT_TK.SuspendLayout();
            grbQLDX_TT.SuspendLayout();
            grbQLDX_TK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splQLDX_CN_HT).BeginInit();
            splQLDX_CN_HT.Panel1.SuspendLayout();
            splQLDX_CN_HT.Panel2.SuspendLayout();
            splQLDX_CN_HT.SuspendLayout();
            grbQLDX_CN.SuspendLayout();
            grbQLDX_HT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLDX).BeginInit();
            SuspendLayout();
            // 
            // tlpQLDX
            // 
            tlpQLDX.ColumnCount = 1;
            tlpQLDX.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpQLDX.Controls.Add(pnQLDX, 0, 0);
            tlpQLDX.Controls.Add(splQLDX_TT_TK, 0, 2);
            tlpQLDX.Controls.Add(splQLDX_CN_HT, 0, 1);
            tlpQLDX.Dock = DockStyle.Fill;
            tlpQLDX.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            tlpQLDX.Location = new Point(0, 0);
            tlpQLDX.Name = "tlpQLDX";
            tlpQLDX.RowCount = 3;
            tlpQLDX.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tlpQLDX.RowStyles.Add(new RowStyle(SizeType.Absolute, 690F));
            tlpQLDX.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tlpQLDX.Size = new Size(1448, 1082);
            tlpQLDX.TabIndex = 1;
            // 
            // pnQLDX
            // 
            pnQLDX.BackColor = Color.FromArgb(15, 142, 219);
            pnQLDX.Controls.Add(lbQLDX);
            pnQLDX.Dock = DockStyle.Fill;
            pnQLDX.Location = new Point(3, 3);
            pnQLDX.Name = "pnQLDX";
            pnQLDX.Size = new Size(1442, 70);
            pnQLDX.TabIndex = 0;
            // 
            // lbQLDX
            // 
            lbQLDX.AutoSize = true;
            lbQLDX.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLDX.ForeColor = SystemColors.ButtonHighlight;
            lbQLDX.Location = new Point(569, 12);
            lbQLDX.Name = "lbQLDX";
            lbQLDX.Size = new Size(385, 50);
            lbQLDX.TabIndex = 0;
            lbQLDX.Text = "QUẢN LÝ ĐƠN XUẤT";
            // 
            // splQLDX_TT_TK
            // 
            splQLDX_TT_TK.BackgroundImage = Properties.Resources.bg;
            splQLDX_TT_TK.Dock = DockStyle.Bottom;
            splQLDX_TT_TK.Location = new Point(3, 769);
            splQLDX_TT_TK.Name = "splQLDX_TT_TK";
            // 
            // splQLDX_TT_TK.Panel1
            // 
            splQLDX_TT_TK.Panel1.BackColor = Color.Transparent;
            splQLDX_TT_TK.Panel1.Controls.Add(grbQLDX_TT);
            // 
            // splQLDX_TT_TK.Panel2
            // 
            splQLDX_TT_TK.Panel2.BackColor = Color.Transparent;
            splQLDX_TT_TK.Panel2.Controls.Add(grbQLDX_TK);
            splQLDX_TT_TK.Size = new Size(1442, 310);
            splQLDX_TT_TK.SplitterDistance = 989;
            splQLDX_TT_TK.TabIndex = 2;
            // 
            // grbQLDX_TT
            // 
            grbQLDX_TT.Controls.Add(linkQLDX);
            grbQLDX_TT.Controls.Add(cbQLDX_MaNV);
            grbQLDX_TT.Controls.Add(dtpQLDX_NgayXuat);
            grbQLDX_TT.Controls.Add(txtQLDX_TenDX);
            grbQLDX_TT.Controls.Add(txtQLDX_MaDX);
            grbQLDX_TT.Controls.Add(lbQLDX_NgayXuat);
            grbQLDX_TT.Controls.Add(lbQLDX_TenDX);
            grbQLDX_TT.Controls.Add(lbQLDX_MaNV);
            grbQLDX_TT.Controls.Add(lbQLDX_MaDX);
            grbQLDX_TT.Dock = DockStyle.Fill;
            grbQLDX_TT.Location = new Point(0, 0);
            grbQLDX_TT.Name = "grbQLDX_TT";
            grbQLDX_TT.Size = new Size(989, 310);
            grbQLDX_TT.TabIndex = 0;
            grbQLDX_TT.TabStop = false;
            grbQLDX_TT.Text = "Thông tin";
            // 
            // linkQLDX
            // 
            linkQLDX.AutoSize = true;
            linkQLDX.Location = new Point(750, 254);
            linkQLDX.Name = "linkQLDX";
            linkQLDX.Size = new Size(213, 37);
            linkQLDX.TabIndex = 10;
            linkQLDX.TabStop = true;
            linkQLDX.Text = "Chi tiết đơn xuất";
            linkQLDX.Click += linkQLDX_Click;
            // 
            // cbQLDX_MaNV
            // 
            cbQLDX_MaNV.FormattingEnabled = true;
            cbQLDX_MaNV.Location = new Point(204, 173);
            cbQLDX_MaNV.Name = "cbQLDX_MaNV";
            cbQLDX_MaNV.Size = new Size(229, 45);
            cbQLDX_MaNV.TabIndex = 8;
            // 
            // dtpQLDX_NgayXuat
            // 
            dtpQLDX_NgayXuat.CustomFormat = "dd/MM/yyyy";
            dtpQLDX_NgayXuat.Format = DateTimePickerFormat.Custom;
            dtpQLDX_NgayXuat.Location = new Point(689, 69);
            dtpQLDX_NgayXuat.Name = "dtpQLDX_NgayXuat";
            dtpQLDX_NgayXuat.Size = new Size(272, 43);
            dtpQLDX_NgayXuat.TabIndex = 7;
            dtpQLDX_NgayXuat.Value = new DateTime(2023, 11, 27, 12, 53, 49, 0);
            // 
            // txtQLDX_TenDX
            // 
            txtQLDX_TenDX.Location = new Point(689, 147);
            txtQLDX_TenDX.Multiline = true;
            txtQLDX_TenDX.Name = "txtQLDX_TenDX";
            txtQLDX_TenDX.ScrollBars = ScrollBars.Vertical;
            txtQLDX_TenDX.Size = new Size(274, 81);
            txtQLDX_TenDX.TabIndex = 6;
            // 
            // txtQLDX_MaDX
            // 
            txtQLDX_MaDX.Location = new Point(204, 66);
            txtQLDX_MaDX.Name = "txtQLDX_MaDX";
            txtQLDX_MaDX.Size = new Size(229, 43);
            txtQLDX_MaDX.TabIndex = 4;
            // 
            // lbQLDX_NgayXuat
            // 
            lbQLDX_NgayXuat.AutoSize = true;
            lbQLDX_NgayXuat.BackColor = SystemColors.Control;
            lbQLDX_NgayXuat.BorderStyle = BorderStyle.Fixed3D;
            lbQLDX_NgayXuat.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLDX_NgayXuat.Location = new Point(489, 69);
            lbQLDX_NgayXuat.Name = "lbQLDX_NgayXuat";
            lbQLDX_NgayXuat.Size = new Size(145, 39);
            lbQLDX_NgayXuat.TabIndex = 3;
            lbQLDX_NgayXuat.Text = "Ngày xuất";
            // 
            // lbQLDX_TenDX
            // 
            lbQLDX_TenDX.AutoSize = true;
            lbQLDX_TenDX.BackColor = SystemColors.Control;
            lbQLDX_TenDX.BorderStyle = BorderStyle.Fixed3D;
            lbQLDX_TenDX.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLDX_TenDX.Location = new Point(489, 168);
            lbQLDX_TenDX.Name = "lbQLDX_TenDX";
            lbQLDX_TenDX.Size = new Size(178, 39);
            lbQLDX_TenDX.TabIndex = 2;
            lbQLDX_TenDX.Text = "Tên đơn xuất";
            // 
            // lbQLDX_MaNV
            // 
            lbQLDX_MaNV.AutoSize = true;
            lbQLDX_MaNV.BackColor = SystemColors.Control;
            lbQLDX_MaNV.BorderStyle = BorderStyle.Fixed3D;
            lbQLDX_MaNV.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLDX_MaNV.Location = new Point(18, 168);
            lbQLDX_MaNV.Name = "lbQLDX_MaNV";
            lbQLDX_MaNV.Size = new Size(103, 39);
            lbQLDX_MaNV.TabIndex = 1;
            lbQLDX_MaNV.Text = "Mã NV";
            // 
            // lbQLDX_MaDX
            // 
            lbQLDX_MaDX.AutoSize = true;
            lbQLDX_MaDX.BackColor = SystemColors.Control;
            lbQLDX_MaDX.BorderStyle = BorderStyle.Fixed3D;
            lbQLDX_MaDX.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLDX_MaDX.Location = new Point(18, 69);
            lbQLDX_MaDX.Name = "lbQLDX_MaDX";
            lbQLDX_MaDX.Size = new Size(175, 39);
            lbQLDX_MaDX.TabIndex = 0;
            lbQLDX_MaDX.Text = "Mã đơn xuất";
            // 
            // grbQLDX_TK
            // 
            grbQLDX_TK.Controls.Add(cbQLDX_TK_MaDX);
            grbQLDX_TK.Controls.Add(cbQLDX_TK_MaNV);
            grbQLDX_TK.Controls.Add(label2);
            grbQLDX_TK.Controls.Add(label1);
            grbQLDX_TK.Dock = DockStyle.Fill;
            grbQLDX_TK.Location = new Point(0, 0);
            grbQLDX_TK.Name = "grbQLDX_TK";
            grbQLDX_TK.Size = new Size(449, 310);
            grbQLDX_TK.TabIndex = 1;
            grbQLDX_TK.TabStop = false;
            grbQLDX_TK.Text = "Tìm kiếm";
            // 
            // cbQLDX_TK_MaDX
            // 
            cbQLDX_TK_MaDX.FormattingEnabled = true;
            cbQLDX_TK_MaDX.Location = new Point(217, 64);
            cbQLDX_TK_MaDX.Name = "cbQLDX_TK_MaDX";
            cbQLDX_TK_MaDX.Size = new Size(212, 45);
            cbQLDX_TK_MaDX.TabIndex = 10;
            cbQLDX_TK_MaDX.SelectedIndexChanged += cbQLDX_TK_MaDX_SelectedIndexChanged;
            // 
            // cbQLDX_TK_MaNV
            // 
            cbQLDX_TK_MaNV.FormattingEnabled = true;
            cbQLDX_TK_MaNV.Location = new Point(217, 183);
            cbQLDX_TK_MaNV.Name = "cbQLDX_TK_MaNV";
            cbQLDX_TK_MaNV.Size = new Size(212, 45);
            cbQLDX_TK_MaNV.TabIndex = 9;
            cbQLDX_TK_MaNV.SelectedIndexChanged += cbQLDX_TK_MaNV_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 189);
            label2.Name = "label2";
            label2.Size = new Size(103, 39);
            label2.TabIndex = 5;
            label2.Text = "Mã NV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 66);
            label1.Name = "label1";
            label1.Size = new Size(175, 39);
            label1.TabIndex = 4;
            label1.Text = "Mã đơn xuất";
            // 
            // splQLDX_CN_HT
            // 
            splQLDX_CN_HT.BackColor = Color.Transparent;
            splQLDX_CN_HT.BackgroundImage = Properties.Resources.bg;
            splQLDX_CN_HT.Dock = DockStyle.Fill;
            splQLDX_CN_HT.Location = new Point(3, 79);
            splQLDX_CN_HT.Name = "splQLDX_CN_HT";
            // 
            // splQLDX_CN_HT.Panel1
            // 
            splQLDX_CN_HT.Panel1.Controls.Add(grbQLDX_CN);
            // 
            // splQLDX_CN_HT.Panel2
            // 
            splQLDX_CN_HT.Panel2.Controls.Add(grbQLDX_HT);
            splQLDX_CN_HT.Size = new Size(1442, 684);
            splQLDX_CN_HT.SplitterDistance = 249;
            splQLDX_CN_HT.TabIndex = 3;
            // 
            // grbQLDX_CN
            // 
            grbQLDX_CN.Controls.Add(btnQLDX_Them);
            grbQLDX_CN.Controls.Add(btnQLDX_Xoa);
            grbQLDX_CN.Controls.Add(btnQLDX_Sua);
            grbQLDX_CN.Dock = DockStyle.Fill;
            grbQLDX_CN.Location = new Point(0, 0);
            grbQLDX_CN.Name = "grbQLDX_CN";
            grbQLDX_CN.Size = new Size(249, 684);
            grbQLDX_CN.TabIndex = 0;
            grbQLDX_CN.TabStop = false;
            grbQLDX_CN.Text = "Chức năng";
            // 
            // btnQLDX_Them
            // 
            btnQLDX_Them.BackColor = SystemColors.ButtonHighlight;
            btnQLDX_Them.FlatAppearance.BorderSize = 0;
            btnQLDX_Them.FlatStyle = FlatStyle.Popup;
            btnQLDX_Them.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDX_Them.Image = Properties.Resources.add;
            btnQLDX_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDX_Them.Location = new Point(31, 75);
            btnQLDX_Them.Name = "btnQLDX_Them";
            btnQLDX_Them.Size = new Size(182, 58);
            btnQLDX_Them.TabIndex = 12;
            btnQLDX_Them.Text = "Thêm";
            btnQLDX_Them.UseVisualStyleBackColor = false;
            btnQLDX_Them.Click += btnQLDX_Them_Click;
            // 
            // btnQLDX_Xoa
            // 
            btnQLDX_Xoa.BackColor = SystemColors.ButtonHighlight;
            btnQLDX_Xoa.FlatAppearance.BorderSize = 0;
            btnQLDX_Xoa.FlatStyle = FlatStyle.Popup;
            btnQLDX_Xoa.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDX_Xoa.Image = Properties.Resources.delete;
            btnQLDX_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDX_Xoa.Location = new Point(31, 597);
            btnQLDX_Xoa.Name = "btnQLDX_Xoa";
            btnQLDX_Xoa.Size = new Size(182, 58);
            btnQLDX_Xoa.TabIndex = 14;
            btnQLDX_Xoa.Text = "Xóa";
            btnQLDX_Xoa.UseVisualStyleBackColor = false;
            btnQLDX_Xoa.Click += btnQLDX_Xoa_Click;
            // 
            // btnQLDX_Sua
            // 
            btnQLDX_Sua.BackColor = SystemColors.ButtonHighlight;
            btnQLDX_Sua.FlatAppearance.BorderSize = 0;
            btnQLDX_Sua.FlatStyle = FlatStyle.Popup;
            btnQLDX_Sua.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDX_Sua.Image = Properties.Resources.update;
            btnQLDX_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDX_Sua.Location = new Point(31, 336);
            btnQLDX_Sua.Name = "btnQLDX_Sua";
            btnQLDX_Sua.Size = new Size(182, 58);
            btnQLDX_Sua.TabIndex = 13;
            btnQLDX_Sua.Text = "Sửa";
            btnQLDX_Sua.UseVisualStyleBackColor = false;
            btnQLDX_Sua.Click += btnQLDX_Sua_Click;
            // 
            // grbQLDX_HT
            // 
            grbQLDX_HT.Controls.Add(dgvQLDX);
            grbQLDX_HT.Dock = DockStyle.Fill;
            grbQLDX_HT.Location = new Point(0, 0);
            grbQLDX_HT.Name = "grbQLDX_HT";
            grbQLDX_HT.Size = new Size(1189, 684);
            grbQLDX_HT.TabIndex = 4;
            grbQLDX_HT.TabStop = false;
            grbQLDX_HT.Text = "Hiển thị";
            // 
            // dgvQLDX
            // 
            dgvQLDX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLDX.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvQLDX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvQLDX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLDX.Columns.AddRange(new DataGridViewColumn[] { DXuat_ID, NV_ID, DX_Name, DX_Datetime });
            dgvQLDX.Dock = DockStyle.Fill;
            dgvQLDX.Location = new Point(3, 39);
            dgvQLDX.Name = "dgvQLDX";
            dgvQLDX.RowHeadersWidth = 82;
            dgvQLDX.RowTemplate.Height = 41;
            dgvQLDX.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQLDX.Size = new Size(1183, 642);
            dgvQLDX.TabIndex = 2;
            dgvQLDX.RowPostPaint += dgvQLDX_RowPostPaint;
            dgvQLDX.SelectionChanged += dgvQLDX_SelectionChanged;
            // 
            // DXuat_ID
            // 
            DXuat_ID.DataPropertyName = "DXuat_ID";
            DXuat_ID.HeaderText = "Mã đơn xuất";
            DXuat_ID.MinimumWidth = 10;
            DXuat_ID.Name = "DXuat_ID";
            // 
            // NV_ID
            // 
            NV_ID.DataPropertyName = "NV_ID";
            NV_ID.HeaderText = "Mã nhân viên";
            NV_ID.MinimumWidth = 10;
            NV_ID.Name = "NV_ID";
            // 
            // DX_Name
            // 
            DX_Name.DataPropertyName = "DX_Name";
            DX_Name.HeaderText = "Tên đơn";
            DX_Name.MinimumWidth = 10;
            DX_Name.Name = "DX_Name";
            // 
            // DX_Datetime
            // 
            DX_Datetime.DataPropertyName = "DX_Datetime";
            DX_Datetime.HeaderText = "Ngày xuất";
            DX_Datetime.MinimumWidth = 10;
            DX_Datetime.Name = "DX_Datetime";
            // 
            // UC_QLDonXuat
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpQLDX);
            Name = "UC_QLDonXuat";
            Size = new Size(1448, 1082);
            tlpQLDX.ResumeLayout(false);
            pnQLDX.ResumeLayout(false);
            pnQLDX.PerformLayout();
            splQLDX_TT_TK.Panel1.ResumeLayout(false);
            splQLDX_TT_TK.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLDX_TT_TK).EndInit();
            splQLDX_TT_TK.ResumeLayout(false);
            grbQLDX_TT.ResumeLayout(false);
            grbQLDX_TT.PerformLayout();
            grbQLDX_TK.ResumeLayout(false);
            grbQLDX_TK.PerformLayout();
            splQLDX_CN_HT.Panel1.ResumeLayout(false);
            splQLDX_CN_HT.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLDX_CN_HT).EndInit();
            splQLDX_CN_HT.ResumeLayout(false);
            grbQLDX_CN.ResumeLayout(false);
            grbQLDX_HT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLDX).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpQLDX;
        private Panel pnQLDX;
        private Label lbQLDX;
        private SplitContainer splQLDX_TT_TK;
        private GroupBox grbQLDX_TT;
        private DateTimePicker dtpQLDX_NgayXuat;
        private TextBox txtQLDX_TenDX;
        private TextBox txtQLDX_MaDX;
        private Label lbQLDX_NgayXuat;
        private Label lbQLDX_TenDX;
        private Label lbQLDX_MaNV;
        private Label lbQLDX_MaDX;
        private GroupBox grbQLDX_TK;
        private SplitContainer splQLDX_CN_HT;
        private GroupBox grbQLDX_CN;
        private GroupBox grbQLDX_HT;
        private DataGridView dgvQLDX;
        private Button btnQLDX_Them;
        private Button btnQLDX_Xoa;
        private Button btnQLDX_Sua;
        private Label label2;
        private Label label1;
        private ComboBox cbQLDX_MaNV;
        private ComboBox cbQLDX_TK_MaDX;
        private ComboBox cbQLDX_TK_MaNV;
        private DataGridViewTextBoxColumn DXuat_ID;
        private DataGridViewTextBoxColumn NV_ID;
        private DataGridViewTextBoxColumn DX_Name;
        private DataGridViewTextBoxColumn DX_Datetime;
        private LinkLabel linkQLDX;
    }
}
