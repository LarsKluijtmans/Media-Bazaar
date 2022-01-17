using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses.IAllManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.ISalesManager
{
    public class SalesManagerControl: ISalesManagerControl
    {
        private IScheduleAllManager schedule;
        private IRegisteredShiftAllManager registeredShift;
        private IPreferredShiftAllManager preferredShift;

        public SalesManagerControl(IScheduleAllManager schedule, IRegisteredShiftAllManager registeredShift, IPreferredShiftAllManager preferredShift)
        {
            this.schedule = schedule;
            this.registeredShift = registeredShift;
            this.preferredShift = preferredShift;
        }
        //schedule
        public List<Schedule> GetSchedules(string department, int year, int week)
        {
            return schedule.GetSchedules(department, year, week);
        }
        public bool CreateWeek(string department, int year, int week)
        {
            return schedule.CreateWeek(department, year, week);
        }
        public bool UpdateSchedule(string department, int year, int week, string day, int morningAmount, int afternoonAmount, int eveningAmount)
        {
            return schedule.UpdateSchedule(department, year, week, day, morningAmount, afternoonAmount, eveningAmount);
        }
        public bool WeekExist(string department, int year, int week)
        {
            return schedule.WeekExist(department, year, week);
        }

        //registered shift
        public void GetAllRegisteredShift()
        {
            registeredShift.GetAllRegisteredShift();
        }
        public bool RegisterEmployee(string department, int year, int week, string day, string shift, Employee employee)
        {
            return registeredShift.RegisterEmployee(department, year, week, day, shift, employee.EmployeeID);
        }
        public bool CheckAmount(string department, int year, int week, string day, string shift)
        {
            return registeredShift.CheckAmount(department, year, week, day, shift);
        }
        public bool DeRegisterEmployee(int year, int week, string day, string shift, Employee employee)
        {
            return registeredShift.DeRegisterEmployee(year, week, day, shift, employee.EmployeeID);
        }
        public RegisteredShift GetRegisteredShift(int year, int week, string day, string shift)
        {
            return registeredShift.GetRegisteredShift(year, week, day, shift);
        }
        public bool RegisteredEmployeeExist(int year, int week, string day, string shift, int employeeID)
        {
            return registeredShift.RegisteredEmployeeExist(year, week, day, shift, employeeID);
        }

        //preferred shift
        public PreferredShift GetPreferredShift(string day, string shift)
        {
            return preferredShift.GetPreferredShift(day, shift);
        }
    }
}
