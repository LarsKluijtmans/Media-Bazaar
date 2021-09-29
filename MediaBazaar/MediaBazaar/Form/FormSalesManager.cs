using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MediaBazaar.Class;
using MySql.Data.MySqlClient;

namespace MediaBazaar
{
    public partial class FormSalesManager : Form
    {
        int ID;
        Store mediaBazaar;
        public FormSalesManager(int UserID, Store mb)
        {
            InitializeComponent();
            mediaBazaar = mb;
            ID = UserID;

        }
        // employees
        
        private void lbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person tempPerson = GetTempEmployee();

            tbxEmployeeID.Text = tempPerson.ID.ToString();
        }

        //Products

        public void ViewAllProducts()
        {
            lstProduct.Items.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = Utils.GET_ALL_PRODUCT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Product product;

                while (reader.Read())
                {
                    int ProductID = reader.GetInt32("ProductID");
                    string barcode = reader.GetString("Barcode");
                    string name = reader.GetString("Name");
                    string productType = reader.GetString("Type");
                    int amountInStore = reader.GetInt32("AmountInStore");
                    int amountInDepot = reader.GetInt32("AmountInDepot");

                    product = new Product(ProductID, name, productType, barcode, amountInDepot, amountInStore);

                    lstProduct.Items.Add(product);
                }
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProduct.SelectedIndex < 0)
            {
                return;
            }

            Object ProductObject = lstProduct.SelectedItem;
            if (!(ProductObject is Product))
            {
                return;
            }

