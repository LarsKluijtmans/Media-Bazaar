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

            foreach (Employee e in store.Employees)
            {
                if(e.N)
            }
        }
    }
}
