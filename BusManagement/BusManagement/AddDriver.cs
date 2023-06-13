﻿using Services.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BusManagement
{
    public partial class AddDriver : Form
    {
        BusRepository _busrepository = new BusRepository();

        public AddDriver()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            load_cbDriverGender();
            load_cbBusID();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String idPattern = @"^d[0-9]{4}|D[0-9]{4}$";
            String id = txtDriverID.Text;
            String name = txtDriverName.Text;
            String address = txtDriverAddress.Text;
            String salary = txtDriverSalary.Text;
            if (!checkNullOrEmpty())
            {

            }
            else
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void load_cbDriverGender()
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("1", "Nam");
            comboSource.Add("2", "Nữ");
            comboSource.Add("3", "Khác");
            cbDriverGender.DataSource = new BindingSource(comboSource, null);
            cbDriverGender.DisplayMember = "Value";
            cbDriverGender.ValueMember = "Key";
        }

        private void load_cbBusID()
        {
            var listCombo = _busrepository.GetAll().Select(p => new { p.BusId, p.BusType }).ToList();
            cbBusID.DisplayMember = "BusType";
            cbBusID.ValueMember = "BusId";
            cbBusID.DataSource = listCombo;
        }

        private void reset()
        {
            txtDriverID.Text = "";
            txtDriverName.Text = "";
            txtDriverAddress.Text = "";
            txtDriverSalary.Text = "";
            dtpDriverDoB.Value = DateTime.Now;
            dtpDriverStartDate.Value = DateTime.Now;
            load_cbDriverGender();
            load_cbBusID();
        }

        public bool checkNullOrEmpty()
        {
            bool check = true;
            if (String.IsNullOrEmpty(txtDriverID.Text) 
                && String.IsNullOrEmpty(txtDriverName.Text) 
                && String.IsNullOrEmpty(txtDriverAddress.Text) 
                && String.IsNullOrEmpty(txtDriverSalary.Text))
            {
                check = false;
            }
            return check;
        }
    }
}
