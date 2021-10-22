using acr122_demo.Class;
using CardReader;
using CardReader.Class;
using MySql.Data.MySqlClient;
using Sydesoft.NfcDevice;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace acr122_demo
{
    public partial class Form1 : Form
    {
        LoginManagement loginManagment = new LoginManagement();
        public Form1()
        {
            InitializeComponent();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = tbUsername.Text;
            if (string.IsNullOrEmpty(UserName))
            {
                MessageBox.Show("'UserName' field is required.");
                return;
            }

            string Password = tbPassword.Text;
            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("'password' field is required.");
                return;
            }

            int ID = loginManagment.GetID(UserName, Password);
            if (ID != 0)
            {
                switch (loginManagment.checkLogin(UserName, Password))
                {
                    case "OFFICE MANAGER": EmployeeCard emp = new EmployeeCard(); Hide(); emp.Show(); break;
                    case "Wrong info!": MessageBox.Show("Wrong info!"); break;
                }
            }
            else
            {
                MessageBox.Show("Wrong login information! Please try again.");
            }
        }
    }
}
