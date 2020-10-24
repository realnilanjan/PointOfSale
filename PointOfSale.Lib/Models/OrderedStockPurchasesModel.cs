using System;
using System.Windows.Forms;

namespace PointOfSale.Lib.Models
{
    public class OrderedStockPurchasesModel
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public int OrderQuantity { get; set; }
        public decimal OrderTotal { get; set; }
        public int Supplier { get; set; }
        public DateTime OrderDate { get; set; }
        public string Remarks { get; set; }
    }
}
