using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.dbClasses.IGetObject;
using ClassLibraryProject.ManagmentClasses.IAllManager;

namespace ClassLibraryProject.ManagmentClasses
{
    public class RegisteredShiftManagment: IRegisteredShiftAllManager
    {
        private IDBRegisteredShift db;
        private IGetSchedule schedule;

        public RegisteredShiftManagment(IDBRegisteredShift dbRegisteredShift, IGetSchedule schedule)
        {
            db = dbRegisteredShift;
            this.schedule = schedule;
        }

        public bool RegisterEmployee(string department, int year, int week, string day, string shift, Employee employee)
        {
            if (!RegisteredEmployeeExist(year, week, day, shift, employee))
            {
                if (CheckAmount(department, year, week, day, shift) == true)
                {
                    if(db.RegisterEmployee(year,week,day,shift,employee) == true)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }
        public bool DeRegisterEmployee(int year, int week, string day, string shift, Employee employee)
        {
            if (RegisteredEmployeeExist(year, week, day, shift, employee))
            {
                if (db.DeRegisterEmployee(year, week, day, shift, employee))
                {
                    return true;
                }
                return false;
            }
            return false;  
        }

        public bool CheckAmount(string department, int year, int week, string day, string shift)
        {
            int amountRegistered = GetRegisteredShift(year, week, day, shift).Employees.Count;
            int morningAmount = schedule.GetSchedule(department, year, week).MorningAmount;
            int afternoonAmount = schedule.GetSchedule(department, year, week).AfternoonAmount;
            int eveningAmount = schedule.GetSchedule(department, year, week).EveningAmount;


            if (shift == "Morning")
            {
                if (morningAmount > amountRegistered)
                {
                    return true;
                }
            }
            else
            {
                if (shift == "Afternoon")
                {
                    if (afternoonAmount > amountRegistered)
                    {
                        return true;
                    }
                }
                else
                {
                    if (shift == "Evening")
                    {
                        if (eveningAmount > amountRegistered)
                        {
                            return true;
                        }
                        return false;
                    }
                }
            }
            return false;
        }
        public RegisteredShift GetRegisteredShift(int year, int week, string day, string shift)
        {
            return db.GetRegisteredShift(year, week, day, shift);
        }
        private Employee RegisteredEmployee(int year, int week, string day, string shift, Employee employee)
        {
            RegisteredShift rs = GetRegisteredShift(year, week, day, shift);
            foreach (Employee e in rs.Employees)
            {
                if (e == employee)
                {
                    return e;
                }
            }
            return null;
        }
        private bool RegisteredEmployeeExist(int year, int week, string day, string shift, Employee employee)
        {
            if (RegisteredEmployee(year, week, day, shift, employee) != null)
            {
                return true;
            }
            return false;
        }
    }
}
