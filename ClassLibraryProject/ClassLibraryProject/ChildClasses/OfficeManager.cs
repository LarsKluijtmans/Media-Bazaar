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

        public OfficeManager() : base()
        { 
            departmentManagment = new DepartmentManagment(new dbDepartmentManagment());
            companyManagment = new CompanyManagment(new dbCompanyManagment());
        }
        public OfficeManager(string firstName, string lastName, int phoneNumber, string email, string city, DateTime dateOfBirth, int bsn, string username, string password)
       : base(firstName, lastName, phoneNumber, email, city, dateOfBirth, bsn, username, password)
        {
            departmentManagment = new DepartmentManagment(new dbDepartmentManagment());
            companyManagment = new CompanyManagment(new dbCompanyManagment());
        }
        public OfficeManager(int employeeID, string firstName, string lastName, int phoneNumber, string email, string city, DateTime dateOfBirth, int bsn, string username, string password)
       : base(employeeID, firstName, lastName, phoneNumber, email, city, dateOfBirth, bsn, username, password)
        {
            departmentManagment = new DepartmentManagment(new dbDepartmentManagment());
            companyManagment = new CompanyManagment(new dbCompanyManagment());
        }
    }
}
