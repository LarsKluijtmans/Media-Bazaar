using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Class
{
    public abstract class Manager : Person
    {
        public Manager(int employeeID, string firstName, string lastName, int phonenumber, string email, string city, string dateofbirth, int bsn, string username, string password) : base(employeeID, firstName, lastName, phonenumber, email, city, dateofbirth, bsn, username, password)
        {

        }
    }
}
