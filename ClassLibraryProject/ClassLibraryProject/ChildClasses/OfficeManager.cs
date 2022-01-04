using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using ClassLibraryProject.Interfaces;
using ClassLibraryProject.ManagmentClasses;
using System;

namespace ClassLibraryProject.ChildClasses
{
     public class OfficeManager :Employee
    {
        public IDepartment departmentManagment;
        public ICompany companyManagment;

        public IEmployeeManagerOffice EmployeeManagerOffice { get; set; }

        public OfficeManager(IDepartment departmentManagment, ICompany companyManagment) : base()
        { 
            this.departmentManagment = departmentManagment;
            this.companyManagment = companyManagment;
        }

        public OfficeManager(string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password)
       : base(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password)
        {
        }
        public OfficeManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password)
       : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password)
        {
        }
      
        public OfficeManager(string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, IEmployeeManagerOffice employeeManagerOffice, IDepartment departmentManagment, ICompany companyManagment)
       : base(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password)
        {
            this.EmployeeManagerOffice = employeeManagerOffice;

            this.departmentManagment = departmentManagment;
            this.companyManagment = companyManagment;
        }
        public OfficeManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, IEmployeeManagerOffice employeeManagerOffice, IDepartment departmentManagment, ICompany companyManagment)
       : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password)
        {
            this.EmployeeManagerOffice = employeeManagerOffice;

            this.departmentManagment = departmentManagment;
            this.companyManagment = companyManagment;
        }
    }
}
