using ClassLibraryProject;
using ClassLibraryProject.Class;
using System;
using System.ComponentModel;
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

        private void rbHistory_CheckedChanged(object sender, EventArgs e)
        {
            dgReshelve.DataSource = store.reshelfManagment.ViewHistoryReshelfRequests();
        }
        public void DeleteReshelveRequest()
        {
            string ReshelveID = txtProductID.Text;
            if (string.IsNullOrEmpty(ReshelveID))
            {
                MessageBox.Show("'RestockID' field is required.");
                return;
            }

            store.reshelfManagment.DeleteReshelfRequest(ReshelveID);

            UpdateReshelveRequests();
        }
        private void btnFufillReshelveRequest_Click(object sender, EventArgs e)
        {
            string id = txtProductID.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please select a product");
                return;
            }

            store.reshelfManagment.ShelfReplenishment(id);

            UpdateReshelveRequests();
        }
        private void btnDeleteReshelveRequest_Click(object sender, EventArgs e)
        {
            DeleteReshelveRequest();
        }
        private void dgReshelve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgReshelve.Rows[e.RowIndex];
                txtProductID.Text = row.Cells["ReshelveReplenishmentID"].Value.ToString();
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtBarcode.Text = row.Cells["Barcode"].Value.ToString();
                txtAmountRequested.Text = row.Cells["AmountRequested"].Value.ToString();
            }
        }
        //
    }
}
