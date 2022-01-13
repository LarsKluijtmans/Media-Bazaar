using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.dbClasses.IGetObject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses
{
    public class DBRegisteredShift: IDBRegisteredShift
    {
        private string GET_REGISTERED_SHIFTS = "SELECT * FROM planning;";
        private string REGISTER_EMPLOYEE = "INSERT INTO planning (PlanningID, Department, Year, Week, Day, Shift, EmployeeID) VALUES (@ID, @Year, @Week, @Day, @Shift, @Employee);";
        private string DE_REGISTER_EMPLOYEE = "DELETE FROM planning WHERE Department = @Department Year = @Year AND Week = @Week AND Day = @Day AND Shift = @Shift AND EmployeeID = @EmployeeID;";

        private List<RegisteredShift> registeredShifts;
        private IGetEmployee employee;

        public DBRegisteredShift(IGetEmployee employee)
        {
            registeredShifts = new List<RegisteredShift>();
            this.employee = employee;

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
                    string department = reader.GetString("Department");
                    int year = reader.GetInt32("Year");
                    int week = reader.GetInt32("Week");
                    string day = reader.GetString("Day");
                    string shift = reader.GetString("Shift");
                    int employeeID = reader.GetInt32("EmployeeID");

                    if(RegisteredShiftExist(department, year, week, day, shift) == true)
                    {
                        GetRegisteredShift(department, year, week, day, shift).Employees.Add(employee.GetEmployee(employeeID));
                    }
                    else
                    {
                        registeredShift = new RegisteredShift(department, year, week, day, shift);
                        registeredShifts.Add(registeredShift);
                        registeredShift.Employees.Add(employee.GetEmployee(employeeID));
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
        public bool RegisterEmployee(string department, int year, int week, string day, string shift, Employee employee)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = REGISTER_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Department", department);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Week", week);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@Shift", shift);
                cmd.Parameters.AddWithValue("@Employee", employee.EmployeeID);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    RegisteredShift registeredShift = new RegisteredShift(department, year, week, day, shift);
                    registeredShift.Employees.Add(employee);
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
        public bool DeRegisterEmployee(string department, int year, int week, string day, string shift, Employee employee)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = DE_REGISTER_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Department", department);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Week", week);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@Shift", shift);
                cmd.Parameters.AddWithValue("@Employee", employee.EmployeeID);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    GetRegisteredShift(department, year, week, day, shift).Employees.Remove(employee);
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


        public RegisteredShift GetRegisteredShift(string department, int year, int week, string day, string shift)
        {
            foreach(RegisteredShift rs in registeredShifts)
            {
                if(rs.Department == department && rs.Year == year && rs.Week == week && rs.Day == day && rs.Shift == shift)
                {
                    return rs;
                }
            }
            return null;
        }
        public bool RegisteredShiftExist(string department, int year, int week, string day, string shift)
        {
            if(GetRegisteredShift(department, year, week, day, shift) != null)
            {
                return true;
            }
            return false;
        }
    }
}
