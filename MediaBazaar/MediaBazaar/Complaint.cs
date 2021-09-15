using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    class Complaint
    {
        private static int count = 1;
        private string message;

        public Complaint(string message)
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
