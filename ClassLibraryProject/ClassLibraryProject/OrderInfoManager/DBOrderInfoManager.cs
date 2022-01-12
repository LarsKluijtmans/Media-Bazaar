using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ClassLibraryProject
{
    public class DBOrderInfoManager : IDBOrderInfoManagerPM
    {
        // sql
        public string GET_ORDER_INFOS_FOR_PRODUCT = "SELECT * FROM OrderInfo as o INNER JOIN Supplier as s on o.SupplierID = s.ID WHERE o.ProductBarcode = @ProductBarcode;";


        public List<OrderInfo> GetOrderInfosForProduct(Product p)
        {
            List<OrderInfo> orderInfos = new List<OrderInfo>();

            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_ORDER_INFOS_FOR_PRODUCT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@ProductBarcode", p.Barcode);

                MySqlDataReader reader = cmd.ExecuteReader();

                OrderInfo orderInfo;
                Supplier supplier;

                while (reader.Read())
                {
                    int supplierID = reader.GetInt32(8);
                    string supplierName = reader.GetString(9);
                    string supplierCountry = reader.GetString(10);
                    int buildingNr = reader.GetInt32(11);
                    string postalCode = reader.GetString(12);
                    string email = reader.GetString(13);
                    string phoneNumber = reader.GetString(14);
                    string bankNumber = reader.GetString(15);
                    string productType = reader.GetString(16);

                    supplier = new Supplier(supplierID, supplierName, supplierCountry, buildingNr, postalCode, email, phoneNumber, bankNumber, productType);
                    
                    int orderInfoID = reader.GetInt32(0);
                    string barcode = reader.GetString(2);
                    int minAmount = reader.GetInt32(3);
                    int maxAmount = reader.GetInt32(4);
                    int multiples = reader.GetInt32(5);

                    orderInfo = new OrderInfo(orderInfoID, supplier, p, minAmount, maxAmount, multiples);
                    orderInfos.Add(orderInfo);
                }
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return orderInfos;
        }
    }
}
