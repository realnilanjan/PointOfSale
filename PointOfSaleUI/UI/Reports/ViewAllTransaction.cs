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
using PointOfSaleUI.Helpers.ReportsQueries;

namespace PointOfSaleUI.UI.Reports
{
    public partial class ViewAllTransaction : Form
    {
        private readonly bool _isCustomerTransaction;
        SQLDataAccess dataAccess = new SQLDataAccess();
        List<AllSalesByCustomer> allSalesByCustomer = new List<AllSalesByCustomer>();
        List<AllSales> allSales = new List<AllSales>();

        public ViewAllTransaction(bool isCustomerTransaction)
        {
            InitializeComponent();
            fromDate.Value = DateTime.Today;
            toDate.Value = DateTime.Now.AddDays(1);
            this._isCustomerTransaction = isCustomerTransaction;
            if (_isCustomerTransaction == true)
            {
                this.Text = "View All Transactions of Customers";
            }
            else
            {
                this.Text = "View All Transactions";
            }
        }

        private void btnLoadTransactions_Click(object sender, EventArgs e)
        {
            if (_isCustomerTransaction == true)
            {
                allTransactionsGridView.Visible = true;
                allSalesByCustomer = dataAccess.GetAllSalesByDateAndCustomer(Queries.GetAllSalesByDateAndCustomer(fromDate.Value, toDate.Value));
                if (allSalesByCustomer.Count > 0)
                {
                    allTransactionsGridView.DataSource = allSalesByCustomer;
                    allTransactionsGridView.ClearSelection();
                }
                else
                {
                    allTransactionsGridView.Visible = false;
                    lblError.Text = "No data found for the given range";
                } 
            }
            else
            {
                allTransactionsGridView.Visible = true;
                allSales = dataAccess.GetAllSalesByDate(Queries.GetAllSalesByDate(fromDate.Value, toDate.Value));
                if (allSales.Count > 0)
                {
                    allTransactionsGridView.DataSource = allSales;
                    allTransactionsGridView.ClearSelection();
                }
                else
                {
                    allTransactionsGridView.Visible = false;
                    lblError.Text = "No data found for the given range";
                }
            }
        }

        private void fromDate_onValueChanged(object sender, EventArgs e)
        {
            fromDate.Value = fromDate.Value.Date;
        }

        private void toDate_onValueChanged(object sender, EventArgs e)
        {
            toDate.Value = toDate.Value.Date;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            AllSalesByCustomer obj = allSalesByCustomerBindingSource.Current as AllSalesByCustomer;



        }
    }
}
