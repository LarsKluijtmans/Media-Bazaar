using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ClassLibraryProject.ManagmentClasses
{
    public class PlaningManagment
    {
        public static string GET_OFFICE_EMPLOYEE = "SELECT DISTINCT EMPLOYEE.EmployeeID, FirstName, LastName, contract.JobTitle FROM `employee` INNER JOIN contract ON contract.EmployeeID = employee.EmployeeID WHERE contract.JobTitle = 'OFFICE EMPLOYEE' or contract.JobTitle = 'OFFICE MANAGER';";
        public static string GET_DEPOT_EMPLOYEE = "SELECT DISTINCT EMPLOYEE.EmployeeID, FirstName, LastName, contract.JobTitle FROM `employee` INNER JOIN contract ON contract.EmployeeID = employee.EmployeeID WHERE contract.JobTitle = 'DEPOT EMPLOYEE' or contract.JobTitle = 'DEPOT MANAGER';";
        public static string GET_SALES_EMPLOYEE = "SELECT DISTINCT EMPLOYEE.EmployeeID, FirstName, LastName, contract.JobTitle FROM `employee` INNER JOIN contract ON contract.EmployeeID = employee.EmployeeID WHERE contract.JobTitle = 'SALES Representative' or contract.JobTitle = 'SALES MANAGER';";

        public static string GET_DEPOT_PLANING = "SELECT workID, Department, employeeID, day, time FROM schduledwork WHERE department = 'DEPOT'; ";
        public static string GET_OFFICE_PLANING = "SELECT workID, Department, employeeID, day, time FROM schduledwork WHERE department = 'OFFICE'; ";
        public static string GET_SALES_PLANING = "SELECT workID, Department, employeeID, day, time FROM schduledwork WHERE department = 'SALES'; ";

        public static string UPDATE_PLANING = "UPDATE schduledwork SET employeeID = @emplyeeID  WHERE workID = @workID;";
        public static string PLAN_AUTOPLANING = "SELECT PrefranceID, contract.EmployeeID, Prefered, DAY, Time, contract.JobTitle, contract.WorkHoursPerWeek FROM workprefrance INNER JOIN contract ON contract.EmployeeID = workprefrance.EmployeeID;";

        public static string MAKE_EMPTY_SCHEDULE = "SELECT Department, Day, Morning , Afternoon, Evening FROM `schedule`;";
        public static string CREATE_SCHDULEDWORK = "INSERT INTO schduledwork (Department, EmployeeID, Day, Time) VALUE ( @depratment , @EmployeeID , @Day , @Time);";

        public static string CLEAR_PLAN = "DELETE FROM schduledwork;";

        public List<Planing> planings;
        public List<BasicEmployeeInfo> employees;

        public PlaningManagment()
        {
            planings = new List<Planing>();
            employees = new List<BasicEmployeeInfo>();
        }

        public void ViewSalesPlaning()
        {
            planings.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_SALES_PLANING;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Planing planing;

                while (reader.Read())
                {
                    int WorkId = reader.GetInt32("workID");
                    string Department = reader.GetString("Department");
                    int employeeID = reader.GetInt32("employeeID");
                    string day = reader.GetString("day");
                    string time = reader.GetString("time");


                    planing = new Planing(WorkId, Department, employeeID, day, time);

                    planings.Add(planing);
                }
            }
            catch (MySqlException )
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }

            employees.Clear();

            sql = GET_SALES_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                BasicEmployeeInfo employee;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32("EmployeeID");
                    string firstName = reader.GetString("FirstName");
                    string lastName = reader.GetString("LastName");
                    string jobTitle = reader.GetString("JobTitle");


                    employee = new BasicEmployeeInfo(employeeID, firstName, lastName, jobTitle);

                    employees.Add(employee);
                }
            }
            catch (MySqlException )
            {}
            catch (Exception)
            {}
            finally
            {
                conn.Close();
            }


        }

        public void ViewDepotPlaning()
        {
            planings.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_DEPOT_PLANING;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Planing planing;

                while (reader.Read())
                {
                    int WorkId = reader.GetInt32("workID");
                    string Department = reader.GetString("Department");
                    int employeeID = reader.GetInt32("employeeID");
                    string day = reader.GetString("day");
                    string time = reader.GetString("time");


                    planing = new Planing(WorkId, Department, employeeID, day, time);

                    planings.Add(planing);
                }
            }
            catch (MySqlException )
            {}
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }

            employees.Clear();

            sql = GET_DEPOT_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                BasicEmployeeInfo employee;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32("EmployeeID");
                    string firstName = reader.GetString("FirstName");
                    string lastName = reader.GetString("LastName");
                    string jobTitle = reader.GetString("JobTitle");


                    employee = new BasicEmployeeInfo(employeeID, firstName, lastName, jobTitle);

                    employees.Add(employee);
                }
            }
            catch (MySqlException )
            {}
            catch (Exception)
            {}
            finally
            {
                conn.Close();
            }
        }

        public void ViewOfficePlaning()
        {
            planings.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_OFFICE_PLANING;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Planing planing;

                while (reader.Read())
                {
                    int WorkId = reader.GetInt32("workID");
                    string Department = reader.GetString("Department");
                    int employeeID = reader.GetInt32("employeeID");
                    string day = reader.GetString("day");
                    string time = reader.GetString("time");


                    planing = new Planing(WorkId, Department, employeeID, day, time);

                    planings.Add(planing);
                }
            }
            catch (MySqlException )
            {}
            catch (Exception)
            {}
            finally
            {
                conn.Close();
            }

            employees.Clear();

            sql = GET_OFFICE_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                BasicEmployeeInfo employee;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32("EmployeeID");
                    string firstName = reader.GetString("FirstName");
                    string lastName = reader.GetString("LastName");
                    string jobTitle = reader.GetString("JobTitle");


                    employee = new BasicEmployeeInfo(employeeID, firstName, lastName, jobTitle);

                    employees.Add(employee);
                }
            }
            catch (MySqlException )
            {}
            catch (Exception)
            {}
            finally
            {
                conn.Close();
            }
        }

        public void EditPlaning(string WorkID, string NewEmployeeId, string Department, string Day, string Time)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_PLANING;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@emplyeeID", NewEmployeeId);
                cmd.Parameters.AddWithValue("@workID", WorkID);

                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (MySqlException )
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
        }
    }
}
