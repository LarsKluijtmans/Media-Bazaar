using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    class Announcement
    {
        private static int counter=1;
        private int id;
        private string message;
        
        public int ID
        {
            get { return id; }
            private set { id = value; }
        }
        public Announcement(string message)
        {
            this.message = message;
            ID = counter;
            counter++;
        }
        public override string ToString()
        {
            return ID + " " + message;
        }
    }
}
