using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;

namespace ClassLibraryProject.ManagmentClasses
{
    public class RestockManagment
    {
        private static string REQUEST_RESTOCKREPLENISHMENT = "INSERT INTO restockreplenishment (Barcode ,ProductID, AmountRequested, Status) VALUES (@Barcode, @ProductID, @AmountRequested, @Status);";
        private static string GET_PENDING_RESTOCKREPLENISHMENT_REQUESTS = "SELECT * FROM restockreplenishment WHERE Status = 'Pending';";
        private static string GET_HISTORY_RESTOCKREPLENISHMENT_REQUESTS = "SELECT * FROM restockreplenishment WHERE Status = 'Fulfilled';";
        private static string DELETE_RESTOCKREPLENISHMENT_BY_ID = "DELETE FROM restockreplenishment WHERE RestockReplenishmentID = @RestockReplenishmentID;";
        private static string RESTOCKREPLENISHMENT = "UPDATE restockreplenishment INNER JOIN product ON Restockreplenishment.ProductID = product.ProductID SET Status = 'Fulfilled', product.AmountInDepot = @AmountInDepot WHERE RestockReplenishmentID = @RestockReplenishmentID;";
        private static string GET_AMOUNT_REQUESTED = "SELECT restockreplenishment.AmountRequested FROM `Restockreplenishment` INNER JOIN product ON Restockreplenishment.ProductID = product.ProductID WHERE RestockReplenishmentID = @RestockReplenishmentID;";
        private static string GET_AMOUNT_DEPOT = "SELECT product.AmountInDepot FROM `restockreplenishment` INNER JOIN product ON Restockreplenishment.ProductID = product.ProductID WHERE RestockReplenishmentID = @RestockReplenishmentID;";

        public DataTable ViewPendingRestockRequests()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_PENDING_RESTOCKREPLENISHMENT_REQUESTS;

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
        public DataTable ViewHistoryRestockRequests()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_HISTORY_RESTOCKREPLENISHMENT_REQUESTS;

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

        public void DeleteRestockRequest(string reRestockID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = DELETE_RESTOCKREPLENISHMENT_BY_ID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RestockReplenishmentID", reRestockID);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();
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

        public void RequestRestock(string barcode, int id, int amountRequested)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = REQUEST_RESTOCKREPLENISHMENT;
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
        public void RestockReplenishment(string RestockReplenishmentID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = RESTOCKREPLENISHMENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RestockReplenishmentID", RestockReplenishmentID);

                int newAmountDepot = GetAmountDepot(RestockReplenishmentID) + GetAmountRequested(RestockReplenishmentID);

                cmd.Parameters.AddWithValue("@AmountInDepot", newAmountDepot);

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
        private int GetAmountRequested(string RestockReplenishmentID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_AMOUNT_REQUESTED;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RestockReplenishmentID", RestockReplenishmentID);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int amountRequested = Convert.ToInt32(reader[0]);
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
        private int GetAmountDepot(string RestockReplenishmentID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_AMOUNT_DEPOT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RestockReplenishmentID", RestockReplenishmentID);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int amountInDepot = Convert.ToInt32(reader[0]);
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
    }
}
