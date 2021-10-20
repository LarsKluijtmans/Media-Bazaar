using ClassLibraryProject;
using ClassLibraryProject.Class;
using System;
using System.Windows.Forms;

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
            timer2.Start();

            lbProducts.HorizontalScrollbar = true;
            lbProducts.ScrollAlwaysVisible = true;

            lbReplenishment.HorizontalScrollbar = true;
            lbReplenishment.ScrollAlwaysVisible = true;

            ViewPorducts();
            ViewReplenishment();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if ( ActiveControl == tbSearchReplenishment || ActiveControl == tbProductSearch )
            {
                timer1.Start();
            }
            else { timer1.Stop(); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ViewPorducts();
            ViewReplenishment();
        }

        public void ViewPorducts()
        {
            store.productManagment.ViewAllProducts( tbProductSearch.Text);

            lbProducts.Items.Clear();

            foreach (Product p in store.productManagment.products)
            {
                lbProducts.Items.Add(p);
            }
        }

        public void ViewReplenishment()
        {
            store.reshelfManagment.ViewAllReshelfRequests( tbSearchReplenishment.Text);

            lbReplenishment.Items.Clear();

            foreach (ReShelf p in store.reshelfManagment.reShelves)
            {
                lbReplenishment.Items.Add(p);
            }
        }

        private void lbReplenishment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbReplenishment.SelectedIndex < 0)
            {
                return;
            }

            Object ReshelfObject = lbReplenishment.SelectedItem;
            if (!(ReshelfObject is ReShelf))
            {
                return;
            }

            ReShelf reShelf = (ReShelf)ReshelfObject;
            tbReplenishmentID.Text = reShelf.ShelfReplenishmentID.ToString();
            tbReplenishmentProductID.Text = reShelf.ProductID.ToString();
            tbReplenishmentProsuctName.Text = reShelf.Name;
            tbReplenishmentAmountInDepot.Text = reShelf.AmountInDepot.ToString();
            tbReplenishmentAmount.Text = reShelf.Amount.ToString();
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex < 0)
            {
                return;
            }

            Object ProductObject = lbProducts.SelectedItem;
            if (!(ProductObject is Product))
            {
                return;
            }

            Product product = (Product)ProductObject;
            tbProductID.Text = product.ProductID.ToString();
            tbProductName.Text = product.Name;
            tbProductType.Text = product.Barcode;
            tbAmountInDepot.Text = product.ProductType;
        }
    }
}
