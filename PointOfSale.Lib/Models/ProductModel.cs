namespace PointOfSale.Lib.Models
{
    public class ProductModel
    {
        public string Barcode { get; set; }
        public int QtyDescId { get; set; }
        public string QtyDescription { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public int StockInHand { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public bool IsTaxable { get; set; }
    }
}
