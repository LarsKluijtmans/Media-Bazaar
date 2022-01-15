using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IDB
{
    public interface IDBPreferredShift
    {
        bool PreferAShift(int year, int week, string day, string shift, Employee employee);
        bool DeletePreferredShift(int year, int week, string day, string shift, Employee employee);
        PreferredShift GetPreferredShift(int year, int week, string day, string shift);
    }
}
