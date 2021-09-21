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
        Employee e;
        Store s;
        private List<Product> porductRequests;
        private List<Product> porductRestock;

        public FormDepotManager(Employee employee, Store store)
        {
            InitializeComponent();
            porductRequests = new List<Product>();
            porductRestock = new List<Product>();
            store = s;
            employee = e;
        }


        public void AddRequesteProduct(int amount, int productid)
        { 
            foreach(Product p in s.Products)
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
