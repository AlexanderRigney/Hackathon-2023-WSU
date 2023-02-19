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
        
        private int index = -1;
        
        public AddEntry()
        {
            InitializeComponent();
        }
        
        public void setIndex(int index) {
            this.index = index;
            Record record = data.getRecord(index);
            textBox1.Text = record.label;
            textBox2.Text = record.money.ToString();
            dateTimePicker1.Value = record.date;
            comboBox1.SelectedIndex = (int)record.repeats;
            button1.Text = "Save";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index != -1)
                data.prepareUpdateRecord(index);
            Record record = index == -1 ? new Record() : data.getRecord(index);
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
            if (index == -1)
                data.addRecord(record);
            else
                data.updateRecord(index);
            data.save();
            Close();
        }
    }
}
