using Services.Models;
using Services.Repository;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BusManagement
{
    public partial class AddBus : Form
    {
        BusServices _busService = new BusServices();
        BusRouteServices _busRouteService;
        public AddBus()
        {
            InitializeComponent();
            _busRouteService = new BusRouteServices();
            loadCBData();
        }
        private void loadCBData()
        {
            var listCBRoute = _busRouteService.GetAll().Select(p => new { p.RoutesId, p.RoutesName }).ToList();
            cbRoute.DisplayMember = "RoutesName";
            cbRoute.ValueMember = "RoutesId";
            cbRoute.DataSource = listCBRoute;
            cbBustype1.Items.AddRange(new string[] { "co nho", "co vua", "co lon" });
            cbBustype1.SelectedIndex = 0;
            cbPeriodic.Items.AddRange(new string[] { "1", "3", "6", "8", "12", "18", "24" });
            cbPeriodic.SelectedIndex = 0;
        }

        private void txtAdbus_Click(object sender, EventArgs e)
        {

            if (checkInput())
            {
                // Lấy thông tin từ các điều khiển trên màn hình
                var bus = new TblBu();
                string busId = txtBusID.Text;
                string numberPlate = txtNumePlate.Text;
                string route = cbRoute.SelectedValue.ToString();
                string busType = cbBustype1.SelectedItem.ToString();
                string seatQuantity = txtSeat.Text;
                string engineOutput = txtEngine.Text;
                string periodicMaintenance = cbPeriodic.SelectedItem.ToString();


                // Tạo đối tượng Bus từ thông tin vừa lấy được

                bus.BusId = busId;
                bus.NumberPlate = numberPlate;
                bus.RoutesId = route;
                bus.BusType = busType;
                bus.SeatQuantity = int.Parse(seatQuantity);
                bus.EngineOuput = int.Parse(engineOutput);
                bus.PeriodicMaintenance = int.Parse(periodicMaintenance);
                bus.ManufacturingDate = dtManufacturing.Value;
                bus.RegistrationDate = dtRegistration.Value;


                _busService.Create(bus);

                // Hiển thị thông báo thành công và đóng màn hình AddBus
                MessageBox.Show("Thêm xe bus thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.Hide();
                Form form = new BusManage();
                form.ShowDialog();
            }

        }

        private bool checkInput()
        {
            bool status = false;
            string busId = txtBusID.Text;
            string numberPlate = txtNumePlate.Text;
            string route = cbRoute.SelectedValue.ToString();
            string busType = cbBustype1.SelectedItem.ToString();
            string seatQuantity = txtSeat.Text;
            string engineOutput = txtEngine.Text;
            string periodicMaintenance = cbPeriodic.SelectedItem.ToString();

            if (String.IsNullOrEmpty(busId) || String.IsNullOrEmpty(numberPlate) || String.IsNullOrEmpty(route)
                || String.IsNullOrEmpty(busType) || String.IsNullOrEmpty(cbPeriodic.Text) || String.IsNullOrEmpty(txtSeat.Text)
                || String.IsNullOrEmpty(txtEngine.Text))
            {
                MessageBox.Show("Các thông tin không được bỏ trống !!!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string idPatternID = @"^b[0-9]{4}$".ToUpper();
                if (!Regex.IsMatch(busId, idPatternID))
                {
                    MessageBox.Show("Mã xe cần nhập theo format Bxxxx", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
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
                            if (!((busType == "co nho" && seatQuantityValue <= 20) ||
                                (busType == "co vua" && (seatQuantityValue >= 20 || busType == "co vua" && seatQuantityValue <= 35)) ||
                                (busType == "co lon" && seatQuantityValue >= 35) || busType == "co lon" && seatQuantityValue > 60))
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
                }
            }

            return false;
        }


        private void txtHuyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form busmanage = new BusManage();
            busmanage.ShowDialog();
        }

        private void txtRefresh_Click(object sender, EventArgs e)
        {
            txtBusID.Text = string.Empty;
            txtNumePlate.Text = string.Empty;
            txtEngine.Text = string.Empty;
            txtSeat.Text = string.Empty;
            cbBustype1.Text = string.Empty;
            cbPeriodic.Text = string.Empty;
            cbRoute.Text = string.Empty;
            dtManufacturing.Text = string.Empty;
            dtRegistration.Text = string.Empty;
        }
    }
}
