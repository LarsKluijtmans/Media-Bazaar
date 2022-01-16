using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IDB
{
    public interface IDBRegisteredShift
    {
        public void GetAllRegisteredShifts();
        bool RegisterEmployee(int year, int week, string day, string shift, int employeeID);
        bool DeRegisterEmployee(int year, int week, string day, string shift, int employeeID);
        RegisteredShift GetRegisteredShift(int year, int week, string day, string shift);
    }
}
