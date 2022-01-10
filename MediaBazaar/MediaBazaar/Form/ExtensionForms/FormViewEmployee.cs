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
        public FormViewEmployee(OfficeManager om, Employee e)
        {
            InitializeComponent();
            this.officeManager = om;
            this.employee = e;

            employee.Contracts = employee.EmployeeManagerAll.GetEmployeeContracts(employee);
            
            foreach (Contract c in employee.Contracts)
            {
                if (c.IsActive)
                {
                    this.contract = c;
                }
            }

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
            if (contract != null)
            {
                this.Text = contract.ContractID.ToString();
                tbxJobTitle.Text = contract.JobTitle.ToLower();
                tbxWorkHours.Text = contract.WorkHoursPerWeek.ToString();
                tbxSalary.Text = contract.SalaryPerHour.ToString();
                tbxStartDate.Text = contract.StartDate.ToString("dd-MM-yyyy");
                tbxEndDate.Text = contract.EndDate.ToString("dd-MM-yyyy");
            }
        }
        private void btnEditData_Click(object sender, EventArgs e)
        {
            if (!UpdateEmployee())
            {
                return;
            }

            var formOfficeManager = Application.OpenForms.OfType<FormOfficeManager>().FirstOrDefault();
            formOfficeManager.ReadEmployees();

            this.Close();
        }
        public bool UpdateEmployee()
        {
            if (string.IsNullOrEmpty(tbxFirstName.Text))
            {
                MessageBox.Show("First name cannot be empty");
                return false;
            }
            employee.FirstName = tbxFirstName.Text;

            if (string.IsNullOrEmpty(tbxLastName.Text))
            {
                MessageBox.Show("Last name cannot be empty");
                return false;
            }
            employee.LastName = tbxLastName.Text;

            if (string.IsNullOrEmpty(tbxPhoneNumber.Text))
            {
                MessageBox.Show("Phone number cannot be empty");
                return false;
            }
            if (!Regex.IsMatch(tbxPhoneNumber.Text, @"^(\+)316[0-9]{8}$"))
            {
                MessageBox.Show("Please enter a valid phone number");
                return false;
            }
            employee.PhoneNumber = tbxPhoneNumber.Text;

            if (string.IsNullOrEmpty(tbxPersonalEmail.Text))
            {
                MessageBox.Show("Personal email cannot be empty");
                return false;
            }
            if (!Regex.IsMatch(tbxPersonalEmail.Text, @"[a-z0-9]+(?:\.[a-z0-9]+)*@(?:[a-z](?:[a-z]*[a-z])?\.)nl|com"))
            {
                MessageBox.Show("Please enter a valid personal email");
                return false;
            }
            employee.PersonalEmail = tbxPersonalEmail.Text;

            if (string.IsNullOrEmpty(tbxCity.Text))
            {
                MessageBox.Show("City cannot be empty");
                return false;
            }
            employee.City = tbxCity.Text;

            if (string.IsNullOrEmpty(tbxAddress.Text))
            {
                MessageBox.Show("Address cannot be empty");
                return false;
            }
            employee.Address = tbxAddress.Text;

            if (string.IsNullOrEmpty(tbxZipCode.Text))
            {
                MessageBox.Show("Zip Code cannot be empty");
                return false; 
            }
            if (!Regex.IsMatch(tbxZipCode.Text, @"^[0-9]{4}[A-Z]{2}$"))
            {
                MessageBox.Show("Please enter a valid zip code");
                return false;
            }
            employee.ZipCode = tbxZipCode.Text;

            return officeManager.EmployeeManagerOffice.UpdateEmployee(employee);
        }  
        public void CreateNewContract()
        {
            if (contract != null)
            {
                contract.IsActive = false;

                officeManager.ContractManager.UpdateContract(contract);
            }

            // get input for new contract
            string jobTitle = tbxJobTitle.Text;
            if (string.IsNullOrEmpty(jobTitle))
            {
                MessageBox.Show("Please enter a jobtitle");
                return;
            }

            if (string.IsNullOrEmpty(tbxWorkHours.Text))
            {
                MessageBox.Show("Please enter work hours per week");
                return;
            }
            int workHoursPerWeek = Convert.ToInt32(tbxWorkHours.Text);
            if (workHoursPerWeek % 4 != 0)
            {
                MessageBox.Show("Work hours has to be a multiple of 4");
                return;
            }
            if (workHoursPerWeek == 0)
            {
                MessageBox.Show("Work hours must be at least 4 hours per week");
                return;
            }

            if (string.IsNullOrEmpty(tbxSalary.Text))
            {
                MessageBox.Show("Please enter salary per hour");
                return;
            }
            double salaryPerHour = Convert.ToDouble(tbxSalary.Text);

            if (string.IsNullOrEmpty(tbxStartDate.Text))
            {
                MessageBox.Show("Please enter a start date");
                return;
            }
            if (!Regex.IsMatch(tbxStartDate.Text, @"((?:0[0-9])|(?:[1-2][0-9])|(?:3[0-1]))\/((?:0[1-9])|(?:1[0-2]))\/(\d{4})"))
            {
                MessageBox.Show("Please enter a valid start date");
                return;
            }
            DateTime startDate = DateTime.ParseExact(tbxStartDate.Text, "dd/MM/yyyy", null);
            if (startDate < DateTime.Now)
            {
                MessageBox.Show("Start date must be in the future");
                return;
            }

            if (string.IsNullOrEmpty(tbxEndDate.Text))
            {
                MessageBox.Show("Please enter an end date");
                return;
            }
            if (!Regex.IsMatch(tbxEndDate.Text, @"((?:0[0-9])|(?:[1-2][0-9])|(?:3[0-1]))\/((?:0[1-9])|(?:1[0-2]))\/(\d{4})"))
            {
                MessageBox.Show("Please enter a valid end date");
                return;
            }
            DateTime endDate = DateTime.ParseExact(tbxEndDate.Text, "dd/MM/yyyy", null);
            if (endDate < DateTime.Now)
            {
                MessageBox.Show("End date must be in the future");
                return;
            }

            if (startDate > endDate)
            {
                MessageBox.Show("End date must be after start date");
                return;
            }

            var contractDays = (endDate - startDate).TotalDays;
            if (contractDays > 365)
            {
                MessageBox.Show("Contract length can be max 1 year");
                return;
            }

            string department = cbxDepartment.Text;
            if (string.IsNullOrEmpty(department))
            {
                MessageBox.Show("Please enter a department");
                return;
            }

            Contract newContract = new Contract(employee, jobTitle, workHoursPerWeek, salaryPerHour, startDate, endDate, department);
            officeManager.ContractManager.CreateContract(newContract);
        }

        /*private bool CreateContract()
        {


            string department = cbxDepartment.Text;
            if (string.IsNullOrEmpty(department))
            {
                MessageBox.Show("Please enter a department");
                return false;
            }

            Contract newContract = new Contract(newEmployee, jobTitle, workHoursPerWeek, salaryPerHour, startDate, endDate, department);

            return officeManager.ContractManager.CreateContract(newContract);
        }*/
    }
}
