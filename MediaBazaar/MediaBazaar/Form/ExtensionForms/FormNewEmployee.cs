using System;
using System.Windows.Forms;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using MySql.Data.MySqlClient;


namespace MediaBazaar
{
    public partial class FormNewEmployee : Form
    {
        public FormNewEmployee()
        {
            InitializeComponent();
        }

        private void BtnNewEmployee_Click(object sender, EventArgs e)
        {
            CreateEmployee();
        }
        // create employee
        public void CreateEmployee()
        {
            string firstName = tbxFirstName.Text;
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Please enter a first name");
            }
            if (char.IsLower(firstName[0]))
            {
                char.ToUpper(firstName[0]);
            }
            string lastName = tbxLastName.Text;
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter a last name");
            }
            if (char.IsLower(lastName[0]))
            {
                char.ToUpper(lastName[0]);
            }
            string username = $"{char.ToLower(firstName[0])}{lastName.ToLower()}";
            string password = $"{char.ToLower(firstName[0])}{lastName.ToLower()}";
            int bsn = Convert.ToInt32(tbxBSN.Text);
            if (bsn == 0)
            {
                MessageBox.Show("Please enter a bsn");
            }
            string city = tbxCity.Text;
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Please enter a city");
            }
            if (char.IsLower(city[0]))
            {
                char.ToUpper(city[0]);
            }
            string email = $"{char.ToLower(firstName[0])}{lastName.ToLower()}@mb.com";
            int phoneNumber = Convert.ToInt32(tbxPhoneNumber.Text);
            if (phoneNumber == 0)
            {
                MessageBox.Show("Please enter a phone number");
            }
            string dateOfBirth = tbxDateOfBirth.Text;
            if (string.IsNullOrEmpty(dateOfBirth))
            {
                MessageBox.Show("Please enter a date of birth");
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = EmployeeManagement.CREATE_EMPLOYEE;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@BSN", bsn);
                cmd.Parameters.AddWithValue("@Active", 1);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();
                long id = cmd.LastInsertedId;

                tbxEmployeeID.Text = id.ToString();

                int employeeID = Convert.ToInt32(id);
                CreateContract(employeeID);
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

            tbxUsername.Text = username;
            tbxPassword.Text = password;
            tbxEmail.Text = email;

        }
        // create contract
        public void CreateContract(int id)
        {
            int employeeID = id;
            string jobTitle = cbxJobTitle.SelectedItem.ToString();
            if (string.IsNullOrEmpty(jobTitle))
            {
                MessageBox.Show("Please select a job title");
            }
            int workHoursPerWeek = Convert.ToInt32(tbxWorkHours.Text);
            if (workHoursPerWeek == 0)
            {
                MessageBox.Show("Please enter work hours per week");
            }
            int salary = Convert.ToInt32(tbxSalary.Text);
            if (salary == 0)
            {
                MessageBox.Show("Please enter salary per hour");
            }
            string startDate = tbxStartDate.Text;
            if (string.IsNullOrEmpty(startDate))
            {
                MessageBox.Show("Please enter a start date");
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = ContractManagement.CREATE_CONTRACT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@JobTitle", jobTitle);
                cmd.Parameters.AddWithValue("@WorkHoursPerWeek", workHoursPerWeek);
                cmd.Parameters.AddWithValue("@SalaryPerHour", salary);
                cmd.Parameters.AddWithValue("@StartDate", startDate);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();
                //long id = cmd.LastInsertedId;
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
