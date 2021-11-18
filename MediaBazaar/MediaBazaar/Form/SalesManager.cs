using ClassLibraryProject;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace AdminBackups
{
    public partial class SalesManager : Form
    {
        int ID;
        Store store;
        int i;
        int pi;
        public SalesManager(int UserID, Store s)
        {
            InitializeComponent();
            ID = UserID;
            store = s;

            txtYear.Text = "2021";

            UpdateSchedule();
            UpdateProducts("");
            Initialize();

            timer2.Start();
        }

        //Initialize
        public void Initialize()
        {
            DateTime date = DateTime.Now;
            lblWeek.Text = GetCurrentWeekOfYear(date).ToString();
            lblPlanningWeek.Text = GetCurrentWeekOfYear(date).ToString();
            i = Convert.ToInt32(lblWeek.Text);
            pi = Convert.ToInt32(lblPlanningWeek.Text);
            txtYear.Text = date.Year.ToString();
            txtPlanningYear.Text = date.Year.ToString();
        }

        //Timer
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ActiveControl == tbProductSearch)
            {
                timer1.Start();
            }
            else 
            { 
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateProducts(tbProductSearch.Text);
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
        public void UpdateProducts(string search)
        {
            dgvProducts.DataSource = store.productManagment.ViewAllProducts(search);
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
            int productID = Convert.ToInt32(tbxProductID.Text);
            double price = Convert.ToDouble(tbxPrice.Text);
            if (price == 0)
            {
                MessageBox.Show("Please enter a price");
            }

            store.productManagment.EditPrice(productID, price);

            UpdateProducts("");
        }
        private void btnDiscontinue_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(tbxProductID.Text);
            store.productManagment.DiscontinueProduct(productID);

            UpdateProducts("");
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
            try
            {
                if (store.scheduleManagment.GetSalesCount(Convert.ToInt32(txtYear.Text), Convert.ToInt32(lblWeek.Text)) == true)
                {
                    store.scheduleManagment.CreateSalesWeek(Convert.ToInt32(txtYear.Text), Convert.ToInt32(lblWeek.Text));
                }
                dgSchedule.DataSource = store.scheduleManagment.ViewSalesSchedule(Convert.ToInt32(lblWeek.Text), Convert.ToInt32(txtYear.Text));
                dgOverviewSchedule.DataSource = store.scheduleManagment.ViewSalesSchedule(Convert.ToInt32(lblWeek.Text), Convert.ToInt32(txtYear.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Please insert year!");
            }
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
        public void UpdatePlanningSchedule()
        {
            try
            {
                if (store.scheduleManagment.GetSalesCount(Convert.ToInt32(txtPlanningYear.Text), Convert.ToInt32(lblPlanningWeek.Text)) == true)
                {
                    store.scheduleManagment.CreateSalesWeek(Convert.ToInt32(txtPlanningYear.Text), Convert.ToInt32(lblPlanningWeek.Text));
                }
                dgPlanningSchedule.DataSource = store.scheduleManagment.ViewSalesSchedule(Convert.ToInt32(lblPlanningWeek.Text), Convert.ToInt32(txtYear.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Please insert year!");
            }
        }
        private void btnIncreasePlanningWeek_Click(object sender, EventArgs e)
        {
            try
            {
                if (pi < ISOWeek.GetWeeksInYear(Convert.ToInt32(txtPlanningYear.Text)))
                {
                    pi++;
                }
                else if (pi >= ISOWeek.GetWeeksInYear(Convert.ToInt32(txtPlanningYear.Text)))
                {
                    pi = ISOWeek.GetWeeksInYear(Convert.ToInt32(txtPlanningYear.Text));
                }
                lblPlanningWeek.Text = pi.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please insert year!");
            }
            UpdatePlanningSchedule();
        }
        private void btnDecreasePlanningWeek_Click(object sender, EventArgs e)
        {
            if (pi > 1)
            {
                pi--;
            }
            else if (pi <= 0)
            {
                pi = 1;
            }
            lblPlanningWeek.Text = pi.ToString();
            UpdatePlanningSchedule();
        }
        private void dgPlanningSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrowindex = dgPlanningSchedule.SelectedCells[0].RowIndex;
                int selectedcolumnindex = dgPlanningSchedule.SelectedCells[0].ColumnIndex;
                DataGridViewRow selectedRow = dgPlanningSchedule.Rows[selectedrowindex];
                DataGridViewColumn selectedColumn = dgPlanningSchedule.Columns[selectedcolumnindex];
                int year = Convert.ToInt32(txtPlanningYear.Text);
                int week = Convert.ToInt32(lblPlanningWeek.Text);
                string day = Convert.ToString(selectedRow.Cells["Day"].Value);
                string shift = Convert.ToString(selectedColumn.Name);

                store.employeeManagement.GetAvailableEmployees(week, day, shift);
                foreach (Employee employee in store.employeeManagement.AvailableEmployee)
                {
                    lstEmpCanWork.Items.Add(employee);
                }

                store.employeeManagement.GetEnlistedEmployees(year, week, day, shift);
                foreach (Employee employee in store.employeeManagement.EnlistedEmployee)
                {
                    lstEmpEnlisted.Items.Add(employee);
                }
            }
            catch
            {
                MessageBox.Show("Select amount");
            }
        }
        private void lstEmpCanWork_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
