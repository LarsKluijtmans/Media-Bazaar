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
            store.productManagment.GetProduct();
        }

        private bool UpdateProduct()
        {
            foreach (Product p in store.productManagment.RemoteProducts)
            {
                if (p.Barcode == txtBarcode.Text)
                {
                    lbName.Text = p.Name;
                    lbAmount.Text = Convert.ToString(p.AmountInStore);
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
        private void btnRequest_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Product product in store.productManagment.RemoteProducts)
                {
                    if (product.Barcode == txtBarcode.Text)
                    {
                        store.reshelfManagment.RequestReshelf(product.Barcode, product.ID, Convert.ToInt32(txtRequest.Text));
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
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

        private void Scanner_Click(object sender, EventArgs e)
        {
            txtBarcode.Clear();
        }
    }
}
