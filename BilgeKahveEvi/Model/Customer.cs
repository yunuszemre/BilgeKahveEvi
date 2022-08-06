using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKahveEvi
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public override string ToString()
        {
            return $"Müşteri Adı{CustomerName} Telefon: {Phone}, Adres: {Adress}";
        }
    }
}
