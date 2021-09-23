using System;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormLogin : Form
    {
        Store mediaBazaar;


        public FormLogin()
        {
            InitializeComponent();
            mediaBazaar = new Store();

            TestEmployees();
            

            Employee e = new Employee("Wolfs1", "Esther1", "F", 0612901749, "ewolfs@mb.com", "drunen", "01-01-1998", 1234, "esther", "wolfs", JobTitle.DEPOT_MANAGER);
            mediaBazaar.Employees.Add(e);

            UpdateListbox();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            foreach (Employee eee in mediaBazaar.Employees)
            {
                if (eee.Username == username && eee.Password == password)
                {
                        switch (eee.Type.ToString())
                        {
                            case "OWNER": Form1 form1 = new Form1(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); form1.Show(); break;
                            case "SALES_MANAGER": FormSalesManager formSalesManager = new FormSalesManager(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); formSalesManager.Show(); break;
                            case "SALES_EMPLOYEE": FormSalesEmployee formSalesEmployee = new FormSalesEmployee(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); formSalesEmployee.Show(); break;
                            case "OFFICE_MANAGER": FormOfficeManager formOfficeManager = new FormOfficeManager(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); formOfficeManager.Show(); break;
                            case "OFFICE_EMPLOYE": FormOfficeEmployee formOfficeEmployee = new FormOfficeEmployee(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); formOfficeEmployee.Show(); break;
                            case "DEPOT_MANAGER": FormDepotManager formDepotManager = new FormDepotManager(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); formDepotManager.Show(); break;
                            case "DEPOT_EMPLOYEE": FormDepotEmployee formDepotEmployee = new FormDepotEmployee(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); formDepotEmployee.Show(); break;
                        }
                } else
                {
                    MessageBox.Show("Wrong username/password");
                }
            }
        }
        public void TestEmployees()
        {
            mediaBazaar.AddEmployee("Wolfs", "Esther", "F", "ewolfs@mb.com", 0612901749, "Drunen", "01-01-1998", 1234, "esther", "wolfs", JobTitle.SALES_MANAGER);
            mediaBazaar.AddEmployee("2", "Employee", "M", "employee2@mb.com", 0643810212, "Eindhoven", "01-01-1998", 1234, "employee", "2", JobTitle.DEPOT_MANAGER);
            mediaBazaar.AddEmployee("3", "Employee", "X", "employee3@mb.com", 0689313810, "Den Bosch", "01-01-1998", 1234, "employee", "3", JobTitle.DEPOT_EMPLOYEE);
            mediaBazaar.AddEmployee("4", "Employee", "F", "employee4@mb.com", 0648936401, "Breda", "01-01-1998", 1234, "employee", "4", JobTitle.SALES_EMPLOYEE);
            mediaBazaar.AddEmployee("5", "Employee", "M", "employee5@mb.com", 0613861920, "Tilburg", "01-01-1998", 1234, "employee", "5", JobTitle.SALES_EMPLOYEE);
            mediaBazaar.AddEmployee("6", "Employee", "X", "employee6@mb.com", 0645739103, "Amsterdam", "01-01-1998", 1234, "employee", "6", JobTitle.SALES_MANAGER);
            mediaBazaar.AddEmployee("7", "Employee", "F", "employee7@mb.com", 0612345678, "Eindhoven", "01-01-1998", 1234, "employee", "7", JobTitle.OFFICE_EMPLOYEE);
            mediaBazaar.AddEmployee("8", "Employee", "F", "employee8@mb.com", 0647581639, "Eindhoven", "01-01-1998", 1234, "employee", "8", JobTitle.OFFICE_MANAGER);
            mediaBazaar.AddEmployee("9", "Employee", "M", "employee9@mb.com", 0658690364, "Amsterdam", "01-01-1998", 1234, "employee", "9", JobTitle.SALES_EMPLOYEE);
            mediaBazaar.AddEmployee("10", "Employee", "F", "employee10@mb.com", 0646123749, "Eindhoven", "01-01-1998", 1234, "employee", "10", JobTitle.SALES_EMPLOYEE);
        }
        private void UpdateListbox()
        {
            listBox1.Items.Clear();

            foreach (Employee e in mediaBazaar.Employees)
            {
                listBox1.Items.Add(e.ToString());
            }
        }
    }
}
