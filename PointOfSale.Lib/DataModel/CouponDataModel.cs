using System;

namespace PointOfSale.Lib.DataModel
{
    public class CouponDataModel
    {
        public int Id { get; set; }
        public string CouponCode { get; set; }
        public string CouponDescription { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsFlatRate { get; set; }
        public bool IsPercentDiscount { get; set; }
        public decimal CouponAmount { get; set; }
        public bool IsUsed { get; set; }
    }
}
