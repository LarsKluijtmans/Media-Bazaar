using ClassLibraryProject.Class;
using System;

namespace ClassLibraryProject.ChildClasses
{
   public class SalesManager : Employee
    {
        public SalesManager() : base()
        { }
        public SalesManager(string firstName, string lastName, int phoneNumber, string email, string city, DateTime dateOfBirth, int bsn, string username, string password)
       : base(firstName, lastName, phoneNumber, email, city, dateOfBirth, bsn, username, password)
        {

        }
        public SalesManager(int employeeID, string firstName, string lastName, int phoneNumber, string email, string city, DateTime dateOfBirth, int bsn, string username, string password)
       : base(employeeID, firstName, lastName, phoneNumber, email, city, dateOfBirth, bsn, username, password)
        {

        }
    }
}
