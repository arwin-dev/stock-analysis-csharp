using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stonks.Models
{
    internal class aCandlestick
    {
        public Decimal open { get; set; }
        public Decimal high { get; set; }
        public Decimal low { get; set; }
        public Decimal close { get; set; }
        public long volume { get; set; }

        public DateTime date { get; set; }

        public aCandlestick()
        {
            
        }

        public aCandlestick(string[] values)
        {
            
        }
    }
}
