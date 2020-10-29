using AutoMapper;
using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.DataModel;
using PointOfSale.Lib.Helpers;
using PointOfSale.Lib.Models;
using PointOfSale.Lib.TerminalModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace PointOfSaleUI.UI
{
    public partial class Terminal : Form
    {
        SQLDataAccess dataAccess = new SQLDataAccess();
        private LoggedInUserModel _loggedInUser;
        List<CartItemModel> CartToCheckOut = new List<CartItemModel>();
        public ProductForCartModel ProductInCart { get; set; }
        private decimal TaxRate = Properties.Settings.Default.TaxRate;
        CouponDataModel couponData = new CouponDataModel();
        private bool IsCouponAdded = false;

        private string CartInvoiceNumber { get; set; }
        private int CashierId { get; set; }
        private decimal CartSubTotal { get; set; }
        private decimal CartSaleTaxRate { get; set; }
        private int CouponId { get; set; }
        private decimal ShippingRate { get; set; }
        private decimal GrandTotal { get; set; }

        private decimal DeliveryRate { get { return Properties.Settings.Default.DeliveryRate; } }
        private decimal GetTaxRate
        {
            get { return TaxRate / 100; }
        }

        public Terminal(LoggedInUserModel loggedInUser)
        {
            InitializeComponent();
            this._loggedInUser = loggedInUser;
            txtBusinessName.Text = BusinessInformation.BusinessInfo[0].BusinessName;
            txtBusinessAddress.Text = BusinessInformation.BusinessInfo[0].BusinsessAddress;
            txtBusinessContact.Text = BusinessInformation.BusinessInfo[0].BusinessContact;
            txtCashierName.Text = _loggedInUser.Fullname;
            txtUserRole.Text = _loggedInUser.UserRole;
            CashierId = _loggedInUser.UserId;
            txtBarcode.Focus();
            switch (_loggedInUser.UserRole)
            {
                case "Administrator":
                    btnAdmin.Enabled = true;
                    break;
                case "Manager":
                    btnAdmin.Enabled = true;
                    break;
                case "Cashier":
                    btnAdmin.Enabled = false;
                    break;
            }
            CartInvoiceNumber = Generate.InvoiceNumber;
            txtInvoiceNumber.Text = CartInvoiceNumber;
        }

        private void CalculateTotal()
        {
            int Quantity = 0;
            decimal SubTotal = 0;
            decimal TotalTax = 0;
            decimal Total = 0;

            foreach (DataGridViewRow row in gridCart.Rows)
            {
                Quantity += Convert.ToInt32(row.Cells["Quantity"].Value);
                SubTotal += Convert.ToDecimal(row.Cells["RetailPrice"].Value) * Convert.ToInt32(row.Cells["Quantity"].Value);
                TotalTax += Convert.ToDecimal(row.Cells["Tax"].Value);
                Total = SubTotal + TotalTax;
            }
            txtTotalItems.Text = Quantity.ToString();
            txtSubTotal.Text = SubTotal.ToString("N2");
            txtTax.Text = TotalTax.ToString("N2");
            txtTotal.Text = Total.ToString("N2");
            GrandTotal = Total;
            txtBarcode.Focus();

            CartSubTotal = SubTotal;
            CartSaleTaxRate = TotalTax;

        }

        private void dateTimeTimer_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("D");
            txtTime.Text = DateTime.Now.ToString("T");
        }

        private void btnClearCode_Click(object sender, EventArgs e)
        {
            txtBarcode.Clear();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<ProductForCartModel, CartItemModel>(); });
            IMapper iMapper = config.CreateMapper();
            var source = new ProductForCartModel();
            var destination = iMapper.Map<ProductForCartModel, CartItemModel>(source);

            if (txtBarcode.Text.Length >= 10)
            {
                btnClearCode.Enabled = true;
                bool ProductAlreadyInList = false;
                string Barcode = txtBarcode.Text;
                ProductInCart = dataAccess.GetProductForCart(Barcode);

                if (ProductInCart == null)
                {
                    SystemSounds.Hand.Play();
                    Messages.DisplayMessage("The product is not found.", lblWarning, Color.Red);
                    txtBarcode.Clear();
                    txtBarcode.Focus();
                }
                else
                {
                    txtStockId.Text = ProductInCart.StockId.ToString();
                    txtProductDescription.Text = ProductInCart.Name;
                    txtUnitPrice.Text = ProductInCart.RetailPrice.ToString("N2");
                    txtUnitQuantity.Text = txtItemQuantity.Text;
                    txtTotalQtyAmount.Text = (ProductInCart.RetailPrice * Convert.ToInt32(txtUnitQuantity.Text)).ToString("N2");

                    if (gridCart.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in gridCart.Rows)
                        {
                            if (Convert.ToInt32(row.Cells[0].Value) == ProductInCart.StockId)
                            {
                                int quantity = Convert.ToInt32(row.Cells[3].Value);
                                quantity += Convert.ToInt32(txtUnitQuantity.Text);
                                row.Cells[3].Value = quantity;
                                row.Cells[6].Value = Convert.ToInt32(row.Cells[3].Value) * Convert.ToInt32(row.Cells[4].Value);
                                gridCart.Refresh();
                                ProductAlreadyInList = true;
                            }
                        }
                        if (!ProductAlreadyInList)
                        {
                            if (ProductInCart.IsTaxable == true)
                            {
                                destination = new CartItemModel
                                {
                                    StockId = ProductInCart.StockId,
                                    Barcode = ProductInCart.Barcode,
                                    Name = ProductInCart.Name,
                                    Quantity = Convert.ToInt32(txtUnitQuantity.Text),
                                    RetailPrice = ProductInCart.RetailPrice,
                                    Tax = (ProductInCart.RetailPrice * GetTaxRate)
                                };
                            }
                            else
                            {
                                destination = new CartItemModel
                                {
                                    StockId = ProductInCart.StockId,
                                    Barcode = ProductInCart.Barcode,
                                    Name = ProductInCart.Name,
                                    Quantity = Convert.ToInt32(txtUnitQuantity.Text),
                                    RetailPrice = ProductInCart.RetailPrice,
                                    Tax = 0
                                };
                            }
                            CartToCheckOut.Add(destination);
                            gridCart.DataSource = null;
                            gridCart.DataSource = CartToCheckOut;
                            gridCart.Refresh();
                        }

                    }
                    else
                    {
                        if (ProductInCart.IsTaxable == true)
                        {
                            destination = new CartItemModel
                            {
                                StockId = ProductInCart.StockId,
                                Barcode = ProductInCart.Barcode,
                                Name = ProductInCart.Name,
                                Quantity = Convert.ToInt32(txtUnitQuantity.Text),
                                RetailPrice = ProductInCart.RetailPrice,
                                Tax = (ProductInCart.RetailPrice * GetTaxRate)
                            };
                        }
                        else
                        {
                            destination = new CartItemModel
                            {
                                StockId = ProductInCart.StockId,
                                Barcode = ProductInCart.Barcode,
                                Name = ProductInCart.Name,
                                Quantity = Convert.ToInt32(txtUnitQuantity.Text),
                                RetailPrice = ProductInCart.RetailPrice,
                                Tax = 0
                            };
                        }
                        CartToCheckOut.Add(destination);
                        gridCart.DataSource = null;
                        gridCart.DataSource = CartToCheckOut;
                        gridCart.Refresh();
                    }
                    this.CalculateTotal();
                    SystemSounds.Asterisk.Play();
                    Messages.DisplayMessage("The product is added in the cart.", lblWarning, Color.SeaGreen);
                    txtBarcode.Clear();
                    txtItemQuantity.Text = "1";
                }
            }
            else
            {
                btnClearCode.Enabled = false;
            }
        }

        private void txtCouponCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCouponCode.Text.Length == 8)
            {
                btnApplyCoupon.Enabled = true;
            }
            else
            {
                btnApplyCoupon.Enabled = false;
            }
        }

        private void chkDelivery_OnChange(object sender, EventArgs e)
        {
            if (chkDelivery.Checked == true)
            {
                lblDelivery.ForeColor = Color.White;
                lblDeliveryRupee.ForeColor = Color.White;
                txtDelivery.ForeColor = Color.White;
                txtDelivery.Text = DeliveryRate.ToString("N2");
                GrandTotal += DeliveryRate;
                ShippingRate = DeliveryRate;
                txtTotal.Text = GrandTotal.ToString("N2");
            }
            else
            {
                lblDelivery.ForeColor = Color.Gray;
                lblDeliveryRupee.ForeColor = Color.Gray;
                txtDelivery.ForeColor = Color.Gray;
                txtDelivery.Text = "0.00";
                ShippingRate = 0;
                GrandTotal -= DeliveryRate;
                txtTotal.Text = GrandTotal.ToString("N2");
            }
        }

        private void txtItemQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(_loggedInUser);
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }

        private void gridCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult result = MessageBox.Show("Do you really want to delete the selected stocks?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in gridCart.Rows)
                    {
                        if (row.Selected == true)
                        {
                            int Id = Convert.ToInt32(row.Cells[0].Value);
                            CartToCheckOut.Remove(CartToCheckOut.Single(x => x.StockId == Id));
                        }
                    }
                    if (CartToCheckOut.Count > 0)
                    {
                        gridCart.DataSource = null;
                        gridCart.DataSource = CartToCheckOut;
                        this.CalculateTotal();
                    }
                    else
                    {
                        gridCart.DataSource = null;
                        this.CalculateTotal();
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void controlTimer_Tick(object sender, EventArgs e)
        {
            if (CartToCheckOut.Count > 0)
            {
                btnClear.Enabled = true;
            }
            else
            {
                btnClear.Enabled = false;
            }
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            ProcessStartInfo pInfo = new ProcessStartInfo();
            pInfo.FileName = "calc.exe";
            Process p = Process.Start(pInfo);
            p.WaitForInputIdle();
            p.WaitForExit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to make this transaction void?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.VoidTransaction();
            }
            else
            {
                return;
            }
        }

        private void VoidTransaction()
        {
            txtBarcode.Clear();
            txtStockId.Clear();
            txtProductDescription.Clear();
            txtItemQuantity.Text = "1";
            txtUnitPrice.Clear();
            txtUnitQuantity.Clear();
            txtTotalQtyAmount.Clear();
            CartToCheckOut.Clear();
            gridCart.DataSource = null;
            CartInvoiceNumber = Generate.InvoiceNumber;
            txtInvoiceNumber.Text = CartInvoiceNumber;
            this.CalculateTotal();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to want to logoff?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.VoidTransaction();
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

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            this.CheckOut();
            this.VoidTransaction();
        }

        private void CheckOut()
        {
            if (IsCouponAdded == true)
            {
                CheckOutModel checkOut = new CheckOutModel
                {
                    CashierId = CashierId,
                    InvoiceNumber = CartInvoiceNumber,
                    SubTotal = CartSubTotal,
                    CouponId = CouponId,
                    SaleTaxRate = CartSaleTaxRate,
                    ShippingRate = ShippingRate,
                    GrandTotal = GrandTotal
                };
            }
            else
            {
                CheckOutModel checkOut = new CheckOutModel
                {
                    CashierId = CashierId,
                    InvoiceNumber = CartInvoiceNumber,
                    SubTotal = CartSubTotal,
                    CouponId = 0,
                    SaleTaxRate = CartSaleTaxRate,
                    ShippingRate = ShippingRate,
                    GrandTotal = GrandTotal
                };
            }

            //Save CheckOutModel
            //Save Every sold products in CartItemModel to sale details database and remove quantities from stock

        }

        private void btnApplyCoupon_Click(object sender, EventArgs e)
        {
            string CouponCode = txtCouponCode.Text;
            couponData = dataAccess.GetCoupon(CouponCode);

            //Get Coupon Details
            if (couponData == null)
            {
                Messages.DisplayMessage("Coupon does not exist..", lblCouponWarning, Color.Red);
                txtCouponCode.Clear();
                txtCouponCode.Focus();
            }
            else
            {
                CouponId = couponData.Id;

                //TODO: Process coupon
                //Is Flat or Is Percent based on couponData
                //Add Discount to Grand Total

                IsCouponAdded = true;
                Messages.DisplayMessage("Coupon added to cart.", lblCouponWarning, Color.SeaGreen);
                txtCouponCode.Text = "Applied";
                txtCouponCode.Enabled = false;
                btnApplyCoupon.Enabled = false;
                btnRemoveCoupon.Enabled = true;
            }
        }

        private void btnRemoveCoupon_Click(object sender, EventArgs e)
        {
            IsCouponAdded = false;

            //Remove coupon discount from Grand Total
            txtCouponCode.Enabled = true;
            btnRemoveCoupon.Enabled = false;
            btnApplyCoupon.Enabled = true;
            txtCouponCode.Clear();
            txtCouponCode.Focus();
        }
    }
}
