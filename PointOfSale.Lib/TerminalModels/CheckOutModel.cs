using System;

namespace PointOfSale.Lib.TerminalModels
{
    public class CheckOutModel
    {
        public int SaleId { get; set; }
        public int CashierId { get; set; }
        public decimal TotalAmount { get; set; }
        public string CardDigits { get; set; }
        public string CardType { get; set; }
        public DateTime DateCreated { get; set; }
    }
}