namespace FormQLKH
{
    partial class UC_QLNhomThuoc
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
            tlpQLNT = new TableLayoutPanel();
            pnQLNT = new Panel();
            lbQLNT = new Label();
            splQLNT = new SplitContainer();
            splQLNT_TT_HT = new SplitContainer();
            grbQLNT_TK = new GroupBox();
            txtQLNT_GhiChu = new TextBox();
            lbQLNT_MaNhom = new Label();
            txtQLNT_MaNhom = new TextBox();
            txtQLNT_TenNhom = new TextBox();
            lbQLNT_GhiChu = new Label();
            lbQLNT_TenNhom = new Label();
            grbQLNT_HT = new GroupBox();
            dgvQLNT = new DataGridView();
            Nhom_ID = new DataGridViewTextBoxColumn();
            Nhom_Name = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            splQLNT_TK_CN = new SplitContainer();
            grbQLNT_TT = new GroupBox();
            cbQLNT_TK_MaNhom = new ComboBox();
            lbQLNT_TK_TenNhom = new Label();
            txtQLNT_TK_TenNhom = new TextBox();
            lbQLNT_TK_MaNhom = new Label();
            grbQLNT_CN = new GroupBox();
            btnQLNT_Sua = new Button();
            btnQLNT_Import = new Button();
            btnQLNT_Export = new Button();
            btnQLNT_Xoa = new Button();
            btnQLNT_Them = new Button();
            tlpQLNT.SuspendLayout();
            pnQLNT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splQLNT).BeginInit();
            splQLNT.Panel1.SuspendLayout();
            splQLNT.Panel2.SuspendLayout();
            splQLNT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splQLNT_TT_HT).BeginInit();
            splQLNT_TT_HT.Panel1.SuspendLayout();
            splQLNT_TT_HT.Panel2.SuspendLayout();
            splQLNT_TT_HT.SuspendLayout();
            grbQLNT_TK.SuspendLayout();
            grbQLNT_HT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLNT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splQLNT_TK_CN).BeginInit();
            splQLNT_TK_CN.Panel1.SuspendLayout();
            splQLNT_TK_CN.Panel2.SuspendLayout();
            splQLNT_TK_CN.SuspendLayout();
            grbQLNT_TT.SuspendLayout();
            grbQLNT_CN.SuspendLayout();
            SuspendLayout();
            // 
            // tlpQLNT
            // 
            tlpQLNT.BackColor = SystemColors.Control;
            tlpQLNT.ColumnCount = 1;
            tlpQLNT.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpQLNT.Controls.Add(pnQLNT, 0, 0);
            tlpQLNT.Controls.Add(splQLNT, 0, 1);
            tlpQLNT.Dock = DockStyle.Fill;
            tlpQLNT.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            tlpQLNT.Location = new Point(0, 0);
            tlpQLNT.Name = "tlpQLNT";
            tlpQLNT.RowCount = 2;
            tlpQLNT.RowStyles.Add(new RowStyle(SizeType.Percent, 8.133087F));
            tlpQLNT.RowStyles.Add(new RowStyle(SizeType.Percent, 91.86691F));
            tlpQLNT.Size = new Size(1448, 1082);
            tlpQLNT.TabIndex = 1;
            // 
            // pnQLNT
            // 
            pnQLNT.BackColor = Color.FromArgb(15, 142, 219);
            pnQLNT.Controls.Add(lbQLNT);
            pnQLNT.Dock = DockStyle.Fill;
            pnQLNT.Location = new Point(3, 3);
            pnQLNT.Name = "pnQLNT";
            pnQLNT.Size = new Size(1442, 82);
            pnQLNT.TabIndex = 0;
            // 
            // lbQLNT
            // 
            lbQLNT.AutoSize = true;
            lbQLNT.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLNT.ForeColor = SystemColors.ButtonHighlight;
            lbQLNT.Location = new Point(514, 19);
            lbQLNT.Name = "lbQLNT";
            lbQLNT.Size = new Size(449, 50);
            lbQLNT.TabIndex = 0;
            lbQLNT.Text = "QUẢN LÝ NHÓM THUỐC";
            lbQLNT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splQLNT
            // 
            splQLNT.BackColor = Color.Transparent;
            splQLNT.BackgroundImage = Properties.Resources.bg;
            splQLNT.Dock = DockStyle.Fill;
            splQLNT.Location = new Point(3, 91);
            splQLNT.Name = "splQLNT";
            // 
            // splQLNT.Panel1
            // 
            splQLNT.Panel1.Controls.Add(splQLNT_TT_HT);
            // 
            // splQLNT.Panel2
            // 
            splQLNT.Panel2.BackColor = Color.Transparent;
            splQLNT.Panel2.Controls.Add(splQLNT_TK_CN);
            splQLNT.Size = new Size(1442, 988);
            splQLNT.SplitterDistance = 986;
            splQLNT.TabIndex = 1;
            // 
            // splQLNT_TT_HT
            // 
            splQLNT_TT_HT.Dock = DockStyle.Fill;
            splQLNT_TT_HT.Location = new Point(0, 0);
            splQLNT_TT_HT.Name = "splQLNT_TT_HT";
            splQLNT_TT_HT.Orientation = Orientation.Horizontal;
            // 
            // splQLNT_TT_HT.Panel1
            // 
            splQLNT_TT_HT.Panel1.Controls.Add(grbQLNT_TK);
            // 
            // splQLNT_TT_HT.Panel2
            // 
            splQLNT_TT_HT.Panel2.Controls.Add(grbQLNT_HT);
            splQLNT_TT_HT.Size = new Size(986, 988);
            splQLNT_TT_HT.SplitterDistance = 220;
            splQLNT_TT_HT.TabIndex = 0;
            // 
            // grbQLNT_TK
            // 
            grbQLNT_TK.Controls.Add(txtQLNT_GhiChu);
            grbQLNT_TK.Controls.Add(lbQLNT_MaNhom);
            grbQLNT_TK.Controls.Add(txtQLNT_MaNhom);
            grbQLNT_TK.Controls.Add(txtQLNT_TenNhom);
            grbQLNT_TK.Controls.Add(lbQLNT_GhiChu);
            grbQLNT_TK.Controls.Add(lbQLNT_TenNhom);
            grbQLNT_TK.Dock = DockStyle.Fill;
            grbQLNT_TK.Location = new Point(0, 0);
            grbQLNT_TK.Name = "grbQLNT_TK";
            grbQLNT_TK.Size = new Size(986, 220);
            grbQLNT_TK.TabIndex = 0;
            grbQLNT_TK.TabStop = false;
            grbQLNT_TK.Text = "Thông tin";
            // 
            // txtQLNT_GhiChu
            // 
            txtQLNT_GhiChu.Location = new Point(670, 60);
            txtQLNT_GhiChu.Multiline = true;
            txtQLNT_GhiChu.Name = "txtQLNT_GhiChu";
            txtQLNT_GhiChu.Size = new Size(284, 123);
            txtQLNT_GhiChu.TabIndex = 3;
            // 
            // lbQLNT_MaNhom
            // 
            lbQLNT_MaNhom.AutoSize = true;
            lbQLNT_MaNhom.BackColor = SystemColors.Control;
            lbQLNT_MaNhom.BorderStyle = BorderStyle.Fixed3D;
            lbQLNT_MaNhom.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLNT_MaNhom.Location = new Point(40, 60);
            lbQLNT_MaNhom.Name = "lbQLNT_MaNhom";
            lbQLNT_MaNhom.Size = new Size(137, 39);
            lbQLNT_MaNhom.TabIndex = 6;
            lbQLNT_MaNhom.Text = "Mã nhóm";
            // 
            // txtQLNT_MaNhom
            // 
            txtQLNT_MaNhom.Location = new Point(199, 60);
            txtQLNT_MaNhom.Name = "txtQLNT_MaNhom";
            txtQLNT_MaNhom.Size = new Size(263, 43);
            txtQLNT_MaNhom.TabIndex = 1;
            // 
            // txtQLNT_TenNhom
            // 
            txtQLNT_TenNhom.Location = new Point(199, 127);
            txtQLNT_TenNhom.Multiline = true;
            txtQLNT_TenNhom.Name = "txtQLNT_TenNhom";
            txtQLNT_TenNhom.Size = new Size(263, 56);
            txtQLNT_TenNhom.TabIndex = 2;
            // 
            // lbQLNT_GhiChu
            // 
            lbQLNT_GhiChu.AutoSize = true;
            lbQLNT_GhiChu.BackColor = SystemColors.Control;
            lbQLNT_GhiChu.BorderStyle = BorderStyle.Fixed3D;
            lbQLNT_GhiChu.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLNT_GhiChu.Location = new Point(535, 60);
            lbQLNT_GhiChu.Name = "lbQLNT_GhiChu";
            lbQLNT_GhiChu.Size = new Size(113, 39);
            lbQLNT_GhiChu.TabIndex = 8;
            lbQLNT_GhiChu.Text = "Ghi chú";
            // 
            // lbQLNT_TenNhom
            // 
            lbQLNT_TenNhom.AutoSize = true;
            lbQLNT_TenNhom.BackColor = SystemColors.Control;
            lbQLNT_TenNhom.BorderStyle = BorderStyle.Fixed3D;
            lbQLNT_TenNhom.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLNT_TenNhom.Location = new Point(38, 130);
            lbQLNT_TenNhom.Name = "lbQLNT_TenNhom";
            lbQLNT_TenNhom.Size = new Size(140, 39);
            lbQLNT_TenNhom.TabIndex = 7;
            lbQLNT_TenNhom.Text = "Tên nhóm";
            // 
            // grbQLNT_HT
            // 
            grbQLNT_HT.Controls.Add(dgvQLNT);
            grbQLNT_HT.Dock = DockStyle.Fill;
            grbQLNT_HT.Location = new Point(0, 0);
            grbQLNT_HT.Name = "grbQLNT_HT";
            grbQLNT_HT.Size = new Size(986, 764);
            grbQLNT_HT.TabIndex = 0;
            grbQLNT_HT.TabStop = false;
            grbQLNT_HT.Text = "Hiển thị";
            // 
            // dgvQLNT
            // 
            dgvQLNT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLNT.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvQLNT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvQLNT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLNT.Columns.AddRange(new DataGridViewColumn[] { Nhom_ID, Nhom_Name, Description });
            dgvQLNT.Dock = DockStyle.Fill;
            dgvQLNT.Location = new Point(3, 39);
            dgvQLNT.Name = "dgvQLNT";
            dgvQLNT.RowHeadersWidth = 82;
            dgvQLNT.RowTemplate.Height = 41;
            dgvQLNT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQLNT.Size = new Size(980, 722);
            dgvQLNT.TabIndex = 0;
            dgvQLNT.RowPostPaint += dgvQLNT_RowPostPaint;
            dgvQLNT.SelectionChanged += dgvQLNT_SelectionChanged;
            // 
            // Nhom_ID
            // 
            Nhom_ID.DataPropertyName = "Nhom_ID";
            Nhom_ID.HeaderText = "Mã nhóm thuốc";
            Nhom_ID.MinimumWidth = 10;
            Nhom_ID.Name = "Nhom_ID";
            // 
            // Nhom_Name
            // 
            Nhom_Name.DataPropertyName = "Nhom_Name";
            Nhom_Name.HeaderText = "Tên nhóm thuốc";
            Nhom_Name.MinimumWidth = 10;
            Nhom_Name.Name = "Nhom_Name";
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Ghi chú";
            Description.MinimumWidth = 10;
            Description.Name = "Description";
            // 
            // splQLNT_TK_CN
            // 
            splQLNT_TK_CN.Dock = DockStyle.Fill;
            splQLNT_TK_CN.Location = new Point(0, 0);
            splQLNT_TK_CN.Name = "splQLNT_TK_CN";
            splQLNT_TK_CN.Orientation = Orientation.Horizontal;
            // 
            // splQLNT_TK_CN.Panel1
            // 
            splQLNT_TK_CN.Panel1.BackColor = Color.Transparent;
            splQLNT_TK_CN.Panel1.Controls.Add(grbQLNT_TT);
            // 
            // splQLNT_TK_CN.Panel2
            // 
            splQLNT_TK_CN.Panel2.Controls.Add(grbQLNT_CN);
            splQLNT_TK_CN.Size = new Size(452, 988);
            splQLNT_TK_CN.SplitterDistance = 375;
            splQLNT_TK_CN.TabIndex = 0;
            // 
            // grbQLNT_TT
            // 
            grbQLNT_TT.Controls.Add(cbQLNT_TK_MaNhom);
            grbQLNT_TT.Controls.Add(lbQLNT_TK_TenNhom);
            grbQLNT_TT.Controls.Add(txtQLNT_TK_TenNhom);
            grbQLNT_TT.Controls.Add(lbQLNT_TK_MaNhom);
            grbQLNT_TT.Dock = DockStyle.Fill;
            grbQLNT_TT.Location = new Point(0, 0);
            grbQLNT_TT.Name = "grbQLNT_TT";
            grbQLNT_TT.Size = new Size(452, 375);
            grbQLNT_TT.TabIndex = 0;
            grbQLNT_TT.TabStop = false;
            grbQLNT_TT.Text = "Tìm kiếm";
            // 
            // cbQLNT_TK_MaNhom
            // 
            cbQLNT_TK_MaNhom.FormattingEnabled = true;
            cbQLNT_TK_MaNhom.Location = new Point(189, 64);
            cbQLNT_TK_MaNhom.Name = "cbQLNT_TK_MaNhom";
            cbQLNT_TK_MaNhom.Size = new Size(233, 45);
            cbQLNT_TK_MaNhom.TabIndex = 6;
            // 
            // lbQLNT_TK_TenNhom
            // 
            lbQLNT_TK_TenNhom.AutoSize = true;
            lbQLNT_TK_TenNhom.BackColor = SystemColors.Control;
            lbQLNT_TK_TenNhom.BorderStyle = BorderStyle.Fixed3D;
            lbQLNT_TK_TenNhom.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLNT_TK_TenNhom.Location = new Point(24, 196);
            lbQLNT_TK_TenNhom.Name = "lbQLNT_TK_TenNhom";
            lbQLNT_TK_TenNhom.Size = new Size(140, 39);
            lbQLNT_TK_TenNhom.TabIndex = 5;
            lbQLNT_TK_TenNhom.Text = "Tên nhóm";
            // 
            // txtQLNT_TK_TenNhom
            // 
            txtQLNT_TK_TenNhom.Location = new Point(189, 196);
            txtQLNT_TK_TenNhom.Multiline = true;
            txtQLNT_TK_TenNhom.Name = "txtQLNT_TK_TenNhom";
            txtQLNT_TK_TenNhom.Size = new Size(233, 117);
            txtQLNT_TK_TenNhom.TabIndex = 8;
            // 
            // lbQLNT_TK_MaNhom
            // 
            lbQLNT_TK_MaNhom.AutoSize = true;
            lbQLNT_TK_MaNhom.BackColor = SystemColors.Control;
            lbQLNT_TK_MaNhom.BorderStyle = BorderStyle.Fixed3D;
            lbQLNT_TK_MaNhom.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLNT_TK_MaNhom.Location = new Point(24, 60);
            lbQLNT_TK_MaNhom.Name = "lbQLNT_TK_MaNhom";
            lbQLNT_TK_MaNhom.Size = new Size(137, 39);
            lbQLNT_TK_MaNhom.TabIndex = 4;
            lbQLNT_TK_MaNhom.Text = "Mã nhóm";
            // 
            // grbQLNT_CN
            // 
            grbQLNT_CN.Controls.Add(btnQLNT_Sua);
            grbQLNT_CN.Controls.Add(btnQLNT_Import);
            grbQLNT_CN.Controls.Add(btnQLNT_Export);
            grbQLNT_CN.Controls.Add(btnQLNT_Xoa);
            grbQLNT_CN.Controls.Add(btnQLNT_Them);
            grbQLNT_CN.Dock = DockStyle.Fill;
            grbQLNT_CN.Location = new Point(0, 0);
            grbQLNT_CN.Name = "grbQLNT_CN";
            grbQLNT_CN.Size = new Size(452, 609);
            grbQLNT_CN.TabIndex = 0;
            grbQLNT_CN.TabStop = false;
            grbQLNT_CN.Text = "Chức năng";
            // 
            // btnQLNT_Sua
            // 
            btnQLNT_Sua.BackColor = SystemColors.ButtonHighlight;
            btnQLNT_Sua.FlatAppearance.BorderSize = 0;
            btnQLNT_Sua.FlatStyle = FlatStyle.Popup;
            btnQLNT_Sua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLNT_Sua.ForeColor = SystemColors.ControlText;
            btnQLNT_Sua.Image = Properties.Resources.update;
            btnQLNT_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLNT_Sua.Location = new Point(24, 293);
            btnQLNT_Sua.Name = "btnQLNT_Sua";
            btnQLNT_Sua.Size = new Size(169, 64);
            btnQLNT_Sua.TabIndex = 5;
            btnQLNT_Sua.Text = "Sửa";
            btnQLNT_Sua.UseVisualStyleBackColor = false;
            // 
            // btnQLNT_Import
            // 
            btnQLNT_Import.BackColor = SystemColors.ButtonHighlight;
            btnQLNT_Import.FlatAppearance.BorderSize = 0;
            btnQLNT_Import.FlatStyle = FlatStyle.Popup;
            btnQLNT_Import.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLNT_Import.ForeColor = SystemColors.ControlText;
            btnQLNT_Import.Image = Properties.Resources.import;
            btnQLNT_Import.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLNT_Import.Location = new Point(262, 400);
            btnQLNT_Import.Name = "btnQLNT_Import";
            btnQLNT_Import.Size = new Size(169, 64);
            btnQLNT_Import.TabIndex = 4;
            btnQLNT_Import.Text = "Import";
            btnQLNT_Import.UseVisualStyleBackColor = false;
            // 
            // btnQLNT_Export
            // 
            btnQLNT_Export.BackColor = SystemColors.ButtonHighlight;
            btnQLNT_Export.FlatAppearance.BorderSize = 0;
            btnQLNT_Export.FlatStyle = FlatStyle.Popup;
            btnQLNT_Export.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLNT_Export.ForeColor = SystemColors.ControlText;
            btnQLNT_Export.Image = Properties.Resources.export;
            btnQLNT_Export.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLNT_Export.Location = new Point(262, 211);
            btnQLNT_Export.Name = "btnQLNT_Export";
            btnQLNT_Export.Size = new Size(169, 64);
            btnQLNT_Export.TabIndex = 3;
            btnQLNT_Export.Text = "Export";
            btnQLNT_Export.UseVisualStyleBackColor = false;
            // 
            // btnQLNT_Xoa
            // 
            btnQLNT_Xoa.BackColor = SystemColors.ButtonHighlight;
            btnQLNT_Xoa.FlatAppearance.BorderSize = 0;
            btnQLNT_Xoa.FlatStyle = FlatStyle.Popup;
            btnQLNT_Xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLNT_Xoa.ForeColor = SystemColors.ControlText;
            btnQLNT_Xoa.Image = Properties.Resources.delete;
            btnQLNT_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLNT_Xoa.Location = new Point(24, 483);
            btnQLNT_Xoa.Name = "btnQLNT_Xoa";
            btnQLNT_Xoa.Size = new Size(169, 64);
            btnQLNT_Xoa.TabIndex = 5;
            btnQLNT_Xoa.Text = "Xóa";
            btnQLNT_Xoa.UseVisualStyleBackColor = false;
            // 
            // btnQLNT_Them
            // 
            btnQLNT_Them.BackColor = SystemColors.ButtonHighlight;
            btnQLNT_Them.FlatAppearance.BorderSize = 0;
            btnQLNT_Them.FlatStyle = FlatStyle.Popup;
            btnQLNT_Them.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLNT_Them.ForeColor = SystemColors.ControlText;
            btnQLNT_Them.Image = Properties.Resources.add;
            btnQLNT_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLNT_Them.Location = new Point(24, 104);
            btnQLNT_Them.Name = "btnQLNT_Them";
            btnQLNT_Them.Size = new Size(169, 64);
            btnQLNT_Them.TabIndex = 0;
            btnQLNT_Them.Text = "Thêm";
            btnQLNT_Them.UseVisualStyleBackColor = false;
            // 
            // UC_QLNhomThuoc
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpQLNT);
            Name = "UC_QLNhomThuoc";
            Size = new Size(1448, 1082);
            tlpQLNT.ResumeLayout(false);
            pnQLNT.ResumeLayout(false);
            pnQLNT.PerformLayout();
            splQLNT.Panel1.ResumeLayout(false);
            splQLNT.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLNT).EndInit();
            splQLNT.ResumeLayout(false);
            splQLNT_TT_HT.Panel1.ResumeLayout(false);
            splQLNT_TT_HT.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLNT_TT_HT).EndInit();
            splQLNT_TT_HT.ResumeLayout(false);
            grbQLNT_TK.ResumeLayout(false);
            grbQLNT_TK.PerformLayout();
            grbQLNT_HT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLNT).EndInit();
            splQLNT_TK_CN.Panel1.ResumeLayout(false);
            splQLNT_TK_CN.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLNT_TK_CN).EndInit();
            splQLNT_TK_CN.ResumeLayout(false);
            grbQLNT_TT.ResumeLayout(false);
            grbQLNT_TT.PerformLayout();
            grbQLNT_CN.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpQLNT;
        private Panel pnQLNT;
        private Label lbQLNT;
        private SplitContainer splQLNT;
        private SplitContainer splQLNT_TT_HT;
        private GroupBox grbQLNT_TK;
        private TextBox txtQLNT_TK_TenNhom;
        private GroupBox grbQLNT_HT;
        private DataGridView dgvQLNT;
        private SplitContainer splQLNT_TK_CN;
        private GroupBox grbQLNT_TT;
        private GroupBox grbQLNT_CN;
        private Button btnQLNT_Sua;
        private Button btnQLNT_Import;
        private Button btnQLNT_Export;
        private Button btnQLNT_Xoa;
        private Button btnQLNT_Them;
        private Label lbQLNT_TK_TenNhom;
        private Label lbQLNT_TK_MaNhom;
        private TextBox txtQLNT_GhiChu;
        private Label lbQLNT_MaNhom;
        private TextBox txtQLNT_MaNhom;
        private TextBox txtQLNT_TenNhom;
        private Label lbQLNT_GhiChu;
        private Label lbQLNT_TenNhom;
        private DataGridViewTextBoxColumn Nhom_ID;
        private DataGridViewTextBoxColumn Nhom_Name;
        private DataGridViewTextBoxColumn Description;
        private ComboBox cbQLNT_TK_MaNhom;
    }
}
