﻿namespace FormQLKH
{
    partial class UC_QLChiNhanh
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tlpQLCN = new TableLayoutPanel();
            pnQLCN = new Panel();
            lbQLCN = new Label();
            splQLCN_HT_CN = new SplitContainer();
            grbQLCN_HT = new GroupBox();
            dgvQLCN = new DataGridView();
            MaCN = new DataGridViewTextBoxColumn();
            TenCN = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            grbQLCN_CN = new GroupBox();
            btnQLCN_Them = new Button();
            btnQLCN_Export = new Button();
            btnQLCN_Sua = new Button();
            btnQLCN_Import = new Button();
            btnQLCN_Xoa = new Button();
            splQLCN_TK_TT = new SplitContainer();
            grbQLCN_TK = new GroupBox();
            lbQLCN_TK_MaCN = new Label();
            txtQLCN_TK_MaCN = new TextBox();
            grbQLCN_TT = new GroupBox();
            txtQLCN_TenCN = new TextBox();
            txtQLCN_DiaChi = new TextBox();
            txtQLCN_MaCN = new TextBox();
            lbQLCN_DiaChi = new Label();
            lbQLCN_TenCN = new Label();
            lbQLCN_MaCN = new Label();
            tlpQLCN.SuspendLayout();
            pnQLCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splQLCN_HT_CN).BeginInit();
            splQLCN_HT_CN.Panel1.SuspendLayout();
            splQLCN_HT_CN.Panel2.SuspendLayout();
            splQLCN_HT_CN.SuspendLayout();
            grbQLCN_HT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLCN).BeginInit();
            grbQLCN_CN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splQLCN_TK_TT).BeginInit();
            splQLCN_TK_TT.Panel1.SuspendLayout();
            splQLCN_TK_TT.Panel2.SuspendLayout();
            splQLCN_TK_TT.SuspendLayout();
            grbQLCN_TK.SuspendLayout();
            grbQLCN_TT.SuspendLayout();
            SuspendLayout();
            // 
            // tlpQLCN
            // 
            tlpQLCN.BackColor = SystemColors.Control;
            tlpQLCN.ColumnCount = 1;
            tlpQLCN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpQLCN.Controls.Add(pnQLCN, 0, 0);
            tlpQLCN.Controls.Add(splQLCN_HT_CN, 0, 1);
            tlpQLCN.Controls.Add(splQLCN_TK_TT, 0, 2);
            tlpQLCN.Dock = DockStyle.Fill;
            tlpQLCN.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            tlpQLCN.Location = new Point(0, 0);
            tlpQLCN.Name = "tlpQLCN";
            tlpQLCN.RowCount = 3;
            tlpQLCN.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tlpQLCN.RowStyles.Add(new RowStyle(SizeType.Absolute, 769F));
            tlpQLCN.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tlpQLCN.Size = new Size(1448, 1082);
            tlpQLCN.TabIndex = 1;
            // 
            // pnQLCN
            // 
            pnQLCN.BackColor = Color.FromArgb(15, 142, 219);
            pnQLCN.Controls.Add(lbQLCN);
            pnQLCN.Dock = DockStyle.Fill;
            pnQLCN.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            pnQLCN.Location = new Point(3, 3);
            pnQLCN.Name = "pnQLCN";
            pnQLCN.Size = new Size(1442, 78);
            pnQLCN.TabIndex = 0;
            // 
            // lbQLCN
            // 
            lbQLCN.AutoSize = true;
            lbQLCN.ForeColor = SystemColors.ButtonHighlight;
            lbQLCN.Location = new Point(552, 18);
            lbQLCN.Name = "lbQLCN";
            lbQLCN.Size = new Size(404, 50);
            lbQLCN.TabIndex = 0;
            lbQLCN.Text = "QUẢN LÝ CHI NHÁNH";
            // 
            // splQLCN_HT_CN
            // 
            splQLCN_HT_CN.BackColor = Color.Transparent;
            splQLCN_HT_CN.BackgroundImage = Properties.Resources.bg;
            splQLCN_HT_CN.Dock = DockStyle.Fill;
            splQLCN_HT_CN.Location = new Point(3, 87);
            splQLCN_HT_CN.Name = "splQLCN_HT_CN";
            // 
            // splQLCN_HT_CN.Panel1
            // 
            splQLCN_HT_CN.Panel1.Controls.Add(grbQLCN_HT);
            // 
            // splQLCN_HT_CN.Panel2
            // 
            splQLCN_HT_CN.Panel2.Controls.Add(grbQLCN_CN);
            splQLCN_HT_CN.Size = new Size(1442, 763);
            splQLCN_HT_CN.SplitterDistance = 1183;
            splQLCN_HT_CN.TabIndex = 1;
            // 
            // grbQLCN_HT
            // 
            grbQLCN_HT.Controls.Add(dgvQLCN);
            grbQLCN_HT.Dock = DockStyle.Fill;
            grbQLCN_HT.Location = new Point(0, 0);
            grbQLCN_HT.Name = "grbQLCN_HT";
            grbQLCN_HT.Size = new Size(1183, 763);
            grbQLCN_HT.TabIndex = 0;
            grbQLCN_HT.TabStop = false;
            grbQLCN_HT.Text = "Hiển thị";
            // 
            // dgvQLCN
            // 
            dgvQLCN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLCN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvQLCN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvQLCN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLCN.Columns.AddRange(new DataGridViewColumn[] { MaCN, TenCN, DiaChi });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvQLCN.DefaultCellStyle = dataGridViewCellStyle4;
            dgvQLCN.Dock = DockStyle.Fill;
            dgvQLCN.Location = new Point(3, 39);
            dgvQLCN.Name = "dgvQLCN";
            dgvQLCN.RowHeadersWidth = 82;
            dgvQLCN.RowTemplate.Height = 41;
            dgvQLCN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQLCN.Size = new Size(1177, 721);
            dgvQLCN.TabIndex = 0;
            dgvQLCN.RowPostPaint += dgvQLCN_RowPostPaint;
            dgvQLCN.SelectionChanged += dgvQLCN_SelectionChanged;
            // 
            // MaCN
            // 
            MaCN.DataPropertyName = "CN_ID";
            MaCN.HeaderText = "Mã CN";
            MaCN.MinimumWidth = 10;
            MaCN.Name = "MaCN";
            // 
            // TenCN
            // 
            TenCN.DataPropertyName = "CN_Name";
            TenCN.HeaderText = "Tên CN";
            TenCN.MinimumWidth = 10;
            TenCN.Name = "TenCN";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "CN_Address";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 10;
            DiaChi.Name = "DiaChi";
            // 
            // grbQLCN_CN
            // 
            grbQLCN_CN.Controls.Add(btnQLCN_Them);
            grbQLCN_CN.Controls.Add(btnQLCN_Export);
            grbQLCN_CN.Controls.Add(btnQLCN_Sua);
            grbQLCN_CN.Controls.Add(btnQLCN_Import);
            grbQLCN_CN.Controls.Add(btnQLCN_Xoa);
            grbQLCN_CN.Dock = DockStyle.Fill;
            grbQLCN_CN.Location = new Point(0, 0);
            grbQLCN_CN.Name = "grbQLCN_CN";
            grbQLCN_CN.Size = new Size(255, 763);
            grbQLCN_CN.TabIndex = 0;
            grbQLCN_CN.TabStop = false;
            grbQLCN_CN.Text = "Chức năng";
            // 
            // btnQLCN_Them
            // 
            btnQLCN_Them.BackColor = SystemColors.ButtonHighlight;
            btnQLCN_Them.FlatAppearance.BorderColor = Color.White;
            btnQLCN_Them.FlatAppearance.BorderSize = 0;
            btnQLCN_Them.FlatAppearance.MouseOverBackColor = Color.White;
            btnQLCN_Them.FlatStyle = FlatStyle.Popup;
            btnQLCN_Them.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLCN_Them.Image = Properties.Resources.add;
            btnQLCN_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLCN_Them.Location = new Point(32, 55);
            btnQLCN_Them.Name = "btnQLCN_Them";
            btnQLCN_Them.Size = new Size(182, 58);
            btnQLCN_Them.TabIndex = 6;
            btnQLCN_Them.Text = "Thêm";
            btnQLCN_Them.UseVisualStyleBackColor = false;
            btnQLCN_Them.Click += btnQLCN_Them_Click;
            // 
            // btnQLCN_Export
            // 
            btnQLCN_Export.BackColor = SystemColors.ButtonHighlight;
            btnQLCN_Export.FlatAppearance.BorderSize = 0;
            btnQLCN_Export.FlatStyle = FlatStyle.Popup;
            btnQLCN_Export.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLCN_Export.Image = Properties.Resources.export;
            btnQLCN_Export.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLCN_Export.Location = new Point(32, 660);
            btnQLCN_Export.Name = "btnQLCN_Export";
            btnQLCN_Export.Size = new Size(182, 58);
            btnQLCN_Export.TabIndex = 10;
            btnQLCN_Export.Text = "Export";
            btnQLCN_Export.UseVisualStyleBackColor = false;
            // 
            // btnQLCN_Sua
            // 
            btnQLCN_Sua.BackColor = SystemColors.ButtonHighlight;
            btnQLCN_Sua.FlatAppearance.BorderSize = 0;
            btnQLCN_Sua.FlatStyle = FlatStyle.Popup;
            btnQLCN_Sua.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLCN_Sua.Image = Properties.Resources.update;
            btnQLCN_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLCN_Sua.Location = new Point(32, 206);
            btnQLCN_Sua.Name = "btnQLCN_Sua";
            btnQLCN_Sua.Size = new Size(182, 58);
            btnQLCN_Sua.TabIndex = 7;
            btnQLCN_Sua.Text = "Sửa";
            btnQLCN_Sua.UseVisualStyleBackColor = false;
            btnQLCN_Sua.Click += btnQLCN_Sua_Click;
            // 
            // btnQLCN_Import
            // 
            btnQLCN_Import.BackColor = SystemColors.ButtonHighlight;
            btnQLCN_Import.FlatAppearance.BorderSize = 0;
            btnQLCN_Import.FlatStyle = FlatStyle.Popup;
            btnQLCN_Import.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLCN_Import.Image = Properties.Resources.import;
            btnQLCN_Import.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLCN_Import.Location = new Point(32, 509);
            btnQLCN_Import.Name = "btnQLCN_Import";
            btnQLCN_Import.Size = new Size(182, 58);
            btnQLCN_Import.TabIndex = 9;
            btnQLCN_Import.Text = "Import";
            btnQLCN_Import.UseVisualStyleBackColor = false;
            // 
            // btnQLCN_Xoa
            // 
            btnQLCN_Xoa.BackColor = SystemColors.ButtonHighlight;
            btnQLCN_Xoa.FlatAppearance.BorderSize = 0;
            btnQLCN_Xoa.FlatStyle = FlatStyle.Popup;
            btnQLCN_Xoa.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLCN_Xoa.Image = Properties.Resources.delete;
            btnQLCN_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLCN_Xoa.Location = new Point(32, 358);
            btnQLCN_Xoa.Name = "btnQLCN_Xoa";
            btnQLCN_Xoa.Size = new Size(182, 58);
            btnQLCN_Xoa.TabIndex = 8;
            btnQLCN_Xoa.Text = "Xóa";
            btnQLCN_Xoa.UseVisualStyleBackColor = false;
            btnQLCN_Xoa.Click += btnQLCN_Xoa_Click;
            // 
            // splQLCN_TK_TT
            // 
            splQLCN_TK_TT.BackgroundImage = Properties.Resources.bg;
            splQLCN_TK_TT.Dock = DockStyle.Bottom;
            splQLCN_TK_TT.Location = new Point(3, 856);
            splQLCN_TK_TT.Name = "splQLCN_TK_TT";
            // 
            // splQLCN_TK_TT.Panel1
            // 
            splQLCN_TK_TT.Panel1.BackColor = Color.Transparent;
            splQLCN_TK_TT.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splQLCN_TK_TT.Panel1.Controls.Add(grbQLCN_TK);
            // 
            // splQLCN_TK_TT.Panel2
            // 
            splQLCN_TK_TT.Panel2.BackColor = Color.Transparent;
            splQLCN_TK_TT.Panel2.Controls.Add(grbQLCN_TT);
            splQLCN_TK_TT.Size = new Size(1442, 223);
            splQLCN_TK_TT.SplitterDistance = 440;
            splQLCN_TK_TT.TabIndex = 2;
            // 
            // grbQLCN_TK
            // 
            grbQLCN_TK.BackColor = Color.Transparent;
            grbQLCN_TK.Controls.Add(lbQLCN_TK_MaCN);
            grbQLCN_TK.Controls.Add(txtQLCN_TK_MaCN);
            grbQLCN_TK.Dock = DockStyle.Fill;
            grbQLCN_TK.Location = new Point(0, 0);
            grbQLCN_TK.Name = "grbQLCN_TK";
            grbQLCN_TK.Size = new Size(440, 223);
            grbQLCN_TK.TabIndex = 0;
            grbQLCN_TK.TabStop = false;
            grbQLCN_TK.Text = "Tìm kiếm";
            // 
            // lbQLCN_TK_MaCN
            // 
            lbQLCN_TK_MaCN.AutoSize = true;
            lbQLCN_TK_MaCN.BackColor = SystemColors.Control;
            lbQLCN_TK_MaCN.BorderStyle = BorderStyle.Fixed3D;
            lbQLCN_TK_MaCN.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLCN_TK_MaCN.Location = new Point(60, 61);
            lbQLCN_TK_MaCN.Name = "lbQLCN_TK_MaCN";
            lbQLCN_TK_MaCN.Size = new Size(103, 39);
            lbQLCN_TK_MaCN.TabIndex = 3;
            lbQLCN_TK_MaCN.Text = "Mã CN";
            // 
            // txtQLCN_TK_MaCN
            // 
            txtQLCN_TK_MaCN.Location = new Point(60, 124);
            txtQLCN_TK_MaCN.Multiline = true;
            txtQLCN_TK_MaCN.Name = "txtQLCN_TK_MaCN";
            txtQLCN_TK_MaCN.Size = new Size(320, 51);
            txtQLCN_TK_MaCN.TabIndex = 2;
            txtQLCN_TK_MaCN.TextChanged += txtQLCN_TK_MaCN_TextChanged;
            // 
            // grbQLCN_TT
            // 
            grbQLCN_TT.BackColor = Color.Transparent;
            grbQLCN_TT.Controls.Add(txtQLCN_TenCN);
            grbQLCN_TT.Controls.Add(txtQLCN_DiaChi);
            grbQLCN_TT.Controls.Add(txtQLCN_MaCN);
            grbQLCN_TT.Controls.Add(lbQLCN_DiaChi);
            grbQLCN_TT.Controls.Add(lbQLCN_TenCN);
            grbQLCN_TT.Controls.Add(lbQLCN_MaCN);
            grbQLCN_TT.Dock = DockStyle.Fill;
            grbQLCN_TT.Location = new Point(0, 0);
            grbQLCN_TT.Name = "grbQLCN_TT";
            grbQLCN_TT.Size = new Size(998, 223);
            grbQLCN_TT.TabIndex = 0;
            grbQLCN_TT.TabStop = false;
            grbQLCN_TT.Text = "Thông tin";
            // 
            // txtQLCN_TenCN
            // 
            txtQLCN_TenCN.Location = new Point(149, 134);
            txtQLCN_TenCN.Multiline = true;
            txtQLCN_TenCN.Name = "txtQLCN_TenCN";
            txtQLCN_TenCN.Size = new Size(251, 62);
            txtQLCN_TenCN.TabIndex = 6;
            // 
            // txtQLCN_DiaChi
            // 
            txtQLCN_DiaChi.Location = new Point(612, 50);
            txtQLCN_DiaChi.Multiline = true;
            txtQLCN_DiaChi.Name = "txtQLCN_DiaChi";
            txtQLCN_DiaChi.Size = new Size(331, 146);
            txtQLCN_DiaChi.TabIndex = 5;
            // 
            // txtQLCN_MaCN
            // 
            txtQLCN_MaCN.Location = new Point(149, 55);
            txtQLCN_MaCN.Name = "txtQLCN_MaCN";
            txtQLCN_MaCN.ReadOnly = true;
            txtQLCN_MaCN.Size = new Size(251, 43);
            txtQLCN_MaCN.TabIndex = 4;
            // 
            // lbQLCN_DiaChi
            // 
            lbQLCN_DiaChi.AutoSize = true;
            lbQLCN_DiaChi.BackColor = SystemColors.Control;
            lbQLCN_DiaChi.BorderStyle = BorderStyle.Fixed3D;
            lbQLCN_DiaChi.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLCN_DiaChi.Location = new Point(480, 61);
            lbQLCN_DiaChi.Name = "lbQLCN_DiaChi";
            lbQLCN_DiaChi.Size = new Size(102, 39);
            lbQLCN_DiaChi.TabIndex = 3;
            lbQLCN_DiaChi.Text = "Địa chỉ";
            // 
            // lbQLCN_TenCN
            // 
            lbQLCN_TenCN.AutoSize = true;
            lbQLCN_TenCN.BackColor = SystemColors.Control;
            lbQLCN_TenCN.BorderStyle = BorderStyle.Fixed3D;
            lbQLCN_TenCN.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLCN_TenCN.Location = new Point(24, 140);
            lbQLCN_TenCN.Name = "lbQLCN_TenCN";
            lbQLCN_TenCN.Size = new Size(106, 39);
            lbQLCN_TenCN.TabIndex = 2;
            lbQLCN_TenCN.Text = "Tên CN";
            // 
            // lbQLCN_MaCN
            // 
            lbQLCN_MaCN.AutoSize = true;
            lbQLCN_MaCN.BackColor = SystemColors.Control;
            lbQLCN_MaCN.BorderStyle = BorderStyle.Fixed3D;
            lbQLCN_MaCN.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbQLCN_MaCN.Location = new Point(26, 55);
            lbQLCN_MaCN.Name = "lbQLCN_MaCN";
            lbQLCN_MaCN.Size = new Size(103, 39);
            lbQLCN_MaCN.TabIndex = 0;
            lbQLCN_MaCN.Text = "Mã CN";
            // 
            // UC_QLChiNhanh
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpQLCN);
            Name = "UC_QLChiNhanh";
            Size = new Size(1448, 1082);
            Load += UC_QLChiNhanh_Load;
            tlpQLCN.ResumeLayout(false);
            pnQLCN.ResumeLayout(false);
            pnQLCN.PerformLayout();
            splQLCN_HT_CN.Panel1.ResumeLayout(false);
            splQLCN_HT_CN.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLCN_HT_CN).EndInit();
            splQLCN_HT_CN.ResumeLayout(false);
            grbQLCN_HT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLCN).EndInit();
            grbQLCN_CN.ResumeLayout(false);
            splQLCN_TK_TT.Panel1.ResumeLayout(false);
            splQLCN_TK_TT.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splQLCN_TK_TT).EndInit();
            splQLCN_TK_TT.ResumeLayout(false);
            grbQLCN_TK.ResumeLayout(false);
            grbQLCN_TK.PerformLayout();
            grbQLCN_TT.ResumeLayout(false);
            grbQLCN_TT.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpQLCN;
        private Panel pnQLCN;
        private Label lbQLCN;
        private SplitContainer splQLCN_HT_CN;
        private GroupBox grbQLCN_HT;
        internal DataGridView dgvQLCN;
        private GroupBox grbQLCN_CN;
        private SplitContainer splQLCN_TK_TT;
        private GroupBox grbQLCN_TK;
        private TextBox txtQLCN_TK_MaCN;
        private GroupBox grbQLCN_TT;
        private TextBox txtQLCN_TenCN;
        private TextBox txtQLCN_DiaChi;
        private TextBox txtQLCN_MaCN;
        private Label lbQLCN_DiaChi;
        private Label lbQLCN_TenCN;
        private Label lbQLCN_MaCN;
        private Button btnQLCN_Them;
        private Button btnQLCN_Export;
        private Button btnQLCN_Sua;
        private Button btnQLCN_Import;
        private Button btnQLCN_Xoa;
        private Label lbQLCN_TK_MaCN;
        private DataGridViewTextBoxColumn MaCN;
        private DataGridViewTextBoxColumn TenCN;
        private DataGridViewTextBoxColumn DiaChi;
    }
}
