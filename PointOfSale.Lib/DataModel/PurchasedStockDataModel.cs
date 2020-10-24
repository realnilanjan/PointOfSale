using System;

namespace PointOfSale.Lib.DataModel
{
    public class PurchasedStockDataModel
    {
        public int StockinId { get; set; }
        public string Barcode { get; set; }
        public DateTime DateReceived { get; set; }
        public int ReceivedQty { get; set; }
        public decimal SubTotal { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
    }
}
