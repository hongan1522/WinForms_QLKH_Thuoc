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
using static WebAPI_QLKH.Controllers.NhanVienController;

namespace FormQLKH
{
    public partial class UC_QLNV : UserControl
    {
        private readonly NhanVienService nvService;
        private readonly TaiKhoanService tkService;
        private readonly ChiNhanhService cnService;
        public UC_QLNV()
        {
            InitializeComponent();
            dgvNV.AutoGenerateColumns = false;

            nvService = new NhanVienService("https://localhost:7195");
            tkService = new TaiKhoanService("https://localhost:7195");
            cnService = new ChiNhanhService("https://localhost:7195");

            LoadDataGridView();
            LoadComboBox();
        }
        private async void LoadDataGridView()
        {
            try
            {
                List<NhanVien> dsnv = nvService.LayDSNV();

                if (dsnv != null)
                {
                    dgvNV.DataSource = dsnv;

                    foreach (DataGridViewColumn column in dgvNV.Columns)
                    {
                        column.ReadOnly = true;
                        dgvNV.Columns["BirthDay"].DefaultCellStyle.Format = "dd/MM/yyyy";
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
        private void dgvNV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvNV.SelectedRows[0];

                string userID = Convert.ToString(selectedRow.Cells["UserID"].Value);
                string maNV = Convert.ToString(selectedRow.Cells["NV_ID"].Value);
                string maCN = Convert.ToString(selectedRow.Cells["CN_ID"].Value);
                string hoTen = Convert.ToString(selectedRow.Cells["NV_Name"].Value);
                DateTime ngaySinh = Convert.ToDateTime(selectedRow.Cells["BirthDay"].Value);
                string sdt = Convert.ToString(selectedRow.Cells["Phone"].Value);
                string email = Convert.ToString(selectedRow.Cells["Email"].Value);
                string address = Convert.ToString(selectedRow.Cells["Address"].Value);
                string gioiTinh = Convert.ToString(selectedRow.Cells["Sex"].Value);

                if (gioiTinh == "Nam")
                {
                    rdbQLNV_Nam.Checked = true;
                }
                else if (gioiTinh == "Nữ")
                {
                    rdbQLNV_Nu.Checked = true;
                }

                cbQLNV_UserID.Text = userID;
                txtQLNV_HoTen.Text = hoTen;
                txtQLNV_MaNV.Text = maNV;
                cbQLNV_MaCN.Text = maCN;
                dtpQLNV_NgaySinh.Value = ngaySinh;
                txtQLNV_SDT.Text = sdt;
                txtQLNV_Email.Text = email;
                txtQLNV_DiaChi.Text = address;
                txtQLNV_MaNV.ReadOnly = true;
            }
        }
        private void dgvNV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rowIndex = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgvNV.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIndex, Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        private void LoadComboBox()
        {
            try
            {
                // Load cbQLNV_UserID
                List<TaiKhoan> dstk = tkService.LayDSTaiKhoan();

                cbQLNV_UserID.DataSource = dstk;
                cbQLNV_UserID.DisplayMember = "UserID";
                cbQLNV_UserID.ValueMember = "UserID";
                cbQLNV_UserID.DropDownStyle = ComboBoxStyle.DropDownList;

                if (dstk.Count > 0)
                {
                    cbQLNV_UserID.SelectedIndex = 0;
                }

                // Load cbQLNV_MaCN
                List<ChiNhanh> dscn = cnService.LayDanhSachChiNhanh();

                cbQLNV_MaCN.DataSource = dscn;
                cbQLNV_MaCN.DisplayMember = "CN_ID";
                cbQLNV_MaCN.ValueMember = "CN_ID";
                cbQLNV_MaCN.DropDownStyle = ComboBoxStyle.DropDownList;

                if (dscn.Count > 0)
                {
                    cbQLNV_MaCN.SelectedIndex = 0;
                }

                //Load cbQLNV_TK_MaNV
                List<NhanVien> dsnv = nvService.LayDSNV();

                cbQLNV_TK_MaNV.DataSource = dsnv;
                cbQLNV_TK_MaNV.DisplayMember = "NV_ID";
                cbQLNV_TK_MaNV.ValueMember = "NV_ID";
                cbQLNV_TK_MaNV.DropDownStyle = ComboBoxStyle.DropDownList;

                if (dsnv.Count > 0)
                {
                    cbQLNV_TK_MaNV.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
