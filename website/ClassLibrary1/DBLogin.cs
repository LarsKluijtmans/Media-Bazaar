using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DBLogin
    {
        // sql string
        public static string LOGIN = "SELECT EmployeeID, FirstName, LastName, Username, Password, Active, Address, Email, Phonenumber FROM Employee WHERE Username = @Username AND Password = @Password;";

        // method that returns userObj if given username & given password match username/password 
        public CurrentUser CheckLogin(string givenUsername, string givenPassword)
        {
            MySqlConnection conn = DatabaseConnection.GetConnected();
            string sql = LOGIN;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@Username", givenUsername);
                cmd.Parameters.AddWithValue("@Password", givenPassword);

                MySqlDataReader reader = cmd.ExecuteReader();

                CurrentUser user;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32("EmployeeID");
                    string firstName = reader.GetString("FirstName");
                    string lastName = reader.GetString("LastName");
                    string username = reader.GetString("Username");
                    string password = reader.GetString("Password");
                    int active = reader.GetInt32("Active");
                    string city = reader.GetString("Address");
                    string email = reader.GetString("Email");
                    int phoneNumber = reader.GetInt32("PhoneNumber");

                    user = new CurrentUser(employeeID, firstName, lastName, email, username, password, active);

                    return user;
                }
            }
            catch (MySqlException msqEx)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return null;
        }
    }
}
