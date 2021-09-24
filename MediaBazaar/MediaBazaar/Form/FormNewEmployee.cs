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
        List<Employee> employee;
        

        public FormNewEmployee()
        {
            InitializeComponent();
            employee = new List<Employee>();
         

        }

        private void BtnNewEmployee_Click(object sender, EventArgs e)
        {
            string firstN = txtFirstName.Text;
            string lastN = txtLastN.Text;
            int phoneN = Convert.ToInt32(txtPhoneN.Text);
            int bsn = Convert.ToInt32(txtBsn.Text);
            string username = txtUserN.Text;
            string email = txtEmail.Text;
            string password = txtPsswrd.Text;

            Employee newEmp = new Employee(firstN, lastN, phoneN, bsn, username, password, email);
            employee.Add(newEmp);
            OpenForm1(firstN, lastN, phoneN, bsn, username, email, password);

        }

        public void OpenForm1(string firstN, string lastN, int phoneN, int bsn, string username, string email, string password)
        {
            Form1 newEmployee = new Form1(firstN, lastN, phoneN, bsn, username, email, password);
            newEmployee.Show();
           
        }
    }
}
