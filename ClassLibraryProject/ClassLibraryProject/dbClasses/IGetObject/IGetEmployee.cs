using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IGetObject
{
    public interface IGetEmployee
    {
        Employee GetEmployeeByID(int givenEmployeeID);
    }
}
