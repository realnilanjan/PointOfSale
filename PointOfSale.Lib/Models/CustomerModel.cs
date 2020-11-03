using System;

namespace PointOfSale.Lib.Models
{
    public class CustomerModel
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddressLine1 { get; set; }
        public string CustomerAddressLine2 { get; set; }
        public string CustomerAddressPin { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
