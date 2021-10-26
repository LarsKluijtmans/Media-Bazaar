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
            if (string.IsNullOrEmpty(reshelveID))
            {
                MessageBox.Show("Select the reshelve request you want to reject");
                return;
            }

            store.reshelfManagment.DeleteReshelfRequest(Convert.ToInt32(reshelveID));

            UpdateReshelveRequests();
        }
        private void btnFufillReshelveRequest_Click(object sender, EventArgs e)
        {
            string id = txtReshelfID.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Select the reshelve request you want to fulfill");
                return;
            }

            store.reshelfManagment.ShelfReplenishment(Convert.ToInt32(id));

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
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtBarcode.Text = row.Cells["Barcode"].Value.ToString();
            }
        }
        private void btnReceiveProduct_Click(object sender, EventArgs e)
        {
            string restockID = txtRestockID.Text;
            if (string.IsNullOrEmpty(restockID))
            {
                MessageBox.Show("Select any restock request that you get the product for.");
                return;
            }
            string amountReceived = txtAmountReceived.Text;
            if (string.IsNullOrEmpty(amountReceived))
            {
                MessageBox.Show("Fill up the amount of product you receive from supplier");
                return;
            }
            store.restockManagment.RestockReplenishment(Convert.ToInt32(restockID), Convert.ToInt32(amountReceived));
            store.restockManagment.AddToDepot(Convert.ToInt32(restockID));
            UpdateOrders();
        }

       
    }
}
