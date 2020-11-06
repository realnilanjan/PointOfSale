using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Lib.Models.ReportModels
{
    public class OrderDetail
    {
        public string InvoiceNumber{ get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public decimal Total
        {
            get 
            {
                return Quantity * Price - Quantity * Price - Discount;
            }
        }
    }
}
