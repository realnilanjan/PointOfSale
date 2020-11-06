using System;

namespace PointOfSaleUI.Helpers.ReportsQueries
{
    public static class Queries
    {
        public static string GetAllSalesByDateAndCustomer(DateTime fromDate, DateTime toDate)
        {
            return "SELECT s.SaleId, s.InvoiceNumber, s.SaleDate, c.CustomerId, c.CustomerName, c.CustomerAddressLine1, c.CustomerAddressLine2, c.CustomerAddressPin, c.CustomerEmail, c.CustomerPhone" +
                   " FROM Sale s INNER JOIN Customer c ON s.CustomerId = c.CustomerId" + 
                   $" WHERE s.SaleDate BETWEEN '{ fromDate.ToString("yyyy-MM-dd hh:mm:ss") }' AND '{ toDate.ToString("yyyy-MM-dd hh:mm:ss") }'";
        }

        public static string GetAllSalesByDate(DateTime fromDate, DateTime toDate)
        {
            return "SELECT [SaleId], [CashierId], [InvoiceNumber], [CustomerId], [SaleDate], [SubTotal], [CouponId], [SaleTaxRate], [ShippingRate], [GrandTotal]" +
                   " FROM Sale" +
                   $" WHERE SaleDate BETWEEN '{ fromDate.ToString("yyyy-MM-dd hh:mm:ss") }' AND '{ toDate.ToString("yyyy-MM-dd hh:mm:ss") }'";
        }

        public static string PrintQuery(DateTime fromDate, DateTime toDate)
        {
            return "";
        }
    }
}
