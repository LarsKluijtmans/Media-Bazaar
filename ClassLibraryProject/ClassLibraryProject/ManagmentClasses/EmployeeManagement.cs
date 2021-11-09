using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ClassLibraryProject.Class;
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

        //MohammadStart
        private static string GET_AVAILABLE_EMPLOYEE = "SELECT EmployeeID FROM availability WHERE Week = @Week AND Day = @Day AND Shift = @Shift;";
        private static string GET_ENLISTED_EMPLOYEE = "SELECT EmployeeID FROM planning WHERE Year = @Year AND Week = @Week AND Day = @Day AND Shift = @Shift;";

        private List<Employee> availableEmployee;
        private List<Employee> enlistedEmployee;

        public List<Employee> AvailableEmployee
        {
            get { return availableEmployee; }
            set { availableEmployee = value; }
        }
        public List<Employee> EnlistedEmployee
        {
            get { return enlistedEmployee; }
            set { enlistedEmployee = value; }
        }
        public EmployeeManagement()
        {
            AvailableEmployee = new List<Employee>();
            EnlistedEmployee = new List<Employee>();
        }

        public void GetAvailableEmployees(int week, string day, string shift)
        {
            AvailableEmployee.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_AVAILABLE_EMPLOYEE;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Week", week);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@Shift", shift);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Employee employee;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32("EmployeeID");

                    //employee = new Employee(employeeID);
                    //AvailableEmployee.Add(employee);
                }
            }
            catch (MySqlException)
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
        }
        public void GetEnlistedEmployees(int year, int week, string day, string shift)
        {
            EnlistedEmployee.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ENLISTED_EMPLOYEE;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Week", week);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@Shift", shift);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Employee employee;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32("EmployeeID");

                    //employee = new Employee(employeeID);
                   // EnlistedEmployee.Add(employee);
                }
            }
            catch (MySqlException)
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
        }
        //MohammadEnd



    }
}
