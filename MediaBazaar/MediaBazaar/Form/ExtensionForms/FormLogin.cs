using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using ClassLibraryProject.Interfaces;
using ClassLibraryProject.ManagmentClasses;

namespace AdminBackups
{
    public partial class FormLogin : Form
    {
        Login login;
        Store store;
        public FormLogin()
        {
            InitializeComponent();

           login = new Login(new LoginManagment(new dbLoginManager()));
            store = new Store();
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

            int ID = login.GetID(UserName, Password);
            if (ID != 0)
            {
                Employee employee = login.CheckLogin(UserName, Password);
                switch (employee.Contract.JobTitle)
                {
                    case "CEO": MessageBox.Show("Please use the CEO application"); break;
                    case "ADMIN": Admin admin = new Admin(employee, store); Hide(); admin.Show(); break;
                    case "SALES MANAGER": SalesManager salesManager = new SalesManager(employee, store); Hide(); salesManager.Show(); break;
                    case "OFFICE MANAGER": OfficeManager officeManager = new OfficeManager(employee, store); Hide(); officeManager.Show(); break;
                    case "PRODUCT MANAGER": ProductManager officeEmployee = new ProductManager(employee, store); Hide(); officeEmployee.Show(); break;
                    case "DEPOT MANAGER": DepotManager depotManager = new DepotManager(employee, store);/* Hide();*/ depotManager.Show(); break;
                    case "DEPOT EMPLOYEE": DepotEmployee depotEmployee = new DepotEmployee(employee, store);/* Hide();*/ depotEmployee.Show(); break;
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

            int ID = login.GetID(UserName, Password);
            if (ID != 0)
            {
                Employee employee = login.CheckLogin(UserName, Password);
                switch (employee.Contract.JobTitle)
                {
                    case "CEO": MessageBox.Show("Please use the CEO application"); break;
                    case "ADMIN": Admin admin = new Admin(employee, store); Hide(); admin.Show(); break;
                    case "SALES MANAGER": SalesManager salesManager = new SalesManager(employee, store); Hide(); salesManager.Show(); break;
                    case "OFFICE MANAGER": OfficeManager officeManager = new OfficeManager(employee, store); Hide(); officeManager.Show(); break;
                    case "PRODUCT MANAGER": ProductManager officeEmployee = new ProductManager(employee, store); Hide(); officeEmployee.Show(); break;
                    case "DEPOT MANAGER": DepotManager depotManager = new DepotManager(employee, store);/* Hide();*/ depotManager.Show(); break;
                    case "DEPOT EMPLOYEE": DepotEmployee depotEmployee = new DepotEmployee(employee, store);/* Hide();*/ depotEmployee.Show(); break;
                    case "": MessageBox.Show("Wrong info!"); break;
                }
            }
            else
            {
                MessageBox.Show("Wrong login information! Please try again.");
            }
        }
    }
}
