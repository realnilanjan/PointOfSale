using System;

namespace PointOfSale.Lib.Models.ReportModels
{
    public class OrderDetailModel
    {
        public string InvoiceNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddressLine1 { get; set; }
        public string CustomerAddressLine2 { get; set; }
        public string CustomerAddressPin { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public decimal DiscountApplied { get; set; }
        public decimal ShippingRate { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
