using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Class
{
    public class RegisteredShift
    {
        //fields
        private int id;
        private int year;
        private int week;
        private string day;
        private string shift;
        private Employee employee;

        //properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int Week
        {
            get { return week; }
            set { week = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
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
        public Employee Employee
        {
            get { return employee; }
            set { employee = value; }
        }

        //constructor
        public RegisteredShift(int id, int year, int week, string day, string shift, Employee employee)
        {
            ID = id;
            Year = year;
            Week = week;
            Day = day;
            Shift = shift;
            Employee = employee;
        }

    }
}
