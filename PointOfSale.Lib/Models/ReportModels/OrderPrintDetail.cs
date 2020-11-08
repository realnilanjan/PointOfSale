using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Lib.Models.ReportModels
{
    public class OrderPrintDetail
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal Tax { get; set; }
        public decimal Total
        {
            get
            {
                return (PurchasePrice * Quantity) + Tax;
            }
        }
    }
}
