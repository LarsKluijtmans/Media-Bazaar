using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.dbClasses.IGetObject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses
{
    public class DBOrderInfo: IDBOrderInfo
    {
        private string GET_ALL_ORDER_INFOS = "SELECT * FROM orderinfo;";
        private string ADD_ORDER_INFO = "INSERT INTO orderinfo (ID, SupplierID, ProductBarcode, MinAmount, MaxAmount, Multiples) VALUES (@SupplierID, @Barcode, @MinAmount, @MaxAmount, @Multiples);";
        private string UPDATE_ORDER_INFO = "UPDATE orderinfo SET MaxAmount = @MaxAmount, MinAmount = @MinAmount, Multiples = @Multiples WHERE ID = @ID;";
        private string DELETE_ORDER_INFO = "DELETE FROM orderinfo WHERE ID = @ID;";

        private List<OrderInfo> orderInfos;
        private IGetProduct p;
        private IGetSupplier s;

        public List<OrderInfo> GetOrderInfos()
        {
            return orderInfos;
        }

        public DBOrderInfo(IGetProduct product, IGetSupplier supplier)
        {
            orderInfos = new List<OrderInfo>();

            p = product;
            s = supplier;

            GetAllOrderInfos();
        }
        private void GetAllOrderInfos()
        {
            orderInfos.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_ORDER_INFOS;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                OrderInfo orderinfo;

                while (reader.Read())
                {
                    int orderInfoID = reader.GetInt32("ID");
                    int supplierID = reader.GetInt32("SupplierID");
                    string barcode = reader.GetString("ProductBarcode");
                    int minAmount = reader.GetInt32("MinAmountOrdered");
                    int maxAmount = reader.GetInt32("MaxAmountOrdered"); 
                    int multiples = reader.GetInt32("Multiples");
                    double purchasePrice = reader.GetDouble(7);

                    orderinfo = new OrderInfo(orderInfoID, s.GetSupplierByID(supplierID), p.GetProduct(barcode), minAmount, maxAmount, multiples, purchasePrice);
                    orderInfos.Add(orderinfo);
                }
            }
            catch (MySqlException)
            {

            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
        }
        public bool AddOrderInfo(OrderInfo oi)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = ADD_ORDER_INFO;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
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
        public bool UpdateOrderInfo(int id, int minAmount, int maxAmount, int multiples)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = UPDATE_ORDER_INFO;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@MinAmount", minAmount);
                cmd.Parameters.AddWithValue("@MaxAmount", maxAmount);
                cmd.Parameters.AddWithValue("@Multiples", multiples);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    foreach(OrderInfo orderInfo in orderInfos)
                    {
                        if(orderInfo.ID == id)
                        {
                            orderInfo.MinAmount = minAmount;
                            orderInfo.MaxAmount = maxAmount;
                            orderInfo.Multiples = multiples;
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
        public bool DeleteOrderInfo(int id)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = DELETE_ORDER_INFO;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    foreach (OrderInfo orderInfo in orderInfos)
                    {
                        if (orderInfo.ID == id)
                        {
                            orderInfos.Remove(orderInfo);
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
    }
}
