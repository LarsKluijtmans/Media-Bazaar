using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormNewEmployee : Form
    {
        Store mediaBazaar;
        public FormNewEmployee(Store mb)
        {
            InitializeComponent();
            this.mediaBazaar = mb;
        }

        private void BtnNewEmployee_Click(object sender, EventArgs e)
        {
            string lastName = tbxLastName.Text;
            string firstName = tbxFirstName.Text;
            string gender = tbxGender.Text;
            int phoneNumber = Convert.ToInt32(tbxPhoneNumber.Text);
            string email = $"{tbxLastName.Text}@mb.com";
            string address = tbxAddress.Text;
            string dateOfBirth = tbxDateOfBirth.Text;
            int bsn = Convert.ToInt32(tbxBSN.Text);
            string username = $"{tbxLastName.Text}";
            string password = $"{tbxLastName.Text}";
            JobTitle type = (JobTitle)Enum.Parse(typeof(JobTitle), cbxType.SelectedItem.ToString());

            Employee newEmployee = new Employee(lastName, firstName, gender, phoneNumber, email, address, dateOfBirth, bsn, username, password, type);
            mediaBazaar.AddEmployee(newEmployee);

            tbxEmployeeID.Text = newEmployee.EmployeeID.ToString();
        }
    }
}
