using Stonks.Models;
using Stonks.Recognizers;
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
        List<Recognizer> recognizers = null;
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

            InitRecognizers();
            InitComboBox();

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

            chart_data.ChartAreas["ChartArea_ohlc"].AxisY.Minimum = (double)min * 0.8;
            chart_data.ChartAreas["ChartArea_ohlc"].AxisY.Maximum = (double)max * 1.1;
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
        /// Event handler for the selection change in the combo box containing candlestick patterns.
        /// Clears existing chart annotations and creates new annotations based on the selected pattern recognizer.
        /// </summary>
        /// <param name="sender">The object that triggered the event (combo box)</param>
        /// <param name="e">Event arguments</param>
        private void comboBox_patterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart_data.Annotations.Clear();
            
            var selectedRecognizer = recognizers[comboBox_patterns.SelectedIndex];
            if (tempop == null) return;
            for(int i = 0; i < tempop.Count ; i++) 
            {
                if(selectedRecognizer.recognizePattern(tempop[i]) && selectedRecognizer.patternSize == 1)
                {
                    CreateAnnotation(tempop[i]);
                }
                else if(i < tempop.Count - selectedRecognizer.patternSize + 1)
                {
                    List<smartCandlestick> subList = tempop.GetRange(i, selectedRecognizer.patternSize);
                    if (selectedRecognizer.recognizePattern(subList))
                    {
                        CreateListOfAnnotation(subList, selectedRecognizer.patternName);
                    }
                }
            }
        }

        /// <summary>
        /// Creates an annotation on the chart for a specific candlestick.
        /// </summary>
        /// <param name="cs">The smartCandlestick for which to create the annotation</param>
        /// <param name="color">Line color for multicandlesticcks</param>
        /// <param name="color2">Back color for multicandlesticcks</param>
        /// <param name="patternName">Pattern Name of the candlesticks</param>
        public void CreateAnnotation(smartCandlestick cs, Color color = default, Color color2 = default, string patternName = "")
        {
            var arrowAnnotation = new ArrowAnnotation();
            arrowAnnotation.AxisX = chart_data.ChartAreas[0].AxisX;
            arrowAnnotation.AxisY = chart_data.ChartAreas[0].AxisY;
            arrowAnnotation.X = cs.date.ToOADate();

            arrowAnnotation.Y = (double)(cs.low) - 5;
            arrowAnnotation.LineWidth = 1;
            arrowAnnotation.Width = 0;
            arrowAnnotation.Height = 5;
            arrowAnnotation.ArrowSize = 2;
            arrowAnnotation.ForeColor = color;
            arrowAnnotation.LineColor = color == default ? (cs.isBullish ? Color.Green : Color.Red) : color;
            arrowAnnotation.BackColor = color2 == default ? default : color2;

            if (color2 != default)
            {
                double x1 = chart_data.Series[0].Points[0].XValue;
                double x2 = chart_data.Series[0].Points[1].XValue;
                double candlestickWidth = Math.Abs(x2 - x1);

                var textAnnotation = new TextAnnotation();
                textAnnotation.AxisX = chart_data.ChartAreas[0].AxisX;
                textAnnotation.AxisY = chart_data.ChartAreas[0].AxisY;
                textAnnotation.X = cs.date.ToOADate() - candlestickWidth;
                textAnnotation.Y = (double)(cs.high)*1.1;
                textAnnotation.Text = patternName;
                textAnnotation.AnchorAlignment = ContentAlignment.MiddleLeft;
                textAnnotation.Alignment = ContentAlignment.MiddleLeft;
                chart_data.Annotations.Add(textAnnotation);
            }

            chart_data.Annotations.Add(arrowAnnotation);
            
        }

        /// <summary>
        /// Handles multistick candlestick patterns (Peak and Valley patterns)
        /// </summary>
        /// <param name="cs">List of Candlesticks</param>
        /// <param name="patternName">Pattern Name of the candlesticks</param>
        public void CreateListOfAnnotation(List<smartCandlestick> cs, string patternName)
        {
            if(cs.Count == 2)
            {
                CreateAnnotation(cs[0], Color.LightGreen);
                CreateAnnotation(cs[1], Color.Red, Color.Red, patternName);
            }
            else if(cs.Count == 3) 
            {
                CreateAnnotation(cs[0], Color.LightGreen);
                CreateAnnotation(cs[2], Color.LightGreen);
                CreateAnnotation(cs[1], Color.Red, Color.Red, patternName);
            }
        }

        /// <summary>
        /// Initializes the list of pattern recognizers with predefined instances for various candlestick patterns.
        /// </summary>
        public void InitRecognizers()
        {
            List<Recognizer> lr = new List<Recognizer>();
            lr.Add(new bullishRecognizer(1, "Bullish"));
            lr.Add(new bearishRecognizer(1, "Bearish"));
            lr.Add(new neutralRecognizer(1, "Neutral"));
            lr.Add(new marubozuRecognizer(1, "Marubozu"));
            lr.Add(new dojiRecognizer(1, "Doji"));
            lr.Add(new dragonflyDojiRecognizer(1, "DragonFly Doji"));
            lr.Add(new gravestoneDojiRecognizer(1, "Gravestone Doji"));
            lr.Add(new hammerRecognizer(1, "Hammer"));
            lr.Add(new invertedHammerRecognizer(1, "Inverted Hammer"));
            lr.Add(new bullishEngulfingRecognizer(2, "Bullish Engulfing"));
            lr.Add(new bearishEngulfingRecognizer(2, "Bearish Engulfing"));
            lr.Add(new bullishHaramiRecognizer(2, "Bullish Harami"));
            lr.Add(new bearishHaramiRecognizer(2, "Bearish Harami"));
            lr.Add(new peakRecognizer(3, "Peak"));
            lr.Add(new valleyRecognizer(3, "Valley"));

            recognizers = lr;
        }

        /// <summary>
        /// Initializes the combo box by populating it with the names of the available candlestick patterns.
        /// </summary>
        public void InitComboBox()
        {
            List<string> patternNames = new List<string>();
            foreach (Recognizer r in recognizers) 
            {
                patternNames.Add(r.patternName);
            }

            comboBox_patterns.DataSource = patternNames;
        }
    }
}
