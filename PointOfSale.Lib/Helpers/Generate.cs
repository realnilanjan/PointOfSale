using System;
using System.Linq;

namespace PointOfSale.Lib.Helpers
{
    public static class Generate
    {
        public static string InvoiceNumber
        {
            get
            {
                long ticks = DateTime.Now.Ticks;
                return "MEM-" + ticks.ToString();
            }
        }

        public static string CouponCode
        {
            get
            {
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var random = new Random();
                var result = new string(
                    Enumerable.Repeat(chars, 8)
                              .Select(s => s[random.Next(s.Length)])
                              .ToArray());
                return result;
            }
        }
    }
}