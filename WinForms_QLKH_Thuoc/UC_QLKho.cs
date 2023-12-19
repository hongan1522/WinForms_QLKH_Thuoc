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
using static WebAPI_QLKH.Controllers.KhoController;
using WebAPI_QLKH.Services;
using static WebAPI_QLKH.Controllers.ChiNhanhController;

namespace FormQLKH
{
    public partial class UC_QLKho : UserControl
    {
        private readonly KhoService khoService;
        private readonly ChiNhanhService chiNhanhService;
        public UC_QLKho()
        {
            InitializeComponent();

            dgvQLK.AutoGenerateColumns = false;
            cbQLK_MaCN.DropDownStyle = ComboBoxStyle.DropDownList;

            khoService = new KhoService("https://localhost:7195");
            chiNhanhService = new ChiNhanhService("https://localhost:7195");
            LoadComboBoxMaCN();
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            try
            {
                List<Kho> danhSachKho = khoService.LayDanhSachKho();

                if (danhSachKho != null)
                {
                    dgvQLK.DataSource = danhSachKho;

                    foreach (DataGridViewColumn column in dgvQLK.Columns)
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
        private void LoadComboBoxMaCN()
        {
            try
            {
                List<ChiNhanh> danhSachMaCN = chiNhanhService.LayDanhSachChiNhanh();

                // Load cbQLK_MaCN
                cbQLK_MaCN.DataSource = danhSachMaCN;
                cbQLK_MaCN.DisplayMember = "CN_ID";
                cbQLK_MaCN.ValueMember = "CN_ID";
                cbQLK_MaCN.DropDownStyle = ComboBoxStyle.DropDownList;

                if (danhSachMaCN.Count > 0)
                {
                    cbQLK_MaCN.SelectedIndex = 0;
                }

                // Load cbQLK_TK_MaCN
                List<ChiNhanh> danhSachMaCN1 = new List<ChiNhanh>(danhSachMaCN);
                danhSachMaCN1.Insert(0, new ChiNhanh { CN_ID = "All" });

                cbQLK_TK_MaCN.DataSource = danhSachMaCN1;
                cbQLK_TK_MaCN.DisplayMember = "CN_ID";
                cbQLK_TK_MaCN.ValueMember = "CN_ID";
                cbQLK_TK_MaCN.DropDownStyle = ComboBoxStyle.DropDownList;

                if (danhSachMaCN1.Count > 0)
                {
                    cbQLK_TK_MaCN.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvQLK_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQLK.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvQLK.SelectedRows[0];

                string maKho = Convert.ToString(selectedRow.Cells["MaKho"].Value);
                string maCN = Convert.ToString(selectedRow.Cells["MaCN"].Value);
                string tenKho = Convert.ToString(selectedRow.Cells["TenKho"].Value);
                string diaChi = Convert.ToString(selectedRow.Cells["DiaChi"].Value);

                txtQLK_MaKho.Text = maKho;
                txtQLK_TenKho.Text = tenKho;
                txtQLK_DiaChi.Text = diaChi;
                cbQLK_MaCN.Text = maCN;

                txtQLK_MaKho.ReadOnly = true;
            }
        }
        private void dgvQLK_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rowIndex = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgvQLK.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIndex, Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        private string TaoMaKhoTuDong()
        {
            List<string> danhSachMaKho = dgvQLK.Rows
                .Cast<DataGridViewRow>()
                .Select(row => row.Cells["MaKho"].Value.ToString())
                .ToList();

            for (int i = 1; i <= danhSachMaKho.Count + 1; i++)
            {
                string maDinhDang = "Kho" + i;
                if (!danhSachMaKho.Any(ma => ma.Trim().Equals(maDinhDang, StringComparison.OrdinalIgnoreCase)))
                {
                    return maDinhDang;
                }
            }

            if (danhSachMaKho.Count > 0)
            {
                string maLonNhat = danhSachMaKho.Max();
                if (int.TryParse(maLonNhat.Substring(4), out int so))
                {
                    return "Kho" + (so + 1).ToString();
                }
            }

            return "Kho1";
        }
        private void btnQLK_Them_Click(object sender, EventArgs e)
        {
            string maKho = TaoMaKhoTuDong();
            string maCN = cbQLK_MaCN.Text.Trim();
            string tenKho = txtQLK_TenKho.Text.Trim();
            string diaChi = txtQLK_DiaChi.Text.Trim();

            if (string.IsNullOrEmpty(maCN) || string.IsNullOrEmpty(maKho) || string.IsNullOrEmpty(tenKho) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var payloads = new List<KhoPost>
            {
                new KhoPost
                {
                    CN_ID = maCN,
                    Kho_ID = maKho,
                    Kho_Name = tenKho,
                    Kho_Address = diaChi
                }
            };

            var response = khoService.ThemKho(payloads);

            if (response.IsSuccessful)
            {
                MessageBox.Show($"Thêm kho {maKho} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show($"Thêm kho thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnQLK_Sua_Click(object sender, EventArgs e)
        {
            string maKho = txtQLK_MaKho.Text.Trim();
            string tenKho = txtQLK_TenKho.Text.Trim();
            string diaChi = txtQLK_DiaChi.Text.Trim();
            string maCN = cbQLK_MaCN.Text.Trim();

            if (string.IsNullOrEmpty(maKho) || string.IsNullOrEmpty(tenKho) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var payload = new KhoPost
            {
                CN_ID = maCN,
                Kho_ID = maKho,
                Kho_Name = tenKho,
                Kho_Address = diaChi
            };

            var response = khoService.CapNhatKho(maKho, payload);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Cập nhật kho {maKho} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Cập nhật kho thất bại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnQLK_Xoa_Click(object sender, EventArgs e)
        {
            string maKho = txtQLK_MaKho.Text.Trim();

            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa kho {maKho}?", "Xác nhận xóa",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                var response = khoService.XoaKho(maKho);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Xóa kho {maKho} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Xóa kho thất bại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async void TimKiemTheoMaKhoMaCN(string maCN, string maKho)
        {
            try
            {
                List<Kho> danhSachKho = khoService.LayDanhSachKho();

                if (danhSachKho != null)
                {
                    var filteredKho = danhSachKho;

                    if (!string.IsNullOrEmpty(maCN) && !maCN.Equals("All"))
                    {
                        filteredKho = danhSachKho.Where(kho =>
                            (string.IsNullOrEmpty(maKho) || kho.Kho_ID.Contains(maKho)) &&
                            (string.IsNullOrEmpty(maCN) || kho.CN_ID.Contains(maCN))
                        ).ToList();
                    }
                    else
                    {
                        filteredKho = danhSachKho.Where(kho =>
                            (string.IsNullOrEmpty(maKho) || kho.Kho_ID.Contains(maKho))
                        ).ToList();
                    }

                    dgvQLK.DataSource = filteredKho;
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
        private void txtQLK_TK_MaKho_TextChanged(object sender, EventArgs e)
        {
            string selectedValue = cbQLK_TK_MaCN.SelectedValue?.ToString();
            string maKho = txtQLK_TK_MaKho.Text.Trim();

            if (string.IsNullOrEmpty(maKho))
            {
                LoadDataGridView();
            }
            else
            {
                TimKiemTheoMaKhoMaCN(selectedValue, maKho);
            }
        }
        private void cbQLK_TK_MaCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbQLK_TK_MaCN.SelectedItem is ChiNhanh selectedCN)
            {
                string selectedValue = selectedCN.CN_ID;
                string maKho = txtQLK_TK_MaKho.Text.Trim();

                TimKiemTheoMaKhoMaCN(selectedValue, maKho);
            }
        }
    }
}
