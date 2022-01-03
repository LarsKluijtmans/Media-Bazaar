using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public class EmployeeManager : IEmployeeManagerOffice
    {
        IDBEmployeeManagerOffice DBEmployeeManagerOffice { get; set; }

        public EmployeeManager()
        {
            DBEmployeeManagerOffice = new DBEmployeeManager();
        }

        public bool CreateEmployee(Employee e)
        {
            return DBEmployeeManagerOffice.CreateEmployee(e);
        }
        public List<Employee> ReadEmployees()
        {
            return DBEmployeeManagerOffice.ReadEmployees();
        }
        public bool UpdateEmployee(Employee e)
        {
            return DBEmployeeManagerOffice.UpdateEmployee(e);
        }
        public bool DeleteEmployee(Employee e)
        {
            return DBEmployeeManagerOffice.DeleteEmployee(e);
        }
    }
}
