using Stonks.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Stonks
{
    public partial class form_chartDisplay : Form
    {
        List<smartCandlestick> stockData = null;
        List<smartCandlestick> tempop = null;
        private BindingList<smartCandlestick> candlesticks { get; set; }

        /// <summary>
        /// Constructor for the form.
        /// Initializes the form, sets data, begin, and end dates, and populates UI elements.
        /// </summary>
        /// <param name="data">List of smartCandlestick data</param>
        /// <param name="begin">Start date for the data</param>
        /// <param name="end">End date for the data</param>
        public form_chartDisplay(List<smartCandlestick> data, DateTime begin, DateTime end)
        {
            InitializeComponent();

            stockData = data;
            dateTimePicker_begin.Value = begin;
            dateTimePicker_end.Value = end;

            List<string> candlestickPatterns = new List<string>
            {
                "",
                "Bullish",
                "Bearish",
                "Neutral",
                "Doji",
                "Marubozu",
                "DragonFly Doji",
                "Gravestone Doji",
                "Hammer",
                "Inverted Hammer"
            };
            comboBox_patterns.DataSource = candlestickPatterns;

            var TempData = stockData.FirstOrDefault();
            var period = TempData.period.ToLower() == "day" ? "Daily" : TempData.period.ToString() + "ly";
            
            label_ticker.Text = TempData.ticker;
            label_period.Text = period;
            this.Text = TempData.ticker;

            refreshGrid();
        }

        /// <summary>
        /// This function is called every time there is a change in the date range.
        /// It uses LINQ to filter the data according to the selected dates and binds the filtered data into the chart.
        /// The function also updates the stock name and the price change label.
        /// </summary>
        public void refreshGrid()
        {
            if (candlesticks != null) candlesticks.Clear();
            if (stockData == null) return;
            var tempdata = stockData.Where(x => x.date >= dateTimePicker_begin.Value && x.date <= dateTimePicker_end.Value).ToList();
            tempop = tempdata;
            if (tempdata == null || tempdata.Count == 0)
            {
                MessageBox.Show("Invalid Date Range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            candlesticks = new BindingList<smartCandlestick>();
            decimal max = 0, min = 9999999;
            foreach (smartCandlestick cs in tempdata)
            {
                if (cs.high > max)
                {
                    max = cs.high;
                }
                
                if (cs.low < min) 
                {
                    min = cs.low;
                }

                candlesticks.Add(cs);

            }

            chart_data.ChartAreas["ChartArea_ohlc"].AxisY.Minimum = (double)min - 10;
            chart_data.ChartAreas["ChartArea_ohlc"].AxisY.Maximum = (double)max + 10;
            chart_data.DataSource = candlesticks;
            chart_data.DataBind();

            var data = stockData.FirstOrDefault();
            

            var change = Math.Round(candlesticks.Last().close - candlesticks.First().close, 2);
            label_priceChange.ForeColor = change < 0 ? Color.Red : Color.Green;

            label_priceChange.Text = change > 0 ? change.ToString() + "$ ↑" : change.ToString() + "$ ↓";
        }

        /// <summary>
        /// Event handler for the click event of the "Refresh" button.
        /// Calls the refreshGrid function to update the chart based on the selected date range.
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Event arguments</param>
        private void button_refreshBtn_MouseClick(object sender, MouseEventArgs e)
        {
            refreshGrid();
        }

        /// <summary>
        /// Event handler for the selection change in the candlestick patterns dropdown.
        /// Clears existing chart annotations and adds new annotations based on the selected pattern.
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Event arguments</param>
        private void comboBox_patterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart_data.Annotations.Clear();
            

            if (comboBox_patterns.SelectedValue.ToString() == "Bullish")
            {
                foreach (smartCandlestick cs in tempop)
                {
                    if (cs.isBullish)
                    {
                        CreateAnnotation(cs);
                    }
                }
            }

            if (comboBox_patterns.SelectedValue.ToString() == "Bearish")
            {
                foreach (smartCandlestick cs in tempop)
                {
                    if (cs.isBearish)
                    {
                        CreateAnnotation(cs);
                    }
                }
            }

            if (comboBox_patterns.SelectedValue.ToString() == "Neutral")
            {
                foreach (smartCandlestick cs in tempop)
                {
                    if (cs.isNeutral)
                    {
                        CreateAnnotation(cs);
                    }
                }
            }

            if (comboBox_patterns.SelectedValue.ToString() == "Doji")
            {
                foreach (smartCandlestick cs in tempop)
                {

                    if (cs.isDoji)
                    {
                        CreateAnnotation(cs);
                    }
                }
            }

            if (comboBox_patterns.SelectedValue.ToString() == "Marubozu")
            {
                foreach (smartCandlestick cs in tempop)
                {
                    if (cs.isMarubozu)
                    {
                        CreateAnnotation(cs);
                    }
                }
            }

            if (comboBox_patterns.SelectedValue.ToString() == "DragonFly Doji")
            {
                foreach (smartCandlestick cs in tempop)
                {
                    if (cs.isDragonFlyDoji)
                    {
                        CreateAnnotation(cs);
                    }
                }
            }

            if (comboBox_patterns.SelectedValue.ToString() == "Gravestone Doji")
            {
                foreach (smartCandlestick cs in tempop)
                {
                    if (cs.isGravestoneDoji)
                    {
                        CreateAnnotation(cs);
                    }
                }
            }

            if (comboBox_patterns.SelectedValue.ToString() == "Hammer")
            {
                foreach (smartCandlestick cs in tempop)
                {
                    if (cs.isHammer)
                    {
                        CreateAnnotation(cs);
                    }
                }
            }

            if (comboBox_patterns.SelectedValue.ToString() == "Inverted Hammer")
            {
                foreach (smartCandlestick cs in tempop)
                {
                    if (cs.isInvertedHammer)
                    {
                        CreateAnnotation(cs);
                    }
                }
            }
        }

        /// <summary>
        /// Creates an annotation on the chart for a specific candlestick.
        /// </summary>
        /// <param name="cs">The smartCandlestick for which to create the annotation</param>
        public void CreateAnnotation(smartCandlestick cs) 
        {
            var rectangleAnnotation = new ArrowAnnotation();
            rectangleAnnotation.AxisX = chart_data.ChartAreas[0].AxisX;
            rectangleAnnotation.AxisY = chart_data.ChartAreas[0].AxisY;
            rectangleAnnotation.X = cs.date.ToOADate();

            rectangleAnnotation.Y = (double)(cs.low) - 5;
            rectangleAnnotation.LineWidth = 1;
            rectangleAnnotation.Width = 0;
            rectangleAnnotation.Height = 5;
            rectangleAnnotation.ArrowSize = 2;

            rectangleAnnotation.LineColor = cs.isBullish ? Color.Green : Color.Red;

            chart_data.Annotations.Add(rectangleAnnotation);
        }
    }
}
