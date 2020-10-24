using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Lib.DataModel
{
    public class PurchaseOrdersDataModel
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public int OrderQuantity { get; set; }
        public decimal OrderTotal { get; set; }
        public int Supplier { get; set; }
        public string Remarks { get; set; }
    }
}
