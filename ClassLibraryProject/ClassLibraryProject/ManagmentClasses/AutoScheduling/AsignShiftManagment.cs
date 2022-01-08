using ClassLibraryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses
{
  public class AsignShiftManagment : IAsignShiftManagment
    {
        IDbAsignShiftManagment dbAsignShift;
        public AsignShiftManagment(IDbAsignShiftManagment dbAsignShift)
        {
            this.dbAsignShift = dbAsignShift;
        }

        public bool AssignEmployeeShift(string sql)
        {
            return dbAsignShift.AssignEmployeeShift(sql);
        }

        public bool ScheduleAllEmployees(List<int> employees, int amountToSchedule, string shift, string day, int week, int year)
        {
            return dbAsignShift.ScheduleAllEmployees(employees, amountToSchedule, shift, day, week, year);
        }

        public bool ScheduleShift(List<int> employees, int amountToSchedule, string shift, string day, int week, int year)
        {
            return dbAsignShift.ScheduleShift(employees,amountToSchedule, shift, day, week, year);
        }
    }
}
