using System;
using System.Collections.Generic;
using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;

namespace ClassLibraryProject.ManagmentClasses
{
   public class CheckinManagment
    {
        public List<Checkin> check;
        public List<TimeWorked> times;
        public List<TimeWorked> timePerEmployee;
 
        public static string GET_TIME_WORKED = "SELECT employee.`EmployeeID`,`FirstName`,`LastName`, SEC_TO_TIME(SUM(TIME_TO_SEC(TIMEDIFF(`CheckOutTime`,`CheckInTime`)))), `JobTitle`,`WorkHoursPerWeek`,`SalaryPerHour` FROM `attendance` INNER JOIN employee ON attendance.EmployeeID = employee.EmployeeID INNER JOIN contract ON contract.EmployeeID = employee.EmployeeID WHERE checkDate LIKE '%@YEAR-@MONTH%' group by contract.EmployeeID;";
        public static string UNIQUE_ATENDANCE = "SELECT `EmployeeID` FROM `attendance`GROUP BY EmployeeID;";
        public static string GET_EMPLOYEEID_WITH_CARD_CODE = "SELECT `EmployeeID` FROM `employee` WHERE `CardNumber`= @CardNumber;";
        public static string IS_CHECKED_IN = "SELECT employeeID FROM `atendance` WHERE EmployeeID = @EmployeeID AND CheckDate = @CheckDate AND `CheckOutTime` IS NULL;";
        public static string CREATE_CHECKIN = "INSERT INTO ATENDANCE(EmployeeID, CheckInTime, CheckOutTime, CheckDate) VALUES(@EmployeeID, @CheckInTime, @CheckOutTime, @CheckDate)";
        public static string UPDATE_CHECKOUT = "UPDATE ATENDANCE SET CheckOutTime = @CheckOutTime WHERE CheckDate = @CheckDate AND EmployeeID = @EmployeeID AND `CheckOutTime` IS NULL ;";
        public static string GET_ALL_ATENDANCE_CHECKIN = "SELECT `EmployeeID`,`CheckInTime`,`CheckOutTime`,`CheckDate` FROM `atendance` WHERE CheckDate = @CheckDate ORDER BY CheckOutTime DESC;";
        public static string GET_ALL_ATENDANCE = "SELECT `EmployeeID`,`CheckInTime`,`CheckOutTime`,`CheckDate` FROM `attendance`;";

        public CheckinManagment()
        {
            check = new List<Checkin>();
            times = new List<TimeWorked>();
            timePerEmployee = new List<TimeWorked>();
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
                    a = new Checkin(Convert.ToInt32(reader[0]),Convert.ToDateTime(reader[1]), Convert.ToDateTime(reader[2]), reader[3].ToString());
                    check.Add(a);
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

        public void getAllAtendanceTime(string year, string month)
        {
            times.Clear();
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_TIME_WORKED;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@YEAR", year);
                cmd.Parameters.AddWithValue("@MONTH", month);

                MySqlDataReader reader = cmd.ExecuteReader();

                TimeWorked a;

                while (reader.Read())
                {
                    a = new TimeWorked(Convert.ToInt32(reader[0]), reader[3].ToString(), reader[1].ToString() + " " + reader[2].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString());
                    times.Add(a);
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

        public void UniqueID()
        {
            timePerEmployee.Clear();
            MySqlConnection conn = Utils.GetConnection();

            string sql = UNIQUE_ATENDANCE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                TimeWorked a;

                while (reader.Read())
                {
                    a = new TimeWorked(Convert.ToInt32(reader[0]), "","","", "", "");
                    timePerEmployee.Add(a);
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

        public void getAllAtendanceOnCheckIn()
        {
            check.Clear();
            var date = DateTime.Now;
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_ATENDANCE_CHECKIN;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Checkin a;

                while (reader.Read())
                {
                    a = new Checkin(Convert.ToInt32(reader[0]), Convert.ToDateTime( reader[1]), Convert.ToDateTime( reader[2]), Convert.ToString(reader[3]));
                    check.Add(a);
                }
            }
            catch (MySqlException )
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
        }

        public int GetEmployeeID(string CardNumber)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_EMPLOYEEID_WITH_CARD_CODE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@CardNumber", CardNumber);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return Convert.ToInt32(reader[0]);
                }
            }
            catch (MySqlException )
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
            return 0;
        }

        public bool IsAlreadyCheckedIn(int EmployeeID)
        {
            var date = DateTime.Now;
            MySqlConnection conn = Utils.GetConnection();
            string sql = IS_CHECKED_IN;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID.ToString());
                cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return true;
                }
            }
            catch (MySqlException )
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public void AddCheckIn(int EmployeeID)
        {
            var date = DateTime.Now;
            MySqlConnection conn = Utils.GetConnection();
            string sql = CREATE_CHECKIN;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID.ToString());
                cmd.Parameters.AddWithValue("@CheckInTime", date.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@CheckOutTime", null);
                cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                conn.Open();
                int n = cmd.ExecuteNonQuery();
            }
            catch (MySqlException )
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
        }

        public void EditCheckOutTime(int EmployeeID)
        {
            var date = DateTime.Now;
            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_CHECKOUT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID.ToString());
                cmd.Parameters.AddWithValue("@CheckOutTime", date.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                conn.Open();
                int n = cmd.ExecuteNonQuery();
            }
            catch (MySqlException )
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
