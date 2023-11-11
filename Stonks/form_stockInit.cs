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
    public partial class form_stockInit : Form
    {
        private BindingList<aCandlestick> candlesticks {  get; set; }

        public form_stockInit()
        {
            InitializeComponent();
        }

        /*
            The button_load_Click function allows users to load data from their chosen 
            file upon clicking. 
        */
        private void button_load_Click(object sender, EventArgs e)
        {
            openFileDialog_getStockFile.ShowDialog();

        }

        private void openFileDialog_getStockFile_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string file in openFileDialog_getStockFile.FileNames)
            {
                List<smartCandlestick> data = DataService.GetCsvDataAsCandleSticks(file);

                form_chartDisplay newChart = new form_chartDisplay(data, dateTimePicker_begin.Value, dateTimePicker_end.Value);
                newChart.Show();
            }
        }
        
    }
}
