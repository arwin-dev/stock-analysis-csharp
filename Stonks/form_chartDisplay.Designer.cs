namespace Stonks
{
    partial class form_chartDisplay
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
            this.chart_data = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker_begin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.label_priceChange = new System.Windows.Forms.Label();
            this.label_ticker = new System.Windows.Forms.Label();
            this.label_period = new System.Windows.Forms.Label();
            this.button_refreshBtn = new System.Windows.Forms.Button();
            this.label_periodEnd = new System.Windows.Forms.Label();
            this.label_periodBegin = new System.Windows.Forms.Label();
            this.comboBox_patterns = new System.Windows.Forms.ComboBox();
            this.bindingSource_aCandlestick = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_aCandlestick)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_data
            // 
            this.chart_data.BorderlineWidth = 0;
            chartArea1.Name = "ChartArea_ohlc";
            chartArea2.AlignWithChartArea = "ChartArea_ohlc";
            chartArea2.Name = "ChartArea_volume";
            this.chart_data.ChartAreas.Add(chartArea1);
            this.chart_data.ChartAreas.Add(chartArea2);
            this.chart_data.Location = new System.Drawing.Point(37, 114);
            this.chart_data.Margin = new System.Windows.Forms.Padding(0);
            this.chart_data.Name = "chart_data";
            series1.ChartArea = "ChartArea_ohlc";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=Lime";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.Name = "Series_ohlc";
            series1.XValueMember = "date";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueMembers = "high, low, open, close";
            series1.YValuesPerPoint = 4;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series2.ChartArea = "ChartArea_volume";
            series2.Name = "Series_volume";
            series2.XValueMember = "date";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series2.YValueMembers = "volume";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.chart_data.Series.Add(series1);
            this.chart_data.Series.Add(series2);
            this.chart_data.Size = new System.Drawing.Size(1236, 545);
            this.chart_data.TabIndex = 7;
            this.chart_data.Text = "chart1";
            // 
            // dateTimePicker_begin
            // 
            this.dateTimePicker_begin.Location = new System.Drawing.Point(362, 708);
            this.dateTimePicker_begin.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_begin.Name = "dateTimePicker_begin";
            this.dateTimePicker_begin.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker_begin.TabIndex = 8;
            this.dateTimePicker_begin.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(758, 708);
            this.dateTimePicker_end.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker_end.TabIndex = 9;
            // 
            // label_priceChange
            // 
            this.label_priceChange.AutoSize = true;
            this.label_priceChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_priceChange.Location = new System.Drawing.Point(754, 27);
            this.label_priceChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_priceChange.Name = "label_priceChange";
            this.label_priceChange.Size = new System.Drawing.Size(15, 24);
            this.label_priceChange.TabIndex = 11;
            this.label_priceChange.Text = ".";
            // 
            // label_ticker
            // 
            this.label_ticker.AutoSize = true;
            this.label_ticker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ticker.Location = new System.Drawing.Point(511, 25);
            this.label_ticker.Name = "label_ticker";
            this.label_ticker.Size = new System.Drawing.Size(70, 26);
            this.label_ticker.TabIndex = 12;
            this.label_ticker.Text = "Ticker";
            // 
            // label_period
            // 
            this.label_period.AutoSize = true;
            this.label_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_period.Location = new System.Drawing.Point(641, 81);
            this.label_period.Name = "label_period";
            this.label_period.Size = new System.Drawing.Size(57, 20);
            this.label_period.TabIndex = 13;
            this.label_period.Text = "label1";
            // 
            // button_refreshBtn
            // 
            this.button_refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refreshBtn.Location = new System.Drawing.Point(604, 706);
            this.button_refreshBtn.Name = "button_refreshBtn";
            this.button_refreshBtn.Size = new System.Drawing.Size(113, 22);
            this.button_refreshBtn.TabIndex = 14;
            this.button_refreshBtn.Text = "Refresh";
            this.button_refreshBtn.UseVisualStyleBackColor = true;
            this.button_refreshBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_refreshBtn_MouseClick);
            // 
            // label_periodEnd
            // 
            this.label_periodEnd.AutoSize = true;
            this.label_periodEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_periodEnd.Location = new System.Drawing.Point(755, 684);
            this.label_periodEnd.Name = "label_periodEnd";
            this.label_periodEnd.Size = new System.Drawing.Size(74, 16);
            this.label_periodEnd.TabIndex = 16;
            this.label_periodEnd.Text = "Period End";
            // 
            // label_periodBegin
            // 
            this.label_periodBegin.AutoSize = true;
            this.label_periodBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_periodBegin.Location = new System.Drawing.Point(452, 684);
            this.label_periodBegin.Name = "label_periodBegin";
            this.label_periodBegin.Size = new System.Drawing.Size(85, 16);
            this.label_periodBegin.TabIndex = 15;
            this.label_periodBegin.Text = "Period Begin";
            // 
            // comboBox_patterns
            // 
            this.comboBox_patterns.FormattingEnabled = true;
            this.comboBox_patterns.Location = new System.Drawing.Point(1160, 711);
            this.comboBox_patterns.Name = "comboBox_patterns";
            this.comboBox_patterns.Size = new System.Drawing.Size(113, 21);
            this.comboBox_patterns.TabIndex = 18;
            this.comboBox_patterns.SelectedIndexChanged += new System.EventHandler(this.comboBox_patterns_SelectedIndexChanged);
            // 
            // bindingSource_aCandlestick
            // 
            this.bindingSource_aCandlestick.DataSource = typeof(Stonks.Models.smartCandlestick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1086, 716);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pattern";
            // 
            // form_chartDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 800);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_patterns);
            this.Controls.Add(this.label_periodEnd);
            this.Controls.Add(this.label_periodBegin);
            this.Controls.Add(this.button_refreshBtn);
            this.Controls.Add(this.label_period);
            this.Controls.Add(this.label_ticker);
            this.Controls.Add(this.label_priceChange);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.dateTimePicker_begin);
            this.Controls.Add(this.chart_data);
            this.Name = "form_chartDisplay";
            this.Text = "ChartDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.chart_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_aCandlestick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_data;
        private System.Windows.Forms.DateTimePicker dateTimePicker_begin;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.Label label_priceChange;
        private System.Windows.Forms.Label label_ticker;
        private System.Windows.Forms.Label label_period;
        private System.Windows.Forms.Button button_refreshBtn;
        private System.Windows.Forms.Label label_periodEnd;
        private System.Windows.Forms.Label label_periodBegin;
        private System.Windows.Forms.ComboBox comboBox_patterns;
        private System.Windows.Forms.BindingSource bindingSource_aCandlestick;
        private System.Windows.Forms.Label label1;
    }
}