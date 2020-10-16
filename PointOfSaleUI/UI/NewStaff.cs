using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.Encryptions;
using PointOfSale.Lib.Models;
using System;
using System.Windows.Forms;

namespace PointOfSaleUI.UI
{
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
            txtFullName.Focus();
            cmbUserRole.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((txtFullName.Text != "")
                && (txtContact.Text != "")
                && (txtEmailAddress.Text != "")
                && (txtUserName.Text != "")
                && (cmbUserRole.SelectedIndex > 0)
                && (txtNewPassword.Text != "")
                && (txtNewVerifyPassword.Text != ""))
            {
                if (txtNewPassword.Text == txtNewVerifyPassword.Text)
                {
                    NewUserModel newUser = new NewUserModel
                    {
                        Fullname = txtFullName.Text,
                        Username = txtUserName.Text,
                        Password = EncryptTo.MD5Hash(txtNewVerifyPassword.Text),
                        UserRole = cmbUserRole.GetItemText(cmbUserRole.SelectedItem),
                        Contact = txtContact.Text,
                        EmailAddress = txtEmailAddress.Text,
                        Status = "1"
                    };
                    SQLDataAccess dataAccess = new SQLDataAccess();
                    dataAccess.SaveData("dbo.SaveUser", newUser, "POS");
                    this.ClearFields();
                }
                else
                {
                    MessageBox.Show(Properties.Resources.PASS_DONT_MATCH, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show(Properties.Resources.FILL_ALL_DETAILS, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }

        private void ClearFields()
        {
            txtFullName.Text = "";
            txtContact.Text = "";
            txtEmailAddress.Text = "";
            txtUserName.Text = "";
            cmbUserRole.SelectedIndex = 0;
            txtNewPassword.Text = "";
            txtNewVerifyPassword.Text = "";
        }

        private void chkShowPasswords_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPasswords.CheckState == CheckState.Checked)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                txtNewVerifyPassword.UseSystemPasswordChar = false;
                chkShowPasswords.Text = "Hide Password";
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
                txtNewVerifyPassword.UseSystemPasswordChar = true;
                chkShowPasswords.Text = "Show Password";
            }
        }
    }
}
