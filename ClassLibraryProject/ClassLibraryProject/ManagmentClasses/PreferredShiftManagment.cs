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

        public bool PreferAShift(int week, string day, string shift, Employee employee)
        {
            if (!EmployeeWantsToWorkExist(week, day, shift, employee))
            {
                if (db.PreferAShift(week, day, shift, employee) == true)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool DeRegisterEmployee(int week, string day, string shift, Employee employee)
        {
            if (EmployeeWantsToWorkExist(week, day, shift, employee))
            {
                if (db.DeletePreferredShift(week, day, shift, employee))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public PreferredShift GetPreferredShift(int week, string day, string shift)
        {
            return db.GetPreferredShift(week, day, shift);
        }
        private Employee EmployeeWantsToWork(int week, string day, string shift, Employee employee)
        {
            PreferredShift rs = GetPreferredShift(week, day, shift);
            foreach (Employee e in rs.Employees)
            {
                if (e == employee)
                {
                    return e;
                }
            }
            return null;
        }
        private bool EmployeeWantsToWorkExist(int week, string day, string shift, Employee employee)
        {
            if (EmployeeWantsToWork(week, day, shift, employee) != null)
            {
                return true;
            }
            return false;
        }
    }
}
