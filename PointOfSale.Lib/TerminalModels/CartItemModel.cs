namespace PointOfSale.Lib.TerminalModels
{
    public class CartItemModel
    {
        public int StockId { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal Tax { get; set; }
        public decimal SubTotal
        {
            get 
            {
                if (Tax == 0)
                {
                    return RetailPrice * Quantity;
                }
                else
                {
                    return (RetailPrice * Quantity) + Tax;
                }
            }
        }
    }
}
