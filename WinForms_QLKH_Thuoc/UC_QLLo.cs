using FormQLKH.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WebAPI_QLKH.Controllers;
using WebAPI_QLKH.Models;
using WebAPI_QLKH.Services;
using static WebAPI_QLKH.Controllers.LoController;
using static WebAPI_QLKH.Controllers.ChiNhanhController;
using static WebAPI_QLKH.Controllers.KhoController;
using Azure;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace FormQLKH
{
    public partial class UC_QLLo : UserControl
    {
        private readonly LoService loService;
        private readonly KhoService khoService;

        public UC_QLLo()
        {
            InitializeComponent();
            dgvQLLo.AutoGenerateColumns = false;

            loService = new LoService("https://localhost:7195");
            khoService = new KhoService("https://localhost:7195");

            LoadDataGridView();
            LoadComboBoxMaKho();
            ViTriComboBox();
        }
        private async void LoadDataGridView()
        {
            try
            {
                List<Lo> danhSachLo = await loService.LayDanhSachLo();

                if (danhSachLo != null)
                {
                    dgvQLLo.DataSource = danhSachLo;

                    foreach (DataGridViewColumn column in dgvQLLo.Columns)
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

        private async void LoadComboBoxMaKho()
        {
            try
            {
                List<Kho> danhSachMaKho = khoService.LayDanhSachKho();

                // Load cbQLLo_MaKho
                cbQLLo_MaKho.DataSource = danhSachMaKho;
                cbQLLo_MaKho.DisplayMember = "Kho_ID";
                cbQLLo_MaKho.ValueMember = "Kho_ID";
                cbQLLo_MaKho.DropDownStyle = ComboBoxStyle.DropDownList;

                if (danhSachMaKho.Count > 0)
                {
                    cbQLLo_MaKho.SelectedIndex = 0;
                }

                // Load cbQLLo_TK_MaKho
                List<Kho> danhSachMaKho1 = new List<Kho>(danhSachMaKho);
                danhSachMaKho1.Insert(0, new Kho { Kho_ID = "All" });

                cbQLLo_TK_MaKho.DataSource = danhSachMaKho1;
                cbQLLo_TK_MaKho.DisplayMember = "Kho_ID";
                cbQLLo_TK_MaKho.ValueMember = "Kho_ID";
                cbQLLo_TK_MaKho.DropDownStyle = ComboBoxStyle.DropDownList;

                if (danhSachMaKho1.Count > 0)
                {
                    cbQLLo_TK_MaKho.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string TaoMaLoTuDong()
        {
            List<string> danhSachMaLo = dgvQLLo.Rows
                .Cast<DataGridViewRow>()
                .Select(row => row.Cells["MaLo"].Value.ToString())
                .ToList();

            for (int i = 1; i <= danhSachMaLo.Count + 1; i++)
            {
                string maDinhDang = "Lo" + i;
                if (!danhSachMaLo.Any(ma => ma.Trim().Equals(maDinhDang, StringComparison.OrdinalIgnoreCase)))
                {
                    return maDinhDang;
                }
            }

            if (danhSachMaLo.Count > 0)
            {
                string maLonNhat = danhSachMaLo.Max();
                if (int.TryParse(maLonNhat.Substring(4), out int so))
                {
                    return "Lo" + (so + 1).ToString();
                }
            }

            return "Lo1";
        }
        private async void btnQLLo_Them_Click(object sender, EventArgs e)
        {
            string maLo = TaoMaLoTuDong();
            string maKho = cbQLLo_MaKho.Text.Trim();
            string tenLo = txtQLLo_TenLo.Text.Trim();
            string viTri = cbQLLo_ViTri.Text.Trim();

            if (string.IsNullOrEmpty(tenLo))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var payloads = new LoPost
            {
                Lo_ID = maLo,
                Kho_ID = maKho,
                Lo_Name = tenLo,
                Lo_Position = viTri
            };

            var response = await loService.ThemLo(payloads);

            if (response.IsSuccessful)
            {
                MessageBox.Show($"Thêm lô {maLo} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show($"Thêm lô thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnQLLo_Sua_Click(object sender, EventArgs e)
        {
            var selectedLo = dgvQLLo.SelectedRows[0].DataBoundItem as Lo;

            if (string.IsNullOrEmpty(txtQLLo_TenLo.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var loPut = new LoPut
            {
                Lo_Name = txtQLLo_TenLo.Text,
                Lo_Position = cbQLLo_ViTri.SelectedItem.ToString()
            };

            var response = await loService.CapNhatLo(selectedLo.Lo_ID, loPut);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Cập nhật lô {txtQLLo_MaLo.Text.Trim()} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Cập nhật lô thất bại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnQLLo_Xoa_Click(object sender, EventArgs e)
        {
            string maLo = txtQLLo_MaLo.Text.Trim();

            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa lô {maLo}?", "Xác nhận xóa",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                var response = await loService.XoaLo(maLo);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Xóa lô {maLo} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Xóa lô thất bại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvQLLo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rowIndex = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgvQLLo.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIndex, Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        private void ViTriComboBox()
        {
            cbQLLo_ViTri.Items.AddRange(new object[] { "A", "B", "C", "D" });

            cbQLLo_ViTri.SelectedIndex = 0;
            cbQLLo_ViTri.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void dgvQLLo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQLLo.SelectedRows.Count > 0)
            {
                var selectedLo = dgvQLLo.SelectedRows[0].DataBoundItem as Lo;

                if (selectedLo != null)
                {
                    txtQLLo_MaLo.Text = selectedLo.Lo_ID;
                    cbQLLo_MaKho.SelectedItem = selectedLo.Kho_ID;
                    txtQLLo_TenLo.Text = selectedLo.Lo_Name;
                    cbQLLo_ViTri.SelectedItem = selectedLo.Lo_Position;

                    txtQLLo_MaLo.ReadOnly = true;
                }
            }
        }
        private async void TimKiemTheoMaKhoMaLo(string maKho, string maLo)
        {
            try
            {
                List<Lo> danhSachLo = await loService.LayDanhSachLo();

                if (danhSachLo != null)
                {
                    var filteredKho = danhSachLo;

                    if (!string.IsNullOrEmpty(maKho) && !maKho.Equals("All"))
                    {
                        filteredKho = danhSachLo.Where(lo =>
                            (string.IsNullOrEmpty(maKho) || lo.Kho_ID.Contains(maKho)) &&
                            (string.IsNullOrEmpty(maLo) || lo.Lo_ID.Contains(maLo))
                        ).ToList();
                    }
                    else
                    {
                        filteredKho = danhSachLo.Where(lo =>
                            (string.IsNullOrEmpty(maLo) || lo.Lo_ID.Contains(maLo))
                        ).ToList();
                    }

                    dgvQLLo.DataSource = filteredKho;
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
        private void txtQLLo_TK_MaLo_TextChanged(object sender, EventArgs e)
        {
            string selectedValue = cbQLLo_TK_MaKho.SelectedValue?.ToString();
            string maLo = txtQLLo_TK_MaLo.Text.Trim();

            if (string.IsNullOrEmpty(maLo))
            {
                LoadDataGridView();
            }
            else
            {
                TimKiemTheoMaKhoMaLo(selectedValue, maLo);
            }
        }
        private void cbQLLo_TK_MaKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbQLLo_TK_MaKho.SelectedItem is Kho selectedKho)
            {
                string selectedValue = selectedKho.Kho_ID;
                string maLo = txtQLLo_TK_MaLo.Text.Trim();

                TimKiemTheoMaKhoMaLo(selectedValue, maLo);
            }
        }
    }
}
