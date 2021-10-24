using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;

namespace ClassLibraryProject.ManagmentClasses
{
    public class ReshelfManagment
    {
        private static string REQUEST_SHELFREPLENISHMENT = "INSERT INTO shelfreplenishment (Barcode ,ProductID, AmountRequested, Status) VALUES (@ProductID, @Barcode, @AmountRequested, @Status);";
        private static string GET_ALL_SHELFREPLENISHMENT_REQUESTS = "SELECT * FROM shelfreplenishment WHERE Status = @Status;";
        private static string DELETE_SHELFREPLENISHMENT_BY_ID = "DELETE FROM shelfreplenishment WHERE ShelfReplenishmentID = @ShelfReplenishmentID;";
        private static string SHELFREPLENISHMENT = "UPDATE shelfreplenishment INNER JOIN product ON shelfreplenishment.ProductID = product.ProductID SET Status = @Status, product.AmountInDepot = @AmountDepot, product.AmountInStore = @AmountStore  WHERE ShelfReplenishmentID = @ShelfReplenishment;";
        private static string GET_AMOUNT_REQUESTED = "SELECT shelfreplenishment.AmountRequested FROM `shelfreplenishment` INNER JOIN product ON shelfreplenishment.ProductID = product.ProductID WHERE ShelfReplenishmentID = @ShelfReplenishmentID;";
        private static string GET_AMOUNT_STORE = "SELECT product.AmountInStore FROM `shelfreplenishment` INNER JOIN product ON shelfreplenishment.ProductID = product.ProductID WHERE ShelfReplenishmentID = @ShelfReplenishmentID;";
        private static string GET_AMOUNT_DEPOT = "SELECT product.AmountInDepot FROM `shelfreplenishment` INNER JOIN product ON shelfreplenishment.ProductID = product.ProductID WHERE ShelfReplenishmentID = @ShelfReplenishmentID;";

        public DataTable ViewReshelfRequests(string status)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_SHELFREPLENISHMENT_REQUESTS;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Status", status);

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

        public void DeleteReshelfRequest(string reshelfID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = DELETE_SHELFREPLENISHMENT_BY_ID;
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

        public void RequestReshelf(string barcode, string id, string amountRequested) 
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = REQUEST_SHELFREPLENISHMENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", id);
                cmd.Parameters.AddWithValue("@Barcode", barcode);
                cmd.Parameters.AddWithValue("@AmountRequested", amountRequested);
                cmd.Parameters.AddWithValue("@Status","Pending");


                conn.Open();
                int numCreatedRows = cmd.ExecuteNonQuery();
            }
            catch (MySqlException )
            { }
            catch (Exception )
            { }
            finally
            {
                conn.Close();
            }
        }
        public void ShelfReplenishment(string shelfReplenishmentID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = SHELFREPLENISHMENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ShelfReplenishmentID", shelfReplenishmentID);
                cmd.Parameters.AddWithValue("@Status", "Completed");

                int newAmountStore = GetAmountStore(shelfReplenishmentID) + GetAmountRequested(shelfReplenishmentID);
                int newAmountDepot = GetAmountDepot(shelfReplenishmentID) - GetAmountRequested(shelfReplenishmentID);

                cmd.Parameters.AddWithValue("@AmountDepot", newAmountDepot);
                cmd.Parameters.AddWithValue("@Status", newAmountStore);


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
        private int GetAmountRequested(string shelfReplenishmentID)
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
        private int GetAmountDepot(string shelfReplenishmentID)
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
        private int GetAmountStore(string shelfReplenishmentID)
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
