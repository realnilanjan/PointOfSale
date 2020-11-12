using System;

namespace PointOfSale.Lib.Models.ReportModels
{
    public class AllSalesInternalModel
    {
        public int SaleId { get; set; }
        public string CashierName { get; set; }
        public string InvoiceNumber { get; set; }
        public int CustomerId { get; set; }
        public DateTime SaleDate { get; set; }
        public int CouponId { get; set; }
        public decimal SaleTaxRate { get; set; }
        public decimal ShippingRate { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
