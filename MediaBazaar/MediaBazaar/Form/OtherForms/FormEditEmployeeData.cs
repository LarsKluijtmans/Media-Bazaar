using ClassLibraryProject.Class;
using System;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormEditEmployeeData : Form
    {
        Employee e;

        public FormEditEmployeeData(Employee e)
        {
            InitializeComponent();
            this.e = e;

            lblEmployeeName.Text = $"{e.FirstName} {e.LastName}";

            tbxEmployeeID.Text = e.EmployeeID.ToString();
            tbxFirstName.Text = e.FirstName;
            tbxLastName.Text = e.LastName;
            tbxPhoneNumber.Text = e.PhoneNumber.ToString();
            tbxEmail.Text = e.Email;
            tbxAddress.Text = e.City;
            tbxUsername.Text = e.Username;
            tbxPassword.Text = e.Password;
            tbxBSN.Text = e.BSN.ToString();
            tbxDateOfBirth.Text = e.DateOfBirth;
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            this.e.FirstName = tbxFirstName.Text;
            this.e.LastName = tbxLastName.Text;
            this.e.PhoneNumber = Convert.ToInt32(tbxPhoneNumber.Text);
            this.e.City = tbxAddress.Text;
            this.e.Username = tbxUsername.Text;
            this.e.Password = tbxPassword.Text;
        }
    }
}
