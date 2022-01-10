using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.dbClasses.IGetObject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ClassLibraryProject.dbClasses
{
    public class DBRestock: IDBRestock
    {
        private string GET_ALL_RESTOCKS = "SELECT * FROM restock;";

        //employee
        private string ADD_RESTOCK_REQUEST = "INSERT INTO restock (ID, ProductBarcode, Amount, Status) VALUES (@ID, @Barcode, null, 'Pending');";
        private string RECEIVE_RESTOCK = "UPDATE restock SET Status = 'Fulfilled' WHERE ID = @ID;";
        private string CHANGE_AMOUNT = "UPDATE product SET AmountInDepot = @Amount WHERE Barcode = @Barcode;";

        //manager
        private string ORDER_RESTOCK = "UPDATE restock SET Status = 'Ordered', Amount = @Amount, OrderInfoID = @OrderID WHERE ID = @ID;";
        private string DELETE_RESTOCK_BY_ID = "DELETE FROM restock WHERE ID = @ID;";

        private List<Restock> restocks;
        private IGetProduct p;
        private IGetOrderInfo o;

        public List<Restock> GetRestockRequests()
        {
            return restocks;
        }

        public DBRestock(IGetProduct product, IGetOrderInfo orderInfo)
        {
            restocks = new List<Restock>();
            p = product;
            o = orderInfo;

            GetAllRestocks();
        }

        private void GetAllRestocks()
        {
            restocks.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_RESTOCKS;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Restock restock;

                while (reader.Read())
                {
                    int id = reader.GetInt32("ID");
                    string barcode = reader.GetString("ProductBarcode");
                    int amount = reader.GetInt32("Amount");
                    string status = reader.GetString("Status");
                    int orderID = reader.GetInt32("OrderInfoID");

                    restock = new Restock(id, p.GetProduct(barcode), o.GetOrderInfo(orderID), amount, status);
                    restocks.Add(restock);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
        }

        //manager
        public bool DeleteRestock(int id)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = DELETE_RESTOCK_BY_ID;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    foreach(Restock restock in restocks)
                    {
                        if(restock.ID == id)
                        {
                            restocks.Remove(restock);
                        }
                    }
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool OrderRestock(int id, OrderInfo orderInfo, int amount)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = ORDER_RESTOCK;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@OrderID", orderInfo.ID);
                cmd.Parameters.AddWithValue("@Amount", amount);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    foreach (Restock restock in restocks)
                    {
                        if (restock.ID == id)
                        {
                            restock.Status = "Ordered";
                            restock.OrderInfo = orderInfo;
                            restock.AmountRequested = amount;
                        }
                    }
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        //employee
        public bool RequestRestock(int id, Product product)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = ADD_RESTOCK_REQUEST;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Barcode", product.Barcode);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    Restock restock = new Restock(id, product);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool ReceiveRestock(int id)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = RECEIVE_RESTOCK;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    foreach (Restock restock in restocks)
                    {
                        if (restock.ID == id)
                        {
                            restock.Status = "Fulfilled";
                        }
                    }
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool ChangeAmount(Product product, int amount)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = CHANGE_AMOUNT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Barcode", product.Barcode);
                cmd.Parameters.AddWithValue("@Amount", amount);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    product.AmountInDepot = amount;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
