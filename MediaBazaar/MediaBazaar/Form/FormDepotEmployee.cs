using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses.IDepotEmployee;
using System;
using System.Windows.Forms;

namespace AdminBackups
{
    public partial class FormDepotEmployee : Form
    {
        DepotEmployee de;
        Store s;
        IDepotEmployeeControl c;
        public FormDepotEmployee(DepotEmployee e, Store s)
        {
            InitializeComponent();

            de = e;
            this.s = s;
            c = de.Control;

            UpdateReshelveRequests();
            UpdateOrders();
        }

        //Overview
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Reshelves
        public void UpdateReshelveRequests()
        {
            dgReshelve.DataSource = c.GetReshelfRequest();
        }
        private void rbPending_Click(object sender, EventArgs e)
        {
            //dgReshelve.DataSource = store.reshelfManagment.ViewPendingReshelfRequests();
        }

        private void rbHistory_Click(object sender, EventArgs e)
        {
            //dgReshelve.DataSource = store.reshelfManagment.ViewHistoryReshelfRequests();
        }
        private void btnFufillReshelveRequest_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtReshelfID.Text);
            Product p = c.GetProduct(txtBarcode.Text);
            try
            {
                c.CompleteReshelf(id, p);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a reshelf request you want to fulfill");
            }

            UpdateReshelveRequests();
        }
        private void btnDeleteReshelveRequest_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtReshelfID.Text);
            try
            {
                c.DeleteReshelf(id);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a reshelf request you want to reject");
            }
            UpdateReshelveRequests();
        }
        private void dgReshelve_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgReshelve.Rows[e.RowIndex];
                txtReshelfID.Text = row.Cells["ID"].Value.ToString();
                txtBarcode.Text = row.Cells["Product"].Value.ToString();
                txtAmountRequested.Text = row.Cells["AmountRequested"].Value.ToString();
            }
        }

        //Receive Product
        public void UpdateOrders()
        {
            dgOrder.DataSource = c.GetOrderedRestockRequests();
        }
        private void dgOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgOrder.Rows[e.RowIndex];
                txtRestockID.Text = row.Cells["RestockReplenishmentID"].Value.ToString();
                txtProductIDRestock.Text = row.Cells["ProductID"].Value.ToString();
                txtBarcodeRestock.Text = row.Cells["Barcode"].Value.ToString();
            }
        }
        private void btnReceiveProduct_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtRestockID.Text);
            Product p = c.GetProduct(txtBarcodeRestock.Text);
            try
            {
                c.ReceiveRestock(id, p);
            }
            catch (Exception)
            {
                MessageBox.Show("Select restock request and input the amount supplied");
            }
            UpdateOrders();
        }
    }
}
