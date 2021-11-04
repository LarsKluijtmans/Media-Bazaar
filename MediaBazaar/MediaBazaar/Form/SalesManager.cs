using ClassLibraryProject;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class SalesManager : Form
    {
        int ID;
        Store store;
        int i;
        public SalesManager(int UserID, Store s)
        {
            InitializeComponent();
            ID = UserID;
            store = s;

            UpdateSchedule();
            UpdateProducts();
            Initialize();
        }

        //Initialize
        public void Initialize()
        {
            DateTime date = DateTime.Now;
            lblWeek.Text = GetCurrentWeekOfYear(date).ToString();
            i = Convert.ToInt32(lblWeek.Text);
            txtYear.Text = date.Year.ToString();
        }

        //Overview
        protected override void OnClosing(CancelEventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgOverviewSchedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(2);
        }
        private void dgProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void lstEmployeesWorkingToday_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        //Products
        //Esther//Esther
        public void UpdateProducts()
        {
            dgvProducts.DataSource = store.productManagment.ViewAllProducts();
        }
        private void dgvProducts_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                tbxProductID.Text = row.Cells["ProductID"].Value.ToString();
                tbxProductName.Text = row.Cells["Name"].Value.ToString();
                tbxBarcode.Text = row.Cells["Barcode"].Value.ToString();
                tbxPrice.Text = row.Cells["Price"].Value.ToString();
                tbxProductType.Text = row.Cells["Type"].Value.ToString();
            }
        }
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            //string productID = txtID.Text;
            //string productName = txtName.Text;
            //string barcode = txtBarcode.Text;
            //string productType = txtProductType.Text;
            //string sellingPrice = txtPrice.Text;

            //store.productManagment.EditProduct(productID, productName, barcode, productType, "", "", sellingPrice);
        }
        private void btnDiscontinue_Click(object sender, EventArgs e)
        {
            //string productID = txtID.Text;
            //store.productManagment.DiscontinueProduct(productID);
        }











        //Schedule
        public static int GetCurrentWeekOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
        public void UpdateSchedule()
        {
            //dgSchedule.DataSource = store.scheduleManagment.ViewSalesSchedule(Convert.ToInt32(lblWeek.Text),Convert.ToInt32(txtYear.Text));
            //dgOverviewSchedule.DataSource = store.scheduleManagment.ViewSalesSchedule(Convert.ToInt32(lblWeek.Text), Convert.ToInt32(txtYear.Text));
            //dgPlanningSchedule.DataSource = store.scheduleManagment.ViewSalesSchedule(Convert.ToInt32(lblWeek.Text), Convert.ToInt32(txtYear.Text));
        }
        private void dgSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgSchedule.Rows[e.RowIndex];
                lbScheduleDay.Text = row.Cells["Day"].Value.ToString();
                lbScheduleEvening.Text = row.Cells["Evening"].Value.ToString();
                lbScheduleMorning.Text = row.Cells["Morning"].Value.ToString();
                lbScheduleAfternoon.Text = row.Cells["Afternoon"].Value.ToString();
            }
        }
        private void btnEditschedule_Click(object sender, EventArgs e)
        {
            string Morning = lbScheduleMorning.Text;
            if (string.IsNullOrEmpty(Morning))
            {
                MessageBox.Show("Amount in Morning is required.");
                return;
            }

            string Afternoon = lbScheduleAfternoon.Text;
            if (string.IsNullOrEmpty(Afternoon))
            {
                MessageBox.Show("Amount in Afternoon is required.");
                return;
            }

            string Evening = lbScheduleEvening.Text;
            if (string.IsNullOrEmpty(Evening))
            {
                MessageBox.Show("Amount in Evening is required.");
                return;
            }

            string Day = lbScheduleDay.Text;
            if (string.IsNullOrEmpty(Day))
            {
                MessageBox.Show("Day is required.");
                return;
            }
            store.scheduleManagment.EditSalesSchedule(Day, Morning, Afternoon, Evening, Convert.ToInt32(lblWeek.Text), Convert.ToInt32(txtYear.Text));

            UpdateSchedule();
        }
        private void btnIncreaseWeek_Click(object sender, EventArgs e)
        {
            try
            {
                if (i < ISOWeek.GetWeeksInYear(Convert.ToInt32(txtYear.Text)))
                {
                    i++;
                }
                else if (i >= ISOWeek.GetWeeksInYear(Convert.ToInt32(txtYear.Text)))
                {
                    i = ISOWeek.GetWeeksInYear(Convert.ToInt32(txtYear.Text));
                }
                lblWeek.Text = i.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please insert year!");
            }
            UpdateSchedule();
        }
        private void btnDecreaseWeek_Click(object sender, EventArgs e)
        {
            if (i > 1)
            {
                i--;
            }
            else if (i <= 0)
            {
                i = 1;
            }
            lblWeek.Text = i.ToString();
            UpdateSchedule();
        }

        

        //Planning   


    }
}
