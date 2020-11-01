using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Lib.TerminalModels
{
    public class CheckOutDataModel
    {
        public int SaleId { get; set; }
        public int CashierId { get; set; }
        public decimal TotalAmount { get; set; }
        public int CardDigits { get; set; }
        public string CardType { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow.AddHours(5.5);
    }
}
