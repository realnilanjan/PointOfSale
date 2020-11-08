using Microsoft.Reporting.WinForms;
using PointOfSale.Lib.Models.ReportModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleUI.UI.Reports
{
    public partial class AfterSaleReportForm : Form
    {
        private readonly OrderDetailModel _orderDetail;
        private readonly List<OrderPrintDetail> _orderPrintDetail;

        public AfterSaleReportForm(OrderDetailModel orderDetail, List<OrderPrintDetail> orderPrintDetail)
        {
            InitializeComponent();
            this._orderDetail = orderDetail;
            this._orderPrintDetail = orderPrintDetail;
            OrderPrintDetailBindingSource.DataSource = _orderPrintDetail;
            ReportParameter[] parameter = new ReportParameter[]
            {
                new ReportParameter("pInvoiceNumber", orderDetail.InvoiceNumber),
                new ReportParameter("pCustomerName", orderDetail.CustomerName),
                new ReportParameter("pCustomerAddressLine1", orderDetail.CustomerAddressLine1),
                new ReportParameter("pCustomerAddressLine2", orderDetail.CustomerAddressLine2),
                new ReportParameter("pCustomerAddressPin", orderDetail.CustomerAddressPin),
                new ReportParameter("pCustomerEmail", orderDetail.CustomerEmail),
                new ReportParameter("pCustomerPhone", orderDetail.CustomerPhone),
                new ReportParameter("pDiscountApplied", orderDetail.DiscountApplied.ToString("N2")),
                new ReportParameter("pSaleDate", orderDetail.SaleDate.ToString("F")),
                new ReportParameter("pDeliveryRate", orderDetail.ShippingRate.ToString("N2")),
            };
            this.reportViewer.LocalReport.SetParameters(parameter);
            this.reportViewer.RefreshReport();
        }
    }
}
