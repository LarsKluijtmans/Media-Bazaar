using ClassLibraryProject.ManagmentClasses;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace AdminBackups
{
    public partial class FormNewEmployee : Form
    {
        EmailManager em;
        EmployeeManagement employeeM;
        public FormNewEmployee()
        {
            InitializeComponent();
            em = new EmailManager();
            employeeM = new EmployeeManagement();
        }

        private void BtnNewEmployee_Click(object sender, EventArgs e)
        {
            string firstName = tbxFirstName.Text;
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Please enter a first name");
                return;
            }
            if (char.IsLower(firstName[0]))
            {
                char.ToUpper(firstName[0]);
            }

            string lastName = tbxLastName.Text;
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter a last name");
                return;
            }
            if (char.IsLower(lastName[0]))
            {
                char.ToUpper(lastName[0]);
            }

            string username = $"{char.ToLower(firstName[0])}{lastName.ToLower()}";
            string password = $"{char.ToLower(firstName[0])}{lastName.ToLower()}";
            int bsn = 0;


            try
            {
                bsn = Convert.ToInt32(tbxBSN.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid bsn");
            }

            if (bsn == 0)
            {
                MessageBox.Show("Please enter a bsn");
                return;
            }

            string city = tbxCity.Text;
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Please enter a city");
                return;
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
                return;
            }

            string personalEmail = tbxPersonalEmail.Text;
            if (string.IsNullOrEmpty(personalEmail))
            {
                MessageBox.Show("Please enter a personal email address");
            }

            string jobTitle = cbxJobTitle.SelectedItem.ToString();

            int workHoursPerWeek = Convert.ToInt32(tbxWorkHours.Text);
            if (workHoursPerWeek == 0)
            {
                MessageBox.Show("Please enter work hours per week");
            }

            double salary = Convert.ToDouble(tbxSalary.Text);
            if (salary == 0)
            {
                MessageBox.Show("Please enter salary");
            }

            string startDate = tbxStartDate.Text;
            string dateOfBirth = tbxDateOfBirth.Text;

            employeeM.CreateEmployee(firstName, lastName, bsn, city, email, dateOfBirth, personalEmail, username, password, phoneNumber, jobTitle, workHoursPerWeek, salary, startDate);
        }
        // create employee
        /*public void CreateEmployee()
        {
            try
            {
                int workHoursPerWeek = Convert.ToInt32(tbxWorkHours.Text);
                if (workHoursPerWeek == 0)
                {
                    MessageBox.Show("Please enter work hours per week");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Please put a number in Work hours");
                return;
            }

            try
            {
                int salary = Convert.ToInt32(tbxSalary.Text);
                if (salary == 0)
                {
                    MessageBox.Show("Please enter salary per hour");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Please put a number in Salary");
                return;
            }

            string jobTitle = cbxJobTitle.Text.ToString();
            if (string.IsNullOrEmpty(jobTitle))
            {
                MessageBox.Show("Please select a job title");
                return;
            }
            string startDate;
            if (Regex.IsMatch(tbxStartDate.Text, @"\d{4}\-(0[1-9]|1[012])\-(0[1-9]|[12][0-9]|3[01])$"))
            {
                startDate = tbxStartDate.Text;
                if (string.IsNullOrEmpty(startDate))
                {
                    MessageBox.Show("Please enter a start date");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter a VALID start birth");
                return;
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

                int employeeID = Convert.ToInt32(id);
                CreateContract(employeeID);

                string personalEmail = tbxPersonalEmail.Text;

                em.Email(password, username, personalEmail);
                MessageBox.Show("Email send");

                return;
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
        }*/
        // create contract
        /*public void CreateContract(int id)
        {
            


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
        }*/
    }
}
