using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acr122_demo
{
    public abstract class Manager : Person
    {
        public Manager(int employeeID, string firstName, string lastName, int phonenumber, string email, string city, string dateofbirth, int bsn, string username, string password) : base(employeeID, firstName, lastName, phonenumber, email, city, dateofbirth, bsn, username, password)
        {

        }
    }
}
