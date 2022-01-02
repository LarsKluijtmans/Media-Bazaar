using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

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

            string sql = "SELECT employee.`EmployeeID`, SEC_TO_TIME(SUM(TIME_TO_SEC(TIMEDIFF(`CheckOutTime`,`CheckInTime`)))), `WorkHoursPerWeek`, `FirstName`,`LastName` FROM `attendance` INNER JOIN employee ON attendance.EmployeeID = employee.EmployeeID INNER JOIN contract ON contract.EmployeeID = employee.EmployeeID WHERE checkdate LIKE '%" + year + "-" + month + "%' group by contract.EmployeeID;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                EmployeeWorkTime a;

                while (reader.Read())
                {
                    TimeSpan t = (TimeSpan)reader[1];
                    a = new EmployeeWorkTime(Convert.ToInt32(reader[0]), reader[3].ToString() + " " + reader[4].ToString(), t, Convert.ToInt32(reader[2]));
                          emp.Add(a);
                }
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
