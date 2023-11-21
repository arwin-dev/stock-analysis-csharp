using Stonks.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Stonks.Services
{
    internal class DataService
    {
        /// <summary>
        /// Reads data from a CSV file, parses it, and creates a list of smartCandlestick objects.
        /// The order of the data is reversed to make it appear in descending order.
        /// </summary>
        /// <param name="filename">The filename of the CSV file to read</param>
        /// <returns>A list of smartCandlestick objects</returns>
        public static List<smartCandlestick> GetCsvDataAsCandleSticks(string filename)
        {
            List<smartCandlestick> aCandlesticks = new List<smartCandlestick>();

            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    string header = sr.ReadLine();

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] values = line.Split(',');

                        if (values.Length >= 9)
                        {
                            smartCandlestick aCandlestick = new smartCandlestick(values);
                            aCandlesticks.Add(aCandlestick); 
                        }
                        else
                        {
                            MessageBox.Show("Invalid data in CSV file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            aCandlesticks.Reverse(); // this is done to make the data appear in DESC
            return aCandlesticks;
        }
    }
}
