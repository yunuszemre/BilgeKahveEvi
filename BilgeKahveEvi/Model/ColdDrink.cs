using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKahveEvi
{
    public class ColdDrink : BaseProduct
    {
        public override void CalculatePrice()
        {
            Price = Count * UnitPrice;
        }
        public override string ToString()
        {
            return $"{Name}, {Count}, {Price}";
        }
    }
}
