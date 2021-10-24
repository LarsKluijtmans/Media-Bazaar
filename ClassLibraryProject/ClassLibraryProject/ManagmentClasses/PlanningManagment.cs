using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ClassLibraryProject.ManagmentClasses
{
    public class PlanningManagment
    {
        public static string GET_PLANNING = "SELECT EmployeeID from Planning WHERE Day = @Day AND Shift = @Shift;";
        public static string NEW_PLANNING = "INSERT INTO Planning (Day, Shift, EmployeeID) VALUES (@Day, @Shift, @EmployeeID);";

        public void AddPlanning(string Day, string Shift, int employeeID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql;
            sql = NEW_PLANNING;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Day", Day);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@Shift", Shift);

                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();
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
