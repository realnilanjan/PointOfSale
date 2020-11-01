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

        private decimal DeliveryRate { get { return Properties.Settings.Default.DeliveryRate; } }
        private decimal GetTaxRate { get { return TaxRate / 100; } }
        List<CartItemModel> Cart = new List<CartItemModel>();
        ProductForCartModel ProductInCart { get; set; }
        CouponDataModel couponData { get; set; }

        private decimal TaxRate = Properties.Settings.Default.TaxRate;
        private LoggedInUserModel _loggedInUser;
        private bool WillBeDelivered = false;
        private decimal DiscountApplied = 0;
        private bool IsCouponAdded = false;
        private int SaleId;
        
        private string CartInvoiceNumber { get; set; }
        private decimal CartSaleTaxRate { get; set; }
        private decimal CartSubTotal { get; set; }
        private decimal ShippingRate { get; set; }
        private decimal GrandTotal { get; set; }
        private int CashierId { get; set; }
        private int CouponId { get; set; }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
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

            var stockInfo = from s in Cart group s by s.StockId into g 
                            select new 
                            { 
                                Key = g.Key,
                                Quantity = g.Sum(x => x.Quantity),
                                SubTotal = g.Sum(x => x.RetailPrice * x.Quantity),
                                TotalTax = g.Sum(x => x.Tax)
                            };

            var total = from s in stockInfo
                        group s by s.Key into g
                        select new
                        {
                            Quantity = g.Sum(x => x.Quantity),
                            SubTotal = g.Sum(x => x.SubTotal),
                            TotalTax = g.Sum(x => x.TotalTax),
                            Total = g.Sum(x => x.SubTotal + x.TotalTax)
                        };

            Quantity = total.Sum(x => x.Quantity);
            SubTotal = total.Sum(x => x.SubTotal);
            TotalTax = total.Sum(x => x.TotalTax);
            Total = total.Sum(x => x.Total);

            txtTotalItems.Text = Quantity.ToString();
            txtSubTotal.Text = SubTotal.ToString("N2");
            txtTax.Text = TotalTax.ToString("N2");
            GrandTotal = Total;
            txtTotal.Text = GrandTotal.ToString("N2");

            if (IsCouponAdded == true)
            {
                GrandTotal -= DiscountApplied;
                txtTotal.Text = GrandTotal.ToString("N2");
            }

            if (WillBeDelivered == true)
            {
                GrandTotal += ShippingRate;
                txtTotal.Text = GrandTotal.ToString("N2");
            }

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
            var config = new MapperConfiguration
                (cfg => 
                { 
                    cfg.CreateMap<ProductForCartModel, CartItemModel>(); 
                });

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

                                var newQuantity = Cart.FirstOrDefault(d => d.StockId == ProductInCart.StockId);
                                if (newQuantity != null) { newQuantity.Quantity = quantity; }
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
                            Cart.Add(destination);
                            gridCart.DataSource = null;
                            gridCart.DataSource = Cart;
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
                        Cart.Add(destination);
                        gridCart.DataSource = null;
                        gridCart.DataSource = Cart;
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
                WillBeDelivered = true;
                ShippingRate = DeliveryRate;
                lblDelivery.ForeColor = Color.White;
                lblDeliveryRupee.ForeColor = Color.White;
                txtDelivery.ForeColor = Color.White;
                GrandTotal += ShippingRate;
                txtDelivery.Text = ShippingRate.ToString("N2");
                txtTotal.Text = GrandTotal.ToString("N2");
                this.CalculateTotal();
            }
            else
            {
                ShippingRate = 0;
                WillBeDelivered = false;
                lblDelivery.ForeColor = Color.Gray;
                lblDeliveryRupee.ForeColor = Color.Gray;
                txtDelivery.ForeColor = Color.Gray;
                GrandTotal -= ShippingRate;
                txtDelivery.Text = ShippingRate.ToString("N2");
                txtTotal.Text = GrandTotal.ToString("N2");
                this.CalculateTotal();
            }
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
                            Cart.Remove(Cart.Single(x => x.StockId == Id));
                        }
                    }
                    if (Cart.Count > 0)
                    {
                        gridCart.DataSource = null;
                        gridCart.DataSource = Cart;
                        this.CalculateTotal();
                    }
                    else
                    {
                        gridCart.DataSource = null;
                        this.CalculateTotal();
                    }
                }
                else { return; }
            }
        }

        private void controlTimer_Tick(object sender, EventArgs e)
        {
            if (Cart.Count > 0) { btnClear.Enabled = true; btnCheckout.Enabled = true;  } else { btnClear.Enabled = false; btnCheckout.Enabled = false; }
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
            else { return; }
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
            DiscountApplied = 0;
            txtDiscount.Text = DiscountApplied.ToString("N2");
            txtCouponCode.Clear();
            btnRemoveCoupon.Enabled = false;
            txtDelivery.Text = ShippingRate.ToString("N2");
            Cart.Clear();
            gridCart.DataSource = null;
            CartInvoiceNumber = Generate.InvoiceNumber;
            txtInvoiceNumber.Text = CartInvoiceNumber;
            chkDelivery.Checked = false;
            ShippingRate = 0;
            GrandTotal = 0;
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
            ProcessCheckout checkout = new ProcessCheckout(SaleId, CashierId, GrandTotal);
            DialogResult result = checkout.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.CheckOut();
                CheckOutModel checkOut = new CheckOutModel
                {
                    SaleId = CheckOutDataModel.SaleId,
                    CashierId = CashierId,
                    TotalAmount = GrandTotal,
                    CardDigits = CheckOutDataModel.CardDigits,
                    CardType = CheckOutDataModel.CardType,
                    DateCreated = DateTime.UtcNow.AddHours(5.5)
                };

                dataAccess.SaveData("dbo.SaveTransaction", checkOut, "POS");
                this.VoidTransaction(); 
            }
        }

        private void CheckOut()
        {
            List<SaleDetailModel> detail = new List<SaleDetailModel>();
            if (IsCouponAdded == true)
            {
                SaleModel checkOut = new SaleModel
                {
                    CashierId = CashierId,
                    InvoiceNumber = CartInvoiceNumber,
                    SubTotal = CartSubTotal,
                    CouponId = CouponId,
                    SaleTaxRate = CartSaleTaxRate,
                    ShippingRate = ShippingRate,
                    GrandTotal = GrandTotal
                };
                SaleId = dataAccess.SaveSale("dbo.SaveSale", checkOut, "POS");
                dataAccess.SaveData("dbo.SetCouponApplied", new { Id = checkOut.CouponId }, "POS");
            }
            else
            {
                SaleModel checkOut = new SaleModel
                {
                    CashierId = CashierId,
                    InvoiceNumber = CartInvoiceNumber,
                    SubTotal = CartSubTotal,
                    CouponId = 0,
                    SaleTaxRate = CartSaleTaxRate,
                    ShippingRate = ShippingRate,
                    GrandTotal = GrandTotal
                };
                SaleId = dataAccess.SaveSale("dbo.SaveSale", checkOut, "POS");
            }

            foreach (var item in Cart)
            {
                detail.Add(new SaleDetailModel
                {
                    SaleId = SaleId,
                    ProductId = item.StockId,
                    PurchasePrice = item.RetailPrice,
                    Quantity = item.Quantity,
                    Tax = item.Tax
                });
            }

            foreach (var item in detail)
            {
                dataAccess.SaveData("dbo.SaveSaleDetails", item, "POS");
                dataAccess.SaveData("dbo.UpdateSoldProduct", new { ProductId = item.ProductId, Quantity = item.Quantity }, "POS");
            }
            CheckOutDataModel.SaleId = SaleId;
        }

        private void btnApplyCoupon_Click(object sender, EventArgs e)
        {
            IsCouponAdded = true;
            string CouponCode = txtCouponCode.Text;
            couponData = dataAccess.GetCoupon(CouponCode);
            if (couponData == null)
            {
                Messages.DisplayMessage("Coupon does not exist..", lblCouponWarning, Color.Red);
                txtCouponCode.Clear();
                txtCouponCode.Focus();
            }
            else
            {
                CouponId = couponData.Id;

                if (couponData.IsFlatRate == true)
                {
                    GrandTotal -= couponData.CouponAmount;
                    DiscountApplied = couponData.CouponAmount;
                    txtDiscount.Text = "-" + DiscountApplied.ToString("N2");
                    txtTotal.Text = GrandTotal.ToString("N2");
                }
                else if (couponData.IsFlatRate == false)
                {
                    var discounted = GrandTotal * (DiscountApplied / 100);
                    var calculateDiscount = GrandTotal - (GrandTotal * (DiscountApplied / 100));
                    DiscountApplied = calculateDiscount;
                    GrandTotal = calculateDiscount;
                    txtDiscount.Text = "-" + discounted.ToString("N2");
                    txtTotal.Text = GrandTotal.ToString("N2");
                }

                this.CalculateTotal();

                Messages.DisplayMessage("Coupon added to cart.", lblCouponWarning, Color.SeaGreen);
                txtCouponCode.Text = "APPLIED";
                txtCouponCode.Enabled = false;
                btnApplyCoupon.Enabled = false;
                btnRemoveCoupon.Enabled = true;
            }
        }

        private void btnRemoveCoupon_Click(object sender, EventArgs e)
        {
            IsCouponAdded = false;
            txtDiscount.Text = "0.00";
            GrandTotal += DiscountApplied;
            txtTotal.Text = GrandTotal.ToString("N2");
            this.CalculateTotal();
            txtCouponCode.Enabled = true;
            btnRemoveCoupon.Enabled = false;
            btnApplyCoupon.Enabled = true;
            txtCouponCode.Clear();
            txtCouponCode.Focus();
        }

        private void btnSaveDraft_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will make this transaction void. Do you want to save and continue?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string FileName = CartInvoiceNumber + "_" + DateTime.Now.ToString("d");
                Functions.SaveDrafts(gridCart, FileName);
                Messages.DisplayMessage("This transaction is saved. Please serve the next customer.", lblWarning, Color.OrangeRed);
                this.VoidTransaction();
            }
            else
            {
                return;
            }
        }
    }
}
