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
    public partial class UC_QLDonXuat : UserControl
    {
        private readonly DXuatService dXuatService;
        private readonly NhanVienService nvService;
        public UC_QLDonXuat()
        {
            InitializeComponent();
            dgvQLDX.AutoGenerateColumns = false;

            dXuatService = new DXuatService("https://localhost:7195");
            nvService = new NhanVienService("https://localhost:7195");

            LoadDataGridView();
            LoadComboBox();
        }
        private async void LoadDataGridView()
        {
            try
            {
                List<DonXuat> dsdx = dXuatService.LayDSDX();

                if (dsdx != null)
                {
                    dgvQLDX.DataSource = dsdx;

                    foreach (DataGridViewColumn column in dgvQLDX.Columns)
                    {
                        column.ReadOnly = true;
                        dgvQLDX.Columns["DX_Datetime"].DefaultCellStyle.Format = "dd/MM/yyyy";
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
        private void dgvQLDX_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rowIndex = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgvQLDX.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIndex, Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        private void dgvQLDX_SelectionChanged(object sender, EventArgs e)
        {
            dgvQLDX.SuspendLayout();

            if (dgvQLDX.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvQLDX.SelectedRows[0];

                string maDX = Convert.ToString(selectedRow.Cells["DXuat_ID"].Value);
                string tenDX = Convert.ToString(selectedRow.Cells["DX_Name"].Value);
                string maNV = Convert.ToString(selectedRow.Cells["NV_ID"].Value);
                DateTime ngayXuat = Convert.ToDateTime(selectedRow.Cells["DX_Datetime"].Value);

                txtQLDX_MaDX.Text = maDX;
                txtQLDX_TenDX.Text = tenDX;
                cbQLDX_MaNV.Text = maNV;
                dtpQLDX_NgayXuat.Value = ngayXuat;

                txtQLDX_MaDX.ReadOnly = true;
            }

            dgvQLDX.ResumeLayout();
            dgvQLDX.PerformLayout();
        }
        private void LoadComboBox()
        {
            try
            {
                // Load cbQLDX_MaNV
                List<NhanVien> dsnv = nvService.LayDSNV();

                cbQLDX_MaNV.DataSource = dsnv;
                cbQLDX_MaNV.DisplayMember = "NV_ID";
                cbQLDX_MaNV.ValueMember = "NV_ID";
                cbQLDX_MaNV.DropDownStyle = ComboBoxStyle.DropDownList;

                if (dsnv.Count > 0)
                {
                    cbQLDX_MaNV.SelectedIndex = 0;
                }

                // Load cbQLDX_TK_MaNV
                List<NhanVien> dsnv1 = new List<NhanVien>(dsnv);
                dsnv1.Insert(0, new NhanVien { NV_ID = "All" });

                cbQLDX_TK_MaNV.DataSource = dsnv1;
                cbQLDX_TK_MaNV.DisplayMember = "NV_ID";
                cbQLDX_TK_MaNV.ValueMember = "NV_ID";
                cbQLDX_TK_MaNV.DropDownStyle = ComboBoxStyle.DropDownList;

                if (dsnv1.Count > 0)
                {
                    cbQLDX_TK_MaNV.SelectedIndex = 0;
                }

                // Load cbQLDX_TK_MaDX
                List<DonXuat> dsdx = dXuatService.LayDSDX();
                dsdx.Insert(0, new DonXuat { DXuat_ID = "All" });

                cbQLDX_TK_MaDX.DataSource = dsdx;
                cbQLDX_TK_MaDX.DisplayMember = "DXuat_ID";
                cbQLDX_TK_MaDX.ValueMember = "DXuat_ID";
                cbQLDX_TK_MaDX.DropDownStyle = ComboBoxStyle.DropDownList;

                if (dsdx.Count > 0)
                {
                    cbQLDX_TK_MaDX.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
