using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public interface IDBEmployeeManagerAdmin
    {
        public bool CreateEmployee(Employee e);

        public int AmountOfOfficeManagers();
    }
}
