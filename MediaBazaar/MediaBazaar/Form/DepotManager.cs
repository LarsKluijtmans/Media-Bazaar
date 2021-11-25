using ClassLibraryProject.Class;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace AdminBackups
{
    public partial class DepotManager : Form
    {
        int ID;
        Store store;
        int i;
        int pi;
        DateTime date = DateTime.Now;
        public DepotManager(int UserID, Store s)
        {
            InitializeComponent();

            store = s;
            ID = UserID;

            Initialize();
            UpdateRestockRequests();
            UpdateSchedule();
            UpdatePlanningSchedule();
            UpdateSupplier();
            UpdateEmployeesWorkingToday();
        }

        //Initialize
        public void Initialize()
        {
            lblWeek.Text = GetCurrentWeekOfYear(date).ToString();
            lblPlanningWeek.Text = GetCurrentWeekOfYear(date).ToString();
            i = Convert.ToInt32(lblWeek.Text);
            pi = Convert.ToInt32(lblPlanningWeek.Text);
            txtYear.Text = date.Year.ToString();
            txtPlanningYear.Text = date.Year.ToString();
        }

        //Overview
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgOverviewSchedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void dgOverviewRestock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void lstEmployeesWorkingToday_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tabControl1.SelectTab(3);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(4);
        }
        private void UpdateEmployeesWorkingToday()
        {
            store.employeeManagement.GetEmployeesWorkingToday(date.Year, Convert.ToInt32(GetCurrentWeekOfYear(date)), date.DayOfWeek.ToString());
            lstEmployeesWorkingToday.Items.Clear();
            foreach(Employee employee in store.employeeManagement.EmployeeWorkingToday)
            {
                lstEmployeesWorkingToday.Items.Add(employee);
            }
        }
        //Restock
        public void UpdateRestockRequests()
        {
            dgOverviewRestock.DataSource = store.restockManagment.ViewPendingRestockRequests();
            dgRestock.DataSource = store.restockManagment.ViewPendingRestockRequests();
        }
        private void rbPending_Click(object sender, EventArgs e)
        {
            dgRestock.DataSource = store.restockManagment.ViewPendingRestockRequests();
        }

        private void rbHistory_CheckedChanged(object sender, EventArgs e)
        {
            dgRestock.DataSource = store.restockManagment.ViewHistoryRestockRequests();
        }
        public void DeleteRestockRequest()
        {
            string restockID = txtRestockID.Text;
            try
            {
                store.restockManagment.DeleteRestockRequest(Convert.ToInt32(restockID));
            }
            catch (Exception)
            {
                MessageBox.Show("Select any restock request you want to reject.");
            }

            UpdateRestockRequests();
        }
        private void btnOrderRestock_Click(object sender, EventArgs e)
        {
            string restockID = txtRestockID.Text;
            try
            {
                store.restockManagment.OrderRestock(Convert.ToInt32(restockID));
            }
            catch
            {
                MessageBox.Show("Select any restock request you want to finalize.");
            }
            UpdateRestockRequests();
        }
        private void btnDeleteRestockRequest_Click(object sender, EventArgs e)
        {
            DeleteRestockRequest();
        }
        private void dgRestock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgRestock.Rows[e.RowIndex];
                txtRestockID.Text = row.Cells["RestockReplenishmentID"].Value.ToString();
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtBarcode.Text = row.Cells["Barcode"].Value.ToString();
                txtCurrentAmount.Text = row.Cells["ReceivedAmount"].Value.ToString();
            }
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
                if (store.scheduleManagment.GetDepotCount(Convert.ToInt32(txtYear.Text), Convert.ToInt32(lblWeek.Text)) == true)
                {
                    store.scheduleManagment.CreateDepotWeek(Convert.ToInt32(txtYear.Text), Convert.ToInt32(lblWeek.Text));
                }
                dgSchedule.DataSource = store.scheduleManagment.ViewDepotSchedule(Convert.ToInt32(lblWeek.Text), Convert.ToInt32(txtYear.Text));
                dgOverviewSchedule.DataSource = store.scheduleManagment.ViewDepotSchedule(Convert.ToInt32(lblWeek.Text), Convert.ToInt32(txtYear.Text));
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
            try
            {
                store.scheduleManagment.EditDepotSchedule(Day, Morning, Afternoon, Evening, Convert.ToInt32(lblWeek.Text), Convert.ToInt32(txtYear.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Please insert year!");
            }

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
                if (store.scheduleManagment.GetDepotCount(Convert.ToInt32(txtPlanningYear.Text), Convert.ToInt32(lblPlanningWeek.Text)) == true)
                {
                    store.scheduleManagment.CreateDepotWeek(Convert.ToInt32(txtPlanningYear.Text), Convert.ToInt32(lblPlanningWeek.Text));
                }
                dgPlanningSchedule.DataSource = store.scheduleManagment.ViewDepotSchedule(Convert.ToInt32(lblPlanningWeek.Text), Convert.ToInt32(txtYear.Text));
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

                lstEmpCanWork.Items.Clear();
                store.employeeManagement.GetAvailableEmployees(week, day, shift);
                foreach (Employee employee in store.employeeManagement.AvailableEmployee)
                {
                    lstEmpCanWork.Items.Add(employee);
                }

                lstEmpEnlisted.Items.Clear();
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
            Object EmployeeObject = lstEmpCanWork.SelectedItem;
            if (!(EmployeeObject is Employee))
            {
                return;
            }
            Employee employee = (Employee)EmployeeObject;
            int selectedrowindex = dgPlanningSchedule.SelectedCells[0].RowIndex;
            int selectedcolumnindex = dgPlanningSchedule.SelectedCells[0].ColumnIndex;
            DataGridViewRow selectedRow = dgPlanningSchedule.Rows[selectedrowindex];
            DataGridViewColumn selectedColumn = dgPlanningSchedule.Columns[selectedcolumnindex];
            int year = Convert.ToInt32(txtPlanningYear.Text);
            int week = Convert.ToInt32(lblPlanningWeek.Text);
            string day = Convert.ToString(selectedRow.Cells["Day"].Value);
            string shift = Convert.ToString(selectedColumn.Name);
            store.planningManagment.AddPlanning(year, week, day, shift, employee.EmployeeID);
        }

        private void btnRemoveFromSchedule_Click(object sender, EventArgs e)
        {

        }

        //Supplier
        private void UpdateSupplier()
        {
            dgOverviewSupplier.DataSource = store.supplierManagment.ViewAllSuppliers();
            dgSupplier.DataSource = store.supplierManagment.ViewAllSuppliers();
        }
        private void dgSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgSupplier.Rows[e.RowIndex];
                txtSupplierID.Text = row.Cells["SupplierID"].Value.ToString();
                txtSupplierName.Text = row.Cells["SupplierName"].Value.ToString();
                txtCountry.Text = row.Cells["Country"].Value.ToString();
                txtBuildingNumber.Text = row.Cells["BuildingNumber"].Value.ToString();
                txtPostalCode.Text = row.Cells["PostalCode"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtBankNumber.Text = row.Cells["BankNumber"].Value.ToString();
            }
        }
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            string name = txtSupplierName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("'Name' is required.");
                return;
            }
            string country = txtCountry.Text;
            if (string.IsNullOrEmpty(country))
            {
                MessageBox.Show("'Country' is required.");
                return;
            }
            string buildingNumber = txtBuildingNumber.Text;
            string postalCode = txtPostalCode.Text;
            if (string.IsNullOrEmpty(postalCode))
            {
                MessageBox.Show("'Postal Code' is required.");
                return;
            }
            string email = txtEmail.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("'Email' is required.");
                return;
            }
            string phoneNumber = txtPhoneNumber.Text;
            string bankNumber = txtBankNumber.Text;
            if (string.IsNullOrEmpty(bankNumber))
            {
                MessageBox.Show("'Bank Number' is required.");
                return;
            }
            try
            {
                store.supplierManagment.AddSupplier(name, country, Convert.ToInt32(buildingNumber), postalCode, email, Convert.ToInt32(phoneNumber), bankNumber);
            }
            catch (Exception)
            {
                MessageBox.Show("Select a supplier you want to edit");
            }
            UpdateSupplier();
        }
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            string id = txtSupplierID.Text;
            string name = txtSupplierName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("'Name' is required.");
                return;
            }
            string country = txtCountry.Text;
            if (string.IsNullOrEmpty(country))
            {
                MessageBox.Show("'Country' is required.");
                return;
            }
            string buildingNumber = txtBuildingNumber.Text;
            string postalCode = txtPostalCode.Text;
            if (string.IsNullOrEmpty(postalCode))
            {
                MessageBox.Show("'Postal Code' is required.");
                return;
            }
            string email = txtEmail.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("'Email' is required.");
                return;
            }
            string phoneNumber = txtPhoneNumber.Text;
            string bankNumber = txtBankNumber.Text;
            if (string.IsNullOrEmpty(bankNumber))
            {
                MessageBox.Show("'Bank Number' is required.");
                return;
            }
            try
            {
                store.supplierManagment.EditSupplier(Convert.ToInt32(id), name, country, Convert.ToInt32(buildingNumber), postalCode, email, Convert.ToInt32(phoneNumber), bankNumber);
            }
            catch (Exception)
            {
                MessageBox.Show("Select a supplier you want to edit");
            }
            UpdateSupplier();
        }
        private void btnRemoveSupplier_Click(object sender, EventArgs e)
        {
            string supplierID = txtSupplierID.Text;
            try
            {
                store.supplierManagment.DeleteSupplier(Convert.ToInt32(supplierID));
            }
            catch (Exception)
            {
                MessageBox.Show("Select supplier you want to delete");
            }

            UpdateSupplier();
        }
        private void btnOrderInfo_Click(object sender, EventArgs e)
        {
            string supplierID = txtSupplierID.Text;
            try
            {
                FormOrderInfo formOrderInfo = new FormOrderInfo(Convert.ToInt32(supplierID));
                formOrderInfo.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Select supplier");
            }
        }
    }
}
