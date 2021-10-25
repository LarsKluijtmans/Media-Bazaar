using ClassLibraryProject.Class;
using System;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class DepotManager : Form
    {
        int ID;
        Store store;

        public DepotManager(int UserID, Store s)
        {
            InitializeComponent();

            store = s;
            ID = UserID;

            UpdateRestockRequests();
            UpdateSchedule();
            UpdateSupplier();
        }

        //Overview
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgOverviewSchedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void dgOverviewRestock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void lstEmployeesWorkingToday_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tabControl1.SelectTab(3);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(4);
        }
        //Restock
        public void UpdateRestockRequests()
        {
            dgOverviewRestock.DataSource = store.restockManagment.ViewPendingRestockRequests();
            dgRestock.DataSource = store.restockManagment.ViewPendingRestockRequests();
        }
        private void rbPending_Click(object sender, EventArgs e)
        {
            dgRestock.DataSource = store.restockManagment.ViewPendingRestockRequests();
        }

        private void rbHistory_CheckedChanged(object sender, EventArgs e)
        {
            dgRestock.DataSource = store.restockManagment.ViewHistoryRestockRequests();
        }
        public void DeleteRestockRequest()
        {
            string restockID = txtProductID.Text;
            if (string.IsNullOrEmpty(restockID))
            {
                MessageBox.Show("'RestokID' field is required.");
                return;
            }

            store.restockManagment.DeleteRestockRequest(restockID);

            UpdateRestockRequests();
        }
        private void btnFufillRestockRequest_Click(object sender, EventArgs e)
        {
            string id = txtProductID.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please select a product");
                return;
            }

            store.restockManagment.RestockReplenishment(id);

            UpdateRestockRequests();
        }
        private void btnDeleteRestockRequest_Click(object sender, EventArgs e)
        {
            DeleteRestockRequest();
        }
        private void dgRestock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgRestock.Rows[e.RowIndex];
                txtProductID.Text = row.Cells["RestockReplenishmentID"].Value.ToString();
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtBarcode.Text = row.Cells["Barcode"].Value.ToString();
                txtAmountRequested.Text = row.Cells["AmountRequested"].Value.ToString();
            }
        }

        //Schedule
        public void UpdateSchedule()
        {
            dgSchedule.DataSource = store.scheduleManagment.ViewDepotSchedule();
            dgOverviewSchedule.DataSource = store.scheduleManagment.ViewDepotSchedule();
            dgPlanningSchedule.DataSource = store.scheduleManagment.ViewDepotSchedule();
        }
        private void dgSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgSchedule.Rows[e.RowIndex];
                lbScheduleDay.Text = row.Cells["Day"].Value.ToString();
                lbScheduleEvening.Text = row.Cells["Evening"].Value.ToString();
                lbScheduleMorning.Text = row.Cells["Morning"].Value.ToString();
                lbScheduleAfternoon.Text = row.Cells["Afternoon"].Value.ToString();
            }
        }
        private void btnEditschedule_Click(object sender, EventArgs e)
        {
            string Morning = lbScheduleMorning.Text;
            if (string.IsNullOrEmpty(Morning))
            {
                MessageBox.Show("'Morning' field is required.");
                return;
            }

            string Afternoon = lbScheduleAfternoon.Text;
            if (string.IsNullOrEmpty(Afternoon))
            {
                MessageBox.Show("'Afternoon' field is required.");
                return;
            }

            string Evening = lbScheduleEvening.Text;
            if (string.IsNullOrEmpty(Evening))
            {
                MessageBox.Show("'Evening' field is required.");
                return;
            }

            string Day = lbScheduleDay.Text;
            if (string.IsNullOrEmpty(Evening))
            {
                MessageBox.Show("'Day' field is required.");
                return;
            }

            store.scheduleManagment.Editschedule(Day, Morning, Afternoon, Evening);

            UpdateSchedule();
        }

        //Planning


        //Supplier
        private void UpdateSupplier()
        {
            dgOverviewSupplier.DataSource = store.supplierManagment.ViewAllSuppliers();
            dgSupplier.DataSource = store.supplierManagment.ViewAllSuppliers();
        }
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            string id = txtSupplierID.Text;
            string name = lbScheduleMorning.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("'Morning' field is required.");
                return;
            }
            string country = lbScheduleAfternoon.Text;
            if (string.IsNullOrEmpty(country))
            {
                MessageBox.Show("'Afternoon' field is required.");
                return;
            }
            string buildingNumber = lbScheduleEvening.Text;
            if (string.IsNullOrEmpty(buildingNumber))
            {
                MessageBox.Show("'Evening' field is required.");
                return;
            }
            string postalCode = lbScheduleDay.Text;
            if (string.IsNullOrEmpty(postalCode))
            {
                MessageBox.Show("'Day' field is required.");
                return;
            }
            string email = lbScheduleDay.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("'Day' field is required.");
                return;
            }
            string phoneNumber = lbScheduleDay.Text;
            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("'Day' field is required.");
                return;
            }
            string bankNumber = lbScheduleDay.Text;
            if (string.IsNullOrEmpty(bankNumber))
            {
                MessageBox.Show("'Day' field is required.");
                return;
            }

            store.supplierManagment.EditSupplier(Convert.ToInt32(id), name, country, Convert.ToInt32(buildingNumber), Convert.ToInt32(postalCode), email, Convert.ToInt32(phoneNumber), bankNumber);

            UpdateSupplier();
        }
        private void btnRemoveSupplier_Click(object sender, EventArgs e)
        {

        }
    }
}
