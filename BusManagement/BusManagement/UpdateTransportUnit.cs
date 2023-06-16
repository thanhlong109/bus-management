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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BusManagement
{
    public partial class UpdateTransportUnit : Form
    {
        TblTransportUnit transportUnitPara;
        TransportUnitRepository _transportUnitRepository;
        public UpdateTransportUnit(TblTransportUnit transportUnit)
        {
            transportUnitPara = transportUnit;
            InitializeComponent();
            _transportUnitRepository = new TransportUnitRepository();
            loadData();
        }

        private void loadData()
        {
            var listTransportUnit = _transportUnitRepository.GetAll();
            txtID.Text = transportUnitPara.TransportUnitId;
            txtID.Enabled = false;
            txtTenDonVi.Text = transportUnitPara.TransportUnitName;
            txtDiaChi.Text = transportUnitPara.Address;
            txtSoDienThoai.Text = transportUnitPara.PhoneNumber;
            txtEmail.Text = transportUnitPara.Email;
        }
        //private bool isIdExists(String id)
        //{
        //    var listTransportUnitCount = _transportUnitRepository.GetAll();
        //    for (int i = 0; i < listTransportUnitCount.Count; i++)
        //    {
        //        if (listTransportUnitCount[i].TransportUnitId.Equals(id))
        //        {
        //            return true; // Id đã tồn tại trong danh sách
        //        }
        //    }
        //    return false; // Id không tồn tại trong danh sách
        //}

        private TblTransportUnit takeInput()
        {
            TblTransportUnit transportUnit = new TblTransportUnit();
            txtID.Text = txtID.Text.Trim();
            txtTenDonVi.Text = txtTenDonVi.Text.Trim();
            txtDiaChi.Text = txtDiaChi.Text.Trim();
            txtSoDienThoai.Text = txtSoDienThoai.Text.Trim();
            txtEmail.Text = txtEmail.Text.Trim();
            if (txtID.Text.Length == 0 || txtTenDonVi.Text.Length == 0 || txtDiaChi.Text.Length == 0 || txtSoDienThoai.Text.Length == 0 || txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Please fill in all the information!", "Warning", MessageBoxButtons.OK);
                return null;
            }

            //string idPattern = @"^TU[0-9]{5}$";
            //if (!Regex.IsMatch(txtID.Text, idPattern))
            //{
            //    MessageBox.Show("Please input a valid ID format (TUXXXXX)!", "Warning", MessageBoxButtons.OK);
            //    return null;
            //}

            //if (isIdExists(txtID.Text))
            //{
            //    MessageBox.Show("The ID already exists!", "Warning", MessageBoxButtons.OK);
            //    return null;
            //}

            transportUnit.TransportUnitId = txtID.Text;
            string emailPattern = "^[A-Za-z0-9]+[A-Za-z0-9]*@[A-Za-z0-9]+(\\.[A-Za-z0-9]+)$";
            //[A-Za-z0-9]*@ tùy chọn theo “[A-Za-z0-9]”, và kết thúc bằng một ký hiệu “@”
            //\\.[A-Za-z0-9] Sau domain là phần mở rộng của domain sau dấu chấm, ví dụ: (.com, .net, .org)
            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Please do not use special characters for the first character!", "Warning", MessageBoxButtons.OK);
                return null;
            }
            transportUnit.Email = txtEmail.Text;

            transportUnit.TransportUnitName = txtTenDonVi.Text;
            transportUnit.Address = txtDiaChi.Text;
            transportUnit.PhoneNumber = txtSoDienThoai.Text;
            return transportUnit;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            var transportUnitInput = takeInput();

            var transportUnitDB = _transportUnitRepository.GetAll().Where(p => p.TransportUnitId.Equals(transportUnitPara.TransportUnitId)).FirstOrDefault();
            if (transportUnitDB != null)
            {
                transportUnitDB.TransportUnitId = transportUnitDB.TransportUnitId;
                transportUnitDB.TransportUnitName = transportUnitInput.TransportUnitName;
                transportUnitDB.Address = transportUnitInput.Address;
                transportUnitDB.PhoneNumber = transportUnitInput.PhoneNumber;
                transportUnitDB.Email = transportUnitInput.Email;
                _transportUnitRepository.Update(transportUnitDB);
            }
           
            
            MessageBox.Show("Save success", "Message", MessageBoxButtons.OK);
            this.Hide();
            Form form = new TransportUnitManagement();
            form.ShowDialog();
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            
            txtTenDonVi.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtEmail.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new TransportUnitManagement();
            form.ShowDialog();
        }
    }
}
