using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using ClassLibraryProject.ManagmentClasses;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace ClassLibraryProject
{
    public class DBEmployeeManager : IDBEmployeeManagerOffice
    {
        // sql
        public static string CREATE_EMPLOYEE = "INSERT INTO Employee (FirstName, LastName, UserName, Password, BSN, Active, City, Email, PhoneNumber, DateOfBirth, StreetName, ZipCode) VALUES (@FirstName, @LastName, @Username, @Password, @BSN, @Active, @City, @Email, @PhoneNumber, @DateOfBirth, @StreetName, @ZipCode);";
        public static string READ_EMPLOYEES = "SELECT * FROM Employee as e INNER JOIN Contract as c on e.EmployeeID = c.EmployeeID WHERE e.Active = @Active;";
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

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@FirstName", e.FirstName);
                cmd.Parameters.AddWithValue("@LastName", e.LastName);
                cmd.Parameters.AddWithValue("@Username", e.Username);
                cmd.Parameters.AddWithValue("@Password", e.Password);
                cmd.Parameters.AddWithValue("@BSN", e.BSN);
                cmd.Parameters.AddWithValue("@Active", 1);
                cmd.Parameters.AddWithValue("@City", e.City);
                cmd.Parameters.AddWithValue("@Email", e.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", e.PhoneNumber);
                cmd.Parameters.AddWithValue("@DateOfBirth", e.DateOfBirth);
                cmd.Parameters.AddWithValue("@StreetName", e.StreetName);
                cmd.Parameters.AddWithValue("@ZipCode", e.ZipCode);

                int numCreatedRows = cmd.ExecuteNonQuery();
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return true;
        }
        public List<Employee> ReadEmployees()
        {
            List<Employee> employees = new List<Employee>();

            MySqlConnection conn = Utils.GetConnection();
            string sql = READ_EMPLOYEES;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@Active", 1);

                MySqlDataReader reader = cmd.ExecuteReader();

                Employee employee;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32(0);
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string username = reader.GetString(3);
                    string password = reader.GetString(4);
                    int bsn = reader.GetInt32(5);
                    string city = reader.GetString(7);
                    string email = reader.GetString(8);
                    string phoneNumber = reader.GetString(9);
                    DateTime dateOfBirth = reader.GetDateTime(10);
                    string streetName = reader.GetString(12);
                    string zipCode = reader.GetString(13);
                    string jobTitle = reader.GetString(16);

                    if (jobTitle == "ADMIN")
                    {
                        IAddEmployee addEmployee = new AdminAddEmployee();
                        employee = new Admin(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, addEmployee);
                        employees.Add(employee);
                    } else if (jobTitle == "CEO")
                    {
                        employee = new CEO(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        employees.Add(employee);
                    } else if (jobTitle == "DEPOT MANAGER")
                    {
                        employee = new DepotManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        employees.Add(employee);
                    } else if (jobTitle == "DEPOT EMPLOYEE")
                    {
                        employee = new DepotEmployee(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        employees.Add(employee);
                    } else if (jobTitle == "OFFICE MANAGER")
                    {
                        employee = new OfficeManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        employees.Add(employee);
                    } else if (jobTitle == "PRODUCT MANAGER")
                    {
                        employee = new ProductManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        employees.Add(employee);
                    } else if (jobTitle == "SALES MANAGER")
                    {
                        employee = new SalesManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "SALES REPRESENTATIVE")
                    {
                        employee = new SalesRepresentative(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        employees.Add(employee);
                    }
                }
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return employees;
        }

        public bool DeleteEmployee(Employee e)
        {
            throw new NotImplementedException();
        }

        

        public bool UpdateEmployee(Employee e)
        {
            throw new NotImplementedException();
        }
    }
}
