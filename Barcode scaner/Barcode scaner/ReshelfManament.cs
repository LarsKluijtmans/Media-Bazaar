using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;



namespace Barcode_scaner
{
    class ReshelfManament
    {
        public static string CREATE_SHELFREPLENICHMENT = "INSERT INTO shelfreplenishment (ProductID, Barcode, Amount) VALUES (@ProductID, @Barcode, @Amount);";
        public static string GET_PRODUCTID = "SELECT ProductID FROM product WHERE Barcode = @Barcode";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn =
                new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi461266;Database=dbi461266;Pwd=Nijlpaard;SslMode =none;");
            return conn;
        }

        public string GetID(string Barcode)
        {
            MySqlConnection conn = GetConnection();
            string sql = GET_PRODUCTID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Barcode", Barcode);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    return reader[0].ToString();
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
            return "";
        }

        public void RequestReshelf(string ProductID, string Barcode, string Amount)
        {
            MySqlConnection conn = GetConnection();
            string sql = CREATE_SHELFREPLENICHMENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", ProductID);
                cmd.Parameters.AddWithValue("@Barcode", Barcode);
                cmd.Parameters.AddWithValue("@Amount", Amount);


                conn.Open();
                int numCreatedRows = cmd.ExecuteNonQuery();
                MessageBox.Show("Request was succesfull");
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong" + ex);
            }
            finally
            {

                conn.Close();
            }
        }
    }
}
