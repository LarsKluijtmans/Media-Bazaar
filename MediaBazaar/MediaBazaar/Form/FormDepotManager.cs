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
                } 
            }
        }

        private void btnCreateNewEmployee_Click(object sender, EventArgs e)
        {
            FormNewEmployee formNewEmployee = new FormNewEmployee(mediaBazaar);
            formNewEmployee.Show();
        }

        private void btnReadEmployees_Click(object sender, EventArgs e)
        {
            UpdateListbox();
        }

        private void btnUpdateEmployees_Click(object sender, EventArgs e)
        {
            Object employeeObj = lbxEmployees.SelectedItem;

            if (!(employeeObj is Employee))
            {
                MessageBox.Show("Error");
            }

            Employee tempEmployee = (Employee)employeeObj;

            FormEditEmployeeData formEditEmployeeData = new FormEditEmployeeData(mediaBazaar, tempEmployee);
            formEditEmployeeData.Show();
        }

        private void btnDeleteEmployees_Click(object sender, EventArgs e)
        {
            Object employeeObj = lbxEmployees.SelectedItem;

            if (!(employeeObj is Employee))
            {
                MessageBox.Show("Error");
            }

            Employee tempEmployee = (Employee)employeeObj;

            tbxEmployeeID.Text = tempEmployee.EmployeeID.ToString();

            mediaBazaar.RemoveEmployee(tempEmployee);

            UpdateListbox();
        }

        private void lbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object employeeObj = lbxEmployees.SelectedItem;

            if (!(employeeObj is Employee))
            {
                MessageBox.Show("Error");
            }

            Employee tempEmployee = (Employee)employeeObj;

            tbxEmployeeID.Text = tempEmployee.EmployeeID.ToString();
        }
    }
}
