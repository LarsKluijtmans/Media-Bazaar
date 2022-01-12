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
                btnCreateOrderInfo.Visible = false;
            }

            LoadProductInfo();
            GetSuppliersForProduct();
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
                cbxStatus.Text = "Discontinued";
            } else
            {
                tbxStatus.Text = "Available";
                cbxStatus.Text = "Available";
            }
        }
        private void GetSuppliersForProduct()
        {
            List<Supplier> productSuppliers = ((ProductManager)employee).SupplierManagerPM.GetSuppliersForProduct(product);

            cbxSupplier.DataSource = productSuppliers;
        }
        private bool UpdateProduct()
        {
            if (employee is ProductManager)
            {
                if (string.IsNullOrEmpty(tbxProductName.Text))
                {
                    MessageBox.Show("Product Name cannot be empty");
                    return false;
                }
                product.ProductName = tbxProductName.Text;

                if (string.IsNullOrEmpty(tbxBarcode.Text))
                {
                    MessageBox.Show("Barcode cannot be empty");
                    return false;
                }
                product.Barcode = tbxBarcode.Text;

                if (string.IsNullOrEmpty(cbxProductType.Text))
                {
                    MessageBox.Show("Product Type cannot be empty");
                    return false;
                }
                product.ProductType = cbxProductType.Text;

                return ((ProductManager)employee).ProductManagerPM.UpdateProductPM(product);
            }


            return false;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (!UpdateProduct())
            {
                return;
            }

            var formProductManager = Application.OpenForms.OfType<FormProductManager>().FirstOrDefault();
            formProductManager.ReadProducts();

            this.Close();
        }

        private void btnCreateOrderInfo_Click(object sender, EventArgs e)
        {
            FormOrderInfo formOrderInfo = new FormOrderInfo((ProductManager)employee, product);
            formOrderInfo.Show();
        }
        private void GetOrderInfoForSupplier()
        {

        }
    }
}
