using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormEditEmployeeData : Form
    {
        Store mb;
        Employee e;

        public FormEditEmployeeData(Store mb, Employee e)
        {
            InitializeComponent();
            this.mb = mb;
            this.e = e;

            lblEmployeeName.Text = $"{e.FirstName} {e.LastName}";

            tbxEmployeeID.Text = e.EmployeeID.ToString();
            tbxFirstName.Text = e.FirstName;
            tbxLastName.Text = e.LastName;
            tbxGender.Text = e.Gender;
            tbxPhoneNumber.Text = e.PhoneNumber.ToString();
            tbxEmail.Text = e.Email;
            tbxAddress.Text = e.Address;
            tbxUsername.Text = e.Username;
            tbxPassword.Text = e.Password;
            cbxType.Text = e.Type.ToString();
            tbxBSN.Text = e.BSN.ToString();
            tbxDateOfBirth.Text = e.DateOfBirth;
        }
    }
}
