using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Lib.Models.ReportModels
{
    public class AllSalesModel
    {
        public int SaleId { get; set; }
        public int CashierId { get; set; }
        public string InvoiceNumber { get; set; }
        public int CustomerId { get; set; }
        public DateTime SaleDate { get; set; }
        public int CouponId { get; set; }
        public decimal SaleTaxRate { get; set; }
        public decimal ShippingRate { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
