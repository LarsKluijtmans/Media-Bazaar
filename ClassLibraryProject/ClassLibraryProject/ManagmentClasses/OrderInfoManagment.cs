using System;
using System.Collections.Generic;
using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;

namespace ClassLibraryProject.ManagmentClasses
{
    public class OrderInfoManagment
    {
        private string GET_ALL_ORDER_INFO = "SELECT * FROM orderinfo;";
        private string ADD_ORDER_INFO = "INSERT INTO orderinfo (SupplierID,ProductID,MinAmountOrdered,MaxAmountOrdered,Multiples) VALUES (@SupplierID, @ProductID, @MinAmountOrdered, @MaxAmountOrdered, @Multiples);";
        private string UPDATE_ORDER_INFO = "UPDATE orderinfo SET ProductID = @ProductID, MaxAmountOrdered = @MaxAmountOrdered, MinAmountOrdered = @MinAmountOrdered, Multiples = @Multiples WHERE SupplierID = @SupplierID;";
        private string DELETE_ORDER_INFO_BY_ID = "DELETE FROM orderinfo WHERE OrderInfoID = @OrderInfoID;";
        private string GET_ALL_PRODUCTS = "SELECT ProductID FROM orderinfo WHERE SupplierID = @SupplierID;";
        
        private List<OrderInfo> orderInfos;
        
        private List<int> products;
        
        public List<OrderInfo> OrderInfos
        {
            get { return orderInfos; }
            set { orderInfos = value; }
        }
        
        public List<int> Products
        {
            get { return products; }
            set { products = value; }
        }
        public OrderInfoManagment()
        {
            OrderInfos = new List<OrderInfo>();
            Products = new List<int>();
        }
        public void GetAllOrderInfo()
        {
            OrderInfos.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_ORDER_INFO;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                OrderInfo orderinfo;

                while (reader.Read())
                {
                    int orderInfoID = reader.GetInt32("OrderInfoID");
                    int supplierID = reader.GetInt32("SupplierID");
                    int minAmount = reader.GetInt32("MinAmountOrdered");
                    int maxAmount = reader.GetInt32("MaxAmountOrdered");
                    int productID = reader.GetInt32("ProductID");
                    int multiples = reader.GetInt32("Multiples");


                    orderinfo = new OrderInfo(orderInfoID, supplierID, productID, minAmount, maxAmount, multiples);
                    OrderInfos.Add(orderinfo);
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
        public void AddOrderInfo(int supplierID, int productID, int minAmount, int maxAmount, int multiples)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = ADD_ORDER_INFO;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", productID);
                cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                cmd.Parameters.AddWithValue("@MinAmountOrdered", minAmount);
                cmd.Parameters.AddWithValue("@MaxAmountOrdered", maxAmount);
                cmd.Parameters.AddWithValue("@Multiples", multiples);

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
        public void EditOrderInfo(int supplierID, int productID, int minAmount, int maxAmount, int multiples)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_ORDER_INFO;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", productID);
                cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                cmd.Parameters.AddWithValue("@MinAmountOrdered", minAmount);
                cmd.Parameters.AddWithValue("@MaxAmountOrdered", maxAmount);
                cmd.Parameters.AddWithValue("@Multiples", multiples);

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
        public void DeleteOrderInfo(int orderInfoID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = DELETE_ORDER_INFO_BY_ID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OrderInfoID", orderInfoID);
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
        public void GetAllProducts(int supplierID)
        {
            OrderInfos.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_PRODUCTS;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int productID = Convert.ToInt32(reader[0]);

                    products.Add(productID);
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
    }
}
