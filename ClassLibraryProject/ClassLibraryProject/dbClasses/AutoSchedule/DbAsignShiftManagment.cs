using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using MySql.Data.MySqlClient;

namespace ClassLibraryProject.dbClasses.AutoSchedule
{
    public class DbAsignShiftManagment : IDbAsignShiftManagment
    {
        public bool AssignEmployeeShift(string sql)
        {
            MySqlConnection conn = Utils.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                int LinedAdded = cmd.ExecuteNonQuery();

                if (LinedAdded >= 1)
                {
                    return true;
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
            return false;
        }

        public bool ScheduleAllEmployees(List<int> employees, int amountToSchedule, string shift, string day, int week, int year)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into`planning` (`Year`, `Week`, `Day`, `Shift`, EmployeeID ) VALUES ");

            for (int i = 0; i < employees.Count; i++)
            {
                if (i == 0)
                {
                    sql.Append($"({year},{week},'{day}','{shift}',{employees[i]})");
                }
                else
                {
                    sql.Append($",({year},{week},'{day}','{shift}',{employees[i]})");
                }

            }
            sql.Append(";");
            AssignEmployeeShift(sql.ToString());

            return true;
        }

        public bool ScheduleShift(List<int> employees, int amountToSchedule, string shift, string day, int week, int year)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into`planning` (`Year`, `Week`, `Day`, `Shift`, EmployeeID ) VALUES ");

            for (int i = 0; i < amountToSchedule; i++)
            {
                if (i == 0)
                {
                    sql.Append($"({year},{week},'{day}','{shift}',{employees[i]})");
                }
                else
                {
                    sql.Append($",({year},{week},'{day}','{shift}',{employees[i]})");
                }

            }
            sql.Append(";");
            AssignEmployeeShift(sql.ToString());

            return true;
        }
    }
}
