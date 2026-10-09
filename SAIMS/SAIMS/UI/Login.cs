using SAIMS.BusinessLogic.Controller;
using SAIMS.Model;
using SAIMS.UI;

namespace SAIMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();
            UserModel user = controller.Login(txtUsername.Text.Trim(), txtUsername.Text.Trim());

            if (user != null)
            {
                if (user.Role == "Admin")
                {
                    AdminDashboard adminForm = new AdminDashboard();
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

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}