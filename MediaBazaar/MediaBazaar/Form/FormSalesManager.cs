using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MediaBazaar.Class;
using MySql.Data.MySqlClient;

namespace MediaBazaar
{
    public partial class FormSalesManager : Form
    {
        int ID;
        Store mediaBazaar;
        public FormSalesManager(int UserID, Store mb)
        {
            InitializeComponent();
            mediaBazaar = mb;
            ID = UserID;

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
                    if (e.Type == JobTitle.SALES_EMPLOYEE || e.Type == JobTitle.SALES_MANAGER)
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
            Employee tempEmployee = GetTempEmployee();

            if (tempEmployee.Type == JobTitle.SALES_MANAGER || tempEmployee.Type == JobTitle.SALES_EMPLOYEE)
            {
                FormEditEmployeeData formEditEmployeeData = new FormEditEmployeeData(mediaBazaar, tempEmployee);
                formEditEmployeeData.Show();
            } else
            {
                MessageBox.Show("You do not have the permission to modify this employee");
            }
        }

        private void btnDeleteEmployees_Click(object sender, EventArgs e)
        {
            Employee tempEmployee = GetTempEmployee();

            tbxEmployeeID.Text = tempEmployee.EmployeeID.ToString();

            if (tempEmployee.Type == JobTitle.SALES_MANAGER || tempEmployee.Type == JobTitle.SALES_EMPLOYEE)
            {
                FormRemoveEmployee formRemoveEmployee = new FormRemoveEmployee(mediaBazaar, tempEmployee);
                formRemoveEmployee.Show();
            }
            else
            {
                MessageBox.Show("You do not have the permission to remove this employee");
            }

            UpdateListbox();
        }

        private void lbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee tempEmployee = GetTempEmployee();

            tbxEmployeeID.Text = tempEmployee.EmployeeID.ToString();
        }
        private Employee GetTempEmployee()
        {
            Object employeeObj = lbxEmployees.SelectedItem;

            if (!(employeeObj is Employee))
            {
                MessageBox.Show("Error");
            }

            Employee tempEmployee = (Employee)employeeObj;

            return tempEmployee;
        }

        public void ViewAllProducts()
        {
            lstProduct.Items.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = Utils.GET_ALL_PRODUCT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Product product;

                while (reader.Read())
                {
                    int ProductID = reader.GetInt32("ProductID");
                    string barcode = reader.GetString("Barcode");
                    string name = reader.GetString("Name");
                    string productType = reader.GetString("Type");
                    int amountInStore = reader.GetInt32("AmountInStore");
                    int amountInDepot = reader.GetInt32("AmountInDepot");

                    product = new Product(ProductID, name, productType, barcode, amountInDepot, amountInStore);

                    lstProduct.Items.Add(product);
                }
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProduct.SelectedIndex < 0)
            {
                return;
            }

            Object ProductObject = lstProduct.SelectedItem;
            if (!(ProductObject is Product))
            {
                return;
            }

            Product product = (Product)ProductObject;
            tbID.Text = product.ProductID.ToString();
            tbName.Text = product.Name;
            tbBarcode.Text = product.Barcode;
            lbProductType.Text = product.ProductType;
            tbmountInStore.Text = product.AmountInStore.ToString();
            tbAmountInDepot.Text = product.AmountInDepot.ToString();
        }

        private void btnRequestReplenishment_Click(object sender, EventArgs e)
        {

            string ID = tbID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                lstProduct.Items.Add("'ID' field is required.");
                return;
            }

            string Amount = tbAmount.Text;
            if (string.IsNullOrEmpty(Amount))
            {
                lstProduct.Items.Add("'Amount' field is required.");
                return;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.CREATE_SHELFREPLENICHMENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", ID);
                cmd.Parameters.AddWithValue("@Amount", Amount);


                conn.Open();
                int numCreatedRows = cmd.ExecuteNonQuery();
                MessageBox.Show("Request was succesfull");
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {

                conn.Close();
            }
        }

        private void btnViewPorducts_Click(object sender, EventArgs e)
        {
            ViewAllProducts();
        }
    }
}
