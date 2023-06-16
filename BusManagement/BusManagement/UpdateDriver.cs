using Services.Models;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusManagement
{
    public partial class UpdateDriver : Form
    {
        TblDriver driverData;
        BusRepository _busrepository = new BusRepository();
        DriverRepository _driverrepository = new DriverRepository();

        public UpdateDriver(TblDriver driver)
        {
            driverData = driver;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            //Load ComboBox Data
            load_cbBusID();
            load_cbDriverGender();
            loadIsActive();

            //Load Driver Data For Update
            txtDriverID.Text = driverData.DriverId;
            txtDriverID.ReadOnly = true;
            txtDriverName.Text = driverData.DriverName;
            txtDriverAddress.Text = driverData.Address;
            dtpDriverStartDate.Value = driverData.StartDate.Value;
            dtpDriverStartDate.Enabled = false;
            dtpDriverDoB.Value = driverData.Dob.Value;
            txtDriverSalary.Text = String.Format("{0:0.##}", Decimal.Parse(driverData.Salary.ToString()));
            cbDriverGender.SelectedItem = driverData.Gender.ToString();
            cbBusID.SelectedValue = driverData.BusId.ToString();
            cbIsActive.SelectedValue = driverData.IsActive.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new DriverManagement();
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var driver = getValidInput();
            if (driver != null)
            {
                _driverrepository.Update(driver);
                MessageBox.Show("Sửa thông tin tài xế thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Form form = new DriverManagement();
                form.ShowDialog();
            }
        }

        private void load_cbDriverGender()
        {
            cbDriverGender.Items.AddRange(new String[] { "Nam", "Nu", "Khac" });
            cbDriverGender.SelectedIndex = 0;
        }

        private void load_cbBusID()
        {
            var listCombo = _busrepository.GetAll().Select(p => new { p.BusId, p.NumberPlate }).ToList();
            cbBusID.DisplayMember = "NumberPlate";
            cbBusID.ValueMember = "BusId";
            cbBusID.DataSource = listCombo;
        }

        private void loadIsActive()
        {
            var item = new[]
            {
                new { Text = "Đang làm", Value = "True" },
                new { Text = "Nghỉ phép", Value = "False" },
            };
            cbIsActive.DisplayMember = "Text";
            cbIsActive.ValueMember = "Value";
            cbIsActive.DataSource = item;

        }

        private TblDriver getValidInput()
        {
            // New driver
            TblDriver driver = new TblDriver();

            // Add "ID"
            driver.DriverId = txtDriverID.Text;

            // Add "StartDate"
            driver.StartDate = dtpDriverStartDate.Value;

            // Check if textbox is null or empty?
            if (String.IsNullOrEmpty(txtDriverID.Text.Trim())
                || String.IsNullOrEmpty(txtDriverName.Text.Trim())
                || String.IsNullOrEmpty(txtDriverAddress.Text.Trim())
                || String.IsNullOrEmpty(txtDriverSalary.Text.Trim())
                )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            //Check if "Name" contains special characters or numbers or not?
            if (!txtDriverName.Text.Trim().All(c => Char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Tên không chứa ký tự đặc biệt và số!!!", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            //Add "Name" to new Driver
            driver.DriverName = txtDriverName.Text.Trim();

            //Check if "Address" contains special characters or not?
            if (!txtDriverAddress.Text.Trim().All(c => Char.IsLetterOrDigit(c) || c == ' '))
            {
                MessageBox.Show("Địa chỉ không chứa ký tự đặc biệt!!!", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            //Add "Address" to new Driver
            driver.Address = txtDriverAddress.Text.Trim();

            //Check if "DoB" right or not?
            if (dtpDriverDoB.Value >= DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không thể nào lớn hơn ngày hôm nay!!!", "Thông báo",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            //Add "DoB" to new Driver
            driver.Dob = dtpDriverDoB.Value;

            //Check if "Salary" contains special characters or alphabet or not?
            if (!txtDriverSalary.Text.Trim().All(c => Char.IsDigit(c)))
            {
                MessageBox.Show("Lương không chứa ký tự đặc biệt và chữ cái!!!", "Thông báo",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            //Add "Salary" to new Driver
            driver.Salary = Decimal.Parse(txtDriverSalary.Text.Trim());

            //Add "Gender" to new Driver
            driver.Gender = cbDriverGender.SelectedItem.ToString();

            //Add "BusID" to new Driver
            driver.BusId = cbBusID.SelectedValue.ToString();

            //Add "isActive" to new Driver
            driver.IsActive = Boolean.Parse(cbIsActive.SelectedValue.ToString());

            return driver;
        }
    }
}
