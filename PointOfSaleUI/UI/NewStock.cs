using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.DataModel;
using PointOfSale.Lib.Helpers;
using PointOfSale.Lib.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PointOfSaleUI.UI
{
    public partial class NewStock : Form
    {
        SQLDataAccess dataAccess = new SQLDataAccess();
        List<CategoryDataModel> categories;
        List<SupplierDataModel> suppliers;
        List<QuantityDescriptionModel> quantityDescriptions;

        public NewStock()
        {
            InitializeComponent();
            categories = dataAccess.LoadAllCategories();
            suppliers = dataAccess.LoadAllSuppliers();
            quantityDescriptions = dataAccess.LoadAllQuantityDescriptions();
            Functions.FillCombo(categories, cmbCategory);
            Functions.FillCombo(suppliers, cmbSupplier);
            Functions.FillCombo(quantityDescriptions, cmbQtyDescId);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtBarcode.Text != "")
                && (txtBrandName.Text != "")
                && (txtQtyDesc.Text != "")
                && (txtProductName.Text != "")
                && (txtUnitPrice.Text != "")
                && (txtRetailPrice.Text != "")
                && (txtStockInHand.Text != ""))
            {
                ProductModel newProduct = new ProductModel
                {
                    Barcode = txtBarcode.Text,
                    QtyDescId = Convert.ToInt32(cmbQtyDescId.SelectedValue),
                    QtyDescription = txtQtyDesc.Text,
                    Brand = txtBrandName.Text,
                    Name = txtProductName.Text,
                    StockPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    RetailPrice = Convert.ToDecimal(txtRetailPrice.Text),
                    StockInHand = Convert.ToInt32(txtStockInHand.Text),
                    CategoryId = Convert.ToInt32(cmbCategory.SelectedValue),
                    SupplierId = Convert.ToInt32(cmbSupplier.SelectedValue),
                    IsTaxable = chkIsTaxable.Checked
                };
                dataAccess.SaveData("dbo.InsertProduct", newProduct, "POS");
                this.ClearFields();
            }
            else
            {
                MessageBox.Show(Properties.Resources.FILL_ALL_DETAILS, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }

        private void ClearFields()
        {
            txtBarcode.Text = "";
            txtBrandName.Text = "";
            txtQtyDesc.Text = "";
            txtProductName.Text = "";
            txtUnitPrice.Text = "";
            txtRetailPrice.Text = "";
            txtStockInHand.Text = "";
            txtBarcode.Focus();
        }
    }
}