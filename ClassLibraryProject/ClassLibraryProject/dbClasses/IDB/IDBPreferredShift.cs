using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IDB
{
    public interface IDBPreferredShift
    {
        bool PreferAShift(string day, string shift, Employee employee);
        bool DeletePreferredShift(string day, string shift, Employee employee);
        PreferredShift GetPreferredShift(string day, string shift);
    }
}
