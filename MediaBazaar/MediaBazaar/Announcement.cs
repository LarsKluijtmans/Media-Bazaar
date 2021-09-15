using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    class Announcement
    {
        private static int count=1;
        private string message;
        
        public Announcement(string message)
        {
            this.message = message;
            count++;
        }
        public override string ToString()
        {
            return count + " " + message;
        }
    }
}
