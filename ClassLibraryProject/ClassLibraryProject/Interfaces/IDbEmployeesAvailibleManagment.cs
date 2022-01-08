using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Interfaces
{
    public interface IDbEmployeesAvailibleManagment
    {
        public List<int> EmployeesShiftPrefered(string shift, string day, int week, int year, string department);
        public List<int> EmployeesWithoughtPreference(string shift, string day, int week, int year, string department);
        public List<int> EmployeesUnPrefered(string shift, string day, int week, int year, string department);


        public List<int> EveningEmployeesShiftPrefered(string shift, string day, int week, int year, string department);
        public List<int> EveningShiftWithoughtPreference(string shift, string day, int week, int year, string department);
        public List<int> EveningShiftUnPrefered(string shift, string day, int week, int year, string department);

    }
}
