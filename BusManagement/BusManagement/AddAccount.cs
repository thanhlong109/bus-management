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
    public partial class AddAccount : Form
    {
        AccountRepository accountRepository;

        public AddAccount()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            accountRepository = new AccountRepository();
            loadComboBox();
        }

        private void loadComboBox()
        {
            var listAccount = accountRepository.GetAll().Select(p => new {p.IsActive }).ToList();
            cbb.DisplayMember = "IsActive";
            cbb.DataSource = listAccount;
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtAccountID.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            dtpAccount.Value = DateTime.Now;
            txtPhoneNumber.Text = string.Empty;
            txtRole.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
