using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.Enum;
using MediaBazaar;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace AdminBackups
{
    public partial class FormSalesManager : Form
    {
        SalesManager salesManager;
        Store store;

        // ???
        int i;
        int pi;
        DateTime date;

        public FormSalesManager(SalesManager salesManager, Store s)
        {
            InitializeComponent();
            this.salesManager = salesManager;
            store = s;

            date = DateTime.Now;

            txtYear.Value = date.Year;

            if (salesManager is SalesManager)
            {
                foreach (Department d in ((SalesManager)salesManager).viewDepartments.ViewAllDepartments())
                {
                    cbSchebuleByDepartment.Items.Add(d);
                    cbDepartments.Items.Add(d);
                }
            }

            cbSchebuleByDepartment.Text = cbSchebuleByDepartment.Items[0].ToString();
            cbDepartments.Text = cbDepartments.Items[0].ToString();


            Initialize();
            UpdateSchedule();
            UpdatePlanningSchedule();
            UpdateEmployeesWorkingToday();

            ReadNewProducts();
            ReadProducts();
        }


        //Logout

        protected override void OnClosed(EventArgs e)
        {
            try
            {
                var FormNewProduct = Application.OpenForms.OfType<FormNewProduct>().FirstOrDefault();
                if (FormNewProduct != null)
                {
                    FormNewProduct.Close();
                }
                var FormViewProduct = Application.OpenForms.OfType<FormViewProduct>().FirstOrDefault();
                if (FormViewProduct != null)
                {
                    FormViewProduct.Close();
                }
            }
            catch { }

            var logout = Application.OpenForms.OfType<FormLogin>().FirstOrDefault();
            logout.Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void UpdateEmployeesWorkingToday()
        {
            try
            {
                store.employeeManagement.GetEmployeesWorkingToday(date.Year, Convert.ToInt32(GetCurrentWeekOfYear(date)), date.DayOfWeek.ToString());
            }
            catch
            {
                MessageBox.Show("Error");
                return;
            }
            lstEmployeesWorkingToday.Items.Clear();
            foreach (Employee employee in store.employeeManagement.EmployeeWorkingToday)
            {
                lstEmployeesWorkingToday.Items.Add(employee);
            }
        }
        public void Initialize()
        {
            DateTime date = DateTime.Now;
            lblWeek.Text = GetCurrentWeekOfYear(date).ToString();
            lblPlanningWeek.Text = GetCurrentWeekOfYear(date).ToString();

            try
            {
                i = Convert.ToInt32(lblWeek.Text);
                pi = Convert.ToInt32(lblPlanningWeek.Text);
            }
            catch
            {
                MessageBox.Show("Error");
                return;
            }
            txtYear.Value = date.Year;
            txtPlanningYear.Value = date.Year;
        }



        //Overview
        private void dgOverviewSchedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(2);
        }
        /* Products */
        private void dgProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void ReadNewProducts()
        {
            List<Product> newProducts = salesManager.ProductManagerSM.ReadNewProductsSM();
            dgvNewProducts.DataSource = newProducts;

            dgvNewProducts.Columns["ProductID"].Visible = false;
            dgvNewProducts.Columns["ProductType"].Visible = false;
            dgvNewProducts.Columns["AmountInDepot"].Visible = false;
            dgvNewProducts.Columns["AmountInStore"].Visible = false;
            dgvNewProducts.Columns["IsDiscontinued"].Visible = false;
        }

        private void lstEmployeesWorkingToday_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        /* Esther Start*/

        /* Products Start */
        public void ReadProducts()
        {
            List<Product> products = salesManager.ProductManagerSM.ReadProductsSM();
            dgvProducts.DataSource = products;
        }
        private void UpdateProduct()
        {
            if (string.IsNullOrEmpty(tbxSelectedProduct.Text))
            {
                MessageBox.Show("Please select a product");
                return;
            }
            int productID = 0;
            try
            {
                productID = Convert.ToInt32(tbxSelectedProduct.Text);
            }
            catch
            {
                MessageBox.Show("Please select a product");
                return;
            }

            Product selectedProduct = salesManager.ProductManagerSM.GetProductByID(productID);

            if (selectedProduct != null)
            {
                FormViewProduct formViewProduct = new FormViewProduct(salesManager, selectedProduct);
                formViewProduct.Show();
            }
        }
        private void tbProductSearch_TextChanged(object sender, EventArgs e)
        {
            UserSearchbar();
        }
        public void UserSearchbar()
        {
            string search = tbProductSearch.Text;

            if (!string.IsNullOrEmpty(search))
            {
                List<Product> products = salesManager.ProductManagerSM.SearchProductsPM(search);
                dgvProducts.DataSource = products;
            }
            else
            {
                ReadProducts();
            }
        }
        private void bntUpdateProduct_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                string productID = row.Cells["ProductID"].Value.ToString();

                tbxSelectedProduct.Text = productID;
            }
        }
        /* Products End */

        /* Esther End*/

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
                //if (salesManager.scheduleManagment.GetSalesCount(Convert.ToInt32(txtYear.Text), Convert.ToInt32(lblWeek.Text), cbDepartments.Text) == true)
                //{
                //    salesManager.scheduleManagment.CreateSalesWeek(Convert.ToInt32(txtYear.Text), Convert.ToInt32(lblWeek.Text), cbDepartments.Text);
                //}
                //dgSchedule.DataSource = salesManager.scheduleManagment.ViewSalesSchedule(Convert.ToInt32(lblWeek.Text), Convert.ToInt32(txtYear.Text), cbDepartments.Text);
                //dgOverviewSchedule.DataSource = salesManager.scheduleManagment.ViewSalesSchedule(Convert.ToInt32(lblWeek.Text), Convert.ToInt32(txtYear.Text), cbDepartments.Text);
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
            string Department = cbSchebuleByDepartment.Text;
            if (string.IsNullOrEmpty(Department))
            {
                MessageBox.Show("Department is required.");
                return;
            }

            UpdateSchedule();
        }
        private void btnIncreaseWeek_Click(object sender, EventArgs e)
        {
            try
            {
                if (i < ISOWeek.GetWeeksInYear(Convert.ToInt32(txtYear.Value)))
                {
                    i++;
                }
                else if (i >= ISOWeek.GetWeeksInYear(Convert.ToInt32(txtYear.Value)))
                {
                    i = ISOWeek.GetWeeksInYear(Convert.ToInt32(txtYear.Value));
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
                //if (store.scheduleManagment.GetSalesCount(Convert.ToInt32(txtPlanningYear.Text), Convert.ToInt32(lblPlanningWeek.Text), cbDepartments.Text) == true)
                //{
                //    store.scheduleManagment.CreateSalesWeek(Convert.ToInt32(txtPlanningYear.Text), Convert.ToInt32(lblPlanningWeek.Text), cbDepartments.Text);
                //}
                //dgPlanningSchedule.DataSource = store.scheduleManagment.ViewSalesSchedule(Convert.ToInt32(lblPlanningWeek.Text), Convert.ToInt32(txtYear.Text), cbDepartments.Text);
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
                if (pi < ISOWeek.GetWeeksInYear(Convert.ToInt32(txtPlanningYear.Value)))
                {
                    pi++;
                }
                else if (pi >= ISOWeek.GetWeeksInYear(Convert.ToInt32(txtPlanningYear.Value)))
                {
                    pi = ISOWeek.GetWeeksInYear(Convert.ToInt32(txtPlanningYear.Value));
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
                int year = Convert.ToInt32(txtPlanningYear.Value);
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


        //Auto schedule
        private void btnAutoSchedule_Click(object sender, EventArgs e)
        {
            if (cbDepartments.Text == "")
            {
                MessageBox.Show("Please select a department");
                return;
            }

            int week = 0;
            int year = 0;
            string department = cbDepartments.Text;
            try
            {
                week = Convert.ToInt32(lblPlanningWeek.Text);
                year = Convert.ToInt32(txtPlanningYear.Value);
            }
            catch
            {
                MessageBox.Show("Please select a week and year");
                return;
            }

            salesManager.autoSchedule.deletePlanning.DeletePlaningThisWeek(week, year, department);

            progressBar1.Maximum = 59;

            for (int loop = 0; loop < 3; loop++)
            {
                Days Day = Days.Monday;
                Shifts Shift = Shifts.Morning;
                for (int i = 0; i < 7; i++)
                {
                    Shift = Shifts.Morning;

                    for (int j = 0; j < 3; j++)
                    {
                        List<int> Employees = new List<int>();
                        int AmountToSchedule = 0;

                        if (loop == 0)
                        {
                            AmountToSchedule = salesManager.autoSchedule.amountOfEmployeesNeeded.AmountOfEmployeesToSchedule(Shift.ToString(), Day.ToString(), week, year, department);

                            if (AmountToSchedule != 0)
                            {
                                if (Shift == Shifts.Evening)
                                { Employees = salesManager.autoSchedule.employeesAvailible.EveningEmployeesShiftPrefered(Shift.ToString(), Day.ToString(), week, year, department); }
                                else
                                { Employees = salesManager.autoSchedule.employeesAvailible.EmployeesShiftPrefered(Shift.ToString(), Day.ToString(), week, year, department); }
                            }
                        }
                        else if (loop == 1)
                        {
                            AmountToSchedule = salesManager.autoSchedule.amountOfEmployeesNeeded.AmountLeftToSchedule(Shift.ToString(), Day.ToString(), week, year, department);

                            if (AmountToSchedule != 0)
                            {
                                if (Shift == Shifts.Evening)
                                { Employees = salesManager.autoSchedule.employeesAvailible.EveningShiftWithoughtPreference(Shift.ToString(), Day.ToString(), week, year, department); }
                                else
                                { Employees = salesManager.autoSchedule.employeesAvailible.EmployeesWithoughtPreference(Shift.ToString(), Day.ToString(), week, year, department); }
                            }
                        }
                        else if (loop == 2)
                        {
                            AmountToSchedule = salesManager.autoSchedule.amountOfEmployeesNeeded.AmountLeftToSchedule(Shift.ToString(), Day.ToString(), week, year, department);

                            if (AmountToSchedule != 0)
                            {
                                if (Shift == Shifts.Evening)
                                { Employees = salesManager.autoSchedule.employeesAvailible.EveningShiftUnPrefered(Shift.ToString(), Day.ToString(), week, year, department); }
                                else
                                { Employees = salesManager.autoSchedule.employeesAvailible.EmployeesUnPrefered(Shift.ToString(), Day.ToString(), week, year, department); }
                            }
                        }

                        if (AmountToSchedule != 0)
                        {
                            if (Employees.Count < AmountToSchedule)
                            {
                                salesManager.autoSchedule.asignShift.ScheduleAllEmployees(Employees, AmountToSchedule, Shift.ToString(), Day.ToString(), week, year);
                            }
                            else
                            {
                                salesManager.autoSchedule.asignShift.ScheduleShift(Employees, AmountToSchedule, Shift.ToString(), Day.ToString(), week, year);
                            }
                        }

                        if (progressBar1.Value != 58)
                        {
                            progressBar1.Value++;
                        }
                        Shift++;
                    }
                    Day++;
                }
            }

            progressBar1.Value = 0;
        }

        private void dgSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNewProducts.Rows[e.RowIndex];

                string productID = row.Cells["ProductID"].Value.ToString();

                tbxSelectedProduct.Text = productID;
            }
            UpdateProduct();
        }

        private void dgvNewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNewProducts.Rows[e.RowIndex];

                string productID = row.Cells["ProductID"].Value.ToString();

                tbxSelectedProduct.Text = productID;
            }

            UpdateProduct();
        }
    }
}
