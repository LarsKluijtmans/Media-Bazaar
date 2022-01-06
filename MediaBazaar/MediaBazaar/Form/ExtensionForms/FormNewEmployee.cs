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

            // fix
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

            // make the employee object

            Employee newEmployee;

            if (cbxJobTitle.SelectedIndex == 0)
            {
                newEmployee = new Admin(username, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
            }
            else if (cbxJobTitle.SelectedIndex == 1)
            {
                newEmployee = new CEO(username, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
            } else if (cbxJobTitle.SelectedIndex == 2)
            {
                newEmployee = new SalesRepresentative(username, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
            }
            else if (cbxJobTitle.SelectedIndex == 3)
            {
                newEmployee = new SalesManager(username, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
            }
            else if (cbxJobTitle.SelectedIndex == 4)
            {
                newEmployee = new DepotEmployee(username, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
            }
            else if (cbxJobTitle.SelectedIndex == 5)
            {
                newEmployee = new DepotManager(username, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
            }
            else if (cbxJobTitle.SelectedIndex == 6)
            {
                newEmployee = new OfficeManager(username, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
            }
            else if (cbxJobTitle.SelectedIndex == 7)
            {
                newEmployee = new ProductManager(username, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
            }
        }
        private void CreateContract()
        {
            // get employee id for contract

            // get email
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

            string email = $"{char.ToLower(firstName[0])}{lastName.ToLower()}@mb.com";

            
        }
    }
}
