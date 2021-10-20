using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using ClassLibraryProject;
using ClassLibraryProject.Class;

namespace MediaBazaar
{
    public partial class DepotEmployee : Form
    {
        int id;
        Store store;

        public DepotEmployee(int UserID, Store s)
        {
            InitializeComponent();
            id = UserID;
            store = s;

            timer1.Start();
            timer1.Interval = 100;

            lbProducts.HorizontalScrollbar = true;
            lbProducts.ScrollAlwaysVisible = true;

            lbReplenishment.HorizontalScrollbar = true;
            lbReplenishment.ScrollAlwaysVisible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ViewPorducts();
            ViewReplenishment();
        }

        public void ViewPorducts()
        {
            store.productManagment.ViewAllProducts();

            lbProducts.Items.Clear();

            foreach (Product p in store.productManagment.products)
            {
                lbProducts.Items.Add(p);
            }
        }

        public void ViewReplenishment()
        {
            store.reshelfManagment.ViewAllReshelfRequests();

            lbReplenishment.Items.Clear();

            foreach (ReShelf p in store.reshelfManagment.reShelves)
            {
                lbReplenishment.Items.Add(p);
            }
        }
    }
}
