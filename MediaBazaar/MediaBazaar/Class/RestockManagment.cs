using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaBazaar.Class
{
    public class RestockManagment
    {
        public static string CREATE_RESTOCKREPLENISHMENT = "INSERT INTO restockreplenishment ( ProductID, Amount) VALUES ( @ProductID, @Amount);";
        public static string GET_ALL_RESTOCKREPLENISHMENT = "SELECT restockreplenishmentID, product.ProductID, Amount, Name, AmountInStore, AmountInDepot FROM restockreplenishment INNER JOIN product ON product.ProductID = restockreplenishment.ProductID ORDER BY restockreplenishmentID;";
        public static string UPDATE_RESTOCKREPLENISHMENT = "UPDATE PRODUCT SET AmountInDepot = @AmountInDepot WHERE ProductID = @ProductID;";
        public static string DELETE_RESTOCKREPLENISHMENT_BY_ID = "DELETE FROM restockreplenishment WHERE RestockReplenishmentID = @RestockReplenishmentID;";

        public List<Restock> restocks;

        public RestockManagment()
        {
            restocks = new List<Restock>();
        }

        public void ViewAllRestockRequests()
        {
            restocks.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_RESTOCKREPLENISHMENT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Restock restock;

                while (reader.Read())
                {
                    int restockReplenishmentID = reader.GetInt32("restockreplenishmentID");
                    int productID = reader.GetInt32("ProductID");
                    int amount = reader.GetInt32("Amount");
                    string name = reader.GetString("Name");
                    int amountInStore = reader.GetInt32("AmountInStore");
                    int amountInDepot = reader.GetInt32("AmountInDepot");

                    restock = new Restock(restockReplenishmentID, productID, amount, name, amountInDepot, amountInStore);

                    restocks.Add(restock);
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
        }

        public void DeleteRestockRequest(string RestokID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = DELETE_RESTOCKREPLENISHMENT_BY_ID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RestockReplenishmentID", RestokID);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();
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

        public void FufillRestockRequest( string AmountInDepot, string amount, string ID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_RESTOCKREPLENISHMENT;
            try
            {
                int Depot = Convert.ToInt32(AmountInDepot);
                Depot += Convert.ToInt32(amount);
                if (Depot < 0)
                {
                    MessageBox.Show("nooooo don't do that you fool");
                    return;
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ProductID", ID);
                    cmd.Parameters.AddWithValue("@AmountInDepot", Depot.ToString());
                    conn.Open();

                    int numAffectedRows = cmd.ExecuteNonQuery();
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
        }

        public void AddRestockRequest(string ID, string Amount)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = CREATE_RESTOCKREPLENISHMENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", ID);
                cmd.Parameters.AddWithValue("@Amount", Amount);


                conn.Open();
                int numCreatedRows = cmd.ExecuteNonQuery();

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
