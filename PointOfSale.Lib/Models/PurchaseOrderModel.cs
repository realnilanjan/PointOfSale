namespace PointOfSale.Lib.Models
{
    public class PurchaseOrderModel
    {
        public string Barcode { get; set; }
        public int OrderQuantity { get; set; }
        public decimal OrderTotal { get; set; }
        public int Supplier { get; set; }
        public string Remarks { get; set; }
    }
}
