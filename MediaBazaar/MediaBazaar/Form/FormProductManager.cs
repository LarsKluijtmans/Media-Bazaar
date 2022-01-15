using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using MediaBazaar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AdminBackups
{
    public partial class FormProductManager : Form
    {
        ProductManager productManager;
        Store store;

        public FormProductManager(ProductManager productManager, Store s)
        {
            InitializeComponent();
            this.productManager = productManager;
            store = s;

            ReadProducts();
            ReadSuppliers();
        }

        //Logout 
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var logout = Application.OpenForms.OfType<FormLogin>().FirstOrDefault();
            logout.Show();
            Close();
        }

        /* Products Start */
        private void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                string productID = row.Cells["ProductID"].Value.ToString();

                tbxSelectedProduct.Text = productID;
            }
        }
        private void CreateProduct()
        {
            FormNewProduct formNewProduct = new FormNewProduct(productManager);
            formNewProduct.Show();
        }
        public void ReadProducts()
        {
            string search = tbProductSearch.Text;

            if (!string.IsNullOrEmpty(search))
            {
                List<Product> products = productManager.ProductManagerPM.SearchProductsPM(search);
                dgvProducts.DataSource = products;
            }
            else
            {
                List<Product> products = productManager.ProductManagerPM.ReadProductsPM();

                dgvProducts.DataSource = products;
            }
        }
        private void UpdateProduct()
        {
            // get selected product
            int productID = 0;
            if (string.IsNullOrEmpty(tbxSelectedProduct.Text))
            {
                MessageBox.Show("Please select a product");
                return;
            }
            try
            {
                productID = Convert.ToInt32(tbxSelectedProduct.Text);
            }
            catch { MessageBox.Show("Error"); return; }

            Product selectedProduct = productManager.ProductManagerPM.GetProductByID(productID);

            // open new form
            if (selectedProduct != null)
            {
                FormViewProduct formViewProduct = new FormViewProduct(productManager, selectedProduct);
                formViewProduct.Show();
            }
        }

        private void tbProductSearch_TextChanged(object sender, EventArgs e)
        {
            string search = tbProductSearch.Text;

            if (!string.IsNullOrEmpty(search))
            {
                List<Product> products = productManager.ProductManagerPM.SearchProductsPM(search);
                dgvProducts.DataSource = products;
            }
            else
            {
                ReadProducts();
            }
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            CreateProduct();
        }

        private void bntUpdateProduct_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }
        /* Products End */

        /* Supplier Start */
        private void CreateSupplier()
        {
            // get input
            string name = tbxSupplierName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name");
                return;
            }

            string country = tbxCountry.Text;
            if (string.IsNullOrEmpty(country))
            {
                MessageBox.Show("Please enter a country");
                return;
            }

            int buildingNumber = 0;
            if (string.IsNullOrEmpty(tbxBuildingNumber.Text))
            {
                MessageBox.Show("Please enter a building number");
                return;
            }
            try
            {
                buildingNumber = Convert.ToInt32(tbxBuildingNumber.Text);
            }
            catch
            {
                MessageBox.Show("Error");
                return;
            }

            string zipCode = tbxPostalCode.Text;
            if (string.IsNullOrEmpty(zipCode))
            {
                MessageBox.Show("Please enter a zip code");
                return;
            }

            string email = tbxEmail.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email");
                return;
            }
            //if (!Regex.IsMatch(email, @"[a-z0-9]+(?:\.[a-z0-9]+)*@(?:[a-z](?:[a-z]*[a-z])?\.)nl|com"))
            //{
            //    MessageBox.Show("Please enter a valid email address");
            //    return;
            //}

            string phoneNumber = tbxPhoneNumber.Text;
            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter a phone number");
                return;
            }

            string bankNumber = tbxBankNumber.Text;
            if (string.IsNullOrEmpty(bankNumber))
            {
                MessageBox.Show("Please enter a bank number");
                return;
            }

            string productType = cbxProductType.Text;
            if (string.IsNullOrEmpty(productType))
            {
                MessageBox.Show("Please select a product type");
                return;
            }

            // make the supplier object
            Supplier supplier = new Supplier(name, country, buildingNumber, zipCode, email, phoneNumber, bankNumber, productType);
            if (productManager.SupplierManagerPM.CreateSupplier(supplier))
            {
                tbxSupplierName.Clear();
                tbxCountry.Clear();
                tbxBuildingNumber.Clear();
                tbxPostalCode.Clear();
                tbxEmail.Clear();
                tbxPhoneNumber.Clear();
                tbxBankNumber.Clear();

                MessageBox.Show("Supplier Created");
                ReadSuppliers();
            }
        }
        private void ReadSuppliers()
        {
            List<Supplier> suppliers = productManager.SupplierManagerPM.ReadSuppliers();
            List<Supplier> supplierType = new List<Supplier>();

            if (cbxSupplierType.SelectedIndex == 1)
            {
                supplierType.Clear();
                foreach (Supplier s in suppliers)
                {
                    if (s.ProductType == "KITCHEN_HOME")
                    {
                        supplierType.Add(s);
                    }
                }
            }
            else if (cbxSupplierType.SelectedIndex == 2)
            {
                supplierType.Clear();
                foreach (Supplier s in suppliers)
                {
                    if (s.ProductType == "PHOTO_VIDEO_NAVIGATION")
                    {
                        supplierType.Add(s);
                    }
                }
            }
            else if (cbxSupplierType.SelectedIndex == 3)
            {
                supplierType.Clear();
                foreach (Supplier s in suppliers)
                {
                    if (s.ProductType == "SMART_HOME_APPLIANCES")
                    {
                        supplierType.Add(s);
                    }
                }
            }
            else if (cbxSupplierType.SelectedIndex == 4)
            {
                supplierType.Clear();
                foreach (Supplier s in suppliers)
                {
                    if (s.ProductType == "GAMING_MUSIC_COMPUTERS")
                    {
                        supplierType.Add(s);
                    }
                }
            }
            dgvSuppliers.DataSource = supplierType;

            if (cbxSupplierType.SelectedIndex == 0)
            {
                dgvSuppliers.DataSource = suppliers;
            }
        }
        private void UpdateSupplier()
        {
            int supplierID = 0;
            if (string.IsNullOrEmpty(tbxSupplierID.Text))
            {
                MessageBox.Show("Please select a supplier");
                return;
            }
            try
            {
                supplierID = Convert.ToInt32(tbxSupplierID.Text);
            }
            catch
            {
                MessageBox.Show("Error");
                return;
            }
            // get supplier by id
            Supplier supplier = productManager.SupplierManagerPM.GetSupplierByID(supplierID);

            if (supplier != null)
            {
                supplier.Name = tbxSupplierName.Text;
                supplier.Country = tbxCountry.Text;
                try
                {
                    supplier.BuildingNumber = Convert.ToInt32(tbxBuildingNumber.Text);
                }
                catch
                {
                    MessageBox.Show("Error");
                    return;
                }
                supplier.PostalCode = tbxPostalCode.Text;
                supplier.Email = tbxEmail.Text;
                supplier.PhoneNumber = tbxPhoneNumber.Text;
                supplier.BankNumber = tbxBankNumber.Text;
                supplier.ProductType = cbxProductType.Text;

                if (productManager.SupplierManagerPM.UpdateSupplier(supplier))
                {
                    tbxSupplierName.Clear();
                    tbxCountry.Clear();
                    tbxBuildingNumber.Clear();
                    tbxPostalCode.Clear();
                    tbxEmail.Clear();
                    tbxPhoneNumber.Clear();
                    tbxBankNumber.Clear();

                    MessageBox.Show("Supplier updated");
                    ReadSuppliers();
                }
            }
        }
        private void DeleteSupplier()
        {

        }
        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSuppliers.Rows[e.RowIndex];

                tbxSupplierID.Text = row.Cells["ID"].Value.ToString();
                tbxSupplierName.Text = row.Cells["Name"].Value.ToString();
                tbxCountry.Text = row.Cells["Country"].Value.ToString();
                tbxBuildingNumber.Text = row.Cells["BuildingNumber"].Value.ToString();
                tbxPostalCode.Text = row.Cells["PostalCode"].Value.ToString();
                tbxEmail.Text = row.Cells["Email"].Value.ToString();
                tbxPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                tbxBankNumber.Text = row.Cells["BankNumber"].Value.ToString();
                cbxProductType.Text = row.Cells["ProductType"].Value.ToString();
            }
        }
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            CreateSupplier();
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            UpdateSupplier();
            // fixed?? cant test
        }

        private void btnRemoveSupplier_Click(object sender, EventArgs e)
        {
            DeleteSupplier();
            tbxSupplierID.Clear();
            tbxSupplierName.Clear();
            tbxCountry.Clear();
            tbxBuildingNumber.Clear();
            tbxPostalCode.Clear();
            tbxEmail.Clear();
            tbxPhoneNumber.Clear();
            tbxBankNumber.Clear();
        }
        /* Search Bar*/
        private void tbxSupplierSearch_TextChanged(object sender, EventArgs e)
        {
            string search = tbxSupplierSearch.Text;

            if (!string.IsNullOrEmpty(search))
            {
                List<Supplier> suppliers = productManager.SupplierManagerPM.SearchSuppliers(search);
                dgvSuppliers.DataSource = suppliers;
            }
            else
            {
                ReadSuppliers();
            }
        }

        private void cbxSupplierType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadSuppliers();
        }
        /* Supplier End */
    }
}
