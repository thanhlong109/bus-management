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
        TransportUnitRepository _transportUnitService = new TransportUnitRepository();
        public TransportUnitManagement()
        {
            InitializeComponent();
            var listTransportUnit = _transportUnitService.GetAll();
            TransportUnitRepository transportUnitRepository = new TransportUnitRepository();
            BusRouteRepository busRouteRepository = new BusRouteRepository();
            var listCombo = busRouteRepository.GetAll().Select(p => p.TransportUnit).ToList();

            dgvListTransportUnit.DataSource = new BindingSource() { DataSource = listTransportUnit };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new AddTransportUnit();
            form.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var listTransportUnit = _transportUnitService.GetAll();
            TblTransportUnit transportUnitDelete = listTransportUnit.FirstOrDefault();
            if (transportUnitDelete != null)
            {
                DialogResult result = MessageBox.Show("Do you want to delete this transport unit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _transportUnitService.Delete(transportUnitDelete);
                    listTransportUnit = _transportUnitService.GetAll();
                    dgvListTransportUnit.DataSource = new BindingSource() { DataSource = listTransportUnit };
                    MessageBox.Show("Delete success", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            
            this.Hide();
            Form form = new AddTransportUnit();
            form.ShowDialog();
            

        }
    }
}
