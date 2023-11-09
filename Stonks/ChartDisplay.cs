using Stonks.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Stonks
{
    public partial class ChartDisplay : Form
    {
        List<smartCandlestick> stockData = null;
        private BindingList<smartCandlestick> candlesticks { get; set; }
        public ChartDisplay(List<smartCandlestick> data, DateTime begin, DateTime end)
        {
            InitializeComponent();

            stockData = data;
            dateTimePicker_begin.Value = begin;
            dateTimePicker_end.Value = end;

            var tempdata = stockData.Where(x => x.date >= dateTimePicker_begin.Value && x.date <= dateTimePicker_end.Value).ToList();

            if (tempdata == null || tempdata.Count == 0)
            {
                MessageBox.Show("Invalid Date Range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var TempData = stockData.FirstOrDefault();
            var period = TempData.period.ToLower() == "day" ? "Daily" : TempData.period.ToString() + "ly";
            

            label_ticker.Text = tempdata[0].ticker;
            label_period.Text = period;
            refreshGrid();
        }

        public void refreshGrid()
        {
            if (candlesticks != null) candlesticks.Clear();
            if (stockData == null) return;
            var tempdata = stockData.Where(x => x.date >= dateTimePicker_begin.Value && x.date <= dateTimePicker_end.Value).ToList();

            if (tempdata == null || tempdata.Count == 0)
            {
                MessageBox.Show("Invalid Date Range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            candlesticks = new BindingList<smartCandlestick>();
            foreach (smartCandlestick cs in tempdata)
            {
                candlesticks.Add(cs);
            }

            chart_data.DataSource = candlesticks;
            chart_data.DataBind();

            var data = stockData.FirstOrDefault();
            

            var change = Math.Round(candlesticks.Last().close - candlesticks.First().close, 2);
            label_priceChange.ForeColor = change < 0 ? Color.Red : Color.Green;

            label_priceChange.Text = change > 0 ? change.ToString() + "$ ↑" : change.ToString() + "$ ↓";
        }

        private void button_refreshBtn_MouseClick(object sender, MouseEventArgs e)
        {
            refreshGrid();
        }
    }
}
