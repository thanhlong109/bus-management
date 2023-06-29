﻿using Services.Models;
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
        TblAccount account;
        public TransportUnitManagement(TblAccount account)
        {
            this.account = account;
            InitializeComponent();
            _transportUnitService = new TransportUnitRepository();
            formSettings();
            updateView();
            if (account.Role.Equals("quan ly"))
            {
                btnAccountManage.Enabled = true;
            }
            else
            {
                btnAccountManage.Enabled = false;
            }
            dgvListTransportUnit.Columns[0].HeaderText = "Mã Đơn Vị";
            dgvListTransportUnit.Columns[1].HeaderText = "Tên Đơn Vị";
            dgvListTransportUnit.Columns[2].HeaderText = "Địa Chỉ";
            dgvListTransportUnit.Columns[3].HeaderText = "Số Điện Thoại";
            dgvListTransportUnit.Columns[4].HeaderText = "Email";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form form = new AddTransportUnit();
            form.ShowDialog();
            updateView();
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
            dgvListTransportUnit.DataSource = new BindingSource() { DataSource = new TransportUnitRepository().GetAll().Where(p => p.IsActive == true && p.TransportUnitName.Contains(txtSearch.Text)).Select(p => new { p.TransportUnitId, p.TransportUnitName, p.Address, p.PhoneNumber, p.Email }) };
        }

        private void formSettings()
        {

            this.StartPosition = FormStartPosition.CenterScreen;

            btnRoutesManage.Enabled = true;
            btnRoutesManage.BackColor = Color.White;

            btnUnitManage.Enabled = false;
            btnUnitManage.BackColor = Color.LightYellow;

            btnBusManage.Enabled = true;
            btnBusManage.BackColor = Color.White;

            btnDriverManage.Enabled = true;
            btnDriverManage.BackColor = Color.White;

            btnAccountManage.Enabled = true;
            btnAccountManage.BackColor = Color.White;

        }

        private void btnRoutesManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new RoutesManagement(account);
            form.ShowDialog();
        }

        private void btnBusManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new BusManage(account);
            form.ShowDialog();
        }

        private void btnDriverManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new DriverManagement(account);
            form.ShowDialog();
        }

        private void btnAccountManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new AccountManagement(account);
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Login();
            form.ShowDialog();
        }
    }
}
