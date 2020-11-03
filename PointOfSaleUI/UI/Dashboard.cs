using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.DataModel;
using PointOfSale.Lib.Encryptions;
using PointOfSale.Lib.Helpers;
using PointOfSale.Lib.Models;
using PointOfSale.Lib.Models.ReportModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSaleUI.UI
{
    public partial class Dashboard : Form
    {
        SQLDataAccess dataAccess = new SQLDataAccess();
        private readonly LoggedInUserModel _loggedInUser;
        List<UserDataModel> users = new List<UserDataModel>();
        List<CategoryDataModel> categories = new List<CategoryDataModel>();
        List<SupplierDataModel> suppliers = new List<SupplierDataModel>();
        List<ProductDataModel> products = new List<ProductDataModel>();
        List<CategoryDataModel> productCategories = new List<CategoryDataModel>();
        List<SupplierDataModel> productSuppliers = new List<SupplierDataModel>();
        TodaysSales todaysSales = new TodaysSales();

        string IsBlocked = "1";  //1 Is not blocked || 0 is blocked

        public Dashboard(LoggedInUserModel loggedInUser)
        {
            InitializeComponent();
            this._loggedInUser = loggedInUser;
            txtUserFullName.Text = _loggedInUser.Fullname;
            txtUserRole.Text = _loggedInUser.UserRole;
            txtBusinessName.Text = BusinessInformation.BusinessInfo[0].BusinessName;
            this.RefreshDashboard();
        }

        #region Functions
        private void RefreshDashboard()
        {
            //Today's Sales
            string DateToday = DateTime.Now.ToString("dd-MM-yyyy") + " 00:00:00";
            todaysSales = dataAccess.LoadTodaySalesTotal(DateToday);
            //var todaysales = from sl in todaysSales
            //                 group sl by sl.GrandTotal into g
            //                 select new
            //                 {
            //                     TodaysSale = g.Sum(x => x.GrandTotal)
            //                 };
            string TotalSalesToday = todaysSales.GrandTotal.ToString("N2");
            txtTodaysSales.Text = String.Format(Properties.Resources.RUPEE_SYMBOL, TotalSalesToday);

            //Products
            products = dataAccess.LoadAllProducts();
            txtTotalProduct.Text = String.Format(Properties.Resources.TOTAL_PRODUCTS, products.Count.ToString());
            var stockInfo = from sl in products
                            group sl by sl.StockInHand into g
                            select new
                            {
                                Total = g.Sum(x => x.StockInHand)
                            };
            txtTotalStock.Text = String.Format(Properties.Resources.TOTAL_STOCK, stockInfo.Sum(x => x.Total));

            //Total Sales
            string TotalSales = dataAccess.GetAllSaleTotal().ToString("N2");
            txtTotalSales.Text = String.Format(Properties.Resources.RUPEE_SYMBOL, TotalSales);


            //Sold Stock



            //Number of Transactions

        }

        private void RefreshStaffGrid()
        {
            users = dataAccess.LoadAllUsers();
            userGridView.DataSource = users;
            userGridView.ClearSelection();
            txtTotalStaff.Text = String.Format(Properties.Resources.NO_OF_STAFFS, users.Count);
            this.ClearStaffValues();
        }

        private void RefreshCategoryGrid()
        {
            categories = dataAccess.LoadAllCategories();
            categoryGridView.DataSource = categories;
            categoryGridView.ClearSelection();
            txtNumberOfCategories.Text = String.Format(Properties.Resources.NO_OF_CATEGORIES, categories.Count);
            this.ClearCategoryValues();
        }

        private void RefreshStockGrid()
        {
            products = dataAccess.LoadAllProducts();
            stockGridView.DataSource = products;
            stockGridView.ClearSelection();
            txtTotalProducts.Text = String.Format(Properties.Resources.NO_OF_PRODUCTS, products.Count);
            Helpers.Functions.ProcessGridColor(stockGridView, 8);
            this.ClearStockValues();
        }

        private void RefreshSupplierGrid()
        {
            suppliers = dataAccess.LoadAllSuppliers();
            supplierGridView.DataSource = suppliers;
            supplierGridView.ClearSelection();
            txtTotalSuppliers.Text = String.Format(Properties.Resources.NO_OF_SUPPLIERS, suppliers.Count);
            this.ClearSupplierValues();
        }

        private void RefreshSettings()
        {
            row11.BackColor = Properties.Settings.Default.ZeroToFiveBackColor;
            row12.BackColor = Properties.Settings.Default.ZeroToFiveRowSelectionBackColor;
            row13.BackColor = Properties.Settings.Default.ZeroToFiveRowRowSelectionForeColor;
            row14.BackColor = Properties.Settings.Default.ZeroToFiveRowSelectionForeColor;

            row21.BackColor = Properties.Settings.Default.FiveToTenBackColor;
            row22.BackColor = Properties.Settings.Default.FiveToTenRowSelectionBackColor;
            row23.BackColor = Properties.Settings.Default.FiveToTenRowRowSelectionForeColor;
            row24.BackColor = Properties.Settings.Default.FiveToTenRowSelectionForeColor;

            row31.BackColor = Properties.Settings.Default.TenToFifteenBackColor;
            row32.BackColor = Properties.Settings.Default.TenToFifteenRowSelectionBackColor;
            row33.BackColor = Properties.Settings.Default.TenToFifteenRowRowSelectionForeColor;
            row34.BackColor = Properties.Settings.Default.TenToFifteenRowSelectionForeColor;

            cmbTaxRate.SelectedIndex = Properties.Settings.Default.TaxRateSelected;

            if (Properties.Settings.Default.QRCodePath.Contains("\r\n"))
            {
                lblQRWarning.BackColor = Color.Red;
                lblQRWarning.Text = "No QR Code Set";
            }
            else
            {
                lblQRWarning.BackColor = Color.SeaGreen;
                lblQRWarning.Text = "QR Code is Saved";
            }

            //TODO: Load Settings Here
        }

        private void ClearStaffValues()
        {
            txtUserId.Text = "";
            txtFullName.Text = "";
            txtUserName.Text = "";
            cmbUserRole.SelectedIndex = 0;
            txtContact.Text = "";
            txtEmailAddress.Text = "";
            txtNewPassword.Text = "";
            txtNewVerifyPassword.Text = "";
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void ClearCategoryValues()
        {
            txtCategoryId.Text = "";
            txtCategoryName.Text = "";
            txtCategoryDescription.Text = "";
            btnUpdateCategory.Enabled = false;
            btnDeleteCategory.Enabled = false;
        }

        private void ClearStockValues()
        {
            List<QuantityDescriptionModel> quantityDescriptions = new List<QuantityDescriptionModel>();
            productCategories = dataAccess.LoadAllCategories();
            productSuppliers = dataAccess.LoadAllSuppliers();
            quantityDescriptions = dataAccess.LoadAllQuantityDescriptions();
            txtStockId.Text = "";
            txtBarcode.Text = "";
            Functions.FillCombo(quantityDescriptions, cmbQtyDescId);
            txtQtyDesc.Text = "";
            txtBrandName.Text = "";
            txtProductName.Text = "";
            txtUnitPrice.Text = "";
            txtRetailPrice.Text = "";
            txtStockInHand.Text = "";
            Functions.FillCombo(productCategories, cmbCategory);
            Functions.FillCombo(productSuppliers, cmbSupplier);
            btnUpdateStock.Enabled = false;
            btnDeleteStock.Enabled = false;
            panel1.Enabled = false;
        }

        private void ClearSupplierValues()
        {
            //TODO: Clear Supplier Values
        }

        private void LoadDashboard()
        {
            dashPanel.Visible = true;

            //TODO: Make all other panels invisible
            staffPanel.Visible = false;
            categoryPanel.Visible = false;
            stockPanel.Visible = false;
            supplierPanel.Visible = false;
            settingsPanel.Visible = false;



            //Refresh Data
            this.RefreshDashboard();
        }

        private void LoadStaffPanel()
        {
            staffPanel.Visible = true;
            cmbSearchUserBy.SelectedIndex = 0;
            cmbUserRole.SelectedIndex = 0;

            //TODO: Make all other panels invisible
            dashPanel.Visible = false;
            categoryPanel.Visible = false;
            supplierPanel.Visible = false;
            stockPanel.Visible = false;
            settingsPanel.Visible = false;



            //Refresh Data
            this.RefreshStaffGrid();
        }

        private void LoadCategoryPanel()
        {
            categoryPanel.Visible = true;


            //Make all other panel invisible
            dashPanel.Visible = false;
            staffPanel.Visible = false;
            supplierPanel.Visible = false;
            stockPanel.Visible = false;
            settingsPanel.Visible = false;



            //Refresh Data
            this.RefreshCategoryGrid();
        }

        private void LoadStockPanel()
        {

            stockPanel.Visible = true;
            cmbSearchStockBy.SelectedIndex = 0;

            //Make all other panel invisible
            dashPanel.Visible = false;
            staffPanel.Visible = false;
            categoryPanel.Visible = false;
            supplierPanel.Visible = false;
            settingsPanel.Visible = false;


            //Refresh Data
            this.RefreshStockGrid();
        }

        private void LoadSupplierPanel()
        {
            supplierPanel.Visible = true;


            //Make all other panel invisible
            dashPanel.Visible = false;
            staffPanel.Visible = false;
            categoryPanel.Visible = false;
            stockPanel.Visible = false;
            settingsPanel.Visible = false;


            //Refresh Data
            this.RefreshSupplierGrid();
        }

        private void LoadSettingsPanel()
        {
            settingsPanel.Visible = true;


            //Make all other panel invisible
            dashPanel.Visible = false;
            staffPanel.Visible = false;
            categoryPanel.Visible = false;
            stockPanel.Visible = false;
            supplierPanel.Visible = false;


            //Refresh Data
            this.RefreshSettings();
        }

        #endregion

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 55)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 300;
                panelAnimator2.ShowSync(sideMenu);
                textAnimator.Hide(smalllogo);
                logoAnimator.ShowSync(biglogo);
                textAnimator.ShowSync(userInfo);
                textAnimator.ShowSync(dateInfo);
            }
            else
            {
                logoAnimator.Hide(biglogo);
                textAnimator.Hide(userInfo);
                textAnimator.Hide(dateInfo);
                sideMenu.Visible = false;
                sideMenu.Width = 55;
                panelAnimator.ShowSync(sideMenu);
                logoAnimator.ShowSync(smalllogo);
            }
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("D");
            txtTime.Text = DateTime.Now.ToString("T");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.LoadDashboard();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.LoadStaffPanel();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((txtNewPassword.Text != "") && (txtNewVerifyPassword.Text != ""))
            {
                if (txtNewPassword.Text == txtNewVerifyPassword.Text)
                {
                    WithPasswordModel user = new WithPasswordModel
                    {
                        UserId = Convert.ToInt32(txtUserId.Text),
                        Fullname = txtUserFullName.Text,
                        Username = txtUserName.Text,
                        Password = EncryptTo.MD5Hash(txtNewVerifyPassword.Text),
                        UserRole = cmbUserRole.GetItemText(cmbUserRole.SelectedItem),
                        Contact = txtContact.Text,
                        EmailAddress = txtEmailAddress.Text,
                        Status = IsBlocked
                    };
                    dataAccess.SaveData("dbo.UpdateUserWithPassword", user, "POS");
                    this.RefreshStaffGrid();
                }
                else
                {
                    MessageBox.Show(Properties.Resources.PASS_DONT_MATCH, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if ((txtNewPassword.Text == "") && (txtNewVerifyPassword.Text == ""))
            {
                WithoutPasswordModel user = new WithoutPasswordModel
                {
                    UserId = Convert.ToInt32(txtUserId.Text),
                    Fullname = txtUserFullName.Text,
                    Username = txtUserName.Text,
                    UserRole = cmbUserRole.GetItemText(cmbUserRole.SelectedItem),
                    Contact = txtContact.Text,
                    EmailAddress = txtEmailAddress.Text,
                    Status = IsBlocked
                };


                dataAccess.SaveData("dbo.UpdateUserWithoutPassword", user, "POS");
                this.RefreshStaffGrid();
            }
            else
            {
                MessageBox.Show(Properties.Resources.PUT_PASSWORDS, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStaffSearch_TextChanged(object sender, EventArgs e)
        {
            switch (cmbSearchUserBy.GetItemText(cmbSearchUserBy.SelectedItem))
            {
                case "ID":
                    var IdResult = users.Where(x => x.UserId.ToString().Contains(txtStaffSearch.Text)).ToList();
                    userGridView.DataSource = IdResult;
                    break;
                case "Full Name":
                    var NameResult = users.Where(x => x.Fullname.Contains(txtStaffSearch.Text)).ToList();
                    userGridView.DataSource = NameResult;
                    break;
                case "Username":
                    var UsernameResult = users.Where(x => x.Username.Contains(txtStaffSearch.Text)).ToList();
                    userGridView.DataSource = UsernameResult;
                    break;
                case "User Role":
                    var UserRoleResult = users.Where(x => x.UserRole.Contains(txtStaffSearch.Text)).ToList();
                    userGridView.DataSource = UserRoleResult;
                    break;
                case "Contact Number":
                    var ContactResult = users.Where(x => x.Contact.Contains(txtStaffSearch.Text)).ToList();
                    userGridView.DataSource = ContactResult;
                    break;
                case "Email Address":
                    var EmailResult = users.Where(x => x.EmailAddress.Contains(txtStaffSearch.Text)).ToList();
                    userGridView.DataSource = EmailResult;
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this user?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int UserId = Convert.ToInt32(txtUserId.Text);
                dataAccess.SaveData("dbo.DeleteUser", new { UserId = UserId }, "POS");
                this.RefreshStaffGrid();
            }
            else { return; }
        }

        private void cmbSearchUserBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchUserBy.SelectedIndex > 0)
            {
                txtStaffSearch.Enabled = true;
            }
        }

        private void chkBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlock.CheckState == CheckState.Checked)
            {
                IsBlocked = "0";
            }
            else
            {
                IsBlocked = "1";
            }
        }

        private void chkShowPasswords_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPasswords.CheckState == CheckState.Checked)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                txtNewVerifyPassword.UseSystemPasswordChar = false;
                chkShowPasswords.Text = "Hide Password";
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
                txtNewVerifyPassword.UseSystemPasswordChar = true;
                chkShowPasswords.Text = "Show Password";
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            NewStaff staff = new NewStaff();
            DialogResult result = staff.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.RefreshStaffGrid();
            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            this.LoadCategoryPanel();
        }

        private void userGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            if (e.RowIndex != -1)
            {
                DataGridViewRow grid = userGridView.Rows[e.RowIndex];
                txtUserId.Text = grid.Cells[0].Value.ToString();
                txtFullName.Text = grid.Cells[1].Value.ToString();
                txtUserName.Text = grid.Cells[2].Value.ToString();
                cmbUserRole.SelectedItem = grid.Cells[4].Value.ToString();
                txtContact.Text = grid.Cells[5].Value.ToString();
                txtEmailAddress.Text = grid.Cells[6].Value.ToString();
                if (grid.Cells[7].Value.ToString() == "0")
                {
                    chkBlock.CheckState = CheckState.Checked;
                }
                else
                {
                    chkBlock.CheckState = CheckState.Unchecked;
                }
            }
        }

        private void btnAddNewcategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            DialogResult result = category.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.RefreshCategoryGrid();
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            CategoryDataModel category = new CategoryDataModel
            {
                Id = Convert.ToInt32(txtCategoryId.Text),
                CategoryName = txtCategoryName.Text,
                CategoryDescription = txtCategoryDescription.Text
            };
            dataAccess.SaveData("dbo.UpdateCategory", category, "POS");
            this.RefreshCategoryGrid();
        }

        private void categoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdateCategory.Enabled = true;
            btnDeleteCategory.Enabled = true;

            if (e.RowIndex != -1)
            {
                DataGridViewRow grid = categoryGridView.Rows[e.RowIndex];
                txtCategoryId.Text = grid.Cells[0].Value.ToString();
                txtCategoryName.Text = grid.Cells[1].Value.ToString();
                txtCategoryDescription.Text = grid.Cells[2].Value.ToString();
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this category?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int Id = Convert.ToInt32(txtCategoryId.Text);

                dataAccess.SaveData("dbo.DeleteCategory", new { Id = Id }, "POS");
                this.RefreshCategoryGrid();
            }
            else { return; }
        }

        private void txtSearchCategory_TextChanged(object sender, EventArgs e)
        {
            var result = categories.Where(x => x.CategoryName.Contains(txtSearchCategory.Text)).ToList();
            categoryGridView.DataSource = result;
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            this.LoadSupplierPanel();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.LoadStockPanel();
        }

        private void btnAddNewStock_Click(object sender, EventArgs e)
        {
            NewStock stock = new NewStock();
            DialogResult result = stock.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.RefreshStockGrid();
            }
        }

        private void stockGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Enabled = true;
            btnUpdateStock.Enabled = true;
            btnDeleteStock.Enabled = true;

            if (e.RowIndex != -1)
            {
                DataGridViewRow grid = stockGridView.Rows[e.RowIndex];
                txtStockId.Text = grid.Cells[0].Value.ToString();
                txtBarcode.Text = grid.Cells[1].Value.ToString();
                cmbQtyDescId.SelectedValue = grid.Cells[2].Value;
                txtQtyDesc.Text = grid.Cells[3].Value.ToString();
                txtBrandName.Text = grid.Cells[4].Value.ToString();
                txtProductName.Text = grid.Cells[5].Value.ToString();
                txtUnitPrice.Text = grid.Cells[6].Value.ToString();
                txtRetailPrice.Text = grid.Cells[7].Value.ToString();
                txtStockInHand.Text = grid.Cells[8].Value.ToString();
                cmbCategory.SelectedValue = grid.Cells[9].Value;
                cmbSupplier.SelectedValue = grid.Cells[10].Value;
                chkIsTaxable.Checked = Convert.ToBoolean(grid.Cells[11].Value);
            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            ProductDataModel product = new ProductDataModel
            {
                StockId = Convert.ToInt32(txtStockId.Text),
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
            dataAccess.SaveData("dbo.UpdateProduct", product, "POS");
            this.RefreshStockGrid();
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this product?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int StockId = Convert.ToInt32(txtStockId.Text);

                dataAccess.SaveData("dbo.DeleteProduct", new { StockId = StockId }, "POS");
                this.RefreshStockGrid();
            }
            else { return; }
        }

        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            NewSupplier supplier = new NewSupplier();
            DialogResult result = supplier.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.RefreshSupplierGrid();
            }
        }

        private void supplierGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdateSupplier.Enabled = true;
            btnDeleteSupplier.Enabled = true;

            if (e.RowIndex != -1)
            {
                DataGridViewRow grid = supplierGridView.Rows[e.RowIndex];
                txtSupplierId.Text = grid.Cells[0].Value.ToString();
                txtSupplierName.Text = grid.Cells[1].Value.ToString();
                txtSupplierAddress.Text = grid.Cells[2].Value.ToString();
                txtSupplierContact.Text = grid.Cells[3].Value.ToString();
                txtSupplierEmail.Text = grid.Cells[4].Value.ToString();
            }
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            SupplierDataModel supplier = new SupplierDataModel
            {
                Id = Convert.ToInt32(txtSupplierId.Text),
                SupplierName = txtSupplierName.Text,
                Address = txtSupplierAddress.Text,
                Contact = txtSupplierContact.Text,
                EmailAddress = txtSupplierEmail.Text
            };
            dataAccess.SaveData("dbo.UpdateSupplier", supplier, "POS");
            this.RefreshSupplierGrid();
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this supplier?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int Id = Convert.ToInt32(txtSupplierId.Text);

                dataAccess.SaveData("dbo.DeleteSupplier", new { Id = Id }, "POS");
                this.RefreshCategoryGrid();
            }
            else { return; }
        }

        private void cmbSearchStockBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchStockBy.SelectedIndex > 0) { txtProductSearch.Enabled = true; }
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            switch (cmbSearchStockBy.GetItemText(cmbSearchStockBy.SelectedItem))
            {
                case "Stock ID":
                    var IdResult = products.Where(x => x.StockId.ToString().Contains(txtProductSearch.Text)).ToList();
                    stockGridView.DataSource = IdResult;
                    break;
                case "Barcode":
                    var BarcodeResult = products.Where(x => x.Barcode.Contains(txtProductSearch.Text)).ToList();
                    stockGridView.DataSource = BarcodeResult;
                    break;
                case "Brand":
                    var BrandResult = products.Where(x => x.Brand.Contains(txtProductSearch.Text)).ToList();
                    stockGridView.DataSource = BrandResult;
                    break;
                case "Name":
                    var NameResult = products.Where(x => x.Name.Contains(txtProductSearch.Text)).ToList();
                    stockGridView.DataSource = NameResult;
                    break;
            }
            Helpers.Functions.ProcessGridColor(stockGridView, 8);
        }

        private void txtSearchSupplier_TextChanged(object sender, EventArgs e)
        {
            var result = suppliers.Where(x => x.SupplierName.Contains(txtSearchSupplier.Text)).ToList();
            supplierGridView.DataSource = result;
        }

        private void btnTerminal_Click(object sender, EventArgs e)
        {
            Terminal terminal = new Terminal(_loggedInUser);
            this.Hide();
            terminal.ShowDialog();
            this.Close();
        }

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            OrderStock order = new OrderStock();
            DialogResult result = order.ShowDialog();
        }

        private void btnViewPurchaseOrder_Click(object sender, EventArgs e)
        {
            using (PurchaseOrders purchaseorder = new PurchaseOrders(_loggedInUser))
            {
                purchaseorder.FormClosed += new FormClosedEventHandler(PurchaseOrderClosed);
                purchaseorder.ShowDialog();
            }
        }

        private void PurchaseOrderClosed(object sender, FormClosedEventArgs e)
        {
            this.RefreshStockGrid();
        }

        private void stockGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetText(stockGridView[e.ColumnIndex, e.RowIndex].Value.ToString());
        }

        //Settings Panel
        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.LoadSettingsPanel();
        }

        private void row11_Click(object sender, EventArgs e)
        {
            DialogResult result = stockColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Color resultColor = stockColorDialog.Color;
                row11.BackColor = resultColor;
                Properties.Settings.Default.ZeroToFiveBackColor = resultColor;
                Properties.Settings.Default.Save();
            }
        }

        private void row12_Click(object sender, EventArgs e)
        {
            DialogResult result = stockColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Color resultColor = stockColorDialog.Color;
                row12.BackColor = resultColor;
                Properties.Settings.Default.ZeroToFiveRowSelectionBackColor = resultColor;
                Properties.Settings.Default.Save();
            }
        }

        private void row13_Click(object sender, EventArgs e)
        {
            DialogResult result = stockColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Color resultColor = stockColorDialog.Color;
                row13.BackColor = resultColor;
                Properties.Settings.Default.ZeroToFiveRowRowSelectionForeColor = resultColor;
                Properties.Settings.Default.Save();
            }
        }

        private void row14_Click(object sender, EventArgs e)
        {
            DialogResult result = stockColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Color resultColor = stockColorDialog.Color;
                row14.BackColor = resultColor;
                Properties.Settings.Default.ZeroToFiveRowSelectionForeColor = resultColor;
                Properties.Settings.Default.Save();
            }
        }

        private void row21_Click(object sender, EventArgs e)
        {
            DialogResult result = stockColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Color resultColor = stockColorDialog.Color;
                row21.BackColor = resultColor;
                Properties.Settings.Default.FiveToTenBackColor = resultColor;
                Properties.Settings.Default.Save();
            }
        }

        private void row22_Click(object sender, EventArgs e)
        {
            DialogResult result = stockColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Color resultColor = stockColorDialog.Color;
                row22.BackColor = resultColor;
                Properties.Settings.Default.FiveToTenRowSelectionBackColor = resultColor;
                Properties.Settings.Default.Save();
            }
        }

        private void row23_Click(object sender, EventArgs e)
        {
            DialogResult result = stockColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Color resultColor = stockColorDialog.Color;
                row23.BackColor = resultColor;
                Properties.Settings.Default.FiveToTenRowRowSelectionForeColor = resultColor;
                Properties.Settings.Default.Save();
            }
        }

        private void row24_Click(object sender, EventArgs e)
        {
            DialogResult result = stockColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Color resultColor = stockColorDialog.Color;
                row24.BackColor = resultColor;
                Properties.Settings.Default.FiveToTenRowSelectionForeColor = resultColor;
                Properties.Settings.Default.Save();
            }
        }

        private void row31_Click(object sender, EventArgs e)
        {

            DialogResult result = stockColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Color resultColor = stockColorDialog.Color;
                row31.BackColor = resultColor;
                Properties.Settings.Default.TenToFifteenBackColor = resultColor;
                Properties.Settings.Default.Save();
            }
        }

        private void row32_Click(object sender, EventArgs e)
        {

            DialogResult result = stockColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Color resultColor = stockColorDialog.Color;
                row32.BackColor = resultColor;
                Properties.Settings.Default.TenToFifteenRowSelectionBackColor = resultColor;
                Properties.Settings.Default.Save();
            }
        }

        private void row33_Click(object sender, EventArgs e)
        {

            DialogResult result = stockColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Color resultColor = stockColorDialog.Color;
                row33.BackColor = resultColor;
                Properties.Settings.Default.TenToFifteenRowRowSelectionForeColor = resultColor;
                Properties.Settings.Default.Save();
            }
        }

        private void row34_Click(object sender, EventArgs e)
        {

            DialogResult result = stockColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Color resultColor = stockColorDialog.Color;
                row34.BackColor = resultColor;
                Properties.Settings.Default.TenToFifteenRowSelectionForeColor = resultColor;
                Properties.Settings.Default.Save();
            }
        }

        private void cmbTaxRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTaxRate.Text = cmbTaxRate.GetItemText(cmbTaxRate.SelectedItem);
            Properties.Settings.Default.TaxRateSelected = cmbTaxRate.SelectedIndex;
            string taxratepercent = cmbTaxRate.GetItemText(cmbTaxRate.SelectedItem);
            string[] percentremoved = taxratepercent.Split('%');
            int TaxRate = Convert.ToInt32(percentremoved[0]);
            Properties.Settings.Default.TaxRate = TaxRate;
            Properties.Settings.Default.Save();
        }

        private void btnGenerateCoupons_Click(object sender, EventArgs e)
        {
            Coupons coupons = new Coupons();
            coupons.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to want to logoff?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void Dashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control && e.KeyCode == Keys.D)
            {
                LoadDashboard();
            }
            if (e.KeyCode == Keys.Control && e.KeyCode == Keys.T)
            {
                Terminal terminal = new Terminal(_loggedInUser);
                this.Hide();
                terminal.ShowDialog();
                this.Close();
            }
        }

        private void btnSaveQr_Click(object sender, EventArgs e)
        {
            string fileName = "QRCode.png";
            string fileDirectory = Environment.CurrentDirectory + @"\UPIQRCode\";
            string oldFilePath;

            DialogResult result = saveQRDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                oldFilePath = saveQRDialog.FileName;

                if (Directory.Exists(fileDirectory))
                {
                    File.Copy(oldFilePath, fileDirectory + fileName, true);
                    Properties.Settings.Default.QRCodePath = fileDirectory + fileName;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Directory.CreateDirectory(fileDirectory);
                    File.Copy(oldFilePath, fileDirectory + fileName, true);
                    Properties.Settings.Default.QRCodePath = fileDirectory + fileName;
                    Properties.Settings.Default.Save();
                }

                lblQRWarning.BackColor = Color.SeaGreen;
                lblQRWarning.Text = "QR Code is Saved";
            }
        }
    }
}