using ClassLibraryProject.Interfaces;
using System;
using System.Collections.Generic;
using ClassLibraryProject.Class;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace ClassLibraryProject.dbClasses.AutoSchedule
{
    public class DbEmployeesAvailibleManagment : IDbEmployeesAvailibleManagment
    {

      private string EMPLYEES_WITH_PREFERED_SHIFT = "SELECT employee.`EmployeeID`, contract.Department, Employee.Active, contract.WorkHoursPerWeek,preferedtime.Day,preferedtime.Shift FROM `employee`  INNER JOIN contract on employee.EmployeeID = contract.EmployeeID INNER JOIN preferedtime on Employee.EmployeeID = preferedtime.EmployeeID where contract.Department = '@department' AND Employee.Active = 1 AND preferedtime.Shift = '@shift' and preferedtime.Day = '@day' AND contract.JobTitle NOT LIKE '%Manager%' AND preferedtime.Prefered = 1 AND(employee.`EmployeeID`) NOT IN (select availability.EmployeeID from availability where day = '@day' AND WEEK = @week AND YEAR = @year) and(contract.WorkHoursPerWeek, contract.EmployeeID) NOT IN(Select Count(planning.EmployeeID)*4, planning.EmployeeID from planning where week = @week AND year = @year group by week, year ,EmployeeID) ;";
        
        //GET EMPLOYEES

        //Prefered
        public List<int> EmployeesShiftPrefered(string shift, string day, int week, int year, string department)
        {
            List<int> Employees = new List<int>();

            MySqlConnection conn = Utils.GetConnection();

            string sql = EMPLYEES_WITH_PREFERED_SHIFT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@department", department);
                cmd.Parameters.AddWithValue("@day", day);
                cmd.Parameters.AddWithValue("@shift", shift);
                cmd.Parameters.AddWithValue("@week", week);
                cmd.Parameters.AddWithValue("@year", year);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employees.Add(Convert.ToInt32(reader[0]));
                }
            }
            catch (MySqlException a)
            { Debug.WriteLine(a.Message); }
            catch (Exception a)
            { Debug.WriteLine(a.Message); }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return Employees;
        }
        //Withought Preference
        public List<int> EmployeesWithoughtPreference(string shift, string day, int week, int year, string department)
        {
            List<int> Employees = new List<int>();

            MySqlConnection conn = Utils.GetConnection();

            string sql = $"SELECT employee.`EmployeeID`, contract.Department, Employee.Active, contract.WorkHoursPerWeek FROM `employee`  INNER JOIN contract on employee.EmployeeID = contract.EmployeeID where contract.Department = '{department}' AND contract.JobTitle NOT LIKE '%Manager%' AND Employee.Active = 1 AND(employee.`EmployeeID`) NOT IN (select availability.EmployeeID from availability where day = '{day}' AND WEEK = {week} AND YEAR = {year}) and(contract.WorkHoursPerWeek, contract.EmployeeID) NOT IN(Select Count(planning.EmployeeID)*4, planning.EmployeeID from planning where week = {week} AND YEAR = {year} group by week, EmployeeID);";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employees.Add(Convert.ToInt32(reader[0]));
                }
            }
            catch (MySqlException a)
            { Debug.WriteLine(a.Message); }
            catch (Exception a)
            { Debug.WriteLine(a.Message); }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return Employees;
        }
        //Unprefered
        public List<int> EmployeesUnPrefered(string shift, string day, int week, int year, string department)
        {
            List<int> Employees = new List<int>();

            MySqlConnection conn = Utils.GetConnection();

            string sql = $"SELECT employee.`EmployeeID`, contract.Department, Employee.Active, contract.WorkHoursPerWeek,preferedtime.Day,preferedtime.Shift FROM `employee`  INNER JOIN contract on employee.EmployeeID = contract.EmployeeID INNER JOIN preferedtime on Employee.EmployeeID = preferedtime.EmployeeID where contract.Department = '{department}' AND contract.JobTitle NOT LIKE '%Manager%' AND Employee.Active = 1 AND preferedtime.Shift = '{shift}' and preferedtime.Day = '{day}' AND preferedtime.Prefered = 0 AND(employee.`EmployeeID`) NOT IN (select availability.EmployeeID from availability where day = '{day}'  AND WEEK = {week} AND YEAR = {year}) and(contract.WorkHoursPerWeek, contract.EmployeeID) NOT IN(Select Count(planning.EmployeeID)*4, planning.EmployeeID from planning where week = {week} group by week, EmployeeID);";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employees.Add(Convert.ToInt32(reader[0]));
                }
            }
            catch (MySqlException a)
            { Debug.WriteLine(a.Message); }
            catch (Exception a)
            { Debug.WriteLine(a.Message); }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return Employees;
        }


        //EVENING SHIFT 

        //Prefered
        public List<int> EveningEmployeesShiftPrefered(string shift, string day, int week, int year, string department)
        {
            List<int> Employees = new List<int>();

            MySqlConnection conn = Utils.GetConnection();

            string sql = $"SELECT employee.`EmployeeID`, contract.Department, Employee.Active, contract.WorkHoursPerWeek,preferedtime.Day,preferedtime.Shift FROM `employee` INNER JOIN contract on employee.EmployeeID = contract.EmployeeID INNER JOIN preferedtime on Employee.EmployeeID = preferedtime.EmployeeID where contract.Department = '{department}' AND contract.JobTitle NOT LIKE '%Manager%' AND Employee.Active = 1 AND preferedtime.Shift = '{shift}' and preferedtime.Day = '{day}'AND preferedtime.Prefered = 1 AND(employee.`EmployeeID`) NOT IN (select availability.EmployeeID from availability where day = '{day}' AND WEEK = {week} AND YEAR = {year}) and(contract.WorkHoursPerWeek, contract.EmployeeID) NOT IN(Select Count(planning.EmployeeID)*4, planning.EmployeeID from planning where week = {week} AND YEAR = {year} group by week, EmployeeID) AND (employee.EmployeeID) NOT IN (select planning.EmployeeID from planning where year = {year} AND WEEK = {week} AND day = '{day}' And shift = 'Morning');";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employees.Add(Convert.ToInt32(reader[0]));
                }
            }
            catch (MySqlException a)
            { Debug.WriteLine(a.Message); }
            catch (Exception a)
            { Debug.WriteLine(a.Message); }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return Employees;
        }
        //Withought Preference
        public List<int> EveningShiftWithoughtPreference(string shift, string day, int week, int year, string department)
        {
            List<int> Employees = new List<int>();

            MySqlConnection conn = Utils.GetConnection();

            string sql = $"SELECT employee.`EmployeeID`, contract.Department, Employee.Active, contract.WorkHoursPerWeek FROM `employee`  INNER JOIN contract on employee.EmployeeID = contract.EmployeeID where contract.Department = '{department}' AND contract.JobTitle NOT LIKE '%Manager%' AND Employee.Active = 1 AND(employee.`EmployeeID`) NOT IN (select availability.EmployeeID from availability where day = '{day}' AND WEEK = {week} AND YEAR = {year}) and(contract.WorkHoursPerWeek, contract.EmployeeID) NOT IN(Select Count(planning.EmployeeID)*4, planning.EmployeeID from planning where week = {week} AND YEAR = {year} group by week, EmployeeID)AND(employee.EmployeeID) NOT IN(select planning.EmployeeID from planning where year = {year} AND WEEK = {week} AND day = '{day}' And shift = 'Morning');";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employees.Add(Convert.ToInt32(reader[0]));
                }
            }
            catch (MySqlException a)
            { Debug.WriteLine(a.Message); }
            catch (Exception a)
            { Debug.WriteLine(a.Message); }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return Employees;
        }
        //Unprefered
        public List<int> EveningShiftUnPrefered(string shift, string day, int week, int year, string department)
        {
            List<int> Employees = new List<int>();

            MySqlConnection conn = Utils.GetConnection();

            string sql = $"SELECT employee.`EmployeeID`, contract.Department, Employee.Active, contract.WorkHoursPerWeek,preferedtime.Day,preferedtime.Shift FROM `employee` INNER JOIN contract on employee.EmployeeID = contract.EmployeeID INNER JOIN preferedtime on Employee.EmployeeID = preferedtime.EmployeeID where contract.Department = '{department}' AND contract.JobTitle NOT LIKE '%Manager%' AND Employee.Active = 1 AND preferedtime.Shift = '{shift}' and preferedtime.Day = '{day}'AND preferedtime.Prefered = 0 AND(employee.`EmployeeID`) NOT IN (select availability.EmployeeID from availability where day = '{day}' AND WEEK = {week} AND YEAR = {year}) and(contract.WorkHoursPerWeek, contract.EmployeeID) NOT IN(Select Count(planning.EmployeeID)*4, planning.EmployeeID from planning where week = {week} AND YEAR = {year} group by week, EmployeeID) AND (employee.EmployeeID) NOT IN (select planning.EmployeeID from planning where year = {year} AND WEEK = {week} AND day = '{day}' And shift = 'Morning');";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employees.Add(Convert.ToInt32(reader[0]));
                }
            }
            catch (MySqlException a)
            { Debug.WriteLine(a.Message); }
            catch (Exception a)
            { Debug.WriteLine(a.Message); }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return Employees;
        }
    }
}
