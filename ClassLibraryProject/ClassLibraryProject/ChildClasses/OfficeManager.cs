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
        public IContractManager ContractManager { get; set; }

        public OfficeManager(IDepartment departmentManagment, ICompany companyManagment) : base()
        { 
            this.departmentManagment = departmentManagment;
            this.companyManagment = companyManagment;
        }

        public OfficeManager(string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail)
       : base(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {
        }
        public OfficeManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail)
       : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {
        }
      
        public OfficeManager(string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IEmployeeManagerOffice employeeManagerOffice, IDepartment departmentManagment, ICompany companyManagment,  IContractManager contractManager)
       : base(firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {
            this.EmployeeManagerOffice = employeeManagerOffice;
            this.ContractManager = contractManager;

            this.departmentManagment = departmentManagment;
            this.companyManagment = companyManagment;
        }
        public OfficeManager(int employeeID, string firstName, string lastName, string phoneNumber, string email, string zipCode, string streetName, string city, DateTime dateOfBirth, int bsn, string username, string password, string personalEmail, IEmployeeManagerOffice employeeManagerOffice, IDepartment departmentManagment, ICompany companyManagment,  IContractManager contractManager)
       : base(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail)
        {
            this.EmployeeManagerOffice = employeeManagerOffice;
            this.ContractManager = contractManager;

            this.departmentManagment = departmentManagment;
            this.companyManagment = companyManagment;
        }
    }
}
