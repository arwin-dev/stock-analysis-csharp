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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView_stock = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aCandlestickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandlestickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1541, 315);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
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
            this.dataGridView_stock.Location = new System.Drawing.Point(13, 14);
            this.dataGridView_stock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_stock.Name = "dataGridView_stock";
            this.dataGridView_stock.RowHeadersWidth = 62;
            this.dataGridView_stock.Size = new System.Drawing.Size(1422, 291);
            this.dataGridView_stock.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1384, 391);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1384, 463);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1453, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(277, 26);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2023, 4, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1453, 78);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(277, 26);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea_ohlc";
            chartArea2.AlignWithChartArea = "ChartArea_ohlc";
            chartArea2.Name = "ChartArea_volume";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.aCandlestickBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(165, 363);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea_ohlc";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=Lime";
            series1.Legend = "Legend1";
            series1.Name = "Series_ohlc";
            series1.XValueMember = "date";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueMembers = "open, high, low, close";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea_volume";
            series2.Legend = "Legend1";
            series2.Name = "Series_volume";
            series2.XValueMember = "date";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series2.YValueMembers = "volume";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1005, 300);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // aCandlestickBindingSource
            // 
            this.aCandlestickBindingSource.DataSource = typeof(Stonks.Models.aCandlestick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 866);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_stock);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandlestickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource aCandlestickBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

