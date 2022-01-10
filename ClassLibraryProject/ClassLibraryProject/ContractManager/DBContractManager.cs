using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ClassLibraryProject
{
    public class DBContractManager : IDBContractManager
    {
        // sql
        public static string CREATE_CONTRACT = "INSERT INTO Contract (EmployeeID, JobTitle, WorkHoursPerWeek, SalaryPerHour, StartDate, EndDate, Department, Active) VALUES (@EmployeeID, '@JobTitle', @WorkHoursPerWeek, @SalaryPerHour, '@StartDate', '@EndDate', '@Department', @Active);";
        public static string READ_CONTRACT = "SELECT * FROM Contract WHERE EmployeeID = @EmployeeID AND Active = @Active;";
        public static string UPDATE_CONTRACT = "UPDATE Contract SET;";
        public static string DELETE_CONTRACT = "DELETE FROM Contract WHERE EmployeeID = @EmployeeID;";

        public bool CreateContract(Contract c)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = CREATE_CONTRACT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@EmployeeID", c.Employee.EmployeeID);
                cmd.Parameters.AddWithValue("@WorkHoursPerWeek", c.WorkHoursPerWeek);
                cmd.Parameters.AddWithValue("@SalaryPerHour", c.SalaryPerHour);
                cmd.Parameters.AddWithValue("@StartDate", c.StartDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@EndDate", c.EndDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Department", c.Department);
                cmd.Parameters.AddWithValue("@Active", 1);

                if (c.Employee is CEO)
                {
                    cmd.Parameters.AddWithValue("@JobTitle", "CEO");
                } else if (c.Employee is Admin)
                {
                    cmd.Parameters.AddWithValue("@JobTitle", "ADMIN");
                }
                else if (c.Employee is DepotEmployee)
                {
                    cmd.Parameters.AddWithValue("@JobTitle", "DEPOT EMPLOYEE");
                }
                else if (c.Employee is DepotManager)
                {
                    cmd.Parameters.AddWithValue("@JobTitle", "DEPOT MANAGER");
                }
                else if (c.Employee is OfficeManager)
                {
                    cmd.Parameters.AddWithValue("@JobTitle", "OFFICE MANAGER");
                }
                else if (c.Employee is ProductManager)
                {
                    cmd.Parameters.AddWithValue("@JobTitle", "PRODUCT MANAGER");
                }
                else if (c.Employee is SalesManager)
                {
                    cmd.Parameters.AddWithValue("@JobTitle", "SALES MANAGER");
                }
                else if (c.Employee is SalesRepresentative)
                {
                    cmd.Parameters.AddWithValue("@JobTitle", "SALES REPRESENTATIVE");
                }

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

        public bool DeleteContract(Contract c)
        {
            throw new NotImplementedException();
        }

        public Contract ReadContract(Employee e)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = READ_CONTRACT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@EmployeeID", e.EmployeeID);
                cmd.Parameters.AddWithValue("@Active", 1);

                MySqlDataReader reader = cmd.ExecuteReader();

                Contract contract;

                while (reader.Read())
                {
                    string jobTitle = reader.GetString(2);
                    int workHoursPerWeek = reader.GetInt32(3);
                    double salaryPerHour = reader.GetDouble(4);
                    DateTime startDate = reader.GetDateTime(5);
                    DateTime endDate = reader.GetDateTime(6);
                    string department = reader.GetString(8);

                    contract = new Contract(e, jobTitle, workHoursPerWeek, salaryPerHour, startDate, endDate, department);
                    return contract;
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

            return null;
        }

        public bool UpdateContract(Contract c)
        {
            throw new NotImplementedException();
        }

        // Send Email for new contract
    }
}
