using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormDepotManager : Form
    {
        private List<Product> porductRequests;
        private List<Product> porductRestock;
        Store store;

        public FormDepotManager()
        {
            InitializeComponent();
            porductRequests = new List<Product>();
            porductRestock = new List<Product>();
        }


        public void AddRequesteProduct(int amount, int productid)
        { 
            foreach(Product p in store.Products)
            {
                if (p.ProductId == productid)
                {
                    Product prod = new Product(p.Barcode, p.Name, p.Type, amount);
                    /*add p to listbox*/
                }
            }
        }




















        private void FormDepotManager_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
