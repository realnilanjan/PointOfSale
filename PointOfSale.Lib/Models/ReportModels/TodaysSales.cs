namespace PointOfSale.Lib.Models.ReportModels
{
    public class TodaysSales
    {
        public decimal TotalSubtotal { get; set; }
        public decimal TotalTax { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
