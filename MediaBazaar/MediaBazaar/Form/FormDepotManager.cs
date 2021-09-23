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
                if (p.ProductId == productid)
                {
                    Product prod = new Product(p.Barcode, p.Name, p.Type, amount);
                    /*add p to listbox*/
                }
            }
        }
        // employees
        public void TestEmployees()
        {
            mediaBazaar.AddEmployees("Employee", "1", "employee1@mb.com", "employee", "1", JobType.SALES_MANAGER);
            mediaBazaar.AddEmployees("Employee", "2", "employee2@mb.com", "employee", "2", JobType.DEPOT_MANAGER);
            mediaBazaar.AddEmployees("Employee", "3", "employee3@mb.com", "employee", "3", JobType.DEPOT_EMPLOYEE);
            mediaBazaar.AddEmployees("Employee", "4", "employee4@mb.com", "employee", "4", JobType.SALES_EMPLOYEE);
            mediaBazaar.AddEmployees("Employee", "5", "employee5@mb.com", "employee", "5", JobType.SALES_EMPLOYEE);
            mediaBazaar.AddEmployees("Employee", "6", "employee6@mb.com", "employee", "6", JobType.SALES_MANAGER);
            mediaBazaar.AddEmployees("Employee", "7", "employee7@mb.com", "employee", "7", JobType.OFFICE_EMPLOYEE);
            mediaBazaar.AddEmployees("Employee", "8", "employee8@mb.com", "employee", "8", JobType.OFFICE_MANAGER);
            mediaBazaar.AddEmployees("Employee", "9", "employee9@mb.com", "employee", "9", JobType.SALES_EMPLOYEE);
            mediaBazaar.AddEmployees("Employee", "10", "employee10@mb.com", "employee", "10", JobType.SALES_EMPLOYEE);
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
