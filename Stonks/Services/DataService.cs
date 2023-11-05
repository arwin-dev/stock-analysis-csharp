using Stonks.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Stonks.Services
{
    internal class DataService
    {
        /*
            The class dataReader reads data from chosen file and parses the data to be stored inside 
            a string list values depending on delimiters. 
            Next, a candlestick object using aCandlestick class is created and the values list is passed as an argument for every line
            in the data file. 
         */
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
            aCandlesticks.Reverse(); // this is done to make the data appear in DESC
            return aCandlesticks;
        }
    }
}
