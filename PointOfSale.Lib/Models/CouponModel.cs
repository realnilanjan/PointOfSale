using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Lib.Models
{
    public class CouponModel
    {
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
