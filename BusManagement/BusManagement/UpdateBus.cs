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
    public partial class UpdateBus : Form
    {
        TblBu busData;
        BusServices _services;
<<<<<<< HEAD
        BusRouteRepository _routeServices;
=======
        BusRouteServices _routeServices;
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
        

        public UpdateBus(TblBu bus)
        {
            busData = bus;
            InitializeComponent();
            _services = new BusServices();
<<<<<<< HEAD
            _routeServices = new BusRouteRepository();
=======
            _routeServices = new BusRouteServices();
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
            loadCBData();
            var isActive = _services.GetBusStatus(busData.BusId); // Phương thức để lấy trạng thái từ cơ sở dữ liệu
            if (isActive)
            {
                cbStatus.SelectedIndex = 0; // Chọn trạng thái "Hoat dong"
            }
            else
            {
                cbStatus.SelectedIndex = 1; // Chọn trạng thái "Khong hoat dong"
            }
            txtBusID.Text = busData.BusId;
            txtNumePlate.Text = busData.NumberPlate;
            cbBustype.SelectedItem = busData.BusType.ToString();
            cbRoute.Text = busData.RoutesId;
            txtSeat.Text = busData.SeatQuantity.ToString();
            txtEngine.Text = busData.EngineOuput.ToString();
            cbPeriodic.SelectedItem = busData.PeriodicMaintenance.ToString();
            dtManufacturing.Value = busData.ManufacturingDate.Value;
            dtRegistration.Value = busData.RegistrationDate.Value;

        }

        private void loadCBData()
        {
            var listCBRoute = _routeServices.GetAll().Select(p => new { p.RoutesId, p.RoutesName }).ToList();
            cbRoute.DisplayMember = "RoutesName";
            cbRoute.ValueMember = "RoutesId";
            cbRoute.DataSource = listCBRoute;
            cbBustype.Items.AddRange(new string[] { "co nho", "co vua", "co lon" });
            cbBustype.SelectedIndex = 0;
            cbPeriodic.Items.AddRange(new string[] { "1", "3", "6", "8", "12", "18", "24" });
            cbPeriodic.SelectedIndex = 0;
            cbStatus.Items.AddRange(new string[] { "Hoat dong", "Khong hoat dong" });
            cbStatus.SelectedIndex = 0;
        }


        private bool checkInput()
        {
            bool status = false;
            string busId = txtBusID.Text;
            string numberPlate = txtNumePlate.Text;
            string route = cbRoute.SelectedValue.ToString();
            string busType = cbBustype.SelectedItem.ToString();
            string seatQuantity = txtSeat.Text;
            string engineOutput = txtEngine.Text;
            string periodicMaintenance = cbPeriodic.SelectedItem.ToString();



            string idPatternPlate1 = @"^[0-9]{2}[A-Z]{1}[0-9]{4}$";
            string idPatternPlate2 = @"^[0-9]{2}[A-Z]{1}[0-9]{5}$";
            if (!Regex.IsMatch(numberPlate, idPatternPlate1) && !Regex.IsMatch(numberPlate, idPatternPlate2))
            {
                MessageBox.Show("Biển số xe phải theo format XXPXXXX hoặc XXPXXXXX (X: số, P: chữ)", "Cảnh báo", MessageBoxButtons.OK);
            }
            else
            {
                int seatQuantityValue;
                if (!int.TryParse(txtSeat.Text, out seatQuantityValue) || seatQuantityValue <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số ghế phù hợp !!!", "Thông báo ", MessageBoxButtons.OK);
                }
                else
                {
                    if (!
                        ((busType == "co nho" && seatQuantityValue <= 20) ||
                        ((busType == "co vua" && seatQuantityValue >= 20) &&
                        (busType == "co vua" && seatQuantityValue <= 35)) ||
                        (busType == "co lon" && seatQuantityValue >= 35) ||
                        (busType == "co lon" && seatQuantityValue > 60)))
                    {
                        MessageBox.Show("Vui lòng chọn số ghế phù hợp với cỡ xe !!! " +
                            "(cỡ nhỏ <= 20, cỡ vừa <= 35, cỡ lớn <= 60)", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        int engineValue;
                        if (!Int32.TryParse(txtEngine.Text, out engineValue) || engineValue <= 0)
                        {
                            MessageBox.Show("Vui lòng nhập công suất xe phù hợp!!!", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            // All input is valid
                            return true;
                        }
                    }
                }
            }


            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.Close();
=======
            this.Hide();
            Form form = new BusManage();
            form.ShowDialog();
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                var _busUpdate = _services.GetAll().Where(p => p.BusId == txtBusID.Text).FirstOrDefault();
                _busUpdate.BusId = txtBusID.Text;
                _busUpdate.NumberPlate = txtNumePlate.Text;
                _busUpdate.RoutesId = cbRoute.SelectedValue.ToString();
                _busUpdate.BusType = cbBustype.SelectedItem.ToString();
                _busUpdate.SeatQuantity = int.Parse(txtSeat.Text);
                _busUpdate.EngineOuput = int.Parse(txtEngine.Text);
                _busUpdate.ManufacturingDate = dtManufacturing.Value;
                _busUpdate.RegistrationDate = dtRegistration.Value;
                _busUpdate.PeriodicMaintenance = int.Parse(cbPeriodic.SelectedItem.ToString());
                if (cbStatus.SelectedItem.ToString() == "Hoat dong")
                {
                    _busUpdate.IsActive = true;
                }
                else
                {
                    _busUpdate.IsActive = false;
                }
                _services.Update(_busUpdate);
                MessageBox.Show("Cập nhật xe bus thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
<<<<<<< HEAD
                this.Close();
=======
                this.Hide();
                Form form = new BusManage();
                form.ShowDialog();
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
            }

        }
    }
}
