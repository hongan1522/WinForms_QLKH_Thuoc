namespace FormQLKH
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tlpQLK = new TableLayoutPanel();
            pnQLK = new Panel();
            lbQLK = new Label();
            splQLK_HT_CN = new SplitContainer();
            grbQLK_HT = new GroupBox();
            dgvQLK = new DataGridView();
            MaKho = new DataGridViewTextBoxColumn();
            MaCN = new DataGridViewTextBoxColumn();
            TenKho = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            grbQLK_CN = new GroupBox();
            btnQLK_Them = new Button();
            btnQLK_Sua = new Button();
            btnQLK_Xoa = new Button();
            btnQLK_Import = new Button();
            btnQLK_Export = new Button();
            splQLK_TK_TT = new SplitContainer();
            grbQLK_TK = new GroupBox();
            cbQLK_TK_MaKho = new ComboBox();
            cbQLK_TK_MaCN = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            grbQLK_TT = new GroupBox();
            cbQLK_MaCN = new ComboBox();
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
            tlpQLK.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tlpQLK.RowStyles.Add(new RowStyle(SizeType.Absolute, 707F));
            tlpQLK.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tlpQLK.Size = new Size(1448, 1082);
            tlpQLK.TabIndex = 0;
            // 
            // pnQLK
            // 
            pnQLK.BackColor = Color.FromArgb(15, 142, 219);
            pnQLK.Controls.Add(lbQLK);
            pnQLK.Dock = DockStyle.Fill;
            pnQLK.Location = new Point(3, 3);
            pnQLK.Name = "pnQLK";
            pnQLK.Size = new Size(1442, 73);
            pnQLK.TabIndex = 0;
            // 
            // lbQLK
            // 
            lbQLK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            splQLK_HT_CN.BackColor = Color.Transparent;
            splQLK_HT_CN.BackgroundImage = Properties.Resources.bg;
            splQLK_HT_CN.Dock = DockStyle.Fill;
            splQLK_HT_CN.Location = new Point(3, 82);
            splQLK_HT_CN.Name = "splQLK_HT_CN";
            // 
            // splQLK_HT_CN.Panel1
            // 
            splQLK_HT_CN.Panel1.Controls.Add(grbQLK_HT);
            // 
            // splQLK_HT_CN.Panel2
            // 
            splQLK_HT_CN.Panel2.Controls.Add(grbQLK_CN);
            splQLK_HT_CN.Size = new Size(1442, 701);
            splQLK_HT_CN.SplitterDistance = 1197;
            splQLK_HT_CN.TabIndex = 1;
            // 
            // grbQLK_HT
            // 
            grbQLK_HT.Controls.Add(dgvQLK);
            grbQLK_HT.Dock = DockStyle.Fill;
            grbQLK_HT.Location = new Point(0, 0);
            grbQLK_HT.Name = "grbQLK_HT";
            grbQLK_HT.Size = new Size(1197, 701);
            grbQLK_HT.TabIndex = 0;
            grbQLK_HT.TabStop = false;
            grbQLK_HT.Text = "Hiển thị";
            // 
            // dgvQLK
            // 
            dgvQLK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLK.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgvQLK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvQLK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLK.Columns.AddRange(new DataGridViewColumn[] { MaKho, MaCN, TenKho, DiaChi });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvQLK.DefaultCellStyle = dataGridViewCellStyle6;
            dgvQLK.Dock = DockStyle.Fill;
            dgvQLK.Location = new Point(3, 39);
            dgvQLK.Name = "dgvQLK";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvQLK.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvQLK.RowHeadersWidth = 82;
            dgvQLK.RowTemplate.Height = 41;
            dgvQLK.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQLK.Size = new Size(1191, 659);
            dgvQLK.TabIndex = 0;
            dgvQLK.RowPostPaint += dgvQLK_RowPostPaint;
            dgvQLK.SelectionChanged += dgvQLK_SelectionChanged;
            // 
            // MaKho
            // 
            MaKho.DataPropertyName = "Kho_ID";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MaKho.DefaultCellStyle = dataGridViewCellStyle2;
            MaKho.HeaderText = "Mã kho";
            MaKho.MinimumWidth = 10;
            MaKho.Name = "MaKho";
            // 
            // MaCN
            // 
            MaCN.DataPropertyName = "CN_ID";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MaCN.DefaultCellStyle = dataGridViewCellStyle3;
            MaCN.HeaderText = "Mã chi nhánh";
            MaCN.MinimumWidth = 10;
            MaCN.Name = "MaCN";
            // 
            // TenKho
            // 
            TenKho.DataPropertyName = "Kho_Name";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TenKho.DefaultCellStyle = dataGridViewCellStyle4;
            TenKho.HeaderText = "Tên kho";
            TenKho.MinimumWidth = 10;
            TenKho.Name = "TenKho";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "Kho_Address";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DiaChi.DefaultCellStyle = dataGridViewCellStyle5;
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 10;
            DiaChi.Name = "DiaChi";
            // 
            // grbQLK_CN
            // 
            grbQLK_CN.Controls.Add(btnQLK_Them);
            grbQLK_CN.Controls.Add(btnQLK_Sua);
            grbQLK_CN.Controls.Add(btnQLK_Xoa);
            grbQLK_CN.Controls.Add(btnQLK_Import);
            grbQLK_CN.Controls.Add(btnQLK_Export);
            grbQLK_CN.Dock = DockStyle.Fill;
            grbQLK_CN.Location = new Point(0, 0);
            grbQLK_CN.Name = "grbQLK_CN";
            grbQLK_CN.Size = new Size(241, 701);
            grbQLK_CN.TabIndex = 1;
            grbQLK_CN.TabStop = false;
            grbQLK_CN.Text = "Chức năng";
            // 
            // btnQLK_Them
            // 
            btnQLK_Them.BackColor = SystemColors.ButtonHighlight;
            btnQLK_Them.FlatAppearance.BorderSize = 0;
            btnQLK_Them.FlatStyle = FlatStyle.Popup;
            btnQLK_Them.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLK_Them.Image = Properties.Resources.add;
            btnQLK_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLK_Them.Location = new Point(26, 52);
            btnQLK_Them.Name = "btnQLK_Them";
            btnQLK_Them.Size = new Size(182, 58);
            btnQLK_Them.TabIndex = 18;
            btnQLK_Them.Text = "Thêm";
            btnQLK_Them.UseVisualStyleBackColor = false;
            btnQLK_Them.Click += btnQLK_Them_Click;
            // 
            // btnQLK_Sua
            // 
            btnQLK_Sua.BackColor = SystemColors.ButtonHighlight;
            btnQLK_Sua.FlatAppearance.BorderSize = 0;
            btnQLK_Sua.FlatStyle = FlatStyle.Popup;
            btnQLK_Sua.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLK_Sua.Image = Properties.Resources.update;
            btnQLK_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLK_Sua.Location = new Point(26, 189);
            btnQLK_Sua.Name = "btnQLK_Sua";
            btnQLK_Sua.Size = new Size(182, 58);
            btnQLK_Sua.TabIndex = 19;
            btnQLK_Sua.Text = "Sửa";
            btnQLK_Sua.UseVisualStyleBackColor = false;
            btnQLK_Sua.Click += btnQLK_Sua_Click;
            // 
            // btnQLK_Xoa
            // 
            btnQLK_Xoa.BackColor = SystemColors.ButtonHighlight;
            btnQLK_Xoa.FlatAppearance.BorderSize = 0;
            btnQLK_Xoa.FlatStyle = FlatStyle.Popup;
            btnQLK_Xoa.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLK_Xoa.Image = Properties.Resources.delete;
            btnQLK_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLK_Xoa.Location = new Point(26, 326);
            btnQLK_Xoa.Name = "btnQLK_Xoa";
            btnQLK_Xoa.Size = new Size(182, 58);
            btnQLK_Xoa.TabIndex = 20;
            btnQLK_Xoa.Text = "Xóa";
            btnQLK_Xoa.UseVisualStyleBackColor = false;
            btnQLK_Xoa.Click += btnQLK_Xoa_Click;
            // 
            // btnQLK_Import
            // 
            btnQLK_Import.BackColor = SystemColors.ButtonHighlight;
            btnQLK_Import.FlatAppearance.BorderSize = 0;
            btnQLK_Import.FlatStyle = FlatStyle.Popup;
            btnQLK_Import.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLK_Import.Image = Properties.Resources.import;
            btnQLK_Import.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLK_Import.Location = new Point(26, 463);
            btnQLK_Import.Name = "btnQLK_Import";
            btnQLK_Import.Size = new Size(182, 58);
            btnQLK_Import.TabIndex = 21;
            btnQLK_Import.Text = "Import";
            btnQLK_Import.UseVisualStyleBackColor = false;
            // 
            // btnQLK_Export
            // 
            btnQLK_Export.BackColor = SystemColors.ButtonHighlight;
            btnQLK_Export.FlatAppearance.BorderSize = 0;
            btnQLK_Export.FlatStyle = FlatStyle.Popup;
            btnQLK_Export.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLK_Export.Image = Properties.Resources.export;
            btnQLK_Export.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLK_Export.Location = new Point(26, 600);
            btnQLK_Export.Name = "btnQLK_Export";
            btnQLK_Export.Size = new Size(182, 58);
            btnQLK_Export.TabIndex = 22;
            btnQLK_Export.Text = "Export";
            btnQLK_Export.UseVisualStyleBackColor = false;
            // 
            // splQLK_TK_TT
            // 
            splQLK_TK_TT.BackgroundImage = Properties.Resources.bg;
            splQLK_TK_TT.Dock = DockStyle.Bottom;
            splQLK_TK_TT.Location = new Point(3, 789);
            splQLK_TK_TT.Name = "splQLK_TK_TT";
            // 
            // splQLK_TK_TT.Panel1
            // 
            splQLK_TK_TT.Panel1.BackColor = Color.Transparent;
            splQLK_TK_TT.Panel1.Controls.Add(grbQLK_TK);
            // 
            // splQLK_TK_TT.Panel2
            // 
            splQLK_TK_TT.Panel2.BackColor = Color.Transparent;
            splQLK_TK_TT.Panel2.Controls.Add(grbQLK_TT);
            splQLK_TK_TT.Size = new Size(1442, 290);
            splQLK_TK_TT.SplitterDistance = 544;
            splQLK_TK_TT.TabIndex = 2;
            // 
            // grbQLK_TK
            // 
            grbQLK_TK.Controls.Add(cbQLK_TK_MaKho);
            grbQLK_TK.Controls.Add(cbQLK_TK_MaCN);
            grbQLK_TK.Controls.Add(label2);
            grbQLK_TK.Controls.Add(label1);
            grbQLK_TK.Dock = DockStyle.Fill;
            grbQLK_TK.Location = new Point(0, 0);
            grbQLK_TK.Name = "grbQLK_TK";
            grbQLK_TK.Size = new Size(544, 290);
            grbQLK_TK.TabIndex = 0;
            grbQLK_TK.TabStop = false;
            grbQLK_TK.Text = "Tìm kiếm";
            // 
            // cbQLK_TK_MaKho
            // 
            cbQLK_TK_MaKho.FormattingEnabled = true;
            cbQLK_TK_MaKho.Location = new Point(227, 68);
            cbQLK_TK_MaKho.Name = "cbQLK_TK_MaKho";
            cbQLK_TK_MaKho.Size = new Size(265, 45);
            cbQLK_TK_MaKho.TabIndex = 12;
            cbQLK_TK_MaKho.SelectedIndexChanged += cbQLK_TK_MaKho_SelectedIndexChanged;
            // 
            // cbQLK_TK_MaCN
            // 
            cbQLK_TK_MaCN.FormattingEnabled = true;
            cbQLK_TK_MaCN.Location = new Point(227, 183);
            cbQLK_TK_MaCN.Name = "cbQLK_TK_MaCN";
            cbQLK_TK_MaCN.Size = new Size(265, 45);
            cbQLK_TK_MaCN.TabIndex = 11;
            cbQLK_TK_MaCN.SelectedIndexChanged += cbQLK_TK_MaCN_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 186);
            label2.Name = "label2";
            label2.Size = new Size(186, 39);
            label2.TabIndex = 9;
            label2.Text = "Mã chi nhánh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 74);
            label1.Name = "label1";
            label1.Size = new Size(111, 39);
            label1.TabIndex = 4;
            label1.Text = "Mã kho";
            // 
            // grbQLK_TT
            // 
            grbQLK_TT.Controls.Add(cbQLK_MaCN);
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
            grbQLK_TT.Size = new Size(894, 290);
            grbQLK_TT.TabIndex = 0;
            grbQLK_TT.TabStop = false;
            grbQLK_TT.Text = "Thông tin";
            // 
            // cbQLK_MaCN
            // 
            cbQLK_MaCN.FormattingEnabled = true;
            cbQLK_MaCN.Location = new Point(217, 177);
            cbQLK_MaCN.Name = "cbQLK_MaCN";
            cbQLK_MaCN.Size = new Size(213, 45);
            cbQLK_MaCN.TabIndex = 10;
            // 
            // lbQLK_MaCN
            // 
            lbQLK_MaCN.AutoSize = true;
            lbQLK_MaCN.BackColor = SystemColors.Control;
            lbQLK_MaCN.BorderStyle = BorderStyle.Fixed3D;
            lbQLK_MaCN.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLK_MaCN.Location = new Point(18, 180);
            lbQLK_MaCN.Name = "lbQLK_MaCN";
            lbQLK_MaCN.Size = new Size(186, 39);
            lbQLK_MaCN.TabIndex = 8;
            lbQLK_MaCN.Text = "Mã chi nhánh";
            // 
            // txtQLK_DiaChi
            // 
            txtQLK_DiaChi.Location = new Point(578, 174);
            txtQLK_DiaChi.Multiline = true;
            txtQLK_DiaChi.Name = "txtQLK_DiaChi";
            txtQLK_DiaChi.Size = new Size(261, 92);
            txtQLK_DiaChi.TabIndex = 7;
            // 
            // lbQLK_DiaChi
            // 
            lbQLK_DiaChi.AutoSize = true;
            lbQLK_DiaChi.BackColor = SystemColors.Control;
            lbQLK_DiaChi.BorderStyle = BorderStyle.Fixed3D;
            lbQLK_DiaChi.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLK_DiaChi.Location = new Point(455, 180);
            lbQLK_DiaChi.Name = "lbQLK_DiaChi";
            lbQLK_DiaChi.Size = new Size(102, 39);
            lbQLK_DiaChi.TabIndex = 6;
            lbQLK_DiaChi.Text = "Địa chỉ";
            // 
            // txtQLK_TenKho
            // 
            txtQLK_TenKho.Location = new Point(578, 76);
            txtQLK_TenKho.Multiline = true;
            txtQLK_TenKho.Name = "txtQLK_TenKho";
            txtQLK_TenKho.Size = new Size(261, 48);
            txtQLK_TenKho.TabIndex = 5;
            // 
            // lbQLK_TenKho
            // 
            lbQLK_TenKho.AutoSize = true;
            lbQLK_TenKho.BackColor = SystemColors.Control;
            lbQLK_TenKho.BorderStyle = BorderStyle.Fixed3D;
            lbQLK_TenKho.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLK_TenKho.Location = new Point(455, 79);
            lbQLK_TenKho.Name = "lbQLK_TenKho";
            lbQLK_TenKho.Size = new Size(114, 39);
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
            lbQLK_MaKho.BackColor = SystemColors.Control;
            lbQLK_MaKho.BorderStyle = BorderStyle.Fixed3D;
            lbQLK_MaKho.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLK_MaKho.Location = new Point(18, 76);
            lbQLK_MaKho.Name = "lbQLK_MaKho";
            lbQLK_MaKho.Size = new Size(111, 39);
            lbQLK_MaKho.TabIndex = 0;
            lbQLK_MaKho.Text = "Mã kho";
            // 
            // UC_QLKho
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpQLK);
            Name = "UC_QLKho";
            Size = new Size(1448, 1082);
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
        private SplitContainer splQLK_TK_TT;
        private GroupBox grbQLK_TK;
        private GroupBox grbQLK_TT;
        private Label lbQLK_MaCN;
        private TextBox txtQLK_DiaChi;
        private Label lbQLK_DiaChi;
        private TextBox txtQLK_TenKho;
        private Label lbQLK_TenKho;
        private TextBox txtQLK_MaKho;
        private Label lbQLK_MaKho;
        private Button btnQLK_Them;
        private Button btnQLK_Sua;
        private Button btnQLK_Xoa;
        private Button btnQLK_Import;
        private Button btnQLK_Export;
        private Label label2;
        private Label label1;
        private ComboBox cbQLK_MaCN;
        private ComboBox cbQLK_TK_MaCN;
        private DataGridViewTextBoxColumn MaKho;
        private DataGridViewTextBoxColumn MaCN;
        private DataGridViewTextBoxColumn TenKho;
        private DataGridViewTextBoxColumn DiaChi;
        private ComboBox cbQLK_TK_MaKho;
    }
}
