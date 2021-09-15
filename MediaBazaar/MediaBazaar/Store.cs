using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    class Store
    {
        private List<Complaint> complaints;
        private List<Announcement> announcements;

        public Store()
        {
            complaints = new List<Complaint>();
            announcements = new List<Announcement>();
        }
        public void AddAnnouncement(string message)
        {
            Announcement announcement = new Announcement(message);
            announcements.Add(announcement);
        }
        public void RemoveAnnouncement(int selectedIndex)
        {
            announcements.RemoveAt(selectedIndex);
        }
        public void AddComplaint(string message)
        {
            Complaint complaint = new Complaint(message);
            complaints.Add(complaint);
        }
        public void RemoveComplaint(int selectedIndex)
        {
            complaints.RemoveAt(selectedIndex);
        }
    }
}
