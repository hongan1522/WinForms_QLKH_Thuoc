namespace FormQLKH
{
    partial class UC_NCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_NCC));
            tlpNCC = new TableLayoutPanel();
            pnNCC = new Panel();
            lbNCC = new Label();
            splNCC_HT_CN = new SplitContainer();
            grbNCC_HT = new GroupBox();
            dgvNCC = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            grbNCC_CN = new GroupBox();
            btnNCC_Thoat = new Button();
            btnNCC_Export = new Button();
            btnNCC_Import = new Button();
            btnNCC_Xoa = new Button();
            btnNCC_Sua = new Button();
            btnNCC_Them = new Button();
            splNCC_TK_TT = new SplitContainer();
            grbNCC_TK = new GroupBox();
            btnNCC_Tim = new Button();
            txtNCC_TK_TenNCC = new TextBox();
            rdbNCC_TenNCC = new RadioButton();
            txtNCC_TK_MaNCC = new TextBox();
            rdbNCC_MaNCC = new RadioButton();
            grbNCC_TT = new GroupBox();
            numNCC_SoLuongDN = new NumericUpDown();
            txtNCC_DiaChi = new TextBox();
            txtNCC_SDT = new TextBox();
            txtNCC_TenNCC = new TextBox();
            txtNCC_MaNCC = new TextBox();
            lbNCC_DiaChi = new Label();
            lbNCC_SoLuongDN = new Label();
            lbNCC_SDT = new Label();
            lbNCC_TenNCC = new Label();
            lbNCC_MaNCC = new Label();
            tlpNCC.SuspendLayout();
            pnNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splNCC_HT_CN).BeginInit();
            splNCC_HT_CN.Panel1.SuspendLayout();
            splNCC_HT_CN.Panel2.SuspendLayout();
            splNCC_HT_CN.SuspendLayout();
            grbNCC_HT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNCC).BeginInit();
            grbNCC_CN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splNCC_TK_TT).BeginInit();
            splNCC_TK_TT.Panel1.SuspendLayout();
            splNCC_TK_TT.Panel2.SuspendLayout();
            splNCC_TK_TT.SuspendLayout();
            grbNCC_TK.SuspendLayout();
            grbNCC_TT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNCC_SoLuongDN).BeginInit();
            SuspendLayout();
            // 
            // tlpNCC
            // 
            tlpNCC.BackColor = SystemColors.Control;
            tlpNCC.ColumnCount = 1;
            tlpNCC.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpNCC.Controls.Add(pnNCC, 0, 0);
            tlpNCC.Controls.Add(splNCC_HT_CN, 0, 1);
            tlpNCC.Controls.Add(splNCC_TK_TT, 0, 2);
            tlpNCC.Dock = DockStyle.Fill;
            tlpNCC.Location = new Point(0, 0);
            tlpNCC.Name = "tlpNCC";
            tlpNCC.RowCount = 3;
            tlpNCC.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tlpNCC.RowStyles.Add(new RowStyle(SizeType.Absolute, 579F));
            tlpNCC.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tlpNCC.Size = new Size(1420, 1000);
            tlpNCC.TabIndex = 1;
            // 
            // pnNCC
            // 
            pnNCC.BackColor = Color.FromArgb(63, 139, 208);
            pnNCC.Controls.Add(lbNCC);
            pnNCC.Dock = DockStyle.Fill;
            pnNCC.Location = new Point(3, 3);
            pnNCC.Name = "pnNCC";
            pnNCC.Size = new Size(1414, 77);
            pnNCC.TabIndex = 0;
            // 
            // lbNCC
            // 
            lbNCC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbNCC.AutoSize = true;
            lbNCC.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbNCC.ForeColor = SystemColors.ButtonHighlight;
            lbNCC.Location = new Point(484, 15);
            lbNCC.Name = "lbNCC";
            lbNCC.Size = new Size(471, 50);
            lbNCC.TabIndex = 0;
            lbNCC.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            // 
            // splNCC_HT_CN
            // 
            splNCC_HT_CN.Dock = DockStyle.Fill;
            splNCC_HT_CN.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            splNCC_HT_CN.Location = new Point(3, 86);
            splNCC_HT_CN.Name = "splNCC_HT_CN";
            // 
            // splNCC_HT_CN.Panel1
            // 
            splNCC_HT_CN.Panel1.Controls.Add(grbNCC_HT);
            // 
            // splNCC_HT_CN.Panel2
            // 
            splNCC_HT_CN.Panel2.Controls.Add(grbNCC_CN);
            splNCC_HT_CN.Size = new Size(1414, 573);
            splNCC_HT_CN.SplitterDistance = 1155;
            splNCC_HT_CN.TabIndex = 1;
            // 
            // grbNCC_HT
            // 
            grbNCC_HT.Controls.Add(dgvNCC);
            grbNCC_HT.Dock = DockStyle.Fill;
            grbNCC_HT.Location = new Point(0, 0);
            grbNCC_HT.Name = "grbNCC_HT";
            grbNCC_HT.Size = new Size(1155, 573);
            grbNCC_HT.TabIndex = 2;
            grbNCC_HT.TabStop = false;
            grbNCC_HT.Text = "Hiển thị";
            // 
            // dgvNCC
            // 
            dgvNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNCC.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNCC.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvNCC.Dock = DockStyle.Fill;
            dgvNCC.Location = new Point(3, 39);
            dgvNCC.Name = "dgvNCC";
            dgvNCC.RowHeadersWidth = 82;
            dgvNCC.RowTemplate.Height = 41;
            dgvNCC.Size = new Size(1149, 531);
            dgvNCC.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Mã NCC";
            dataGridViewTextBoxColumn1.MinimumWidth = 10;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Tên NCC";
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Số lượng đơn nhập";
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "SĐT";
            dataGridViewTextBoxColumn4.MinimumWidth = 10;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Địa chỉ";
            dataGridViewTextBoxColumn5.MinimumWidth = 10;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // grbNCC_CN
            // 
            grbNCC_CN.Controls.Add(btnNCC_Thoat);
            grbNCC_CN.Controls.Add(btnNCC_Export);
            grbNCC_CN.Controls.Add(btnNCC_Import);
            grbNCC_CN.Controls.Add(btnNCC_Xoa);
            grbNCC_CN.Controls.Add(btnNCC_Sua);
            grbNCC_CN.Controls.Add(btnNCC_Them);
            grbNCC_CN.Dock = DockStyle.Fill;
            grbNCC_CN.Location = new Point(0, 0);
            grbNCC_CN.Name = "grbNCC_CN";
            grbNCC_CN.Size = new Size(255, 573);
            grbNCC_CN.TabIndex = 0;
            grbNCC_CN.TabStop = false;
            grbNCC_CN.Text = "Chức năng";
            // 
            // btnNCC_Thoat
            // 
            btnNCC_Thoat.BackColor = Color.Red;
            btnNCC_Thoat.FlatAppearance.BorderSize = 0;
            btnNCC_Thoat.FlatStyle = FlatStyle.Flat;
            btnNCC_Thoat.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnNCC_Thoat.Image = (Image)resources.GetObject("btnNCC_Thoat.Image");
            btnNCC_Thoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnNCC_Thoat.Location = new Point(36, 494);
            btnNCC_Thoat.Name = "btnNCC_Thoat";
            btnNCC_Thoat.Size = new Size(182, 58);
            btnNCC_Thoat.TabIndex = 5;
            btnNCC_Thoat.Text = "Thoát";
            btnNCC_Thoat.UseVisualStyleBackColor = false;
            // 
            // btnNCC_Export
            // 
            btnNCC_Export.BackColor = SystemColors.ButtonHighlight;
            btnNCC_Export.FlatAppearance.BorderSize = 0;
            btnNCC_Export.FlatStyle = FlatStyle.Flat;
            btnNCC_Export.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnNCC_Export.Image = Properties.Resources.export;
            btnNCC_Export.ImageAlign = ContentAlignment.MiddleLeft;
            btnNCC_Export.Location = new Point(36, 407);
            btnNCC_Export.Name = "btnNCC_Export";
            btnNCC_Export.Size = new Size(182, 58);
            btnNCC_Export.TabIndex = 4;
            btnNCC_Export.Text = "Export";
            btnNCC_Export.UseVisualStyleBackColor = false;
            // 
            // btnNCC_Import
            // 
            btnNCC_Import.BackColor = SystemColors.ButtonHighlight;
            btnNCC_Import.FlatAppearance.BorderSize = 0;
            btnNCC_Import.FlatStyle = FlatStyle.Flat;
            btnNCC_Import.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnNCC_Import.Image = Properties.Resources.import;
            btnNCC_Import.ImageAlign = ContentAlignment.MiddleLeft;
            btnNCC_Import.Location = new Point(36, 320);
            btnNCC_Import.Name = "btnNCC_Import";
            btnNCC_Import.Size = new Size(182, 58);
            btnNCC_Import.TabIndex = 3;
            btnNCC_Import.Text = "Import";
            btnNCC_Import.UseVisualStyleBackColor = false;
            // 
            // btnNCC_Xoa
            // 
            btnNCC_Xoa.BackColor = SystemColors.ButtonHighlight;
            btnNCC_Xoa.FlatAppearance.BorderSize = 0;
            btnNCC_Xoa.FlatStyle = FlatStyle.Flat;
            btnNCC_Xoa.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnNCC_Xoa.Image = Properties.Resources.Delete;
            btnNCC_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnNCC_Xoa.Location = new Point(36, 233);
            btnNCC_Xoa.Name = "btnNCC_Xoa";
            btnNCC_Xoa.Size = new Size(182, 58);
            btnNCC_Xoa.TabIndex = 2;
            btnNCC_Xoa.Text = "Xóa";
            btnNCC_Xoa.UseVisualStyleBackColor = false;
            // 
            // btnNCC_Sua
            // 
            btnNCC_Sua.BackColor = SystemColors.ButtonHighlight;
            btnNCC_Sua.FlatAppearance.BorderSize = 0;
            btnNCC_Sua.FlatStyle = FlatStyle.Flat;
            btnNCC_Sua.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnNCC_Sua.Image = Properties.Resources.Edit;
            btnNCC_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btnNCC_Sua.Location = new Point(36, 146);
            btnNCC_Sua.Name = "btnNCC_Sua";
            btnNCC_Sua.Size = new Size(182, 58);
            btnNCC_Sua.TabIndex = 1;
            btnNCC_Sua.Text = "Sửa";
            btnNCC_Sua.UseVisualStyleBackColor = false;
            // 
            // btnNCC_Them
            // 
            btnNCC_Them.BackColor = SystemColors.ButtonHighlight;
            btnNCC_Them.FlatAppearance.BorderSize = 0;
            btnNCC_Them.FlatStyle = FlatStyle.Flat;
            btnNCC_Them.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnNCC_Them.Image = Properties.Resources.New;
            btnNCC_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btnNCC_Them.Location = new Point(36, 59);
            btnNCC_Them.Name = "btnNCC_Them";
            btnNCC_Them.Size = new Size(182, 58);
            btnNCC_Them.TabIndex = 0;
            btnNCC_Them.Text = "Thêm";
            btnNCC_Them.UseVisualStyleBackColor = false;
            // 
            // splNCC_TK_TT
            // 
            splNCC_TK_TT.Dock = DockStyle.Fill;
            splNCC_TK_TT.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            splNCC_TK_TT.Location = new Point(3, 665);
            splNCC_TK_TT.Name = "splNCC_TK_TT";
            // 
            // splNCC_TK_TT.Panel1
            // 
            splNCC_TK_TT.Panel1.Controls.Add(grbNCC_TK);
            // 
            // splNCC_TK_TT.Panel2
            // 
            splNCC_TK_TT.Panel2.Controls.Add(grbNCC_TT);
            splNCC_TK_TT.Size = new Size(1414, 332);
            splNCC_TK_TT.SplitterDistance = 531;
            splNCC_TK_TT.TabIndex = 2;
            // 
            // grbNCC_TK
            // 
            grbNCC_TK.Controls.Add(btnNCC_Tim);
            grbNCC_TK.Controls.Add(txtNCC_TK_TenNCC);
            grbNCC_TK.Controls.Add(rdbNCC_TenNCC);
            grbNCC_TK.Controls.Add(txtNCC_TK_MaNCC);
            grbNCC_TK.Controls.Add(rdbNCC_MaNCC);
            grbNCC_TK.Dock = DockStyle.Fill;
            grbNCC_TK.Location = new Point(0, 0);
            grbNCC_TK.Name = "grbNCC_TK";
            grbNCC_TK.Size = new Size(531, 332);
            grbNCC_TK.TabIndex = 0;
            grbNCC_TK.TabStop = false;
            grbNCC_TK.Text = "Tìm kiếm";
            // 
            // btnNCC_Tim
            // 
            btnNCC_Tim.BackColor = SystemColors.ControlLightLight;
            btnNCC_Tim.FlatAppearance.BorderSize = 0;
            btnNCC_Tim.FlatStyle = FlatStyle.Flat;
            btnNCC_Tim.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnNCC_Tim.Image = Properties.Resources.glass;
            btnNCC_Tim.ImageAlign = ContentAlignment.MiddleLeft;
            btnNCC_Tim.Location = new Point(325, 237);
            btnNCC_Tim.Name = "btnNCC_Tim";
            btnNCC_Tim.Size = new Size(166, 58);
            btnNCC_Tim.TabIndex = 4;
            btnNCC_Tim.Text = "Tìm ";
            btnNCC_Tim.UseVisualStyleBackColor = false;
            // 
            // txtNCC_TK_TenNCC
            // 
            txtNCC_TK_TenNCC.Location = new Point(194, 141);
            txtNCC_TK_TenNCC.Multiline = true;
            txtNCC_TK_TenNCC.Name = "txtNCC_TK_TenNCC";
            txtNCC_TK_TenNCC.Size = new Size(296, 58);
            txtNCC_TK_TenNCC.TabIndex = 3;
            // 
            // rdbNCC_TenNCC
            // 
            rdbNCC_TenNCC.AutoSize = true;
            rdbNCC_TenNCC.Location = new Point(31, 141);
            rdbNCC_TenNCC.Name = "rdbNCC_TenNCC";
            rdbNCC_TenNCC.Size = new Size(148, 41);
            rdbNCC_TenNCC.TabIndex = 2;
            rdbNCC_TenNCC.TabStop = true;
            rdbNCC_TenNCC.Text = "Tên NCC";
            rdbNCC_TenNCC.UseVisualStyleBackColor = true;
            // 
            // txtNCC_TK_MaNCC
            // 
            txtNCC_TK_MaNCC.Location = new Point(194, 59);
            txtNCC_TK_MaNCC.Name = "txtNCC_TK_MaNCC";
            txtNCC_TK_MaNCC.Size = new Size(296, 43);
            txtNCC_TK_MaNCC.TabIndex = 1;
            // 
            // rdbNCC_MaNCC
            // 
            rdbNCC_MaNCC.AutoSize = true;
            rdbNCC_MaNCC.Location = new Point(31, 59);
            rdbNCC_MaNCC.Name = "rdbNCC_MaNCC";
            rdbNCC_MaNCC.Size = new Size(146, 41);
            rdbNCC_MaNCC.TabIndex = 0;
            rdbNCC_MaNCC.TabStop = true;
            rdbNCC_MaNCC.Text = "Mã NCC";
            rdbNCC_MaNCC.UseVisualStyleBackColor = true;
            // 
            // grbNCC_TT
            // 
            grbNCC_TT.Controls.Add(numNCC_SoLuongDN);
            grbNCC_TT.Controls.Add(txtNCC_DiaChi);
            grbNCC_TT.Controls.Add(txtNCC_SDT);
            grbNCC_TT.Controls.Add(txtNCC_TenNCC);
            grbNCC_TT.Controls.Add(txtNCC_MaNCC);
            grbNCC_TT.Controls.Add(lbNCC_DiaChi);
            grbNCC_TT.Controls.Add(lbNCC_SoLuongDN);
            grbNCC_TT.Controls.Add(lbNCC_SDT);
            grbNCC_TT.Controls.Add(lbNCC_TenNCC);
            grbNCC_TT.Controls.Add(lbNCC_MaNCC);
            grbNCC_TT.Dock = DockStyle.Fill;
            grbNCC_TT.Location = new Point(0, 0);
            grbNCC_TT.Name = "grbNCC_TT";
            grbNCC_TT.Size = new Size(879, 332);
            grbNCC_TT.TabIndex = 0;
            grbNCC_TT.TabStop = false;
            grbNCC_TT.Text = "Thông tin";
            // 
            // numNCC_SoLuongDN
            // 
            numNCC_SoLuongDN.Location = new Point(276, 244);
            numNCC_SoLuongDN.Name = "numNCC_SoLuongDN";
            numNCC_SoLuongDN.Size = new Size(144, 43);
            numNCC_SoLuongDN.TabIndex = 9;
            // 
            // txtNCC_DiaChi
            // 
            txtNCC_DiaChi.Location = new Point(592, 196);
            txtNCC_DiaChi.Multiline = true;
            txtNCC_DiaChi.Name = "txtNCC_DiaChi";
            txtNCC_DiaChi.Size = new Size(270, 103);
            txtNCC_DiaChi.TabIndex = 8;
            // 
            // txtNCC_SDT
            // 
            txtNCC_SDT.Location = new Point(156, 160);
            txtNCC_SDT.Name = "txtNCC_SDT";
            txtNCC_SDT.Size = new Size(263, 43);
            txtNCC_SDT.TabIndex = 7;
            // 
            // txtNCC_TenNCC
            // 
            txtNCC_TenNCC.Location = new Point(592, 76);
            txtNCC_TenNCC.Multiline = true;
            txtNCC_TenNCC.Name = "txtNCC_TenNCC";
            txtNCC_TenNCC.Size = new Size(263, 74);
            txtNCC_TenNCC.TabIndex = 6;
            // 
            // txtNCC_MaNCC
            // 
            txtNCC_MaNCC.Location = new Point(156, 70);
            txtNCC_MaNCC.Name = "txtNCC_MaNCC";
            txtNCC_MaNCC.Size = new Size(263, 43);
            txtNCC_MaNCC.TabIndex = 5;
            // 
            // lbNCC_DiaChi
            // 
            lbNCC_DiaChi.AutoSize = true;
            lbNCC_DiaChi.Location = new Point(471, 198);
            lbNCC_DiaChi.Name = "lbNCC_DiaChi";
            lbNCC_DiaChi.Size = new Size(98, 37);
            lbNCC_DiaChi.TabIndex = 4;
            lbNCC_DiaChi.Text = "Địa chỉ";
            // 
            // lbNCC_SoLuongDN
            // 
            lbNCC_SoLuongDN.AutoSize = true;
            lbNCC_SoLuongDN.Location = new Point(23, 250);
            lbNCC_SoLuongDN.Name = "lbNCC_SoLuongDN";
            lbNCC_SoLuongDN.Size = new Size(245, 37);
            lbNCC_SoLuongDN.TabIndex = 3;
            lbNCC_SoLuongDN.Text = "Số lượng đơn nhập";
            // 
            // lbNCC_SDT
            // 
            lbNCC_SDT.AutoSize = true;
            lbNCC_SDT.Location = new Point(23, 157);
            lbNCC_SDT.Name = "lbNCC_SDT";
            lbNCC_SDT.Size = new Size(64, 37);
            lbNCC_SDT.TabIndex = 2;
            lbNCC_SDT.Text = "SĐT";
            // 
            // lbNCC_TenNCC
            // 
            lbNCC_TenNCC.AutoSize = true;
            lbNCC_TenNCC.Location = new Point(471, 72);
            lbNCC_TenNCC.Name = "lbNCC_TenNCC";
            lbNCC_TenNCC.Size = new Size(117, 37);
            lbNCC_TenNCC.TabIndex = 1;
            lbNCC_TenNCC.Text = "Tên NCC";
            // 
            // lbNCC_MaNCC
            // 
            lbNCC_MaNCC.AutoSize = true;
            lbNCC_MaNCC.Location = new Point(23, 74);
            lbNCC_MaNCC.Name = "lbNCC_MaNCC";
            lbNCC_MaNCC.Size = new Size(115, 37);
            lbNCC_MaNCC.TabIndex = 0;
            lbNCC_MaNCC.Text = "Mã NCC";
            // 
            // UC_NCC
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpNCC);
            Name = "UC_NCC";
            Size = new Size(1420, 1000);
            tlpNCC.ResumeLayout(false);
            pnNCC.ResumeLayout(false);
            pnNCC.PerformLayout();
            splNCC_HT_CN.Panel1.ResumeLayout(false);
            splNCC_HT_CN.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splNCC_HT_CN).EndInit();
            splNCC_HT_CN.ResumeLayout(false);
            grbNCC_HT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNCC).EndInit();
            grbNCC_CN.ResumeLayout(false);
            splNCC_TK_TT.Panel1.ResumeLayout(false);
            splNCC_TK_TT.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splNCC_TK_TT).EndInit();
            splNCC_TK_TT.ResumeLayout(false);
            grbNCC_TK.ResumeLayout(false);
            grbNCC_TK.PerformLayout();
            grbNCC_TT.ResumeLayout(false);
            grbNCC_TT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNCC_SoLuongDN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpNCC;
        private Panel pnNCC;
        private Label lbNCC;
        private SplitContainer splNCC_HT_CN;
        private GroupBox grbNCC_HT;
        private DataGridView dgvNCC;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private GroupBox grbNCC_CN;
        private Button btnNCC_Thoat;
        private Button btnNCC_Export;
        private Button btnNCC_Import;
        private Button btnNCC_Xoa;
        private Button btnNCC_Sua;
        private Button btnNCC_Them;
        private SplitContainer splNCC_TK_TT;
        private GroupBox grbNCC_TK;
        private Button btnNCC_Tim;
        private TextBox txtNCC_TK_TenNCC;
        private RadioButton rdbNCC_TenNCC;
        private TextBox txtNCC_TK_MaNCC;
        private RadioButton rdbNCC_MaNCC;
        private GroupBox grbNCC_TT;
        private NumericUpDown numNCC_SoLuongDN;
        private TextBox txtNCC_DiaChi;
        private TextBox txtNCC_SDT;
        private TextBox txtNCC_TenNCC;
        private TextBox txtNCC_MaNCC;
        private Label lbNCC_DiaChi;
        private Label lbNCC_SoLuongDN;
        private Label lbNCC_SDT;
        private Label lbNCC_TenNCC;
        private Label lbNCC_MaNCC;
    }
}
