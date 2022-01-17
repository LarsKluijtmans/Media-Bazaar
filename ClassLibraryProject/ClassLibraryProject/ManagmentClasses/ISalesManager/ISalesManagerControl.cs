using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.ISalesManager
{
    public interface ISalesManagerControl
    {
        //schedule
        List<Schedule> GetSchedules(string department, int year, int week);
        bool CreateWeek(string department, int year, int week);
        bool WeekExist(string department, int year, int week);
        bool UpdateSchedule(string department, int year, int week, string day, int morningAmount, int afternoonAmount, int eveningAmount);

        //planning
        void GetAllRegisteredShift();
        bool RegisterEmployee(string department, int year, int week, string day, string shift, Employee employee);
        bool CheckAmount(string department, int year, int week, string day, string shift);
        bool DeRegisterEmployee(int year, int week, string day, string shift, Employee employee);
        RegisteredShift GetRegisteredShift(int year, int week, string day, string shift);
        bool RegisteredEmployeeExist(int year, int week, string day, string shift, int employeeID);

        //preferred shift
        PreferredShift GetPreferredShift(string day, string shift);
    }
}
