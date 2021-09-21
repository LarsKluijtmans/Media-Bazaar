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


            Employee e = new Employee("lars", "lars", 1231231234, "L", "1", Jobs.OWNER);
            store.AddEmployee(e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxID.Text);
            string password = tbxPassword.Text;

            foreach (Employee ee in store.Employees)
            {
                if(ee.EmployeeID == id)
                {
                    if (ee.Password == password)
                    {

                        switch (ee.Jobtitle.ToString())
                        {
                            case "OWNER": Form1 form1 = new Form1(store.GetEmployee(ee.EmployeeID),store); form1.Show(); break;
                            case "SALESMANAGER": FormSalesManager formSalesManager = new FormSalesManager(store.GetEmployee(ee.EmployeeID), store); formSalesManager.Show();  break;
                            case "SALESEMPLOYEE": FormSalesEmployee formSalesEmployee = new FormSalesEmployee(store.GetEmployee(ee.EmployeeID), store); formSalesEmployee.Show(); break;
                            case "OFFICEMANAGER": FormOfficeManager formOfficeManager = new FormOfficeManager(store.GetEmployee(ee.EmployeeID), store); formOfficeManager.Show(); break;
                            case "OFFICEEMPLOYE": FormOfficeEmployee formOfficeEmployee = new FormOfficeEmployee(store.GetEmployee(ee.EmployeeID), store); formOfficeEmployee.Show(); break;
                            case "DEPOTMANAGER": FormDepotManager formDepotManager = new FormDepotManager(store.GetEmployee(ee.EmployeeID), store); formDepotManager.Show(); break;
                            case "DEPOTEMPLOYEE": FormDepotEmployee formDepotEmployee = new FormDepotEmployee(store.GetEmployee(ee.EmployeeID), store); formDepotEmployee.Show(); break;
                        }
                    }
                }
            }
        }
    }
}
