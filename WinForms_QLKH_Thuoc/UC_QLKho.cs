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

                cbQLK_MaCN.DataSource = danhSachMaCN;

                // Thiết lập các thuộc tính hiển thị và giá trị tương ứng
                cbQLK_MaCN.DisplayMember = "CN_ID";
                cbQLK_MaCN.ValueMember = "CN_ID";

                cbQLK_MaCN.SelectedIndex = 0;
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
        private void btnQLK_Them_Click(object sender, EventArgs e)
        {
            string maKho = txtQLK_MaKho.Text.Trim();
            string maCN = cbQLK_MaCN.Text.Trim();
            string tenKho = txtQLK_TenKho.Text.Trim();
            string diaChi = txtQLK_DiaChi.Text.Trim();

            if (string.IsNullOrEmpty(maCN) || string.IsNullOrEmpty(maKho) || string.IsNullOrEmpty(tenKho) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var payloads = new List<KhoPayload>
            {
                new KhoPayload
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

            var payload = new KhoPayload
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
        //private void txtQLK_TK_MaKho_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        TimTheoID();
        //    }
        //}
        //private void TimTheoID()
        //{
        //    string maKho = txtQLK_TK_MaKho.Text.Trim();

        //    if (string.IsNullOrEmpty(maKho))
        //    {
        //        LoadDataGridView();
        //        return;
        //    }

        //    var kho = khoService.TimKiemTheoID(maKho);

        //    if (kho != null)
        //    {
        //        txtQLK_TK_MaKho.Text = kho.Kho_ID;
        //        dgvQLK.DataSource = new List<Kho> {kho};
        //    }
        //    else
        //    {
        //        MessageBox.Show($"Không tìm thấy kho {maKho}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        LoadDataGridView();
        //    }
        //}

        //private void txtQLK_TK_MaKho_TextChanged(object sender, EventArgs e)
        //{
        //    string maKho = txtQLK_TK_MaKho.Text.Trim();

        //    if (string.IsNullOrEmpty(maKho))
        //    {
        //        LoadDataGridView();
        //        return;
        //    }

        //    var danhSachKho = khoService.TimKiemTheoID(maKho);

        //    if (danhSachKho != null)
        //    {
        //        if (danhSachKho.Any())
        //        {
        //            dgvQLK.DataSource = danhSachKho;
        //        }
        //        else
        //        {
        //            dgvQLK.DataSource = null;
        //            dgvQLK.Columns.Clear();
        //            MessageBox.Show($"Không tìm thấy kho có mã chứa '{maKho}'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //}

        private void TimTheoID()
        {
            string maKho = txtQLK_TK_MaKho.Text.Trim();

            if (string.IsNullOrEmpty(maKho))
            {
                LoadDataGridView();
                return;
            }

            var kho = khoService.TimKiemTheoID(maKho);

            if (kho != null)
            {
                txtQLK_TK_MaKho.Text = kho.Kho_ID;
                dgvQLK.DataSource = new List<Kho> { kho };
            }
            else
            {
                MessageBox.Show($"Không tìm thấy kho {maKho}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
        }

    }
}
