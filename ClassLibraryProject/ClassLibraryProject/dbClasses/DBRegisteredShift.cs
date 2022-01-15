using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.AutoSchedule;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.dbClasses.IGetObject;
using ClassLibraryProject.ManagmentClasses;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses
{
    public class DBRegisteredShift: IDBRegisteredShift
    {
        public string GET_ALL_EMPLOYEES = "SELECT * FROM Employee as e INNER JOIN Contract as c on e.EmployeeID = c.EmployeeID WHERE e.Active = 1;";

        private string GET_REGISTERED_SHIFTS = "SELECT * FROM planning;";
        private string REGISTER_EMPLOYEE = "INSERT INTO planning (Year, Week, Day, Shift, EmployeeID) VALUES (@Year, @Week, @Day, @Shift, @Employee);";
        private string DE_REGISTER_EMPLOYEE = "DELETE FROM planning WHERE Year = @Year AND Week = @Week AND Day = @Day AND Shift = @Shift AND EmployeeID = @Employee;";

        private List<RegisteredShift> registeredShifts;
        private List<Employee> employees;

        public DBRegisteredShift()
        {
            registeredShifts = new List<RegisteredShift>();
            employees = new List<Employee>();

            GetAllEmployees();
            GetAllRegisteredShifts();
        }
        private void GetAllRegisteredShifts()
        {
            registeredShifts.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_REGISTERED_SHIFTS;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                RegisteredShift registeredShift;

                while (reader.Read())
                {
                    int year = reader.GetInt32("Year");
                    int week = reader.GetInt32("Week");
                    string day = reader.GetString("Day");
                    string shift = reader.GetString("Shift");
                    int employeeID = reader.GetInt32("EmployeeID");

                    if(RegisteredShiftExist(year, week, day, shift) == true)
                    {
                        if (GetEmployee(employeeID) != null)
                        {
                            GetRegisteredShift(year, week, day, shift).Employees.Add(GetEmployee(employeeID));
                        }
                    }
                    else
                    {
                        if (GetEmployee(employeeID) != null)
                        {
                            registeredShift = new RegisteredShift(year, week, day, shift);
                            registeredShifts.Add(registeredShift);
                            registeredShift.Employees.Add(GetEmployee(employeeID));
                        }
                    }
                }
            }
            catch (MySqlException)
            {

            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
        }

        public Employee GetEmployee(int id)
        {
            foreach(Employee employee in employees)
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

                    if (jobTitle == "ADMIN")
                    {
                        employee = new Admin(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "CEO")
                    {
                        employee = new CEO(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "DEPOT MANAGER")
                    {
                        employee = new DepotManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "DEPOT EMPLOYEE")
                    {
                        employee = new DepotEmployee(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "OFFICE MANAGER")
                    {
                        employee = new OfficeManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "PRODUCT MANAGER")
                    {
                        employee = new ProductManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "SALES MANAGER")
                    {
                        AutoScheduleManagment autoSchedule = new AutoScheduleManagment(new AsignShiftManagment(new DbAsignShiftManagment()), new EmployeesAvailibleManagment(new DbEmployeesAvailibleManagment()), new DeletePlanningForTheWeekManagment(new DbDeletePlanningForTheWeekManagment()), new AmountOfEmployeesNeededManagment(new DbAmountOfEmployeesNeededManagment()));
                        employee = new SalesManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, new SalesDepartmentsManagment(new dbSalesDepartments()), autoSchedule, employeeManagerAll);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "SALES REPRESENTATIVE")
                    {
                        employee = new SalesRepresentative(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll);
                        employees.Add(employee);
                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public bool RegisterEmployee(int year, int week, string day, string shift, int employeeID)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = REGISTER_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Week", week);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@Shift", shift);
                cmd.Parameters.AddWithValue("@Employee", employeeID);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    GetRegisteredShift(year, week, day, shift).Employees.Add(GetEmployee(employeeID));
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool DeRegisterEmployee(int year, int week, string day, string shift, int employeeID)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = DE_REGISTER_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Week", week);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@Shift", shift);
                cmd.Parameters.AddWithValue("@Employee", employeeID);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    if (RegisteredShiftExist(year, week, day, shift) == true)
                    {
                        if (GetEmployee(employeeID) != null)
                        {
                            GetRegisteredShift(year, week, day, shift).Employees.Add(GetEmployee(employeeID));
                        }
                    }
                    else
                    {
                        if (GetEmployee(employeeID) != null)
                        {
                            RegisteredShift registeredShift = new RegisteredShift(year, week, day, shift);
                            registeredShifts.Add(registeredShift);
                            registeredShift.Employees.Add(GetEmployee(employeeID));
                        }
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }


        public RegisteredShift GetRegisteredShift(int year, int week, string day, string shift)
        {
            foreach(RegisteredShift rs in registeredShifts)
            {
                if(rs.Year == year && rs.Week == week && rs.Day == day && rs.Shift == shift)
                {
                    return rs;
                }
            }
            return null;
        }
        public bool RegisteredShiftExist(int year, int week, string day, string shift)
        {
            if(GetRegisteredShift(year, week, day, shift) != null)
            {
                return true;
            }
            return false;
        }
    }
}
