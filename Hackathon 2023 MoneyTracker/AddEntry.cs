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
    public partial class AddEntry : Form
    {
        public Data data;
        
        public AddEntry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            record.label = textBox1.Text;
            record.money = Int64.Parse(textBox2.Text);
            record.date = dateTimePicker1.Value;
            switch (comboBox1.SelectedItem.ToString()) {
            case "none"    : record.repeats = Record.Repeat.none    ; break;
            case "daily"   : record.repeats = Record.Repeat.daily   ; break;
            case "weekly"  : record.repeats = Record.Repeat.weekly  ; break;
            case "biweekly": record.repeats = Record.Repeat.biweekly; break;
            case "monthly" : record.repeats = Record.Repeat.monthly ; break;
            }
            data.addRecord(record);
            Close();
        }
    }
}
