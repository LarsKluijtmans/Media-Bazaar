using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;


namespace AdminBackups
{
    public partial class FromAdmin : Form
    {
        Employee admin;
        Store store;

        public FromAdmin(Employee admin, Store store)
        {
            InitializeComponent();
            this.admin = admin;
            this.store = store;

            if (AmountOfOfficeManagers() > 0)
            {
                gbMakeEmployee.Visible = false;
                labEmployeeAlreadyAdded.Visible = true;
            }
            else 
            {
                gbMakeEmployee.Visible = true;
                labEmployeeAlreadyAdded.Visible = false;
            }

        }

        //close
        protected override void OnClosing(CancelEventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
        }
        //Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Move to employee manager class
        private void BtnNewEmployee_Click(object sender, EventArgs e)
        {
            string firstName = tbxFirstName.Text;
            string lastName = tbxLastName.Text;
            string username = $"{lastName.ToLower()}";
            string password = $"{lastName.ToLower()}";
            int bsn = Convert.ToInt32(tbxBSN.Text);
            string city = tbxCity.Text;
            string email = $"{lastName.ToLower()}@mb.com";
            int phoneNumber = Convert.ToInt32(tbxPhoneNumber.Text);
            string dateOfBirth = tbxDateOfBirth.Text;

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

            tbxUsername.Text = username;
            tbxPassword.Text = password;
            tbxEmail.Text = email;

            Store store = new Store();

            store.emailManager.Email(password, username, email);
            MessageBox.Show("Email send");
        }
        private void btnAddContract_Click(object sender, EventArgs e)
        {
            int employeeID = Convert.ToInt32(tbxEmployeeID.Text);
            string jobTitle = cbxJobTitle.Text.ToString();
            int workHoursPerWeek = Convert.ToInt32(tbxWorkHours.Text);
            int salary = Convert.ToInt32(tbxSalary.Text);
            string startDate = tbxStartDate.Text;

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
                long id = cmd.LastInsertedId;

                tbxEmployeeID.Text = id.ToString();
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


        //Move to db class
        private int AmountOfOfficeManagers()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = "SELECT COUNT(employee.EmployeeID) FROM employee INNER JOIN contract on contract.employeeID = employee.EmployeeID WHERE jobtitle = 'OFFICE MANAGER';";
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();


                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    return Convert.ToInt16(reader[0]);
                }
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
            return 0;
        }
    }
}
