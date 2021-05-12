using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.Encryptions;
using PointOfSale.Lib.Helpers;
using PointOfSale.Lib.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PointOfSaleUI.UI
{
    public partial class Login : Form
    {
        LoggedInUserModel user = new LoggedInUserModel();
        int NumberofRetries = Properties.Settings.Default.NumberofRetries;
        int TimesTried = 0;

        public Login()
        {
            InitializeComponent();
            this.Text = BusinessInformation.BusinessInfo[0].BusinessName + " POS - Login";
            txtHeader.Text = String.Format(txtHeader.Text, BusinessInformation.BusinessInfo[0].BusinessName);
        }

        private void chkShowHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowHidePassword.CheckState == CheckState.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                chkShowHidePassword.Text = "Hide Password";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                chkShowHidePassword.Text = "Show Password";
            }
        }

        private void ClearAll()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string encryptedpassword = EncryptTo.MD5Hash(txtPassword.Text);
            if ((txtUserName.Text != "") && (txtPassword.Text != ""))
            {
                SQLDataAccess dataAccess = new SQLDataAccess();
                user = dataAccess.VerifyUser(txtUserName.Text, encryptedpassword);
                if (user != null)
                {
                    LoggedInUserModel loggedInUser = new LoggedInUserModel
                    {
                        UserId = user.UserId,
                        Fullname = user.Fullname,
                        Username = user.Username,
                        UserRole = user.UserRole,
                        Contact = user.Contact,
                        EmailAddress = user.EmailAddress,
                        Status = user.Status
                    };
                    if ((loggedInUser.UserRole == "Administrator") && (loggedInUser.Status == "1"))
                    {
                        this.Hide();
                        Dashboard dashboard = new Dashboard(loggedInUser);
                        dashboard.ShowDialog();
                        this.Close();
                    }
                    else if ((loggedInUser.UserRole == "Cashier") && (loggedInUser.Status == "1"))
                    {
                        this.Hide();
                        Terminal terminal = new Terminal(loggedInUser);
                        terminal.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Messages.DisplayMessage(Properties.Resources.USER_BLOCKED, lblWarning, Color.Red);
                        Utils.DoErrorShake(this);
                        this.ClearAll();
                    }
                }
                else if ((user == null) && (TimesTried == NumberofRetries))
                {
                    Messages.DisplayMessage(Properties.Resources.MAX_RETRIES, lblWarning, Color.Red);
                    Utils.DoErrorShake(this);
                    this.ClearAll();
                }
                else
                {
                    Messages.DisplayMessage(Properties.Resources.INVALID_CREDENTIALS, lblWarning, Color.Red);
                    TimesTried ++;
                    Utils.DoErrorShake(this);
                    this.ClearAll();
                }
            }
            else
            {
                if (txtUserName.Text == "")
                {
                    Messages.DisplayMessage("Please provide the username.", lblWarning, Color.Red);
                    Utils.DoErrorShake(this);
                    txtUserName.Focus();
                }
                else if (txtPassword.Text == "")
                {
                    Messages.DisplayMessage("Please provide the password.", lblWarning, Color.Red);
                    Utils.DoErrorShake(this);
                    txtPassword.Focus();
                }
                else if ((txtUserName.Text == "") && (txtPassword.Text == ""))
                {
                    Messages.DisplayMessage(Properties.Resources.FILL_ALL_DETAILS_LOGIN, lblWarning, Color.Red);
                    Utils.DoErrorShake(this);
                    txtUserName.Focus();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
