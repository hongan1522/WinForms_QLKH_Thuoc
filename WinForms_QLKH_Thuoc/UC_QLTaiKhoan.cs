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
using WebAPI_QLKH.Controllers;
using WebAPI_QLKH.Models;
using WebAPI_QLKH.Services;
using static WebAPI_QLKH.Controllers.TaiKhoanController;
using System.Security.Cryptography;

namespace FormQLKH
{
    public partial class UC_QLTaiKhoan : UserControl
    {
        private readonly TaiKhoanService tKService;
        private readonly RoleService roleService;
        public UC_QLTaiKhoan()
        {
            InitializeComponent();
            dgvQLTK.AutoGenerateColumns = false;
            cbQLTK_RoleID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbQLTK_TK_RoleID.DropDownStyle = ComboBoxStyle.DropDownList;

            tKService = new TaiKhoanService("https://localhost:7195");
            roleService = new RoleService("https://localhost:7195");
            LoadComboBoxRoleID();
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            try
            {
                List<TaiKhoan> danhSachtK = tKService.LayDSTaiKhoan();

                if (danhSachtK != null)
                {
                    dgvQLTK.DataSource = danhSachtK;
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
        private void LoadComboBoxRoleID()
        {
            try
            {
                List<Role> danhSachRoleID = roleService.LayDanhSachRole();

                cbQLTK_RoleID.DataSource = danhSachRoleID;
                cbQLTK_TK_RoleID.DataSource = danhSachRoleID;

                cbQLTK_RoleID.DisplayMember = "RoleID";
                cbQLTK_RoleID.ValueMember = "RoleID";
                cbQLTK_TK_RoleID.DisplayMember = "RoleID";
                cbQLTK_TK_RoleID.ValueMember = "RoleID";

                cbQLTK_RoleID.SelectedIndex = 0;
                cbQLTK_TK_RoleID.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvQLTK_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQLTK.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvQLTK.SelectedRows[0];

                string userID = Convert.ToString(selectedRow.Cells["UserID"].Value);
                string userName = Convert.ToString(selectedRow.Cells["UserName"].Value);
                string password = Convert.ToString(selectedRow.Cells["Password"].Value);
                string ghiChu = Convert.ToString(selectedRow.Cells["GhiChu"].Value);
                string roleID = Convert.ToString(selectedRow.Cells["RoleID"].Value);

                txtQLTK_UserID.Text = userID;
                txtQLTK_UserName.Text = userName;
                txtQLTK_Password.Text = password;
                txtQLTK_GhiChu.Text = ghiChu;
                cbQLTK_RoleID.Text = roleID;

                txtQLTK_UserID.ReadOnly = true;
            }
        }
        private void dgvQLTK_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rowIndex = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgvQLTK.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIndex, Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        private string TaoUserIDTuDong()
        {
            List<string> danhSachMaUserID = dgvQLTK.Rows
                .Cast<DataGridViewRow>()
                .Select(row => row.Cells["UserID"].Value.ToString())
                .ToList();

            for (int i = 1; i <= danhSachMaUserID.Count + 1; i++)
            {
                string maDinhDang = "User" + i;
                if (!danhSachMaUserID.Any(ma => ma.Trim().Equals(maDinhDang, StringComparison.OrdinalIgnoreCase)))
                {
                    return maDinhDang;
                }
            }

            if (danhSachMaUserID.Count > 0)
            {
                string maLonNhat = danhSachMaUserID.Max();
                if (int.TryParse(maLonNhat.Substring(4), out int so))
                {
                    return "User" + (so + 1).ToString();
                }
            }

            return "User1";
        }
        private string BamPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
        private void txtQLTK_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
        private bool IsUserNameExists(string userName)
        {
            if (userName.Trim() != userName)
            {
                return true;
            }

            foreach (DataGridViewRow row in dgvQLTK.Rows)
            {
                if (row.Cells["UserName"].Value != null && row.Cells["UserName"].Value.ToString().Equals(userName))
                {
                    return true;
                }
            }

            return false;
        }
        private bool IsPasswordExists(string password)
        {
            foreach (DataGridViewRow row in dgvQLTK.Rows)
            {
                if (row.Cells["Password"].Value != null && row.Cells["Password"].Value.ToString().Equals(password))
                {
                    return true;
                }
            }

            return false;
        }
        private void btnQLTK_Them_Click(object sender, EventArgs e)
        {
            string userID = TaoUserIDTuDong();
            string roleID = cbQLTK_RoleID.Text.Trim();
            string userName = txtQLTK_UserName.Text.Trim();
            string password = txtQLTK_Password.Text.Trim();
            string ghiChu = txtQLTK_GhiChu.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsUserNameExists(userName))
            {
                MessageBox.Show("User Name đã tồn tại. Vui lòng chọn một User Name khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsPasswordExists(password))
            {
                MessageBox.Show("Password đã tồn tại. Vui lòng chọn một Password khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = BamPassword(password);

            var payloads = new List<TKPayload>
            {
                new TKPayload
                {
                    UserID = userID,
                    RoleID = roleID,
                    UserName = userName,
                    Password = hashedPassword, 
                    Description = ghiChu
                }
            };

            var response = tKService.ThemTaiKhoan(payloads);

            if (response.IsSuccessful)
            {
                MessageBox.Show($"Thêm tài khoản {userID} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show($"Thêm tài khoản thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnQLTK_Sua_Click(object sender, EventArgs e)
        {
            string userID = txtQLTK_UserID.Text.Trim();
            string roleID = cbQLTK_RoleID.Text.Trim();
            string userName = txtQLTK_UserName.Text.Trim();
            string password = txtQLTK_Password.Text.Trim();
            string ghiChu = txtQLTK_GhiChu.Text.Trim();

            string userNameBanDau = dgvQLTK.CurrentRow.Cells["UserName"].Value.ToString();
            string passwordBanDau = dgvQLTK.CurrentRow.Cells["Password"].Value.ToString();

            if (userName != userNameBanDau || password != passwordBanDau)
            {
                MessageBox.Show("Không được sửa đổi UserName và Password.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var payload = new TKPayload
            {
                UserID = userID,
                RoleID = roleID,
                UserName = userName,
                Password = password,
                Description = ghiChu
            };

            var response = tKService.CapNhatTaiKhoan(userID, payload);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Cập nhật tài khoản {userID} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnQLTK_Xoa_Click(object sender, EventArgs e)
        {
            string userID = txtQLTK_UserID.Text.Trim();

            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản {userID}?", "Xác nhận xóa",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                var response = tKService.XoaTaiKhoan(userID);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Xóa tài khoản {userID} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
