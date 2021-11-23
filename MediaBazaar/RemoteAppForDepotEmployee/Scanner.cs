using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryProject.Class;

namespace RemoteAppForDepotEmployee
{
    public partial class BarcodeScannerDepot : Form
    {
        Store store;
        public BarcodeScannerDepot()
        {
            InitializeComponent();
            store = new Store();
            timerUpdate.Start();
            timerRevival.Start();
            store.productManagment.GetProduct();
        }
        private bool UpdateProduct()
        {
            foreach (Product p in store.productManagment.Products)
            {
                if (p.Barcode == txtBarcode.Text)
                {
                    lbName.Text = p.Name;
                    lbAmount.Text = Convert.ToString(p.AmountInDepot);
                    return true;
                }
                else
                {
                    lbName.Text = "";
                    lbAmount.Text = "";
                }
            }
            return false;
        }
        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            UpdateProduct();
        }
        private void timerRevival_Tick(object sender, EventArgs e)
        {
            if (UpdateProduct())
            {
                timerUpdate.Start();
            }
            else
            {
                timerUpdate.Stop();
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            foreach (Product product in store.productManagment.RemoteProducts)
            {
                if(product.Barcode == txtBarcode.Text)
                {
                    store.restockManagment.RequestRestock(product.Barcode, product.ProductID);
                }
            }

        }

        private void BarcodeScannerDepot_Click(object sender, EventArgs e)
        {
            txtBarcode.Clear();
        }
    }
}
