namespace PointOfSale.Lib.DataModel
{
    public class ProductToStockDataModel
    {
        public string Barcode { get; set; }
        public string Name{ get; set; }
        public string Brand{ get; set; }
        public decimal StockPrice { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
    }
}
