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
            txtTenderedAmount.Enabled = false;
            txtLastDigits.Enabled = false;
            txtBalance.Text = "0.00";
        }

        private void btnTransact_Click(object sender, EventArgs e)
        {
            if ((rdoCash.Checked == true) && !(txtTenderedAmount.Text.Length > 0))
            {
                Messages.DisplayMessage("Please enter a tendered amount.", lblWarning, Color.Red);
                txtTenderedAmount.Focus();
                this.DialogResult = DialogResult.None;
            }
            else if ((txtTenderedAmount.Text.Length > 0) && !(tendered >= _totalAmount))
            {
                Messages.DisplayMessage("Please enter correct tendered amount.", lblWarning, Color.Red);
                txtTenderedAmount.SelectAll();
                this.DialogResult = DialogResult.None;
            }
            else
            {
                CheckOutDataModel checkOutModel = new CheckOutDataModel
                {
                    SaleId = _saleId,
                    CashierId = _cashierId,
                    TotalAmount = _totalAmount,
                    CardDigits = 0,
                    CardType = rdoCard.Text
                };
                dataAccess.SaveData("dbo.SaveTransaction", checkOutModel, "POS");
            }
            if ((rdoCard.Checked == true) && !(txtLastDigits.Text.Length == 6))
            {
                Messages.DisplayMessage("Please enter a six digit number.", lblWarning, Color.Red);
                txtLastDigits.Focus();
                this.DialogResult = DialogResult.None;
            }
            else
            {
                CheckOutDataModel checkOutModel = new CheckOutDataModel
                {
                    SaleId = _saleId,
                    CashierId = _cashierId,
                    TotalAmount = _totalAmount,
                    CardDigits = Convert.ToInt32(txtLastDigits.Text),
                    CardType = rdoCard.Text
                };
                dataAccess.SaveData("dbo.SaveTransaction", checkOutModel, "POS");
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