namespace PointOfSale.Lib.Models.ReportModels
{
    public class AllSales
    {
        public int SaleId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddressLine1 { get; set; }
        public string CustomerAddressLine2 { get; set; }
        public string CustomerAddressPin { get; set; }
        public string CustomerPhone { get; set; }
    }
}
