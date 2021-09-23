using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormSalesManager : Form
    {
        Employee employee;
        Store mediaBazaar;
        public FormSalesManager(Employee e, Store mb)
        {
            InitializeComponent();
            mediaBazaar = mb;
            this.employee = e;

            UpdateListbox();
        }
        // employees
        public void UpdateListbox()
        {
            lbxEmployees.Items.Clear();
            foreach (Employee e in mediaBazaar.Employees)
            {
                if (rbnAllEmployees.Checked)
                {
                    lbxEmployees.Items.Add(e);
                }
                else if (rbnSalesEmployees.Checked)
                {
                    if (e.Type == JobTitle.DEPOT_EMPLOYEE || e.Type == JobTitle.DEPOT_MANAGER)
                    {
                        lbxEmployees.Items.Add(e);
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
            
            if (tempEmployee.Type != JobTitle.SALES_MANAGER || tempEmployee.Type != JobTitle.SALES_EMPLOYEE)
            {
                MessageBox.Show("You do not have the permission to modify this employee");
            } else
            {
                FormEditEmployeeData formEditEmployeeData = new FormEditEmployeeData(mediaBazaar, tempEmployee);
                formEditEmployeeData.Show();
            }
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

            if (tempEmployee.Type != JobTitle.SALES_MANAGER || tempEmployee.Type != JobTitle.SALES_EMPLOYEE)
            {
                MessageBox.Show("You do not have the permission to remove this employee");
            }
            else
            {
                mediaBazaar.RemoveEmployee(tempEmployee);
                FormRemoveEmployee formRemoveEmployee = new FormRemoveEmployee(mediaBazaar, tempEmployee);
                formRemoveEmployee.Show();
            }

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
