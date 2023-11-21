using System;

namespace Stonks.Models
{
    /// <summary>
    /// The aCandlestick class represents a candlestick object that contains information
    /// about a specific company's stock for a given date and time period.
    /// </summary>
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

        /// <summary>
        /// Constructor that accepts an array of values and initializes the object's properties.
        /// </summary>
        /// <param name="values">An array of values containing stock data</param>
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
