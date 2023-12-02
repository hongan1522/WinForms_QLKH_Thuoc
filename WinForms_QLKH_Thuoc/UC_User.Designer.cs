namespace GUI
{
    partial class UC_User
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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            tbUser_Password = new TextBox();
            tbUser_UserName = new TextBox();
            tbUser_RoleID = new TextBox();
            tbUser_MaNV = new TextBox();
            tbUser_UserID = new TextBox();
            label6 = new Label();
            tbUser_GhiChu = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox4 = new GroupBox();
            btnUser_Search = new Button();
            tbUser_Search_MaNV = new TextBox();
            tbUser_Search_UserName = new TextBox();
            rdbUser_MaNV = new RadioButton();
            rdbUser_UserName = new RadioButton();
            groupBox3 = new GroupBox();
            btnUser_Export = new Button();
            btnUser_Import = new Button();
            btnUser_Delete = new Button();
            btnUser_Update = new Button();
            btnUser_Add = new Button();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            btnUser_Back = new Button();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.50029F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.818182F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.1818161F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 609F));
            tableLayoutPanel1.Size = new Size(1747, 1103);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 496);
            panel1.Name = "panel1";
            panel1.Size = new Size(1741, 604);
            panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox3);
            splitContainer1.Size = new Size(1741, 604);
            splitContainer1.SplitterDistance = 1295;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(groupBox4);
            splitContainer2.Size = new Size(1295, 604);
            splitContainer2.SplitterDistance = 361;
            splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(tbUser_Password);
            groupBox2.Controls.Add(tbUser_UserName);
            groupBox2.Controls.Add(tbUser_RoleID);
            groupBox2.Controls.Add(tbUser_MaNV);
            groupBox2.Controls.Add(tbUser_UserID);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbUser_GhiChu);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1295, 361);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(838, 234);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(388, 100);
            textBox4.TabIndex = 11;
            // 
            // tbUser_Password
            // 
            tbUser_Password.Location = new Point(838, 152);
            tbUser_Password.Name = "tbUser_Password";
            tbUser_Password.PasswordChar = '*';
            tbUser_Password.Size = new Size(388, 39);
            tbUser_Password.TabIndex = 10;
            // 
            // tbUser_UserName
            // 
            tbUser_UserName.Location = new Point(838, 73);
            tbUser_UserName.Name = "tbUser_UserName";
            tbUser_UserName.Size = new Size(388, 39);
            tbUser_UserName.TabIndex = 9;
            // 
            // tbUser_RoleID
            // 
            tbUser_RoleID.Location = new Point(166, 259);
            tbUser_RoleID.Name = "tbUser_RoleID";
            tbUser_RoleID.Size = new Size(388, 39);
            tbUser_RoleID.TabIndex = 8;
            // 
            // tbUser_MaNV
            // 
            tbUser_MaNV.Location = new Point(166, 174);
            tbUser_MaNV.Name = "tbUser_MaNV";
            tbUser_MaNV.Size = new Size(388, 39);
            tbUser_MaNV.TabIndex = 7;
            // 
            // tbUser_UserID
            // 
            tbUser_UserID.Location = new Point(166, 86);
            tbUser_UserID.Name = "tbUser_UserID";
            tbUser_UserID.Size = new Size(388, 39);
            tbUser_UserID.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(671, 159);
            label6.Name = "label6";
            label6.Size = new Size(111, 32);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // tbUser_GhiChu
            // 
            tbUser_GhiChu.AutoSize = true;
            tbUser_GhiChu.Location = new Point(671, 237);
            tbUser_GhiChu.Name = "tbUser_GhiChu";
            tbUser_GhiChu.Size = new Size(96, 32);
            tbUser_GhiChu.TabIndex = 4;
            tbUser_GhiChu.Text = "Ghi chú";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(671, 76);
            label4.Name = "label4";
            label4.Size = new Size(125, 32);
            label4.TabIndex = 3;
            label4.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 259);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 2;
            label3.Text = "RoleID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 166);
            label2.Name = "label2";
            label2.Size = new Size(88, 32);
            label2.TabIndex = 1;
            label2.Text = "Mã NV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 86);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 0;
            label1.Text = "UserID";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnUser_Search);
            groupBox4.Controls.Add(tbUser_Search_MaNV);
            groupBox4.Controls.Add(tbUser_Search_UserName);
            groupBox4.Controls.Add(rdbUser_MaNV);
            groupBox4.Controls.Add(rdbUser_UserName);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1295, 239);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // btnUser_Search
            // 
            btnUser_Search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser_Search.Location = new Point(1020, 102);
            btnUser_Search.Name = "btnUser_Search";
            btnUser_Search.Size = new Size(150, 46);
            btnUser_Search.TabIndex = 9;
            btnUser_Search.Text = "Tìm kiếm";
            btnUser_Search.UseVisualStyleBackColor = true;
            // 
            // tbUser_Search_MaNV
            // 
            tbUser_Search_MaNV.Location = new Point(337, 143);
            tbUser_Search_MaNV.Name = "tbUser_Search_MaNV";
            tbUser_Search_MaNV.Size = new Size(540, 39);
            tbUser_Search_MaNV.TabIndex = 8;
            // 
            // tbUser_Search_UserName
            // 
            tbUser_Search_UserName.Location = new Point(337, 68);
            tbUser_Search_UserName.Name = "tbUser_Search_UserName";
            tbUser_Search_UserName.Size = new Size(540, 39);
            tbUser_Search_UserName.TabIndex = 7;
            // 
            // rdbUser_MaNV
            // 
            rdbUser_MaNV.AutoSize = true;
            rdbUser_MaNV.Location = new Point(66, 143);
            rdbUser_MaNV.Name = "rdbUser_MaNV";
            rdbUser_MaNV.Size = new Size(119, 36);
            rdbUser_MaNV.TabIndex = 1;
            rdbUser_MaNV.TabStop = true;
            rdbUser_MaNV.Text = "Mã NV";
            rdbUser_MaNV.UseVisualStyleBackColor = true;
            // 
            // rdbUser_UserName
            // 
            rdbUser_UserName.AutoSize = true;
            rdbUser_UserName.Location = new Point(66, 69);
            rdbUser_UserName.Name = "rdbUser_UserName";
            rdbUser_UserName.Size = new Size(156, 36);
            rdbUser_UserName.TabIndex = 0;
            rdbUser_UserName.TabStop = true;
            rdbUser_UserName.Text = "UserName";
            rdbUser_UserName.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnUser_Export);
            groupBox3.Controls.Add(btnUser_Import);
            groupBox3.Controls.Add(btnUser_Delete);
            groupBox3.Controls.Add(btnUser_Update);
            groupBox3.Controls.Add(btnUser_Add);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(442, 604);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnUser_Export
            // 
            btnUser_Export.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser_Export.Location = new Point(160, 485);
            btnUser_Export.Name = "btnUser_Export";
            btnUser_Export.Size = new Size(150, 49);
            btnUser_Export.TabIndex = 14;
            btnUser_Export.Text = "Export";
            btnUser_Export.UseVisualStyleBackColor = true;
            // 
            // btnUser_Import
            // 
            btnUser_Import.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser_Import.Location = new Point(160, 387);
            btnUser_Import.Name = "btnUser_Import";
            btnUser_Import.Size = new Size(150, 49);
            btnUser_Import.TabIndex = 13;
            btnUser_Import.Text = "Import";
            btnUser_Import.UseVisualStyleBackColor = true;
            // 
            // btnUser_Delete
            // 
            btnUser_Delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser_Delete.Image = Properties.Resources.Delete;
            btnUser_Delete.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser_Delete.Location = new Point(160, 276);
            btnUser_Delete.Name = "btnUser_Delete";
            btnUser_Delete.Size = new Size(150, 49);
            btnUser_Delete.TabIndex = 12;
            btnUser_Delete.Text = "Xóa";
            btnUser_Delete.UseVisualStyleBackColor = true;
            // 
            // btnUser_Update
            // 
            btnUser_Update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser_Update.Image = Properties.Resources.Edit;
            btnUser_Update.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser_Update.Location = new Point(160, 174);
            btnUser_Update.Name = "btnUser_Update";
            btnUser_Update.Size = new Size(150, 49);
            btnUser_Update.TabIndex = 11;
            btnUser_Update.Text = "Sửa";
            btnUser_Update.UseVisualStyleBackColor = true;
            // 
            // btnUser_Add
            // 
            btnUser_Add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser_Add.Image = Properties.Resources.New;
            btnUser_Add.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser_Add.Location = new Point(160, 70);
            btnUser_Add.Name = "btnUser_Add";
            btnUser_Add.Size = new Size(150, 49);
            btnUser_Add.TabIndex = 10;
            btnUser_Add.Text = "Thêm";
            btnUser_Add.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1741, 380);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hiển thị";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnUser_Back);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1741, 101);
            panel2.TabIndex = 3;
            // 
            // btnUser_Back
            // 
            btnUser_Back.BackColor = Color.Red;
            btnUser_Back.FlatStyle = FlatStyle.Popup;
            btnUser_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser_Back.ForeColor = Color.White;
            btnUser_Back.Image = Properties.Resources.Logout;
            btnUser_Back.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser_Back.Location = new Point(1409, 28);
            btnUser_Back.Name = "btnUser_Back";
            btnUser_Back.Size = new Size(199, 46);
            btnUser_Back.TabIndex = 14;
            btnUser_Back.Text = "Thoát";
            btnUser_Back.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(723, 24);
            label5.Name = "label5";
            label5.Size = new Size(394, 50);
            label5.TabIndex = 0;
            label5.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1735, 342);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "UserID";
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
            Column3.HeaderText = "RoleID";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "UserName";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Password";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Ghi chú";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            // 
            // UC_User
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_User";
            Size = new Size(1747, 1103);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private Panel panel2;
        private GroupBox groupBox3;
        private SplitContainer splitContainer2;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private TextBox tbUser_Password;
        private TextBox tbUser_UserName;
        private TextBox tbUser_RoleID;
        private TextBox tbUser_MaNV;
        private TextBox tbUser_UserID;
        private Label label6;
        private Label tbUser_GhiChu;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox4;
        private RadioButton rdbUser_UserName;
        private TextBox tbUser_Search_UserName;
        private RadioButton rdbUser_MaNV;
        private Button btnUser_Search;
        private TextBox tbUser_Search_MaNV;
        private Button btnUser_Delete;
        private Button btnUser_Update;
        private Button btnUser_Add;
        private Label label5;
        private Button btnUser_Export;
        private Button btnUser_Import;
        private Button btnUser_Back;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
