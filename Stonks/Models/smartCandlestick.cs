using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stonks.Models
{
    public class smartCandlestick : aCandlestick
    {
        public smartCandlestick(string[] values) : base(values)
        {
            if (values.Length >= 9)
            {
                try
                {
                    ticker = values[0].Trim('"');
                    period = values[1].Trim('"');
                    open = Convert.ToDecimal(values[4]);
                    high = Convert.ToDecimal(values[5]);
                    low = Convert.ToDecimal(values[6]);
                    close = Convert.ToDecimal(values[7]);
                    volume = Convert.ToInt64(values[8]);
                    date = DateTime.Parse(values[2].Trim('"') + " " + values[3].Trim('"'));
                }
                catch (FormatException ex)
                {
                    throw new FormatException("Failed to parse candlestick values.", ex);
                }
            }
            else
            {
                throw new ArgumentException("Input values array should have at least 8 elements.");
            }
        }
    }
}
