using PointOfSale.Lib.TerminalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Lib.Models
{
    public class CheckOutModel
    {
        public int CashierId { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal SubTotal { get; set; }
        public int CouponId { get; set; }
        public decimal SaleTaxRate { get; set; }
        public decimal ShippingRate { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
