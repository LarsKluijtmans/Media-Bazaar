using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;

namespace ClassLibraryProject.ManagmentClasses
{
    public class RestockManagment
    {
        //For Action
            //For employee
        private static string REQUEST_RESTOCKREPLENISHMENT = "INSERT INTO restockreplenishment (Barcode, ProductID, ReceivedAmount, Status) VALUES (@Barcode, @ProductID, @ReceivedAmount, 'Pending');";
        private static string RESTOCK_REPLENISHMENT = "UPDATE restockreplenishment SET Status = 'Fulfilled', ReceivedAmount = @ReceivedAmount WHERE RestockReplenishmentID = @RestockReplenishmentID;";
        private static string ADD_TO_DEPOT = "UPDATE restockreplenishment INNER JOIN product ON restockreplenishment.ProductID = product.ProductID SET product.AmountInDepot = @AmountInDepot WHERE RestockReplenishmentID = @RestockReplenishmentID;";
            //For manager
        private static string ORDER_RESTOCK = "UPDATE restockreplenishment SET Status = 'Ordered' WHERE RestockReplenishmentID = @RestockReplenishmentID;";
        private static string DELETE_RESTOCKREPLENISHMENT_BY_ID = "DELETE FROM restockreplenishment WHERE RestockReplenishmentID = @RestockReplenishmentID;";
        //For Viewing
             //For manager
        private static string GET_PENDING_RESTOCKREPLENISHMENT_REQUESTS = "SELECT * FROM restockreplenishment WHERE Status = 'Pending';";
        private static string GET_HISTORY_RESTOCKREPLENISHMENT_REQUESTS = "SELECT * FROM restockreplenishment WHERE Status = 'Fulfilled';";
            //For employee
        private static string GET_ORDERED_RESTOCKREPLENISHMENT_REQUESTS = "SELECT * FROM restockreplenishment WHERE Status = 'Ordered';";
        //Extra
        private static string GET_AMOUNT_RECEIVED = "SELECT restockreplenishment.ReceivedAmount FROM restockreplenishment INNER JOIN product ON restockreplenishment.ProductID = product.ProductID WHERE RestockReplenishmentID = @RestockReplenishmentID;";
        private static string GET_AMOUNT_DEPOT = "SELECT product.AmountInDepot FROM restockreplenishment INNER JOIN product ON restockreplenishment.ProductID = product.ProductID WHERE RestockReplenishmentID = @RestockReplenishmentID;";
        private static string GET_STATUS = "SELECT Status FROM restockreplenishment WHERE Barcode = @Barcode;";

        //manager
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
        public void DeleteRestockRequest(int restockID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = DELETE_RESTOCKREPLENISHMENT_BY_ID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RestockReplenishmentID", restockID);
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
        public void OrderRestock(int restockReplinishmentID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = ORDER_RESTOCK;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RestockReplenishmentID", restockReplinishmentID);


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
        //For employee
        public DataTable ViewOrderedRestockRequests()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ORDERED_RESTOCKREPLENISHMENT_REQUESTS;

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
        public void RequestRestock(string barcode, int id)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = REQUEST_RESTOCKREPLENISHMENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", id);
                cmd.Parameters.AddWithValue("@Barcode", barcode);
                cmd.Parameters.AddWithValue("ReceivedAmount", null);


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
        public void RestockReplenishment(int restockReplenishmentID, int amountReceived)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = RESTOCK_REPLENISHMENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RestockReplenishmentID", restockReplenishmentID);
                cmd.Parameters.AddWithValue("@ReceivedAmount", amountReceived);

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
        public void AddToDepot(int restockReplenishmentID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = ADD_TO_DEPOT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RestockReplenishmentID", restockReplenishmentID);

                int newAmountDepot = GetAmountDepot(restockReplenishmentID) + GetAmountReceived(restockReplenishmentID);

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

        private int GetAmountReceived(int RestockReplenishmentID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_AMOUNT_RECEIVED;
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
        private int GetAmountDepot(int RestockReplenishmentID)
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
        public string GetStatus(string barcode)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_STATUS;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Barcode", barcode);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string status = reader.GetString("Status");
                    return status;
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
            return "";
        }
    }
}
