using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;

namespace ClassLibraryProject.ManagmentClasses
{
    public class ReshelfManagment
    {
        //Action
            //For depot
        private static string SHELF_REPLENISHMENT = "UPDATE shelfreplenishment INNER JOIN product ON shelfreplenishment.ProductID = product.ProductID SET Status = 'Fulfilled', product.AmountInDepot = @AmountDepot, product.AmountInStore = @AmountStore  WHERE ShelfReplenishmentID = @ShelfReplenishmentID;";
        private static string DELETE_SHELF_REPLENISHMENT_BY_ID = "DELETE FROM shelfreplenishment WHERE ShelfReplenishmentID = @ShelfReplenishmentID;";
            //For sales
        private static string REQUEST_SHELF_REPLENISHMENT = "INSERT INTO shelfreplenishment (Barcode ,ProductID, AmountRequested, Status) VALUES (@Barcode, @ProductID, @AmountRequested, @Status);";
        //View
            //For depot
        private static string GET_FULFILLED_SHELF_REPLENISHMENT_REQUESTS = "SELECT * FROM shelfreplenishment WHERE Status = 'Fulfilled';";
        private static string GET_PENDING_SHELF_REPLENISHMENT_REQUESTS = "SELECT * FROM shelfreplenishment WHERE Status = 'Pending';";
        //Extra
        private static string GET_AMOUNT_REQUESTED = "SELECT shelfreplenishment.AmountRequested FROM `shelfreplenishment` INNER JOIN product ON shelfreplenishment.ProductID = product.ProductID WHERE ShelfReplenishmentID = @ShelfReplenishmentID;";
        private static string GET_AMOUNT_STORE = "SELECT product.AmountInStore FROM `shelfreplenishment` INNER JOIN product ON shelfreplenishment.ProductID = product.ProductID WHERE ShelfReplenishmentID = @ShelfReplenishmentID;";
        private static string GET_AMOUNT_DEPOT = "SELECT product.AmountInDepot FROM `shelfreplenishment` INNER JOIN product ON shelfreplenishment.ProductID = product.ProductID WHERE ShelfReplenishmentID = @ShelfReplenishmentID;";

        //For sales
        public void RequestReshelf(string barcode, int id, int amountRequested)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = REQUEST_SHELF_REPLENISHMENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", id);
                cmd.Parameters.AddWithValue("@Barcode", barcode);
                cmd.Parameters.AddWithValue("@AmountRequested", amountRequested);
                cmd.Parameters.AddWithValue("@Status", "Pending");


                conn.Open();
                int numCreatedRows = cmd.ExecuteNonQuery();
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
        //Depot
        public DataTable ViewPendingReshelfRequests()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_PENDING_SHELF_REPLENISHMENT_REQUESTS;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataAdapter reader = new MySqlDataAdapter(sql, conn);

                DataTable table = new DataTable();
                reader.Fill(table);

                return table;
            }
            catch (MySqlException )
            {}
            catch (Exception)
            {}
            finally
            {
                conn.Close();
            }
            DataTable a = new DataTable();
            return a;
        }
        public DataTable ViewHistoryReshelfRequests()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_FULFILLED_SHELF_REPLENISHMENT_REQUESTS;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataAdapter reader = new MySqlDataAdapter(sql, conn);

                DataTable table = new DataTable();
                reader.Fill(table);

                return table;
            }
            catch (MySqlException)
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
            DataTable a = new DataTable();
            return a;
        }
        public void DeleteReshelfRequest(int reshelfID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = DELETE_SHELF_REPLENISHMENT_BY_ID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ShelfReplenishmentID", reshelfID);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (MySqlException )
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
        }       
        public void ShelfReplenishment(int shelfReplenishmentID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = SHELF_REPLENISHMENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ShelfReplenishmentID", shelfReplenishmentID);

                int newAmountStore = GetAmountStore(shelfReplenishmentID) + GetAmountRequested(shelfReplenishmentID);
                int newAmountDepot = GetAmountDepot(shelfReplenishmentID) - GetAmountRequested(shelfReplenishmentID);

                cmd.Parameters.AddWithValue("@AmountDepot", newAmountDepot);
                cmd.Parameters.AddWithValue("@AmountStore", newAmountStore);


                conn.Open();
                int numCreatedRows = cmd.ExecuteNonQuery();
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
        private int GetAmountRequested(int shelfReplenishmentID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_AMOUNT_REQUESTED;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ShelfReplenishmentID", shelfReplenishmentID);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int amountRequested = reader.GetInt32("AmountRequested");
                    return amountRequested;
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
            return 0;
        }
        private int GetAmountDepot(int shelfReplenishmentID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_AMOUNT_DEPOT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ShelfReplenishmentID", shelfReplenishmentID);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int amountInDepot = reader.GetInt32("AmountInDepot");
                    return amountInDepot;
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
            return 0;
        }
        private int GetAmountStore(int shelfReplenishmentID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_AMOUNT_STORE;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ShelfReplenishmentID", shelfReplenishmentID);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int amountInStore = reader.GetInt32("AmountInStore");
                    return amountInStore;
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
            return 0;
        }
    }   
}
