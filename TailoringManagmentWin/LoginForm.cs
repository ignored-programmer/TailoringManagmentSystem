using System;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TMS.DataLayer;
using TMS.DataLayer.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TailoringManagmentWin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateUser(txtbUserName.Text, txtbPassword.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("اعتبارسنجی ناموفق بود.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("کاربری در دیتابیس وجود ندارد" , "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private bool ValidateUser(string username, string password)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var login = db.LoginRepository.Get().First();

                if (username == login.UserName && password == login.Password && login.IsActive == true)
                {
                    return true;
                }

                return false;
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtbPassword.PasswordChar = '*';
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
