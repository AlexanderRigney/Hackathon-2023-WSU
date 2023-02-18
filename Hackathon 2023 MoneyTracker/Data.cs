using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_2023_MoneyTracker
{
    public class Data
    {
        private List<Record> records = new List<Record>();
        public System.Windows.Forms.DataVisualization.Charting.Series series;
        public DataGridView grid;
        
        public void loadRecords(string file) {
            List<Record> loaded = Record.readRecords(file);
            foreach (Record record in loaded)
                addRecord(record);
        }
        
        public void addRecord(Record record) {
            records.Add(record);
            series.Points.AddXY(record.date, record.money);
            grid.Rows.Add(record.label, "✏️", "X");
        }
        
        public void saveRecords() {
            
        }
    }
}
