using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Class
{
   public class TimeWorked
    {
        private int employeeID;
        private string timeWorked;


        public int EmployeeID
        { 
            get { return employeeID; } 
        }

        public string TimeWork
        { 
            get { return timeWorked; }
            set { timeWorked = value; }
        }


        public TimeWorked(int EmployeeID, string TimeWorked)
        {
            employeeID = EmployeeID;
            timeWorked = TimeWorked;

        }

        public override string ToString()
        {
            return $"EmployeeID:   {EmployeeID} timeWorked:   {timeWorked}";
        }
    }
}
