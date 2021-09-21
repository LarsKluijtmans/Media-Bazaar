using System;
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


            Employee e = new Employee("lars", "lars", 1231231234, "L", "a");
            store.Employees.Add(e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = tbxUsername.Text;
            string password = tbxPassword.Text;

            foreach (Employee eee in store.Employees)
            {
                if (eee.Username == Username)
                {
                    if (eee.Password == password)
                    {

                        switch (eee.Jobtitle.ToString())
                        {
                            case "OWNER": Form1 form1 = new Form1(store.GetEmployee(eee.EmployeeID), store); form1.Show(); break;
                            case "SALESMANAGER": FormSalesManager formSalesManager = new FormSalesManager(store.GetEmployee(eee.EmployeeID), store); formSalesManager.Show(); break;
                            case "SALESEMPLOYEE": FormSalesEmployee formSalesEmployee = new FormSalesEmployee(store.GetEmployee(eee.EmployeeID), store); formSalesEmployee.Show(); break;
                            case "OFFICEMANAGER": FormOfficeManager formOfficeManager = new FormOfficeManager(store.GetEmployee(eee.EmployeeID), store); formOfficeManager.Show(); break;
                            case "OFFICEEMPLOYE": FormOfficeEmployee formOfficeEmployee = new FormOfficeEmployee(store.GetEmployee(eee.EmployeeID), store); formOfficeEmployee.Show(); break;
                            case "DEPOTMANAGER": FormDepotManager formDepotManager = new FormDepotManager(store.GetEmployee(eee.EmployeeID), store); formDepotManager.Show(); break;
                            case "DEPOTEMPLOYEE": FormDepotEmployee formDepotEmployee = new FormDepotEmployee(store.GetEmployee(eee.EmployeeID), store); formDepotEmployee.Show(); break;
                        }
                    }
                }
            }
        }
    }
}
