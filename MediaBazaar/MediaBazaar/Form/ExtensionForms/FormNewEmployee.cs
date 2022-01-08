using ClassLibraryProject;
using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace AdminBackups
{
    public partial class FormNewEmployee : Form
    {
        OfficeManager officeManager;

        public FormNewEmployee(OfficeManager officeManager)
        {
            InitializeComponent();

            this.officeManager = officeManager;
        }

        private void BtnNewEmployee_Click(object sender, EventArgs e)
        {
            CreateEmployee();
            var formOfficeManager = Application.OpenForms.OfType<FormOfficeManager>().FirstOrDefault();
            formOfficeManager.ReadEmployees();
        }
        private void CreateEmployee()
        {
            // get all input 
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

            
            string phoneNumber = tbxPhoneNumber.Text;
            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter a phone number");
                return;
            }
            if (!Regex.IsMatch(tbxPhoneNumber.Text, @"^(\+)316[0-9]{8}$"))
            {
                MessageBox.Show("Please enter a valid phone number");
                return;
            }

            string email = $"{char.ToLower(firstName[0])}{lastName.ToLower()}@mb.com";
            
            
            string zipCode = tbxZipCode.Text;
            if (string.IsNullOrEmpty(zipCode))
            {
                MessageBox.Show("Please enter a zip code");
                return;
            }
            if (!Regex.IsMatch(tbxZipCode.Text, @"^[0-9]{4}[A-Z]{2}$"))
            {
                MessageBox.Show("Please enter a valid zip code");
                return;
            }


            string streetName = tbxAddress.Text;
            if (string.IsNullOrEmpty(streetName))
            {
                MessageBox.Show("Please enter a street name");
                return;
            }

            string city = tbxCity.Text;
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Please enter a city");
                return;
            }

            if (string.IsNullOrEmpty(tbxDateOfBirth.Text))
            {
                MessageBox.Show("Please enter a date of birth");
                return;
            }
            if (!Regex.IsMatch(tbxDateOfBirth.Text, @"((?:0[0-9])|(?:[1-2][0-9])|(?:3[0-1]))\/((?:0[1-9])|(?:1[0-2]))\/(\d{4})"))
            {
                MessageBox.Show("Please enter a valid date of birth");
                return;
            }
            DateTime dateOfBirth = DateTime.ParseExact(tbxDateOfBirth.Text, "dd/MM/yyyy", null);
            DateTime firstBirthDay = DateTime.Now.AddYears(-16);
            if (dateOfBirth > firstBirthDay)
            {
                MessageBox.Show("New employee should be at least 16 years old");
                return;
            }
            
            if (string.IsNullOrEmpty(tbxBSN.Text))
            {
                MessageBox.Show("Please enter a BSN");
                return;
            }
            if (!Regex.IsMatch(tbxBSN.Text, @"\b[0-9]{8,9}\b"))
            {
                MessageBox.Show("Please enter a valid BSN");
                return;
            }
            int bsn = Convert.ToInt32(tbxBSN.Text);

            string username = $"{char.ToLower(firstName[0])}{lastName.ToLower()}";
            string password = $"{char.ToLower(firstName[0])}{lastName.ToLower()}";

            string personalEmail = tbxPersonalEmail.Text;
            if (string.IsNullOrEmpty(personalEmail))
            {
                MessageBox.Show("Please enter a personal email");
                return;
            }
            if (!Regex.IsMatch(personalEmail, @"[a-z0-9]+(?:\.[a-z0-9]+)*@(?:[a-z](?:[a-z]*[a-z])?\.)nl|com"))
            {
                MessageBox.Show("Please enter a valid personal email");
                return;
            }

            // make the employee object

            Employee newEmployee;

            if (cbxJobTitle.SelectedIndex == 0)
            {
                newEmployee = new Admin(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                if (officeManager.EmployeeManagerOffice.CreateEmployee(newEmployee))
                {
                    if (CreateContract())
                    {
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {

                        }
                        else if (dr == DialogResult.No)
                        {
                            this.Close();
                        }
                    } else
                    {
                        return;
                    }
                }
            }
            else if (cbxJobTitle.SelectedIndex == 1)
            {
                newEmployee = new CEO(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                if (officeManager.EmployeeManagerOffice.CreateEmployee(newEmployee))
                {
                    if (CreateContract())
                    {
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {

                        }
                        else if (dr == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            } else if (cbxJobTitle.SelectedIndex == 2)
            {
                newEmployee = new SalesRepresentative(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                if (officeManager.EmployeeManagerOffice.CreateEmployee(newEmployee))
                {
                    if (CreateContract())
                    {
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {

                        }
                        else if (dr == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else if (cbxJobTitle.SelectedIndex == 3)
            {
                newEmployee = new SalesManager(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                if (officeManager.EmployeeManagerOffice.CreateEmployee(newEmployee))
                {
                    if (CreateContract())
                    {
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {

                        }
                        else if (dr == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else if (cbxJobTitle.SelectedIndex == 4)
            {
                newEmployee = new DepotEmployee(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                if (officeManager.EmployeeManagerOffice.CreateEmployee(newEmployee))
                {
                    if (CreateContract())
                    {
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {

                        }
                        else if (dr == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else if (cbxJobTitle.SelectedIndex == 5)
            {
                newEmployee = new DepotManager(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                if (officeManager.EmployeeManagerOffice.CreateEmployee(newEmployee))
                {
                    if (CreateContract())
                    {
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {

                        }
                        else if (dr == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else if (cbxJobTitle.SelectedIndex == 6)
            {
                newEmployee = new OfficeManager(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                if (officeManager.EmployeeManagerOffice.CreateEmployee(newEmployee))
                {
                    if (CreateContract())
                    {
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {

                        }
                        else if (dr == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else if (cbxJobTitle.SelectedIndex == 7)
            {
                newEmployee = new ProductManager(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                if (officeManager.EmployeeManagerOffice.CreateEmployee(newEmployee))
                {
                    if (CreateContract())
                    {
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {

                        }
                        else if (dr == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
        private bool CreateContract()
        {
            // get employee id for contract

            // get email
            string firstName = tbxFirstName.Text;
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Please enter a first name");
                return false;
            }

            string lastName = tbxLastName.Text;
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter a last name");
                return false;
            }

            string email = $"{char.ToLower(firstName[0])}{lastName.ToLower()}@mb.com";

            // get job title
            string jobTitle = "SALES REPRESENTATIVE";

            // get employee 
            Employee newEmployee = officeManager.EmployeeManagerOffice.GetEmployeeID(email, jobTitle);

            // get input for contract
            if (string.IsNullOrEmpty(tbxWorkHours.Text))
            {
                MessageBox.Show("Please enter work hours per week");
                return false;
            }
            int workHoursPerWeek = Convert.ToInt32(tbxWorkHours.Text);
            if (workHoursPerWeek % 4 != 0)
            {
                MessageBox.Show("Work hours has to be a multiple of 4");
                return false;
            }
            if (workHoursPerWeek == 0)
            {
                MessageBox.Show("Work hours must be at least 4 hours per week");
                return false;
            }

            if (string.IsNullOrEmpty(tbxSalary.Text))
            {
                MessageBox.Show("Please enter salary per hour");
                return false;
            }
            double salaryPerHour = Convert.ToDouble(tbxSalary.Text);

            if (string.IsNullOrEmpty(tbxStartDate.Text))
            {
                MessageBox.Show("Please enter a start date");
                return false;
            }
            if (!Regex.IsMatch(tbxStartDate.Text, @"((?:0[0-9])|(?:[1-2][0-9])|(?:3[0-1]))\/((?:0[1-9])|(?:1[0-2]))\/(\d{4})"))
            {
                MessageBox.Show("Please enter a valid start date");
                return false;
            }
            DateTime startDate = DateTime.ParseExact(tbxStartDate.Text, "dd/MM/yyyy", null);
            if (startDate < DateTime.Now)
            {
                MessageBox.Show("Start date must be in the future");
                return false;
            }

            if (string.IsNullOrEmpty(tbxEndDate.Text))
            {
                MessageBox.Show("Please enter an end date");
                return false;
            }
            if (!Regex.IsMatch(tbxEndDate.Text, @"((?:0[0-9])|(?:[1-2][0-9])|(?:3[0-1]))\/((?:0[1-9])|(?:1[0-2]))\/(\d{4})"))
            {
                MessageBox.Show("Please enter a valid end date");
                return false;
            }
            DateTime endDate = DateTime.ParseExact(tbxEndDate.Text, "dd/MM/yyyy", null);
            if (endDate < DateTime.Now)
            {
                MessageBox.Show("End date must be in the future");
                return false;
            }

            if (startDate > endDate)
            {
                MessageBox.Show("End date must be after start date");
                return false;
            }

            var contractDays = (endDate - startDate).TotalDays;
            if (contractDays > 365)
            {
                MessageBox.Show("Contract length can be max 1 year");
                return false;
            }

            string department = cbxDepartment.Text;
            if (string.IsNullOrEmpty(department))
            {
                MessageBox.Show("Please enter a department");
                return false;
            }

            Contract newContract = new Contract(newEmployee, jobTitle, workHoursPerWeek, salaryPerHour, startDate, endDate, department);

            return officeManager.ContractManager.CreateContract(newContract);
        }
    }
}
