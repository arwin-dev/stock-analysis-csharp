using System;

namespace Stonks.Models
{
    /*
        aCandlestick class creates aCandlestick object that has the following information : ticker, period,
        open, high, low, close, volume and date. These values correspond to the specific company's stocks
        the user chooses. 
    */
    public class aCandlestick
    {
        public DateTime date { get; set; }
        public string ticker { get; set; }
        public string period { get; set; }
        public Decimal open { get; set; }
        public Decimal close { get; set; }
        public Decimal high { get; set; }
        public Decimal low { get; set; }
        public long volume { get; set; }

        //Creates a empty object
        public aCandlestick()
        {
            
        }

        //Constructor which accepts a array of values and then sets values into the object.
        public aCandlestick(string[] values)
        {
            if (values.Length >= 9)
            {
                try
                {
                    /*
                        values[2] and values[3] contain the date value, they are split because
                        the date is stored in the following format in the data file: Month Day, Year
                        In the dataReader class, the values in each line is parse using "," as 
                        a delimiter which splits the Month Day section and the Year section 
                        into two separate values.
                    */
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
