namespace PointOfSale.Lib.TerminalModels
{
    public class ProductForCartModel
    {
        public int StockId { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public decimal RetailPrice { get; set; }
        public bool IsTaxable { get; set; }
    }
}
