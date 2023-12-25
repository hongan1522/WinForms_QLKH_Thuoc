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
    public partial class UC_QLNV : UserControl
    {
        private readonly NhanVienService nvService;
        public UC_QLNV()
        {
            InitializeComponent();
            dgvNV.AutoGenerateColumns = false;

            nvService = new NhanVienService("https://localhost:7195");

            LoadDataGridView();
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
    }
}
