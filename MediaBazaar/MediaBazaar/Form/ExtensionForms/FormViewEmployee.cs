using System;
using System.Diagnostics;
using System.Windows.Forms;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using MySql.Data.MySqlClient;


namespace AdminBackups
{
    public partial class FormViewEmployee : Form
    {
        Person p;
        Contract c;
        public FormViewEmployee(Person p, Contract c)
        {
            InitializeComponent();
            this.p = p;
            this.c = c;

            try
            {

                lblEmployeeName.Text = $"{p.FirstName} {p.LastName}";
            }
            catch
            {
                MessageBox.Show("Please select a employee from the list.");
            }

            // employee
            tbxEmployeeID.Text = p.EmployeeID.ToString(); // read only
            tbxFirstName.Text = p.FirstName;
            tbxLastName.Text = p.LastName;
            tbxUserName.Text = p.Username; //
            tbxBSN.Text = p.BSN.ToString(); //
            tbxCity.Text = p.City;
            tbxEmail.Text = p.Email; //
            tbxPhoneNumber.Text = p.PhoneNumber.ToString();
            tbxDateOfBirth.Text = p.DateOfBirth; //

            // contract
            cbxJobTitle.Text = c.JobTitle;
            tbxWorkHours.Text = c.WorkHoursPerWeek.ToString();
            tbxSalary.Text = c.SalaryPerHour.ToString();
            tbxStartDate.Text = c.StartDate;
        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            UpdateEmployee();
            UpdateContract();
        }
        public void UpdateEmployee()
        {
            string employeeID = tbxEmployeeID.Text;
            string firstName = tbxFirstName.Text;
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Please enter a first name");
                return;
            }
            string lastName = tbxLastName.Text;
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter a last name");
                return;
            }
            string city = tbxCity.Text;
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Please enter a city");
                return;
            }
            string phoneNumber = tbxPhoneNumber.Text;
            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter a phone number");
                return;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = EmployeeManagement.UPDATE_EMPLOYEE;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void UpdateContract()
        {
            string employeeID = tbxEmployeeID.Text;
            string jobTitle = cbxJobTitle.SelectedItem.ToString();
            if (string.IsNullOrEmpty(jobTitle))
            {
                MessageBox.Show("Please select a job title");
                return;
            }
            string workHours = tbxWorkHours.Text;
            if (string.IsNullOrEmpty(workHours))
            {
                MessageBox.Show("Please enter work hours");
                return;
            }
            string salary = tbxSalary.Text;
            if (string.IsNullOrEmpty(salary))
            {
                MessageBox.Show("Please enter salary");
                return;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = ContractManagement.UPDATE_CONTRACT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@JobTitle", jobTitle);
                cmd.Parameters.AddWithValue("@WorkHoursPerWeek", workHours);
                cmd.Parameters.AddWithValue("@SalaryPerHour", salary);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
