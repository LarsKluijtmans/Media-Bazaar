using Statistics.ProductData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistics
{
    public partial class Statistics : Form
    {
        Atendance a;
        public Statistics()
        {
            InitializeComponent();
            a = new Atendance();

            labYear.Text = DateTime.Now.Year.ToString();
            labMonth.Text = DateTime.Now.Month.ToString();

            ShowData();
            ShowRestockAmountData();
            ShowRestockRequestData();
            ShowReshelfAmountData();
            ShowReshelfRequestData();
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
