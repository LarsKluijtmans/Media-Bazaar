using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IDB
{
    public interface IDBRegisteredShift
    {
        bool RegisterEmployee(int year, int week, string day, string shift, Employee employee);
        bool DeRegisterEmployee(int year, int week, string day, string shift, Employee employee);
        RegisteredShift GetRegisteredShift(int year, int week, string day, string shift);
    }
}
