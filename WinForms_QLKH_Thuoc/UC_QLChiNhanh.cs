using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FormQLKH.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OfficeOpenXml;
using WebAPI_QLKH.Models;
using static WebAPI_QLKH.Controllers.ChiNhanhController;

namespace FormQLKH
{
    public partial class UC_QLChiNhanh : UserControl
    {
        private readonly ChiNhanhService chiNhanhService;

        public UC_QLChiNhanh()
        {
            InitializeComponent();

            chiNhanhService = new ChiNhanhService("https://localhost:7195");
            LoadDataGridView();
        }
        private void UC_QLChiNhanh_Load(object sender, EventArgs e)
        {
            txtQLCN_TK_MaCN.KeyPress += new KeyPressEventHandler(txtQLCN_TK_MaCN_KeyPress);
        }
        private void LoadDataGridView()
        {
            List<ChiNhanh> danhSachChiNhanh = chiNhanhService.LayDanhSachChiNhanh();

            if (danhSachChiNhanh != null)
            {
                dgvQLCN.DataSource = danhSachChiNhanh;
            }
            else
            {
                MessageBox.Show("Không thể lấy dữ liệu từ API.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvQLCN_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQLCN.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvQLCN.SelectedRows[0];

                //Xóa cột khóa ngoại
                if (dgvQLCN.Columns.Contains("Kho"))
                {
                    dgvQLCN.Columns.Remove("Kho");
                }
                if (dgvQLCN.Columns.Contains("NhanVien"))
                {
                    dgvQLCN.Columns.Remove("NhanVien");
                }

                string maCN = Convert.ToString(selectedRow.Cells["MaCN"].Value);
                string tenCN = Convert.ToString(selectedRow.Cells["TenCN"].Value);
                string diaChi = Convert.ToString(selectedRow.Cells["DiaChi"].Value);

                txtQLCN_MaCN.Text = maCN;
                txtQLCN_TenCN.Text = tenCN;
                txtQLCN_DiaChi.Text = diaChi;

                txtQLCN_MaCN.ReadOnly = true;
            }
        }
        private void btnQLCN_Them_Click(object sender, EventArgs e)
        {
            string maCN = txtQLCN_MaCN.Text.Trim();
            string tenCN = txtQLCN_TenCN.Text.Trim();
            string diaChi = txtQLCN_DiaChi.Text.Trim();

            if (string.IsNullOrEmpty(maCN) || string.IsNullOrEmpty(tenCN) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var payloads = new List<ChiNhanhPayload>
            {
                new ChiNhanhPayload
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
            string maCN = txtQLCN_MaCN.Text;
            string tenCN = txtQLCN_TenCN.Text;
            string diaChi = txtQLCN_DiaChi.Text;

            if (string.IsNullOrEmpty(maCN) || string.IsNullOrEmpty(tenCN) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var payload = new ChiNhanhPayload
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

            if (string.IsNullOrEmpty(maCN))
            {
                MessageBox.Show("Vui lòng chọn chi nhánh để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
        //private void txtQLCN_TK_MaCN_TextChanged(object sender, EventArgs e)
        //{
        //    string maCN = txtQLCN_TK_MaCN.Text.Trim();

        //    if (string.IsNullOrEmpty(maCN))
        //    {
        //        LoadDataGridView();
        //        return;
        //    }

        //    var chiNhanh = chiNhanhService.TimKiemTheoID(maCN);

        //    if (chiNhanh != null)
        //    {
        //        dgvQLCN.DataSource = new List<ChiNhanh> { chiNhanh };
        //    }
        //    else
        //    {
        //        MessageBox.Show($"Không tìm thấy chi nhánh {maCN}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        LoadDataGridView();
        //    }
        //}
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
                dgvQLCN.DataSource = new List<ChiNhanh> { chiNhanh };
            }
            else
            {
                MessageBox.Show($"Không tìm thấy chi nhánh {maCN}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
        }


        private void btnQLCN_Export_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveFileDialog.InitialDirectory = desktopPath;

                string fileName = "ChiNhanh" + GenerateRandomNumber(1000, 9999);
                saveFileDialog.FileName = fileName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(saveFileDialog.FileName);
                }
            }
        }
        private void ExportToExcel(string filePath)
        {
            try
            {
                List<ChiNhanh> chiNhanhList = (List<ChiNhanh>)dgvQLCN.DataSource;

                if (chiNhanhList == null || chiNhanhList.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("ChiNhanhSheet");

                    worksheet.Cells[1, 1].Value = "Mã chi nhánh";
                    worksheet.Cells[1, 2].Value = "Tên chi nhánh";
                    worksheet.Cells[1, 3].Value = "Địa chỉ chi nhánh";

                    for (int i = 0; i < chiNhanhList.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = chiNhanhList[i].CN_ID;
                        worksheet.Cells[i + 2, 2].Value = chiNhanhList[i].CN_Name;
                        worksheet.Cells[i + 2, 3].Value = chiNhanhList[i].CN_Address;
                    }

                    package.SaveAs(new FileInfo(filePath));
                }

                MessageBox.Show($"Xuất Excel thành công. Đường dẫn: {filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
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
        private void btnQLCN_Reload_Click(object sender, EventArgs e)
        {
            txtQLCN_MaCN.ReadOnly = false;
            txtQLCN_TenCN.Clear();
            txtQLCN_DiaChi.Clear();
        }
    }
}
