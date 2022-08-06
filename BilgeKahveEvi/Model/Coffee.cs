using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKahveEvi
{
    public class Coffee : BaseProduct
    {
        public string Süt { get; set; }
        public string Shot { get; set; }
        public override void CalculatePrice()
        {
            switch (Name)
            {
                case "Misto":
                    UnitPrice = 4.5m;
                    break;
                case "Americano":
                    UnitPrice = 5.75m;
                    break;
                case "Bianco":
                    UnitPrice = 6m;
                    break;
                case "Cappucino":
                    UnitPrice = 7.5m;
                    break;
                case "Macchiato":
                    UnitPrice = 6.75m;
                    break;
                case "Con Panna":
                    UnitPrice = 8m;
                    break;
                case "Mocha":
                    UnitPrice = 7.75m;
                    break;
                default:
                    break;
            }
            Price = (Count * UnitPrice) * (decimal)Size;
        }
        public override string ToString()
        {
            return $"{Name}, {Count}, {Price}";
        }
    }
}
