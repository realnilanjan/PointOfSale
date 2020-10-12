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
                cmbBusinessType.SelectedIndex = 1;
            }
            else
            {
                panelAdminAccountCreation.Visible = true;
                lnkSetupBusinessInfo.Font = new Font(lnkSetupBusinessInfo.Font, FontStyle.Regular);
                lnkCreateAdminAccount.Font = new Font(lnkCreateAdminAccount.Font, FontStyle.Bold);
                panelBusiness.Visible = false;
                txtUsername.Focus();
                cmbUserType.SelectedIndex = 1;
                btnBack.Visible = true;
                btnNext.Text = "Finish";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.WizardStep == 1)
            {
                Properties.Settings.Default.WizardStep++;
                Properties.Settings.Default.Save();
                panelAdminAccountCreation.Visible = false;
                panelAdminAccountCreation.Visible = true;
                lnkSetupBusinessInfo.Font = new Font(lnkSetupBusinessInfo.Font, FontStyle.Regular);
                lnkCreateAdminAccount.Font = new Font(lnkCreateAdminAccount.Font, FontStyle.Bold);
                txtUsername.Focus();
                btnBack.Visible = true;
                btnNext.Text = "Finish";
            }
            else
            {
                //TODO: Finish Wizard
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
    }
}
