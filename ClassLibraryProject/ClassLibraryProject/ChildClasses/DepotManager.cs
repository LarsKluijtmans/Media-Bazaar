using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using System;

namespace ClassLibraryProject.ChildClasses
{
    public class DepotManager : Employee
    {
       public IViewDepartments viewDepartments;
        public DepotManager() : base()
        { }

        public DepotManager(string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password)
            : base(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password)
        {}

        public DepotManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, IViewDepartments viewDepartments)
            : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password)
        {
            this.viewDepartments = viewDepartments;
        }
    }
}
