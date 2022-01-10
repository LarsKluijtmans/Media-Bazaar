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
        public static string READ_CONTRACT = "SELECT * FROM Contract as c INNER JOIN Employee as e on c.EmployeeID = e.EmployeeID WHERE c.EmployeeID = @EmployeeID;";
        public static string UPDATE_CONTRACT = "UPDATE Contract SET;";
        public static string DELETE_CONTRACT = "DELETE FROM Contract WHERE EmployeeID = @EmployeeID;";

        public bool CreateContract(Contract c)
        {
            MySqlConnection conn = Utils.GetConnection();

           // string sql = CREATE_CONTRACT;

            string sql = $"INSERT INTO Contract (EmployeeID, JobTitle, WorkHoursPerWeek, SalaryPerHour, StartDate, EndDate, Department, Active) VALUES ({c.Employee.EmployeeID}, '{c.JobTitle}', {c.WorkHoursPerWeek}, {c.SalaryPerHour}, '{c.StartDate.ToString("yyyy-MM-dd")}', '{c.EndDate.ToString("yyyy-MM-dd")}', '{c.Department}', 1);";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                //cmd.Parameters.AddWithValue("@EmployeeID", c.Employee.EmployeeID);
                //cmd.Parameters.AddWithValue("@WorkHoursPerWeek", c.WorkHoursPerWeek);
                //cmd.Parameters.AddWithValue("@SalaryPerHour", c.SalaryPerHour);
                //cmd.Parameters.AddWithValue("@StartDate", c.StartDate.ToString("yyyy-MM-dd"));
                //cmd.Parameters.AddWithValue("@EndDate", c.EndDate.ToString("yyyy-MM-dd"));
                //cmd.Parameters.AddWithValue("@Department", c.Department);
                //cmd.Parameters.AddWithValue("@Active", 1);
                //cmd.Parameters.AddWithValue("@JobTitle", c.JobTitle);
              

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows == 1)
                {
                    return true;
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

            return false;
        }

        public bool DeleteContract(Contract c)
        {
            throw new NotImplementedException();
        }

        public Contract ReadContract(Employee e)
        {
            throw new NotImplementedException();
        }

        public bool UpdateContract(Contract c)
        {
            throw new NotImplementedException();
        }

        // Send Email for new contract
    }
}
