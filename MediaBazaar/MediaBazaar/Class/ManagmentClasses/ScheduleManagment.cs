using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaBazaar.Class
{
    public class ScheduleManagment
    {
        public static string GET_SCHEDULE = "SELECT scheduleId, department, day, morning, afternoon, evening from SCHEDULE";
        public static string GET_SCHEDULE_SALES = "SELECT scheduleId, department, day, morning, afternoon, evening from SCHEDULE where Department = 'sales';";
        public static string GET_SCHEDULE_DEPOT = "SELECT  scheduleId, department, day, morning, afternoon, evening from SCHEDULE where Department = 'depot';";
        public static string GET_SCHEDULE_OFFICE = "SELECT scheduleId, department, day, morning, afternoon, evening from SCHEDULE where Department = 'office';";
        public static string UPDATE_SCHEDULE = "UPDATE schedule SET morning = @morning, afternoon = @afternoon, evening = @evening WHERE scheduleId = @scheduleId;";

        public List<Schedule> schedules;

        public ScheduleManagment()
        {
            schedules = new List<Schedule>();
        }

        public void ViewAllSchedule()
        {
            schedules.Clear();
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_SCHEDULE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Schedule schedule;

                while (reader.Read())
                {
                    int Id = reader.GetInt32("scheduleId");
                    string Department = reader.GetString("department");
                    string Day = reader.GetString("day");
                    int MorningAmount = reader.GetInt32("morning");
                    int AfternoonAmount = reader.GetInt32("afternoon");
                    int EveningAmount = reader.GetInt32("evening");

                    schedule = new Schedule(Id, Department, Day, MorningAmount, AfternoonAmount, EveningAmount);

                    schedules.Add(schedule);
                }
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
