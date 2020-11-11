using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.Models.ReportModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleUI.UI.Reports
{
    public partial class TerminalTransactions : Form
    {
        SQLDataAccess dataAccess = new SQLDataAccess();
        List<OrderDetailModel> AllSales = new List<OrderDetailModel>();

        public TerminalTransactions()
        {
            InitializeComponent();
            GetAllSales();
        }

        private void GetAllSales()
        {
            AllSales = dataAccess.GetAllSales();
            allTransactionsGridView.DataSource = AllSales;
        }

        private void GetSalesBetweenDate()
        {

        }

        private void txtTransactionSearch_TextChanged(object sender, EventArgs e)
        {
            switch (cmbSearchTransactionBy.GetItemText(cmbSearchTransactionBy.SelectedItem))
            {
                case "Invoice Number":
                    var InvResult = AllSales.Where(x => x.InvoiceNumber.ToString().Contains(txtTransactionSearch.Text)).ToList();
                    allTransactionsGridView.DataSource = InvResult;
                    break;
                case "Customer Name":
                    var NameResult = AllSales.Where(x => x.CustomerName.Contains(txtTransactionSearch.Text)).ToList();
                    allTransactionsGridView.DataSource = NameResult;
                    break;
                case "Customer Contact":
                    var ContactResult = AllSales.Where(x => x.CustomerPhone.Contains(txtTransactionSearch.Text)).ToList();
                    allTransactionsGridView.DataSource = ContactResult;
                    break;
            }
        }

        private void rdoAllSales_CheckedChanged(object sender, EventArgs e)
        {
            GetAllSales();
        }

        private void rdoAllSalesDated_CheckedChanged(object sender, EventArgs e)
        {

            //GetSalesBetweenDate();
        }
    }
}
