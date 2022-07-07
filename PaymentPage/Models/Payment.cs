using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentPage.Models
{
    public class Payment
    {
        public int Card { get; set; }
        public int Exp { get; set; }
        public int CVV { get; set; }
        public string Holder { get; set; }
    }
}
