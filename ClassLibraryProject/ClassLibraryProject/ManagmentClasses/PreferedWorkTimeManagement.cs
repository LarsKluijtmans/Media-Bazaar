
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
        public static string GET_PWT = "SELECT Shift, Day, Prefered FROM preferedtime WHERE EmployeeID = @EmployeeID";
        public static string UPDATE_PWT = "UPDATE preferedtime SET Time = @Time, Prefered = @Prefered WHERE EmployeeID = @EmployeeID where Day = @Day;";
        public static string DELETE_PWT_BY_ID = "DELETE FROM preferedtime WHERE EmployeeID = @EmployeeID";

        public static string VIEW_PWT_BY_ID = "SELECT * FROM preferedtime WHERE EmployeeID = @EmployeeID;";




        // constructor
        public PreferedWorkTimeManagement()
        {

        }


        // methods
        public List<PreferedWorkTime> GetPreferedWorkTimeForEmployee(string employeeId)
        {
            List<PreferedWorkTime> preferedWorks = new List<PreferedWorkTime>();
            MySqlConnection conn = Utils.GetConnection();

            try
            {
                int id = Convert.ToInt32(employeeId);
                MySqlCommand cmd = new MySqlCommand(GET_PWT, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", id);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    string day = reader.GetString("Day");
                    string shift = reader.GetString("Shift");
                    bool preferd = reader.GetBoolean("Prefered");

                    PreferedWorkTime preferedwork = new PreferedWorkTime(shift, day);
                    preferedWorks.Add(preferedwork);

                }
                return preferedWorks;
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
            return null;
        }

        public void EditPreferedWorkTimeForEmployee(string day, string shift, bool prefered)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = UPDATE_PWT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                
                cmd.Parameters.AddWithValue("@Shift", shift);
                cmd.Parameters.AddWithValue("@Prefered", prefered);

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
