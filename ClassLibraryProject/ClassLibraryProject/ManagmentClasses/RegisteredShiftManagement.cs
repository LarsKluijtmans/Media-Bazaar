using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.ManagmentClasses.IAllManager;

namespace ClassLibraryProject.ManagmentClasses
{
    public class RegisteredShiftManagement: IRegisteredShiftAllManager
    {
        private IDBRegisteredShift db;

        public RegisteredShiftManagement(IDBRegisteredShift dbRegisteredShift)
        {
            db = dbRegisteredShift;
        }

        public bool RegisterEmployee(string department, int year, int week, string day, string shift, Employee employee)
        {
            if(!RegisteredEmployeeExist(department, year, week, day, shift, employee))
            {
                if (db.RegisterEmployee(department, year, week, day, shift, employee))
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool DeRegisterEmployee(string department, int year, int week, string day, string shift, Employee employee)
        {
            if (RegisteredEmployeeExist(department, year, week, day, shift, employee))
            {
                if (db.DeRegisterEmployee(department, year, week, day, shift, employee))
                {
                    return true;
                }
                return false;
            }
            return false;  
        }
        public RegisteredShift GetRegisteredShift(string department, int year, int week, string day, string shift)
        {
            return db.GetRegisteredShift(department, year, week, day, shift);
        }
        private Employee RegisteredEmployee(string department, int year, int week, string day, string shift, Employee employee)
        {
            RegisteredShift rs = GetRegisteredShift(department, year, week, day, shift);
            foreach (Employee e in rs.Employees)
            {
                if (e == employee)
                {
                    return e;
                }
            }
            return null;
        }
        private bool RegisteredEmployeeExist(string department, int year, int week, string day, string shift, Employee employee)
        {
            if (RegisteredEmployee(department, year, week, day, shift, employee) != null)
            {
                return true;
            }
            return false;
        }
    }
}
