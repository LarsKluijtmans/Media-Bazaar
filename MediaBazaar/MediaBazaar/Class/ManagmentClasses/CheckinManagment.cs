using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MediaBazaar.Class.ManagmentClasses
{
   public class CheckinManagment
    {
        public List<Checkin> check;

        public static string GET_ALL_ATENDANCE = "SELECT `EmployeeID`,`CheckInTime`,`CheckOutTime`,`CheckDate` FROM `atendance`;";

        public CheckinManagment()
        {
            check = new List<Checkin>();
        }

        public void getAllAtendance()
        {
            check.Clear();
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_ATENDANCE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Checkin a;

                while (reader.Read())
                {
                    a = new Checkin(Convert.ToInt32(reader[0]), Convert.ToDateTime(reader[1]), Convert.ToDateTime(reader[2]), Convert.ToDateTime(reader[3]));
                    check.Add(a);
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
    }
}
