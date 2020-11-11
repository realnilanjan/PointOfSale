using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.Models;
using PointOfSale.Lib.Models.ReportModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSaleUI.UI.Reports
{
    public partial class TerminalTransactions : Form
    {
        SQLDataAccess dataAccess = new SQLDataAccess();
        List<OrderDetailModel> AllSales = new List<OrderDetailModel>();
        List<AllSalesModel> AllSalesByDate = new List<AllSalesModel>();
        List<OrderPrintDetail> printDetails = new List<OrderPrintDetail>();
        OrderDetailModel soldOrder = new OrderDetailModel();

        public TerminalTransactions()
        {
            InitializeComponent();
            fromDate.Value = DateTime.Today;
            toDate.Value = DateTime.Now.AddDays(1);
            //allTransactionsGridView.Visible = true;
            GetAllSales();
        }

        private void GetAllSales()
        {
            allTransactionsGridView.DataSource = null;
            AllSales = dataAccess.GetAllSales();
            allTransactionsGridView.DataSource = AllSales;
            allTransactionsGridView.ClearSelection();
            lblDetailsCount.Text = String.Format(Properties.Resources.NO_OF_ITEMS, AllSales.Count.ToString());
        }

        private void GetSalesBetweenDate()
        {
            AllSalesByDate = dataAccess.GetAllSalesByDate(fromDate.Value, toDate.Value);
            if (AllSalesByDate.Count > 0)
            {
                allTransactionsGridView.DataSource = null;
                allTransactionsGridView.Visible = true;
                allTransactionsGridView.DataSource = AllSalesByDate;
                allTransactionsGridView.ClearSelection();
                lblDetailsCount.Visible = true;
                lblDetailsCount.Text = String.Format(Properties.Resources.NO_OF_ITEMS, AllSalesByDate.Count.ToString());
            }
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
            if (rdoAllSales.Checked == true)
            {
                panel1.Enabled = false;
                allTransactionsGridView.Visible = true;
                GetAllSales();
            }
        }

        private void rdoAllSalesDated_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAllSalesDated.Checked == true)
            {
                panel1.Enabled = true;
                allTransactionsGridView.Visible = false;
                lblDetailsCount.Visible = false;
            }
            //GetSalesBetweenDate();
        }

        private void btnLoadTransactions_Click(object sender, EventArgs e)
        {
            GetSalesBetweenDate();
        }

        private void allTransactionsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int SaleId = Convert.ToInt32(allTransactionsGridView.CurrentRow.Cells[0].Value);

            soldOrder = dataAccess.GetLastSale(SaleId);
            printDetails = dataAccess.PrintLastSale(SaleId);

            AfterSaleReportForm orderPrint = new AfterSaleReportForm(BusinessInformation.BusinessInfo, soldOrder, printDetails);
            DialogResult printResult = orderPrint.ShowDialog();
            if (printResult == DialogResult.OK)
            {
                //TODO: Do something
            }
        }
    }
}
