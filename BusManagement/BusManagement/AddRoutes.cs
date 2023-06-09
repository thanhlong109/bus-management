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
    public partial class AddRoutes : Form
    {
        BusRouteRepository routeRepo;
        TransportUnitRepository transportUnitRepo;
        public AddRoutes()
        {
            InitializeComponent();
            routeRepo = new BusRouteRepository();
            transportUnitRepo = new TransportUnitRepository();
            LoadCombobox();
        }
        private void LoadCombobox()
        {
            var list = transportUnitRepo.GetAll().Select(p => new { p.TransportUnitId, p.TransportUnitName }).ToList();
            cbb.DisplayMember = "TransportUnitName";
            cbb.ValueMember = "TransportUnitId";
            cbb.DataSource = list;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
