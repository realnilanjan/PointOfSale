using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.DataModel;
using PointOfSale.Lib.Helpers;
using PointOfSale.Lib.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PointOfSaleUI.UI
{
    public partial class PurchaseOrders : Form
    {
        SQLDataAccess dataAccess = new SQLDataAccess();
        private readonly LoggedInUserModel loggedInUser;
        List<OrderedStockPurchasesModel> purchaseOrders = new List<OrderedStockPurchasesModel>();
        List<PurchasedStockDataModel> stockIns = new List<PurchasedStockDataModel>();
        
        public PurchaseOrders(LoggedInUserModel loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            this.LoadAllPurchasedStocks();
        }

        private void LoadAllPurchasedStocks()
        {
            stockIns = dataAccess.LoadAllStockPurchased();
            if (stockIns.Count > 0)
            {
                gridReceivedOrders.Visible = true;
                gridReceivedOrders.DataSource = stockIns;
            }
            else
            {
                gridReceivedOrders.Visible = false;
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    if (txtBarcode.Text != "")
                    {
                        if (txtBarcode.Text.Length >= 10)
                        {
                            string Barcode = txtBarcode.Text;
                            purchaseOrders = dataAccess.GetOrderedStockPurchases(Barcode);
                            if (purchaseOrders.Count > 0)
                            {
                                gridPurchaseOrders.DataSource = purchaseOrders;
                                gridPurchaseOrders.Visible = true;
                                btnAdd.Enabled = true;
                            }
                            else
                            {
                                Messages.DisplayMessage("No purchase orders found for the given Barcode.", lblWarning, Color.Red);
                                gridPurchaseOrders.Visible = false;
                                btnAdd.Enabled = false;
                            }
                        }
                        else
                        {
                            gridPurchaseOrders.DataSource = null;
                            gridPurchaseOrders.Visible = false;
                        }
                    }
                }
                catch (Exception)
                {
                    Messages.DisplayMessage("No purchase orders found for the given Barcode.", lblWarning, Color.Red);
                    txtBarcode.Text = "";
                    txtBarcode.Focus();
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
                dataAccess.SaveData("dbo.InsertPurchasedStock", purchasedStock, "POS");
                int OrderId = Convert.ToInt32(dgvr.Cells[0].Value);
                dataAccess.SaveData("dbo.UpdateOrder", new { OrderId = OrderId }, "POS");
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
            Messages.DisplayMessage("Stocks purchased are received.", lblWarning, Color.LimeGreen);
            this.LoadAllPurchasedStocks();
        }

       
    }
}