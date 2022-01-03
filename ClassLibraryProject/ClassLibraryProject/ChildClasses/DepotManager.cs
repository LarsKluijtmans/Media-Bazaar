using ClassLibraryProject.Class;
using System;

namespace ClassLibraryProject.ChildClasses
{
    public class DepotManager : Employee
    {
        public DepotManager() : base()
        { }
        public DepotManager(string firstName, string lastName, int phoneNumber, string email, string city, DateTime dateOfBirth, int bsn, string username, string password)
            : base(firstName, lastName, phoneNumber, email, city, dateOfBirth, bsn, username, password)
        {

        }
        public DepotManager(int employeeID, string firstName, string lastName, int phoneNumber, string email, string city, DateTime dateOfBirth, int bsn, string username, string password)
            : base(employeeID, firstName, lastName, phoneNumber, email, city, dateOfBirth, bsn, username, password)
        {

        }
    }
}
