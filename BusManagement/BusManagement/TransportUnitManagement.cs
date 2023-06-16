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
    public partial class TransportUnitManagement : Form
    {
        TransportUnitRepository _transportUnitService;
        TblTransportUnit selectedTransUnit = new TblTransportUnit();
        public TransportUnitManagement()
        {
            InitializeComponent();
            //var listTransportUnit = _transportUnitService.GetAll();
            _transportUnitService = new TransportUnitRepository();
            //BusRouteRepository busRouteRepository = new BusRouteRepository();
            //var listCombo = busRouteRepository.GetAll().Select(p => p.TransportUnit).ToList();

            updateView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new AddTransportUnit();
            form.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int location = dgvListTransportUnit.CurrentCell.RowIndex;
            string transportUnitID = dgvListTransportUnit.Rows[location].Cells["TransportUnitId"].Value.ToString();
            selectedTransUnit = _transportUnitService.GetAll().FirstOrDefault(p => p.TransportUnitId.Equals(transportUnitID));


            DialogResult result = MessageBox.Show("Do you want to delete this transport unit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                selectedTransUnit.IsActive = false;
                _transportUnitService.Update(selectedTransUnit);

                MessageBox.Show("Delete success", "Message", MessageBoxButtons.OK);
                updateView();
            }



        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //var listTransportUnit = _transportUnitService.GetAll();
            //TblTransportUnit transportUnitUpdate = listTransportUnit.FirstOrDefault();
            Form form = new UpdateTransportUnit(selectedTransUnit);
            form.ShowDialog();
            updateView();

        }



        private void updateView()
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dgvListTransportUnit.DataSource = new BindingSource() { DataSource = new TransportUnitRepository().GetAll().Where(p => p.IsActive == true).Select(p => new { p.TransportUnitId, p.TransportUnitName, p.Address, p.PhoneNumber, p.Email }) };
        }

        private void dgvListTransportUnit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            selectedTransUnit = _transportUnitService.GetAll().Where(p => p.TransportUnitId.Equals(dgvListTransportUnit.Rows[e.RowIndex].Cells[0].Value)).FirstOrDefault();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) //search by name
        {
            dgvListTransportUnit.DataSource = new BindingSource() {DataSource = new TransportUnitRepository().GetAll().Where(p => p.IsActive == true && p.TransportUnitName.Contains(txtSearch.Text)).Select(p => new { p.TransportUnitId, p.TransportUnitName, p.Address, p.PhoneNumber, p.Email }) };
        }
    }
}
