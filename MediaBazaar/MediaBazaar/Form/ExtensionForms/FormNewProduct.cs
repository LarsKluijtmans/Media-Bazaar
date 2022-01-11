using ClassLibraryProject.ChildClasses;
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
        ProductManager productManager;
        public FormNewProduct(ProductManager pm)
        {
            InitializeComponent();

            this.productManager = pm;
        }
    }
}
