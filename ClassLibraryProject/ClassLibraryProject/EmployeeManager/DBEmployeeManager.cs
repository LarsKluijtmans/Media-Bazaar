using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public class DBEmployeeManager : IDBEmployeeManagerOffice
    {
        // sql
        public static string CREATE_EMPLOYE = "INSERT INTO Employee (FirstName, LastName, UserName, Password, BSN, Active, City, Email, PhoneNumber, DateOfBirth, StreetName, ZipCode) VALUES (@FirstName, @LastName, @Username, @Password, @BSN, @Active, @City, @Email, @PhoneNumber, @DateOfBirth, @StreetName, @ZipCode);";
        public static string READ_EMPLOYEES;
        public static string UPDATE_EMPLOYEE;
        public static string DELETE_EMPLOYEE;

        /*public static string CREATE_EMPLOYEE = "INSERT INTO Employee (FirstName, LastName, UserName, Password, BSN, Active, Address, Email, PhoneNumber, DateOfBirth) VALUES (@FirstName, @LastName, @Username, @Password, @BSN, @Active, @City, @Email, @PhoneNumber, @DateOfBirth);";
        public static string GET_ALL_EMPLOYEES = "SELECT * FROM Employee ORDER BY EmployeeID LIMIT 25;";
        public static string UPDATE_EMPLOYEE = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, Address = @City, PhoneNumber = @PhoneNumber WHERE EmployeeID = @EmployeeID;";
        public static string DELETE_EMPLOYEE_BY_ID = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";*/

        public bool CreateEmployee(Employee e)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEmployee(Employee e)
        {
            throw new NotImplementedException();
        }

        public List<Employee> ReadEmployees()
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmployee(Employee e)
        {
            throw new NotImplementedException();
        }
    }
}
