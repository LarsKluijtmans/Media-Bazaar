using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;

namespace ClassLibraryProject.ManagmentClasses
{
    public class OrderInfoManagment
    {
        private static string GET_ALL_ORDER_INFO = "SELECT * FROM orderinfo;";
        private static string UPDATE_ORDER_INFO = "UPDATE orderinfo SET ProductID = @ProductID, MaxAmountOrdered = @MaxAmount, MinAmountOrdered = @MinAmountOrdered WHERE Supplier = @SupplierID;";
        private static string DELETE_ORDER_INFO_BY_ID = "DELETE FROM orderinfo WHERE OrderInfoID = @OrderInfoID;";
        private List<OrderInfo> orderInfos;
        public List<OrderInfo> OrderInfos
        {
            get { return orderInfos; }
            set { orderInfos = value; }
        }
        public OrderInfoManagment()
        {
            OrderInfos = new List<OrderInfo>();
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
        public void EditOrderInfo(int supplierID, int productID, int minAmount, int maxAmount, int multiples)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_ORDER_INFO;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", productID);
                cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                cmd.Parameters.AddWithValue("@MinAmount", minAmount);
                cmd.Parameters.AddWithValue("@MaxAmount", maxAmount);
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
    }
}
