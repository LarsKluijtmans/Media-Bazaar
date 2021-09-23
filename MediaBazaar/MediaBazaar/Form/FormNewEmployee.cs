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
        Store mb;
        public FormNewEmployee(Store mb)
        {
            InitializeComponent();
            this.mb = mb;
        }


        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            string firstName = tbxFirstName.Text;
            string lastName = tbxLastName.Text;
            string email = tbxEmail.Text;
            int phoneNumber = Convert.ToInt32(tbxPhoneNumber.Text);
            string address = tbxAddress.Text;
            int bsn = Convert.ToInt32(tbxBSN.Text);
            string username = tbxEmail.Text;
            string password = tbxPassword.Text;
        }
    }
}
