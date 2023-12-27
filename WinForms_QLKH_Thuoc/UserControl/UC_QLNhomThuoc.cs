using FormQLKH.Services;
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
    public partial class UC_QLNhomThuoc : UserControl
    {
        private readonly NThuocService nThuocService;
        public UC_QLNhomThuoc()
        {
            InitializeComponent();
            dgvQLNT.AutoGenerateColumns = false;

            nThuocService = new NThuocService("https://localhost:7195");

            LoadDataGridView();
            LoadComboBox();
        }
        private async void LoadDataGridView()
        {
            try
            {
                List<NhomThuoc> dsnt = nThuocService.LayDSNT();

                if (dsnt != null)
                {
                    dgvQLNT.DataSource = dsnt;

                    foreach (DataGridViewColumn column in dgvQLNT.Columns)
                    {
                        column.ReadOnly = true;
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
        private void dgvQLNT_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rowIndex = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgvQLNT.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIndex, Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        private void dgvQLNT_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQLNT.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvQLNT.SelectedRows[0];

                string maNhom = Convert.ToString(selectedRow.Cells["Nhom_ID"].Value);
                string tenNhom = Convert.ToString(selectedRow.Cells["Nhom_Name"].Value);
                string ghiChu = Convert.ToString(selectedRow.Cells["Description"].Value);

                txtQLNT_MaNhom.ReadOnly = true;
                txtQLNT_MaNhom.Text = maNhom;
                txtQLNT_TenNhom.Text = tenNhom;
                txtQLNT_GhiChu.Text = ghiChu;
            }
        }
        private void LoadComboBox()
        {
            try
            {
                // Load cbQLNT_TK_MaNhom
                List<NhomThuoc> dsNT = nThuocService.LayDSNT();
                dsNT.Insert(0, new NhomThuoc { Nhom_ID = "All" });

                cbQLNT_TK_MaNhom.DataSource = dsNT;
                cbQLNT_TK_MaNhom.DisplayMember = "Nhom_ID";
                cbQLNT_TK_MaNhom.ValueMember = "Nhom_ID";
                cbQLNT_TK_MaNhom.DropDownStyle = ComboBoxStyle.DropDownList;

                if (dsNT.Count > 0)
                {
                    cbQLNT_TK_MaNhom.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
