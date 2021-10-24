using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RemoteAppForSalesRepresentative
{
    
    public partial class ProductInfo : Form
    {
        Store s;
        public ProductInfo(Store store)
        {
            InitializeComponent();
            s = store;
            UpdateProduct();
        }
        private void UpdateProduct()
        {
            foreach (Product product in s.productManagment.products)
            {
                lbAmount.Text = product.AmountInDepot.ToString();
                lbName.Text = product.Name;
            }
        }
        private void btnRequest_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txtRequest.Text);
            foreach (Product product in s.productManagment.products)
            {
                s.reshelfManagment.RequestReshelf(product.Barcode, product.ProductID, amount);
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            s.productManagment.products.Clear();
            Close();
        }
    }
    
}
