using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAPI_QLKH.Models;
using WebAPI_QLKH.Services;

namespace FormQLKH
{
    public partial class UC_QLDonNhap : UserControl
    {
        private readonly DNhapService dNhapService;
        private readonly NCCService nCCService;
        private readonly NhanVienService nvService;
        public UC_QLDonNhap()
        {
            InitializeComponent();
            dgvQLDN.AutoGenerateColumns = false;

            dNhapService = new DNhapService("https://localhost:7195");
            nCCService = new NCCService("https://localhost:7195");
            nvService = new NhanVienService("https://localhost:7195");

            LoadDataGridView();
            LoadComboBox();
        }
        private async void LoadDataGridView()
        {
            try
            {
                List<DonNhap> dsdn = dNhapService.LayDSDN();

                if (dsdn != null)
                {
                    dgvQLDN.DataSource = dsdn;

                    foreach (DataGridViewColumn column in dgvQLDN.Columns)
                    {
                        column.ReadOnly = true;
                        dgvQLDN.Columns["DN_Datetime"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }
                }
                else
                {
                    MessageBox.Show("Không thể lấy dữ liệu từ API.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvQLDN_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rowIndex = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgvQLDN.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIndex, Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        private void dgvQLDN_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQLDN.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvQLDN.SelectedRows[0];

                string maDN = Convert.ToString(selectedRow.Cells["DNhap_ID"].Value);
                string tenDN = Convert.ToString(selectedRow.Cells["DN_Name"].Value);
                string maNCC = Convert.ToString(selectedRow.Cells["NCC_ID"].Value);
                string maNV = Convert.ToString(selectedRow.Cells["NV_ID"].Value);
                DateTime ngayNhap = Convert.ToDateTime(selectedRow.Cells["DN_Datetime"].Value);

                txtQLDN_MaDN.Text = maDN;
                txtQLDN_TenDN.Text = tenDN;
                cbQLDN_MaNCC.Text = maNCC;
                cbQLDN_MaNV.Text = maNV;
                dtpQLDN_NgayNhap.Value = ngayNhap;

                txtQLDN_MaDN.ReadOnly = true;
            }
        }
        private void LoadComboBox()
        {
            try
            {
                // Load cbQLDN_MaNCC
                List<NCC> dsNCC = nCCService.LayDS_NCC();

                cbQLDN_MaNCC.DataSource = dsNCC;
                cbQLDN_MaNCC.DisplayMember = "NCC_ID";
                cbQLDN_MaNCC.ValueMember = "NCC_ID";
                cbQLDN_MaNCC.DropDownStyle = ComboBoxStyle.DropDownList;

                if (dsNCC.Count > 0)
                {
                    cbQLDN_MaNCC.SelectedIndex = 0;
                }

                // Load cbQLDN_MaNV
                List<NhanVien> dsnv = nvService.LayDSNV();

                cbQLDN_MaNV.DataSource = dsnv;
                cbQLDN_MaNV.DisplayMember = "NV_ID";
                cbQLDN_MaNV.ValueMember = "NV_ID";
                cbQLDN_MaNV.DropDownStyle = ComboBoxStyle.DropDownList;

                if (dsnv.Count > 0)
                {
                    cbQLDN_MaNV.SelectedIndex = 0;
                }

                // Load cbQLDN_TK_MaNV
                List<NhanVien> dsnv1 = new List<NhanVien>(dsnv);
                dsnv1.Insert(0, new NhanVien { NV_ID = "All" });

                cbQLDN_TK_MaNV.DataSource = dsnv1;
                cbQLDN_TK_MaNV.DisplayMember = "NV_ID";
                cbQLDN_TK_MaNV.ValueMember = "NV_ID";
                cbQLDN_TK_MaNV.DropDownStyle = ComboBoxStyle.DropDownList;

                if (dsnv1.Count > 0)
                {
                    cbQLDN_TK_MaNV.SelectedIndex = 0;
                }

                // Load cbQLDN_TK_MaDN
                List<DonNhap> dsdn = dNhapService.LayDSDN();
                dsdn.Insert(0, new DonNhap { DNhap_ID = "All" });

                cbQLDN_TK_MaDN.DataSource = dsdn;
                cbQLDN_TK_MaDN.DisplayMember = "DNhap_ID";
                cbQLDN_TK_MaDN.ValueMember = "DNhap_ID";
                cbQLDN_TK_MaDN.DropDownStyle = ComboBoxStyle.DropDownList;

                if (dsdn.Count > 0)
                {
                    cbQLDN_TK_MaDN.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
