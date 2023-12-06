namespace FormQLKH
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tlpUser = new TableLayoutPanel();
            splUser_TTTK_CN = new SplitContainer();
            splUser_TT_TK = new SplitContainer();
            grbUser_TT = new GroupBox();
            txtUser_GhiChu = new TextBox();
            txtUser_Password = new TextBox();
            txtUser_UserName = new TextBox();
            txtUser_RoleID = new TextBox();
            txtUser_MaNV = new TextBox();
            txtUser_UserID = new TextBox();
            lbUser_Password = new Label();
            lbUser_GhiChu = new Label();
            lbUser_UserName = new Label();
            lbUser_RoleID = new Label();
            lbUser_MaNV = new Label();
            lbUser_UserID = new Label();
            grbUser_TK = new GroupBox();
            btnUser_Tim = new Button();
            txtUser_TK_MaNV = new TextBox();
            txtUser_TK_UserName = new TextBox();
            rdbUser_MaNV = new RadioButton();
            rdbUser_UserName = new RadioButton();
            grbUser_CN = new GroupBox();
            btnUser_Export = new Button();
            btnUser_Import = new Button();
            btnUser_Xoa = new Button();
            btnUser_Sua = new Button();
            btnUser_Them = new Button();
            grbUser_HT = new GroupBox();
            dgvUser = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            pnUser = new Panel();
            btnUser_Thoat = new Button();
            lbUser = new Label();
            tlpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splUser_TTTK_CN).BeginInit();
            splUser_TTTK_CN.Panel1.SuspendLayout();
            splUser_TTTK_CN.Panel2.SuspendLayout();
            splUser_TTTK_CN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splUser_TT_TK).BeginInit();
            splUser_TT_TK.Panel1.SuspendLayout();
            splUser_TT_TK.Panel2.SuspendLayout();
            splUser_TT_TK.SuspendLayout();
            grbUser_TT.SuspendLayout();
            grbUser_TK.SuspendLayout();
            grbUser_CN.SuspendLayout();
            grbUser_HT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            pnUser.SuspendLayout();
            SuspendLayout();
            // 
            // tlpUser
            // 
            tlpUser.ColumnCount = 1;
            tlpUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpUser.Controls.Add(splUser_TTTK_CN, 0, 2);
            tlpUser.Controls.Add(grbUser_HT, 0, 1);
            tlpUser.Controls.Add(pnUser, 0, 0);
            tlpUser.Dock = DockStyle.Fill;
            tlpUser.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            tlpUser.Location = new Point(0, 0);
            tlpUser.Name = "tlpUser";
            tlpUser.RowCount = 3;
            tlpUser.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tlpUser.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpUser.RowStyles.Add(new RowStyle());
            tlpUser.Size = new Size(1420, 1000);
            tlpUser.TabIndex = 1;
            // 
            // splUser_TTTK_CN
            // 
            splUser_TTTK_CN.Dock = DockStyle.Fill;
            splUser_TTTK_CN.Location = new Point(3, 462);
            splUser_TTTK_CN.Name = "splUser_TTTK_CN";
            // 
            // splUser_TTTK_CN.Panel1
            // 
            splUser_TTTK_CN.Panel1.Controls.Add(splUser_TT_TK);
            // 
            // splUser_TTTK_CN.Panel2
            // 
            splUser_TTTK_CN.Panel2.Controls.Add(grbUser_CN);
            splUser_TTTK_CN.Size = new Size(1414, 535);
            splUser_TTTK_CN.SplitterDistance = 1168;
            splUser_TTTK_CN.TabIndex = 4;
            // 
            // splUser_TT_TK
            // 
            splUser_TT_TK.Dock = DockStyle.Fill;
            splUser_TT_TK.Location = new Point(0, 0);
            splUser_TT_TK.Name = "splUser_TT_TK";
            splUser_TT_TK.Orientation = Orientation.Horizontal;
            // 
            // splUser_TT_TK.Panel1
            // 
            splUser_TT_TK.Panel1.Controls.Add(grbUser_TT);
            // 
            // splUser_TT_TK.Panel2
            // 
            splUser_TT_TK.Panel2.Controls.Add(grbUser_TK);
            splUser_TT_TK.Size = new Size(1168, 535);
            splUser_TT_TK.SplitterDistance = 322;
            splUser_TT_TK.TabIndex = 0;
            // 
            // grbUser_TT
            // 
            grbUser_TT.Controls.Add(txtUser_GhiChu);
            grbUser_TT.Controls.Add(txtUser_Password);
            grbUser_TT.Controls.Add(txtUser_UserName);
            grbUser_TT.Controls.Add(txtUser_RoleID);
            grbUser_TT.Controls.Add(txtUser_MaNV);
            grbUser_TT.Controls.Add(txtUser_UserID);
            grbUser_TT.Controls.Add(lbUser_Password);
            grbUser_TT.Controls.Add(lbUser_GhiChu);
            grbUser_TT.Controls.Add(lbUser_UserName);
            grbUser_TT.Controls.Add(lbUser_RoleID);
            grbUser_TT.Controls.Add(lbUser_MaNV);
            grbUser_TT.Controls.Add(lbUser_UserID);
            grbUser_TT.Dock = DockStyle.Fill;
            grbUser_TT.Location = new Point(0, 0);
            grbUser_TT.Name = "grbUser_TT";
            grbUser_TT.Size = new Size(1168, 322);
            grbUser_TT.TabIndex = 2;
            grbUser_TT.TabStop = false;
            grbUser_TT.Text = "Thông tin";
            // 
            // txtUser_GhiChu
            // 
            txtUser_GhiChu.Location = new Point(710, 207);
            txtUser_GhiChu.Multiline = true;
            txtUser_GhiChu.Name = "txtUser_GhiChu";
            txtUser_GhiChu.Size = new Size(388, 100);
            txtUser_GhiChu.TabIndex = 11;
            // 
            // txtUser_Password
            // 
            txtUser_Password.Location = new Point(710, 129);
            txtUser_Password.Name = "txtUser_Password";
            txtUser_Password.PasswordChar = '*';
            txtUser_Password.Size = new Size(388, 43);
            txtUser_Password.TabIndex = 10;
            // 
            // txtUser_UserName
            // 
            txtUser_UserName.Location = new Point(710, 53);
            txtUser_UserName.Name = "txtUser_UserName";
            txtUser_UserName.Size = new Size(388, 43);
            txtUser_UserName.TabIndex = 9;
            // 
            // txtUser_RoleID
            // 
            txtUser_RoleID.Location = new Point(185, 223);
            txtUser_RoleID.Name = "txtUser_RoleID";
            txtUser_RoleID.Size = new Size(297, 43);
            txtUser_RoleID.TabIndex = 8;
            // 
            // txtUser_MaNV
            // 
            txtUser_MaNV.Location = new Point(185, 138);
            txtUser_MaNV.Name = "txtUser_MaNV";
            txtUser_MaNV.Size = new Size(297, 43);
            txtUser_MaNV.TabIndex = 7;
            // 
            // txtUser_UserID
            // 
            txtUser_UserID.Location = new Point(185, 50);
            txtUser_UserID.Name = "txtUser_UserID";
            txtUser_UserID.Size = new Size(297, 43);
            txtUser_UserID.TabIndex = 6;
            // 
            // lbUser_Password
            // 
            lbUser_Password.AutoSize = true;
            lbUser_Password.Location = new Point(538, 133);
            lbUser_Password.Name = "lbUser_Password";
            lbUser_Password.Size = new Size(128, 37);
            lbUser_Password.TabIndex = 5;
            lbUser_Password.Text = "Password";
            // 
            // lbUser_GhiChu
            // 
            lbUser_GhiChu.AutoSize = true;
            lbUser_GhiChu.Location = new Point(538, 207);
            lbUser_GhiChu.Name = "lbUser_GhiChu";
            lbUser_GhiChu.Size = new Size(107, 37);
            lbUser_GhiChu.TabIndex = 4;
            lbUser_GhiChu.Text = "Ghi chú";
            // 
            // lbUser_UserName
            // 
            lbUser_UserName.AutoSize = true;
            lbUser_UserName.Location = new Point(538, 50);
            lbUser_UserName.Name = "lbUser_UserName";
            lbUser_UserName.Size = new Size(141, 37);
            lbUser_UserName.TabIndex = 3;
            lbUser_UserName.Text = "UserName";
            // 
            // lbUser_RoleID
            // 
            lbUser_RoleID.AutoSize = true;
            lbUser_RoleID.Location = new Point(49, 223);
            lbUser_RoleID.Name = "lbUser_RoleID";
            lbUser_RoleID.Size = new Size(95, 37);
            lbUser_RoleID.TabIndex = 2;
            lbUser_RoleID.Text = "RoleID";
            // 
            // lbUser_MaNV
            // 
            lbUser_MaNV.AutoSize = true;
            lbUser_MaNV.Location = new Point(49, 130);
            lbUser_MaNV.Name = "lbUser_MaNV";
            lbUser_MaNV.Size = new Size(99, 37);
            lbUser_MaNV.TabIndex = 1;
            lbUser_MaNV.Text = "Mã NV";
            // 
            // lbUser_UserID
            // 
            lbUser_UserID.AutoSize = true;
            lbUser_UserID.Location = new Point(49, 50);
            lbUser_UserID.Name = "lbUser_UserID";
            lbUser_UserID.Size = new Size(96, 37);
            lbUser_UserID.TabIndex = 0;
            lbUser_UserID.Text = "UserID";
            // 
            // grbUser_TK
            // 
            grbUser_TK.Controls.Add(btnUser_Tim);
            grbUser_TK.Controls.Add(txtUser_TK_MaNV);
            grbUser_TK.Controls.Add(txtUser_TK_UserName);
            grbUser_TK.Controls.Add(rdbUser_MaNV);
            grbUser_TK.Controls.Add(rdbUser_UserName);
            grbUser_TK.Location = new Point(0, 6);
            grbUser_TK.Name = "grbUser_TK";
            grbUser_TK.Size = new Size(1168, 197);
            grbUser_TK.TabIndex = 2;
            grbUser_TK.TabStop = false;
            grbUser_TK.Text = "Tìm kiếm";
            // 
            // btnUser_Tim
            // 
            btnUser_Tim.BackColor = SystemColors.ButtonHighlight;
            btnUser_Tim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser_Tim.Location = new Point(1002, 67);
            btnUser_Tim.Name = "btnUser_Tim";
            btnUser_Tim.Size = new Size(123, 73);
            btnUser_Tim.TabIndex = 9;
            btnUser_Tim.Text = "Tìm";
            btnUser_Tim.UseVisualStyleBackColor = false;
            // 
            // txtUser_TK_MaNV
            // 
            txtUser_TK_MaNV.Location = new Point(338, 131);
            txtUser_TK_MaNV.Name = "txtUser_TK_MaNV";
            txtUser_TK_MaNV.Size = new Size(533, 43);
            txtUser_TK_MaNV.TabIndex = 8;
            // 
            // txtUser_TK_UserName
            // 
            txtUser_TK_UserName.Location = new Point(338, 56);
            txtUser_TK_UserName.Name = "txtUser_TK_UserName";
            txtUser_TK_UserName.Size = new Size(533, 43);
            txtUser_TK_UserName.TabIndex = 7;
            // 
            // rdbUser_MaNV
            // 
            rdbUser_MaNV.AutoSize = true;
            rdbUser_MaNV.Location = new Point(67, 131);
            rdbUser_MaNV.Name = "rdbUser_MaNV";
            rdbUser_MaNV.Size = new Size(130, 41);
            rdbUser_MaNV.TabIndex = 1;
            rdbUser_MaNV.TabStop = true;
            rdbUser_MaNV.Text = "Mã NV";
            rdbUser_MaNV.UseVisualStyleBackColor = true;
            // 
            // rdbUser_UserName
            // 
            rdbUser_UserName.AutoSize = true;
            rdbUser_UserName.Location = new Point(67, 57);
            rdbUser_UserName.Name = "rdbUser_UserName";
            rdbUser_UserName.Size = new Size(172, 41);
            rdbUser_UserName.TabIndex = 0;
            rdbUser_UserName.TabStop = true;
            rdbUser_UserName.Text = "UserName";
            rdbUser_UserName.UseVisualStyleBackColor = true;
            // 
            // grbUser_CN
            // 
            grbUser_CN.Controls.Add(btnUser_Export);
            grbUser_CN.Controls.Add(btnUser_Import);
            grbUser_CN.Controls.Add(btnUser_Xoa);
            grbUser_CN.Controls.Add(btnUser_Sua);
            grbUser_CN.Controls.Add(btnUser_Them);
            grbUser_CN.Location = new Point(0, 0);
            grbUser_CN.Name = "grbUser_CN";
            grbUser_CN.Size = new Size(242, 535);
            grbUser_CN.TabIndex = 0;
            grbUser_CN.TabStop = false;
            grbUser_CN.Text = "Chức năng";
            // 
            // btnUser_Export
            // 
            btnUser_Export.BackColor = SystemColors.ButtonHighlight;
            btnUser_Export.FlatStyle = FlatStyle.Popup;
            btnUser_Export.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser_Export.Location = new Point(62, 429);
            btnUser_Export.Name = "btnUser_Export";
            btnUser_Export.Size = new Size(123, 77);
            btnUser_Export.TabIndex = 14;
            btnUser_Export.Text = "Export";
            btnUser_Export.UseVisualStyleBackColor = false;
            // 
            // btnUser_Import
            // 
            btnUser_Import.BackColor = SystemColors.ButtonHighlight;
            btnUser_Import.FlatStyle = FlatStyle.Popup;
            btnUser_Import.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser_Import.Location = new Point(62, 334);
            btnUser_Import.Name = "btnUser_Import";
            btnUser_Import.Size = new Size(123, 77);
            btnUser_Import.TabIndex = 13;
            btnUser_Import.Text = "Import";
            btnUser_Import.UseVisualStyleBackColor = false;
            // 
            // btnUser_Xoa
            // 
            btnUser_Xoa.BackColor = SystemColors.ButtonHighlight;
            btnUser_Xoa.FlatStyle = FlatStyle.Popup;
            btnUser_Xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser_Xoa.Image = Properties.Resources.Delete;
            btnUser_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser_Xoa.Location = new Point(62, 239);
            btnUser_Xoa.Name = "btnUser_Xoa";
            btnUser_Xoa.Size = new Size(123, 77);
            btnUser_Xoa.TabIndex = 12;
            btnUser_Xoa.Text = "Xóa";
            btnUser_Xoa.UseVisualStyleBackColor = false;
            // 
            // btnUser_Sua
            // 
            btnUser_Sua.BackColor = SystemColors.ButtonHighlight;
            btnUser_Sua.FlatStyle = FlatStyle.Popup;
            btnUser_Sua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser_Sua.Image = Properties.Resources.Edit;
            btnUser_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser_Sua.Location = new Point(62, 144);
            btnUser_Sua.Name = "btnUser_Sua";
            btnUser_Sua.Size = new Size(123, 77);
            btnUser_Sua.TabIndex = 11;
            btnUser_Sua.Text = "Sửa";
            btnUser_Sua.UseVisualStyleBackColor = false;
            // 
            // btnUser_Them
            // 
            btnUser_Them.BackColor = SystemColors.ButtonHighlight;
            btnUser_Them.FlatStyle = FlatStyle.Popup;
            btnUser_Them.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser_Them.Image = Properties.Resources.New;
            btnUser_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser_Them.Location = new Point(62, 49);
            btnUser_Them.Name = "btnUser_Them";
            btnUser_Them.Size = new Size(123, 77);
            btnUser_Them.TabIndex = 10;
            btnUser_Them.Text = "Thêm";
            btnUser_Them.UseVisualStyleBackColor = false;
            // 
            // grbUser_HT
            // 
            grbUser_HT.Controls.Add(dgvUser);
            grbUser_HT.Dock = DockStyle.Fill;
            grbUser_HT.Location = new Point(3, 96);
            grbUser_HT.Name = "grbUser_HT";
            grbUser_HT.Size = new Size(1414, 360);
            grbUser_HT.TabIndex = 0;
            grbUser_HT.TabStop = false;
            grbUser_HT.Text = "Hiển thị";
            // 
            // dgvUser
            // 
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvUser.Dock = DockStyle.Fill;
            dgvUser.Location = new Point(3, 39);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 82;
            dgvUser.RowTemplate.Height = 41;
            dgvUser.Size = new Size(1408, 318);
            dgvUser.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            // pnUser
            // 
            pnUser.BackColor = Color.FromArgb(63, 139, 208);
            pnUser.Controls.Add(lbUser);
            pnUser.Controls.Add(btnUser_Thoat);
            pnUser.Dock = DockStyle.Fill;
            pnUser.Location = new Point(3, 3);
            pnUser.Name = "pnUser";
            pnUser.Size = new Size(1414, 87);
            pnUser.TabIndex = 3;
            // 
            // btnUser_Thoat
            // 
            btnUser_Thoat.BackColor = Color.Red;
            btnUser_Thoat.FlatStyle = FlatStyle.Popup;
            btnUser_Thoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser_Thoat.ForeColor = Color.White;
            btnUser_Thoat.Image = Properties.Resources.Logout;
            btnUser_Thoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser_Thoat.Location = new Point(1215, 18);
            btnUser_Thoat.Name = "btnUser_Thoat";
            btnUser_Thoat.Size = new Size(173, 54);
            btnUser_Thoat.TabIndex = 14;
            btnUser_Thoat.Text = "Thoát";
            btnUser_Thoat.UseVisualStyleBackColor = false;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbUser.ForeColor = SystemColors.ButtonHighlight;
            lbUser.Location = new Point(510, 15);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(394, 50);
            lbUser.TabIndex = 0;
            lbUser.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // UC_User
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpUser);
            Name = "UC_User";
            Size = new Size(1420, 1000);
            tlpUser.ResumeLayout(false);
            splUser_TTTK_CN.Panel1.ResumeLayout(false);
            splUser_TTTK_CN.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splUser_TTTK_CN).EndInit();
            splUser_TTTK_CN.ResumeLayout(false);
            splUser_TT_TK.Panel1.ResumeLayout(false);
            splUser_TT_TK.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splUser_TT_TK).EndInit();
            splUser_TT_TK.ResumeLayout(false);
            grbUser_TT.ResumeLayout(false);
            grbUser_TT.PerformLayout();
            grbUser_TK.ResumeLayout(false);
            grbUser_TK.PerformLayout();
            grbUser_CN.ResumeLayout(false);
            grbUser_HT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            pnUser.ResumeLayout(false);
            pnUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpUser;
        private GroupBox grbUser_HT;
        private DataGridView dgvUser;
        private Panel pnUser;
        private Button btnUser_Thoat;
        private Label lbUser;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private SplitContainer splUser_TTTK_CN;
        private SplitContainer splUser_TT_TK;
        private GroupBox grbUser_TT;
        private TextBox txtUser_GhiChu;
        private TextBox txtUser_Password;
        private TextBox txtUser_UserName;
        private TextBox txtUser_RoleID;
        private TextBox txtUser_MaNV;
        private TextBox txtUser_UserID;
        private Label lbUser_Password;
        private Label lbUser_GhiChu;
        private Label lbUser_UserName;
        private Label lbUser_RoleID;
        private Label lbUser_MaNV;
        private Label lbUser_UserID;
        private GroupBox grbUser_TK;
        private Button btnUser_Tim;
        private TextBox txtUser_TK_MaNV;
        private TextBox txtUser_TK_UserName;
        private RadioButton rdbUser_MaNV;
        private RadioButton rdbUser_UserName;
        private GroupBox grbUser_CN;
        private Button btnUser_Export;
        private Button btnUser_Import;
        private Button btnUser_Xoa;
        private Button btnUser_Sua;
        private Button btnUser_Them;
    }
}
