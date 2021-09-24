using System;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormLogin : Form
    {
        Store mediaBazaar;
        Employee employee;

        public FormLogin()
        {
            InitializeComponent();
            mediaBazaar = new Store();

            

            employee = new Employee("Wolfs1", "Esther1", "F", 0612901749, "ewolfs@mb.com", "drunen", "01-01-1998", 1234, "esther", "wolfs", JobTitle.DEPOT_MANAGER);
            mediaBazaar.Employees.Add(employee);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            FormSalesManager formSalesManager = new FormSalesManager(employee, mediaBazaar);
            formSalesManager.Show();

            //foreach (Employee eee in mediaBazaar.Employees)
            //{
            //    if (eee.Username == username && eee.Password == password)
            //    {
            //            switch (eee.Type.ToString())
            //            {
            //                case "OWNER": Form1 form1 = new Form1(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); form1.Show(); break;
            //                case "SALES_MANAGER": FormSalesManager formSalesManager = new FormSalesManager(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); formSalesManager.Show(); break;
            //                case "SALES_EMPLOYEE": FormSalesEmployee formSalesEmployee = new FormSalesEmployee(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); formSalesEmployee.Show(); break;
            //                case "OFFICE_MANAGER": FormOfficeManager formOfficeManager = new FormOfficeManager(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); formOfficeManager.Show(); break;
            //                case "OFFICE_EMPLOYE": FormOfficeEmployee formOfficeEmployee = new FormOfficeEmployee(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); formOfficeEmployee.Show(); break;
            //                case "DEPOT_MANAGER": FormDepotManager formDepotManager = new FormDepotManager(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); formDepotManager.Show(); break;
            //                case "DEPOT_EMPLOYEE": FormDepotEmployee formDepotEmployee = new FormDepotEmployee(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); formDepotEmployee.Show(); break;
            //            }
            //    } else
            //    {
            //        MessageBox.Show("Wrong username/password");
            //    }
            //}
        }
    }
}
