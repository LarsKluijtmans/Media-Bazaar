using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace acr122_demo
{
    public abstract class Manager : Person
    {
        public Manager(int employeeID, string firstName, string lastName, int phonenumber, string email, string city, string dateofbirth, int bsn, string username, string password) : base(employeeID, firstName, lastName, phonenumber, email, city, dateofbirth, bsn, username, password)
        {

        }
    }
}
