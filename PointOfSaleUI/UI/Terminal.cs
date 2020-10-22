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
    public partial class Terminal : Form
    {
        private readonly LoggedInUserModel _loggedInUser;

        public Terminal(LoggedInUserModel loggedInUser)
        {
            InitializeComponent();
            this._loggedInUser = loggedInUser;
            txtBusinessName.Text = BusinessInformation.BusinessInfo[0].BusinessName;
            txtBusinessAddress.Text = BusinessInformation.BusinessInfo[0].BusinsessAddress;
            txtBusinessContact.Text = BusinessInformation.BusinessInfo[0].BusinessContact;
            txtCashierName.Text = _loggedInUser.Fullname;
            txtUserRole.Text = _loggedInUser.UserRole;
            txtBarcode.Focus();
        }

        private void dateTimeTimer_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("D");
            txtTime.Text = DateTime.Now.ToString("T");
        }

        private void btnClearCode_Click(object sender, EventArgs e)
        {
            txtBarcode.Clear();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            if (txtBarcode.Text.Length > 0)
            {
                btnClearCode.Enabled = true;
            }
            else
            {
                btnClearCode.Enabled = false;
            }
        }
    }
}
