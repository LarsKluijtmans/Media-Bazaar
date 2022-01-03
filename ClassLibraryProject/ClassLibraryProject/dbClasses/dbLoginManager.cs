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
        private string LOGIN_BY_EMPLOYEEID = " SELECT * FROM employee INNER JOIN contract ON contract.employeeID = employee.Employeeid where employee.UserName = @UserName  AND Password = @Password AND Active = 1 ;";
        private string GET_EMPLOYEEID = " SELECT employeeID, password, userName FROM employee where UserName = @UserName";


        public Employee checkLogin(string userName, string password)
        {
            Employee employee = new CEO();
            Contract contract;
            MySqlConnection conn = Utils.GetConnection();
            string sql = LOGIN_BY_EMPLOYEEID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@UserName", userName); 
                cmd.Parameters.AddWithValue("@Password", password);

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
            return employee;
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
