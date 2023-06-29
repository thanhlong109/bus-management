using Accessibility;
using Microsoft.VisualBasic;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace BusManagement
{
    public partial class AddTransportUnit : Form
    {
        TransportUnitRepository _transportUnitService = new TransportUnitRepository();
        
        public AddTransportUnit()
        {
            InitializeComponent();
        }

        private bool isIdExists(String id)
        {
            var listTransportUnitCount = _transportUnitService.GetAll();
            for (int i = 0; i < listTransportUnitCount.Count; i++)
            {
                if (listTransportUnitCount[i].TransportUnitId.Equals(id))
                {
                    return true; // Id đã tồn tại trong danh sách
                }
            }
            return false; // Id không tồn tại trong danh sách
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            var transportUnit = new TblTransportUnit();
            string ID = txtID.Text.Trim();
            string tenDonVi = txtTenDonVi.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string soDienThoai = txtDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();
            bool is_Active = true;

            if (string.IsNullOrEmpty(tenDonVi) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(soDienThoai) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please fill in all the information!", "Warning", MessageBoxButtons.OK);
                return;
            }

            string idPattern = @"^TU[0-9]{5}$";
            if (!Regex.IsMatch(ID, idPattern))
            {
                MessageBox.Show("Please input a valid ID format (TUXXXXX)!", "Warning", MessageBoxButtons.OK);
                return;
            }

            if (isIdExists(ID))
            {
                MessageBox.Show("The ID already exists!", "Warning", MessageBoxButtons.OK);
                return;
            }
            transportUnit.TransportUnitId = ID;

            string emailPattern = "^[A-Za-z0-9]+[A-Za-z0-9]*@[A-Za-z0-9]+(\\.[A-Za-z0-9]+)$";
            //[A-Za-z0-9]*@ tùy chọn theo “[A-Za-z0-9]”, và kết thúc bằng một ký hiệu “@”
            //\\.[A-Za-z0-9] Sau domain là phần mở rộng của domain sau dấu chấm, ví dụ: (.com, .net, .org)
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please do not use special characters for the first character!", "Warning", MessageBoxButtons.OK);
                return;
            }
            transportUnit.Email = email;

            transportUnit.TransportUnitName = tenDonVi;
            transportUnit.Address = diaChi;
            transportUnit.PhoneNumber = soDienThoai;

            transportUnit.IsActive = is_Active;
            _transportUnitService.Create(transportUnit);



            MessageBox.Show("Save success", "Message", MessageBoxButtons.OK);
            this.Close();


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtTenDonVi.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
        }
    }
}
