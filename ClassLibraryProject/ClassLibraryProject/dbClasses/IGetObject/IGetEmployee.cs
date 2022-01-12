using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IGetObject
{
    public interface IGetEmployee
    {
        Employee GetEmployee(int id);
    }
}
