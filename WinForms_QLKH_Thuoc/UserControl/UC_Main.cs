using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp;

namespace FormQLKH
{
    public partial class UC_Main : UserControl
    {
        public UC_Main()
        {
            InitializeComponent();

            Load += UC_Main_Load;
        }
        private void ShowUC_QLChiNhanh()
        {
            UC_QLChiNhanh ucCN = new UC_QLChiNhanh();

            pnlShowForm.Controls.Clear();
            ucCN.Parent = pnlShowForm;
            ucCN.Dock = DockStyle.Fill;
            ucCN.Show();
        }
        private void UC_Main_Load(object sender, EventArgs e)
        {
            ShowUC_QLChiNhanh();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();

            Form parentForm = FindForm();
            if (parentForm is FrmMain frmMain)
            {
                frmMain.Hide();
            }

            frmLogin.Show();
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            UC_QLTaiKhoan ucUser = new UC_QLTaiKhoan();

            pnlShowForm.Controls.Clear();
            ucUser.Parent = pnlShowForm;
            ucUser.Dock = DockStyle.Fill;
            ucUser.Show();
        }
        private void btnQLNV_Click(object sender, EventArgs e)
        {
            UC_QLNV ucNV = new UC_QLNV();

            pnlShowForm.Controls.Clear();
            ucNV.Parent = pnlShowForm;
            ucNV.Dock = DockStyle.Fill;
            ucNV.Show();
        }
        private void btnQLNT_Click(object sender, EventArgs e)
        {
            UC_QLNhomThuoc ucNT = new UC_QLNhomThuoc();

            pnlShowForm.Controls.Clear();
            ucNT.Parent = pnlShowForm;
            ucNT.Dock = DockStyle.Fill;
            ucNT.Show();
        }
        private void btnQLT_Click(object sender, EventArgs e)
        {
            UC_QLThuoc ucThuoc = new UC_QLThuoc();

            pnlShowForm.Controls.Clear();
            ucThuoc.Parent = pnlShowForm;
            ucThuoc.Dock = DockStyle.Fill;
            ucThuoc.Show();
        }
        private void btnQLDX_Click(object sender, EventArgs e)
        {
            UC_QLDonXuat ucDX = new UC_QLDonXuat();

            pnlShowForm.Controls.Clear();
            ucDX.Parent = pnlShowForm;
            ucDX.Dock = DockStyle.Fill;
            ucDX.Show();
        }
        private void btnQLDN_Click(object sender, EventArgs e)
        {
            UC_QLDonNhap ucDN = new UC_QLDonNhap();

            pnlShowForm.Controls.Clear();
            ucDN.Parent = pnlShowForm;
            ucDN.Dock = DockStyle.Fill;
            ucDN.Show();
        }
        private void btnQLLo_Click(object sender, EventArgs e)
        {
            UC_QLLo ucLo = new UC_QLLo();

            pnlShowForm.Controls.Clear();
            ucLo.Parent = pnlShowForm;
            ucLo.Dock = DockStyle.Fill;
            ucLo.Show();
        }
        private void btnQLK_Click(object sender, EventArgs e)
        {
            UC_QLKho ucKho = new UC_QLKho();

            pnlShowForm.Controls.Clear();
            ucKho.Parent = pnlShowForm;
            ucKho.Dock = DockStyle.Fill;
            ucKho.Show();
        }
        private void btnQLCN_Click(object sender, EventArgs e)
        {
            ShowUC_QLChiNhanh();
        }
        private void btnNCC_Click(object sender, EventArgs e)
        {
            UC_NCC ucNCC = new UC_NCC();

            pnlShowForm.Controls.Clear();
            ucNCC.Parent = pnlShowForm;
            ucNCC.Dock = DockStyle.Fill;
            ucNCC.Show();
        }

        private bool isSubMenuVisible = true;

        private void ToggleQLK()
        {
            if (isSubMenuVisible)
            {
                pnlSubMenuKho.Visible = false;
                pbArrowQLK.Image = Properties.Resources.up_arrow;
            }
            else
            {
                pnlSubMenuKho.Visible = true;
                pbArrowQLK.Image = Properties.Resources.down_arrow;
            }

            isSubMenuVisible = !isSubMenuVisible;
        }
        private void pbArrowQLK_Click(object sender, EventArgs e)
        {
            ToggleQLK();
        }
        private void btnQuanLyKho_Click(object sender, EventArgs e)
        {
            ToggleQLK();
        }

        private void ToggleQLSP()
        {
            if (isSubMenuVisible)
            {
                pnlSubMenuDssp.Visible = false;
                pbArrowQLSP.Image = Properties.Resources.up_arrow;
            }
            else
            {
                pnlSubMenuDssp.Visible = true;
                pbArrowQLSP.Image = Properties.Resources.down_arrow;
            }

            isSubMenuVisible = !isSubMenuVisible;
        }
        private void pbArrowQLSP_Click(object sender, EventArgs e)
        {
            ToggleQLSP();
        }
        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            ToggleQLSP();
        }

        private void ToggleQLNV()
        {
            if (isSubMenuVisible)
            {
                pnlSubMenuDsnv.Visible = false;
                pbArrowQLNS.Image = Properties.Resources.up_arrow;
            }
            else
            {
                pnlSubMenuDsnv.Visible = true;
                pbArrowQLNS.Image = Properties.Resources.down_arrow;
            }

            isSubMenuVisible = !isSubMenuVisible;
        }
        private void pbArrowQLNS_Click(object sender, EventArgs e)
        {
            ToggleQLNV();
        }
        private void btnQLNS_Click(object sender, EventArgs e)
        {
            ToggleQLNV();
        }
    }
}
