using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses
{
    public class EmployeeManagement
    {
        // fields

        // sql
        public static string CREATE_EMPLOYEE = "INSERT INTO Employee (FirstName, LastName, UserName, Password, BSN, Active, Address, Email, PhoneNumber, DateOfBirth) VALUES (@FirstName, @LastName, @Username, @Password, @BSN, @Active, @City, @Email, @PhoneNumber, @DateOfBirth);";
        public static string GET_ALL_EMPLOYEES = "SELECT * FROM Employee ORDER BY EmployeeID;";
        public static string UPDATE_EMPLOYEE = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, Address = @City, PhoneNumber = @PhoneNumber WHERE EmployeeID = @EmployeeID;";
        public static string DELETE_EMPLOYEE_BY_ID = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";

        public static string VIEW_EMPLOYEE = "SELECT * FROM Employee WHERE EmployeeID = @EmployeeID;";
        public static string REMOVE_EMPLOYEE_BY_ID = "UPDATE Employee SET Active = @Active WHERE EmployeeID = @EmployeeID;";

        // properties

        // constructor
        public EmployeeManagement()
        {

        }

        // methods


        
    }
}
