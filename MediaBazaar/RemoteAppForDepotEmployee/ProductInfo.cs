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
            foreach (Product product in s.productManagment.products)
            {
                lbAmount.Text = product.AmountInDepot.ToString();
                lbName.Text = product.Name;
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txtAmount.Text);
            foreach (Product product in s.productManagment.products)
            {
                s.restockManagment.RequestRestock(product.Barcode, product.ProductID, amount);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            s.productManagment.products.Clear();
            Close();
        }
    }
}
