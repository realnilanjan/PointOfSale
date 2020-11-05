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
    public partial class ViewAllTransaction : Form
    {
        SQLDataAccess dataAccess = new SQLDataAccess();
        List<AllSales> allSales = new List<AllSales>();

        public ViewAllTransaction()
        {
            InitializeComponent();
        }

        private void btnLoadTransactions_Click(object sender, EventArgs e)
        {
            //allTransactionsGridView.Visible = true;
            //allSales = dataAccess.GetAllSalesByDate(ReportQuery.GetAllSalesByDate(fromDate.Value, toDate.Value));
            //allTransactionsGridView.DataSource = allSales;
        }
    }
}
