using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public class EmployeeManager : IEmployeeManagerOffice, IEmployeeManagerAdmin
    {
        IDBEmployeeManagerOffice DBEmployeeManagerOffice { get; set; }
        IDBEmployeeManagerAdmin DBEmployeeManagerAdmin { get; set; }

        public EmployeeManager()
        {
            DBEmployeeManagerOffice = new DBEmployeeManager();
            DBEmployeeManagerAdmin = new DBEmployeeManager();
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

        public Employee GetEmployeeID(string givenEmail, string jobTitle)
        {
            return DBEmployeeManagerOffice.GetEmployeeID(givenEmail, jobTitle);
        }

        public int AmountOfOfficeManagers()
        {
            return DBEmployeeManagerAdmin.AmountOfOfficeManagers();
        }
    }
}
