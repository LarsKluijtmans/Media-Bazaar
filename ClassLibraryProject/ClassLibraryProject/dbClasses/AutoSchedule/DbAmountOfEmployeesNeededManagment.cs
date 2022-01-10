﻿using ClassLibraryProject.Interfaces;
using System;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using ClassLibraryProject.Class;

namespace ClassLibraryProject.dbClasses.AutoSchedule
{
    public class DbAmountOfEmployeesNeededManagment : IDbAmountOfEmployeesNeededManagment
    {
        public int AmountLeftToSchedule(string shift, string day, int week, int year, string department)
        {
            int AmountScheduled = 0;
            int AmountNeeded = 0;
            int AmountLeft = 0;

            MySqlConnection conn = Utils.GetConnection();

            string sql = $"SELECT Count(`EmployeeID`) FROM `planning` WHERE `Year` = {year} AND `Week` = {week} AND `Day` = '{day}' AND `Shift` = '{shift}';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AmountScheduled = Convert.ToInt32(reader[0]);
                    break;
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

            sql = $"SELECT {shift} FROM `schedule` WHERE `Year` = {year} AND `Week` = {week} AND `Day` = '{day}';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AmountNeeded = Convert.ToInt32(reader[0]);
                    break;
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
            AmountLeft = AmountNeeded - AmountScheduled;
            return AmountLeft;
        }

        public int AmountOfEmployeesToSchedule(string shift, string day, int week, int year, string department)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = $"SELECT `{shift}` FROM `schedule` WHERE `Year`= {year} AND `Week` = {week} AND `Day` = '{day}';";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return Convert.ToInt32(reader[0]);
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
            return 0;
        }
    }
}