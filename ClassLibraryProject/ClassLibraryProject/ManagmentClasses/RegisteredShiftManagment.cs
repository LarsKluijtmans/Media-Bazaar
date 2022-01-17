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

        public void GetAllRegisteredShift()
        {
            db.GetAllRegisteredShifts();
        }
        public bool RegisterEmployee(string department, int year, int week, string day, string shift, int employeeID)
        {
            if (!RegisteredEmployeeExist(year, week, day, shift, employeeID))
            {
                if (CheckAmount(department, year, week, day, shift) == true)
                {
                    if(db.RegisterEmployee(year,week,day,shift,employeeID) == true)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }
        public bool DeRegisterEmployee(int year, int week, string day, string shift, int employeeID)
        {
            if (RegisteredEmployeeExist(year, week, day, shift, employeeID))
            {
                if (db.DeRegisterEmployee(year, week, day, shift, employeeID))
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
            int morningAmount = schedule.GetSchedule(department, year, week, day).MorningAmount;
            int afternoonAmount = schedule.GetSchedule(department, year, week, day).AfternoonAmount;
            int eveningAmount = schedule.GetSchedule(department, year, week, day).EveningAmount;


            if (shift == "Morning")
            {
                if (morningAmount > amountRegistered)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (shift == "Afternoon")
                {
                    if (afternoonAmount > amountRegistered)
                    {
                        return true;
                    }
                    return false;
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
                return false;
            }
        }
        public RegisteredShift GetRegisteredShift(int year, int week, string day, string shift)
        {
            return db.GetRegisteredShift(year, week, day, shift);
        }
        private Employee RegisteredEmployee(int year, int week, string day, string shift, int employeeID)
        {
            if(GetRegisteredShift(year, week, day, shift) != null)
            {
                RegisteredShift rs = GetRegisteredShift(year, week, day, shift);
                foreach (Employee e in rs.Employees)
                {
                    if (e.EmployeeID == employeeID)
                    {
                        return e;
                    }
                }
            }
            return null;
        }
        public bool RegisteredEmployeeExist(int year, int week, string day, string shift, int employeeID)
        {
            if (RegisteredEmployee(year, week, day, shift, employeeID) != null)
            {
                return true;
            }
            return false;
        }
    }
}