            Product product = (Product)ProductObject;
            tbID.Text = product.ProductID.ToString();
            tbName.Text = product.Name;
            tbBarcode.Text = product.Barcode;
            lbProductType.Text = product.ProductType;
            tbmountInStore.Text = product.AmountInStore.ToString();
            tbAmountInDepot.Text = product.AmountInDepot.ToString();
        }

        private void btnRequestReplenishment_Click(object sender, EventArgs e)
        {

            string ID = tbID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                lstProduct.Items.Add("'ID' field is required.");
                return;
            }

            string Amount = tbAmount.Text;
            if (string.IsNullOrEmpty(Amount))
            {
                lstProduct.Items.Add("'Amount' field is required.");
                return;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.CREATE_SHELFREPLENICHMENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", ID);
                cmd.Parameters.AddWithValue("@Amount", Amount);


                conn.Open();
                int numCreatedRows = cmd.ExecuteNonQuery();
                MessageBox.Show("Request was succesfull");
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {

                conn.Close();
            }
        }

        private void btnViewPorducts_Click(object sender, EventArgs e)
        {
            ViewAllProducts();
        }

        // schedule

        public void ViewAllSchedule() 
        {
            lbSchedule.Items.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = Utils.GET_SCHEDULE_SALES;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Schedule schedule;

                while (reader.Read())
                {
                    int Id = reader.GetInt32("scheduleId");
                    string Department = reader.GetString("department");
                    string Day = reader.GetString("day");
                    int MorningAmount = reader.GetInt32("morning");
                    int AfternoonAmount = reader.GetInt32("afternoon");
                    int EveningAmount = reader.GetInt32("evening");

                    schedule = new Schedule(Id, Department, Day, MorningAmount, AfternoonAmount, EveningAmount);

                    lbSchedule.Items.Add(schedule);
                }
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btViewSchedule_Click(object sender, EventArgs e)
        {
            ViewAllSchedule();
        }

        private void btnEditschedule_Click(object sender, EventArgs e)
        {

            string Morning = lbScheduleMorning.Text;
            if (string.IsNullOrEmpty(Morning))
            {
                lbSchedule.Items.Add("'Morning' field is required.");
                return;
            }

            string Afternoon = lbScheduleAfternoon.Text;
            if (string.IsNullOrEmpty(Afternoon))
            {
                lbSchedule.Items.Add("'Afternoon' field is required.");
                return;
            }

            string Evening = lbScheduleEvening.Text;
            if (string.IsNullOrEmpty(Evening))
            {
                lbSchedule.Items.Add("'Evening' field is required.");
                return;
            }
            string ID = lbScheduleID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                lbSchedule.Items.Add("Please select a time");
                return;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.UPDATE_SCHEDULE;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@scheduleId", ID);
                cmd.Parameters.AddWithValue("@morning", Morning);
                cmd.Parameters.AddWithValue("@afternoon", Afternoon);
                cmd.Parameters.AddWithValue("@evening", Evening);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();

                ViewAllSchedule();
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                conn.Close();
            }
        }

        private void lbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSchedule.SelectedIndex < 0)
            {
                return;
            }

            Object scheduleObject = lbSchedule.SelectedItem;
            if (!(scheduleObject is Schedule))
            {
                return;
            }

            Schedule schedule = (Schedule)scheduleObject;

            lbScheduleID.Text = schedule.ID.ToString();
            lbScheduleDepartment.Text = schedule.Department.ToString();
            lbScheduleDay.Text = schedule.Day;
            lbScheduleMorning.Text = schedule.MorningAmount.ToString();
            lbScheduleAfternoon.Text = schedule.AfternoonAmount.ToString();
            lbScheduleEvening.Text = schedule.EveningAmount.ToString();
        }

        //Planing

        public void ViewSalesPlan()
        {
            lbPlaning.Items.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = Utils.GET_SALES_PLANING;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Planing planing;

                while (reader.Read())
                {
                    int WorkId = reader.GetInt32("workID");
                    string Department = reader.GetString("Department");
                    int employeeID = reader.GetInt32("employeeID");
                    string day = reader.GetString("day");
                    string time = reader.GetString("time");


                    planing = new Planing(WorkId, Department, employeeID, day, time);

                    lbPlaning.Items.Add(planing);
                }
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong" + ex);
            }
            finally
            {
                conn.Close();
            }

            lbEmployee.Items.Clear();

            sql = Utils.GET_SALES_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                BasicEmployeeInfo employee;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32("EmployeeID");
                    string firstName = reader.GetString("FirstName");
                    string lastName = reader.GetString("LastName");
                    string jodTitle = reader.GetString("JodTitle");


                    employee = new BasicEmployeeInfo(employeeID, firstName, lastName, jodTitle);

                    lbEmployee.Items.Add(employee);
                }
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void lbPlaning_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPlaning.SelectedIndex < 0)
            {
                return;
            }

            Object planObject = lbPlaning.SelectedItem;
            if (!(planObject is Planing))
            {
                return;
            }

            Planing planing = (Planing)planObject;

            tbWorkId.Text = planing.WorkID.ToString();
            tbNewEmployeeId.Text = planing.EmployeeID.ToString();
            tbDep.Text = planing.Department;
            tbDay.Text = planing.Day.ToString();
            tbTime.Text = planing.Time.ToString();
        }

        private void lbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEmployee.SelectedIndex < 0)
            {
                return;
            }

            Object employeeObject = lbEmployee.SelectedItem;
            if (!(employeeObject is BasicEmployeeInfo))
            {
                return;
            }

            BasicEmployeeInfo EmployeeInfo = (BasicEmployeeInfo)employeeObject;

            tbNewEmployeeId.Text = EmployeeInfo.EmployeeID.ToString();
            tbNewEmployeeId.BackColor = Color.LightBlue;
        }

        private void btnEditPlaning_Click(object sender, EventArgs e)
        {

            string WorkID = tbWorkId.Text;
            if (string.IsNullOrEmpty(WorkID))
            {
                lbPlaning.Items.Add("'WorkID' field is required.");
                lbEmployee.Items.Add("'WorkID' field is required.");
                return;
            }

            string NewEmployeeId = tbNewEmployeeId.Text;
            if (string.IsNullOrEmpty(NewEmployeeId))
            {
                lbPlaning.Items.Add("'NewEmployeeId' field is required.");
                lbEmployee.Items.Add("'NewEmployeeId' field is required.");
                return;
            }

            string Department = tbDep.Text;
            if (string.IsNullOrEmpty(Department))
            {
                lbPlaning.Items.Add("'Department' field is required.");
                lbEmployee.Items.Add("'Department' field is required.");
                return;
            }

            string Day = tbDay.Text;
            if (string.IsNullOrEmpty(Day))
            {
                lbPlaning.Items.Add("'Day' field is required.");
                lbEmployee.Items.Add("'Day' field is required.");
                return;
            }

            string Time = tbTime.Text;
            if (string.IsNullOrEmpty(Time))
            {
                lbPlaning.Items.Add("'Time' field is required.");
                lbEmployee.Items.Add("'Time' field is required.");
                return;
            }
            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.UPDATE_PLANING;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@emplyeeID", NewEmployeeId);
                cmd.Parameters.AddWithValue("@workID", WorkID);

                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();


                ViewSalesPlan();


                tbNewEmployeeId.Text = "";
                tbWorkId.Text = "";
                tbNewEmployeeId.Text = "";
                tbDep.Text = "";
                tbDay.Text = "";
                tbTime.Text = "";
                tbNewEmployeeId.BackColor = Color.LightGray;
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnViewSalesPlan_Click(object sender, EventArgs e)
        {
            ViewSalesPlan();
        }
        // employee
        private void button4_Click(object sender, EventArgs e)
        {
            FormNewEmployee formNewEmployee = new FormNewEmployee();
            formNewEmployee.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewAllEmployees();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Person employee = GetTempEmployee();

            FormViewEmployee formViewEmployee = new FormViewEmployee(employee);
            formViewEmployee.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person employee = GetTempEmployee();
            FormRemoveEmployee formRemoveEmployee = new FormRemoveEmployee(employee);
            formRemoveEmployee.Show();

            string employeeID = tbxEmployeeID.Text;
            string active = "0";

            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.REMOVE_EMPLOYEE_BY_ID;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@Active", active);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                conn.Close();
            }
        }
        private Person GetTempEmployee()
        {
            Object personObj = lbxEmployees.SelectedItem;

            if (!(personObj is Person))
            {
                MessageBox.Show("Error");
            }

            Person tempPerson = (Person)personObj;

            return tempPerson;
        }

        public void ViewAllEmployees()
        {
            lbxEmployees.Items.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = Utils.GET_ALL_EMPLOYEES;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Person employee;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32("EmployeeID");
                    string firstName = reader.GetString("FirstName");
                    string lastName = reader.GetString("LastName");
                    string username = reader.GetString("UserName");
                    string password = reader.GetString("Password");
                    int bsn = reader.GetInt32("BSN");
                    string city = reader.GetString("Address");
                    string email = reader.GetString("Email");
                    int phoneNumber = reader.GetInt32("PhoneNumber");
                    string dateOfBirth = "01-01-1998";

                    employee = new ManagerDepot(employeeID, firstName, lastName, phoneNumber, email, city, dateOfBirth, bsn, username, password);
                    lbxEmployees.Items.Add(employee);

                }
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
