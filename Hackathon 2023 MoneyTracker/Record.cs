using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Hackathon_2023_MoneyTracker
{
    public class Record
    {
        public enum Repeat {
            none, daily, weekly, biweekly, monthly
        };
        
        public Int64 money;
        public DateTime date;
        public Repeat repeats;
        public string label;
        
        
        
        public static List<Record> readRecords(string file) {
            List<Record> records = new List<Record>();
            
            using (StreamReader reader = new StreamReader(file)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    string[] columns = line.Split(',');
                    
                    Record record = new Record();
                    
                    // Parse money
                    if (columns[0].Contains('.')) {
                        string[] point = columns[0].Split('.');
                        record.money = Int64.Parse(point[0]) * 100;
                        if (point[1].Length == 1)
                            record.money += Int64.Parse(point[1]) * 10;
                        if (point[1].Length == 2)
                            record.money += Int64.Parse(point[1]);
                    } else {
                        record.money = Int64.Parse(columns[0]) * 100;
                    }
                    
                    // Parse date
                    string[] dateStrings = columns[1].Split('/');
                    record.date = new DateTime(
                        int.Parse(dateStrings[2]),
                        int.Parse(dateStrings[0]),
                        int.Parse(dateStrings[1])
                    );
                    
                    // Parse repeat
                    switch (columns[2]) {
                    case "none"    : record.repeats = Repeat.none    ; break;
                    case "daily"   : record.repeats = Repeat.daily   ; break;
                    case "weekly"  : record.repeats = Repeat.weekly  ; break;
                    case "biweekly": record.repeats = Repeat.biweekly; break;
                    case "monthly" : record.repeats = Repeat.monthly ; break;
                    }
                    
                    record.label = columns[3];
                    
                    records.Add(record);
                }
            }
            
            return records;
        }
    }
}

