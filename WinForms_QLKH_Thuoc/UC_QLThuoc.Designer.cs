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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tlpQLT = new TableLayoutPanel();
            pnQLT = new Panel();
            lbQLT = new Label();
            splQLT_CN_HT = new SplitContainer();
            grbQLT_TK = new GroupBox();
            grbQLT_HT = new GroupBox();
            dgvQLT = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            pnQLT_TT_CN = new Panel();
            splQLT_TT_TK = new SplitContainer();
            grbQLT_TT = new GroupBox();
            txtQLT_TK_TenThuoc = new TextBox();
            txtQLT_TK_MaThuoc = new TextBox();
            txtQLT_TenThuoc = new TextBox();
            txtQLT_MaNhom = new TextBox();
            txtQLT_MaThuoc = new TextBox();
            lbQLT_MaNhom = new Label();
            lbQLT_TenThuoc = new Label();
            lbQLT_MaThuoc = new Label();
            grbQLT_CN = new GroupBox();
            btnQLT_Reload = new Button();
            btnQLT_Sua = new Button();
            btnQLT_Export = new Button();
            btnQLT_Them = new Button();
            btnQLT_Import = new Button();
            btnQLT_Xoa = new Button();
            lbQLT_TK_TenThuoc = new Label();
            lbQLT_TK_MaThuoc = new Label();
            tlpQLT.SuspendLayout();
            pnQLT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splQLT_CN_HT).BeginInit();
            splQLT_CN_HT.Panel1.SuspendLayout();
            splQLT_CN_HT.Panel2.SuspendLayout();
            splQLT_CN_HT.SuspendLayout();
            grbQLT_TK.SuspendLayout();
            grbQLT_HT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLT).BeginInit();
            pnQLT_TT_CN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splQLT_TT_TK).BeginInit();
            splQLT_TT_TK.Panel1.SuspendLayout();
            splQLT_TT_TK.Panel2.SuspendLayout();
            splQLT_TT_TK.SuspendLayout();
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
            tlpQLT.Controls.Add(splQLT_CN_HT, 0, 1);
            tlpQLT.Controls.Add(pnQLT_TT_CN, 0, 2);
            tlpQLT.Dock = DockStyle.Fill;
            tlpQLT.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            tlpQLT.Location = new Point(0, 0);
            tlpQLT.Name = "tlpQLT";
            tlpQLT.RowCount = 3;
            tlpQLT.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tlpQLT.RowStyles.Add(new RowStyle(SizeType.Absolute, 588F));
            tlpQLT.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tlpQLT.Size = new Size(1420, 1000);
            tlpQLT.TabIndex = 1;
            // 
            // pnQLT
            // 
            pnQLT.BackColor = Color.FromArgb(63, 139, 208);
            pnQLT.Controls.Add(lbQLT);
            pnQLT.Dock = DockStyle.Fill;
            pnQLT.Location = new Point(3, 3);
            pnQLT.Name = "pnQLT";
            pnQLT.Size = new Size(1414, 73);
            pnQLT.TabIndex = 0;
            // 
            // lbQLT
            // 
            lbQLT.AutoSize = true;
            lbQLT.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLT.ForeColor = SystemColors.ButtonHighlight;
            lbQLT.Location = new Point(582, 15);
            lbQLT.Name = "lbQLT";
            lbQLT.Size = new Size(319, 50);
            lbQLT.TabIndex = 0;
            lbQLT.Text = "QUẢN LÝ THUỐC";
            lbQLT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splQLT_CN_HT
            // 
            splQLT_CN_HT.Dock = DockStyle.Fill;
            splQLT_CN_HT.Location = new Point(3, 82);
            splQLT_CN_HT.Name = "splQLT_CN_HT";
            splQLT_CN_HT.Orientation = Orientation.Horizontal;
            // 
            // splQLT_CN_HT.Panel1
            // 
            splQLT_CN_HT.Panel1.Controls.Add(grbQLT_TK);
            // 
            // splQLT_CN_HT.Panel2
            // 
            splQLT_CN_HT.Panel2.Controls.Add(grbQLT_HT);
            splQLT_CN_HT.Size = new Size(1414, 582);
            splQLT_CN_HT.SplitterDistance = 118;
            splQLT_CN_HT.TabIndex = 1;
            // 
            // grbQLT_TK
            // 
            grbQLT_TK.Controls.Add(btnQLT_Reload);
            grbQLT_TK.Controls.Add(btnQLT_Them);
            grbQLT_TK.Controls.Add(btnQLT_Export);
            grbQLT_TK.Controls.Add(btnQLT_Sua);
            grbQLT_TK.Controls.Add(btnQLT_Import);
            grbQLT_TK.Controls.Add(btnQLT_Xoa);
            grbQLT_TK.Dock = DockStyle.Fill;
            grbQLT_TK.Location = new Point(0, 0);
            grbQLT_TK.Name = "grbQLT_TK";
            grbQLT_TK.Size = new Size(1414, 118);
            grbQLT_TK.TabIndex = 0;
            grbQLT_TK.TabStop = false;
            grbQLT_TK.Text = "Chức năng";
            // 
            // grbQLT_HT
            // 
            grbQLT_HT.Controls.Add(dgvQLT);
            grbQLT_HT.Dock = DockStyle.Fill;
            grbQLT_HT.Location = new Point(0, 0);
            grbQLT_HT.Name = "grbQLT_HT";
            grbQLT_HT.Size = new Size(1414, 460);
            grbQLT_HT.TabIndex = 0;
            grbQLT_HT.TabStop = false;
            grbQLT_HT.Text = "Hiển thị";
            // 
            // dgvQLT
            // 
            dgvQLT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLT.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvQLT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvQLT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLT.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column2 });
            dgvQLT.Dock = DockStyle.Fill;
            dgvQLT.Location = new Point(3, 39);
            dgvQLT.Name = "dgvQLT";
            dgvQLT.RowHeadersWidth = 82;
            dgvQLT.RowTemplate.Height = 41;
            dgvQLT.Size = new Size(1408, 418);
            dgvQLT.AutoGenerateColumns = false;
            dgvQLT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQLT.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã thuốc";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
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
            pnQLT_TT_CN.Controls.Add(splQLT_TT_TK);
            pnQLT_TT_CN.Location = new Point(3, 670);
            pnQLT_TT_CN.Name = "pnQLT_TT_CN";
            pnQLT_TT_CN.Size = new Size(1414, 325);
            pnQLT_TT_CN.TabIndex = 2;
            // 
            // splQLT_TT_TK
            // 
            splQLT_TT_TK.BackColor = Color.Transparent;
            splQLT_TT_TK.BackgroundImage = Properties.Resources.bg3;
            splQLT_TT_TK.Dock = DockStyle.Fill;
            splQLT_TT_TK.Location = new Point(0, 0);
            splQLT_TT_TK.Name = "splQLT_TT_TK";
            // 
            // splQLT_TT_TK.Panel1
            // 
            splQLT_TT_TK.Panel1.Controls.Add(grbQLT_TT);
            // 
            // splQLT_TT_TK.Panel2
            // 
            splQLT_TT_TK.Panel2.Controls.Add(grbQLT_CN);
            splQLT_TT_TK.Size = new Size(1414, 325);
            splQLT_TT_TK.SplitterDistance = 778;
            splQLT_TT_TK.TabIndex = 3;
            // 
            // grbQLT_TT
            // 
            grbQLT_TT.Controls.Add(txtQLT_TenThuoc);
            grbQLT_TT.Controls.Add(txtQLT_MaNhom);
            grbQLT_TT.Controls.Add(txtQLT_MaThuoc);
            grbQLT_TT.Controls.Add(lbQLT_MaNhom);
            grbQLT_TT.Controls.Add(lbQLT_TenThuoc);
            grbQLT_TT.Controls.Add(lbQLT_MaThuoc);
            grbQLT_TT.Dock = DockStyle.Fill;
            grbQLT_TT.Location = new Point(0, 0);
            grbQLT_TT.Name = "grbQLT_TT";
            grbQLT_TT.Size = new Size(778, 325);
            grbQLT_TT.TabIndex = 0;
            grbQLT_TT.TabStop = false;
            grbQLT_TT.Text = "Thông tin";
            // 
            // txtQLT_TK_TenThuoc
            // 
            txtQLT_TK_TenThuoc.Location = new Point(240, 184);
            txtQLT_TK_TenThuoc.Multiline = true;
            txtQLT_TK_TenThuoc.Name = "txtQLT_TK_TenThuoc";
            txtQLT_TK_TenThuoc.Size = new Size(324, 93);
            txtQLT_TK_TenThuoc.TabIndex = 3;
            // 
            // txtQLT_TK_MaThuoc
            // 
            txtQLT_TK_MaThuoc.Location = new Point(240, 69);
            txtQLT_TK_MaThuoc.Name = "txtQLT_TK_MaThuoc";
            txtQLT_TK_MaThuoc.Size = new Size(324, 43);
            txtQLT_TK_MaThuoc.TabIndex = 2;
            // 
            // txtQLT_TenThuoc
            // 
            txtQLT_TenThuoc.Location = new Point(261, 234);
            txtQLT_TenThuoc.Name = "txtQLT_TenThuoc";
            txtQLT_TenThuoc.Size = new Size(439, 43);
            txtQLT_TenThuoc.TabIndex = 7;
            // 
            // txtQLT_MaNhom
            // 
            txtQLT_MaNhom.Location = new Point(261, 148);
            txtQLT_MaNhom.Name = "txtQLT_MaNhom";
            txtQLT_MaNhom.Size = new Size(439, 43);
            txtQLT_MaNhom.TabIndex = 6;
            // 
            // txtQLT_MaThuoc
            // 
            txtQLT_MaThuoc.Location = new Point(261, 63);
            txtQLT_MaThuoc.Name = "txtQLT_MaThuoc";
            txtQLT_MaThuoc.Size = new Size(439, 43);
            txtQLT_MaThuoc.TabIndex = 4;
            // 
            // lbQLT_MaNhom
            // 
            lbQLT_MaNhom.AutoSize = true;
            lbQLT_MaNhom.BackColor = SystemColors.Control;
            lbQLT_MaNhom.BorderStyle = BorderStyle.Fixed3D;
            lbQLT_MaNhom.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLT_MaNhom.Location = new Point(35, 148);
            lbQLT_MaNhom.Name = "lbQLT_MaNhom";
            lbQLT_MaNhom.Size = new Size(215, 39);
            lbQLT_MaNhom.TabIndex = 2;
            lbQLT_MaNhom.Text = "Mã nhóm thuốc";
            // 
            // lbQLT_TenThuoc
            // 
            lbQLT_TenThuoc.AutoSize = true;
            lbQLT_TenThuoc.BackColor = SystemColors.Control;
            lbQLT_TenThuoc.BorderStyle = BorderStyle.Fixed3D;
            lbQLT_TenThuoc.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLT_TenThuoc.Location = new Point(35, 233);
            lbQLT_TenThuoc.Name = "lbQLT_TenThuoc";
            lbQLT_TenThuoc.Size = new Size(139, 39);
            lbQLT_TenThuoc.TabIndex = 1;
            lbQLT_TenThuoc.Text = "Tên thuốc";
            // 
            // lbQLT_MaThuoc
            // 
            lbQLT_MaThuoc.AutoSize = true;
            lbQLT_MaThuoc.BackColor = SystemColors.Control;
            lbQLT_MaThuoc.BorderStyle = BorderStyle.Fixed3D;
            lbQLT_MaThuoc.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLT_MaThuoc.Location = new Point(35, 68);
            lbQLT_MaThuoc.Name = "lbQLT_MaThuoc";
            lbQLT_MaThuoc.Size = new Size(136, 39);
            lbQLT_MaThuoc.TabIndex = 0;
            lbQLT_MaThuoc.Text = "Mã thuốc";
            // 
            // grbQLT_CN
            // 
            grbQLT_CN.Controls.Add(lbQLT_TK_TenThuoc);
            grbQLT_CN.Controls.Add(lbQLT_TK_MaThuoc);
            grbQLT_CN.Controls.Add(txtQLT_TK_TenThuoc);
            grbQLT_CN.Controls.Add(txtQLT_TK_MaThuoc);
            grbQLT_CN.Dock = DockStyle.Fill;
            grbQLT_CN.Location = new Point(0, 0);
            grbQLT_CN.Name = "grbQLT_CN";
            grbQLT_CN.Size = new Size(632, 325);
            grbQLT_CN.TabIndex = 0;
            grbQLT_CN.TabStop = false;
            grbQLT_CN.Text = "Tìm kiếm";
            // 
            // btnQLT_Reload
            // 
            btnQLT_Reload.BackColor = SystemColors.ButtonHighlight;
            btnQLT_Reload.FlatAppearance.BorderSize = 0;
            btnQLT_Reload.FlatStyle = FlatStyle.Flat;
            btnQLT_Reload.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLT_Reload.Image = Properties.Resources.reload;
            btnQLT_Reload.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLT_Reload.Location = new Point(1202, 42);
            btnQLT_Reload.Name = "btnQLT_Reload";
            btnQLT_Reload.Size = new Size(169, 64);
            btnQLT_Reload.TabIndex = 33;
            btnQLT_Reload.Text = "Reload";
            btnQLT_Reload.UseVisualStyleBackColor = false;
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
            btnQLT_Sua.Location = new Point(266, 42);
            btnQLT_Sua.Name = "btnQLT_Sua";
            btnQLT_Sua.Size = new Size(169, 64);
            btnQLT_Sua.TabIndex = 11;
            btnQLT_Sua.Text = "Sửa";
            btnQLT_Sua.UseVisualStyleBackColor = false;
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
            btnQLT_Export.Location = new Point(968, 42);
            btnQLT_Export.Name = "btnQLT_Export";
            btnQLT_Export.Size = new Size(169, 64);
            btnQLT_Export.TabIndex = 9;
            btnQLT_Export.Text = "Export";
            btnQLT_Export.UseVisualStyleBackColor = false;
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
            btnQLT_Them.Location = new Point(32, 42);
            btnQLT_Them.Name = "btnQLT_Them";
            btnQLT_Them.Size = new Size(169, 64);
            btnQLT_Them.TabIndex = 6;
            btnQLT_Them.Text = "Thêm";
            btnQLT_Them.UseVisualStyleBackColor = false;
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
            btnQLT_Import.Location = new Point(734, 42);
            btnQLT_Import.Name = "btnQLT_Import";
            btnQLT_Import.Size = new Size(169, 64);
            btnQLT_Import.TabIndex = 10;
            btnQLT_Import.Text = "Import";
            btnQLT_Import.UseVisualStyleBackColor = false;
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
            btnQLT_Xoa.Location = new Point(500, 42);
            btnQLT_Xoa.Name = "btnQLT_Xoa";
            btnQLT_Xoa.Size = new Size(169, 64);
            btnQLT_Xoa.TabIndex = 7;
            btnQLT_Xoa.Text = "Xóa";
            btnQLT_Xoa.UseVisualStyleBackColor = false;
            // 
            // lbQLT_TK_TenThuoc
            // 
            lbQLT_TK_TenThuoc.AutoSize = true;
            lbQLT_TK_TenThuoc.BackColor = SystemColors.Control;
            lbQLT_TK_TenThuoc.BorderStyle = BorderStyle.Fixed3D;
            lbQLT_TK_TenThuoc.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLT_TK_TenThuoc.Location = new Point(59, 184);
            lbQLT_TK_TenThuoc.Name = "lbQLT_TK_TenThuoc";
            lbQLT_TK_TenThuoc.Size = new Size(139, 39);
            lbQLT_TK_TenThuoc.TabIndex = 5;
            lbQLT_TK_TenThuoc.Text = "Tên thuốc";
            // 
            // lbQLT_TK_MaThuoc
            // 
            lbQLT_TK_MaThuoc.AutoSize = true;
            lbQLT_TK_MaThuoc.BackColor = SystemColors.Control;
            lbQLT_TK_MaThuoc.BorderStyle = BorderStyle.Fixed3D;
            lbQLT_TK_MaThuoc.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLT_TK_MaThuoc.Location = new Point(59, 69);
            lbQLT_TK_MaThuoc.Name = "lbQLT_TK_MaThuoc";
            lbQLT_TK_MaThuoc.Size = new Size(136, 39);
            lbQLT_TK_MaThuoc.TabIndex = 4;
            lbQLT_TK_MaThuoc.Text = "Mã thuốc";
            // 
            // UC_QLThuoc
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpQLT);
            Name = "UC_QLThuoc";
            Size = new Size(1420, 1000);
            tlpQLT.ResumeLayout(false);
            pnQLT.ResumeLayout(false);
            pnQLT.PerformLayout();
            splQLT_CN_HT.Panel1.ResumeLayout(false);
            splQLT_CN_HT.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLT_CN_HT).EndInit();
            splQLT_CN_HT.ResumeLayout(false);
            grbQLT_TK.ResumeLayout(false);
            grbQLT_HT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLT).EndInit();
            pnQLT_TT_CN.ResumeLayout(false);
            splQLT_TT_TK.Panel1.ResumeLayout(false);
            splQLT_TT_TK.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLT_TT_TK).EndInit();
            splQLT_TT_TK.ResumeLayout(false);
            grbQLT_TT.ResumeLayout(false);
            grbQLT_TT.PerformLayout();
            grbQLT_CN.ResumeLayout(false);
            grbQLT_CN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpQLT;
        private Panel pnQLT;
        private Label lbQLT;
        private SplitContainer splQLT_CN_HT;
        private GroupBox grbQLT_TK;
        private TextBox txtQLT_TK_TenThuoc;
        private TextBox txtQLT_TK_MaThuoc;
        private GroupBox grbQLT_HT;
        private DataGridView dgvQLT;
        private Panel pnQLT_TT_CN;
        private SplitContainer splQLT_TT_TK;
        private GroupBox grbQLT_TT;
        private TextBox txtQLT_TenThuoc;
        private TextBox txtQLT_MaNhom;
        private TextBox txtQLT_MaThuoc;
        private Label lbQLT_MaNhom;
        private Label lbQLT_TenThuoc;
        private Label lbQLT_MaThuoc;
        private GroupBox grbQLT_CN;
        private Button btnQLT_Sua;
        private Button btnQLT_Export;
        private Button btnQLT_Them;
        private Button btnQLT_Import;
        private Button btnQLT_Xoa;
        private Button btnQLT_Reload;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private Label lbQLT_TK_TenThuoc;
        private Label lbQLT_TK_MaThuoc;
    }
}
