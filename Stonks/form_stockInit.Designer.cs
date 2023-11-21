using System.Windows.Forms;

namespace Stonks
{
    partial class form_stockInit
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
            this.button_load = new System.Windows.Forms.Button();
            this.openFileDialog_getStockFile = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker_begin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.label_periodBegin = new System.Windows.Forms.Label();
            this.label_periodEnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_load
            // 
            this.button_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load.Location = new System.Drawing.Point(32, 140);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(343, 36);
            this.button_load.TabIndex = 0;
            this.button_load.Text = "LOAD DATA";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // openFileDialog_getStockFile
            // 
            this.openFileDialog_getStockFile.FileName = "openFileDialog1";
            this.openFileDialog_getStockFile.Filter = "All Stock files| *.csv|Daily Stocks|*-Day.csv|Weekly Stocks|*-Week.csv|Monthly St" +
    "ocks|* -Month.csv";
            this.openFileDialog_getStockFile.InitialDirectory = "C:\\Projects\\Stonks\\Stonks\\Stock Data";
            this.openFileDialog_getStockFile.Multiselect = true;
            this.openFileDialog_getStockFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_getStockFile_FileOk);
            // 
            // dateTimePicker_begin
            // 
            this.dateTimePicker_begin.Location = new System.Drawing.Point(171, 41);
            this.dateTimePicker_begin.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_begin.Name = "dateTimePicker_begin";
            this.dateTimePicker_begin.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker_begin.TabIndex = 4;
            this.dateTimePicker_begin.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(171, 87);
            this.dateTimePicker_end.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker_end.TabIndex = 5;
            // 
            // label_periodBegin
            // 
            this.label_periodBegin.AutoSize = true;
            this.label_periodBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_periodBegin.Location = new System.Drawing.Point(29, 45);
            this.label_periodBegin.Name = "label_periodBegin";
            this.label_periodBegin.Size = new System.Drawing.Size(85, 16);
            this.label_periodBegin.TabIndex = 11;
            this.label_periodBegin.Text = "Period Begin";
            // 
            // label_periodEnd
            // 
            this.label_periodEnd.AutoSize = true;
            this.label_periodEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_periodEnd.Location = new System.Drawing.Point(29, 87);
            this.label_periodEnd.Name = "label_periodEnd";
            this.label_periodEnd.Size = new System.Drawing.Size(74, 16);
            this.label_periodEnd.TabIndex = 12;
            this.label_periodEnd.Text = "Period End";
            // 
            // form_stockInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(408, 203);
            this.Controls.Add(this.label_periodEnd);
            this.Controls.Add(this.label_periodBegin);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.dateTimePicker_begin);
            this.Controls.Add(this.button_load);
            this.Name = "form_stockInit";
            this.Text = "Stonks Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.OpenFileDialog openFileDialog_getStockFile;
        private System.Windows.Forms.DateTimePicker dateTimePicker_begin;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private Label label_periodBegin;
        private Label label_periodEnd;
    }
}

