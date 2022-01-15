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

        public bool PreferAShift(int year, int week, string day, string shift, Employee employee)
        {
            if (!EmployeeWantsToWorkExist(year, week, day, shift, employee))
            {
                if (db.PreferAShift(year, week, day, shift, employee) == true)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool DeRegisterEmployee(int year, int week, string day, string shift, Employee employee)
        {
            if (EmployeeWantsToWorkExist(year, week, day, shift, employee))
            {
                if (db.DeletePreferredShift(year, week, day, shift, employee))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public PreferredShift GetPreferredShift(int year, int week, string day, string shift)
        {
            return db.GetPreferredShift(year, week, day, shift);
        }
        private Employee EmployeeWantsToWork(int year, int week, string day, string shift, Employee employee)
        {
            PreferredShift rs = GetPreferredShift(year, week, day, shift);
            foreach (Employee e in rs.Employees)
            {
                if (e == employee)
                {
                    return e;
                }
            }
            return null;
        }
        private bool EmployeeWantsToWorkExist(int year, int week, string day, string shift, Employee employee)
        {
            if (EmployeeWantsToWork(year, week, day, shift, employee) != null)
            {
                return true;
            }
            return false;
        }
    }
}
