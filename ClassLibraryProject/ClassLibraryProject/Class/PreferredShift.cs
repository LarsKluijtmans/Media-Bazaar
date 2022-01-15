using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Class
{
    public class PreferredShift
    {
        //fields
        private int week;
        private string day;
        private string shift;
        private List<Employee> employees;

        //properties
        public int Week
        {
            get { return week; }
            set { week = value; }
        }
        public string Day
        {
            get { return day; }
            set { day = value; }
        }
        public string Shift
        {
            get { return shift; }
            set { shift = value; }
        }
        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        //constructor
        public PreferredShift(int week, string day, string shift)
        {
            Week = week;
            Day = day;
            Shift = shift;
            Employees = new List<Employee>();
        }
    }
}
