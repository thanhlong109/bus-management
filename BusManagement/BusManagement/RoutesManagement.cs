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
    public partial class RoutesManagement : Form
    {
        BusRouteRepository routeRepository;
        public RoutesManagement()
        {
            InitializeComponent();
            routeRepository = new BusRouteRepository();
            updateView();
            this.FormClosing += RoutesManagement_FormClosing;
        }
        public void RoutesManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void updateView()
        {
            dgv.DataSource = new BindingSource() { DataSource = routeRepository.GetAll() };
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form form = new AddRoutes();
            form.ShowDialog();
            updateView();
        }
    }
}
