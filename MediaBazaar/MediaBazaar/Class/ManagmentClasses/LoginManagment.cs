using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MediaBazaar.Class.ManagmentClasses
{
    public class LoginManagment
    {
        public static string LOGIN_BY_EMPLOYEEID = " SELECT employee.employeeID, password, contract.JobTitle FROM employee INNER JOIN contract ON contract.employeeID = employee.Employeeid where employee.employeeid = @employeeid order by startdate;";

        public string checkLogin(string ID, string Password)
        {

            MySqlConnection conn = Utils.GetConnection();
            string sql = LOGIN_BY_EMPLOYEEID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@employeeid", ID);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (Convert.ToInt32(reader[0]) == Convert.ToInt32(ID) && reader[1].ToString() == Password)
                    {
                        return reader[2].ToString();
                    }
                    else
                    {
                        return "Wrong info!";
                    }
                }
                return "Wrong info!";
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
            return "";
        }
    }
}
