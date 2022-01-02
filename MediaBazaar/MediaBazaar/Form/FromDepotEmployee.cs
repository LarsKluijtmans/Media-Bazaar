using ClassLibraryProject.Class;
using System;
using System.Windows.Forms;

namespace AdminBackups
{
    public partial class FromDepotEmployee : Form
    {
        Employee depotemployee;
        Store store;
        public FromDepotEmployee(Employee depotemployee, Store store)
        {
            InitializeComponent();

            this.depotemployee = depotemployee;
            this.store = store;

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
            dgReshelve.DataSource = store.reshelfManagment.ViewPendingReshelfRequests();
        }
        private void rbPending_Click(object sender, EventArgs e)
        {
            dgReshelve.DataSource = store.reshelfManagment.ViewPendingReshelfRequests();
        }

        private void rbHistory_Click(object sender, EventArgs e)
        {
            dgReshelve.DataSource = store.reshelfManagment.ViewHistoryReshelfRequests();
        }
        public void DeleteReshelveRequest()
        {
            string reshelveID = txtReshelfID.Text;
            try
            {
                store.reshelfManagment.DeleteReshelfRequest(Convert.ToInt32(reshelveID));
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a reshelf request you want to reject");
            }
            UpdateReshelveRequests();
        }
        private void btnFufillReshelveRequest_Click(object sender, EventArgs e)
        {
            string id = txtReshelfID.Text;
            try
            {
                store.reshelfManagment.ShelfReplenishment(Convert.ToInt32(id));
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a reshelf request you want to fulfill");
            }

            UpdateReshelveRequests();
        }
        private void btnDeleteReshelveRequest_Click(object sender, EventArgs e)
        {
            DeleteReshelveRequest();
        }
        private void dgReshelve_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgReshelve.Rows[e.RowIndex];
                txtReshelfID.Text = row.Cells["ShelfReplenishmentID"].Value.ToString();
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtBarcode.Text = row.Cells["Barcode"].Value.ToString();
                txtAmountRequested.Text = row.Cells["AmountRequested"].Value.ToString();
            }
        }

        //Receive Product
        public void UpdateOrders()
        {
            dgOrder.DataSource = store.restockManagment.ViewOrderedRestockRequests();
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
            string restockID = txtRestockID.Text;
            string amountReceived = txtAmountReceived.Text;
            try
            {
                store.restockManagment.RestockReplenishment(Convert.ToInt32(restockID), Convert.ToInt32(amountReceived));
                store.restockManagment.AddToDepot(Convert.ToInt32(restockID));
            }
            catch (Exception)
            {
                MessageBox.Show("Select restock request and input the amount supplied");
            }
            UpdateOrders();
        }
    }
}
