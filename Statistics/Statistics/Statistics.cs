using Statistics.ProductData;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Statistics
{
    public partial class Statistics : Form
    {
        Atendance a;
        int numberOfZoom;
        public Statistics()
        {
            InitializeComponent();
            a = new Atendance();

            labYear.Text = DateTime.Now.Year.ToString();
            labMonth.Text = DateTime.Now.Month.ToString();

            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            numberOfZoom = 0;

            chart1.MouseWheel += chart1_MouseWheel;

            ShowData();
            ShowRestockAmountData();
            ShowRestockRequestData();
            ShowReshelfAmountData();
            ShowReshelfRequestData();
        }

        //Zoom
        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
        
            var xMin = xAxis.ScaleView.ViewMinimum;
            var xMax = xAxis.ScaleView.ViewMaximum;
           
            int IntervalX = 4;
            try
            {
                if (e.Delta < 0 && numberOfZoom > 0) // Scrolled down.
                {
                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - IntervalX *2 / Math.Pow(2, numberOfZoom);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + IntervalX *2/ Math.Pow(2, numberOfZoom);
                  
                    if (posXStart < 0) posXStart = 0;
                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    numberOfZoom--;
                }
                else if (e.Delta < 0 && numberOfZoom == 0) //Last scrolled dowm
                {
                    xAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - IntervalX / Math.Pow(2, numberOfZoom);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + IntervalX / Math.Pow(2, numberOfZoom);
                   
                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    numberOfZoom++;
                }

                if (numberOfZoom < 0) numberOfZoom = 0;
            }
            catch { }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }

        // connect to database
        public void GetAtendeance()
        {
            int year, month;

            year = Convert.ToInt32(labYear.Text);
            month = Convert.ToInt32(labMonth.Text);
            a.GetAtendanceData(year, month);
        }

        // chose year and month
        private void btnIncreaseYear_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt16(labYear.Text);

            year++;
            labYear.Text = year.ToString();
            ShowData();
        }
        private void btnDecreaseYear_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt16(labYear.Text);

            year--;
            labYear.Text = year.ToString();
            ShowData();
        }
        private void btnIncreaseMonth_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt16(labMonth.Text);

            if (month == 12)
            {
                month = 1;
                labMonth.Text = month.ToString();
            }
            else
            {
                month++;
                labMonth.Text = month.ToString();
            }
            ShowData();
        }
        private void btnDecreaseMonth_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt16(labMonth.Text);

            if (month == 1)
            {
                month = 12;
                labMonth.Text = month.ToString();
            }
            else
            {
                month--;
                labMonth.Text = month.ToString();
            }
            ShowData();
        }

        // show data
        public void ShowData()
        {
            GetAtendeance();

            this.chart1.Series["TimeWorked"].Points.Clear();
            this.chart1.Series["WorkHours"].Points.Clear();

            foreach (EmployeeWorkTime ee in a.emp)
            {
                this.chart1.Series["TimeWorked"].Points.AddXY(ee.EmployeeName, Convert.ToInt32(ee.Timeworked.TotalHours));
                this.chart1.Series["WorkHours"].Points.AddXY(ee.EmployeeName, ee.WorkHours * 4);
            }
        }
        public void ShowRestockAmountData()
        {
            RestockData rd = new RestockData();

            this.CRestockAmount.Series["Amount"].Points.Clear();

            foreach (ProductsData ee in rd.RestockAmount())
            {
                this.CRestockAmount.Series["Amount"].Points.AddXY(ee.ProductName, ee.Amount);
            }
        }
        public void ShowRestockRequestData()
        {
            RestockData rd = new RestockData();

            this.CRestockRequest.Series["Amount"].Points.Clear();

            foreach (ProductsData ee in rd.RestockProductAmount())
            {
                this.CRestockRequest.Series["Amount"].Points.AddXY(ee.ProductName, ee.Amount);
            }
        }
        public void ShowReshelfAmountData()
        {
            ReshelfData rd = new ReshelfData();

            this.CReshelfAmount.Series["Amount"].Points.Clear();

            foreach (ProductsData ee in rd.ReshelfAmount())
            {
                this.CReshelfAmount.Series["Amount"].Points.AddXY(ee.ProductName, ee.Amount);
            }
        }
        public void ShowReshelfRequestData()
        {
            ReshelfData rd = new ReshelfData();

            this.CReshelfRequest.Series["Amount"].Points.Clear();

            foreach (ProductsData ee in rd.ReshelfProductAmount())
            {
                this.CReshelfRequest.Series["Amount"].Points.AddXY(ee.ProductName, ee.Amount);
            }
        }
    }
}
