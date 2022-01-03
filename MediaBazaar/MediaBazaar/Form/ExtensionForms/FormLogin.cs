using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
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
                    case "ADMIN": FormAdmin admin = new FromAdmin(employee, store); Hide(); admin.Show(); break;
                    case "SALES MANAGER": FormSalesManager salesManager = new FromSalesManager(employee, store); Hide(); salesManager.Show(); break;
                    case "OFFICE MANAGER": FormOfficeManager officeManager = new FromOfficeManager(employee, store); Hide(); officeManager.Show(); break;
                    case "PRODUCT MANAGER": FormProductManager officeEmployee = new FromProductManager(employee, store); Hide(); officeEmployee.Show(); break;
                    case "DEPOT MANAGER": FormDepotManager depotManager = new FromDepotManager(employee, store);/* Hide();*/ depotManager.Show(); break;
                    case "DEPOT EMPLOYEE": FormDepotEmployee depotEmployee = new FromDepotEmployee(employee, store);/* Hide();*/ depotEmployee.Show(); break;
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
                    case "ADMIN": FormAdmin admin = new FormAdmin(employee, store); Hide(); admin.Show(); break;
                    case "SALES MANAGER": FormSalesManager salesManager = new FromSalesManager(employee, store); Hide(); salesManager.Show(); break;
                    case "OFFICE MANAGER": FormOfficeManager officeManager = new FromOfficeManager(employee, store); Hide(); officeManager.Show(); break;
                    case "PRODUCT MANAGER": FormProductManager officeEmployee = new FromProductManager(employee, store); Hide(); officeEmployee.Show(); break;
                    case "DEPOT MANAGER": FormDepotManager depotManager = new FromDepotManager(employee, store);/* Hide();*/ depotManager.Show(); break;
                    case "DEPOT EMPLOYEE": FormDepotEmployee depotEmployee = new FromDepotEmployee(employee, store);/* Hide();*/ depotEmployee.Show(); break;
                    case "": MessageBox.Show("Wrong info!"); break;
                }
            }
            else
            {
                MessageBox.Show("Wrong login information! Please try again.");
            }
        }
        private void Login(string username, string password)
        {
            Employee employee = login.CheckLogin(username, password);

            if (employee != null)
            {
                if (employee is CEO)
                {
                    MessageBox.Show("Please use the CEO application");
                    return;
                } else if (employee is Admin)
                {
                    //Fo
                }
            }
        }
    }
}
