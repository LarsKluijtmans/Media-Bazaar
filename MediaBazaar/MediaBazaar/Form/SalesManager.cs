using ClassLibraryProject;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class SalesManager : Form
    {
        int ID;
        Store store;
        public SalesManager(int UserID, Store s)
        {
            InitializeComponent();
            ID = UserID;
            store = s;

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
        private void dgProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void lstEmployeesWorkingToday_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tabControl1.SelectTab(3);
        }
        //Products
        //Esther//Esther
        private void btnEditProduct_Click(object sender, EventArgs e)
        {

        }
        private void btnDiscontinue_Click(object sender, EventArgs e)
        {

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
