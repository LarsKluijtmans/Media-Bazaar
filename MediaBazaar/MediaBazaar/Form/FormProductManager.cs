using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using MediaBazaar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            List<Product> products = productManager.ProductManagerPM.ReadProductsPM();

            dgvProducts.DataSource = products;
        }
        private void UpdateProduct()
        {
            // get selected product
            int productID = Convert.ToInt32(tbxSelectedProduct.Text);
            if (string.IsNullOrEmpty(tbxSelectedProduct.Text))
            {
                MessageBox.Show("Please select a product");
                return;
            }

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

        /* Supplier End */
    }
}
