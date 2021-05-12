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
    public partial class OrderStock : Form
    {
        SQLDataAccess dataAccess = new SQLDataAccess();
        List<CategoryDataModel> categories = new List<CategoryDataModel>();
        List<SupplierDataModel> suppliers = new List<SupplierDataModel>();
        List<ProductToStockDataModel> purchaseOrder = new List<ProductToStockDataModel>();
        List<PurchaseOrdersDataModel> stockOrders = new List<PurchaseOrdersDataModel>();
        double totalPrice;

        public OrderStock()
        {
            InitializeComponent();
            categories = dataAccess.LoadAllCategories();
            suppliers = dataAccess.LoadAllSuppliers();
            Utils.FillCombo(suppliers, cmbSupplier);
            this.LoadPurchaseOrders();
        }

        private void LoadPurchaseOrders()
        {
            stockOrders = dataAccess.LoadPurchasedStock();
            if (stockOrders.Count > 0)
            {
                gridStockPurchaseOrders.Visible = true;
                gridStockPurchaseOrders.DataSource = stockOrders;
            }
            else
            {
                gridStockPurchaseOrders.Visible = false;
            }
            btnDeleteStock.Enabled = false;
            gridStockPurchaseOrders.ClearSelection();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBarcode.Text != "")
                {
                    if ((txtBarcode.Text.Length >= 10) || (txtBarcode.Text.Length <= 10))
                    {
                        string Barcode = txtBarcode.Text;
                        purchaseOrder = dataAccess.ProductToStock(Barcode);
                        if (purchaseOrder.Count > 0)
                        {
                            txtProductName.Text = purchaseOrder[0].Name;
                            txtBrandName.Text = purchaseOrder[0].Brand;
                            txtUnitPrice.Text = purchaseOrder[0].StockPrice.ToString("N2");
                            cmbSupplier.SelectedValue = purchaseOrder[0].SupplierId;
                            double price = double.Parse(txtUnitPrice.Text.ToString());
                            int qty = int.Parse(txtOrderQty.Text.ToString());
                            totalPrice = price * qty;
                            txtSubtotal.Text = totalPrice.ToString("N2");
                            btnAdd.Enabled = true;
                        }
                        else
                        {
                            btnAdd.Enabled = false;
                        }
                    }
                }
                else
                {
                    btnAdd.Enabled = false;
                }
            }
            catch (Exception)
            {
                Messages.DisplayMessage("This product is not found in database.", lblWarning, Color.Red);
                this.ClearAll();
            }
        }

        private void txtOrderQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double price = double.Parse(txtUnitPrice.Text.ToString());
                int qty = int.Parse(txtOrderQty.Text.ToString());
                totalPrice = price * qty;
                txtSubtotal.Text = totalPrice.ToString("N2");
            }
            catch (Exception)
            {
                txtOrderQty.Text = "1";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            PurchaseOrderModel purchaseOrder = new PurchaseOrderModel
            {
                Barcode = txtBarcode.Text,
                OrderQuantity = Convert.ToInt32(txtOrderQty.Text),
                OrderTotal = Convert.ToDecimal(txtSubtotal.Text),
                Remarks = "Ordered"
            };
            dataAccess.SaveData("dbo.InsertStockPurchaseOrder", purchaseOrder, "POS");
            Messages.DisplayMessage("Purchase order for the product is placed.", lblWarning, Color.SeaGreen);
            this.LoadPurchaseOrders();
            this.ClearAll();
            btnAdd.Enabled = true;
        }

        private void ClearAll()
        {
            txtBarcode.Text = "";

            txtProductName.ReadOnly = false;
            txtBrandName.ReadOnly = false;
            txtUnitPrice.ReadOnly = false;
            txtSubtotal.ReadOnly = false;

            txtProductName.Text = "";
            txtBrandName.Text = "";
            txtUnitPrice.Text = "0.00";
            txtOrderQty.Text = "1";
            txtSubtotal.Text = "0.00";
            cmbSupplier.SelectedIndex = 0;
            txtBarcode.Focus();
        }

        private void gridStockPurchaseOrders_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetText(gridStockPurchaseOrders[e.ColumnIndex, e.RowIndex].Value.ToString());
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete the selected stocks?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in gridStockPurchaseOrders.Rows)
                {
                    if (r.Selected == true)
                    {
                        int Id = Convert.ToInt32(r.Cells[0].Value);
                        dataAccess.SaveData("dbo.DeletePurchaseOrder", new { Id = Id }, "POS");
                    }
                }
                this.LoadPurchaseOrders();
            }
            else
            {
                return;
            }
        }

        private void gridStockPurchaseOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteStock.Enabled = true;
        }
    }
}
