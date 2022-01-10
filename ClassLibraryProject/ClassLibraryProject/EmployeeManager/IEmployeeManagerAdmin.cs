using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public interface IEmployeeManagerAdmin
    {
        public bool CreateEmployee(Employee e);
        public int AmountOfOfficeManagers();

        public Employee GetEmployeeID(string givenEmail, string jobTitle);
    }
}
