using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Class
{
    public class PreferredShift
    {
        //fields
        private string day;
        private string shift;
        private List<Employee> employees;

        //properties
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
        public PreferredShift(string day, string shift)
        {
            Day = day;
            Shift = shift;
            Employees = new List<Employee>();
        }
    }
}
