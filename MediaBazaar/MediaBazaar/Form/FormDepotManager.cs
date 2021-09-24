using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormDepotManager : Form
    {
        Employee e;
        Store mediaBazaar;

        private List<Product> porductRequests;
        private List<Product> porductRestock;
        private string productN;
        private ProductType productType;
        private int productA;

        public FormDepotManager(Employee employee, Store store)
        {
            InitializeComponent();
            porductRequests = new List<Product>();
            porductRestock = new List<Product>();
            this.mediaBazaar = store;
            employee = e;

            TestEmployees();
            UpdateListbox();
        }

        public void AddRequesteProduct(int amount, int productid)
        { 
            foreach(Product p in mediaBazaar.Products)
            {
                if (p.ProductID == productid)
                {
                    Product prod = new Product(p.Barcode, p.Name, p.ProductType, amount);
                    /*add p to listbox*/
                }
            }
        }
        // employees
        public void TestEmployees()
        {
            mediaBazaar.AddEmployee("Wolfs", "Esther", "F", "ewolfs@mb.com", 0612901749, "Drunen", "01-01-1998", 1234, "esther", "wolfs", JobTitle.SALES_MANAGER);
            mediaBazaar.AddEmployee("2", "Employee", "M", "employee2@mb.com", 0643810212, "Eindhoven", "01-01-1998", 1234, "employee", "2", JobTitle.DEPOT_MANAGER);
            mediaBazaar.AddEmployee("3", "Employee", "X","employee3@mb.com", 0689313810, "Den Bosch", "01-01-1998", 1234, "employee", "3", JobTitle.DEPOT_EMPLOYEE);
            mediaBazaar.AddEmployee("4", "Employee", "F", "employee4@mb.com", 0648936401, "Breda", "01-01-1998", 1234, "employee", "4", JobTitle.SALES_EMPLOYEE);
            mediaBazaar.AddEmployee("5", "Employee", "M", "employee5@mb.com", 0613861920, "Tilburg", "01-01-1998", 1234, "employee", "5", JobTitle.SALES_EMPLOYEE);
            mediaBazaar.AddEmployee("6", "Employee", "X", "employee6@mb.com", 0645739103, "Amsterdam", "01-01-1998", 1234, "employee", "6", JobTitle.SALES_MANAGER);
            mediaBazaar.AddEmployee("7", "Employee", "F", "employee7@mb.com", 0612345678, "Eindhoven", "01-01-1998", 1234, "employee", "7", JobTitle.OFFICE_EMPLOYEE);
            mediaBazaar.AddEmployee("8", "Employee", "F", "employee8@mb.com", 0647581639, "Eindhoven", "01-01-1998", 1234, "employee", "8", JobTitle.OFFICE_MANAGER);
            mediaBazaar.AddEmployee("9", "Employee", "M", "employee9@mb.com", 0658690364, "Amsterdam", "01-01-1998", 1234, "employee", "9", JobTitle.SALES_EMPLOYEE);
            mediaBazaar.AddEmployee("10", "Employee", "F", "employee10@mb.com", 0646123749, "Eindhoven", "01-01-1998", 1234, "employee", "10", JobTitle.SALES_EMPLOYEE);
        }
        public void UpdateListbox()
        {
            lbxEmployees.Items.Clear();
            foreach (Employee e in mediaBazaar.Employees)
            {
                if (rbnAllEmployees.Checked)
                {
                    lbxEmployees.Items.Add(e.ToString());
                } else if (rbnDepotEmployees.Checked)
                {
                    if (e.Type == JobTitle.DEPOT_EMPLOYEE || e.Type == JobTitle.DEPOT_MANAGER)
                    {
                        lbxEmployees.Items.Add(e.Tostring());
                    }
                } else if (rbnOfficeEmployees.Checked)
                {
                    if (e.Type == JobTitle.OFFICE_EMPLOYEE || e.Type == JobTitle.OFFICE_MANAGER)
                    {
                        lbxEmployees.Items.Add(e.Tostring());
                    }
                } else if (rbnSalesEmployees.Checked)
                {
                    if (e.Type == JobTitle.SALES_EMPLOYEE || e.Type == JobTitle.SALES_MANAGER)
                    {
                        lbxEmployees.Items.Add(e.Tostring());
                    }
                }
            }
        }
    }
}
