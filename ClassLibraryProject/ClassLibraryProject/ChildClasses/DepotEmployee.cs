using ClassLibraryProject.Class;
using System;

namespace ClassLibraryProject.ChildClasses
{
    public class DepotEmployee : Employee
    {
        public DepotEmployee() : base()
        { }
        public DepotEmployee(string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password)
       : base(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password)
        {

        }
        public DepotEmployee(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password)
       : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password)
        {

        }
    }
}
