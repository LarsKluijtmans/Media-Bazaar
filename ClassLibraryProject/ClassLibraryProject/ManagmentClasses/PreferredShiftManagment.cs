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

        public bool PreferAShift(string day, string shift, Employee employee, bool isPreferred)
        {
            if (!EmployeeWantsToWorkExist(day, shift, employee.EmployeeID, isPreferred))
            {
                if (db.PreferAShift(day, shift, employee, isPreferred) == true)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (db.UpdatePreferredShift(day, shift, employee, isPreferred) == true)
                {
                    return true;
                }
                return false;
            }
        }

        public PreferredShift GetPreferredShift(string day, string shift)
        {
            return db.GetPreferredShift(day, shift);
        }
        private Employee EmployeeWantsToWork(string day, string shift, int employeeID, bool isPreferred)
        {
            if(GetPreferredShift(day, shift) != null)
            {
                PreferredShift rs = GetPreferredShift(day, shift);
                foreach (Employee e in rs.Employees)
                {
                    if (e.EmployeeID == employeeID && rs.IsPreferred == isPreferred)
                    {
                        return e;
                    }
                }
            }
            return null;
        }
        private bool EmployeeWantsToWorkExist(string day, string shift, int employeeID, bool isPreferred)
        {
            if (EmployeeWantsToWork(day, shift, employeeID, isPreferred) != null)
            {
                return true;
            }
            return false;
        }
    }
}
