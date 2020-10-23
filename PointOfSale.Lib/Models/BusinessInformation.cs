using System.Collections.Generic;

namespace PointOfSale.Lib.Models
{
    public class BusinessInformation
    {
        public string BusinessName { get; set; }
        public string GSTNumber { get; set; }
        public string BusinessType { get; set; }
        public string BusinsessAddress { get; set; }
        public string BusinessContact { get; set; }
        public string BusinessEmail { get; set; }

        public static List<BusinessInformation> BusinessInfo;
    }
}
