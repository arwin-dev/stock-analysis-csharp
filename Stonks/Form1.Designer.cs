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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView_stock = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_begin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.chart_ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aCandlestickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandlestickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1097, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All Stock files| *.csv|Daily Stocks|*-Day.csv|Weekly Stocks|*-Week.csv|Monthly St" +
    "ocks|* -Month.csv";
            this.openFileDialog1.InitialDirectory = "C:\\Projects\\Stonks\\Stonks\\Stock Data";
            // 
            // dataGridView_stock
            // 
            this.dataGridView_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stock.Location = new System.Drawing.Point(32, 24);
            this.dataGridView_stock.Name = "dataGridView_stock";
            this.dataGridView_stock.RowHeadersWidth = 62;
            this.dataGridView_stock.Size = new System.Drawing.Size(948, 189);
            this.dataGridView_stock.TabIndex = 1;
            // 
            // dateTimePicker_begin
            // 
            this.dateTimePicker_begin.Location = new System.Drawing.Point(1097, 94);
            this.dateTimePicker_begin.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_begin.Name = "dateTimePicker_begin";
            this.dateTimePicker_begin.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker_begin.TabIndex = 4;
            this.dateTimePicker_begin.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_begin.ValueChanged += new System.EventHandler(this.dateTimePicker_begin_ValueChanged);
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(1097, 134);
            this.dateTimePicker_end.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker_end.TabIndex = 5;
            this.dateTimePicker_end.ValueChanged += new System.EventHandler(this.dateTimePicker_begin_ValueChanged);
            // 
            // chart_
            // 
            chartArea1.Name = "ChartArea_ohlc";
            chartArea2.AlignWithChartArea = "ChartArea_ohlc";
            chartArea2.Name = "ChartArea_volume";
            this.chart_.ChartAreas.Add(chartArea1);
            this.chart_.ChartAreas.Add(chartArea2);
            this.chart_.DataSource = this.aCandlestickBindingSource;
            this.chart_.Location = new System.Drawing.Point(32, 234);
            this.chart_.Margin = new System.Windows.Forms.Padding(2);
            this.chart_.Name = "chart_";
            series1.ChartArea = "ChartArea_ohlc";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=Lime";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerSize = 1;
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
            this.chart_.Series.Add(series1);
            this.chart_.Series.Add(series2);
            this.chart_.Size = new System.Drawing.Size(1361, 705);
            this.chart_.TabIndex = 6;
            this.chart_.Text = "chart1";
            // 
            // aCandlestickBindingSource
            // 
            this.aCandlestickBindingSource.DataSource = typeof(Stonks.Models.aCandlestick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1146, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1213, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 950);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart_);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.dateTimePicker_begin);
            this.Controls.Add(this.dataGridView_stock);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandlestickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView_stock;
        private System.Windows.Forms.BindingSource aCandlestickBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker_begin;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

