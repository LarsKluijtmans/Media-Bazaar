using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MediaBazaar.Class;


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
            CreateContract();
        }
        public void CreateEmployee()
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
        public void CreateContract()
        {
            int employeeID = Convert.ToInt32(tbxEmployeeID.Text);
            string jobTitle = cbxJobTitle.SelectedItem.ToString();
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

                //int numCreatedRows = cmd.ExecuteNonQuery();
                //long id = cmd.LastInsertedId;

                //tbxEmployeeID.Text = id.ToString();
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
