using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IAllManager
{
    public interface IRegisteredShiftAllManager
    {
        bool RegisterEmployee(string department, int year, int week, string day, string shift, Employee employee);
        bool DeRegisterEmployee(int year, int week, string day, string shift, Employee employee);
        RegisteredShift GetRegisteredShift(int year, int week, string day, string shift);
        bool CheckAmount(string department, int year, int week, string day, string shift);
    }
}
