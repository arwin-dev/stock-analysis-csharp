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

        /// <summary>
        /// Constructor for the form_stockInit class.
        /// Initializes the form.
        /// </summary>
        public form_stockInit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the "Load" button click.
        /// Opens a file dialog for users to select a data file.
        /// </summary>
        private void button_load_Click(object sender, EventArgs e)
        {
            openFileDialog_getStockFile.ShowDialog();

        }

        /// <summary>
        /// Event handler for the file dialog's "FileOk" event.
        /// Retrieves data from the selected file, creates a new form_chartDisplay, and displays it.
        /// </summary>
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
