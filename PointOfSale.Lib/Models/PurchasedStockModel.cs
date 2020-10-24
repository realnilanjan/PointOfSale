namespace PointOfSale.Lib.Models
{
    public class PurchasedStockModel
    {
        public string Barcode { get; set; }
        public int ReceivedQty { get; set; }
        public decimal SubTotal { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
    }
}
