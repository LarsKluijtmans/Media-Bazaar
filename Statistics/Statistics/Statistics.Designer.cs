
namespace Statistics
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.btnIncreaseMonth = new System.Windows.Forms.Button();
            this.btnIncreaseYear = new System.Windows.Forms.Button();
            this.btnDecreaseMonth = new System.Windows.Forms.Button();
            this.btnDecreaseYear = new System.Windows.Forms.Button();
            this.labMonth = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncreaseMonth
            // 
            this.btnIncreaseMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseMonth.Location = new System.Drawing.Point(373, 15);
            this.btnIncreaseMonth.Name = "btnIncreaseMonth";
            this.btnIncreaseMonth.Size = new System.Drawing.Size(52, 33);
            this.btnIncreaseMonth.TabIndex = 15;
            this.btnIncreaseMonth.Text = "<";
            this.btnIncreaseMonth.UseVisualStyleBackColor = true;
            this.btnIncreaseMonth.Click += new System.EventHandler(this.btnIncreaseMonth_Click);
            // 
            // btnIncreaseYear
            // 
            this.btnIncreaseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseYear.Location = new System.Drawing.Point(189, 15);
            this.btnIncreaseYear.Name = "btnIncreaseYear";
            this.btnIncreaseYear.Size = new System.Drawing.Size(52, 33);
            this.btnIncreaseYear.TabIndex = 14;
            this.btnIncreaseYear.Text = "<";
            this.btnIncreaseYear.UseVisualStyleBackColor = true;
            this.btnIncreaseYear.Click += new System.EventHandler(this.btnIncreaseYear_Click);
            // 
            // btnDecreaseMonth
            // 
            this.btnDecreaseMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecreaseMonth.Location = new System.Drawing.Point(500, 15);
            this.btnDecreaseMonth.Name = "btnDecreaseMonth";
            this.btnDecreaseMonth.Size = new System.Drawing.Size(52, 33);
            this.btnDecreaseMonth.TabIndex = 13;
            this.btnDecreaseMonth.Text = ">";
            this.btnDecreaseMonth.UseVisualStyleBackColor = true;
            this.btnDecreaseMonth.Click += new System.EventHandler(this.btnDecreaseMonth_Click);
            // 
            // btnDecreaseYear
            // 
            this.btnDecreaseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecreaseYear.Location = new System.Drawing.Point(302, 15);
            this.btnDecreaseYear.Name = "btnDecreaseYear";
            this.btnDecreaseYear.Size = new System.Drawing.Size(52, 33);
            this.btnDecreaseYear.TabIndex = 12;
            this.btnDecreaseYear.Text = ">";
            this.btnDecreaseYear.UseVisualStyleBackColor = true;
            this.btnDecreaseYear.Click += new System.EventHandler(this.btnDecreaseYear_Click);
            // 
            // labMonth
            // 
            this.labMonth.AutoSize = true;
            this.labMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMonth.Location = new System.Drawing.Point(431, 19);
            this.labMonth.Name = "labMonth";
            this.labMonth.Size = new System.Drawing.Size(63, 24);
            this.labMonth.TabIndex = 10;
            this.labMonth.Text = "Month";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labYear.Location = new System.Drawing.Point(247, 19);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(49, 24);
            this.labYear.TabIndex = 9;
            this.labYear.Text = "Year";
            // 
            // chart1
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(41, 88);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "EmptyPointValue=Zero";
            series1.EmptyPointStyle.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            series1.EmptyPointStyle.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.EmptyPointStyle.BorderWidth = 0;
            series1.EmptyPointStyle.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "TimeWorked";
            series2.ChartArea = "ChartArea1";
            series2.CustomProperties = "EmptyPointValue=Zero";
            series2.EmptyPointStyle.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            series2.EmptyPointStyle.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.EmptyPointStyle.BorderWidth = 0;
            series2.Legend = "Legend1";
            series2.Name = "WorkHours";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(875, 382);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            title1.Name = "Employee atendance";
            title1.Text = "Employee atendance";
            this.chart1.Titles.Add(title1);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 505);
            this.Controls.Add(this.btnIncreaseMonth);
            this.Controls.Add(this.btnIncreaseYear);
            this.Controls.Add(this.btnDecreaseMonth);
            this.Controls.Add(this.btnDecreaseYear);
            this.Controls.Add(this.labMonth);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncreaseMonth;
        private System.Windows.Forms.Button btnIncreaseYear;
        private System.Windows.Forms.Button btnDecreaseMonth;
        private System.Windows.Forms.Button btnDecreaseYear;
        private System.Windows.Forms.Label labMonth;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}