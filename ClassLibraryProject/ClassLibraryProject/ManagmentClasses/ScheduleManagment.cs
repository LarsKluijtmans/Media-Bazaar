using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLibraryProject.ManagmentClasses
{
    public class ScheduleManagment
    {
        //Sales
        public static string UPDATE_SALES_SCHEDULE = "UPDATE schedule SET morning = @morning, afternoon = @afternoon, evening = @evening WHERE Day = @Day AND Department = 'sales' AND Week = @Week AND Year = @Year;";
        public static string GET_SALES_COUNT = "SELECT COUNT(ScheduleID) FROM Schedule WHERE Department = 'Sales' AND Year = @Year AND Week = @Week;";
        public static string CREATE_WEEK_SALES = "INSERT INTO `schedule` (`Department`, `Year`, `Week`, `Day`, `Morning`, `Afternoon`, `Evening`) VALUES ('Sales', @Year, @Week, 'Monday', '0', '0', '0'), ('Sales',  @Year, @Week, 'Tuesday', '0', '0', '0'), ('Sales',  @Year, @Week, 'Wednesday', '0', '0', '0'), ('Sales',  @Year, @Week, 'Thursday', '0', '0', '0'), ('Sales',  @Year, @Week, 'Friday', '0', '0', '0'), ('Sales',  @Year, @Week, 'Saturday', '0', '0', '0'), ('Sales',  @Year, @Week, 'Sunday', '0', '0', '0');";
        //Depot
        public static string UPDATE_DEPOT_SCHEDULE = "UPDATE schedule SET morning = @morning, afternoon = @afternoon, evening = @evening WHERE Day = @Day AND Department = 'depot' AND Week = @Week AND Year = @Year;";
        public static string GET_DEPOT_COUNT = "SELECT COUNT(ScheduleID) FROM Schedule WHERE Department = 'Depot' AND Year = @Year AND Week = @Week;";
        public static string CREATE_WEEK_DEPOT = "INSERT INTO `schedule` (`Department`, `Year`, `Week`, `Day`, `Morning`, `Afternoon`, `Evening`) VALUES ('Depot', @Year, @Week, 'Monday', '0', '0', '0'), ('Depot',  @Year, @Week, 'Tuesday', '0', '0', '0'), ('Depot',  @Year, @Week, 'Wednesday', '0', '0', '0'), ('Depot',  @Year, @Week, 'Thursday', '0', '0', '0'), ('Depot',  @Year, @Week, 'Friday', '0', '0', '0'), ('Depot',  @Year, @Week, 'Saturday', '0', '0', '0'), ('Depot',  @Year, @Week, 'Sunday', '0', '0', '0');";
        //CRUD
        public static string GET_ALL_SCHEDULES = "SELECT * FROM SCHEDULE;";

        private List<Schedule> schedules;

        public List<Schedule> Schedules
        {
            get { return schedules; }
            set { schedules = value; }
        }

        public ScheduleManagment()
        {
            Schedules = new List<Schedule>();
        }

        //Sales
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
        public void CreateSalesWeek(int year, int week)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = CREATE_WEEK_SALES;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Week", week);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
        }
        public bool GetSalesCount(int year, int week)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_SALES_COUNT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Week", week);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (Convert.ToInt32(reader[0]) == 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        //Depot
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
            catch (MySqlException)
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
        }
        public void CreateDepotWeek(int year, int week)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = CREATE_WEEK_DEPOT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Week", week);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
        }
        public bool GetDepotCount(int year, int week)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_DEPOT_COUNT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Week", week);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (Convert.ToInt32(reader[0]) == 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        //CRUD
        public void GetAllSchedule()
        {
            schedules.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_SCHEDULES;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Schedule schedule;

                while (reader.Read())
                {
                    int scheduleID = reader.GetInt32("ScheduleID");
                    string department = reader.GetString("Department");
                    int year = reader.GetInt32("Year");
                    int week = reader.GetInt32("Week");
                    string day = reader.GetString("Day");
                    int morningAmount = reader.GetInt32("Morning");
                    int afternoonAmount = reader.GetInt32("Afternoon");
                    int eveningAmount = reader.GetInt32("Evening");


                    schedule = new Schedule(scheduleID, department, year, week, day, morningAmount, afternoonAmount, eveningAmount);
                    schedules.Add(schedule);
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
        

    }
}
