namespace Stonks
{
    partial class ChartDisplay
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_data = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker_begin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.label_priceChange = new System.Windows.Forms.Label();
            this.label_ticker = new System.Windows.Forms.Label();
            this.label_period = new System.Windows.Forms.Label();
            this.button_refreshBtn = new System.Windows.Forms.Button();
            this.label_periodEnd = new System.Windows.Forms.Label();
            this.label_periodBegin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_data)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_data
            // 
            this.chart_data.BorderlineWidth = 0;
            chartArea3.Name = "ChartArea_ohlc";
            chartArea4.AlignWithChartArea = "ChartArea_ohlc";
            chartArea4.Name = "ChartArea_volume";
            this.chart_data.ChartAreas.Add(chartArea3);
            this.chart_data.ChartAreas.Add(chartArea4);
            this.chart_data.Location = new System.Drawing.Point(37, 143);
            this.chart_data.Margin = new System.Windows.Forms.Padding(0);
            this.chart_data.Name = "chart_data";
            series3.ChartArea = "ChartArea_ohlc";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series3.CustomProperties = "PriceDownColor=Red, PriceUpColor=Lime";
            series3.MarkerBorderColor = System.Drawing.Color.White;
            series3.Name = "Series_ohlc";
            series3.XValueMember = "date";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series3.YValueMembers = "high, low, open, close";
            series3.YValuesPerPoint = 4;
            series4.ChartArea = "ChartArea_volume";
            series4.Name = "Series_volume";
            series4.XValueMember = "date";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series4.YValueMembers = "volume";
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.chart_data.Series.Add(series3);
            this.chart_data.Series.Add(series4);
            this.chart_data.Size = new System.Drawing.Size(1236, 545);
            this.chart_data.TabIndex = 7;
            this.chart_data.Text = "chart1";
            // 
            // dateTimePicker_begin
            // 
            this.dateTimePicker_begin.Location = new System.Drawing.Point(408, 727);
            this.dateTimePicker_begin.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_begin.Name = "dateTimePicker_begin";
            this.dateTimePicker_begin.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker_begin.TabIndex = 8;
            this.dateTimePicker_begin.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(847, 727);
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
            this.label_period.Location = new System.Drawing.Point(640, 103);
            this.label_period.Name = "label_period";
            this.label_period.Size = new System.Drawing.Size(57, 20);
            this.label_period.TabIndex = 13;
            this.label_period.Text = "label1";
            // 
            // button_refreshBtn
            // 
            this.button_refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refreshBtn.Location = new System.Drawing.Point(556, 773);
            this.button_refreshBtn.Name = "button_refreshBtn";
            this.button_refreshBtn.Size = new System.Drawing.Size(241, 27);
            this.button_refreshBtn.TabIndex = 14;
            this.button_refreshBtn.Text = "Refresh";
            this.button_refreshBtn.UseVisualStyleBackColor = true;
            this.button_refreshBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_refreshBtn_MouseClick);
            // 
            // label_periodEnd
            // 
            this.label_periodEnd.AutoSize = true;
            this.label_periodEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_periodEnd.Location = new System.Drawing.Point(755, 731);
            this.label_periodEnd.Name = "label_periodEnd";
            this.label_periodEnd.Size = new System.Drawing.Size(74, 16);
            this.label_periodEnd.TabIndex = 16;
            this.label_periodEnd.Text = "Period End";
            // 
            // label_periodBegin
            // 
            this.label_periodBegin.AutoSize = true;
            this.label_periodBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_periodBegin.Location = new System.Drawing.Point(307, 727);
            this.label_periodBegin.Name = "label_periodBegin";
            this.label_periodBegin.Size = new System.Drawing.Size(85, 16);
            this.label_periodBegin.TabIndex = 15;
            this.label_periodBegin.Text = "Period Begin";
            // 
            // ChartDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 833);
            this.Controls.Add(this.label_periodEnd);
            this.Controls.Add(this.label_periodBegin);
            this.Controls.Add(this.button_refreshBtn);
            this.Controls.Add(this.label_period);
            this.Controls.Add(this.label_ticker);
            this.Controls.Add(this.label_priceChange);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.dateTimePicker_begin);
            this.Controls.Add(this.chart_data);
            this.Name = "ChartDisplay";
            this.Text = "ChartDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.chart_data)).EndInit();
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
    }
}