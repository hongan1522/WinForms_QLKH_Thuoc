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
    public partial class UC_QLThuoc : UserControl
    {
        private readonly ThuocService thuocService;
        private readonly NThuocService nThuocService;
        public UC_QLThuoc()
        {
            InitializeComponent();
            dgvQLT.AutoGenerateColumns = false;

            thuocService = new ThuocService("https://localhost:7195");
            nThuocService = new NThuocService("https://localhost:7195");

            LoadDataGridView();
            LoadComboBox();
        }
        private async void LoadDataGridView()
        {
            try
            {
                List<Thuoc> dsThuoc = thuocService.LayDSThuoc();

                if (dsThuoc != null)
                {
                    dgvQLT.DataSource = dsThuoc;

                    foreach (DataGridViewColumn column in dgvQLT.Columns)
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
        private void dgvQLT_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rowIndex = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgvQLT.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIndex, Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        private void dgvQLT_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQLT.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvQLT.SelectedRows[0];

                string maThuoc = Convert.ToString(selectedRow.Cells["Thuoc_ID"].Value);
                string tenThuoc = Convert.ToString(selectedRow.Cells["Thuoc_Name"].Value);
                string maNhom = Convert.ToString(selectedRow.Cells["Nhom_ID"].Value);

                txtQLT_MaThuoc.ReadOnly = true;
                cbQLT_MaNhom.Text = maNhom;
                txtQLT_MaThuoc.Text = maThuoc;
                txtQLT_TenThuoc.Text = tenThuoc;
            }
        }
        private void LoadComboBox()
        {
            try
            {
                // Load cbQLT_MaNhom
                List<NhomThuoc> dsNT = nThuocService.LayDSNT();

                cbQLT_MaNhom.DataSource = dsNT;
                cbQLT_MaNhom.DisplayMember = "Nhom_ID";
                cbQLT_MaNhom.ValueMember = "Nhom_ID";
                cbQLT_MaNhom.DropDownStyle = ComboBoxStyle.DropDownList;

                if (dsNT.Count > 0)
                {
                    cbQLT_MaNhom.SelectedIndex = 0;
                }

                // Load cbQLT_TK_MaThuoc
                List<Thuoc> dsThuoc = thuocService.LayDSThuoc();

                cbQLT_TK_MaThuoc.DataSource = dsThuoc;
                cbQLT_TK_MaThuoc.DisplayMember = "Thuoc_ID";
                cbQLT_TK_MaThuoc.ValueMember = "Thuoc_ID";
                cbQLT_TK_MaThuoc.DropDownStyle = ComboBoxStyle.DropDownList;

                if (dsThuoc.Count > 0)
                {
                    cbQLT_TK_MaThuoc.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
