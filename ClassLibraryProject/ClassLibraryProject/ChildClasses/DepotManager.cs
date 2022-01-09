using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using ClassLibraryProject.ManagmentClasses;
using System;

namespace ClassLibraryProject.ChildClasses
{
    public class DepotManager : Employee
    {
        public AutoScheduleManagment autoSchedule;
        public IViewDepartments viewDepartments;

        public DepotManager() : base()
        { }

        public DepotManager(string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail)
            : base(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {}

        public DepotManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IViewDepartments viewDepartments, AutoScheduleManagment autoSchedule)
            : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {
            this.viewDepartments = viewDepartments;
            this.autoSchedule = autoSchedule;
        }
    }
}
