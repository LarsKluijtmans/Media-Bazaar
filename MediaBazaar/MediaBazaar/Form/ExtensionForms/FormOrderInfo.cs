using System;
using System.Windows.Forms;
using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
namespace AdminBackups
{
    public partial class FormOrderInfo : Form
    {
        ProductManager employee;
        Product product;
        public FormOrderInfo(ProductManager e, Product p)
        {
            InitializeComponent();

            this.employee = e;
            this.product = p;
        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            
        }
    }
}
