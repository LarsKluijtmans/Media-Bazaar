using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormLogin : Form
    {
        Store store;
        public FormLogin()
        {
            InitializeComponent();
            store = new Store();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUserName.Text;
            string password = tbxPassword.Text;

            foreach (Employee ee in store.Employees)
            {
                if(ee.Username == username)
                {
                    if (ee.Password == password)
                    {
                        if (ee.Contract.Job.ToString() == "OWNER")
                        { 
                            /*Open admin tab*/
                        }
                        if (ee.Contract.Job.ToString() == "SALESMANAGER")
                        {
                            /*Open Sales Manager  tab*/
                        }
                        if (ee.Contract.Job.ToString() == "SALESEMPLOYEE")
                        {
                            /*Open Sales Employee tab*/
                        }
                        if (ee.Contract.Job.ToString() == "OFFICEMANAGER")
                        {
                            /*Open Office Manager  tab*/
                        }
                        if (ee.Contract.Job.ToString() == "OFFICEEMPLOYE")
                        {
                            /*Open Office Employee tab*/
                        }
                        if (ee.Contract.Job.ToString() == "DEPOTMANAGER")
                        {
                            /*Open Depot Manager tab*/
                        }
                        if (ee.Contract.Job.ToString() == "DEPOTEMPLOYEE")
                        {
                            /*Open Depot Employee tab*/
                        }

                        /**/
                    }
                }
            }
        }
    }
}
