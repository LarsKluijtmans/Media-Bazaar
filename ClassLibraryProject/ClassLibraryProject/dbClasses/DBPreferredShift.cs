using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.AutoSchedule;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.ManagmentClasses;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ClassLibraryProject.dbClasses
{
    public class DBPreferredShift: IDBPreferredShift
    {
        public string GET_ALL_EMPLOYEES = "SELECT * FROM Employee as e INNER JOIN Contract as c on e.EmployeeID = c.EmployeeID WHERE e.Active = 1 AND c.Active = 1;";

        private string GET_PREFERRED_SHIFTS = "SELECT * FROM preferedtime;";
        private string PREFER_SHIFT = "INSERT INTO preferedtime (Week, Day, Shift, EmployeeID) VALUES (@Week, @Day, @Shift, @Employee);";
        private string DELETE_PREFERRED_SHIFT = "DELETE FROM preferedtime WHERE Week = @Week AND Day = @Day AND Shift = @Shift AND EmployeeID = @EmployeeID;";

        private List<PreferredShift> preferredShifts;
        private List<Employee> employees;

        public DBPreferredShift()
        {
            preferredShifts = new List<PreferredShift>();
            employees = new List<Employee>();

            GetAllEmployees();
            GetAllPreferredShifts();
        }
        private void GetAllPreferredShifts()
        {
            preferredShifts.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_PREFERRED_SHIFTS;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                PreferredShift preferredShift;

                while (reader.Read())
                {
                    string day = reader.GetString("Day");
                    string shift = reader.GetString("Shift");
                    int employeeID = reader.GetInt32("EmployeeID");

                    if (PreferredShiftExist(day, shift) == true)
                    {
                        if (GetEmployee(employeeID) != null)
                        {
                            GetPreferredShift(day, shift).Employees.Add(GetEmployee(employeeID));
                        }
                    }
                    else
                    {
                        if (GetEmployee(employeeID) != null)
                        {
                            preferredShift = new PreferredShift(day, shift);
                            preferredShifts.Add(preferredShift);
                            preferredShift.Employees.Add(GetEmployee(employeeID));
                        }
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
        }

        public Employee GetEmployee(int id)
        {
            foreach (Employee employee in employees)
            {
                if (employee.EmployeeID == id)
                {
                    return employee;
                }
            }
            return null;
        }
        private void GetAllEmployees()
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_ALL_EMPLOYEES;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

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
                    string personalEmail = reader.GetString(14);
                    string jobTitle = reader.GetString(17);

                    IEmployeeManagerAll employeeManagerAll = new EmployeeManager();

                    if (jobTitle == "DEPOT EMPLOYEE")
                    {
                        employee = new DepotEmployee(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll);
                        employees.Add(employee);
                    }
                    if (jobTitle == "SALES REPRESENTATIVE")
                    {
                        employee = new SalesRepresentative(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll);
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
        }

        public bool PreferAShift(string day, string shift, Employee employee)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = PREFER_SHIFT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@Shift", shift);
                cmd.Parameters.AddWithValue("@Employee", employee.EmployeeID);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    PreferredShift preferredShift = new PreferredShift(day, shift);
                    preferredShift.Employees.Add(employee);
                    return true;
                }
                return false;
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

            return false;
        }
        public bool DeletePreferredShift(string day, string shift, Employee employee)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = DELETE_PREFERRED_SHIFT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@Shift", shift);
                cmd.Parameters.AddWithValue("@Employee", employee.EmployeeID);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    GetPreferredShift(day, shift).Employees.Remove(employee);
                    return true;
                }
                return false;
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
            return false;
        }

        public PreferredShift GetPreferredShift(string day, string shift)
        {
            foreach (PreferredShift ps in preferredShifts)
            {
                if (ps.Day == day && ps.Shift == shift)
                {
                    return ps;
                }
            }
            return null;
        }
        public bool PreferredShiftExist(string day, string shift)
        {
            if (GetPreferredShift(day, shift) != null)
            {
                return true;
            }
            return false;
        }
    }
}
