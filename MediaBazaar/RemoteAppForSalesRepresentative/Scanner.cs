using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteAppForSalesRepresentative
{
    public partial class Scanner : Form
    {
        Store store;
        public Scanner()
        {
            InitializeComponent();
            store = new Store();
            timerUpdate.Start();
            timerRevival.Start();
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            store.productManagment.GetProduct(txtBarcode.Text);
            if (store.productManagment.RemoteProducts.Count > 0)
            {
                ProductInfo productInfo = new ProductInfo(store);
                productInfo.Show();
                txtBarcode.Clear();
            }
        }

        private void timerRevival_Tick(object sender, EventArgs e)
        {
            if (store.productManagment.RemoteProducts.Count > 0)
            {
                timerUpdate.Stop();
            }
            else if (store.productManagment.RemoteProducts.Count <= 0)
            {
                timerUpdate.Start();
            }
        }
    }
}
