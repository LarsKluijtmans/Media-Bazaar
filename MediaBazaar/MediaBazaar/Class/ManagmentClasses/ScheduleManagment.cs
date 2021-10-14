using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

namespace MediaBazaar.Class
{
    public class ScheduleManagment
    {

        public static string GET_SCHEDULE_SALES = "SELECT  day, morning, afternoon, evening from SCHEDULE where Department = 'sales';";
        public static string GET_SCHEDULE_DEPOT = "SELECT   day, morning, afternoon, evening from SCHEDULE where Department = 'depot';";
        public static string UPDATE_SCHEDULE = "UPDATE schedule SET morning = @morning, afternoon = @afternoon, evening = @evening WHERE scheduleId = @scheduleId;";

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
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
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
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                conn.Close();
            }
            DataTable a = new DataTable();
            return a;
        }

      
        public void Editschedule(string ID, string Morning, string Afternoon, string Evening)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_SCHEDULE;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@scheduleId", ID);
                cmd.Parameters.AddWithValue("@morning", Morning);
                cmd.Parameters.AddWithValue("@afternoon", Afternoon);
                cmd.Parameters.AddWithValue("@evening", Evening);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();

            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
