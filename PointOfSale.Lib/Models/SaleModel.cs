using System;
using System.Collections.Generic;

namespace PointOfSale.Lib.Models
{
    public class SaleModel
    {
        //public List<SaleDetailModel> saleDetails { get; set; } = new List<SaleDetailModel>();
        public int CashierId { get; set; }
        public string InvoiceNumber { get; set; }
        public int CustomerId { get; set; }
        public DateTime SaleDate { get; set; } = DateTime.UtcNow.AddHours(5.5);
        public decimal SubTotal { get; set; }
        public int CouponId { get; set; }
        public decimal SaleTaxRate { get; set; }
        public decimal ShippingRate { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
