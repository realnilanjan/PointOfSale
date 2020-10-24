namespace PointOfSale.Lib.Models
{
    public class PurchasedStockUpdateModel
    {
        public string Barcode { get; set; }
        public int NewStockQty { get; set; }
    }
}
