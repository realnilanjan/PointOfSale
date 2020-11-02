using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.Helpers;
using PointOfSale.Lib.TerminalModels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PointOfSaleUI.UI
{
    public partial class ProcessCheckout : Form
    {
        SQLDataAccess dataAccess = new SQLDataAccess();

        private readonly int _saleId;
        private readonly int _cashierId;
        private static decimal _totalAmount;
        private static decimal tendered;
        private decimal balance;

        public ProcessCheckout(int saleId, int cashierId, decimal totalAmount)
        {
            InitializeComponent();
            _saleId = saleId;
            _cashierId = cashierId;
            _totalAmount = totalAmount;
            txtTotalAmount.Text = _totalAmount.ToString("N2");
            rdoCash.Checked = true;
            txtBalance.Text = "0.00";
        }

        private void rdoCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCash.Checked == true)
            {
                txtLastDigits.Clear();
                txtTenderedAmount.Enabled = true;
                txtTenderedAmount.Focus();
            }
            else { txtTenderedAmount.Enabled = false; }
        }

        private void rdoCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCard.Checked == true)
            {
                txtTenderedAmount.Clear();
                txtLastDigits.Enabled = true;
                txtLastDigits.Focus();
            }
            else { txtLastDigits.Enabled = false; }
        }

        private void rdoUpi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoUpi.Checked == true)
            {
                txtTenderedAmount.Enabled = false;
                txtLastDigits.Enabled = false;
                txtBalance.Text = "0.00";
                if (Properties.Settings.Default.QRCodePath.Contains("\r\n"))
                {
                    MessageBox.Show("No QR Code is set. Please go to Settings to add one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    ShowQR showQR = new ShowQR();
                    showQR.ShowDialog();
                }
            }
        }

        private void btnTransact_Click(object sender, EventArgs e)
        {
            if (rdoCash.Checked == true)
            {
                if (!(txtTenderedAmount.Text.Length > 0))
                {
                    Messages.DisplayMessage("Please enter a tendered amount.", lblWarning, Color.Red);
                    txtTenderedAmount.Focus();
                    this.DialogResult = DialogResult.None;
                    return;
                }
                else if (!(tendered >= _totalAmount))
                {
                    Messages.DisplayMessage("Please enter correct tendered amount.", lblWarning, Color.Red);
                    txtTenderedAmount.SelectAll();
                    this.DialogResult = DialogResult.None;
                    return;
                }
                else
                {
                    CheckOutDataModel.CardDigits = "000000";
                    CheckOutDataModel.CardType = rdoCash.Text;
                }
            }

            if (rdoCard.Checked == true)
            {
                if (!(txtLastDigits.Text.Length == 6))
                {
                    Messages.DisplayMessage("Please enter a six digit number.", lblWarning, Color.Red);
                    txtLastDigits.Focus();
                    this.DialogResult = DialogResult.None;
                    return;
                }
                else
                {
                    CheckOutDataModel.CardDigits = txtLastDigits.Text;
                    CheckOutDataModel.CardType = rdoCard.Text;
                }
            }
        }

        private void txtTenderedAmount_TextChanged(object sender, EventArgs e)
        {
            balance = 0;
            try
            {
                tendered = Convert.ToDecimal(txtTenderedAmount.Text);
                balance = tendered - _totalAmount;
                txtBalance.Text = balance.ToString("N2");
            }
            catch (Exception) { }
        }
    }
}