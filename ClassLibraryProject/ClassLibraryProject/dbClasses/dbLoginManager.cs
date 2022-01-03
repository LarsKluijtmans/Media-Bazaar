using System;
using System.Diagnostics;
using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using MySql.Data.MySqlClient;

namespace ClassLibraryProject.dbClasses
{
     public class dbLoginManager : ILoginManagement
    {
        private string LOGIN_EMPLOYEE = " SELECT * FROM employee as e INNER JOIN contract as c ON c.employeeID = e.Employeeid where e.UserName = @UserName  AND e.Password = @Password AND e.Active = 1 ;";
        private string GET_EMPLOYEEID = " SELECT employeeID, password, userName FROM employee where UserName = @UserName";


        public Employee checkLogin(string givenUsername, string givenPassword)
        {
            /*Employee employee = new CEO();
            Contract contract;
            MySqlConnection conn = Utils.GetConnection();
            string sql = LOGIN_BY_EMPLOYEEID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@UserName", givenUsername); 
                cmd.Parameters.AddWithValue("@Password", givenPassword);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    switch (reader["JobTitle"])
                    {
                        case "CEO": employee = new CEO( Convert.ToInt32(reader["EmployeeID"]), reader["LastName"].ToString(), reader["FirstName"].ToString(), Convert.ToInt32(reader["PhoneNumber"]), reader["Email"].ToString(), reader["Address"].ToString(), reader["DateOfBirth"].ToString(), Convert.ToInt32(reader["BSN"]), reader["UserName"].ToString(),  reader["Password"].ToString());
                            contract = new Contract(Convert.ToInt32(reader["EmployeeID"]), reader["JobTitle"].ToString(),Convert.ToInt32(reader["WorkHoursPerWeek"]), Convert.ToInt32(reader["SalaryPerHour"]), reader["StartDate"].ToString());
                            employee.Contract = contract;
                            break;
                        case "ADMIN": employee = new Admin(Convert.ToInt32(reader["EmployeeID"]), reader["LastName"].ToString(), reader["FirstName"].ToString(), Convert.ToInt32(reader["PhoneNumber"]), reader["Email"].ToString(), reader["Address"].ToString(), reader["DateOfBirth"].ToString(), Convert.ToInt32(reader["BSN"]), reader["UserName"].ToString(), reader["Password"].ToString());
                            contract = new Contract(Convert.ToInt32(reader["EmployeeID"]), reader["JobTitle"].ToString(), Convert.ToInt32(reader["WorkHoursPerWeek"]), Convert.ToInt32(reader["SalaryPerHour"]), reader["StartDate"].ToString());
                            employee.Contract = contract;
                            break;
                        case "SALES MANAGER": employee = new SalesManager(Convert.ToInt32(reader["EmployeeID"]), reader["LastName"].ToString(), reader["FirstName"].ToString(), Convert.ToInt32(reader["PhoneNumber"]), reader["Email"].ToString(), reader["Address"].ToString(), reader["DateOfBirth"].ToString(), Convert.ToInt32(reader["BSN"]), reader["UserName"].ToString(), reader["Password"].ToString());
                            contract = new Contract(Convert.ToInt32(reader["EmployeeID"]), reader["JobTitle"].ToString(), Convert.ToInt32(reader["WorkHoursPerWeek"]), Convert.ToInt32(reader["SalaryPerHour"]), reader["StartDate"].ToString());
                            employee.Contract = contract;
                            break;
                        case "OFFICE MANAGER": employee = new OfficeManager(Convert.ToInt32(reader["EmployeeID"]), reader["LastName"].ToString(), reader["FirstName"].ToString(), Convert.ToInt32(reader["PhoneNumber"]), reader["Email"].ToString(), reader["Address"].ToString(), reader["DateOfBirth"].ToString(), Convert.ToInt32(reader["BSN"]), reader["UserName"].ToString(), reader["Password"].ToString());
                            contract = new Contract(Convert.ToInt32(reader["EmployeeID"]), reader["JobTitle"].ToString(), Convert.ToInt32(reader["WorkHoursPerWeek"]), Convert.ToInt32(reader["SalaryPerHour"]), reader["StartDate"].ToString());
                            employee.Contract = contract;
                            break;
                        case "PRODUCT MANAGER": employee = new ProductManager(Convert.ToInt32(reader["EmployeeID"]), reader["LastName"].ToString(), reader["FirstName"].ToString(), Convert.ToInt32(reader["PhoneNumber"]), reader["Email"].ToString(), reader["Address"].ToString(), reader["DateOfBirth"].ToString(), Convert.ToInt32(reader["BSN"]), reader["UserName"].ToString(), reader["Password"].ToString());
                            contract = new Contract(Convert.ToInt32(reader["EmployeeID"]), reader["JobTitle"].ToString(), Convert.ToInt32(reader["WorkHoursPerWeek"]), Convert.ToInt32(reader["SalaryPerHour"]), reader["StartDate"].ToString());
                            employee.Contract = contract;
                            break;
                        case "DEPOT MANAGER": employee = new DepotManager(Convert.ToInt32(reader["EmployeeID"]), reader["LastName"].ToString(), reader["FirstName"].ToString(), Convert.ToInt32(reader["PhoneNumber"]), reader["Email"].ToString(), reader["Address"].ToString(), reader["DateOfBirth"].ToString(), Convert.ToInt32(reader["BSN"]), reader["UserName"].ToString(), reader["Password"].ToString());
                            contract = new Contract(Convert.ToInt32(reader["EmployeeID"]), reader["JobTitle"].ToString(), Convert.ToInt32(reader["WorkHoursPerWeek"]), Convert.ToInt32(reader["SalaryPerHour"]), reader["StartDate"].ToString());
                            employee.Contract = contract;
                            break;
                        case "DEPOT EMPLOYEE": employee = new DepotEmployee(Convert.ToInt32(reader["EmployeeID"]), reader["LastName"].ToString(), reader["FirstName"].ToString(), Convert.ToInt32(reader["PhoneNumber"]), reader["Email"].ToString(), reader["Address"].ToString(), reader["DateOfBirth"].ToString(), Convert.ToInt32(reader["BSN"]), reader["UserName"].ToString(), reader["Password"].ToString());
                            contract = new Contract(Convert.ToInt32(reader["EmployeeID"]), reader["JobTitle"].ToString(), Convert.ToInt32(reader["WorkHoursPerWeek"]), Convert.ToInt32(reader["SalaryPerHour"]), reader["StartDate"].ToString());
                            employee.Contract = contract;
                            break;
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
            return employee;*/

            MySqlConnection conn = Utils.GetConnection();
            string sql = LOGIN_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@Username", givenUsername);
                cmd.Parameters.AddWithValue("@Password", givenPassword);

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
                        employee = new Admin(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        return employee;
                    }
                    else if (jobTitle == "CEO")
                    {
                        employee = new CEO(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        return employee;
                    }
                    else if (jobTitle == "DEPOT MANAGER")
                    {
                        employee = new DepotManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        return employee;
                    }
                    else if (jobTitle == "DEPOT EMPLOYEE")
                    {
                        employee = new DepotEmployee(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        return employee;
                    }
                    else if (jobTitle == "OFFICE MANAGER")
                    {
                        employee = new OfficeManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        return employee;
                    }
                    else if (jobTitle == "PRODUCT MANAGER")
                    {
                        employee = new ProductManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        return employee;
                    }
                    else if (jobTitle == "SALES MANAGER")
                    {
                        employee = new SalesManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        return employee;
                    }
                    else if (jobTitle == "SALES REPRESENTATIVE")
                    {
                        employee = new SalesRepresentative(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        return employee;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return null;
        }

        public int GetID(string UserName, string Password)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_EMPLOYEEID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@UserName", UserName);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[2].ToString() == UserName.ToString() && reader[1].ToString() == Password.ToString())
                    {
                        return Convert.ToInt32(reader[0]);
                    }
                }
                return 0;
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
            return 0;
        }
    }
}
