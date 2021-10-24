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
            string restockID = txtRestockID.Text;
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
            string id = txtRestockID.Text;
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
                txtRestockID.Text = row.Cells["RestockReplenishmentID"].Value.ToString();
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtBarcode.Text = row.Cells["Barcode"].Value.ToString();
                txtRestockAmount.Text = row.Cells["AmountRequested"].Value.ToString();
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




    }
}
