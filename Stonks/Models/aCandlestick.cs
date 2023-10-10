using System;

namespace Stonks.Models
{
    public class aCandlestick
    {
        public DateTime date { get; set; }
        public string ticker { get; set; }
        public string period { get; set; }
        public Decimal open { get; set; }
        public Decimal high { get; set; }
        public Decimal low { get; set; }
        public Decimal close { get; set; }
        public long volume { get; set; }

        public aCandlestick()
        {
            
        }

        public aCandlestick(string[] values)
        {
            if (values.Length >= 6)
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
                throw new ArgumentException("Input values array should have at least 6 elements.");
            }
        }
    }
}
