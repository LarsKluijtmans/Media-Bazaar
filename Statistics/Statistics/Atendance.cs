using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Statistics
{
    class Atendance
    {
       public List<EmployeeWorkTime> emp;

        public Atendance()
        {
            emp = new List<EmployeeWorkTime>();
        }
          
        public void GetAtendanceData(int year, int month)
        {
            emp.Clear();
            MySqlConnection conn = Utils.GetConnection();

            string sql = "";

            if (month > 9)
            {
                sql = "SELECT employee.`EmployeeID`, SEC_TO_TIME(SUM(TIME_TO_SEC(TIMEDIFF(`CheckOutTime`,`CheckInTime`)))), `WorkHoursPerWeek`, `FirstName`,`LastName` FROM `attendance` INNER JOIN employee ON attendance.EmployeeID = employee.EmployeeID INNER JOIN contract ON contract.EmployeeID = employee.EmployeeID WHERE checkdate LIKE '" + year + "-" + month + "%' group by contract.EmployeeID;";
            }
            else
            {
                sql = "SELECT employee.`EmployeeID`, SEC_TO_TIME(SUM(TIME_TO_SEC(TIMEDIFF(`CheckOutTime`,`CheckInTime`)))), `WorkHoursPerWeek`, `FirstName`,`LastName` FROM `attendance` INNER JOIN employee ON attendance.EmployeeID = employee.EmployeeID INNER JOIN contract ON contract.EmployeeID = employee.EmployeeID WHERE checkdate LIKE '" + year + "-0" + month + "%' group by contract.EmployeeID;";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                EmployeeWorkTime a;

                while (reader.Read())
                {
                    string date = reader[1].ToString();

                    string hour = date[0].ToString() + date[1].ToString();
                    string minute = date[3].ToString() + date[4].ToString();
                    string seconds = date[6].ToString() + date[7].ToString();

                    TimeSpan t = new TimeSpan(Convert.ToInt16(hour), Convert.ToInt16(minute), Convert.ToInt16(seconds));
                    a = new EmployeeWorkTime(Convert.ToInt32(reader[0]), reader[3].ToString() + " " + reader[4].ToString(), t, Convert.ToInt32(reader[2]));
                          emp.Add(a);
                }
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
