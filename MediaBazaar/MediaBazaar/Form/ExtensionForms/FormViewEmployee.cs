using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using MySql.Data.MySqlClient;


namespace AdminBackups
{
    public partial class FormViewEmployee : Form
    {
        OfficeManager officeManager;
        Employee employee;
        Contract contract;
        public FormViewEmployee(OfficeManager om, Employee e, Contract c)
        {
            InitializeComponent();
            this.officeManager = om;
            this.employee = e;
            this.contract = c;

            this.Text = $"{employee.FirstName} {employee.LastName}";

            LoadEmployeeInfo();
        }
        private void LoadEmployeeInfo()
        {
            // employee
            tbxEmployeeID.Text = employee.EmployeeID.ToString(); // read only
            tbxFirstName.Text = employee.FirstName;
            tbxLastName.Text = employee.LastName;
            tbxPhoneNumber.Text = employee.PhoneNumber;
            tbxEmail.Text = employee.Email; //
            tbxPersonalEmail.Text = employee.PersonalEmail;
            tbxUsername.Text = employee.Username; //
            tbxDateOfBirth.Text = employee.DateOfBirth.ToString("dd-MM-yyyy"); //
            tbxBSN.Text = employee.BSN.ToString(); //
            tbxCity.Text = employee.City;
            tbxAddress.Text = employee.Address;
            tbxZipCode.Text = employee.ZipCode;

            // contract
            tbxJobTitle.Text = contract.JobTitle.ToLower();
            tbxWorkHours.Text = contract.WorkHoursPerWeek.ToString();
            tbxSalary.Text = contract.SalaryPerHour.ToString();
            tbxStartDate.Text = contract.StartDate.ToString("dd-MM-yyyy");
            tbxEndDate.Text = contract.EndDate.ToString("dd-MM-yyyy");
        }
        private void btnEditData_Click(object sender, EventArgs e)
        {
            UpdateEmployee();
            var formOfficeManager = Application.OpenForms.OfType<FormOfficeManager>().FirstOrDefault();
            formOfficeManager.ReadEmployees();

            this.Close();
        }
        public void UpdateEmployee()
        {
            if (string.IsNullOrEmpty(tbxFirstName.Text))
            {
                MessageBox.Show("First name cannot be empty");
                return;
            }
            employee.FirstName = tbxFirstName.Text;

            if (string.IsNullOrEmpty(tbxLastName.Text))
            {
                MessageBox.Show("Last name cannot be empty");
                return;
            }
            employee.LastName = tbxLastName.Text;

            if (string.IsNullOrEmpty(tbxPhoneNumber.Text))
            {
                MessageBox.Show("Phone number cannot be empty");
                return;
            }
            if (!Regex.IsMatch(tbxPhoneNumber.Text, @"^(\+)316[0-9]{8}$"))
            {
                MessageBox.Show("Please enter a valid phone number");
                return;
            }
            employee.PhoneNumber = tbxPhoneNumber.Text;

            if (string.IsNullOrEmpty(tbxPersonalEmail.Text))
            {
                MessageBox.Show("Personal email cannot be empty");
                return;
            }
            if (!Regex.IsMatch(tbxPersonalEmail.Text, @"[a-z0-9]+(?:\.[a-z0-9]+)*@(?:[a-z](?:[a-z]*[a-z])?\.)nl|com"))
            {
                MessageBox.Show("Please enter a valid personal email");
                return;
            }
            employee.PersonalEmail = tbxPersonalEmail.Text;

            if (string.IsNullOrEmpty(tbxCity.Text))
            {
                MessageBox.Show("City cannot be empty");
                return;
            }
            employee.City = tbxCity.Text;

            if (string.IsNullOrEmpty(tbxAddress.Text))
            {
                MessageBox.Show("Address cannot be empty");
                return;
            }
            employee.Address = tbxAddress.Text;

            if (string.IsNullOrEmpty(tbxZipCode.Text))
            {
                MessageBox.Show("Zip Code cannot be empty");
                return; 
            }
            if (!Regex.IsMatch(tbxZipCode.Text, @"^[0-9]{4}[A-Z]{2}$"))
            {
                MessageBox.Show("Please enter a valid zip code");
                return;
            }
            employee.ZipCode = tbxZipCode.Text;

            officeManager.EmployeeManagerOffice.UpdateEmployee(employee);
        }  
        public void CreateNewContract()
        {
            
        }
    }
}
