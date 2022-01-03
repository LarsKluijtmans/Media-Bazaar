using ClassLibraryProject.Class;
using System;

namespace ClassLibraryProject.ChildClasses
{
    public class Admin : Employee
    {
        public Admin() : base()
        { }

        public Admin(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password) 
            : base (employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password)
        {

        }
    }
}
