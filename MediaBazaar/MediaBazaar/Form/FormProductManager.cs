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

        /* Products start */
        private void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
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
    }
}
