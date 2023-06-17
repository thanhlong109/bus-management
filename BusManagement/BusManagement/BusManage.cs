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
    public partial class BusManage : Form
    {
        BusServices _busService = new BusServices();
        TblBu selectedBus;
        public BusManage()
        {
            InitializeComponent();
            loadDB();
        }
        public void loadDB()
        {
            var listBus = _busService.GetAllWithRoutes().Select(p => new
            {
                p.BusId,
                p.NumberPlate,
                p.BusType,
                p.SeatQuantity,
                p.EngineOuput,
                p.ManufacturingDate,
                p.RegistrationDate,
                p.PeriodicMaintenance,
                RoutesId = p.Routes.RoutesName,
                IsActive = p.IsActive ? "Hoat dong" : "Khong hoat dong"
            });

            dgvListBus.DataSource = new BindingSource() { DataSource = listBus };
        }




        private void dgvListBus_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Kiểm tra hàng hợp lệ
            {
                dgvListBus.Rows[e.RowIndex].Selected = true; // Chọn toàn bộ hàng được click
            }


        }

        

        private void dgvListBus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvListBus.Rows[e.RowIndex];
                selectedBus = new TblBu
                {
                    BusId = row.Cells["BusId"].Value.ToString(),
                    NumberPlate = row.Cells["NumberPlate"].Value.ToString(),
                    RoutesId = row.Cells["RoutesId"].Value.ToString(),
                    BusType = row.Cells["BusType"].Value.ToString(),
                    SeatQuantity = int.Parse(row.Cells["SeatQuantity"].Value.ToString()),
                    EngineOuput = int.Parse(row.Cells["EngineOuput"].Value.ToString()),
                    ManufacturingDate = DateTime.Parse(row.Cells["ManufacturingDate"].Value.ToString()),
                    RegistrationDate = DateTime.Parse(row.Cells["RegistrationDate"].Value.ToString()),
                    PeriodicMaintenance = int.Parse(row.Cells["PeriodicMaintenance"].Value.ToString())

                };
                
                this.Hide();
                Form updateBus = new UpdateBus(selectedBus);
                updateBus.ShowDialog();
            }
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form addBus = new AddBus();
            addBus.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvListBus.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvListBus.SelectedRows[0];
                selectedBus = new TblBu
                {
                    BusId = selectedRow.Cells["BusId"].Value.ToString(),
                    NumberPlate = selectedRow.Cells["NumberPlate"].Value.ToString(),
                    RoutesId = selectedRow.Cells["RoutesId"].Value.ToString(),
                    BusType = selectedRow.Cells["BusType"].Value.ToString(),
                    SeatQuantity = int.Parse(selectedRow.Cells["SeatQuantity"].Value.ToString()),
                    EngineOuput = int.Parse(selectedRow.Cells["EngineOuput"].Value.ToString()),
                    ManufacturingDate = DateTime.Parse(selectedRow.Cells["ManufacturingDate"].Value.ToString()),
                    RegistrationDate = DateTime.Parse(selectedRow.Cells["RegistrationDate"].Value.ToString()),
                    PeriodicMaintenance = int.Parse(selectedRow.Cells["PeriodicMaintenance"].Value.ToString()),

                };
                

                this.Hide();
                Form updateBus = new UpdateBus(selectedBus);
                updateBus.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvListBus.SelectedRows.Count > 0)
            {
                int location = dgvListBus.CurrentCell.RowIndex;
                string busId = dgvListBus.Rows[location].Cells["BusId"].Value.ToString();
                selectedBus = _busService.GetAll().FirstOrDefault(p => p.BusId.Equals(busId));

                DialogResult result = MessageBox.Show("Bạn muốn xóa xe bus này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    selectedBus.IsActive = false;
                    _busService.Update(selectedBus);
                    MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK);
                    loadDB();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa", "Thông báo", MessageBoxButtons.OK);
            }
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var listBus = _busService.GetAllWithRoutes().Where(p => p.NumberPlate.Contains(txtSearch.Text.Trim())).Select(p => new
            {
                p.BusId,
                p.NumberPlate,
                p.BusType,
                p.SeatQuantity,
                p.EngineOuput,
                p.ManufacturingDate,
                p.RegistrationDate,
                p.PeriodicMaintenance,
                RoutesId = p.Routes.RoutesName,
                IsActive = p.IsActive ? "Hoat dong" : "Khong hoat dong"

            });

            dgvListBus.DataSource = new BindingSource() { DataSource = listBus };
        }

    }
}
