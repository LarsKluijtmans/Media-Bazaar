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

                    string hour = "";
                    string minute = "";
                    string seconds = "";

                    if (date.ToCharArray().Length > 8)
                    {
                        string days = date.ToCharArray()[0].ToString();
                        hour = ( Convert.ToInt32(days) * 24 +  Convert.ToInt32(date.ToCharArray()[2].ToString() + date.ToCharArray()[3].ToString())).ToString();
                        minute = date.ToCharArray()[5].ToString() + date.ToCharArray()[6].ToString();
                        seconds = date.ToCharArray()[8].ToString() + date.ToCharArray()[9].ToString();
                    }
                    else if (date.ToCharArray().Length == 8)
                    {
                        hour = date.ToCharArray()[0].ToString() + date.ToCharArray()[1].ToString();
                        minute = date.ToCharArray()[3].ToString() + date.ToCharArray()[4].ToString();
                        seconds = date.ToCharArray()[6].ToString() + date.ToCharArray()[7].ToString();
                    }
                    else 
                    {
                        for(int i = 0; i<100;i++)
                        { 
                        Debug.WriteLine("Error");
                        }
                    }


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
