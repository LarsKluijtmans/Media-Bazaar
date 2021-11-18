using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.ProductData
{
    class RestockData
    {
        public void GetAtendanceData(int year, int month)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = "SELECT employee.`EmployeeID`, SEC_TO_TIME(SUM(TIME_TO_SEC(TIMEDIFF(`CheckOutTime`,`CheckInTime`)))), `WorkHoursPerWeek`FROM `attendance` INNER JOIN employee ON attendance.EmployeeID = employee.EmployeeID INNER JOIN contract ON contract.EmployeeID = employee.EmployeeID WHERE checkdate LIKE '%" + year + "-" + month + "%' group by contract.EmployeeID;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                List<ProductsData> ProductsDatas = new List<ProductsData>();

                while (reader.Read())
                {
                    ProductsData productsData = new ProductsData(Convert.ToInt32( reader[0]), Convert.ToInt32(reader[1]));

                    ProductsDatas.Add(productsData);
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
