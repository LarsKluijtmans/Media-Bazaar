
using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ClassLibraryProject.ManagmentClasses
{
    public class PreferedWorkTimeManagement
    {
        // sql
        public static string CREATE_PWT = "INSERT INTO preferedtime (EmployeeID, Prefered, Day, Time) VALUES (@EmployeeID, @Prefered, @Day, @Time) WHERE EmployeeID = @EmployeeID;";
        public static string GET_ALL_PWT = "SELECT * FROM preferedtime WHERE EmployeeID = @EmployeeID";
        public static string UPDATE_PWT = "UPDATE preferedtime SET Day = @Day, Time = @Time, Prefered = @Prefered WHERE EmployeeID = @EmployeeID;";
        public static string DELETE_PWT_BY_ID = "DELETE FROM preferedtime WHERE EmployeeID = @EmployeeID";

        public static string VIEW_PWT_BY_ID = "SELECT * FROM preferedtime WHERE EmployeeID = @EmployeeID;";

        private List<PreferedWorkTime> preferedWorkTimes;

        //public PreferedWorkTime GetpreferedWorkTime()
        //{
        //    return preferedWorkTimes.GetpreferedWorkTime();
        //}

        // constructor
        public PreferedWorkTimeManagement()
        {
            preferedWorkTimes = new List<PreferedWorkTime>();
        }


        // methods
        public void GetAllPreferedWorkTime()
        {
            MySqlConnection conn = Utils.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(GET_ALL_PWT, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                PreferedWorkTime preferedWorkTime;

                while (reader.Read())
                {
                    string day = reader.GetString("Day");
                    string shift = reader.GetString("Shift");
                    bool preferd = reader.GetBoolean("Prefered");

                    preferedWorkTime = new PreferedWorkTime(preferd, day,shift);
                    preferedWorkTimes.Add(preferedWorkTime);
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
