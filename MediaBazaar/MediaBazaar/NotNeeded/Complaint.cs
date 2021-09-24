using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    public class Complaint
    {
        //fields
        private static int counter = 1;
        private int complaintID;
        private string message;


        //properties
        public int ComplaintID
        {
            get { return complaintID; }
            private set { complaintID = value; }
        }

        //constructors
        public Complaint(string message)
        {
            this.message = message;
            ComplaintID = counter;
            counter++;
        }


        //methods
        public override string ToString()
        {
            return ComplaintID + ": " + message;
        }
    }
}
