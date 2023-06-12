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
    public partial class AddDriver : Form
    {
        public AddDriver()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtDriverID.Text = "";
            txtDriverName.Text = "";
            txtDriverAddress.Text = "";
            txtDriverSalary.Text = "";
            dtpDriverDoB.Value = DateTime.Now;
            dtpDriverStartDate.Value = DateTime.Now;
            cbDriverGender.DisplayMember = "Gender";
            cbBusID.DisplayMember = "BusID";
        }
    }
}
