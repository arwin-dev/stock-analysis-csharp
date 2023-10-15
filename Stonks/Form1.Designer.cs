namespace Stonks
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_load = new System.Windows.Forms.Button();
            this.openFileDialog_getStockFile = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView_stock = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_begin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.chart_data = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bindingSource_aCandlestick = new System.Windows.Forms.BindingSource(this.components);
            this.label_ticker = new System.Windows.Forms.Label();
            this.label_period = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label_priceChange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_aCandlestick)).BeginInit();
            this.SuspendLayout();
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(1464, 260);
            this.button_load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(153, 55);
            this.button_load.TabIndex = 0;
            this.button_load.Text = "Load Data";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // openFileDialog_getStockFile
            // 
            this.openFileDialog_getStockFile.FileName = "openFileDialog1";
            this.openFileDialog_getStockFile.Filter = "All Stock files| *.csv|Daily Stocks|*-Day.csv|Weekly Stocks|*-Week.csv|Monthly St" +
    "ocks|* -Month.csv";
            this.openFileDialog_getStockFile.InitialDirectory = "C:\\Projects\\Stonks\\Stonks\\Stock Data";
            // 
            // dataGridView_stock
            // 
            this.dataGridView_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stock.Location = new System.Drawing.Point(48, 14);
            this.dataGridView_stock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_stock.Name = "dataGridView_stock";
            this.dataGridView_stock.RowHeadersWidth = 62;
            this.dataGridView_stock.Size = new System.Drawing.Size(1366, 291);
            this.dataGridView_stock.TabIndex = 1;
            // 
            // dateTimePicker_begin
            // 
            this.dateTimePicker_begin.Location = new System.Drawing.Point(1464, 184);
            this.dateTimePicker_begin.Name = "dateTimePicker_begin";
            this.dateTimePicker_begin.Size = new System.Drawing.Size(304, 26);
            this.dateTimePicker_begin.TabIndex = 4;
            this.dateTimePicker_begin.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(1464, 226);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(304, 26);
            this.dateTimePicker_end.TabIndex = 5;
            // 
            // chart_data
            // 
            chartArea1.Name = "ChartArea_ohlc";
            chartArea2.AlignWithChartArea = "ChartArea_ohlc";
            chartArea2.Name = "ChartArea_volume";
            this.chart_data.ChartAreas.Add(chartArea1);
            this.chart_data.ChartAreas.Add(chartArea2);
            this.chart_data.DataSource = this.bindingSource_aCandlestick;
            this.chart_data.Location = new System.Drawing.Point(48, 387);
            this.chart_data.Name = "chart_data";
            series1.ChartArea = "ChartArea_ohlc";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=Lime";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerSize = 5;
            series1.Name = "Series_ohlc";
            series1.XValueMember = "date";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueMembers = "high, low, open, close";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea_volume";
            series2.Name = "Series_volume";
            series2.XValueMember = "date";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series2.YValueMembers = "volume";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.chart_data.Series.Add(series1);
            this.chart_data.Series.Add(series2);
            this.chart_data.Size = new System.Drawing.Size(2042, 1058);
            this.chart_data.TabIndex = 6;
            this.chart_data.Text = "chart1";
            // 
            // bindingSource_aCandlestick
            // 
            this.bindingSource_aCandlestick.DataSource = typeof(Stonks.Models.aCandlestick);
            // 
            // label_ticker
            // 
            this.label_ticker.AutoSize = true;
            this.label_ticker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ticker.Location = new System.Drawing.Point(1591, 87);
            this.label_ticker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ticker.Name = "label_ticker";
            this.label_ticker.Size = new System.Drawing.Size(26, 37);
            this.label_ticker.TabIndex = 7;
            this.label_ticker.Text = ".";
            // 
            // label_period
            // 
            this.label_period.AutoSize = true;
            this.label_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_period.Location = new System.Drawing.Point(1021, 330);
            this.label_period.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_period.Name = "label_period";
            this.label_period.Size = new System.Drawing.Size(128, 37);
            this.label_period.TabIndex = 8;
            this.label_period.Text = "Monthly";
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(1624, 260);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(144, 55);
            this.button_refresh.TabIndex = 9;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label_priceChange
            // 
            this.label_priceChange.AutoSize = true;
            this.label_priceChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_priceChange.Location = new System.Drawing.Point(1458, 127);
            this.label_priceChange.Name = "label_priceChange";
            this.label_priceChange.Size = new System.Drawing.Size(92, 32);
            this.label_priceChange.TabIndex = 10;
            this.label_priceChange.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2138, 1483);
            this.Controls.Add(this.label_priceChange);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.label_period);
            this.Controls.Add(this.label_ticker);
            this.Controls.Add(this.chart_data);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.dateTimePicker_begin);
            this.Controls.Add(this.dataGridView_stock);
            this.Controls.Add(this.button_load);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Stonks Analysis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_aCandlestick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.OpenFileDialog openFileDialog_getStockFile;
        private System.Windows.Forms.DataGridView dataGridView_stock;
        private System.Windows.Forms.BindingSource bindingSource_aCandlestick;
        private System.Windows.Forms.DateTimePicker dateTimePicker_begin;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_data;
        private System.Windows.Forms.Label label_ticker;
        private System.Windows.Forms.Label label_period;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label_priceChange;
    }
}

