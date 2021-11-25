using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormNewOrderInfo : Form
    {
        Store s;
        int id;
        public FormNewOrderInfo(Store store, int supplierID)
        {
            InitializeComponent();
            s = store;
            id = supplierID;
            txtSupplierID.Text = id.ToString();
            UpdateProductListbox();
        }
        private void UpdateProductListbox()
        {
            lstProduct.Items.Clear();
            foreach(Product p in s.productManagment.Products)
            {
                lstProduct.Items.Add(p);
            }
        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            int supplierID = Convert.ToInt32(txtSupplierID.Text);
            int multiples = Convert.ToInt32(txtMultiples.Text);
            int maxAmount = Convert.ToInt32(txtMaxAmount.Text);
            int minAmount = Convert.ToInt32(txtMinAmount.Text);
            if (lstProduct.SelectedIndex < 0)
            {
                return;
            }

            Object productObject = lstProduct.SelectedItem;
            if (productObject is Product)
            {
                Product product = (Product)productObject;
                s.orderInfoManagment.AddOrderInfo(supplierID, product.ProductID, minAmount, maxAmount, multiples);
            }
        }
    }
}
