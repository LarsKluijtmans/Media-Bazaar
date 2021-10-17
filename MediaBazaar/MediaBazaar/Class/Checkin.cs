using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar.Class
{
    public class Checkin
    {
        private int employeeID;
        private DateTime checkIn;
        private DateTime checkOut;
        private DateTime date;

        public int EmployeeID
        { get { return employeeID; } }

        public DateTime CheckIn
        { get { return checkIn; } }
        public DateTime CheckOut
        { get { return checkOut; } }
        public DateTime Date
        { get { return date; } }

        public Checkin(int EmployeeID, DateTime CheckIn, DateTime CheckOut, DateTime Date)
        {
            employeeID = EmployeeID;
            checkIn = CheckIn;
            checkOut = CheckOut;
            date = Date;
        }

        public override string ToString()
        {
            return $"EmployeeID: {EmployeeID} Checkin: {CheckIn}  Checkout: {CheckOut}";
        }
    }
}
