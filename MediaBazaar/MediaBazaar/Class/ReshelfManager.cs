using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaBazaar.Class
{
    public class ReshelfManagment
    {
        public static string CREATE_SHELFREPLENICHMENT = "INSERT INTO shelfreplenishment ( ProductID, Amount) VALUES ( @ProductID, @Amount);";
        public static string GET_ALL_SHELFREPLENICHMENT = "SELECT ShelfReplenishmentID,shelfreplenishment.ProductID, Amount, Name, Barcode, Type, AmountInStore, AmountInDepot FROM shelfreplenishment  INNER JOIN product ON shelfreplenishment.ProductID = product.ProductID ORDER BY ShelfReplenishmentID;";
        public static string UPDATE_SHELFREPLENICHMENT = "UPDATE PRODUCT SET AmountInStore = @AmountInStore, AmountInDepot = @AmountInDepot WHERE ProductID = @ProductID;";
        public static string DELETE_SHELFREPLENICHMENT_BY_ID = "DELETE FROM shelfreplenishment WHERE ShelfReplenishmentID = @ShelfReplenishmentID;";

        public List<ReShelf> reShelves;

        public ReshelfManagment()
        {
            reShelves = new List<ReShelf>();
        }

        public void ViewAllReshelfRequests()
        {
            reShelves.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_SHELFREPLENICHMENT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                ReShelf reshelf;

                while (reader.Read())
                {
                    int shelfReplenishmentID = reader.GetInt32("ShelfReplenishmentID");
                    int productID = reader.GetInt32("ProductID");
                    int amount = reader.GetInt32("Amount");
                    string name = reader.GetString("Name");
                    int amountInStore = reader.GetInt32("AmountInStore");
                    int amountInDepot = reader.GetInt32("AmountInDepot");

                    reshelf = new ReShelf(shelfReplenishmentID, productID, amount, name, amountInDepot, amountInStore);

                    reShelves.Add(reshelf);
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

        public void DeleteReshelfRequest( string ReShelfID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = DELETE_SHELFREPLENICHMENT_BY_ID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ShelfReplenishmentID", ReShelfID);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();

                ViewAllReshelfRequests();
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

        public void FufillReshelftRequest( string AmountInDepot, string AmountInStore, string amount, string ID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_SHELFREPLENICHMENT;
            try
            {
                int Depot = Convert.ToInt32(AmountInDepot);
                Depot -= Convert.ToInt32(amount);
                if (Depot < 0)
                {
                    MessageBox.Show("The Dpot does not have that many of this type of product");
                    return;
                }
                else
                {

                    int Store = Convert.ToInt32(AmountInStore);
                    Store += Convert.ToInt32(amount);
                    if (Store < 0)
                    {
                        MessageBox.Show("NOOOOOO what have you done!!!!!!!!!!!");
                        return;
                    }
                    else
                    {
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@ProductID", ID);
                        cmd.Parameters.AddWithValue("@AmountInStore", Store.ToString());
                        cmd.Parameters.AddWithValue("@AmountInDepot", Depot.ToString());
                        conn.Open();

                        int numCreatedRows = cmd.ExecuteNonQuery();
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
        }

        public void RequestReshelf(string ID, string Amount) 
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.CREATE_SHELFREPLENICHMENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", ID);
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
