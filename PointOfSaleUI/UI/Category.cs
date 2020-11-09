using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.Models;
using System;
using System.Windows.Forms;

namespace PointOfSaleUI.UI
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            txtCategoryName.Focus();
        }

        private void ClearFields()
        {
            txtCategoryName.Text = "";
            txtCategoryDescription.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtCategoryName.Text != "")
                && (txtCategoryDescription.Text != ""))
            {

                CategoryModel category = new CategoryModel
                {
                    CategoryName = txtCategoryName.Text,
                    CategoryDescription = txtCategoryDescription.Text,
                };
                SQLDataAccess dataAccess = new SQLDataAccess();
                dataAccess.SaveData("dbo.InsertCategory", category, "POS");
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