using ClassLibraryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses
{
   public class EmployeesAvailibleManagment : IEmployeesAvailibleManagment
    {
        public IDbEmployeesAvailibleManagment dbEmployeesAvailible;
        public EmployeesAvailibleManagment(IDbEmployeesAvailibleManagment dbEmployeesAvailible)
        {
            this.dbEmployeesAvailible = dbEmployeesAvailible;
        }

        public List<int> EmployeesShiftPrefered(string shift, string day, int week, int year, string department)
        {
            return dbEmployeesAvailible.EmployeesShiftPrefered(shift, day, week, year, department);
        }

        public List<int> EmployeesUnPrefered(string shift, string day, int week, int year, string department)
        {
            return dbEmployeesAvailible.EmployeesUnPrefered(shift, day, week, year, department);
        }

        public List<int> EmployeesWithoughtPreference(string shift, string day, int week, int year, string department)
        {
            return dbEmployeesAvailible.EmployeesWithoughtPreference(shift, day, week, year, department);
        }

        public List<int> EveningEmployeesShiftPrefered(string shift, string day, int week, int year, string department)
        {
            return dbEmployeesAvailible.EveningEmployeesShiftPrefered(shift, day, week, year, department);
        }

        public List<int> EveningShiftUnPrefered(string shift, string day, int week, int year, string department)
        {
            return dbEmployeesAvailible.EveningShiftUnPrefered(shift, day, week, year, department);
        }

        public List<int> EveningShiftWithoughtPreference(string shift, string day, int week, int year, string department)
        {
            return dbEmployeesAvailible.EveningShiftWithoughtPreference(shift, day, week, year, department);
        }
    }
}
