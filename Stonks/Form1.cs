using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Stonks.Models;
using Stonks.Services;
using System.ComponentModel;
using System.Windows.Controls.Primitives;
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

        private void button_load_Click(object sender, EventArgs e)
        {

            if( openFileDialog_getStockFile.ShowDialog() == DialogResult.OK ) 
            {
                stockData = DataService.GetCsvDataAsCandleSticks(openFileDialog_getStockFile.FileName);

                refreshGrid();

                dataGridView_stock.Columns[1].Visible = false;
                dataGridView_stock.Columns[2].Visible = false;

                var data = stockData.FirstOrDefault();

                label1.Text = data.ticker;
                label2.Text = data.period;
            }
        }

        public void refreshGrid()
        {
            if( candlesticks != null ) candlesticks.Clear();
            if(stockData == null ) return;
            var tempdata = stockData.Where(x => x.date >= dateTimePicker_begin.Value && x.date <= dateTimePicker_end.Value).ToList();
            candlesticks = new BindingList<aCandlestick>();
            foreach (aCandlestick cs in tempdata)
            {
                candlesticks.Add(cs);
            }
            dataGridView_stock.DataSource = candlesticks;
            chart_.DataSource = candlesticks;
            chart_.DataBind();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }
    }
}
