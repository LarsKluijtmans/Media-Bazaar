using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IGetObject
{
    public interface IGetRegisteredShift
    {
        bool RegisteredShiftExist(string department, int year, string month, string day, string shift);
    }
}
