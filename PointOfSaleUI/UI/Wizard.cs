using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.Encryptions;
using PointOfSale.Lib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleUI.UI
{
    public partial class Wizard : Form
    {
        int businessTypeSelected;
        int userRoleSelected;

        BusinessModel businessModel;
        NewUserModel newUserModel;

        public Wizard()
        {
            InitializeComponent();
            if (Properties.Settings.Default.WizardStep == 1)
            {
                lnkSetupBusinessInfo.Font = new Font(lnkSetupBusinessInfo.Font, FontStyle.Bold);
                lnkCreateAdminAccount.Font = new Font(lnkCreateAdminAccount.Font, FontStyle.Regular);
                panelBusiness.Visible = true;
                panelAdminAccountCreation.Visible = false;
                txtBusinessName.Focus();
                cmbBusinessType.SelectedIndex = 1; businessTypeSelected = cmbBusinessType.SelectedIndex;
            }
            else
            {
                panelAdminAccountCreation.Visible = true;
                lnkSetupBusinessInfo.Font = new Font(lnkSetupBusinessInfo.Font, FontStyle.Regular);
                lnkCreateAdminAccount.Font = new Font(lnkCreateAdminAccount.Font, FontStyle.Bold);
                panelBusiness.Visible = false;
                txtFullName.Focus();
                cmbUserRole.SelectedIndex = 1; userRoleSelected = cmbUserRole.SelectedIndex;
                btnBack.Visible = true;
                btnNext.Text = "Finish";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.WizardStep == 1)
            {
                if ((txtBusinessName.Text != "") && (txtGSTIN.Text != "") && (txtBusinessAddress.Text != "") && (txtContactNumber.Text != "") && (txtEmailAddress.Text != ""))
                {
                    Properties.Settings.Default.WizardStep++;
                    Properties.Settings.Default.Save();
                    panelAdminAccountCreation.Visible = false;
                    panelAdminAccountCreation.Visible = true;
                    lnkSetupBusinessInfo.Font = new Font(lnkSetupBusinessInfo.Font, FontStyle.Regular);
                    lnkCreateAdminAccount.Font = new Font(lnkCreateAdminAccount.Font, FontStyle.Bold);
                    cmbUserRole.SelectedIndex = userRoleSelected;
                    txtFullName.Focus();
                    btnBack.Visible = true;
                    btnNext.Text = "Finish";

                    businessModel = new BusinessModel
                    {
                        BusinessName = txtBusinessName.Text,
                        GSTNumber = txtGSTIN.Text,
                        BusinessType = cmbBusinessType.GetItemText(cmbBusinessType.SelectedItem),
                        BusinsessAddress = txtBusinessAddress.Text,
                        BusinessContact = txtContactNumber.Text,
                        BusinessEmail = txtEmailAddress.Text
                    };
                }
                else
                {
                    MessageBox.Show("Please fill in all the details first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if ((txtFullName.Text != "") || (txtUsername.Text != "") || (txtBusinessAddress.Text != "") || (txtContactNumber.Text != "") || (txtEmailAddress.Text != ""))
                {
                    if (txtPassword.Text == txtVerifyPassword.Text)
                    {
                        newUserModel = new NewUserModel
                        {
                            Fullname = txtFullName.Text,
                            Username = txtUsername.Text,
                            Password = EncryptTo.MD5Hash(txtVerifyPassword.Text),
                            UserRole = cmbUserRole.GetItemText(cmbUserRole.SelectedItem),
                            Contact = txtUserContact.Text,
                            EmailAddress = txtUserEmail.Text,
                            Status = "1"
                        };

                        SQLDataAccess dataAccess = new SQLDataAccess();
                        dataAccess.SaveData("dbo.SaveBusiness", businessModel, "POS");
                        dataAccess.SaveData("dbo.SaveUser", newUserModel, "POS");

                        Properties.Settings.Default.WizardStep++;
                        Properties.Settings.Default.Save();

                        Login login = new Login();
                        this.Close();
                        login.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all the details first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.WizardStep--;
            Properties.Settings.Default.Save();
            lnkSetupBusinessInfo.Font = new Font(lnkSetupBusinessInfo.Font, FontStyle.Bold);
            lnkCreateAdminAccount.Font = new Font(lnkCreateAdminAccount.Font, FontStyle.Regular);
            panelAdminAccountCreation.Visible = false; 
            panelBusiness.Visible = true;
            cmbBusinessType.SelectedIndex = businessTypeSelected;
            txtBusinessName.Focus();
            btnBack.Visible = false;
            btnNext.Text = "Next >>";
        }

        private void lnkSetupBusinessInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnBack.PerformClick();
        }

        private void lnkCreateAdminAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnNext.PerformClick();
        }

        private void cmbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            userRoleSelected = cmbUserRole.SelectedIndex;
        }

        private void cmbBusinessType_SelectedIndexChanged(object sender, EventArgs e)
        {
            businessTypeSelected = cmbBusinessType.SelectedIndex;
        }
    }
}
