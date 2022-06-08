using System;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using InvoiceManagementSystem.Models.Database;

namespace InvoiceManagementSystem.Views
{
    public partial class Login : Form
    {
        bool LoginBtnIsEnabled;
        readonly ResourceManager rm;
        private IIMSConnection _imsConnection;
        public Login(IIMSConnection dataAccess)
        {
            rm = new ResourceManager("InvoiceManagementSystem.Models.Resources.Login", Assembly.GetExecutingAssembly());
            _imsConnection = dataAccess;
            InitializeComponent();
            ChangeText();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            return;
        }

        private bool LoginBtnEnabled()
        {
            if (!string.IsNullOrWhiteSpace(UsernameTxtBox.Text) && !string.IsNullOrWhiteSpace(PasswordTxtBox.Text)) {
                LoginBtn.BackColor = Color.Blue;
                LoginBtn.ForeColor = Color.White;
                LoginBtnIsEnabled = true;
            } else
            {
                LoginBtn.BackColor = Color.DarkGray;
                LoginBtn.ForeColor = Color.LightGray;
                LoginBtnIsEnabled = false;
            }
            return LoginBtnIsEnabled;
        }

        private void UsernameTxtBox_TextChanged(object sender, EventArgs e)
        {
            LoginBtn.Enabled = LoginBtnEnabled();
            return;
        }

        private void PasswordTxtBox_TextChanged(object sender, EventArgs e)
        {
            LoginBtn.Enabled = LoginBtnEnabled();
            return;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var validLogin = _imsConnection.AttemptLogin(rm, UsernameTxtBox.Text, PasswordTxtBox.Text);
            if (validLogin) { 
                _imsConnection.SetCurrentUser(UsernameTxtBox.Text);
                Hide();
                var scheduleForm = new Dashboard(_imsConnection);
                scheduleForm.ShowDialog();
                return;
            }
        }

        private void ChangeText()
        {
            Text = rm.GetString("LoginLbl");
            LoginLbl.Text = rm.GetString("LoginLbl");
            LoginBtn.Text = rm.GetString("LoginLbl");
            UsernameLbl.Text = rm.GetString("Username");
            PasswordLbl.Text = rm.GetString("Password");
            ExitBtn.Text = rm.GetString("Exit");
        }
    }
}
