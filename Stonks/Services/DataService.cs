using Stonks.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Stonks.Services
{
    internal class DataService
    {
        public static List<aCandlestick> GetCsvDataAsCandleSticks(string filename)
        {
            List<aCandlestick> aCandlesticks = new List<aCandlestick>();

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
                            aCandlestick aCandlestick = new aCandlestick(values);
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
            aCandlesticks.Reverse();
            return aCandlesticks;
        }
    }
}
