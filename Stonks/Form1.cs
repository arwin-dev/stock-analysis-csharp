using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Stonks.Models;
using Stonks.Services;
using System.ComponentModel;
using System.Windows.Controls.Primitives;

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

        private void button1_Click(object sender, EventArgs e)
        {

            if( openFileDialog1.ShowDialog() == DialogResult.OK ) 
            {
                stockData = DataService.GetCsvDataAsCandleSticks(openFileDialog1.FileName);

                refreshGrid();

                dataGridView_stock.Columns[1].Visible = false;
                dataGridView_stock.Columns[2].Visible = false;

                var data = stockData.FirstOrDefault();

                label1.Text = data.ticker;
                label2.Text = data.period;
            }
        }

        private void dateTimePicker_begin_ValueChanged(object sender, EventArgs e)
        {
            refreshGrid();
        }

        public void refreshGrid()
        {
            if( candlesticks != null ) candlesticks.Clear();
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
    }
}
