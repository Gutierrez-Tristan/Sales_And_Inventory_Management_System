using SAIMS.BusinessLogic.Controller;
using SAIMS.Model;
using SAIMS.UI;

namespace SAIMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();
            UserModel user = controller.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (user != null)
            {
                UserSession.Current = user;

                if (user.Role == "Admin")
                {
                    frmAdminDashboard adminForm = new frmAdminDashboard();
                    adminForm.Show();
                }
                else if (user.Role == "Cashier")
                {
                    CashierDashboard recepForm = new CashierDashboard();
                    recepForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
