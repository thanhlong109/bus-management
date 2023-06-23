using Services.Models;
using Services.Repository;
using System.Data;

namespace BusManagement
{
    public partial class AccountManagement : Form
    {
        AccountRepository accountRepository;
        TblAccount account;
        public AccountManagement()
        {
            InitializeComponent();
            formSettings();
            this.StartPosition = FormStartPosition.CenterScreen;
            btnAccountManage.Enabled = false;
            accountRepository = new AccountRepository();
            loadData();
            dgv_Account.Columns[0].HeaderText = "Mã Nhân Viên";
            dgv_Account.Columns[1].HeaderText = "Tài Khoản";
            dgv_Account.Columns[2].HeaderText = "Mật Khẩu";
            dgv_Account.Columns[3].HeaderText = "Họ và Tên";
            dgv_Account.Columns[4].HeaderText = "Ngày Tháng Năm Sinh";
            dgv_Account.Columns[5].HeaderText = "Email";
            dgv_Account.Columns[6].HeaderText = "Số Điện Thoại";
            dgv_Account.Columns[7].HeaderText = "Chức Vụ";
        }

        private void loadData()
        {
            btnRemove.Enabled = false;
            btnUpdate.Enabled = false;

            var listAccount = new AccountRepository().GetAll().Where(p => p.IsActive == true).Select(p => new
            {
                p.AccountId,
                p.Username,
                p.Password,
                p.FullName,
                p.Dob,
                p.Email,
                p.PhoneNumber,
                p.Role
            });
            dgv_Account.DataSource = new BindingSource() { DataSource = listAccount };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new AddAccount();
            form.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa hàng này?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                accountRepository.Delete(account);
                MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK);
                loadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new UpdateAccount(account);
            form.ShowDialog();
            loadData();
        }


        private void dgv_Account_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRemove.Enabled = true;
            btnUpdate.Enabled = true;
            account = accountRepository.GetAll().Where(
                p => p.AccountId.Equals(dgv_Account.Rows[e.RowIndex].Cells[0].Value)).FirstOrDefault();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var search = new AccountRepository().GetAll().Where(p =>
            p.IsActive == true && p.FullName.Contains(txtSearch.Text)).
            Select(p => new
            {
                p.AccountId,
                p.Username,
                p.Password,
                p.FullName,
                p.Dob,
                p.Email,
                p.PhoneNumber,
                p.Role
            });
            dgv_Account.DataSource = new BindingSource() { DataSource = search };
        }
        private void formSettings()
        {

            this.StartPosition = FormStartPosition.CenterScreen;

            btnRoutesManage.Enabled = true;
            btnRoutesManage.BackColor = Color.White;

            btnUnitManage.Enabled = true;
            btnUnitManage.BackColor = Color.White;

            btnBusManage.Enabled = true;
            btnBusManage.BackColor = Color.White;

            btnDriverManage.Enabled = true;
            btnDriverManage.BackColor = Color.White;

            btnAccountManage.Enabled = false;
            btnAccountManage.BackColor = Color.LightYellow;
        }

        private void btnRoutesManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new RoutesManagement();
            form.ShowDialog();
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
    }
}

