using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ChildClasses
{
     public class OfficeManager :Employee
    {
        public OfficeManager() : base()
        { }

        public OfficeManager(int employeeID, string lastname, string firstname, int phonenumber, string email, string city, string dateofbirth, int bsn, string username, string password)
       : base(employeeID, lastname, firstname, phonenumber, email, city, dateofbirth, bsn, username, password)
        { }
    }
}
