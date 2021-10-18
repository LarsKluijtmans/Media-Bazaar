using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public class PreferedWorkTimeManagement
    {
        // sql
        public static string CREATE_PWT = "INSERT INTO PreferedWorkTime (FirstName, LastName, UserName, Password, BSN, Active, Address, Email, PhoneNumber, DateOfBirth) VALUES (@FirstName, @LastName, @Username, @Password, @BSN, @Active, @City, @Email, @PhoneNumber, @DateOfBirth);";
        public static string GET_ALL_PWT = "SELECT * FROM Employee ORDER BY EmployeeID;";
        public static string UPDATE_PWT = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, Address = @City, PhoneNumber = @PhoneNumber WHERE EmployeeID = @EmployeeID;";
        public static string DELETE_PWT_BY_ID = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";

        //public static string VIEW_EMPLOYEE = "SELECT * FROM Employee WHERE EmployeeID = @EmployeeID;";
        public static string VIEW_PWT_BY_ID = "UPDATE Employee SET Active = @Active WHERE EmployeeID = @EmployeeID;";

        // constructor
        public PreferedWorkTimeManagement()
        {

        }

        // methods
    }
}
