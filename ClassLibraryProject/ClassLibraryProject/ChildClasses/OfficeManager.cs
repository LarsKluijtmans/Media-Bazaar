using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using ClassLibraryProject.ManagmentClasses;
using System;

namespace ClassLibraryProject.ChildClasses
{
     public class OfficeManager :Employee
    {
        public DepartmentManagment departmentManagment;
        public CompanyManagment companyManagment;

        public IEmployeeManagerOffice EmployeeManagerOffice { get; set; }

        public OfficeManager() : base()
        { 
            departmentManagment = new DepartmentManagment(new dbDepartmentManagment());
            companyManagment = new CompanyManagment(new dbCompanyManagment());
        }
        public OfficeManager(string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password)
       : base(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password)
        {
            departmentManagment = new DepartmentManagment(new dbDepartmentManagment());
            companyManagment = new CompanyManagment(new dbCompanyManagment());
        }
        public OfficeManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password)
       : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password)
        {
            departmentManagment = new DepartmentManagment(new dbDepartmentManagment());
            companyManagment = new CompanyManagment(new dbCompanyManagment());
        }
        public OfficeManager(string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, IEmployeeManagerOffice employeeManagerOffice)
       : base(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password)
        {
            this.EmployeeManagerOffice = employeeManagerOffice;

            departmentManagment = new DepartmentManagment(new dbDepartmentManagment());
            companyManagment = new CompanyManagment(new dbCompanyManagment());
        }
        public OfficeManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, IEmployeeManagerOffice employeeManagerOffice)
       : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password)
        {
            this.EmployeeManagerOffice = employeeManagerOffice;

            departmentManagment = new DepartmentManagment(new dbDepartmentManagment());
            companyManagment = new CompanyManagment(new dbCompanyManagment());
        }
    }
}
