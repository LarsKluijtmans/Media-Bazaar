using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace acr122_demo.Class
{
    public class Employee
    {
        private static string CHANGE_CARD_INFO = "UPDATE Employee SET CardNumber = @CardNumber WHERE EmployeeID = @EmployeeID;";

        public void changeID(string employeeID, string CardNumber)
        {
            MySqlConnection conn = Connection.GetConnection();
            string sql = CHANGE_CARD_INFO;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@CardNumber", CardNumber);

                conn.Open();
                int numAffectedRows = cmd.ExecuteNonQuery();


                MessageBox.Show(" Done");
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
