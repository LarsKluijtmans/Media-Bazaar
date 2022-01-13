using AdminBackups;
using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormNewProduct : Form
    {
        ProductManager productManager;
        public FormNewProduct(ProductManager pm)
        {
            InitializeComponent();

            this.productManager = pm;
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            CreateProduct();

            var formProductManager = Application.OpenForms.OfType<FormProductManager>().FirstOrDefault();
            formProductManager.ReadProducts();
        }
        private void CreateProduct()
        {
            // get input
            string productName = tbxProductName.Text;
            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Please enter a product name");
                return;
            }

            string barcode = tbxBarcode.Text;
            if (string.IsNullOrEmpty(barcode))
            {
                MessageBox.Show("Please enter a barcode");
                return;
            }

            string type = cbxProductType.Text;
            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Please enter a product type");
                return;
            }

            // make product object
            Product product = new Product(productName, type, barcode);

            if (productManager.ProductManagerPM.CreateProduct(product))
            {
                DialogResult dr = MessageBox.Show("Do you want to add another product?", "Product Added", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    tbxProductName.Clear();
                    tbxBarcode.Clear();
                } else if (dr == DialogResult.No)
                {
                    this.Close();
                }
            } else
            {
                return;
            }
        }
    }
}
