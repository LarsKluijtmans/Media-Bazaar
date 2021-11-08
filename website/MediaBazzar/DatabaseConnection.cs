using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class DatabaseConnection
    {




        public static string GET_EMPLOYEEID = " SELECT employeeID, password, userName FROM employee where UserName = @UserName";


        public MySqlConnection GetConnected()
        {
            MySqlConnection conn =
            new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi461266;Database=dbi461266;Pwd=Nijlpaard;SslMode =none;");
            return conn;
        }


        public bool IsEmployeeExist(Employee employee)
        {

            String CheckUserEXIST = "SELECT * FROM employee WHERE Username=?user AND Password = ?pass;";
            MySqlConnection conn = GetConnected();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(CheckUserEXIST, conn);

            cmd.Parameters.AddWithValue("pass", employee.Password);
            cmd.Parameters.AddWithValue("user", employee.UserName);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            return false;
        }
    }
}
