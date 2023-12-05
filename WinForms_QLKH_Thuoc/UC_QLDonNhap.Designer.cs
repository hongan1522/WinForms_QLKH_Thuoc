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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            label1 = new Label();
            groupBox3 = new GroupBox();
            dgvQLDN = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            splitContainer1 = new SplitContainer();
            groupBox4 = new GroupBox();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            btnSearchQLDN = new Button();
            groupBox2 = new GroupBox();
            btnQLDN_Back = new Button();
            btnExQLDN = new Button();
            btnImpQLDN = new Button();
            btnXoaQLDN = new Button();
            btnSuaQLDN = new Button();
            btnThemQLDN = new Button();
            textBox2 = new TextBox();
            radioButton2 = new RadioButton();
            dtpNgayNhapHang = new DateTimePicker();
            txtNote = new TextBox();
            txtTenDN = new TextBox();
            txtMaDN = new TextBox();
            txtMaThuoc = new TextBox();
            txtMaNV = new TextBox();
            txtMaNCC = new TextBox();
            txtMaLo = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLDN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(splitContainer1, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 354F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 311F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(1420, 1000);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgayNhapHang);
            groupBox1.Controls.Add(txtNote);
            groupBox1.Controls.Add(txtTenDN);
            groupBox1.Controls.Add(txtMaDN);
            groupBox1.Controls.Add(txtMaThuoc);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(txtMaNCC);
            groupBox1.Controls.Add(txtMaLo);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 435);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1414, 305);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1414, 72);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(536, 18);
            label1.Name = "label1";
            label1.Size = new Size(348, 39);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ ĐƠN NHẬP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvQLDN);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 81);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1414, 348);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hiển thị";
            // 
            // dgvQLDN
            // 
            dgvQLDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLDN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvQLDN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvQLDN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLDN.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column6, Column3, Column4, Column5, Column7, Column8 });
            dgvQLDN.Dock = DockStyle.Fill;
            dgvQLDN.Location = new Point(3, 35);
            dgvQLDN.Name = "dgvQLDN";
            dgvQLDN.RowHeadersWidth = 82;
            dgvQLDN.RowTemplate.Height = 41;
            dgvQLDN.Size = new Size(1408, 310);
            dgvQLDN.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã đơn nhập";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã lô";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            // 
            // Column6
            // 
            Column6.HeaderText = "Mã thuốc";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            // 
            // Column3
            // 
            Column3.HeaderText = "Mã NV";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Mã NCC";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Tên đơn";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            // 
            // Column7
            // 
            Column7.HeaderText = "Ngày nhập ";
            Column7.MinimumWidth = 10;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Ghi chú";
            Column8.MinimumWidth = 10;
            Column8.Name = "Column8";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 746);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(1414, 251);
            splitContainer1.SplitterDistance = 673;
            splitContainer1.TabIndex = 8;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(radioButton2);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(radioButton1);
            groupBox4.Controls.Add(btnSearchQLDN);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(673, 251);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(310, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 39);
            textBox1.TabIndex = 14;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(58, 49);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(189, 36);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Mã đơn nhập";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnSearchQLDN
            // 
            btnSearchQLDN.BackColor = SystemColors.MenuBar;
            btnSearchQLDN.FlatAppearance.BorderColor = Color.Gainsboro;
            btnSearchQLDN.FlatAppearance.BorderSize = 2;
            btnSearchQLDN.FlatStyle = FlatStyle.Popup;
            btnSearchQLDN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchQLDN.Location = new Point(496, 182);
            btnSearchQLDN.Name = "btnSearchQLDN";
            btnSearchQLDN.Size = new Size(150, 46);
            btnSearchQLDN.TabIndex = 9;
            btnSearchQLDN.Text = "Tìm kiếm";
            btnSearchQLDN.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnQLDN_Back);
            groupBox2.Controls.Add(btnExQLDN);
            groupBox2.Controls.Add(btnImpQLDN);
            groupBox2.Controls.Add(btnXoaQLDN);
            groupBox2.Controls.Add(btnSuaQLDN);
            groupBox2.Controls.Add(btnThemQLDN);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(737, 251);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnQLDN_Back
            // 
            btnQLDN_Back.BackColor = Color.Red;
            btnQLDN_Back.FlatAppearance.BorderColor = Color.Gainsboro;
            btnQLDN_Back.FlatAppearance.BorderSize = 2;
            btnQLDN_Back.FlatStyle = FlatStyle.Popup;
            btnQLDN_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDN_Back.ForeColor = SystemColors.ButtonHighlight;
            btnQLDN_Back.Image = Properties.Resources.Logout;
            btnQLDN_Back.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDN_Back.Location = new Point(544, 168);
            btnQLDN_Back.Name = "btnQLDN_Back";
            btnQLDN_Back.Size = new Size(150, 46);
            btnQLDN_Back.TabIndex = 6;
            btnQLDN_Back.Text = "Thoát";
            btnQLDN_Back.UseVisualStyleBackColor = false;
            // 
            // btnExQLDN
            // 
            btnExQLDN.BackColor = SystemColors.MenuBar;
            btnExQLDN.FlatAppearance.BorderColor = Color.Gainsboro;
            btnExQLDN.FlatAppearance.BorderSize = 2;
            btnExQLDN.FlatStyle = FlatStyle.Popup;
            btnExQLDN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExQLDN.Location = new Point(544, 72);
            btnExQLDN.Name = "btnExQLDN";
            btnExQLDN.Size = new Size(150, 46);
            btnExQLDN.TabIndex = 4;
            btnExQLDN.Text = "Export";
            btnExQLDN.UseVisualStyleBackColor = false;
            // 
            // btnImpQLDN
            // 
            btnImpQLDN.BackColor = SystemColors.MenuBar;
            btnImpQLDN.FlatAppearance.BorderColor = Color.Gainsboro;
            btnImpQLDN.FlatAppearance.BorderSize = 2;
            btnImpQLDN.FlatStyle = FlatStyle.Popup;
            btnImpQLDN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnImpQLDN.Location = new Point(308, 168);
            btnImpQLDN.Name = "btnImpQLDN";
            btnImpQLDN.Size = new Size(150, 46);
            btnImpQLDN.TabIndex = 3;
            btnImpQLDN.Text = "Import";
            btnImpQLDN.UseVisualStyleBackColor = false;
            // 
            // btnXoaQLDN
            // 
            btnXoaQLDN.BackColor = SystemColors.MenuBar;
            btnXoaQLDN.FlatAppearance.BorderColor = Color.Gainsboro;
            btnXoaQLDN.FlatAppearance.BorderSize = 2;
            btnXoaQLDN.FlatStyle = FlatStyle.Popup;
            btnXoaQLDN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoaQLDN.Image = Properties.Resources.Delete;
            btnXoaQLDN.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaQLDN.Location = new Point(308, 72);
            btnXoaQLDN.Name = "btnXoaQLDN";
            btnXoaQLDN.Size = new Size(150, 46);
            btnXoaQLDN.TabIndex = 2;
            btnXoaQLDN.Text = "Xóa";
            btnXoaQLDN.UseVisualStyleBackColor = false;
            // 
            // btnSuaQLDN
            // 
            btnSuaQLDN.BackColor = SystemColors.MenuBar;
            btnSuaQLDN.FlatAppearance.BorderColor = Color.Gainsboro;
            btnSuaQLDN.FlatAppearance.BorderSize = 2;
            btnSuaQLDN.FlatStyle = FlatStyle.Popup;
            btnSuaQLDN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuaQLDN.Image = Properties.Resources.Edit;
            btnSuaQLDN.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuaQLDN.Location = new Point(41, 168);
            btnSuaQLDN.Name = "btnSuaQLDN";
            btnSuaQLDN.Size = new Size(150, 46);
            btnSuaQLDN.TabIndex = 1;
            btnSuaQLDN.Text = "Sửa";
            btnSuaQLDN.UseVisualStyleBackColor = false;
            // 
            // btnThemQLDN
            // 
            btnThemQLDN.BackColor = SystemColors.MenuBar;
            btnThemQLDN.FlatAppearance.BorderColor = Color.Gainsboro;
            btnThemQLDN.FlatAppearance.BorderSize = 2;
            btnThemQLDN.FlatStyle = FlatStyle.Popup;
            btnThemQLDN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemQLDN.Image = Properties.Resources.New;
            btnThemQLDN.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemQLDN.Location = new Point(41, 72);
            btnThemQLDN.Name = "btnThemQLDN";
            btnThemQLDN.Size = new Size(150, 46);
            btnThemQLDN.TabIndex = 0;
            btnThemQLDN.Text = "Thêm";
            btnThemQLDN.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(313, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(333, 39);
            textBox2.TabIndex = 16;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(61, 119);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(192, 36);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mã nhân viên";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // dtpNgayNhapHang
            // 
            dtpNgayNhapHang.CustomFormat = "dd/MM/yyyy";
            dtpNgayNhapHang.Format = DateTimePickerFormat.Custom;
            dtpNgayNhapHang.Location = new Point(950, 164);
            dtpNgayNhapHang.Name = "dtpNgayNhapHang";
            dtpNgayNhapHang.Size = new Size(400, 39);
            dtpNgayNhapHang.TabIndex = 32;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(950, 231);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(400, 64);
            txtNote.TabIndex = 31;
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(950, 97);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(400, 39);
            txtTenDN.TabIndex = 30;
            // 
            // txtMaDN
            // 
            txtMaDN.Location = new Point(319, 35);
            txtMaDN.Name = "txtMaDN";
            txtMaDN.Size = new Size(289, 39);
            txtMaDN.TabIndex = 29;
            // 
            // txtMaThuoc
            // 
            txtMaThuoc.Location = new Point(319, 235);
            txtMaThuoc.Name = "txtMaThuoc";
            txtMaThuoc.Size = new Size(289, 39);
            txtMaThuoc.TabIndex = 28;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(319, 99);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(289, 39);
            txtMaNV.TabIndex = 27;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(319, 169);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(289, 39);
            txtMaNCC.TabIndex = 26;
            // 
            // txtMaLo
            // 
            txtMaLo.Location = new Point(949, 31);
            txtMaLo.Name = "txtMaLo";
            txtMaLo.Size = new Size(402, 39);
            txtMaLo.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(715, 232);
            label9.Name = "label9";
            label9.Size = new Size(96, 32);
            label9.TabIndex = 24;
            label9.Text = "Ghi chú";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(715, 166);
            label8.Name = "label8";
            label8.Size = new Size(192, 32);
            label8.TabIndex = 23;
            label8.Text = "Ngày nhập hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(715, 100);
            label7.Name = "label7";
            label7.Size = new Size(162, 32);
            label7.TabIndex = 22;
            label7.Text = "Tên đơn nhập";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(715, 34);
            label6.Name = "label6";
            label6.Size = new Size(75, 32);
            label6.TabIndex = 21;
            label6.Text = "Mã lô";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 246);
            label5.Name = "label5";
            label5.Size = new Size(116, 32);
            label5.TabIndex = 20;
            label5.Text = "Mã thuốc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 176);
            label4.Name = "label4";
            label4.Size = new Size(199, 32);
            label4.TabIndex = 19;
            label4.Text = "Mã nhà cung cấp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 106);
            label3.Name = "label3";
            label3.Size = new Size(161, 32);
            label3.TabIndex = 18;
            label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 36);
            label2.Name = "label2";
            label2.Size = new Size(158, 32);
            label2.TabIndex = 17;
            label2.Text = "Mã đơn nhập";
            // 
            // UC_QLDonNhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_QLDonNhap";
            Size = new Size(1420, 1000);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLDN).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox3;
        private DataGridView dgvQLDN;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private SplitContainer splitContainer1;
        private GroupBox groupBox4;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private Button btnSearchQLDN;
        private GroupBox groupBox2;
        private Button btnQLDN_Back;
        private Button btnExQLDN;
        private Button btnImpQLDN;
        private Button btnXoaQLDN;
        private Button btnSuaQLDN;
        private Button btnThemQLDN;
        private TextBox textBox2;
        private RadioButton radioButton2;
        private DateTimePicker dtpNgayNhapHang;
        private TextBox txtNote;
        private TextBox txtTenDN;
        private TextBox txtMaDN;
        private TextBox txtMaThuoc;
        private TextBox txtMaNV;
        private TextBox txtMaNCC;
        private TextBox txtMaLo;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
