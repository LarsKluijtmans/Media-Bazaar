using MediaBazaar.Class;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormOfficeManager : Form
    {
        int ID;
        Store store;
        public FormOfficeManager(int UserID, Store s)
        {
            InitializeComponent();
            ID = UserID;
            store = s;

            ViewAllEmployees();
            ViewAllSchedule();
            ViewOfficePlaning();

        }
        private void lbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person tempPerson = GetTempEmployee();

            tbxEmployeeID.Text = tempPerson.ID.ToString();
        }

        // schedule

        public void ViewAllSchedule()
        {
            store.scheduleManagment.ViewAllSchedule();

            lbSchedule.Items.Clear();

            foreach (Schedule schedule in store.scheduleManagment.schedules)
            {
                if (schedule.Department == "Office")
                {
                    lbSchedule.Items.Add(schedule);
                }
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
                MessageBox.Show("'Morning' field is required.");
                return;
            }

            string Afternoon = lbScheduleAfternoon.Text;
            if (string.IsNullOrEmpty(Afternoon))
            {
                MessageBox.Show("'Afternoon' field is required.");
                return;
            }

            string Evening = lbScheduleEvening.Text;
            if (string.IsNullOrEmpty(Evening))
            {
                MessageBox.Show("'Evening' field is required.");
                return;
            }
            string ID = lbScheduleID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please select a time");
                return;
            }

            store.scheduleManagment.Editschedule(ID, Morning, Afternoon, Evening);

            ViewAllSchedule();
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

        public void ViewOfficePlaning()
        {
            store.planingManagment.ViewOfficePlaning();

            lbPlaning.Items.Clear();

            foreach (Planing planing in store.planingManagment.planings)
            {
                lbPlaning.Items.Add(planing);
            }


            lbEmployee.Items.Clear();

            foreach (BasicEmployeeInfo employee in store.planingManagment.employees)
            {
                lbEmployee.Items.Add(employee);
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

        private void btnEditPlanning_Click(object sender, EventArgs e)
        {

            string WorkID = tbWorkId.Text;
            if (string.IsNullOrEmpty(WorkID))
            {
                MessageBox.Show("'WorkID' field is required.");
                return;
            }

            string NewEmployeeId = tbNewEmployeeId.Text;
            if (string.IsNullOrEmpty(NewEmployeeId))
            {
                MessageBox.Show("'NewEmployeeId' field is required.");
                return;
            }

            string Department = tbDep.Text;
            if (string.IsNullOrEmpty(Department))
            {
                MessageBox.Show("'Department' field is required.");
                return;
            }

            string Day = tbDay.Text;
            if (string.IsNullOrEmpty(Day))
            {
                MessageBox.Show("'Day' field is required.");
                return;
            }

            string Time = tbTime.Text;
            if (string.IsNullOrEmpty(Time))
            {
                MessageBox.Show("'Time' field is required.");
                return;
            }
            store.planingManagment.EditPlaning(WorkID, NewEmployeeId, Department, Day, Time);


            ViewOfficePlaning();

            tbNewEmployeeId.Text = "";
            tbWorkId.Text = "";
            tbNewEmployeeId.Text = "";
            tbDep.Text = "";
            tbDay.Text = "";
            tbTime.Text = "";
            tbNewEmployeeId.BackColor = Color.LightGray;

        }

        private void btnOfficePlan_Click(object sender, EventArgs e)
        {
            ViewOfficePlaning();
        }

        // employees
        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            FormNewEmployee formNewEmployee = new FormNewEmployee();
            formNewEmployee.Show();
        }

        private void btnReadEmployee_Click(object sender, EventArgs e)
        {
            ViewAllEmployees();
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
                    if (reader.GetInt32("Active") == 1)
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

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            Person employee = GetTempEmployee();

            FormViewEmployee formViewEmployee = new FormViewEmployee(employee);
            formViewEmployee.Show();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
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
                MessageBox.Show("Something went wrong" + ex);
            }
            finally
            {
                conn.Close();
            }
            ViewAllEmployees();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (btnCheck.Text == "Check In")
            {
                var date = DateTime.Now;
                MySqlConnection conn = Utils.GetConnection();
                string sql = Utils.CREATE_CHECKIN;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", ID.ToString());
                    cmd.Parameters.AddWithValue("@CheckInTime", date.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@CheckOutTime", null);
                    cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                    conn.Open();
                    int n = cmd.ExecuteNonQuery();
                }
                catch (MySqlException msqEx)
                {
                    MessageBox.Show(msqEx.Message);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong");
                }
                finally
                {
                    conn.Close();
                    btnCheck.Text = "Check Out";
                    MessageBox.Show("Check in successful");
                }
            }
            else if (btnCheck.Text == "Check Out")
            {
                var date = DateTime.Now;
                MySqlConnection conn = Utils.GetConnection();
                string sql = Utils.CREATE_CHECKOUT;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", ID.ToString());
                    cmd.Parameters.AddWithValue("@CheckOutTime", date.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                    conn.Open();
                    int n = cmd.ExecuteNonQuery();
                }
                catch (MySqlException msqEx)
                {
                    MessageBox.Show(msqEx.Message);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong");
                }
                finally
                {
                    conn.Close();
                    btnCheck.Text = "Check In";
                    MessageBox.Show("Check out successful");
                }
            }
        }
    }
}
