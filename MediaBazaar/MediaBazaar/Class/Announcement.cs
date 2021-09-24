using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    public class Announcement
    {
        //fields
        private static int counter=1;
        private int announcementID;
        private string message;
        
        //properties
        public int AnnouncementID
        {
            get { return announcementID; }
            private set { announcementID = value; }
        }

        //constructor
        public Announcement(string message)
        {
            this.message = message;
            AnnouncementID = counter;
            counter++;
        }
        public override string ToString()
        {
            return AnnouncementID + ": " + message;
        }
    }
}
