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
    public partial class RoutesManagement : Form
    {
        BusRouteRepository routeRepository;
        TblBusRoute selectedRoute;
        Util u;
        public RoutesManagement()
        {
            InitializeComponent();
            formSettings();
            routeRepository = new BusRouteRepository();
            updateView();
            this.FormClosing += RoutesManagement_FormClosing;
            dgv.Columns[0].HeaderText = "Mã Tuyến";
            dgv.Columns[1].HeaderText = "Mã Đơn Vị";
            dgv.Columns[2].HeaderText = "Tên Tuyến";
            dgv.Columns[3].HeaderText = "Thời Gian Bắt Đầu";
            dgv.Columns[4].HeaderText = "Thời Gian Kết Thúc";
            dgv.Columns[5].HeaderText = "Thời Gian giãn cách";
            dgv.Columns[6].HeaderText = "Lộ Trình Lượt Đi";
            dgv.Columns[7].HeaderText = "Lộ Trình Lượt Về";
            u = new Util();
        }
        public void RoutesManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void updateView()
        {
            btnRemove.Enabled = false;
            btnUpdate.Enabled = false;
            dgv.DataSource = new BindingSource() { DataSource = new BusRouteRepository().GetAll().Where(p => p.IsActive == true).Select(p => new { p.RoutesId, p.TransportUnitId, p.RoutesName, p.StartTime, p.EndTime, p.EstimatedTime, p.StartPoint, p.EndPoint }) };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form form = new AddRoutes();
            form.ShowDialog();
            updateView();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRemove.Enabled = true;
            btnUpdate.Enabled = true;

            selectedRoute = routeRepository.GetAll().Where(p => p.RoutesId.Equals(dgv.Rows[e.RowIndex].Cells[0].Value)).FirstOrDefault();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form form = new UpdateRoutes(selectedRoute);
            form.ShowDialog();
            updateView();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            routeRepository.Delete(selectedRoute);
            updateView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = new BindingSource() { DataSource = new BusRouteRepository().GetAll().Where(p => p.IsActive == true && p.RoutesName.Contains(txtSearch.Text)).Select(p => new { p.RoutesId, p.TransportUnitId, p.RoutesName, p.StartTime, p.EndTime, p.EstimatedTime, p.StartPoint, p.EndPoint }) };
        }

        private void formSettings()
        {

            this.StartPosition = FormStartPosition.CenterScreen;

            btnRoutesManage.Enabled = false;
            btnRoutesManage.BackColor = Color.LightYellow;

            btnUnitManage.Enabled = true;
            btnUnitManage.BackColor = Color.White;

            btnBusManage.Enabled = true;
            btnBusManage.BackColor = Color.White;

            btnDriverManage.Enabled = true;
            btnDriverManage.BackColor = Color.White;

            btnAccountManage.Enabled = true;
            btnAccountManage.BackColor = Color.White;
        }

        private void btnUnitManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new TransportUnitManagement();
            form.ShowDialog();
        }

        private void btnBusManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new BusManage();
            form.ShowDialog();
        }

        private void btnDriverManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new DriverManagement();
            form.ShowDialog();
        }

        private void btnAccountManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new AccountManagement();
            form.ShowDialog();
        }
    }
}
