using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using ClassLibraryProject.ManagmentClasses;
using System;
using System.Collections.Generic;
using System.Text;

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

        public OfficeManager(int employeeID, string lastname, string firstname, int phonenumber, string email, string city, string dateofbirth, int bsn, string username, string password)
       : base(employeeID, lastname, firstname, phonenumber, email, city, dateofbirth, bsn, username, password)
        {
            departmentManagment = new DepartmentManagment(new dbDepartmentManagment());
            companyManagment = new CompanyManagment(new dbCompanyManagment());
        }
    }
}
