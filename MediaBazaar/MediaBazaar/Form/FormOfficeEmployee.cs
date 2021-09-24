using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormOfficeEmployee : Form
    {
        Store s;
        Employee em;     
        public FormOfficeEmployee(Store store, Employee employee)
        {
            InitializeComponent();
            s = store;
            em = employee;

            UpdateAnnouncementList();
        }
        public void UpdateAnnouncementList()
        {
            lstOverviewAnnouncement.Items.Clear();
            lstAnnouncement.Items.Clear();
            foreach (Announcement a in s.Announcements)
            {
                lstAnnouncement.Items.Add(a);
                lstOverviewAnnouncement.Items.Add(a);
            }
        }

        private void btnSubmitComplaint_Click(object sender, EventArgs e)
        {
            string message = txtComplaint.Text;
            Complaint complaint = new Complaint(message);
            s.AddComplaint(complaint);
        }

        private void btnSubmitAnnouncement_Click(object sender, EventArgs e)
        {
            string message = txtAnnouncement.Text;
            Announcement announcement = new Announcement(message);
            s.AddAnnouncement(announcement);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FormEditEmployeeData editEmployeeData = new FormEditEmployeeData(s, em);
            editEmployeeData.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }

       
    }
}
