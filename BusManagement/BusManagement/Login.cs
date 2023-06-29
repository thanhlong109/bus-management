using Services.Repository;

namespace BusManagement
{
    public partial class Login : Form
    {
        Util u;
        public Login()
        {
            InitializeComponent();
            u = new Util();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var account = new AccountRepository().GetAll().Where(p => p.IsActive == true && p.Username.Equals(txtAccount.Text) && p.Password.Equals(txtPassword.Text)).FirstOrDefault();
            if (account==null || account.Role.Length == 0)
            {
                u.ShowNoiceBox("Tài Khoản hoặc mật khẩu không đúng!");
            }
            else
            {
                Form f = new RoutesManagement(account);
                this.Hide();
                f.ShowDialog();
            }
        }

    }
}