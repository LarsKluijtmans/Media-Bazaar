using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;



namespace Barcode_scaner
{
    class ReshelfManament
    {
        public static string CREATE_SHELFREPLENICHMENT = "INSERT INTO shelfreplenishment (ProductID, Barcode, Amount) VALUES (@ProductID, @Barcode, @Amount);";
        public static string GET_PRODUCTID = "SELECT ProductID FROM product WHERE Barcode = @Barcode";
        public static string GET_RECOMENDEDAMOUNT = "SELECT Product.ProductID, product.Barcode, MinAmountOrdered, MaxAmountOrdered, UnitCount FROM `Product`  INNER JOIN productsluplie On Product.ProductID = productsluplie.ProductID having product.Barcode =  @Barcode;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn =
                new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi461266;Database=dbi461266;Pwd=Nijlpaard;SslMode =none;");
            return conn;
        }


        public int GetRecomendedAmount(string Barcode, int Amount)
        {
            MySqlConnection conn = GetConnection();
            string sql = GET_RECOMENDEDAMOUNT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Barcode", Barcode);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return Convert.ToInt32(reader[2]);
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
        public int DecreaseAmount(string Barcode, int Amount)
        {
            MySqlConnection conn = GetConnection();
            string sql = GET_RECOMENDEDAMOUNT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Barcode", Barcode);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if ((Amount -= Convert.ToInt32(reader[4])) <= Convert.ToInt32(reader[3]))
                    {
                        return 0;
                        MessageBox.Show("This is the maximem amount you can order.");
                    }
                    else
                    {
                        return Convert.ToInt32(reader[4]);
                    }
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

        public int IncreaseAmount(string Barcode, int amount)
        {
            MySqlConnection conn = GetConnection();
            string sql = GET_RECOMENDEDAMOUNT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Barcode", Barcode);

                    MySqlDataReader reader = cmd.ExecuteReader();

                conn.Open();

                while (reader.Read())
                {
                    if ((amount += Convert.ToInt32(reader[4])) > Convert.ToInt32(reader[3]))
                    {
                        return 0;
                        MessageBox.Show("This is the maximem amount you can order.");
                    }
                    else
                    {
                        int q =  Convert.ToInt32(reader[4]);
                        return q;
                    }
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
