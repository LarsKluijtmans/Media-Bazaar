using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;


namespace AdminBackups
{
    public partial class FormAdmin : Form
    {
        Admin admin;
        Store store;

        public FormAdmin(Admin a, Store s)
        {
            InitializeComponent();
            this.admin = a;
            this.store = s;

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

        private void BtnNewEmployee_Click_1(object sender, EventArgs e)
        {
            //Employee
            string firstName = tbxFirstName.Text;
            string lastName = tbxLastName.Text;
            string username = $"{lastName.ToLower()}";
            string password = $"{lastName.ToLower()}";
            int bsn = Convert.ToInt32(tbxBSN.Text);
            string city = tbxCity.Text;
            string email = $"{lastName.ToLower()}@mb.com";
            int phoneNumber = Convert.ToInt32(tbxPhoneNumber.Text);
            string dateOfBirth = tbxDateOfBirth.Text;

            //contract 
            string jobTitle = cbxJobTitle.Text.ToString();
            int workHoursPerWeek = Convert.ToInt32(tbxWorkHours.Text);
            int salary = Convert.ToInt32(tbxSalary.Text);
            string startDate = tbxStartDate.Text;

            if (AmountOfOfficeManagers() != 0)
            {
                admin.addEmployee.AddEmployee();
            }
        }
    }
}
