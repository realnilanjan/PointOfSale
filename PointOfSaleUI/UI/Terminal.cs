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



        private decimal DeliveryRate = Properties.Settings.Default.DeliveryRate;
        private decimal Total;

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
            switch (_loggedInUser.UserRole)
            {
                case "Administrator":
                    btnAdmin.Enabled = true;
                    break;
                case "Manager":
                    btnAdmin.Enabled = true;
                    break;
                case "Cashier":
                    btnAdmin.Enabled = false;
                    break;
            }
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

        private void txtCouponCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCouponCode.Text.Length == 8)
            {
                btnApplyCoupon.Enabled = true;
            }
            else
            {
                btnApplyCoupon.Enabled = false;
            }
        }

        private void chkDelivery_OnChange(object sender, EventArgs e)
        {
            if (chkDelivery.Checked == true)
            {
                lblDelivery.ForeColor = Color.White;
                lblDeliveryRupee.ForeColor = Color.White;
                txtDelivery.ForeColor = Color.White;
                txtDelivery.Text = DeliveryRate.ToString("N2");
                Total += DeliveryRate;
                txtTotal.Text = Total.ToString("N2");

                //TODO: Get Delivery Rates and set to txtDelivery and count total
            }
            else
            {
                lblDelivery.ForeColor = Color.Gray;
                lblDeliveryRupee.ForeColor = Color.Gray;
                txtDelivery.ForeColor = Color.Gray;
                txtDelivery.Text = "0.00";
                Total -= DeliveryRate;
                txtTotal.Text = Total.ToString("N2");
            }
        }
    }
}
