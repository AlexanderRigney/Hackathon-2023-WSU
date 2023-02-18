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
            data.series = series1;
            data.loadRecords(@"C:\Users\rigne\source\repos\Hackathon 2023 MoneyTracker\Hackathon 2023 MoneyTracker\Money.csv");
        }
        
        

        private void addButtonClick(object sender, EventArgs e)
        {
            AddEntry entry = new AddEntry();
            entry.data = data;
            
            entry.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}  
    

