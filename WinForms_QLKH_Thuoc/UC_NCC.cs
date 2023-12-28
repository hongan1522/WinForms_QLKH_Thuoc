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
    public partial class UC_NCC : UserControl
    {
        private readonly NCCService nccService;
        public UC_NCC()
        {
            InitializeComponent();
            dgvNCC.AutoGenerateColumns = false;

            nccService = new NCCService("https://localhost:7195");

            LoadDataGridView();
            LoadComboBox();
        }
        private async void LoadDataGridView()
        {
            try
            {
                List<NCC> dsNCC = nccService.LayDS_NCC();

                if (dsNCC != null)
                {
                    dgvNCC.DataSource = dsNCC;

                    foreach (DataGridViewColumn column in dgvNCC.Columns)
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
        private void dgvNCC_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rowIndex = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgvNCC.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIndex, Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        private void dgvNCC_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvNCC.SelectedRows[0];

                string maNCC = Convert.ToString(selectedRow.Cells["NCC_ID"].Value);
                string hoTen = Convert.ToString(selectedRow.Cells["NCC_Name"].Value);
                string sdt = Convert.ToString(selectedRow.Cells["NCC_Phone"].Value);
                string address = Convert.ToString(selectedRow.Cells["NCC_Address"].Value);
                int sldn = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);

                txtNCC_MaNCC.Text = maNCC;
                txtNCC_TenNCC.Text = hoTen;
                txtNCC_SDT.Text = sdt;
                txtNCC_DiaChi.Text = address;
                numNCC_SoLuongDN.Value = sldn;
                txtNCC_MaNCC.ReadOnly = true;
            }
        }
        private void LoadComboBox()
        {
            try
            {
                // Load cbNCC_TK_MaNCC
                List<NCC> dsNCC = nccService.LayDS_NCC();
                dsNCC.Insert(0, new NCC { NCC_ID = "All" });

                cbNCC_TK_MaNCC.DataSource = dsNCC;
                cbNCC_TK_MaNCC.DisplayMember = "NCC_ID";
                cbNCC_TK_MaNCC.ValueMember = "NCC_ID";
                cbNCC_TK_MaNCC.DropDownStyle = ComboBoxStyle.DropDownList;

                if (dsNCC.Count > 0)
                {
                    cbNCC_TK_MaNCC.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
