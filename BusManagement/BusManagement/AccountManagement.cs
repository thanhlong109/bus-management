using Services.Models;
using Services.Repository;
using System.Data;

namespace BusManagement
{
    public partial class AccountManagement : Form
    {
        AccountRepository accountRepository;

        public AccountManagement()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            btnAccountManage.Enabled = false;
            accountRepository = new AccountRepository();
            loadData();

        }

        private void loadData()
        {
            var listAccount = accountRepository.GetAll().Select(p => new
            {
                p.AccountId,
                p.Username,
                p.Password,
                p.FullName,
                p.Dob,
                p.Email,
                p.PhoneNumber,
                p.Role
            }).ToList();

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
            TblAccount account = new TblAccount();
            if (dgv_Account.SelectedRows.Count > 0)
            {
                int pos = dgv_Account.CurrentCell.RowIndex;
                string id = dgv_Account.Rows[pos].Cells["AccountId"].ToString();
                account = accountRepository.GetAll().FirstOrDefault(p => p.AccountId.Equals(id));

                DialogResult result = MessageBox.Show("Bạn muốn xóa hàng này?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    accountRepository.Delete(account);
                    MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK);
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một hàng để xóa", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                dgv_Account.Rows[e.RowIndex].Selected = true; 
            }
        }

        private void dgv_Account_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}

