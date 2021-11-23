using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Statistics.ProductData
{
    class ReshelfData
    {
        private static string RESHELF_AMOUNT = "SELECT Name, COUNT(product.ProductID) FROM `product` INNER JOIN shelfreplenishment ON product.ProductID = shelfreplenishment.ProductID GROUP BY product.ProductID;";
        private static string RESHELF_PRODUCT_AMOUNT = "SELECT Name, sum(shelfreplenishment.AmountRequested) FROM `product` INNER JOIN shelfreplenishment ON product.ProductID = shelfreplenishment.ProductID GROUP BY product.ProductID  HAVING sum(shelfreplenishment.AmountRequested) > 1;";
       
        public ProductsData[] ReshelfAmount()
        {
            List<ProductsData> products = new List<ProductsData>();

            MySqlConnection conn = Utils.GetConnection();

            string sql = RESHELF_AMOUNT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                ProductsData productsData;

                while (reader.Read())
                {
                    productsData = new ProductsData(reader[0].ToString(), Convert.ToInt32(reader[1]));
                    products.Add(productsData);
                }

                return products.ToArray();
            }
            catch (MySqlException)
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
            return products.ToArray();
        }

        public ProductsData[] ReshelfProductAmount()
        {

            List<ProductsData> products = new List<ProductsData>();

            MySqlConnection conn = Utils.GetConnection();

            string sql = RESHELF_PRODUCT_AMOUNT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                ProductsData productsData;

                while (reader.Read())
                {

                    productsData = new ProductsData(reader[0].ToString(), Convert.ToInt32(reader[1]));
                    products.Add(productsData);

                }

                return products.ToArray();
            }
            catch (MySqlException)
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
            return products.ToArray();
        }
    }
}
