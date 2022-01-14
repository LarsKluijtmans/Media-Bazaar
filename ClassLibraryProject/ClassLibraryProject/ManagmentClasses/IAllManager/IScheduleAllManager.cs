using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IAllManager
{
    public interface IScheduleAllManager
    {
        List<Schedule> GetSchedules(string department, int year, int week);
        bool CreateWeek(string department, int year, int week);
        bool UpdateSchedule(string department, int year, int week, string day, int morningAmount, int afternoonAmount, int eveningAmount);
        bool WeekExist(string department, int year, int week);
    }
}
