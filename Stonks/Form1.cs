using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Stonks.Models;
using Stonks.Services;
using System.ComponentModel;
using System.Drawing;

namespace Stonks
{
    public partial class Form1 : Form
    {
        List<aCandlestick> stockData = null;
        private BindingList<aCandlestick> candlesticks {  get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        // Get the Data as list of acandleStick objects and Calls the refreshGrid funtion on OnClick event
        private void button_load_Click(object sender, EventArgs e)
        {
            openFileDialog_getStockFile.ShowDialog();

        }

        private void openFileDialog_getStockFile_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string file in openFileDialog_getStockFile.FileNames)
            {
                List<smartCandlestick> data = DataService.GetCsvDataAsCandleSticks(file);

                ChartDisplay newChart = new ChartDisplay(data, dateTimePicker_begin.Value, dateTimePicker_end.Value);
                newChart.Show();
            }
        }
        
    }
}
