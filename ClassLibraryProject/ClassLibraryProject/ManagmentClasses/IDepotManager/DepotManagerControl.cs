using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses.IAllManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IDepotManager
{
    public class DepotManagerControl
    {
        private IRestockDepotManager restock;
        private IScheduleAllManager schedule;
        private IRegisteredShiftAllManager registeredShift;

        public DepotManagerControl(IRestockDepotManager restock, IScheduleAllManager schedule, IRegisteredShiftAllManager registeredShift)
        {
            this.restock = restock;
            this.schedule = schedule;
            this.registeredShift = registeredShift;
        }

        //restock
        public List<Restock> GetRestockRequests()
        {
            return restock.GetRestockRequests();
        }
        public bool OrderRestock(int id, OrderInfo orderInfo, int amount)
        {
            return restock.OrderRestock(id, orderInfo, amount);
        }
        public bool DeleteRestock(int id)
        {
            return restock.DeleteRestock(id);
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

        //registered shift
        public bool RegisterEmployee(string department, int year, int week, string day, string shift, Employee employee)
        {
            return registeredShift.RegisterEmployee(department, year, week, day, shift, employee);
        }
        public bool DeRegisterEmployee(string department, int year, int week, string day, string shift, Employee employee)
        {
            return registeredShift.DeRegisterEmployee(department, year, week, day, shift, employee);
        }
        public RegisteredShift GetRegisteredShift(string department, int year, int week, string day, string shift)
        {
            return registeredShift.GetRegisteredShift(department, year, week, day, shift);
        }
    }
}
