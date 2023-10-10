using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Stonks.Models;
using Stonks.Services;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using System.ComponentModel;

namespace Stonks
{
    public partial class Form1 : Form
    {
        List<aCandlestick> stockData = null;
        List<aCandlestick> templist = new List<aCandlestick>();
        private BindingList<aCandlestick> candlesticks {  get; set; }

        private CartesianChart cartesianChart;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if( openFileDialog1.ShowDialog() == DialogResult.OK ) 
            {
                stockData = DataService.GetCsvDataAsCandleSticks(openFileDialog1.FileName);

                


                stockData = stockData.Where(x => x.date >= dateTimePicker1.Value && x.date <= dateTimePicker2.Value).ToList();


                candlesticks = new BindingList<aCandlestick>();
                foreach (aCandlestick cs in stockData)
                {
                    candlesticks.Add(cs);
                }

                dataGridView_stock.DataSource = candlesticks;

                
                chart1.DataSource = candlesticks;
                chart1.DataBind();

                dataGridView_stock.Columns[1].Visible = false;
                dataGridView_stock.Columns[2].Visible = false;

                var data = stockData.FirstOrDefault();

                label1.Text = data.ticker;
                label2.Text = data.period;

                

                /*var chartService = new ChartService(stockData);

                cartesianChart = new CartesianChart
                {
                    Series = chartService.Series,
                    XAxes = chartService.XAxes,
                    Size = new System.Drawing.Size(800, 600),
                    Location = new System.Drawing.Point(0, 0),
                    Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
                };

                Controls.Add(cartesianChart);
                cartesianChart.BringToFront();*/
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
