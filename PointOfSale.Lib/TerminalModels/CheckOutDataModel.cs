using System;
using System.Windows.Forms.VisualStyles;

namespace PointOfSale.Lib.TerminalModels
{
    public static class CheckOutDataModel
    {
        public static int CustomerId { get; set; }
        public static int SaleId { get; set; }
        public static string CardDigits { get; set; }
        public static string CardType { get; set; }
    }
}
