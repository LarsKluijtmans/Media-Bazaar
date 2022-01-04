using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using System;

namespace ClassLibraryProject.ChildClasses
{
    public class Admin : Employee
    {
        public Admin()
        {

        }

        public IAddEmployee addEmployee;
        public Admin(IAddEmployee addEmployee) : base()
        { 
            this.addEmployee = addEmployee;
        }

        public Admin(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, IAddEmployee addEmployee) 
            : base (employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password)
        {
            this.addEmployee = addEmployee;
        }
    }
}
