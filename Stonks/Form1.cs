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

namespace Stonks
{
    public partial class Form1 : Form
    {
        private CartesianChart cartesianChart;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if( openFileDialog1.ShowDialog() == DialogResult.OK ) 
            {
                List<aCandlestick> stockData = new List<aCandlestick>();
                stockData = DataService.GetCsvDataAsCandleSticks(openFileDialog1.FileName);
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                dataGridView1.DataSource = stockData;

                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;

                var data = stockData.FirstOrDefault();

                label1.Text = data.ticker;
                label2.Text = data.period;

                var chartService = new ChartService(stockData);

                cartesianChart = new CartesianChart
                {
                    Series = chartService.Series,
                    XAxes = chartService.XAxes,
                    Size = new System.Drawing.Size(800, 600),
                    Location = new System.Drawing.Point(0, 0),
                    Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
                };

                Controls.Add(cartesianChart);
                cartesianChart.BringToFront();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
