using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IAllManager
{
    public interface IRegisteredShiftAllManager
    {
        void GetAllRegisteredShift();
        bool RegisterEmployee(string department, int year, int week, string day, string shift, int employeeID);
        bool DeRegisterEmployee(int year, int week, string day, string shift, int employeeID);
        RegisteredShift GetRegisteredShift(int year, int week, string day, string shift);
        bool CheckAmount(string department, int year, int week, string day, string shift);
        bool RegisteredEmployeeExist(int year, int week, string day, string shift, int employeeID);
    }
}
