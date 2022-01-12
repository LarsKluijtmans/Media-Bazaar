using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IDB
{
    public interface IDBRegisteredShift
    {
        bool RegisterEmployee(string department, int year, int week, string day, string shift, Employee employee);
        bool DeRegisterEmployee(string department, int year, int week, string day, string shift, Employee employee);
        RegisteredShift GetRegisteredShift(string department, int year, int week, string day, string shift);
    }
}
