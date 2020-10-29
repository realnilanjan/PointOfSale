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
    public partial class Coupons : Form
    {
        SQLDataAccess dataAccess = new SQLDataAccess();
        List<CouponDataModel> coupons = new List<CouponDataModel>();

        public Coupons()
        {
            InitializeComponent();
            singleStartDate.Value = DateTime.Today;
            bulkStartDate.Value = DateTime.Today;
            singleExpiryDate.Value = singleExpiryDate.Value.AddDays(10);
            bulkExpiryDate.Value = bulkExpiryDate.Value.AddDays(10);
            txtCouponCode.Text = Generate.CouponCode;

            this.RefreshCouponsGrid();
        }

        private void RefreshCouponsGrid()
        {
            coupons = dataAccess.GetAllCoupons();
            couponGridView.DataSource = coupons;

            if (coupons.Count > 0)
            {
                couponGridView.Visible = true;
                couponGridView.DataSource = coupons;
            }
            else
            {
                couponGridView.Visible = false;
            }
            btnDeleteCoupon.Enabled = false;
            couponGridView.ClearSelection();
        }

        private void GenerateNewCoupon()
        {
            txtCouponCode.Text = Generate.CouponCode;
        }

        private void rdoSinglePDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSinglePDiscount.Checked == true)
            {
                txtSingleFlatDiscount.Enabled = true;
                txtSinglePercentDiscount.Enabled = false;
                txtSingleFlatDiscount.Focus();
            }
        }

        private void rdoSingleDPercentage_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSingleDPercentage.Checked == true)
            {
                txtSinglePercentDiscount.Enabled = true;
                txtSingleFlatDiscount.Enabled = false;
                txtSinglePercentDiscount.Focus();
            }
        }

        private void rdoBulkPDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBulkPDiscount.Checked == true)
            {
                txtBulkFlatDiscount.Enabled = true;
                txtBulkPercentDiscount.Enabled = false;
                txtBulkFlatDiscount.Focus();
            }
        }

        private void rdoBulkDPercentage_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBulkDPercentage.Checked == true)
            {
                txtBulkPercentDiscount.Enabled = true;
                txtBulkFlatDiscount.Enabled = false;
                txtBulkPercentDiscount.Focus();
            }
        }

        private void btnSingleGenerate_Click(object sender, EventArgs e)
        {
            if (rdoSinglePDiscount.Checked == true)
            {
                CouponModel singleCoupon = new CouponModel
                {
                    CouponCode = txtCouponCode.Text,
                    CouponDescription = txtSingleDescription.Text,
                    IssueDate = singleStartDate.Value,
                    ExpiryDate = singleExpiryDate.Value,
                    IsFlatRate = rdoSinglePDiscount.Checked,
                    IsPercentDiscount = rdoSingleDPercentage.Checked,
                    CouponAmount = Convert.ToDecimal(txtSingleFlatDiscount.Text),
                    IsUsed = false
                };
                dataAccess.SaveData("dbo.InsertCoupon", singleCoupon, "POS");
            }
            else if(rdoSingleDPercentage.Checked == true)
            {
                CouponModel singleCoupon = new CouponModel
                {
                    CouponCode = txtCouponCode.Text,
                    CouponDescription = txtSingleDescription.Text,
                    IssueDate = singleStartDate.Value,
                    ExpiryDate = singleExpiryDate.Value,
                    IsFlatRate = rdoSinglePDiscount.Checked,
                    IsPercentDiscount = rdoSingleDPercentage.Checked,
                    CouponAmount = Convert.ToDecimal(txtSinglePercentDiscount.Text),
                    IsUsed = false
                };
                dataAccess.SaveData("dbo.InsertCoupon", singleCoupon, "POS");
            }

            this.GenerateNewCoupon();
            this.RefreshCouponsGrid();
        }

        private void btnGenerateCoupon_Click(object sender, EventArgs e)
        {
            this.GenerateNewCoupon();
        }

        private void btnBulkGenerate_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= numNoOfCoupons.Value; i++)
            {
                if (rdoBulkPDiscount.Checked == true)
                {
                    CouponModel bulkCoupon = new CouponModel
                    {
                        CouponCode = Generate.CouponCode,
                        CouponDescription = txtBulkDescription.Text,
                        IssueDate = singleStartDate.Value,
                        ExpiryDate = singleExpiryDate.Value,
                        IsFlatRate = rdoSinglePDiscount.Checked,
                        IsPercentDiscount = rdoSingleDPercentage.Checked,
                        CouponAmount = Convert.ToDecimal(txtBulkFlatDiscount.Text),
                        IsUsed = false
                    };
                    dataAccess.SaveData("dbo.InsertCoupon", bulkCoupon, "POS");
                }
                else if (rdoBulkDPercentage.Checked == true)
                {
                    CouponModel bulkCoupon = new CouponModel
                    {
                        CouponCode = Generate.CouponCode,
                        CouponDescription = txtBulkDescription.Text,
                        IssueDate = singleStartDate.Value,
                        ExpiryDate = singleExpiryDate.Value,
                        IsFlatRate = rdoSinglePDiscount.Checked,
                        IsPercentDiscount = rdoSingleDPercentage.Checked,
                        CouponAmount = Convert.ToDecimal(txtBulkPercentDiscount.Text),
                        IsUsed = false
                    };
                    dataAccess.SaveData("dbo.InsertCoupon", bulkCoupon, "POS");
                }

                this.RefreshCouponsGrid();
            }
        }

        private void btnDeleteCoupon_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete the selected coupon(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in couponGridView.Rows)
                {
                    if (r.Selected == true)
                    {
                        int Id = Convert.ToInt32(r.Cells[0].Value);
                        dataAccess.SaveData("dbo.DeleteCoupon", new { Id = Id }, "POS");
                    }
                }
                this.RefreshCouponsGrid();
            }
            else
            {
                return;
            }
        }

        private void couponGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteCoupon.Enabled = true;
            btnUpdateCoupon.Enabled = true;
        }

        private void singleExpiryDate_onValueChanged(object sender, EventArgs e)
        {
            singleExpiryDate.Value = singleExpiryDate.Value.Date;
        }

        private void bulkExpiryDate_onValueChanged(object sender, EventArgs e)
        {
            bulkExpiryDate.Value = bulkExpiryDate.Value.Date;
        }

        private void singleStartDate_onValueChanged(object sender, EventArgs e)
        {
            singleStartDate.Value = singleStartDate.Value.Date;
        }

        private void bulkStartDate_onValueChanged(object sender, EventArgs e)
        {
            bulkStartDate.Value = bulkStartDate.Value.Date;
        }

        private void couponGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetText(couponGridView[e.ColumnIndex, e.RowIndex].Value.ToString());
        }
    }
}
