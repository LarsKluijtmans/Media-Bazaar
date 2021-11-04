using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassLibraryProject.Class;

namespace RemoteAppForDepotEmployee
{
    public partial class ProductInfo : Form
    {
        Store s;
        public ProductInfo(Store store)
        {
            InitializeComponent();
            s = store;
            foreach (Product product in s.productManagment.Products)
            {
                lbAmount.Text = product.AmountInDepot.ToString();
                lbName.Text = product.Name;
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            foreach (Product product in s.productManagment.Products)
            {
                s.restockManagment.RequestRestock(product.Barcode, product.ProductID);
            }
            s.productManagment.Products.Clear();
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            s.productManagment.Products.Clear();
            Close();
        }

        private void ProductInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            s.productManagment.Products.Clear();
        }
    }
}
