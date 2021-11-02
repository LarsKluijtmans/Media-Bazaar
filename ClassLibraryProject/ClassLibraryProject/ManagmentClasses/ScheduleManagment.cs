using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLibraryProject.ManagmentClasses
{
    public class ScheduleManagment
    {
        public static string UPDATE_DEPOT_SCHEDULE = "UPDATE schedule SET morning = @morning, afternoon = @afternoon, evening = @evening WHERE Day = @Day AND Department = 'depot' AND Week = @Week AND Year = @Year;";
        public static string UPDATE_SALES_SCHEDULE = "UPDATE schedule SET morning = @morning, afternoon = @afternoon, evening = @evening WHERE Day = @Day AND Department = 'sales' AND Week = @Week AND Year = @Year;";

        public DataTable ViewSalesSchedule(int week, int year)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = $"SELECT  day, morning, afternoon, evening from SCHEDULE where Department = 'sales' AND Year = {year} AND Week = {week};";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataAdapter reader = new MySqlDataAdapter(sql, conn);

                DataTable table = new DataTable();
                reader.Fill(table);

                return table;
            }
            catch (MySqlException )
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
            DataTable a = new DataTable();
            return a;
        }

        public DataTable ViewDepotSchedule(int week, int year)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = $"SELECT   day, morning, afternoon, evening from SCHEDULE where Department = 'depot' AND Year = {year} AND Week = {week};";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataAdapter reader = new MySqlDataAdapter(sql, conn);

                DataTable table = new DataTable();
                reader.Fill(table);

                return table;
            }
            catch (MySqlException)
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
            DataTable a = new DataTable();
            return a;
        }

      
        public void EditDepotSchedule(string day, string morning, string afternoon, string evening, int week, int year)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_DEPOT_SCHEDULE;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@morning", morning);
                cmd.Parameters.AddWithValue("@afternoon", afternoon);
                cmd.Parameters.AddWithValue("@evening", evening);
                cmd.Parameters.AddWithValue("@Week", week);
                cmd.Parameters.AddWithValue("@Year", year);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();

            }
            catch (MySqlException )
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
        }
        public void EditSalesSchedule(string day, string morning, string afternoon, string evening, int week, int year)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_SALES_SCHEDULE;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@morning", morning);
                cmd.Parameters.AddWithValue("@afternoon", afternoon);
                cmd.Parameters.AddWithValue("@evening", evening);
                cmd.Parameters.AddWithValue("@Week", week);
                cmd.Parameters.AddWithValue("@Year", year);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();

            }
            catch (MySqlException)
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
        }

    }
}
