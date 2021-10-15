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
    public partial class FormViewEmployee : Form
    {
        Person p;
        Contract c;
        public FormViewEmployee(Person p)
        {
            InitializeComponent();
            this.p = p;
            //this.c = c;

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
            //cbxJobTitle.Text = c.JobTitle;
            //tbxWorkHours.Text = c.WorkHoursPerWeek.ToString();
            //tbxSalary.Text = c.SalaryPerHour.ToString();
            //tbxStartDate.Text = c.StartDate;
        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            string employeeID = tbxEmployeeID.Text;
            string firstName = tbxFirstName.Text;
            string lastName = tbxLastName.Text;
            string city = tbxCity.Text;
            string phoneNumber = tbxPhoneNumber.Text;

            MySqlConnection conn = Utils.GetConnection();
            string sql = "Utils.UPDATE_EMPLOYEE";
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
