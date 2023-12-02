using WinFormsApp;

namespace GUI
{
    partial class UC_Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Main));
            tlpFrmMain = new TableLayoutPanel();
            pnlSideBar = new Panel();
            pnlSubMenuDsnv = new Panel();
            button1 = new Button();
            btnDsnv = new Button();
            pnlQuanLyNhanVien = new Panel();
            pbArrowQLNV = new PictureBox();
            btnQLNS = new Button();
            panel12 = new Panel();
            btnLogout = new Button();
            pnlSubMenuQLTK = new Panel();
            pnlSubMenuDssp = new Panel();
            btnDsnt = new Button();
            btnDst = new Button();
            pnlDssp = new Panel();
            pbArrowQLSP = new PictureBox();
            btnQuanLySanPham = new Button();
            pnlSubMenuKho = new Panel();
            btnQLDX = new Button();
            btnQLDN = new Button();
            btnDsl = new Button();
            btnDsk = new Button();
            btnDscn = new Button();
            pnlDsKho = new Panel();
            pbArrowQLK = new PictureBox();
            btnQuanLyKho = new Button();
            pbLogo = new PictureBox();
            pnlMenu = new Panel();
            tlpMenu = new TableLayoutPanel();
            btnMenu = new Button();
            label2 = new Label();
            panel7 = new Panel();
            pnlTitleBar = new Panel();
            label1 = new Label();
            pnlShowForm = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            CollapseTimer = new System.Windows.Forms.Timer(components);
            tlpFrmMain.SuspendLayout();
            pnlSideBar.SuspendLayout();
            pnlSubMenuDsnv.SuspendLayout();
            pnlQuanLyNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbArrowQLNV).BeginInit();
            panel12.SuspendLayout();
            pnlSubMenuDssp.SuspendLayout();
            pnlDssp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbArrowQLSP).BeginInit();
            pnlSubMenuKho.SuspendLayout();
            pnlDsKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbArrowQLK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlMenu.SuspendLayout();
            tlpMenu.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // tlpFrmMain
            // 
            tlpFrmMain.ColumnCount = 2;
            tlpFrmMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.1830311F));
            tlpFrmMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.81696F));
            tlpFrmMain.Controls.Add(pnlSideBar, 0, 1);
            tlpFrmMain.Controls.Add(pnlTitleBar, 0, 0);
            tlpFrmMain.Controls.Add(pnlShowForm, 1, 1);
            tlpFrmMain.Dock = DockStyle.Fill;
            tlpFrmMain.Location = new Point(0, 0);
            tlpFrmMain.Margin = new Padding(0);
            tlpFrmMain.Name = "tlpFrmMain";
            tlpFrmMain.RowCount = 2;
            tlpFrmMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5.43383F));
            tlpFrmMain.RowStyles.Add(new RowStyle(SizeType.Percent, 94.56617F));
            tlpFrmMain.Size = new Size(1750, 1544);
            tlpFrmMain.TabIndex = 0;
            // 
            // pnlSideBar
            // 
            pnlSideBar.AutoScroll = true;
            pnlSideBar.BackColor = Color.FromArgb(64, 64, 64);
            pnlSideBar.Controls.Add(pnlSubMenuDsnv);
            pnlSideBar.Controls.Add(pnlQuanLyNhanVien);
            pnlSideBar.Controls.Add(panel12);
            pnlSideBar.Controls.Add(pnlSubMenuQLTK);
            pnlSideBar.Controls.Add(pnlSubMenuDssp);
            pnlSideBar.Controls.Add(pnlDssp);
            pnlSideBar.Controls.Add(pnlSubMenuKho);
            pnlSideBar.Controls.Add(pnlDsKho);
            pnlSideBar.Controls.Add(pbLogo);
            pnlSideBar.Controls.Add(pnlMenu);
            pnlSideBar.Controls.Add(panel7);
            pnlSideBar.Dock = DockStyle.Fill;
            pnlSideBar.Location = new Point(0, 83);
            pnlSideBar.Margin = new Padding(0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(510, 1461);
            pnlSideBar.TabIndex = 1;
            // 
            // pnlSubMenuDsnv
            // 
            pnlSubMenuDsnv.AutoScroll = true;
            pnlSubMenuDsnv.AutoSize = true;
            pnlSubMenuDsnv.Controls.Add(button1);
            pnlSubMenuDsnv.Controls.Add(btnDsnv);
            pnlSubMenuDsnv.Dock = DockStyle.Top;
            pnlSubMenuDsnv.Location = new Point(0, 1054);
            pnlSubMenuDsnv.Margin = new Padding(4, 4, 4, 4);
            pnlSubMenuDsnv.Name = "pnlSubMenuDsnv";
            pnlSubMenuDsnv.Size = new Size(510, 116);
            pnlSubMenuDsnv.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 58);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(88, 0, 0, 0);
            button1.Size = new Size(510, 58);
            button1.TabIndex = 1;
            button1.Text = "Danh sách tài khoản";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnDsnv
            // 
            btnDsnv.BackColor = Color.Gray;
            btnDsnv.Dock = DockStyle.Top;
            btnDsnv.FlatAppearance.BorderSize = 0;
            btnDsnv.FlatStyle = FlatStyle.Flat;
            btnDsnv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDsnv.ForeColor = Color.White;
            btnDsnv.Location = new Point(0, 0);
            btnDsnv.Margin = new Padding(4, 4, 4, 4);
            btnDsnv.Name = "btnDsnv";
            btnDsnv.Padding = new Padding(88, 0, 0, 0);
            btnDsnv.Size = new Size(510, 58);
            btnDsnv.TabIndex = 0;
            btnDsnv.Text = "Danh sách nhân viên";
            btnDsnv.TextAlign = ContentAlignment.MiddleLeft;
            btnDsnv.UseVisualStyleBackColor = false;
            // 
            // pnlQuanLyNhanVien
            // 
            pnlQuanLyNhanVien.Controls.Add(pbArrowQLNV);
            pnlQuanLyNhanVien.Controls.Add(btnQLNS);
            pnlQuanLyNhanVien.Dock = DockStyle.Top;
            pnlQuanLyNhanVien.Location = new Point(0, 977);
            pnlQuanLyNhanVien.Margin = new Padding(4, 4, 4, 4);
            pnlQuanLyNhanVien.Name = "pnlQuanLyNhanVien";
            pnlQuanLyNhanVien.Size = new Size(510, 77);
            pnlQuanLyNhanVien.TabIndex = 16;
            // 
            // pbArrowQLNV
            // 
            pbArrowQLNV.BackColor = Color.FromArgb(255, 110, 20);
            pbArrowQLNV.BackgroundImage = (Image)resources.GetObject("pbArrowQLNV.BackgroundImage");
            pbArrowQLNV.BackgroundImageLayout = ImageLayout.Center;
            pbArrowQLNV.Dock = DockStyle.Right;
            pbArrowQLNV.Location = new Point(445, 0);
            pbArrowQLNV.Margin = new Padding(4, 4, 4, 4);
            pbArrowQLNV.Name = "pbArrowQLNV";
            pbArrowQLNV.Size = new Size(65, 77);
            pbArrowQLNV.TabIndex = 1;
            pbArrowQLNV.TabStop = false;
            // 
            // btnQLNS
            // 
            btnQLNS.BackColor = Color.SteelBlue;
            btnQLNS.Dock = DockStyle.Fill;
            btnQLNS.FlatAppearance.BorderSize = 0;
            btnQLNS.FlatStyle = FlatStyle.Flat;
            btnQLNS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLNS.ForeColor = Color.White;
            btnQLNS.Image = Properties.Resources.user11;
            btnQLNS.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLNS.Location = new Point(0, 0);
            btnQLNS.Margin = new Padding(0);
            btnQLNS.Name = "btnQLNS";
            btnQLNS.Padding = new Padding(13, 0, 156, 0);
            btnQLNS.Size = new Size(510, 77);
            btnQLNS.TabIndex = 0;
            btnQLNS.Text = "Quản lý nhân sự";
            btnQLNS.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            panel12.Controls.Add(btnLogout);
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(0, 1384);
            panel12.Margin = new Padding(4, 4, 4, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(510, 77);
            panel12.TabIndex = 15;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(244, 67, 54);
            btnLogout.Dock = DockStyle.Fill;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 0);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(5, 0, 0, 0);
            btnLogout.Size = new Size(510, 77);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // pnlSubMenuQLTK
            // 
            pnlSubMenuQLTK.AutoScroll = true;
            pnlSubMenuQLTK.AutoSize = true;
            pnlSubMenuQLTK.Dock = DockStyle.Top;
            pnlSubMenuQLTK.Location = new Point(0, 977);
            pnlSubMenuQLTK.Margin = new Padding(4, 4, 4, 4);
            pnlSubMenuQLTK.Name = "pnlSubMenuQLTK";
            pnlSubMenuQLTK.Size = new Size(510, 0);
            pnlSubMenuQLTK.TabIndex = 14;
            // 
            // pnlSubMenuDssp
            // 
            pnlSubMenuDssp.AutoScroll = true;
            pnlSubMenuDssp.AutoSize = true;
            pnlSubMenuDssp.Controls.Add(btnDsnt);
            pnlSubMenuDssp.Controls.Add(btnDst);
            pnlSubMenuDssp.Dock = DockStyle.Top;
            pnlSubMenuDssp.Location = new Point(0, 861);
            pnlSubMenuDssp.Margin = new Padding(4, 4, 4, 4);
            pnlSubMenuDssp.Name = "pnlSubMenuDssp";
            pnlSubMenuDssp.Size = new Size(510, 116);
            pnlSubMenuDssp.TabIndex = 12;
            // 
            // btnDsnt
            // 
            btnDsnt.BackColor = Color.Gray;
            btnDsnt.Dock = DockStyle.Top;
            btnDsnt.FlatAppearance.BorderSize = 0;
            btnDsnt.FlatStyle = FlatStyle.Flat;
            btnDsnt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDsnt.ForeColor = Color.White;
            btnDsnt.Location = new Point(0, 58);
            btnDsnt.Margin = new Padding(4, 4, 4, 4);
            btnDsnt.Name = "btnDsnt";
            btnDsnt.Padding = new Padding(88, 0, 0, 0);
            btnDsnt.Size = new Size(510, 58);
            btnDsnt.TabIndex = 1;
            btnDsnt.Text = "Danh sách nhóm thuốc";
            btnDsnt.TextAlign = ContentAlignment.MiddleLeft;
            btnDsnt.UseVisualStyleBackColor = false;
            // 
            // btnDst
            // 
            btnDst.BackColor = Color.Gray;
            btnDst.Dock = DockStyle.Top;
            btnDst.FlatAppearance.BorderSize = 0;
            btnDst.FlatStyle = FlatStyle.Flat;
            btnDst.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDst.ForeColor = Color.White;
            btnDst.Location = new Point(0, 0);
            btnDst.Margin = new Padding(4, 4, 4, 4);
            btnDst.Name = "btnDst";
            btnDst.Padding = new Padding(88, 0, 0, 0);
            btnDst.Size = new Size(510, 58);
            btnDst.TabIndex = 0;
            btnDst.Text = "Danh sách thuốc";
            btnDst.TextAlign = ContentAlignment.MiddleLeft;
            btnDst.UseVisualStyleBackColor = false;
            // 
            // pnlDssp
            // 
            pnlDssp.Controls.Add(pbArrowQLSP);
            pnlDssp.Controls.Add(btnQuanLySanPham);
            pnlDssp.Dock = DockStyle.Top;
            pnlDssp.Location = new Point(0, 784);
            pnlDssp.Margin = new Padding(4, 4, 4, 4);
            pnlDssp.Name = "pnlDssp";
            pnlDssp.Size = new Size(510, 77);
            pnlDssp.TabIndex = 11;
            // 
            // pbArrowQLSP
            // 
            pbArrowQLSP.BackColor = Color.FromArgb(255, 110, 20);
            pbArrowQLSP.BackgroundImage = (Image)resources.GetObject("pbArrowQLSP.BackgroundImage");
            pbArrowQLSP.BackgroundImageLayout = ImageLayout.Center;
            pbArrowQLSP.Dock = DockStyle.Right;
            pbArrowQLSP.Location = new Point(445, 0);
            pbArrowQLSP.Margin = new Padding(4, 4, 4, 4);
            pbArrowQLSP.Name = "pbArrowQLSP";
            pbArrowQLSP.Size = new Size(65, 77);
            pbArrowQLSP.TabIndex = 1;
            pbArrowQLSP.TabStop = false;
            // 
            // btnQuanLySanPham
            // 
            btnQuanLySanPham.BackColor = Color.SteelBlue;
            btnQuanLySanPham.Dock = DockStyle.Fill;
            btnQuanLySanPham.FlatAppearance.BorderSize = 0;
            btnQuanLySanPham.FlatStyle = FlatStyle.Flat;
            btnQuanLySanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuanLySanPham.ForeColor = Color.White;
            btnQuanLySanPham.Image = Properties.Resources.Product;
            btnQuanLySanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuanLySanPham.Location = new Point(0, 0);
            btnQuanLySanPham.Margin = new Padding(0);
            btnQuanLySanPham.Name = "btnQuanLySanPham";
            btnQuanLySanPham.Padding = new Padding(13, 0, 156, 0);
            btnQuanLySanPham.Size = new Size(510, 77);
            btnQuanLySanPham.TabIndex = 0;
            btnQuanLySanPham.Text = "Quản lý sản phẩm";
            btnQuanLySanPham.UseVisualStyleBackColor = false;
            // 
            // pnlSubMenuKho
            // 
            pnlSubMenuKho.AutoScroll = true;
            pnlSubMenuKho.AutoSize = true;
            pnlSubMenuKho.Controls.Add(btnQLDX);
            pnlSubMenuKho.Controls.Add(btnQLDN);
            pnlSubMenuKho.Controls.Add(btnDsl);
            pnlSubMenuKho.Controls.Add(btnDsk);
            pnlSubMenuKho.Controls.Add(btnDscn);
            pnlSubMenuKho.Dock = DockStyle.Top;
            pnlSubMenuKho.Location = new Point(0, 494);
            pnlSubMenuKho.Margin = new Padding(4, 4, 4, 4);
            pnlSubMenuKho.Name = "pnlSubMenuKho";
            pnlSubMenuKho.Size = new Size(510, 290);
            pnlSubMenuKho.TabIndex = 10;
            // 
            // btnQLDX
            // 
            btnQLDX.BackColor = Color.Gray;
            btnQLDX.Dock = DockStyle.Top;
            btnQLDX.FlatAppearance.BorderSize = 0;
            btnQLDX.FlatStyle = FlatStyle.Flat;
            btnQLDX.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDX.ForeColor = Color.White;
            btnQLDX.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDX.Location = new Point(0, 232);
            btnQLDX.Margin = new Padding(4, 4, 4, 4);
            btnQLDX.Name = "btnQLDX";
            btnQLDX.Padding = new Padding(88, 0, 0, 0);
            btnQLDX.Size = new Size(510, 58);
            btnQLDX.TabIndex = 2;
            btnQLDX.Text = "Quản lý đơn xuất";
            btnQLDX.TextAlign = ContentAlignment.MiddleLeft;
            btnQLDX.UseVisualStyleBackColor = false;
            // 
            // btnQLDN
            // 
            btnQLDN.BackColor = Color.Gray;
            btnQLDN.Dock = DockStyle.Top;
            btnQLDN.FlatAppearance.BorderSize = 0;
            btnQLDN.FlatStyle = FlatStyle.Flat;
            btnQLDN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDN.ForeColor = Color.White;
            btnQLDN.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDN.Location = new Point(0, 174);
            btnQLDN.Margin = new Padding(4, 4, 4, 4);
            btnQLDN.Name = "btnQLDN";
            btnQLDN.Padding = new Padding(88, 0, 0, 0);
            btnQLDN.Size = new Size(510, 58);
            btnQLDN.TabIndex = 5;
            btnQLDN.Text = "Quản lý đơn nhập";
            btnQLDN.TextAlign = ContentAlignment.MiddleLeft;
            btnQLDN.UseVisualStyleBackColor = false;
            // 
            // btnDsl
            // 
            btnDsl.BackColor = Color.Gray;
            btnDsl.Dock = DockStyle.Top;
            btnDsl.FlatAppearance.BorderSize = 0;
            btnDsl.FlatStyle = FlatStyle.Flat;
            btnDsl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDsl.ForeColor = Color.White;
            btnDsl.ImageAlign = ContentAlignment.MiddleLeft;
            btnDsl.Location = new Point(0, 116);
            btnDsl.Margin = new Padding(4, 4, 4, 4);
            btnDsl.Name = "btnDsl";
            btnDsl.Padding = new Padding(88, 0, 0, 0);
            btnDsl.Size = new Size(510, 58);
            btnDsl.TabIndex = 4;
            btnDsl.Text = "Danh sách lô";
            btnDsl.TextAlign = ContentAlignment.MiddleLeft;
            btnDsl.UseVisualStyleBackColor = false;
            // 
            // btnDsk
            // 
            btnDsk.BackColor = Color.Gray;
            btnDsk.Dock = DockStyle.Top;
            btnDsk.FlatAppearance.BorderSize = 0;
            btnDsk.FlatStyle = FlatStyle.Flat;
            btnDsk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDsk.ForeColor = Color.White;
            btnDsk.ImageAlign = ContentAlignment.MiddleLeft;
            btnDsk.Location = new Point(0, 58);
            btnDsk.Margin = new Padding(4, 4, 4, 4);
            btnDsk.Name = "btnDsk";
            btnDsk.Padding = new Padding(88, 0, 0, 0);
            btnDsk.Size = new Size(510, 58);
            btnDsk.TabIndex = 0;
            btnDsk.Text = "Danh sách kho";
            btnDsk.TextAlign = ContentAlignment.MiddleLeft;
            btnDsk.UseVisualStyleBackColor = false;
            // 
            // btnDscn
            // 
            btnDscn.BackColor = Color.Gray;
            btnDscn.Dock = DockStyle.Top;
            btnDscn.FlatAppearance.BorderSize = 0;
            btnDscn.FlatStyle = FlatStyle.Flat;
            btnDscn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDscn.ForeColor = Color.White;
            btnDscn.ImageAlign = ContentAlignment.MiddleLeft;
            btnDscn.Location = new Point(0, 0);
            btnDscn.Margin = new Padding(4, 4, 4, 4);
            btnDscn.Name = "btnDscn";
            btnDscn.Padding = new Padding(88, 0, 0, 0);
            btnDscn.Size = new Size(510, 58);
            btnDscn.TabIndex = 2;
            btnDscn.Text = "Danh sách chi nhánh";
            btnDscn.TextAlign = ContentAlignment.MiddleLeft;
            btnDscn.UseVisualStyleBackColor = false;
            // 
            // pnlDsKho
            // 
            pnlDsKho.Controls.Add(pbArrowQLK);
            pnlDsKho.Controls.Add(btnQuanLyKho);
            pnlDsKho.Dock = DockStyle.Top;
            pnlDsKho.Location = new Point(0, 417);
            pnlDsKho.Margin = new Padding(4, 4, 4, 4);
            pnlDsKho.Name = "pnlDsKho";
            pnlDsKho.Size = new Size(510, 77);
            pnlDsKho.TabIndex = 9;
            // 
            // pbArrowQLK
            // 
            pbArrowQLK.BackColor = Color.FromArgb(255, 110, 20);
            pbArrowQLK.BackgroundImage = (Image)resources.GetObject("pbArrowQLK.BackgroundImage");
            pbArrowQLK.BackgroundImageLayout = ImageLayout.Center;
            pbArrowQLK.Dock = DockStyle.Right;
            pbArrowQLK.Location = new Point(445, 0);
            pbArrowQLK.Margin = new Padding(4, 4, 4, 4);
            pbArrowQLK.Name = "pbArrowQLK";
            pbArrowQLK.Size = new Size(65, 77);
            pbArrowQLK.TabIndex = 0;
            pbArrowQLK.TabStop = false;
            // 
            // btnQuanLyKho
            // 
            btnQuanLyKho.BackColor = Color.SteelBlue;
            btnQuanLyKho.Dock = DockStyle.Fill;
            btnQuanLyKho.FlatAppearance.BorderSize = 0;
            btnQuanLyKho.FlatStyle = FlatStyle.Flat;
            btnQuanLyKho.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuanLyKho.ForeColor = Color.White;
            btnQuanLyKho.Image = Properties.Resources.Storal;
            btnQuanLyKho.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuanLyKho.Location = new Point(0, 0);
            btnQuanLyKho.Margin = new Padding(0);
            btnQuanLyKho.Name = "btnQuanLyKho";
            btnQuanLyKho.Padding = new Padding(10, 0, 221, 0);
            btnQuanLyKho.Size = new Size(510, 77);
            btnQuanLyKho.TabIndex = 0;
            btnQuanLyKho.Text = "Quản lý kho";
            btnQuanLyKho.UseVisualStyleBackColor = false;
            // 
            // pbLogo
            // 
            pbLogo.Dock = DockStyle.Top;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(0, 91);
            pbLogo.Margin = new Padding(0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(510, 326);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(tlpMenu);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(510, 91);
            pnlMenu.TabIndex = 8;
            // 
            // tlpMenu
            // 
            tlpMenu.AutoSize = true;
            tlpMenu.ColumnCount = 2;
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.54348F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.456522F));
            tlpMenu.Controls.Add(btnMenu, 1, 0);
            tlpMenu.Controls.Add(label2, 0, 0);
            tlpMenu.Dock = DockStyle.Top;
            tlpMenu.Location = new Point(0, 0);
            tlpMenu.Margin = new Padding(0);
            tlpMenu.Name = "tlpMenu";
            tlpMenu.RowCount = 1;
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            tlpMenu.Size = new Size(510, 91);
            tlpMenu.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.BackgroundImageLayout = ImageLayout.None;
            btnMenu.Dock = DockStyle.Fill;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = Color.DimGray;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(385, 0);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(125, 91);
            btnMenu.TabIndex = 0;
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(385, 91);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.AutoSize = true;
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(4, 4, 4, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(510, 0);
            panel7.TabIndex = 7;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.AutoSize = true;
            pnlTitleBar.BackColor = Color.SteelBlue;
            tlpFrmMain.SetColumnSpan(pnlTitleBar, 2);
            pnlTitleBar.Controls.Add(label1);
            pnlTitleBar.Dock = DockStyle.Fill;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Margin = new Padding(0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1750, 83);
            pnlTitleBar.TabIndex = 3;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(524, 83);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH QUẢN LÝ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlShowForm
            // 
            pnlShowForm.Dock = DockStyle.Fill;
            pnlShowForm.Location = new Point(510, 83);
            pnlShowForm.Margin = new Padding(0);
            pnlShowForm.Name = "pnlShowForm";
            pnlShowForm.Size = new Size(1240, 1461);
            pnlShowForm.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            // 
            // CollapseTimer
            // 
            CollapseTimer.Enabled = true;
            CollapseTimer.Interval = 10;
            // 
            // UC_Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpFrmMain);
            Margin = new Padding(0);
            MinimumSize = new Size(1664, 1382);
            Name = "UC_Main";
            Size = new Size(1750, 1544);
            tlpFrmMain.ResumeLayout(false);
            tlpFrmMain.PerformLayout();
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
            pnlSubMenuDsnv.ResumeLayout(false);
            pnlQuanLyNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbArrowQLNV).EndInit();
            panel12.ResumeLayout(false);
            pnlSubMenuDssp.ResumeLayout(false);
            pnlDssp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbArrowQLSP).EndInit();
            pnlSubMenuKho.ResumeLayout(false);
            pnlDsKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbArrowQLK).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            tlpMenu.ResumeLayout(false);
            pnlTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpFrmMain;
        private Panel pnlSideBar;
        private Panel pnlShowForm;
        private Button btnQuanLyKho;
        private Panel pnlTitleBar;
        private Label label1;
        private Panel panel7;
        private Panel pnlMenu;
        private TableLayoutPanel tlpMenu;
        private Button btnMenu;
        private Label label2;
        private PictureBox pbLogo;
        private Panel pnlDssp;
        private Panel pnlSubMenuKho;
        private Panel pnlDsKho;
        private Panel pnlSubMenuQLTK;
        private Panel pnlSubMenuDssp;
        private Button btnQuanLySanPham;
        private Button btnDsk;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button btnDst;
        private Button button9;
        private Button btnQLDN;
        private Panel panel12;
        private Button btnLogout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer CollapseTimer;
        private PictureBox pbArrowQLSP;
        private PictureBox pbArrowQLK;
        private Panel pnlSubMenuDsnv;
        private Button btnDsnv;
        private Panel pnlQuanLyNhanVien;
        private PictureBox pbArrowQLNV;
        private Button btnQLNS;
        private Button btnQLDX;
        private Button button1;
        private Button btnDsl;
        private Button btnDscn;
        private Button btnDsnt;
    }
}
