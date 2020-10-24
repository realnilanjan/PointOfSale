using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.DataModel;
using PointOfSale.Lib.Helpers;
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
            Functions.FillCombo(categories, cmbCategory);
            Functions.FillCombo(suppliers, cmbSupplier);
            this.LoadPurchaseOrders();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            if (txtBarcode.Text != "")
            {
                if (txtBarcode.Text.Length >= 10)
                {
                    string Barcode = txtBarcode.Text;
                    purchaseOrder = dataAccess.ProductToStock(Barcode);

                    txtProductName.Text = purchaseOrder[0].Name;
                    txtBrandName.Text = purchaseOrder[0].Brand;
                    txtUnitPrice.Text = purchaseOrder[0].StockPrice.ToString("N2");
                    cmbCategory.SelectedValue = purchaseOrder[0].CategoryId;
                    cmbSupplier.SelectedValue = purchaseOrder[0].SupplierId;
                }
            }
        }

        private void txtOrderQty_TextChanged(object sender, EventArgs e)
        {
            double price = double.Parse(txtUnitPrice.Text.ToString());
            int qty = int.Parse(txtOrderQty.Text.ToString());
            totalPrice = price * qty;

            txtUnitPrice.Text = totalPrice.ToString("N2");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;

            PurchaseOrderModel purchaseOrder = new PurchaseOrderModel
            {
                Barcode = txtBarcode.Text,
                OrderQuantity = Convert.ToInt32(txtOrderQty.Text),
                OrderTotal = Convert.ToDecimal(txtUnitPrice.Text),
                Supplier = Convert.ToInt32(cmbCategory.SelectedValue),
                Remarks = "Ordered"
            };
            dataAccess.SaveData("dbo.InsertStockPurchaseOrder", purchaseOrder, "POS");
            this.LoadPurchaseOrders();
            this.ClearAll();
            btnAdd.Enabled = true;
        }

        private void LoadPurchaseOrders()
        {
            stockOrders = dataAccess.LoadPurchasedStock();
            gridStockPurchaseOrders.DataSource = stockOrders;
        }

        private void ClearAll()
        {
            txtBarcode.Text = "";
            txtProductName.Text = "";
            txtBrandName.Text = "";
            txtUnitPrice.Text = "0.00";
            txtOrderQty.Text = "1";
            cmbCategory.SelectedIndex = 0;
            cmbSupplier.SelectedIndex = 0;
            txtBarcode.Focus();
        }
    }
}
