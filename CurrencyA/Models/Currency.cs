using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyA.Models
{
    public class Currency
    {
        public string Base { get; set; }
        public string Date { get; set; }
        public Rates Rates { get; set; }
    }
}
