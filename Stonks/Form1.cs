using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stonks.Models;
using Stonks.Services;


namespace Stonks
{
    public partial class Form1 : Form
    {
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
                dataGridView1.DataSource = stockData;

                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;

                var data = stockData.FirstOrDefault();

                label1.Text = data.ticker;
                label2.Text = data.period;


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
