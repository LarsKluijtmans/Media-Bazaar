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

            //Product newProduct = new Product(productN, productType,  productA);

            //products.Add(newProduct);
            //OpenForm1(productN, productA);
        }

        public void OpenForm1(int id)
        {

            Form1 newProduct = new Form1(id);
            newProduct.Show();
        }
    }
}
