using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IDB
{
    public interface IDBPreferredShift
    {
        bool PreferAShift(int week, string day, string shift, Employee employee);
        bool DeletePreferredShift(int week, string day, string shift, Employee employee);
        PreferredShift GetPreferredShift(int week, string day, string shift);
    }
}
