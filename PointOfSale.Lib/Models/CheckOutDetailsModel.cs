namespace PointOfSale.Lib.Models
{
    public class CheckOutDetailsModel
    {
        public int CashierId { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal SubTotal { get; set; }
        public int CouponId { get; set; }
        public decimal SaleTaxRate { get; set; }
        public decimal ShippingRate { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
