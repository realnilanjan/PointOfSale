﻿using System;

namespace PointOfSale.Lib.Models.ReportModels
{
    public class AllSalesByCustomer
    {
        public int SaleId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime SaleDate { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddressLine1 { get; set; }
        public string CustomerAddressLine2 { get; set; }
        public string CustomerAddressPin { get; set; }
        public string CustomerPhone { get; set; }
    }
}