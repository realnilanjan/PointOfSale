using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.Models;
using System;
using System.Windows.Forms;

namespace PointOfSaleUI.UI
{
    public partial class NewSupplier : Form
    {
        public NewSupplier()
        {
            InitializeComponent();
            txtName.Focus();
        }

        private void ClearFields()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "")
                && (txtAddress.Text != "")
                && (txtContact.Text != "")
                && (txtAddress.Text != ""))
            {
                SupplierModel category = new SupplierModel
                {
                    SupplierName = txtName.Text,
                    Address = txtAddress.Text,
                    Contact = txtContact.Text,
                    EmailAddress = txtEmail.Text
                };
                SQLDataAccess dataAccess = new SQLDataAccess();
                dataAccess.SaveData("dbo.InsertSupplier", category, "POS");
                this.ClearFields();
            }
            else
            {
                MessageBox.Show(Properties.Resources.FILL_ALL_DETAILS, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
