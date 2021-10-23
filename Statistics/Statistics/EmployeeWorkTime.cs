using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    public  class EmployeeWorkTime
    {
        private int employeeID;
        private TimeSpan timeworked;
        private int workHours;

        public int EmployeeID
        { get { return employeeID; } }

        public TimeSpan Timeworked
        { get { return timeworked; } }
        public int WorkHours
        { get { return workHours; } }

        public EmployeeWorkTime(int EmployeeID, TimeSpan Timeworked, int WorkHours)
        {
            employeeID = EmployeeID;
            timeworked = Timeworked;
            workHours = WorkHours;

        }
    }
}
