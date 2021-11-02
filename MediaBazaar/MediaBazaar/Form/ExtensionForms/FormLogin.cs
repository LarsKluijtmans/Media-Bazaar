using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;

namespace MediaBazaar
{
    public partial class FormLogin : Form
    {
        Store store = new Store();
        public FormLogin()
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
                switch (store.loginManagment.checkLogin(UserName, Password))
                {
                    case "CEO": MessageBox.Show("Please use the CEO application"); break;
                    case "ADMIN": Admin admin = new Admin(Convert.ToInt32(ID), store); Hide(); admin.Show(); break;
                    case "SALES MANAGER": SalesManager salesManager = new SalesManager(Convert.ToInt32(ID), store); Hide(); salesManager.Show(); break;
                    case "OFFICE MANAGER": OfficeManager officeManager = new OfficeManager(Convert.ToInt32(ID), store); Hide(); officeManager.Show(); break;
                    case "PRODUCT MANAGER": ProductManager officeEmployee = new ProductManager(Convert.ToInt32(ID), store); Hide(); officeEmployee.Show(); break;
                    case "DEPOT MANAGER": DepotManager depotManager = new DepotManager(Convert.ToInt32(ID), store);/* Hide();*/ depotManager.Show(); break;
                    case "DEPOT EMPLOYEE": DepotEmployee depotEmployee = new DepotEmployee(Convert.ToInt32(ID), store);/* Hide();*/ depotEmployee.Show(); break;
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
                switch (store.loginManagment.checkLogin(UserName, Password))
                {
                    case "CEO": MessageBox.Show("Please use the CEO application"); break;
                    case "ADMIN": Admin admin = new Admin(Convert.ToInt32(ID), store); Hide(); admin.Show(); break;
                    case "SALES MANAGER": SalesManager salesManager = new SalesManager(Convert.ToInt32(ID), store); Hide(); salesManager.Show(); break;
                    case "OFFICE MANAGER": OfficeManager officeManager = new OfficeManager(Convert.ToInt32(ID), store); Hide(); officeManager.Show(); break;
                    case "PRODUCT MANAGER": ProductManager officeEmployee = new ProductManager(Convert.ToInt32(ID), store); Hide(); officeEmployee.Show(); break;
                    case "DEPOT MANAGER": DepotManager depotManager = new DepotManager(Convert.ToInt32(ID), store);/* Hide();*/ depotManager.Show(); break;
                    case "DEPOT EMPLOYEE": DepotEmployee depotEmployee = new DepotEmployee(Convert.ToInt32(ID), store);/* Hide();*/ depotEmployee.Show(); break;
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
