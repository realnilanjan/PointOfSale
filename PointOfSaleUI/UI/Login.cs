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
        public Login()
        {
            InitializeComponent();
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
                var userlist = dataAccess.VerifyUser(txtUserName.Text, encryptedpassword);
                if (userlist.Count > 0)
                {
                    LoggedInUserModel loggedInUser = new LoggedInUserModel
                    {
                        UserId = userlist[0].UserId,
                        Fullname = userlist[0].Fullname,
                        Username = userlist[0].Username,
                        UserRole = userlist[0].UserRole,
                        Contact = userlist[0].Contact,
                        EmailAddress = userlist[0].EmailAddress,
                        Status = userlist[0].Status
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
                        this.ClearAll();
                    }
                }
                else
                {
                    Messages.DisplayMessage(Properties.Resources.INVALID_CREDENTIALS, lblWarning, Color.Red);
                    this.ClearAll();
                }
            }
            else
            {
                if (txtUserName.Text == "")
                {
                    Messages.DisplayMessage("Please provide the username.", lblWarning, Color.Red);
                    txtUserName.Focus();
                }
                else if (txtPassword.Text == "")
                {
                    Messages.DisplayMessage("Please provide the password.", lblWarning, Color.Red);
                    txtPassword.Focus();
                }
                else if ((txtUserName.Text == "") && (txtPassword.Text == ""))
                {
                    Messages.DisplayMessage(Properties.Resources.FILL_ALL_DETAILS_LOGIN, lblWarning, Color.Red);
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
