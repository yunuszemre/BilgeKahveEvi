using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKahveEvi
{
    public abstract class BaseProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public double Size { get; set; }
        
        public decimal UnitPrice { get; set; }
        public int Count { get; set; }

        public abstract void CalculatePrice();
        public override string ToString()
        {
            return $"{Name} {Price} {Size}";
        }
        

    }
}
