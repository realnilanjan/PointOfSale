namespace PointOfSale.Lib.Models
{
    public class CheckOutDetailsModel
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Tax { get; set; }
    }
}
