using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;

namespace AdminBackups
{
    public partial class FormAdminLogin : Form
    {
        Store store = new Store();
        public FormAdminLogin()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = tbxUsername.Text;
            if (string.IsNullOrEmpty(UserName))
            {
                MessageBox.Show("'UserName' field is required.");
                return;
            }

            string Password = tbxPassword.Text;
            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("'password' field is required.");
                return;
            }

            int ID = store.loginManagment.GetID(UserName, Password);
            if (ID != 0)
            {
                switch (store.loginManagment.CheckLogin(UserName, Password))
                {
                    case "CEO": MessageBox.Show("Please use the CEO application"); break;
                    case "ADMIN": AdminBackups admin = new AdminBackups(Convert.ToInt32(ID), store); Hide(); admin.Show(); break;
                    case "Wrong info!": MessageBox.Show("Wrong info!"); break;
                }
            }
            else
            {
                MessageBox.Show("Wrong login information! Please try again.");
            }
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            string UserName = tbxUsername.Text;
            if (string.IsNullOrEmpty(UserName))
            {
                MessageBox.Show("'UserName' field is required.");
                return;
            }

            string Password = tbxPassword.Text;
            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("'password' field is required.");
                return;
            }

            int ID = store.loginManagment.GetID(UserName, Password);
            if (ID != 0)
            {
                switch (store.loginManagment.CheckLogin(UserName, Password))
                {
                    case "CEO": MessageBox.Show("Please use the CEO application"); break;
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
