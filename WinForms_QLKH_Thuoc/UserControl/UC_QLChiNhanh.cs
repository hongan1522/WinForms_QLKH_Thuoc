using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using FormQLKH.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OfficeOpenXml;
using WebAPI_QLKH.Models;
using WebAPI_QLKH.Services;
using static WebAPI_QLKH.Controllers.ChiNhanhController;

namespace FormQLKH
{
    public partial class UC_QLChiNhanh : UserControl
    {
        private readonly ChiNhanhService chiNhanhService;
        public UC_QLChiNhanh()
        {
            InitializeComponent();
            dgvQLCN.AutoGenerateColumns = false;

            chiNhanhService = new ChiNhanhService("https://localhost:7195");
            LoadDataGridView();
        }
        private void UC_QLChiNhanh_Load(object sender, EventArgs e)
        {
            txtQLCN_TK_MaCN.KeyPress += new KeyPressEventHandler(txtQLCN_TK_MaCN_KeyPress);
        }
        private void LoadDataGridView()
        {
            try
            {
                List<ChiNhanh> danhSachChiNhanh = chiNhanhService.LayDanhSachChiNhanh();

                if (danhSachChiNhanh != null)
                {
                    dgvQLCN.DataSource = danhSachChiNhanh;

                    foreach (DataGridViewColumn column in dgvQLCN.Columns)
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
        private void dgvQLCN_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQLCN.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvQLCN.SelectedRows[0];

                string maCN = Convert.ToString(selectedRow.Cells["MaCN"].Value);
                string tenCN = Convert.ToString(selectedRow.Cells["TenCN"].Value);
                string diaChi = Convert.ToString(selectedRow.Cells["DiaChi"].Value);

                txtQLCN_MaCN.Text = maCN;
                txtQLCN_TenCN.Text = tenCN;
                txtQLCN_DiaChi.Text = diaChi;

                txtQLCN_MaCN.ReadOnly = true;
            }
        }
        private string TaoMaCNTuDong()
        {
            List<string> danhSachMaCN = dgvQLCN.Rows
                .Cast<DataGridViewRow>()
                .Select(row => row.Cells["MaCN"].Value.ToString())
                .ToList();

            for (int i = 1; i <= danhSachMaCN.Count + 1; i++)
            {
                string maDinhDang = "CN" + i;
                if (!danhSachMaCN.Any(ma => ma.Trim().Equals(maDinhDang, StringComparison.OrdinalIgnoreCase)))
                {
                    return maDinhDang;
                }
            }

            if (danhSachMaCN.Count > 0)
            {
                string maLonNhat = danhSachMaCN.Max();
                if (int.TryParse(maLonNhat.Substring(4), out int so))
                {
                    return "CN" + (so + 1).ToString();
                }
            }

            return "CN1";
        }
        private void btnQLCN_Them_Click(object sender, EventArgs e)
        {
            string maCN = TaoMaCNTuDong();
            string tenCN = txtQLCN_TenCN.Text.Trim();
            string diaChi = txtQLCN_DiaChi.Text.Trim();

            if (string.IsNullOrEmpty(maCN) || string.IsNullOrEmpty(tenCN) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var payloads = new List<ChiNhanhPost>
            {
                new ChiNhanhPost
                {
                    CN_ID = maCN,
                    CN_Name = tenCN,
                    CN_Address = diaChi
                }
            };

            var response = chiNhanhService.ThemChiNhanh(payloads);

            if (response.IsSuccessful)
            {
                MessageBox.Show($"Thêm chi nhánh {maCN} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show($"Thêm chi nhánh thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnQLCN_Sua_Click(object sender, EventArgs e)
        {
            string maCN = txtQLCN_MaCN.Text.Trim();
            string tenCN = txtQLCN_TenCN.Text.Trim();
            string diaChi = txtQLCN_DiaChi.Text.Trim();

            if (string.IsNullOrEmpty(maCN) || string.IsNullOrEmpty(tenCN) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var payload = new ChiNhanhPost
            {
                CN_ID = maCN,
                CN_Name = tenCN,
                CN_Address = diaChi
            };

            var response = chiNhanhService.CapNhatChiNhanh(maCN, payload);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Cập nhật chi nhánh {maCN} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Cập nhật chi nhánh thất bại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnQLCN_Xoa_Click(object sender, EventArgs e)
        {
            string maCN = txtQLCN_MaCN.Text.Trim();

            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa chi nhánh {maCN}?", "Xác nhận xóa",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                var response = chiNhanhService.XoaChiNhanh(maCN);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Xóa chi nhánh {maCN} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Xóa chi nhánh thất bại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txtQLCN_TK_MaCN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TimTheoID();
            }
        }
        private void TimTheoID()
        {
            string maCN = txtQLCN_TK_MaCN.Text.Trim();

            if (string.IsNullOrEmpty(maCN))
            {
                LoadDataGridView();
                return;
            }

            var chiNhanh = chiNhanhService.TimKiemTheoID(maCN);

            if (chiNhanh != null)
            {
                txtQLCN_TK_MaCN.Text = chiNhanh.CN_ID;
                dgvQLCN.DataSource = new List<ChiNhanh> { chiNhanh };
            }
            else
            {
                MessageBox.Show($"Không tìm thấy chi nhánh {maCN}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
        }
        private void dgvQLCN_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rowIndex = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgvQLCN.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIndex, Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        private async void TimKiemTheoMaCN(string maCN)
        {
            try
            {
                List<ChiNhanh> danhSachCN = chiNhanhService.LayDanhSachChiNhanh();

                if (danhSachCN != null)
                {
                    var filteredCN = danhSachCN;

                    filteredCN = danhSachCN.Where(cn =>
                        (string.IsNullOrEmpty(maCN) || cn.CN_ID.Contains(maCN))
                    ).ToList();

                    dgvQLCN.DataSource = filteredCN;
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
        private void txtQLCN_TK_MaCN_TextChanged(object sender, EventArgs e)
        {
            string maCN = txtQLCN_TK_MaCN.Text.Trim();

            if (string.IsNullOrEmpty(maCN))
            {
                LoadDataGridView();
            }
            else
            {
                TimKiemTheoMaCN(maCN);
            }
        }
    }
}
