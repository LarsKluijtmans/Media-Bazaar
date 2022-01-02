using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;

namespace ClassLibraryProject.ManagmentClasses
{
    public class PlanningManagment
    {
        public static string NEW_PLANNING = "INSERT INTO Planning (Year, Week, Day, Shift, EmployeeID) VALUES (@Year, @Week, @Day, @Shift, @EmployeeID);";

        public void AddPlanning(int year, int week, string day, string shift, int employeeID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql;
            sql = NEW_PLANNING;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Week", week);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@Shift", shift);

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
