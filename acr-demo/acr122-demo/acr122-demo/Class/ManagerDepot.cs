using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Class
{
    public class ManagerDepot : Manager
    {
        public ManagerDepot(int employeeID, string firstName, string lastName, int phonenumber, string email, string city, string dateofbirth, int bsn, string username, string password) : base(employeeID, firstName, lastName, phonenumber, email, city, dateofbirth, bsn, username, password)
        {

        }

    }
}
