using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormNewProduct : Form
    {
        List<Product> products;
        public FormNewProduct()
        {
            InitializeComponent();

            products = new List<Product>();
        }

        private void BtnNewProduct_Click(object sender, EventArgs e)
        {
            string productN = txtProductName.Text;
            int productA = Convert.ToInt32(txtProductAmount.Text);
            ProductType productType = (ProductType)Enum.Parse(typeof(ProductType), cbxProductType.SelectedItem.ToString());

            Product newProduct = new Product(productN, productType,  productA);

            products.Add(newProduct);
            OpenForm1(productN, productType, productA);
        }

        public void OpenForm1(string productN, ProductType productType, int productA)
        {

            Form1 newProduct = new Form1(productN, productType, productA);
            newProduct.Show();
        }
    }
}
