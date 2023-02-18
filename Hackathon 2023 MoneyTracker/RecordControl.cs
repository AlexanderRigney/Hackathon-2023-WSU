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
    public partial class RecordControl : UserControl
    {
        public RecordControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        
        public void setLabel(string label) {
            button1.Text = label;
        }
    }
}
