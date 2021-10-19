using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Class
{
    public class Checkin
    {
        private int employeeID;
        private string checkIn;
        private string checkOut;
        private DateTime date;

        public int EmployeeID
        { get { return employeeID; } }

        public string CheckIn
        { get { return checkIn; } }
        public string CheckOut
        { get { return checkOut; } }
        public DateTime Date
        { get { return date; } }

        public Checkin(int EmployeeID, string CheckIn, string CheckOut, DateTime Date)
        {
            employeeID = EmployeeID;
            checkIn = CheckIn;
            checkOut = CheckOut;
            date = Date;
        }

        public override string ToString()
        {
            return $"EmployeeID: {EmployeeID} Checkin: {CheckIn}  Checkout: {CheckOut} Day: {date.Day}/{date.Month}/{date.Year}";
        }
    }
}
