using ClassLibraryProject;
using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace AdminBackups
{
    public partial class FormNewEmployee : Form
    {
        OfficeManager officeManager;
        Store store;

        public FormNewEmployee(OfficeManager officeManager, Store s)
        {
            InitializeComponent();

            this.officeManager = officeManager;
            store = s;
            AddDepartment();
        }

        //Create employee
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
            DateTime dateOfBirth = new DateTime(1000, 1, 1);
            try
            {
                DateTime MakeDate = Convert.ToDateTime(tbxDateOfBirth.Value.ToString());

                dateOfBirth = Convert.ToDateTime(MakeDate.ToString("yyyy/MM/dd"));

                DateTime firstBirthDay = DateTime.Now.AddYears(-16);
                if (dateOfBirth > firstBirthDay)
                {
                    MessageBox.Show("New employee should be at least 16 years old");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid date of birth");
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

            int bsn = 0;
            try
            {
                bsn = Convert.ToInt32(tbxBSN.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid BSN");
                return;
            }

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
                        store.emailManager.NewEmployeeInfoEmail(newEmployee);
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.No)
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
                        store.emailManager.NewEmployeeInfoEmail(newEmployee);
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.No)
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
                        store.emailManager.NewEmployeeInfoEmail(newEmployee);
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.No)
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
                        store.emailManager.NewEmployeeInfoEmail(newEmployee);
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.No)
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
                        store.emailManager.NewEmployeeInfoEmail(newEmployee);
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.No)
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
                        store.emailManager.NewEmployeeInfoEmail(newEmployee);
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.No)
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
                        store.emailManager.NewEmployeeInfoEmail(newEmployee);
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                         if (dr == DialogResult.No)
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
                        store.emailManager.NewEmployeeInfoEmail(newEmployee);
                        DialogResult dr = MessageBox.Show("Do you want to add another employee?", "Employee Added", MessageBoxButtons.YesNo);

                         if (dr == DialogResult.No)
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
            string jobTitle = cbxJobTitle.Text;

            // get employee 
            Employee newEmployee = officeManager.EmployeeManagerOffice.GetEmployeeID(email, jobTitle);

            // get input for contract
            if (string.IsNullOrEmpty(tbxWorkHours.Text))
            {
                MessageBox.Show("Please enter work hours per week");
                return false;
            }

            int workHoursPerWeek = 0;
            try
            {
                workHoursPerWeek = Convert.ToInt32(tbxWorkHours.Text);
            }
            catch
            {
                MessageBox.Show("Please enter valid work hours per week");
                return false;
            }

            if (workHoursPerWeek < 8)
            {
                MessageBox.Show("Work hours has to be atleast 8");
                return false;
            }
            if (workHoursPerWeek > 40)
            {
                MessageBox.Show("Max work hours is 40");
                return false;
            }
            if (workHoursPerWeek % 4 != 0)
            {
                MessageBox.Show("Work hours has to be a multiple of 4");
                return false;
            }

            if (string.IsNullOrEmpty(tbxSalary.Text))
            {
                MessageBox.Show("Please enter salary per hour");
                return false;
            }
            double salaryPerHour = 0;
            try
            {
                salaryPerHour = Convert.ToDouble(tbxSalary.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid salary per hour");
                return false;
            }

            if (salaryPerHour > 5)
            {
                MessageBox.Show("Min salary is 5");
                return false;
            }
            if (salaryPerHour > 200)
            {
                MessageBox.Show("Max salary is 200");
                return false;
            }
            if (string.IsNullOrEmpty(tbxStartDate.Text))
            {
                MessageBox.Show("Please enter a start date");
                return false;
            }

            DateTime startDate = new DateTime(1000, 1, 1);
            try
            {
                DateTime MakeDate = Convert.ToDateTime(tbxStartDate.Value.ToString());

                startDate = Convert.ToDateTime(MakeDate.ToString("yyyy/MM/dd"));

                if (startDate < DateTime.Now)
                {
                    MessageBox.Show("Start date must be in the future");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid start birth");
                return false;
            }

            DateTime endDate = new DateTime(1000, 1, 1);
            try
            {
                DateTime MakeDate = Convert.ToDateTime(tbxEndDate.Value.ToString());

                endDate = Convert.ToDateTime(MakeDate.ToString("yyyy/MM/dd"));

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
                if (contractDays > 3650)
                {
                    MessageBox.Show("Contract length can be max 10 year");
                    return false;
                }

                var contractMonth = (endDate.Month - startDate.Month);
                if (contractDays > 3)
                {
                    MessageBox.Show("Contract length can be min 3 months");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid start birth");
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

        //Departments
        private void AddDepartment()
        {
            cbxDepartment.Items.Clear();

            try
            {
                foreach (DataRow r in officeManager.departmentManagment.ViewAllDepartments().Rows)
                {
                    if (Convert.ToInt16(r[0]) > 4)
                    {
                        if (cbxJobTitle.Text == "SALES REPRESENTATIVE" || cbxJobTitle.Text == "SALES MANAGER")
                        {
                            if (r[1].ToString() == "Sales")
                            {
                                Department d = new Department(
                                r[0].ToString(),
                                r[1].ToString(),
                                r[2].ToString()); cbxDepartment.Items.Add(d);
                            }
                        }
                        else if (cbxJobTitle.Text == "DEPOT EMPLOYEE" || cbxJobTitle.Text == "DEPOT MANAGER" || cbxJobTitle.Text == "PRODUCT MANAGER")
                        {
                            if (r[1].ToString() == "Depot")
                            {
                                Department d = new Department(
                                r[0].ToString(),
                                r[1].ToString(),
                                r[2].ToString()); cbxDepartment.Items.Add(d);
                            }
                        }
                        else if (cbxJobTitle.Text == "OFFICE MANAGER")
                        {
                            if (r[1].ToString() == "Office")
                            {
                                Department d = new Department(
                                r[0].ToString(),
                                r[1].ToString(),
                                r[2].ToString()); cbxDepartment.Items.Add(d);
                            }
                        }
                        else if (cbxJobTitle.Text == "CEO" || cbxJobTitle.Text == "ADMIN")
                        {
                            if (r[1].ToString() == "Other")
                            {
                                Department d = new Department(
                                r[0].ToString(),
                                r[1].ToString(),
                                r[2].ToString()); cbxDepartment.Items.Add(d);
                            }
                        }
                    }
                }

                if (cbxJobTitle.Text == "SALES REPRESENTATIVE" || cbxJobTitle.Text == "SALES MANAGER")
                {
                    if (cbxDepartment.Items.Count == 0)
                    {
                        cbxDepartment.Items.Add("Sales");
                    }
                }
                else if (cbxJobTitle.Text == "DEPOT EMPLOYEE" || cbxJobTitle.Text == "DEPOT MANAGER" || cbxJobTitle.Text == "PRODUCT MANAGER")
                {
                    if (cbxDepartment.Items.Count == 0)
                    {
                        cbxDepartment.Items.Add("Depot");
                    }
                }
                else if (cbxJobTitle.Text == "OFFICE MANAGER")
                {
                    if (cbxDepartment.Items.Count == 0)
                    {
                        cbxDepartment.Items.Add("Office");
                    }
                }
                else if (cbxJobTitle.Text == "CEO" || cbxJobTitle.Text == "ADMIN")
                {
                    if (cbxDepartment.Items.Count == 0)
                    {
                        cbxDepartment.Items.Add("Other");
                    }
                }
                cbxDepartment.Text = cbxDepartment.Items[0].ToString();
            } catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            
        }
        private void cbxJobTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDepartment();
        }
    }
}
