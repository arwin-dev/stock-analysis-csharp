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

        /*
            The button_load_Click function allows users to load data from their chosen 
            file upon clicking. 
        */
        private void button_load_Click(object sender, EventArgs e)
        {

            if( openFileDialog_getStockFile.ShowDialog() == DialogResult.OK ) 
            {
                stockData = DataService.GetCsvDataAsCandleSticks(openFileDialog_getStockFile.FileName);

                if (stockData == null || stockData.Count == 0)
                {
                    MessageBox.Show("Invalid Date Range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                button_refresh.Visible = true;
                refreshGrid();

                dataGridView_stock.Columns[1].Visible = false;
                dataGridView_stock.Columns[2].Visible = false;
            }
        }

        /*
            The refreshGrid function makes sure that dataGridView is cleared if values pre-exist. 
            This function also makes sure that only the candlesticks within the chose timeframe
            is displayed. Additionally, it also binds the data with both the dataGridView and the chart.
        */
        public void refreshGrid()
        {
            if( candlesticks != null ) candlesticks.Clear();
            if(stockData == null ) return;
            var tempdata = stockData.Where(x => x.date >= dateTimePicker_begin.Value && x.date <= dateTimePicker_end.Value).ToList();

            if(tempdata == null || tempdata.Count == 0 ) 
            {
                MessageBox.Show("Invalid Date Range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            candlesticks = new BindingList<aCandlestick>();
            foreach (aCandlestick cs in tempdata)
            {
                candlesticks.Add(cs);
            }
            dataGridView_stock.DataSource = candlesticks;
            chart_data.DataSource = candlesticks;
            chart_data.DataBind();

            var data = stockData.FirstOrDefault();
            var period = data.period.ToLower() == "day" ? "Daily" : data.period.ToString() + "ly";
            label_ticker.Text = data.ticker;
            label_period.Text = period;
            var change = Math.Round(candlesticks.Last().close - candlesticks.First().close, 2);
            label_priceChange.ForeColor = change < 0 ? Color.Red : Color.Green;

            label_priceChange.Text = change > 0 ? change.ToString() + "$ ↑" : change.ToString() + "$ ↓";
        }

        /*
            When the user clicks on the Reload Button, all the data displayed on the dataGridView 
            and the chart is reloaded.
        */
        private void button_refresh_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }

    }
}
