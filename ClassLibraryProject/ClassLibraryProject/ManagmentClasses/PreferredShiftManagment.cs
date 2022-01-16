using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.ManagmentClasses.IAllManager;

namespace ClassLibraryProject.ManagmentClasses
{
    public class PreferredShiftManagment: IPreferredShiftAllManager
    {
        private IDBPreferredShift db;

        public PreferredShiftManagment(IDBPreferredShift dbPreferredShift)
        {
            db = dbPreferredShift;
        }

        public bool PreferAShift(string day, string shift, Employee employee)
        {
            if (!EmployeeWantsToWorkExist(day, shift, employee.EmployeeID))
            {
                if (db.PreferAShift(day, shift, employee) == true)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool DeRegisterEmployee(string day, string shift, Employee employee)
        {
            if (EmployeeWantsToWorkExist(day, shift, employee.EmployeeID))
            {
                if (db.DeletePreferredShift(day, shift, employee))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public PreferredShift GetPreferredShift(string day, string shift)
        {
            return db.GetPreferredShift(day, shift);
        }
        private Employee EmployeeWantsToWork(string day, string shift, int employeeID)
        {
            PreferredShift rs = GetPreferredShift(day, shift);
            foreach (Employee e in rs.Employees)
            {
                if (e.EmployeeID == employeeID)
                {
                    return e;
                }
            }
            return null;
        }
        private bool EmployeeWantsToWorkExist(string day, string shift, int employeeID)
        {
            if (EmployeeWantsToWork(day, shift, employeeID) != null)
            {
                return true;
            }
            return false;
        }
    }
}
