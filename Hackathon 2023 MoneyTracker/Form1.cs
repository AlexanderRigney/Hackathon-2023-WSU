using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_2023_MoneyTracker
{
    public partial class Form1 : Form
    {
        public Data data;
        
        public Form1()
        {
            InitializeComponent();
            
            data = new Data();
            data.grid = dataGridView1;
            data.chart = chart1;
            data.dailyChange = series1;
            data.runningTotal = series2;
            data.monthSelector = comboBox1;
            data.yearSelector = comboBox2;
            data.file = @"C:\Users\rigne\source\repos\Hackathon 2023 MoneyTracker\Hackathon 2023 MoneyTracker\Money.csv";
            data.updateMonth(2, 2023);
            data.loadRecords();
        }
        
        

        private void addButtonClick(object sender, EventArgs e)
        {
            AddEntry entry = new AddEntry();
            entry.data = data;
            entry.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    break;
                
                case 1:
                    AddEntry entry = new AddEntry();
                    entry.data = data;
                    entry.setIndex(e.RowIndex);
                    entry.ShowDialog();
                    break;
                
                case 2:
                    data.removeRecord(e.RowIndex);
                    data.save();
                    break;
            }
        }

        // Next date
        private void button2_Click(object sender, EventArgs e)
        {
            data.month++;
            if (data.month > 12) {
                data.year++;
                if (data.year > 2025)
                    data.year = 2022;
                data.month = 1;
            }
            data.updateMonth(data.month, data.year);
        }

        //Left Button, -1 month
        private void button1_Click(object sender, EventArgs e)
        {
            data.month--;
            if (data.month <1 )
            {
                data.year--;
                if (data.year < 2022)
                    data.year = 2025;
                data.month = 12;
            }
            data.updateMonth(data.month, data.year);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.updateMonth(comboBox1.SelectedIndex + 1, data.year);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.updateMonth(data.month, comboBox2.SelectedIndex + 2022);
        }
    }
}

