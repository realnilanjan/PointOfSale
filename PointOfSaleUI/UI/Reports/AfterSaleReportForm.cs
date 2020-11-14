using Microsoft.Reporting.WinForms;
using PointOfSale.Lib.Models;
using PointOfSale.Lib.Models.ReportModels;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PointOfSaleUI.UI.Reports
{
    public partial class AfterSaleReportForm : Form
    {
        private readonly OrderDetailModel _orderDetail;
        private readonly List<OrderPrintDetail> _orderPrintDetail;

        public AfterSaleReportForm(List<BusinessInformation> businessInformation, OrderDetailModel orderDetail, List<OrderPrintDetail> orderPrintDetail)
        {
            InitializeComponent();
            this._orderDetail = orderDetail;
            this._orderPrintDetail = orderPrintDetail;
            OrderPrintDetailBindingSource.DataSource = _orderPrintDetail;
            if (orderDetail.CouponCode == null)
            {
                ReportParameter[] parameter = new ReportParameter[]
                {
                    new ReportParameter("pInvoiceNumber", orderDetail.InvoiceNumber),
                    new ReportParameter("pCustomerName", orderDetail.CustomerName),
                    new ReportParameter("pCouponCode", "None"),
                    new ReportParameter("pCustomerAddressLine1", orderDetail.CustomerAddressLine1),
                    new ReportParameter("pCustomerAddressLine2", orderDetail.CustomerAddressLine2),
                    new ReportParameter("pCustomerAddressPin", orderDetail.CustomerAddressPin),
                    new ReportParameter("pCustomerEmail", orderDetail.CustomerEmail),
                    new ReportParameter("pCustomerPhone", orderDetail.CustomerPhone),
                    new ReportParameter("pDiscountApplied", "₹" + orderDetail.DiscountApplied.ToString("N2")),
                    new ReportParameter("pSaleDate", orderDetail.SaleDate.ToString("F")),
                    new ReportParameter("pDeliveryRate", "₹" + orderDetail.ShippingRate.ToString("N2")),
                    new ReportParameter("pCashierName", orderDetail.Fullname),
                    new ReportParameter("pGrandTotal", "₹" + orderDetail.GrandTotal.ToString("N2")),
                    new ReportParameter("pTransactionMode", orderDetail.Mode),
                    new ReportParameter("pBusinessName", businessInformation[0].BusinessName),
                    new ReportParameter("pBusinessGSTIN", businessInformation[0].GSTNumber),
                    new ReportParameter("pBusinessAddress", businessInformation[0].BusinsessAddress),
                    new ReportParameter("pBusinessEmail", businessInformation[0].BusinessEmail),
                    new ReportParameter("pBusinessContact", businessInformation[0].BusinessContact),
                };
                this.reportViewer.LocalReport.SetParameters(parameter);
                this.reportViewer.RefreshReport();
            }
            else
            {
                ReportParameter[] parameter = new ReportParameter[]
                {
                    new ReportParameter("pInvoiceNumber", orderDetail.InvoiceNumber),
                    new ReportParameter("pCustomerName", orderDetail.CustomerName),
                    new ReportParameter("pCouponCode", orderDetail.CouponCode),
                    new ReportParameter("pCustomerAddressLine1", orderDetail.CustomerAddressLine1),
                    new ReportParameter("pCustomerAddressLine2", orderDetail.CustomerAddressLine2),
                    new ReportParameter("pCustomerAddressPin", orderDetail.CustomerAddressPin),
                    new ReportParameter("pCustomerEmail", orderDetail.CustomerEmail),
                    new ReportParameter("pCustomerPhone", orderDetail.CustomerPhone),
                    new ReportParameter("pDiscountApplied", "₹" + orderDetail.DiscountApplied.ToString("N2")),
                    new ReportParameter("pSaleDate", orderDetail.SaleDate.ToString("F")),
                    new ReportParameter("pCashierName", orderDetail.Fullname),
                    new ReportParameter("pDeliveryRate", "₹" + orderDetail.ShippingRate.ToString("N2")),
                    new ReportParameter("pGrandTotal", "₹" + orderDetail.GrandTotal.ToString("N2")),
                    new ReportParameter("pTransactionMode", orderDetail.Mode),
                    new ReportParameter("pBusinessName", businessInformation[0].BusinessName),
                    new ReportParameter("pBusinessGSTIN", businessInformation[0].GSTNumber),
                    new ReportParameter("pBusinessAddress", businessInformation[0].BusinsessAddress),
                    new ReportParameter("pBusinessEmail", businessInformation[0].BusinessEmail),
                    new ReportParameter("pBusinessContact", businessInformation[0].BusinessContact),
                };
                this.reportViewer.LocalReport.SetParameters(parameter);
                this.reportViewer.RefreshReport();
            }
        }
    }
}