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
            btnDriverManage.Enabled = false;
            dgvDriver.ReadOnly = true;

            _driverRepository = new DriverRepository();

            var listDriver = _driverRepository.GetAll().ToList();
            dgvDriver.DataSource = listDriver;
        }
    }


}
