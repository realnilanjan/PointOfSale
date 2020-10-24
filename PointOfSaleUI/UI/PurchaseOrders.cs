using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.DataModel;
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
    public partial class PurchaseOrders : Form
    {
        SQLDataAccess dataAccess = new SQLDataAccess();
        private readonly LoggedInUserModel loggedInUser;

        public PurchaseOrders(LoggedInUserModel loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            this.LoadAllPurchasedStocks();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            {
                if (txtBarcode.Text != "")
                {
                    if (txtBarcode.Text.Length >= 10)
                    {
                        string Barcode = txtBarcode.Text;
                        List<OrderedStockPurchasesModel> purchaseOrders = new List<OrderedStockPurchasesModel>();
                        purchaseOrders = dataAccess.GetOrderedStockPurchases(Barcode);
                        gridPurchaseOrders.DataSource = purchaseOrders;
                    }
                    else
                    {
                        //gridPurchaseOrders.DataSource = null;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in gridPurchaseOrders.Rows)
            {
                PurchasedStockUpdateModel purchasedStock = new PurchasedStockUpdateModel
                {
                    Barcode = txtBarcode.Text,
                    NewStockQty = Convert.ToInt32(dgvr.Cells[2].Value)
                };

                //Insert New Purchased Stock
                dataAccess.SaveData("dbo.InsertPurchasedStock", purchasedStock, "POS");

                //Update Order table as stock received
                int OrderId = Convert.ToInt32(dgvr.Cells[0].Value);
                dataAccess.SaveData("dbo.UpdateOrder", new { OrderId = OrderId }, "POS");

                //Update Products table with new order received.
                PurchasedStockModel stockInModel = new PurchasedStockModel
                {
                    Barcode = dgvr.Cells[1].Value.ToString(),
                    ReceivedQty = Convert.ToInt32(dgvr.Cells[2].Value),
                    SubTotal = Convert.ToDecimal(dgvr.Cells[3].Value),
                    UserId = loggedInUser.UserId,
                    OrderId = Convert.ToInt32(dgvr.Cells[0].Value)
                };
                
                dataAccess.SaveData("dbo.InsertStockPurchased", stockInModel, "POS");
            }
            txtBarcode.Text = "";
            txtBarcode.Focus();
            this.LoadAllPurchasedStocks();
        }

        private void LoadAllPurchasedStocks()
        {
            List<PurchasedStockDataModel> stockIns = new List<PurchasedStockDataModel>();
            stockIns = dataAccess.LoadAllStockPurchased();
            gridReceivedOrders.DataSource = stockIns;
        }
    }
}