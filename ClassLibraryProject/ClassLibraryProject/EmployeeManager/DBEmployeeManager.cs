using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ClassLibraryProject
{
    public class DBEmployeeManager : IDBEmployeeManagerOffice
    {
        // sql
        public static string CREATE_EMPLOYEE = "INSERT INTO Employee (FirstName, LastName, UserName, Password, BSN, Active, City, Email, PhoneNumber, DateOfBirth, StreetName, ZipCode) VALUES (@FirstName, @LastName, @Username, @Password, @BSN, @Active, @City, @Email, @PhoneNumber, @DateOfBirth, @StreetName, @ZipCode);";
        public static string READ_EMPLOYEES = "SELECT * FROM Employee as e INNER JOIN Contract as c on e.EmployeeID = c.EmployeeID;";
        public static string UPDATE_EMPLOYEE = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, City = @City, PhoneNumber = @PhoneNumber, StreetName = @StreetName, ZipCode = @ZipCode WHERE EmployeeID = @EmployeeID;";
        public static string DELETE_EMPLOYEE = "UPDATE Employee SET Active = @Active WHERE EmployeeID = @EmployeeID;";

        /*public static string CREATE_EMPLOYEE = "INSERT INTO Employee (FirstName, LastName, UserName, Password, BSN, Active, Address, Email, PhoneNumber, DateOfBirth) VALUES (@FirstName, @LastName, @Username, @Password, @BSN, @Active, @City, @Email, @PhoneNumber, @DateOfBirth);";
        public static string GET_ALL_EMPLOYEES = "SELECT * FROM Employee ORDER BY EmployeeID LIMIT 25;";
        public static string UPDATE_EMPLOYEE = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, Address = @City, PhoneNumber = @PhoneNumber WHERE EmployeeID = @EmployeeID;";
        public static string DELETE_EMPLOYEE_BY_ID = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";*/

        public bool CreateEmployee(Employee e)
        {
            if (!Regex.IsMatch(e.ZipCode, @"^[0-9]{4}[A-Z]{2}$"))
            {
                return false;
            }
            if (!Regex.IsMatch(e.Email, @"[a-z]@mb.com"))
            {
                return false;
            }
            if (!Regex.IsMatch(e.BSN.ToString(), @"\b[0-9]{8,9}\b"))
            {
                return false;
            }
            if (!Regex.IsMatch(e.PhoneNumber, @"^(\+)316[0-9]{8}$"))
            {
                return false;
            }
            if (!Regex.IsMatch(e.DateOfBirth.ToString("dd/MM/yyyy"), @"((?:0[0-9])|(?:[1-2][0-9])|(?:3[0-1]))\/((?:0[1-9])|(?:1[0-2]))\/(\d{4})"))
            {
                return false;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = CREATE_EMPLOYEE;

            return true;
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
