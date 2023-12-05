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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            groupBox2 = new GroupBox();
            dtpNgayXuat = new DateTimePicker();
            txtTenDX = new TextBox();
            txtMaNV = new TextBox();
            txtMaDX = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox4 = new GroupBox();
            textBox2 = new TextBox();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
            btnSearchQLDX = new Button();
            radioButton1 = new RadioButton();
            splitContainer2 = new SplitContainer();
            groupBox3 = new GroupBox();
            btnQLDX_Back = new Button();
            btnExQLDX = new Button();
            btnImpQLDX = new Button();
            btnXoaQLDX = new Button();
            btnSuaQLDX = new Button();
            btnThemQLDX = new Button();
            groupBox1 = new GroupBox();
            dgvQLDX = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLDX).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(splitContainer1, 0, 2);
            tableLayoutPanel1.Controls.Add(splitContainer2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 603F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(1420, 1000);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1414, 69);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(570, 12);
            label1.Name = "label1";
            label1.Size = new Size(385, 50);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ ĐƠN XUẤT";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(3, 681);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox4);
            splitContainer1.Size = new Size(1414, 316);
            splitContainer1.SplitterDistance = 935;
            splitContainer1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpNgayXuat);
            groupBox2.Controls.Add(txtTenDX);
            groupBox2.Controls.Add(txtMaNV);
            groupBox2.Controls.Add(txtMaDX);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(935, 316);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // dtpNgayXuat
            // 
            dtpNgayXuat.CustomFormat = "dd/MM/yyyy";
            dtpNgayXuat.Format = DateTimePickerFormat.Custom;
            dtpNgayXuat.Location = new Point(611, 69);
            dtpNgayXuat.Name = "dtpNgayXuat";
            dtpNgayXuat.Size = new Size(291, 39);
            dtpNgayXuat.TabIndex = 7;
            dtpNgayXuat.Value = new DateTime(2023, 11, 27, 12, 53, 49, 0);
            // 
            // txtTenDX
            // 
            txtTenDX.Location = new Point(611, 168);
            txtTenDX.Multiline = true;
            txtTenDX.Name = "txtTenDX";
            txtTenDX.Size = new Size(291, 109);
            txtTenDX.TabIndex = 6;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(186, 168);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(229, 39);
            txtMaNV.TabIndex = 5;
            // 
            // txtMaDX
            // 
            txtMaDX.Location = new Point(186, 69);
            txtMaDX.Name = "txtMaDX";
            txtMaDX.Size = new Size(229, 39);
            txtMaDX.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(457, 69);
            label5.Name = "label5";
            label5.Size = new Size(122, 32);
            label5.TabIndex = 3;
            label5.Text = "Ngày xuất";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(457, 168);
            label4.Name = "label4";
            label4.Size = new Size(108, 32);
            label4.TabIndex = 2;
            label4.Text = "Tên đơn ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 168);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 1;
            label3.Text = "Mã NV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 69);
            label2.Name = "label2";
            label2.Size = new Size(149, 32);
            label2.TabIndex = 0;
            label2.Text = "Mã đơn xuất";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(radioButton2);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(btnSearchQLDX);
            groupBox4.Controls.Add(radioButton1);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(475, 316);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(240, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 39);
            textBox2.TabIndex = 3;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(26, 164);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(192, 36);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mã nhân viên";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 39);
            textBox1.TabIndex = 1;
            // 
            // btnSearchQLDX
            // 
            btnSearchQLDX.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchQLDX.Location = new Point(301, 242);
            btnSearchQLDX.Name = "btnSearchQLDX";
            btnSearchQLDX.Size = new Size(150, 46);
            btnSearchQLDX.TabIndex = 3;
            btnSearchQLDX.Text = "Tìm kiếm";
            btnSearchQLDX.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(26, 69);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(180, 36);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Mã đơn xuất";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 78);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(groupBox1);
            splitContainer2.Size = new Size(1414, 597);
            splitContainer2.SplitterDistance = 246;
            splitContainer2.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnQLDX_Back);
            groupBox3.Controls.Add(btnExQLDX);
            groupBox3.Controls.Add(btnImpQLDX);
            groupBox3.Controls.Add(btnXoaQLDX);
            groupBox3.Controls.Add(btnSuaQLDX);
            groupBox3.Controls.Add(btnThemQLDX);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(246, 597);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnQLDX_Back
            // 
            btnQLDX_Back.BackColor = Color.Red;
            btnQLDX_Back.FlatAppearance.BorderColor = Color.Gainsboro;
            btnQLDX_Back.FlatAppearance.BorderSize = 2;
            btnQLDX_Back.FlatStyle = FlatStyle.Popup;
            btnQLDX_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDX_Back.ForeColor = SystemColors.ButtonHighlight;
            btnQLDX_Back.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDX_Back.Location = new Point(42, 526);
            btnQLDX_Back.Name = "btnQLDX_Back";
            btnQLDX_Back.Size = new Size(150, 46);
            btnQLDX_Back.TabIndex = 6;
            btnQLDX_Back.Text = "Thoát";
            btnQLDX_Back.UseVisualStyleBackColor = false;
            // 
            // btnExQLDX
            // 
            btnExQLDX.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExQLDX.Location = new Point(42, 344);
            btnExQLDX.Name = "btnExQLDX";
            btnExQLDX.Size = new Size(150, 46);
            btnExQLDX.TabIndex = 4;
            btnExQLDX.Text = "Export";
            btnExQLDX.UseVisualStyleBackColor = true;
            // 
            // btnImpQLDX
            // 
            btnImpQLDX.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnImpQLDX.Location = new Point(42, 435);
            btnImpQLDX.Name = "btnImpQLDX";
            btnImpQLDX.Size = new Size(150, 46);
            btnImpQLDX.TabIndex = 3;
            btnImpQLDX.Text = "Import";
            btnImpQLDX.UseVisualStyleBackColor = true;
            // 
            // btnXoaQLDX
            // 
            btnXoaQLDX.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoaQLDX.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaQLDX.Location = new Point(42, 253);
            btnXoaQLDX.Name = "btnXoaQLDX";
            btnXoaQLDX.Size = new Size(150, 46);
            btnXoaQLDX.TabIndex = 2;
            btnXoaQLDX.Text = "Xóa";
            btnXoaQLDX.UseVisualStyleBackColor = true;
            // 
            // btnSuaQLDX
            // 
            btnSuaQLDX.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuaQLDX.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuaQLDX.Location = new Point(42, 162);
            btnSuaQLDX.Name = "btnSuaQLDX";
            btnSuaQLDX.Size = new Size(150, 46);
            btnSuaQLDX.TabIndex = 1;
            btnSuaQLDX.Text = "Sửa";
            btnSuaQLDX.UseVisualStyleBackColor = true;
            // 
            // btnThemQLDX
            // 
            btnThemQLDX.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemQLDX.Image = Properties.Resources.New;
            btnThemQLDX.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemQLDX.Location = new Point(42, 71);
            btnThemQLDX.Name = "btnThemQLDX";
            btnThemQLDX.Size = new Size(150, 46);
            btnThemQLDX.TabIndex = 0;
            btnThemQLDX.Text = "Thêm";
            btnThemQLDX.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvQLDX);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1164, 597);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hiển thị";
            // 
            // dgvQLDX
            // 
            dgvQLDX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLDX.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvQLDX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvQLDX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLDX.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvQLDX.Dock = DockStyle.Fill;
            dgvQLDX.Location = new Point(3, 35);
            dgvQLDX.Name = "dgvQLDX";
            dgvQLDX.RowHeadersWidth = 82;
            dgvQLDX.RowTemplate.Height = 41;
            dgvQLDX.Size = new Size(1158, 559);
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
            Controls.Add(tableLayoutPanel1);
            Name = "UC_QLDonXuat";
            Size = new Size(1420, 1000);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLDX).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private DateTimePicker dtpNgayXuat;
        private TextBox txtTenDX;
        private TextBox txtMaNV;
        private TextBox txtMaDX;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox4;
        private TextBox textBox2;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private Button btnSearchQLDX;
        private RadioButton radioButton1;
        private SplitContainer splitContainer2;
        private GroupBox groupBox3;
        private Button btnQLDX_Back;
        private Button btnExQLDX;
        private Button btnImpQLDX;
        private Button btnXoaQLDX;
        private Button btnSuaQLDX;
        private Button btnThemQLDX;
        private GroupBox groupBox1;
        private DataGridView dgvQLDX;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
