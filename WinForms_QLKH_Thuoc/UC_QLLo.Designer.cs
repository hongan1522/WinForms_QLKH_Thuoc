namespace FormQLKH
{
    partial class UC_QLLo
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
            tlpQLLo = new TableLayoutPanel();
            pnQLLo = new Panel();
            lbQLLo = new Label();
            splQLLo_HT_CN = new SplitContainer();
            gpbQLLo_HT = new GroupBox();
            dgvQLLo = new DataGridView();
            MaLo = new DataGridViewTextBoxColumn();
            MaKho = new DataGridViewTextBoxColumn();
            TenLo = new DataGridViewTextBoxColumn();
            ViTri = new DataGridViewTextBoxColumn();
            gpbQLLo_CN = new GroupBox();
            btnQLLo_Them = new Button();
            btnQLLo_Export = new Button();
            btnQLLo_Sua = new Button();
            btnQLLo_Import = new Button();
            btnQLLo_Xoa = new Button();
            splQLLo_TT_TK = new SplitContainer();
            gpbQLLo_TT = new GroupBox();
            cbQLLo_MaKho = new ComboBox();
            cbQLLo_ViTri = new ComboBox();
            lbQLLo_ViTri = new Label();
            txtQLLo_TenLo = new TextBox();
            lbQLLo_TenLo = new Label();
            lbQLLo_MaKho = new Label();
            txtQLLo_MaLo = new TextBox();
            lbQLLo_MaLo = new Label();
            gpbQLLo_TK = new GroupBox();
            cbQLLo_TK_MaLo = new ComboBox();
            cbQLLo_TK_MaKho = new ComboBox();
            lbQLLo_TK_MaKho = new Label();
            lbQLLo_TK_MaLo = new Label();
            tlpQLLo.SuspendLayout();
            pnQLLo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splQLLo_HT_CN).BeginInit();
            splQLLo_HT_CN.Panel1.SuspendLayout();
            splQLLo_HT_CN.Panel2.SuspendLayout();
            splQLLo_HT_CN.SuspendLayout();
            gpbQLLo_HT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLLo).BeginInit();
            gpbQLLo_CN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splQLLo_TT_TK).BeginInit();
            splQLLo_TT_TK.Panel1.SuspendLayout();
            splQLLo_TT_TK.Panel2.SuspendLayout();
            splQLLo_TT_TK.SuspendLayout();
            gpbQLLo_TT.SuspendLayout();
            gpbQLLo_TK.SuspendLayout();
            SuspendLayout();
            // 
            // tlpQLLo
            // 
            tlpQLLo.BackColor = SystemColors.Control;
            tlpQLLo.ColumnCount = 1;
            tlpQLLo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpQLLo.Controls.Add(pnQLLo, 0, 0);
            tlpQLLo.Controls.Add(splQLLo_HT_CN, 0, 1);
            tlpQLLo.Controls.Add(splQLLo_TT_TK, 0, 2);
            tlpQLLo.Dock = DockStyle.Fill;
            tlpQLLo.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            tlpQLLo.Location = new Point(0, 0);
            tlpQLLo.Name = "tlpQLLo";
            tlpQLLo.RowCount = 3;
            tlpQLLo.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tlpQLLo.RowStyles.Add(new RowStyle(SizeType.Absolute, 727F));
            tlpQLLo.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tlpQLLo.Size = new Size(1448, 1082);
            tlpQLLo.TabIndex = 2;
            // 
            // pnQLLo
            // 
            pnQLLo.BackColor = Color.FromArgb(15, 142, 219);
            pnQLLo.Controls.Add(lbQLLo);
            pnQLLo.Dock = DockStyle.Fill;
            pnQLLo.Location = new Point(3, 3);
            pnQLLo.Name = "pnQLLo";
            pnQLLo.Size = new Size(1442, 78);
            pnQLLo.TabIndex = 0;
            // 
            // lbQLLo
            // 
            lbQLLo.AutoSize = true;
            lbQLLo.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLLo.ForeColor = SystemColors.ButtonHighlight;
            lbQLLo.Location = new Point(590, 13);
            lbQLLo.Name = "lbQLLo";
            lbQLLo.Size = new Size(237, 50);
            lbQLLo.TabIndex = 0;
            lbQLLo.Text = "QUẢN LÝ LÔ";
            // 
            // splQLLo_HT_CN
            // 
            splQLLo_HT_CN.BackColor = Color.Transparent;
            splQLLo_HT_CN.BackgroundImage = Properties.Resources.bg;
            splQLLo_HT_CN.Dock = DockStyle.Fill;
            splQLLo_HT_CN.Location = new Point(3, 87);
            splQLLo_HT_CN.Name = "splQLLo_HT_CN";
            // 
            // splQLLo_HT_CN.Panel1
            // 
            splQLLo_HT_CN.Panel1.Controls.Add(gpbQLLo_HT);
            // 
            // splQLLo_HT_CN.Panel2
            // 
            splQLLo_HT_CN.Panel2.Controls.Add(gpbQLLo_CN);
            splQLLo_HT_CN.Size = new Size(1442, 721);
            splQLLo_HT_CN.SplitterDistance = 1190;
            splQLLo_HT_CN.TabIndex = 1;
            // 
            // gpbQLLo_HT
            // 
            gpbQLLo_HT.Controls.Add(dgvQLLo);
            gpbQLLo_HT.Dock = DockStyle.Fill;
            gpbQLLo_HT.Location = new Point(0, 0);
            gpbQLLo_HT.Name = "gpbQLLo_HT";
            gpbQLLo_HT.Size = new Size(1190, 721);
            gpbQLLo_HT.TabIndex = 0;
            gpbQLLo_HT.TabStop = false;
            gpbQLLo_HT.Text = "Hiển thị";
            // 
            // dgvQLLo
            // 
            dgvQLLo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLLo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvQLLo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvQLLo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLLo.Columns.AddRange(new DataGridViewColumn[] { MaLo, MaKho, TenLo, ViTri });
            dgvQLLo.Dock = DockStyle.Fill;
            dgvQLLo.Location = new Point(3, 39);
            dgvQLLo.Name = "dgvQLLo";
            dgvQLLo.RowHeadersWidth = 82;
            dgvQLLo.RowTemplate.Height = 41;
            dgvQLLo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQLLo.Size = new Size(1184, 679);
            dgvQLLo.TabIndex = 0;
            dgvQLLo.RowPostPaint += dgvQLLo_RowPostPaint;
            dgvQLLo.SelectionChanged += dgvQLLo_SelectionChanged;
            // 
            // MaLo
            // 
            MaLo.DataPropertyName = "Lo_ID";
            MaLo.HeaderText = "Mã lô";
            MaLo.MinimumWidth = 10;
            MaLo.Name = "MaLo";
            // 
            // MaKho
            // 
            MaKho.DataPropertyName = "Kho_ID";
            MaKho.HeaderText = "Mã kho";
            MaKho.MinimumWidth = 10;
            MaKho.Name = "MaKho";
            // 
            // TenLo
            // 
            TenLo.DataPropertyName = "Lo_Name";
            TenLo.HeaderText = "Tên lô";
            TenLo.MinimumWidth = 10;
            TenLo.Name = "TenLo";
            // 
            // ViTri
            // 
            ViTri.DataPropertyName = "Lo_Position";
            ViTri.HeaderText = "Vị trí ";
            ViTri.MinimumWidth = 10;
            ViTri.Name = "ViTri";
            // 
            // gpbQLLo_CN
            // 
            gpbQLLo_CN.Controls.Add(btnQLLo_Them);
            gpbQLLo_CN.Controls.Add(btnQLLo_Export);
            gpbQLLo_CN.Controls.Add(btnQLLo_Sua);
            gpbQLLo_CN.Controls.Add(btnQLLo_Import);
            gpbQLLo_CN.Controls.Add(btnQLLo_Xoa);
            gpbQLLo_CN.Dock = DockStyle.Fill;
            gpbQLLo_CN.Location = new Point(0, 0);
            gpbQLLo_CN.Name = "gpbQLLo_CN";
            gpbQLLo_CN.Size = new Size(248, 721);
            gpbQLLo_CN.TabIndex = 1;
            gpbQLLo_CN.TabStop = false;
            gpbQLLo_CN.Text = "Chức năng";
            // 
            // btnQLLo_Them
            // 
            btnQLLo_Them.BackColor = SystemColors.ButtonHighlight;
            btnQLLo_Them.FlatAppearance.BorderSize = 0;
            btnQLLo_Them.FlatStyle = FlatStyle.Popup;
            btnQLLo_Them.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLLo_Them.Image = Properties.Resources.add;
            btnQLLo_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLLo_Them.Location = new Point(34, 62);
            btnQLLo_Them.Name = "btnQLLo_Them";
            btnQLLo_Them.Size = new Size(182, 58);
            btnQLLo_Them.TabIndex = 24;
            btnQLLo_Them.Text = "Thêm";
            btnQLLo_Them.UseVisualStyleBackColor = false;
            btnQLLo_Them.Click += btnQLLo_Them_Click;
            // 
            // btnQLLo_Export
            // 
            btnQLLo_Export.BackColor = SystemColors.ButtonHighlight;
            btnQLLo_Export.FlatAppearance.BorderSize = 0;
            btnQLLo_Export.FlatStyle = FlatStyle.Popup;
            btnQLLo_Export.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLLo_Export.Image = Properties.Resources.export;
            btnQLLo_Export.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLLo_Export.Location = new Point(34, 614);
            btnQLLo_Export.Name = "btnQLLo_Export";
            btnQLLo_Export.Size = new Size(182, 58);
            btnQLLo_Export.TabIndex = 28;
            btnQLLo_Export.Text = "Export";
            btnQLLo_Export.UseVisualStyleBackColor = false;
            // 
            // btnQLLo_Sua
            // 
            btnQLLo_Sua.BackColor = SystemColors.ButtonHighlight;
            btnQLLo_Sua.FlatAppearance.BorderSize = 0;
            btnQLLo_Sua.FlatStyle = FlatStyle.Popup;
            btnQLLo_Sua.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLLo_Sua.Image = Properties.Resources.update;
            btnQLLo_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLLo_Sua.Location = new Point(34, 200);
            btnQLLo_Sua.Name = "btnQLLo_Sua";
            btnQLLo_Sua.Size = new Size(182, 58);
            btnQLLo_Sua.TabIndex = 25;
            btnQLLo_Sua.Text = "Sửa";
            btnQLLo_Sua.UseVisualStyleBackColor = false;
            btnQLLo_Sua.Click += btnQLLo_Sua_Click;
            // 
            // btnQLLo_Import
            // 
            btnQLLo_Import.BackColor = SystemColors.ButtonHighlight;
            btnQLLo_Import.FlatAppearance.BorderSize = 0;
            btnQLLo_Import.FlatStyle = FlatStyle.Popup;
            btnQLLo_Import.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLLo_Import.Image = Properties.Resources.import;
            btnQLLo_Import.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLLo_Import.Location = new Point(34, 476);
            btnQLLo_Import.Name = "btnQLLo_Import";
            btnQLLo_Import.Size = new Size(182, 58);
            btnQLLo_Import.TabIndex = 27;
            btnQLLo_Import.Text = "Import";
            btnQLLo_Import.UseVisualStyleBackColor = false;
            // 
            // btnQLLo_Xoa
            // 
            btnQLLo_Xoa.BackColor = SystemColors.ButtonHighlight;
            btnQLLo_Xoa.FlatAppearance.BorderSize = 0;
            btnQLLo_Xoa.FlatStyle = FlatStyle.Popup;
            btnQLLo_Xoa.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLLo_Xoa.Image = Properties.Resources.delete;
            btnQLLo_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLLo_Xoa.Location = new Point(34, 338);
            btnQLLo_Xoa.Name = "btnQLLo_Xoa";
            btnQLLo_Xoa.Size = new Size(182, 58);
            btnQLLo_Xoa.TabIndex = 26;
            btnQLLo_Xoa.Text = "Xóa";
            btnQLLo_Xoa.UseVisualStyleBackColor = false;
            btnQLLo_Xoa.Click += btnQLLo_Xoa_Click;
            // 
            // splQLLo_TT_TK
            // 
            splQLLo_TT_TK.BackColor = Color.Transparent;
            splQLLo_TT_TK.BackgroundImage = Properties.Resources.bg;
            splQLLo_TT_TK.Dock = DockStyle.Bottom;
            splQLLo_TT_TK.Location = new Point(3, 821);
            splQLLo_TT_TK.Name = "splQLLo_TT_TK";
            // 
            // splQLLo_TT_TK.Panel1
            // 
            splQLLo_TT_TK.Panel1.BackColor = Color.Transparent;
            splQLLo_TT_TK.Panel1.Controls.Add(gpbQLLo_TT);
            // 
            // splQLLo_TT_TK.Panel2
            // 
            splQLLo_TT_TK.Panel2.BackColor = Color.Transparent;
            splQLLo_TT_TK.Panel2.Controls.Add(gpbQLLo_TK);
            splQLLo_TT_TK.Size = new Size(1442, 258);
            splQLLo_TT_TK.SplitterDistance = 877;
            splQLLo_TT_TK.TabIndex = 2;
            // 
            // gpbQLLo_TT
            // 
            gpbQLLo_TT.Controls.Add(cbQLLo_MaKho);
            gpbQLLo_TT.Controls.Add(cbQLLo_ViTri);
            gpbQLLo_TT.Controls.Add(lbQLLo_ViTri);
            gpbQLLo_TT.Controls.Add(txtQLLo_TenLo);
            gpbQLLo_TT.Controls.Add(lbQLLo_TenLo);
            gpbQLLo_TT.Controls.Add(lbQLLo_MaKho);
            gpbQLLo_TT.Controls.Add(txtQLLo_MaLo);
            gpbQLLo_TT.Controls.Add(lbQLLo_MaLo);
            gpbQLLo_TT.Dock = DockStyle.Fill;
            gpbQLLo_TT.Location = new Point(0, 0);
            gpbQLLo_TT.Name = "gpbQLLo_TT";
            gpbQLLo_TT.Size = new Size(877, 258);
            gpbQLLo_TT.TabIndex = 0;
            gpbQLLo_TT.TabStop = false;
            gpbQLLo_TT.Text = "Thông tin";
            // 
            // cbQLLo_MaKho
            // 
            cbQLLo_MaKho.FormattingEnabled = true;
            cbQLLo_MaKho.Location = new Point(147, 162);
            cbQLLo_MaKho.Name = "cbQLLo_MaKho";
            cbQLLo_MaKho.Size = new Size(200, 45);
            cbQLLo_MaKho.TabIndex = 8;
            // 
            // cbQLLo_ViTri
            // 
            cbQLLo_ViTri.FormattingEnabled = true;
            cbQLLo_ViTri.Location = new Point(555, 169);
            cbQLLo_ViTri.Name = "cbQLLo_ViTri";
            cbQLLo_ViTri.Size = new Size(177, 45);
            cbQLLo_ViTri.TabIndex = 7;
            // 
            // lbQLLo_ViTri
            // 
            lbQLLo_ViTri.AutoSize = true;
            lbQLLo_ViTri.BackColor = SystemColors.Control;
            lbQLLo_ViTri.BorderStyle = BorderStyle.Fixed3D;
            lbQLLo_ViTri.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLLo_ViTri.Location = new Point(435, 169);
            lbQLLo_ViTri.Name = "lbQLLo_ViTri";
            lbQLLo_ViTri.Size = new Size(77, 39);
            lbQLLo_ViTri.TabIndex = 6;
            lbQLLo_ViTri.Text = "Vị trí";
            // 
            // txtQLLo_TenLo
            // 
            txtQLLo_TenLo.Location = new Point(555, 52);
            txtQLLo_TenLo.Multiline = true;
            txtQLLo_TenLo.Name = "txtQLLo_TenLo";
            txtQLLo_TenLo.Size = new Size(257, 73);
            txtQLLo_TenLo.TabIndex = 5;
            // 
            // lbQLLo_TenLo
            // 
            lbQLLo_TenLo.AutoSize = true;
            lbQLLo_TenLo.BackColor = SystemColors.Control;
            lbQLLo_TenLo.BorderStyle = BorderStyle.Fixed3D;
            lbQLLo_TenLo.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLLo_TenLo.Location = new Point(435, 65);
            lbQLLo_TenLo.Name = "lbQLLo_TenLo";
            lbQLLo_TenLo.Size = new Size(91, 39);
            lbQLLo_TenLo.TabIndex = 4;
            lbQLLo_TenLo.Text = "Tên lô";
            // 
            // lbQLLo_MaKho
            // 
            lbQLLo_MaKho.AutoSize = true;
            lbQLLo_MaKho.BackColor = SystemColors.Control;
            lbQLLo_MaKho.BorderStyle = BorderStyle.Fixed3D;
            lbQLLo_MaKho.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLLo_MaKho.Location = new Point(20, 165);
            lbQLLo_MaKho.Name = "lbQLLo_MaKho";
            lbQLLo_MaKho.Size = new Size(111, 39);
            lbQLLo_MaKho.TabIndex = 2;
            lbQLLo_MaKho.Text = "Mã kho";
            // 
            // txtQLLo_MaLo
            // 
            txtQLLo_MaLo.Location = new Point(147, 59);
            txtQLLo_MaLo.Name = "txtQLLo_MaLo";
            txtQLLo_MaLo.Size = new Size(200, 43);
            txtQLLo_MaLo.TabIndex = 1;
            // 
            // lbQLLo_MaLo
            // 
            lbQLLo_MaLo.AutoSize = true;
            lbQLLo_MaLo.BackColor = SystemColors.Control;
            lbQLLo_MaLo.BorderStyle = BorderStyle.Fixed3D;
            lbQLLo_MaLo.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLLo_MaLo.Location = new Point(20, 59);
            lbQLLo_MaLo.Name = "lbQLLo_MaLo";
            lbQLLo_MaLo.Size = new Size(88, 39);
            lbQLLo_MaLo.TabIndex = 0;
            lbQLLo_MaLo.Text = "Mã lô";
            // 
            // gpbQLLo_TK
            // 
            gpbQLLo_TK.Controls.Add(cbQLLo_TK_MaLo);
            gpbQLLo_TK.Controls.Add(cbQLLo_TK_MaKho);
            gpbQLLo_TK.Controls.Add(lbQLLo_TK_MaKho);
            gpbQLLo_TK.Controls.Add(lbQLLo_TK_MaLo);
            gpbQLLo_TK.Dock = DockStyle.Fill;
            gpbQLLo_TK.Location = new Point(0, 0);
            gpbQLLo_TK.Name = "gpbQLLo_TK";
            gpbQLLo_TK.Size = new Size(561, 258);
            gpbQLLo_TK.TabIndex = 0;
            gpbQLLo_TK.TabStop = false;
            gpbQLLo_TK.Text = "Tìm kiếm";
            // 
            // cbQLLo_TK_MaLo
            // 
            cbQLLo_TK_MaLo.FormattingEnabled = true;
            cbQLLo_TK_MaLo.Location = new Point(204, 56);
            cbQLLo_TK_MaLo.Name = "cbQLLo_TK_MaLo";
            cbQLLo_TK_MaLo.Size = new Size(284, 45);
            cbQLLo_TK_MaLo.TabIndex = 10;
            cbQLLo_TK_MaLo.SelectedIndexChanged += cbQLLo_TK_MaLo_SelectedIndexChanged;
            // 
            // cbQLLo_TK_MaKho
            // 
            cbQLLo_TK_MaKho.FormattingEnabled = true;
            cbQLLo_TK_MaKho.Location = new Point(204, 166);
            cbQLLo_TK_MaKho.Name = "cbQLLo_TK_MaKho";
            cbQLLo_TK_MaKho.Size = new Size(284, 45);
            cbQLLo_TK_MaKho.TabIndex = 9;
            cbQLLo_TK_MaKho.SelectedIndexChanged += cbQLLo_TK_MaKho_SelectedIndexChanged;
            // 
            // lbQLLo_TK_MaKho
            // 
            lbQLLo_TK_MaKho.AutoSize = true;
            lbQLLo_TK_MaKho.BackColor = SystemColors.Control;
            lbQLLo_TK_MaKho.BorderStyle = BorderStyle.Fixed3D;
            lbQLLo_TK_MaKho.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLLo_TK_MaKho.Location = new Point(53, 169);
            lbQLLo_TK_MaKho.Name = "lbQLLo_TK_MaKho";
            lbQLLo_TK_MaKho.Size = new Size(111, 39);
            lbQLLo_TK_MaKho.TabIndex = 7;
            lbQLLo_TK_MaKho.Text = "Mã kho";
            // 
            // lbQLLo_TK_MaLo
            // 
            lbQLLo_TK_MaLo.AutoSize = true;
            lbQLLo_TK_MaLo.BackColor = SystemColors.Control;
            lbQLLo_TK_MaLo.BorderStyle = BorderStyle.Fixed3D;
            lbQLLo_TK_MaLo.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLLo_TK_MaLo.Location = new Point(53, 59);
            lbQLLo_TK_MaLo.Name = "lbQLLo_TK_MaLo";
            lbQLLo_TK_MaLo.Size = new Size(88, 39);
            lbQLLo_TK_MaLo.TabIndex = 6;
            lbQLLo_TK_MaLo.Text = "Mã lô";
            // 
            // UC_QLLo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpQLLo);
            Name = "UC_QLLo";
            Size = new Size(1448, 1082);
            tlpQLLo.ResumeLayout(false);
            pnQLLo.ResumeLayout(false);
            pnQLLo.PerformLayout();
            splQLLo_HT_CN.Panel1.ResumeLayout(false);
            splQLLo_HT_CN.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLLo_HT_CN).EndInit();
            splQLLo_HT_CN.ResumeLayout(false);
            gpbQLLo_HT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLLo).EndInit();
            gpbQLLo_CN.ResumeLayout(false);
            splQLLo_TT_TK.Panel1.ResumeLayout(false);
            splQLLo_TT_TK.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLLo_TT_TK).EndInit();
            splQLLo_TT_TK.ResumeLayout(false);
            gpbQLLo_TT.ResumeLayout(false);
            gpbQLLo_TT.PerformLayout();
            gpbQLLo_TK.ResumeLayout(false);
            gpbQLLo_TK.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpQLLo;
        private Panel pnQLLo;
        private Label lbQLLo;
        private SplitContainer splQLLo_HT_CN;
        private GroupBox gpbQLLo_HT;
        private DataGridView dgvQLLo;
        private GroupBox gpbQLLo_CN;
        private SplitContainer splQLLo_TT_TK;
        private GroupBox gpbQLLo_TT;
        private ComboBox cbQLLo_ViTri;
        private Label lbQLLo_ViTri;
        private TextBox txtQLLo_TenLo;
        private Label lbQLLo_TenLo;
        private Label lbQLLo_MaKho;
        private TextBox txtQLLo_MaLo;
        private Label lbQLLo_MaLo;
        private GroupBox gpbQLLo_TK;
        private Button btnQLLo_Them;
        private Button btnQLLo_Export;
        private Button btnQLLo_Sua;
        private Button btnQLLo_Import;
        private Button btnQLLo_Xoa;
        private Label lbQLLo_TK_MaKho;
        private Label lbQLLo_TK_MaLo;
        private ComboBox cbQLLo_MaKho;
        private DataGridViewTextBoxColumn MaLo;
        private DataGridViewTextBoxColumn MaKho;
        private DataGridViewTextBoxColumn TenLo;
        private DataGridViewTextBoxColumn ViTri;
        private ComboBox cbQLLo_TK_MaKho;
        private ComboBox cbQLLo_TK_MaLo;
    }
}
