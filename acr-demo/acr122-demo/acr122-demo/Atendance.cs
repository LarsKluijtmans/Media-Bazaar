using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace acr122_demo
{
    class Atendance
    {
        public static string GET_EMPLOYEEID_WITH_CARD_CODE = "SELECT `EmployeeID` FROM `employee` WHERE `CardNumber`= @CardNumber;";
        public static string IS_CHECKED_IN = "SELECT * FROM `atendance` WHERE EmployeeID = @EmployeeID AND CheckDate = @DateTime.now AND `CheckOutTime` IS NULL;";
        public static string CREATE_CHECKIN = "INSERT INTO ATENDANCE(EmployeeID, CheckInTime, CheckOutTime, CheckDate) VALUES(@ID, @CheckInTime, @CheckOutTime, @CheckDate)";
        public static string CREATE_CHECKOUT = "UPDATE ATENDANCE SET CheckOutTime = @CheckOutTime WHERE CheckDate = @CheckDate && EmployeeID = @ID;";


        public int GetEmployeeID(string CardNumber)
        {
            MySqlConnection conn = Connection.GetConnection();

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
            return 0;
        }

        public bool IsAlreadyCheckedIn()
        {
            return true;
        }

        public void AddCheckIn(int EmployeeID)
        {
            var date = DateTime.Now;
            MySqlConnection conn = Connection.GetConnection();
            string sql = CREATE_CHECKIN;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", EmployeeID.ToString());
                cmd.Parameters.AddWithValue("@CheckInTime", date.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@CheckOutTime", null);
                cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                conn.Open();
                int n = cmd.ExecuteNonQuery();
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

        public void EditCheckOutTime()
        {

        }
    }
}
