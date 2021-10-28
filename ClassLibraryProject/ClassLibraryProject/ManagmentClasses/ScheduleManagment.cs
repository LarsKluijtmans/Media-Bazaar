using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLibraryProject.ManagmentClasses
{
    public class ScheduleManagment
    {

        public static string GET_SCHEDULE_SALES = "SELECT  day, morning, afternoon, evening from SCHEDULE where Department = 'sales';";
        public static string GET_SCHEDULE_DEPOT = "SELECT   day, morning, afternoon, evening from SCHEDULE where Department = 'depot';";
        public static string UPDATE_DEPOT_SCHEDULE = "UPDATE schedule SET morning = @morning, afternoon = @afternoon, evening = @evening WHERE Day = @Day AND Department = 'depot';";
        public static string UPDATE_SALES_SCHEDULE = "UPDATE schedule SET morning = @morning, afternoon = @afternoon, evening = @evening WHERE Day = @Day AND Department = 'sales';";

        public DataTable ViewSalesSchedule()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_SCHEDULE_SALES;

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

        public DataTable ViewDepotSchedule()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_SCHEDULE_DEPOT;

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

      
        public void EditDepotSchedule(string day, string morning, string afternoon, string evening)
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
        public void EditSalesSchedule(string day, string morning, string afternoon, string evening)
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
