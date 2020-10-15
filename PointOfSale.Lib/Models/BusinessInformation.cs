using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
