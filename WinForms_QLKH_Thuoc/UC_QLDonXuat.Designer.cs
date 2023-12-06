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
            dtpQLDX_NgayXuat = new DateTimePicker();
            txtQLDX_TenDX = new TextBox();
            txtQLDX_MaNV = new TextBox();
            txtQLDX_MaDX = new TextBox();
            lbQLDX_NgayXuat = new Label();
            lbQLDX_TenDX = new Label();
            lbQLDX_MaNV = new Label();
            lbQLDX_MaDX = new Label();
            grbQLDX_TK = new GroupBox();
            txtQLDX_TK_MaNV = new TextBox();
            rdbQLDX_MaNV = new RadioButton();
            txtQLDX_TK_MaDX = new TextBox();
            btnQLDX_Tim = new Button();
            rdbQLDX_MaDX = new RadioButton();
            splQLDX_CN_HT = new SplitContainer();
            grbQLDX_CN = new GroupBox();
            btnQLDX_Thoat = new Button();
            btnQLDX_Export = new Button();
            btnQLDX_Import = new Button();
            btnQLDX_Xoa = new Button();
            btnQLDX_Sua = new Button();
            btnQLDX_Them = new Button();
            grbQLDX_HT = new GroupBox();
            dgvQLDX = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
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
            tlpQLDX.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpQLDX.RowStyles.Add(new RowStyle(SizeType.Absolute, 603F));
            tlpQLDX.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tlpQLDX.Size = new Size(1420, 1000);
            tlpQLDX.TabIndex = 1;
            // 
            // pnQLDX
            // 
            pnQLDX.BackColor = Color.FromArgb(63, 139, 208);
            pnQLDX.Controls.Add(lbQLDX);
            pnQLDX.Dock = DockStyle.Fill;
            pnQLDX.Location = new Point(3, 3);
            pnQLDX.Name = "pnQLDX";
            pnQLDX.Size = new Size(1414, 69);
            pnQLDX.TabIndex = 0;
            // 
            // lbQLDX
            // 
            lbQLDX.AutoSize = true;
            lbQLDX.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLDX.ForeColor = SystemColors.ButtonHighlight;
            lbQLDX.Location = new Point(570, 12);
            lbQLDX.Name = "lbQLDX";
            lbQLDX.Size = new Size(385, 50);
            lbQLDX.TabIndex = 0;
            lbQLDX.Text = "QUẢN LÝ ĐƠN XUẤT";
            // 
            // splQLDX_TT_TK
            // 
            splQLDX_TT_TK.Location = new Point(3, 681);
            splQLDX_TT_TK.Name = "splQLDX_TT_TK";
            // 
            // splQLDX_TT_TK.Panel1
            // 
            splQLDX_TT_TK.Panel1.Controls.Add(grbQLDX_TT);
            // 
            // splQLDX_TT_TK.Panel2
            // 
            splQLDX_TT_TK.Panel2.Controls.Add(grbQLDX_TK);
            splQLDX_TT_TK.Size = new Size(1414, 316);
            splQLDX_TT_TK.SplitterDistance = 935;
            splQLDX_TT_TK.TabIndex = 2;
            // 
            // grbQLDX_TT
            // 
            grbQLDX_TT.Controls.Add(dtpQLDX_NgayXuat);
            grbQLDX_TT.Controls.Add(txtQLDX_TenDX);
            grbQLDX_TT.Controls.Add(txtQLDX_MaNV);
            grbQLDX_TT.Controls.Add(txtQLDX_MaDX);
            grbQLDX_TT.Controls.Add(lbQLDX_NgayXuat);
            grbQLDX_TT.Controls.Add(lbQLDX_TenDX);
            grbQLDX_TT.Controls.Add(lbQLDX_MaNV);
            grbQLDX_TT.Controls.Add(lbQLDX_MaDX);
            grbQLDX_TT.Dock = DockStyle.Fill;
            grbQLDX_TT.Location = new Point(0, 0);
            grbQLDX_TT.Name = "grbQLDX_TT";
            grbQLDX_TT.Size = new Size(935, 316);
            grbQLDX_TT.TabIndex = 0;
            grbQLDX_TT.TabStop = false;
            grbQLDX_TT.Text = "Thông tin";
            // 
            // dtpQLDX_NgayXuat
            // 
            dtpQLDX_NgayXuat.CustomFormat = "dd/MM/yyyy";
            dtpQLDX_NgayXuat.Format = DateTimePickerFormat.Custom;
            dtpQLDX_NgayXuat.Location = new Point(631, 71);
            dtpQLDX_NgayXuat.Name = "dtpQLDX_NgayXuat";
            dtpQLDX_NgayXuat.Size = new Size(291, 43);
            dtpQLDX_NgayXuat.TabIndex = 7;
            dtpQLDX_NgayXuat.Value = new DateTime(2023, 11, 27, 12, 53, 49, 0);
            // 
            // txtQLDX_TenDX
            // 
            txtQLDX_TenDX.Location = new Point(631, 168);
            txtQLDX_TenDX.Multiline = true;
            txtQLDX_TenDX.Name = "txtQLDX_TenDX";
            txtQLDX_TenDX.Size = new Size(291, 109);
            txtQLDX_TenDX.TabIndex = 6;
            // 
            // txtQLDX_MaNV
            // 
            txtQLDX_MaNV.Location = new Point(186, 168);
            txtQLDX_MaNV.Name = "txtQLDX_MaNV";
            txtQLDX_MaNV.Size = new Size(229, 43);
            txtQLDX_MaNV.TabIndex = 5;
            // 
            // txtQLDX_MaDX
            // 
            txtQLDX_MaDX.Location = new Point(186, 69);
            txtQLDX_MaDX.Name = "txtQLDX_MaDX";
            txtQLDX_MaDX.Size = new Size(229, 43);
            txtQLDX_MaDX.TabIndex = 4;
            // 
            // lbQLDX_NgayXuat
            // 
            lbQLDX_NgayXuat.AutoSize = true;
            lbQLDX_NgayXuat.Location = new Point(457, 69);
            lbQLDX_NgayXuat.Name = "lbQLDX_NgayXuat";
            lbQLDX_NgayXuat.Size = new Size(137, 37);
            lbQLDX_NgayXuat.TabIndex = 3;
            lbQLDX_NgayXuat.Text = "Ngày xuất";
            // 
            // lbQLDX_TenDX
            // 
            lbQLDX_TenDX.AutoSize = true;
            lbQLDX_TenDX.Location = new Point(457, 168);
            lbQLDX_TenDX.Name = "lbQLDX_TenDX";
            lbQLDX_TenDX.Size = new Size(168, 37);
            lbQLDX_TenDX.TabIndex = 2;
            lbQLDX_TenDX.Text = "Tên đơn xuất";
            // 
            // lbQLDX_MaNV
            // 
            lbQLDX_MaNV.AutoSize = true;
            lbQLDX_MaNV.Location = new Point(18, 168);
            lbQLDX_MaNV.Name = "lbQLDX_MaNV";
            lbQLDX_MaNV.Size = new Size(99, 37);
            lbQLDX_MaNV.TabIndex = 1;
            lbQLDX_MaNV.Text = "Mã NV";
            // 
            // lbQLDX_MaDX
            // 
            lbQLDX_MaDX.AutoSize = true;
            lbQLDX_MaDX.Location = new Point(18, 69);
            lbQLDX_MaDX.Name = "lbQLDX_MaDX";
            lbQLDX_MaDX.Size = new Size(166, 37);
            lbQLDX_MaDX.TabIndex = 0;
            lbQLDX_MaDX.Text = "Mã đơn xuất";
            // 
            // grbQLDX_TK
            // 
            grbQLDX_TK.Controls.Add(txtQLDX_TK_MaNV);
            grbQLDX_TK.Controls.Add(rdbQLDX_MaNV);
            grbQLDX_TK.Controls.Add(txtQLDX_TK_MaDX);
            grbQLDX_TK.Controls.Add(btnQLDX_Tim);
            grbQLDX_TK.Controls.Add(rdbQLDX_MaDX);
            grbQLDX_TK.Dock = DockStyle.Fill;
            grbQLDX_TK.Location = new Point(0, 0);
            grbQLDX_TK.Name = "grbQLDX_TK";
            grbQLDX_TK.Size = new Size(475, 316);
            grbQLDX_TK.TabIndex = 1;
            grbQLDX_TK.TabStop = false;
            grbQLDX_TK.Text = "Tìm kiếm";
            // 
            // txtQLDX_TK_MaNV
            // 
            txtQLDX_TK_MaNV.Location = new Point(240, 163);
            txtQLDX_TK_MaNV.Name = "txtQLDX_TK_MaNV";
            txtQLDX_TK_MaNV.Size = new Size(211, 43);
            txtQLDX_TK_MaNV.TabIndex = 3;
            // 
            // rdbQLDX_MaNV
            // 
            rdbQLDX_MaNV.AutoSize = true;
            rdbQLDX_MaNV.Location = new Point(26, 164);
            rdbQLDX_MaNV.Name = "rdbQLDX_MaNV";
            rdbQLDX_MaNV.Size = new Size(208, 41);
            rdbQLDX_MaNV.TabIndex = 2;
            rdbQLDX_MaNV.TabStop = true;
            rdbQLDX_MaNV.Text = "Mã nhân viên";
            rdbQLDX_MaNV.UseVisualStyleBackColor = true;
            // 
            // txtQLDX_TK_MaDX
            // 
            txtQLDX_TK_MaDX.Location = new Point(240, 71);
            txtQLDX_TK_MaDX.Name = "txtQLDX_TK_MaDX";
            txtQLDX_TK_MaDX.Size = new Size(211, 43);
            txtQLDX_TK_MaDX.TabIndex = 1;
            // 
            // btnQLDX_Tim
            // 
            btnQLDX_Tim.BackColor = SystemColors.ButtonHighlight;
            btnQLDX_Tim.FlatAppearance.BorderSize = 0;
            btnQLDX_Tim.FlatStyle = FlatStyle.Flat;
            btnQLDX_Tim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDX_Tim.Location = new Point(330, 225);
            btnQLDX_Tim.Name = "btnQLDX_Tim";
            btnQLDX_Tim.Size = new Size(121, 67);
            btnQLDX_Tim.TabIndex = 3;
            btnQLDX_Tim.Text = "Tìm";
            btnQLDX_Tim.UseVisualStyleBackColor = false;
            // 
            // rdbQLDX_MaDX
            // 
            rdbQLDX_MaDX.AutoSize = true;
            rdbQLDX_MaDX.Location = new Point(26, 69);
            rdbQLDX_MaDX.Name = "rdbQLDX_MaDX";
            rdbQLDX_MaDX.Size = new Size(197, 41);
            rdbQLDX_MaDX.TabIndex = 0;
            rdbQLDX_MaDX.TabStop = true;
            rdbQLDX_MaDX.Text = "Mã đơn xuất";
            rdbQLDX_MaDX.UseVisualStyleBackColor = true;
            // 
            // splQLDX_CN_HT
            // 
            splQLDX_CN_HT.Dock = DockStyle.Fill;
            splQLDX_CN_HT.Location = new Point(3, 78);
            splQLDX_CN_HT.Name = "splQLDX_CN_HT";
            // 
            // splQLDX_CN_HT.Panel1
            // 
            splQLDX_CN_HT.Panel1.Controls.Add(grbQLDX_CN);
            // 
            // splQLDX_CN_HT.Panel2
            // 
            splQLDX_CN_HT.Panel2.Controls.Add(grbQLDX_HT);
            splQLDX_CN_HT.Size = new Size(1414, 597);
            splQLDX_CN_HT.SplitterDistance = 246;
            splQLDX_CN_HT.TabIndex = 3;
            // 
            // grbQLDX_CN
            // 
            grbQLDX_CN.Controls.Add(btnQLDX_Thoat);
            grbQLDX_CN.Controls.Add(btnQLDX_Export);
            grbQLDX_CN.Controls.Add(btnQLDX_Import);
            grbQLDX_CN.Controls.Add(btnQLDX_Xoa);
            grbQLDX_CN.Controls.Add(btnQLDX_Sua);
            grbQLDX_CN.Controls.Add(btnQLDX_Them);
            grbQLDX_CN.Dock = DockStyle.Fill;
            grbQLDX_CN.Location = new Point(0, 0);
            grbQLDX_CN.Name = "grbQLDX_CN";
            grbQLDX_CN.Size = new Size(246, 597);
            grbQLDX_CN.TabIndex = 0;
            grbQLDX_CN.TabStop = false;
            grbQLDX_CN.Text = "Chức năng";
            // 
            // btnQLDX_Thoat
            // 
            btnQLDX_Thoat.BackColor = Color.Red;
            btnQLDX_Thoat.FlatAppearance.BorderColor = Color.Gainsboro;
            btnQLDX_Thoat.FlatAppearance.BorderSize = 0;
            btnQLDX_Thoat.FlatStyle = FlatStyle.Flat;
            btnQLDX_Thoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDX_Thoat.ForeColor = SystemColors.ButtonHighlight;
            btnQLDX_Thoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDX_Thoat.Location = new Point(63, 509);
            btnQLDX_Thoat.Name = "btnQLDX_Thoat";
            btnQLDX_Thoat.Size = new Size(121, 67);
            btnQLDX_Thoat.TabIndex = 6;
            btnQLDX_Thoat.Text = "Thoát";
            btnQLDX_Thoat.UseVisualStyleBackColor = false;
            // 
            // btnQLDX_Export
            // 
            btnQLDX_Export.BackColor = SystemColors.ButtonHighlight;
            btnQLDX_Export.FlatAppearance.BorderSize = 0;
            btnQLDX_Export.FlatStyle = FlatStyle.Flat;
            btnQLDX_Export.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDX_Export.Location = new Point(63, 327);
            btnQLDX_Export.Name = "btnQLDX_Export";
            btnQLDX_Export.Size = new Size(121, 67);
            btnQLDX_Export.TabIndex = 4;
            btnQLDX_Export.Text = "Export";
            btnQLDX_Export.UseVisualStyleBackColor = false;
            // 
            // btnQLDX_Import
            // 
            btnQLDX_Import.BackColor = SystemColors.ButtonHighlight;
            btnQLDX_Import.FlatAppearance.BorderSize = 0;
            btnQLDX_Import.FlatStyle = FlatStyle.Flat;
            btnQLDX_Import.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDX_Import.Location = new Point(63, 418);
            btnQLDX_Import.Name = "btnQLDX_Import";
            btnQLDX_Import.Size = new Size(121, 67);
            btnQLDX_Import.TabIndex = 3;
            btnQLDX_Import.Text = "Import";
            btnQLDX_Import.UseVisualStyleBackColor = false;
            // 
            // btnQLDX_Xoa
            // 
            btnQLDX_Xoa.BackColor = SystemColors.ButtonHighlight;
            btnQLDX_Xoa.FlatAppearance.BorderSize = 0;
            btnQLDX_Xoa.FlatStyle = FlatStyle.Flat;
            btnQLDX_Xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDX_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDX_Xoa.Location = new Point(63, 236);
            btnQLDX_Xoa.Name = "btnQLDX_Xoa";
            btnQLDX_Xoa.Size = new Size(121, 67);
            btnQLDX_Xoa.TabIndex = 2;
            btnQLDX_Xoa.Text = "Xóa";
            btnQLDX_Xoa.UseVisualStyleBackColor = false;
            // 
            // btnQLDX_Sua
            // 
            btnQLDX_Sua.BackColor = SystemColors.ButtonHighlight;
            btnQLDX_Sua.FlatAppearance.BorderSize = 0;
            btnQLDX_Sua.FlatStyle = FlatStyle.Flat;
            btnQLDX_Sua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDX_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDX_Sua.Location = new Point(63, 145);
            btnQLDX_Sua.Name = "btnQLDX_Sua";
            btnQLDX_Sua.Size = new Size(121, 67);
            btnQLDX_Sua.TabIndex = 1;
            btnQLDX_Sua.Text = "Sửa";
            btnQLDX_Sua.UseVisualStyleBackColor = false;
            // 
            // btnQLDX_Them
            // 
            btnQLDX_Them.BackColor = SystemColors.ButtonHighlight;
            btnQLDX_Them.FlatAppearance.BorderSize = 0;
            btnQLDX_Them.FlatStyle = FlatStyle.Flat;
            btnQLDX_Them.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDX_Them.Image = Properties.Resources.New;
            btnQLDX_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDX_Them.Location = new Point(63, 54);
            btnQLDX_Them.Name = "btnQLDX_Them";
            btnQLDX_Them.Size = new Size(121, 67);
            btnQLDX_Them.TabIndex = 0;
            btnQLDX_Them.Text = "Thêm";
            btnQLDX_Them.UseVisualStyleBackColor = false;
            // 
            // grbQLDX_HT
            // 
            grbQLDX_HT.Controls.Add(dgvQLDX);
            grbQLDX_HT.Dock = DockStyle.Fill;
            grbQLDX_HT.Location = new Point(0, 0);
            grbQLDX_HT.Name = "grbQLDX_HT";
            grbQLDX_HT.Size = new Size(1164, 597);
            grbQLDX_HT.TabIndex = 4;
            grbQLDX_HT.TabStop = false;
            grbQLDX_HT.Text = "Hiển thị";
            // 
            // dgvQLDX
            // 
            dgvQLDX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLDX.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvQLDX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvQLDX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLDX.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvQLDX.Dock = DockStyle.Fill;
            dgvQLDX.Location = new Point(3, 39);
            dgvQLDX.Name = "dgvQLDX";
            dgvQLDX.RowHeadersWidth = 82;
            dgvQLDX.RowTemplate.Height = 41;
            dgvQLDX.Size = new Size(1158, 555);
            dgvQLDX.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã đơn xuất";
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
            Column3.HeaderText = "Tên đơn";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Ngày xuất";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            // 
            // UC_QLDonXuat
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpQLDX);
            Name = "UC_QLDonXuat";
            Size = new Size(1420, 1000);
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
        private TextBox txtQLDX_MaNV;
        private TextBox txtQLDX_MaDX;
        private Label lbQLDX_NgayXuat;
        private Label lbQLDX_TenDX;
        private Label lbQLDX_MaNV;
        private Label lbQLDX_MaDX;
        private GroupBox grbQLDX_TK;
        private TextBox txtQLDX_TK_MaNV;
        private RadioButton rdbQLDX_MaNV;
        private TextBox txtQLDX_TK_MaDX;
        private Button btnQLDX_Tim;
        private RadioButton rdbQLDX_MaDX;
        private SplitContainer splQLDX_CN_HT;
        private GroupBox grbQLDX_CN;
        private Button btnQLDX_Thoat;
        private Button btnQLDX_Export;
        private Button btnQLDX_Import;
        private Button btnQLDX_Xoa;
        private Button btnQLDX_Sua;
        private Button btnQLDX_Them;
        private GroupBox grbQLDX_HT;
        private DataGridView dgvQLDX;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
