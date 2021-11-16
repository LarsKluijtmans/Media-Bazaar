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
        public static string LOGIN = "SELECT * FROM User;";

        // method that returns userObj if given username & given password match username/password 
        public Employee CheckLogin(string givenUsername, string givenPassword)
        {
            MySqlConnection conn = DatabaseConnection.GetConnected();
            string sql = LOGIN;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Employee user;

                while (reader.Read())
                {
                    if (reader.GetString("Username") == givenUsername && reader.GetString("Password") == givenPassword)
                    {
                        int employeeID = reader.GetInt32("EmployeeID");
                        string firstName = reader.GetString("FirstName");
                        string lastName = reader.GetString("LastName");
                        string username = reader.GetString("Username");
                        string password = reader.GetString("Password");
                        int bsn = reader.GetInt32("BSN");
                        int active = reader.GetInt32("Active");
                        string city = reader.GetString("City");
                        string email = reader.GetString("Email");
                        int phoneNumber = reader.GetInt32("PhoneNumber");
                        string dateOfBirth = reader.GetString("DateOfBirth");

                        if (active == 1)
                        {
                            user = new Employee(employeeID, firstName, lastName, phoneNumber, email, city, dateOfBirth, bsn, username, password);

                            return user;
                        }
                    }
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
