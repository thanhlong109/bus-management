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
            dgvDriver.ReadOnly = false;

            _driverRepository = new DriverRepository();

            var listDriver = _driverRepository.GetAll().ToList();
            dgvDriver.DataSource = listDriver;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new AddDriver();
            form.ShowDialog();           
        }
    }


}
