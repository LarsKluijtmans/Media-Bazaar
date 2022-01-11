using ClassLibraryProject.ChildClasses;
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
    public partial class FormViewProduct : Form
    {
        Product product;
        Employee employee;
        public FormViewProduct(Employee e, Product p)
        {
            InitializeComponent();
            this.product = p;
            this.employee = e;

            this.Text = $"{product.ProductID}: {product.ProductName}";

            if (employee is ProductManager)
            {
                tbxSellingPrice.ReadOnly = true;
                cbxStatus.Visible = false;
                tbxStatus.ReadOnly = true;
                tbxType.Visible = false;

            } else if (employee is SalesManager)
            {
                tbxStatus.Visible = false;
                tbxProductName.ReadOnly = true;
                tbxBarcode.ReadOnly = true;
                tbxType.ReadOnly = true;
                cbxProductType.Visible = false;
            }

            LoadProductInfo();
        }
        private void LoadProductInfo()
        {
            tbxProductID.Text = product.ProductID.ToString();
            tbxProductName.Text = product.ProductName;
            tbxBarcode.Text = product.Barcode;
            tbxType.Text = product.ProductType;
            cbxProductType.Text = product.ProductType;
            tbxSellingPrice.Text = product.SellingPrice.ToString();
            tbxAmountInDepot.Text = product.AmountInDepot.ToString();
            tbxAmountInStore.Text = product.AmountInStore.ToString();

            if (product.IsDiscontinued)
            {
                tbxStatus.Text = "Discontinued";
                cbxProductType.Text = "Discontinued";
            } else
            {
                tbxStatus.Text = "Available";
                cbxStatus.Text = "Available";
            }
        }
    }
}
