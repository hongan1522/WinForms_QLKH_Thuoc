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
                cbQLLo_MaKho.SelectedIndex = 0;

                // Load cbQLLo_TK_MaKho
                danhSachMaKho.Insert(0, new Kho { Kho_ID = "All" });
                cbQLLo_TK_MaKho.DataSource = danhSachMaKho;
                cbQLLo_TK_MaKho.DisplayMember = "Kho_ID";
                cbQLLo_TK_MaKho.ValueMember = "Kho_ID";
                cbQLLo_TK_MaKho.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnQLLo_Them_Click(object sender, EventArgs e)
        {
            string maLo = txtQLLo_MaLo.Text.Trim();
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
            using (SolidBrush b = new SolidBrush(dgvQLLo.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
        private void ViTriComboBox()
        {
            cbQLLo_ViTri.Items.AddRange(new object[] { "A", "B", "C", "D" });

            cbQLLo_ViTri.SelectedIndex = 0;
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
        private void txtQLLo_TK_MaLo_TextChanged(object sender, EventArgs e)
        {
            TimKiemTheoMaKhoMaLo(cbQLLo_TK_MaKho.SelectedValue?.ToString(), txtQLLo_TK_MaLo.Text.Trim());
        }
        private void cbQLLo_TK_MaKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbQLLo_TK_MaKho.SelectedItem is Kho selectedKho)
            {
                string selectedValue = selectedKho.Kho_ID;
                string maLo = txtQLLo_TK_MaLo.Text.Trim();

                if (selectedValue.Equals("All"))
                {
                    LoadDataGridView();
                }
                else
                {
                    TimKiemTheoMaKhoMaLo(selectedValue, maLo);
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
                    var filteredLos = danhSachLo.Where(lo =>
                        (string.IsNullOrEmpty(maKho) || lo.Kho_ID.Contains(maKho)) &&
                        (string.IsNullOrEmpty(maLo) || lo.Lo_ID.Contains(maLo))
                    ).ToList();

                    dgvQLLo.DataSource = filteredLos;
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
    }
}
