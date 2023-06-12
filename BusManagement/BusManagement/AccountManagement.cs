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
    public partial class AccountManagement : Form
    {
        AccountRepository accountRepository;


        public AccountManagement()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            btnAccountManage.Enabled = false;
            dgv_Account.ReadOnly = false;

            accountRepository = new AccountRepository();

            var listAccount = accountRepository.GetAll().ToList();
            dgv_Account.DataSource = new BindingSource() { DataSource = listAccount };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {         
            Form form = new AddAccount();
            form.ShowDialog();
        }
    }
}
