using Services.Models;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusManagement
{
    public partial class DriverManagement : Form
    {
        DriverRepository _driverRepository;

        public DriverManagement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            btnDriverManage.Enabled = false;
            btnDriverManage.BackColor = Color.Yellow;
            dgvDriver.ReadOnly = true;

            loadDgv();
        }

        private void loadDgv()
        {
            _driverRepository = new DriverRepository();

            var listDriver = _driverRepository.GetAll().Select(p => new
            {
                p.DriverId,
                p.DriverName,
                p.Address,
                p.Gender,
                p.Dob,
                p.Salary,
                p.StartDate,
                p.BusId,
                p.IsActive,
            }).ToList();
            dgvDriver.DataSource = listDriver;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new AddDriver();
            form.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchBox = txtSearch.Text.Trim().ToString();

            var listSearch = _driverRepository.GetAll()
                .Where(p => p.DriverName.Contains(searchBox)).Select(p => new
                {
                    p.DriverId,
                    p.DriverName,
                    p.Address,
                    p.Gender,
                    p.Dob,
                    p.Salary,
                    p.StartDate,
                    p.BusId,
                    p.IsActive,
                }).ToList();
            dgvDriver.DataSource = listSearch;
        }

        private void dgvDriver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra hàng hợp lệ
            {
                dgvDriver.Rows[e.RowIndex].Selected = true; // Chọn toàn bộ hàng được click
            }
        }

        private void dgvDriver_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDriver.Rows[e.RowIndex];
                TblDriver selectedDriver = new TblDriver
                {
                    DriverId = row.Cells["DriverID"].Value.ToString(),
                    DriverName = row.Cells["DriverName"].Value.ToString(),
                    Address = row.Cells["Address"].Value.ToString(),
                    StartDate = DateTime.Parse(row.Cells["StartDate"].Value.ToString()),
                    Dob = DateTime.Parse(row.Cells["Dob"].Value.ToString()),
                    Salary = Decimal.Parse(row.Cells["Salary"].Value.ToString()),
                    Gender = row.Cells["Gender"].Value.ToString(),
                    BusId = row.Cells["BusId"].Value.ToString(),
                    IsActive = Boolean.Parse(row.Cells["IsActive"].Value.ToString())
                };
                //truyen du lieu

                this.Hide();
                Form updateDriver = new UpdateDriver(selectedDriver);
                updateDriver.ShowDialog();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDriver.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDriver.SelectedRows[0];
                TblDriver selectedDriver = new TblDriver
                {
                    DriverId = selectedRow.Cells["DriverID"].Value.ToString(),
                    DriverName = selectedRow.Cells["DriverName"].Value.ToString(),
                    Address = selectedRow.Cells["Address"].Value.ToString(),
                    StartDate = DateTime.Parse(selectedRow.Cells["StartDate"].Value.ToString()),
                    Dob = DateTime.Parse(selectedRow.Cells["Dob"].Value.ToString()),
                    Salary = Decimal.Parse(selectedRow.Cells["Salary"].Value.ToString()),
                    Gender = selectedRow.Cells["Gender"].Value.ToString(),
                    BusId = selectedRow.Cells["BusId"].Value.ToString(),
                    IsActive = Boolean.Parse(selectedRow.Cells["IsActive"].Value.ToString())
                };
                //truyen du lieu

                this.Hide();
                Form updateDriver = new UpdateDriver(selectedDriver);
                updateDriver.ShowDialog();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDriver.SelectedRows.Count > 0)
            {
                int location = dgvDriver.CurrentCell.RowIndex;
                string driverId = dgvDriver.Rows[location].Cells["DriverID"].Value.ToString();
                TblDriver selectedDriver = _driverRepository.GetAll().FirstOrDefault(p => p.DriverId.Equals(driverId));

                DialogResult result = MessageBox.Show("Bạn muốn xóa tài xế này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _driverRepository.Delete(selectedDriver);
                    MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK);
                    loadDgv();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDgv();
        }
    }


}
