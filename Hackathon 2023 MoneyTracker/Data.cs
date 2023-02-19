using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hackathon_2023_MoneyTracker
{
    public class Data
    {
        int[] daysInMonth = {
            31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
        };
        
        private List<Record> records = new List<Record>();
        public System.Windows.Forms.DataVisualization.Charting.Chart chart;
        public System.Windows.Forms.DataVisualization.Charting.Series dailyChange;
        public System.Windows.Forms.DataVisualization.Charting.Series runningTotal;
        public ComboBox monthSelector;
        public ComboBox yearSelector;
        public int month;
        public int year;
        public DataGridView grid;
        public string file;
        
        public void loadRecords() {
            List<Record> loaded = Record.readRecords(file);
            foreach (Record record in loaded)
                addRecord(record);
        }
        
        public void updateChart() {
            for (int i = 0; i < 31; i++)
                dailyChange.Points[i].SetValueY(0);
            
            foreach (Record record in records)
                if (record.repeats != Record.Repeat.none) {
                    
                } else if (record.date.Year == year && record.date.Month == month) {
                    var point = dailyChange.Points[record.date.Day - 1];
                    point.SetValueY(point.YValues[0] + (double)record.money / 100D);
                }
            chart.Refresh();
        }
        
        public void updateMonth(int month, int year) {
            this.month = month;
            this.year = year;
            
            chart.ChartAreas[0].AxisX.Maximum = daysInMonth[month - 1];
            
            monthSelector.SelectedItem = monthSelector.Items[month - 1];
            yearSelector.SelectedItem = yearSelector.Items[year - 2022];
            
            updateChart();
        }
        
        public Record getRecord(int index) {
            return records[index];
        }
        
        public void removeRecord(int index) {
            Record record = records[index];
            records.RemoveAt(index);
            grid.Rows.RemoveAt(index);
            
            if (record.date.Year == year && record.date.Month == month) {
                var point = dailyChange.Points[record.date.Day - 1];
                point.SetValueY(point.YValues[0] - (double)record.money / 100D);
                if (point.YValues[0] < 0)
                    point.Color = System.Drawing.Color.Red;
                else
                    point.Color = System.Drawing.Color.MediumSeaGreen;
                for (int i = record.date.Day - 1; i < 31; i++) {
                    point = runningTotal.Points[i];
                    point.SetValueY(point.YValues[0] - (double)record.money / 100D);
                }
            }
            chart.Refresh();
        }
        
        public void prepareUpdateRecord(int index) {
            Record record = records[index];
            
            if (record.date.Year == year && record.date.Month == month) {
                var point = dailyChange.Points[record.date.Day - 1];
                point.SetValueY(point.YValues[0] - (double)record.money / 100D);
                if (point.YValues[0] < 0)
                    point.Color = System.Drawing.Color.Red;
                else
                    point.Color = System.Drawing.Color.MediumSeaGreen;
                for (int i = record.date.Day - 1; i < 31; i++) {
                    point = runningTotal.Points[i];
                    point.SetValueY(point.YValues[0] - (double)record.money / 100D);
                }
            }
        }
        
        public void updateRecord(int index) {
            Record record = records[index];
            
            grid.Rows[index].Cells[0].Value = record.label;
           
            if (record.date.Year == year && record.date.Month == month) {
                var point = dailyChange.Points[record.date.Day - 1];
                point.SetValueY(point.YValues[0] + (double)record.money / 100D);
                if (point.YValues[0] < 0)
                    point.Color = System.Drawing.Color.Red;
                else
                    point.Color = System.Drawing.Color.MediumSeaGreen;
                for (int i = record.date.Day - 1; i < 31; i++) {
                    point = runningTotal.Points[i];
                    point.SetValueY(point.YValues[0] + (double)record.money / 100D);
                }
            }
            
            chart.Refresh();
        }
        
        public void addRecord(Record record) {
            records.Add(record);
            // series.Points.AddXY(record.date, record.money);
            grid.Rows.Add(record.label, "✏️", "X");
            
            if (record.date.Year == year && record.date.Month == month) {
                var point = dailyChange.Points[record.date.Day - 1];
                point.SetValueY(point.YValues[0] + (double)record.money / 100D);
                if (point.YValues[0] < 0)
                    point.Color = System.Drawing.Color.Red;
                else
                    point.Color = System.Drawing.Color.MediumSeaGreen;
                for (int i = record.date.Day - 1; i < 31; i++) {
                    point = runningTotal.Points[i];
                    point.SetValueY(point.YValues[0] + (double)record.money / 100D);
                }
            }
            chart.Refresh();
        }
        
        public void save() {
            using (StreamWriter writer = new StreamWriter(file)) {
                foreach (Record record in records) {
                    StringBuilder row = new StringBuilder();
                    row.Append(record.money);
                    row.Append(',');
                    row.Append(record.date.Month);
                    row.Append('/');
                    row.Append(record.date.Day);
                    row.Append('/');
                    row.Append(record.date.Year);
                    row.Append(',');
                    switch (record.repeats) {
                    case Record.Repeat.none:
                        row.Append("none");
                        break;
                    case Record.Repeat.daily:
                        row.Append("daily");
                        break;
                    case Record.Repeat.weekly:
                        row.Append("weekly");
                        break;
                    case Record.Repeat.biweekly:
                        row.Append("biweekly");
                        break;
                    case Record.Repeat.monthly:
                        row.Append("monthly");
                        break;
                    }
                    row.Append(',');
                    row.Append(record.label);
                    writer.WriteLine(row.ToString());
                }
            }
        }
    }
}
