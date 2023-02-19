 using System;               //
 using System.Windows.Forms; // For testing "chart1"
 using System.Collections.Generic;

namespace Hackathon_2023_MoneyTracker
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(9D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(11D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(12D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(13D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(14D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(15D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(16D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(17D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(18D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(19D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(20D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(21D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint22 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(22D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint23 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(23D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint24 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(24D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint25 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(25D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint26 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(26D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint27 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(27D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint28 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(28D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint29 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(29D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint30 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(30D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint31 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(31D, 0D);
series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint32 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint33 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint34 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint35 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint36 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint37 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint38 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint39 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint40 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(9D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint41 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint42 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(11D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint43 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(12D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint44 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(13D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint45 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(14D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint46 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(15D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint47 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(16D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint48 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(17D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint49 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(18D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint50 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(19D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint51 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(20D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint52 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(21D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint53 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(22D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint54 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(23D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint55 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(24D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint56 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(25D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint57 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(26D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint58 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(27D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint59 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(28D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint60 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(29D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint61 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(30D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint62 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(31D, 0D);
            this.addButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 513);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(451, 25);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "+ Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButtonClick);
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 2D;
            chartArea1.AxisX.IntervalOffset = 1D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(469, 42);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 10;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.MediumSeaGreen;
     
            series1.Legend = "Legend1";
            series1.Name = "Daily Change";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.Points.Add(dataPoint10);
            series1.Points.Add(dataPoint11);
            series1.Points.Add(dataPoint12);
            series1.Points.Add(dataPoint13);
            series1.Points.Add(dataPoint14);
            series1.Points.Add(dataPoint15);
            series1.Points.Add(dataPoint16);
            series1.Points.Add(dataPoint17);
            series1.Points.Add(dataPoint18);
            series1.Points.Add(dataPoint19);
            series1.Points.Add(dataPoint20);
            series1.Points.Add(dataPoint21);
            series1.Points.Add(dataPoint22);
            series1.Points.Add(dataPoint23);
            series1.Points.Add(dataPoint24);
            series1.Points.Add(dataPoint25);
            series1.Points.Add(dataPoint26);
            series1.Points.Add(dataPoint27);
            series1.Points.Add(dataPoint28);
            series1.Points.Add(dataPoint29);
            series1.Points.Add(dataPoint30);
            series1.Points.Add(dataPoint31);
            series2.BorderWidth = 10;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            series2.Legend = "Legend1";
            series2.Name = "Running Total";
            series2.Points.Add(dataPoint32);
            series2.Points.Add(dataPoint33);
            series2.Points.Add(dataPoint34);
            series2.Points.Add(dataPoint35);
            series2.Points.Add(dataPoint36);
            series2.Points.Add(dataPoint37);
            series2.Points.Add(dataPoint38);
            series2.Points.Add(dataPoint39);
            series2.Points.Add(dataPoint40);
            series2.Points.Add(dataPoint41);
            series2.Points.Add(dataPoint42);
            series2.Points.Add(dataPoint43);
            series2.Points.Add(dataPoint44);
            series2.Points.Add(dataPoint45);
            series2.Points.Add(dataPoint46);
            series2.Points.Add(dataPoint47);
            series2.Points.Add(dataPoint48);
            series2.Points.Add(dataPoint49);
            series2.Points.Add(dataPoint50);
            series2.Points.Add(dataPoint51);
            series2.Points.Add(dataPoint52);
            series2.Points.Add(dataPoint53);
            series2.Points.Add(dataPoint54);
            series2.Points.Add(dataPoint55);
            series2.Points.Add(dataPoint56);
            series2.Points.Add(dataPoint57);
            series2.Points.Add(dataPoint58);
            series2.Points.Add(dataPoint59);
            series2.Points.Add(dataPoint60);
            series2.Points.Add(dataPoint61);
            series2.Points.Add(dataPoint62);
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(741, 496);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Edit,
            this.Remove});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(451, 495);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 280;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "✏️";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Width = 25;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "X";
            this.Remove.MinimumWidth = 6;
            this.Remove.Name = "Remove";
            this.Remove.Width = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April ",
            "May ",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December "});
            this.comboBox1.Location = new System.Drawing.Point(550, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(264, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025"});
            this.comboBox2.Location = new System.Drawing.Point(821, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(312, 24);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "◀︎";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1140, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "▶︎";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1034, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "USD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.addButton);
            //this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Series series1;
        private System.Windows.Forms.DataVisualization.Charting.Series series2;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn Name;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Remove;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}

