using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ClassLibraryProject.ManagmentClasses
{
    public class ProductManagment
    {

        public static string CREATE_PRODUCT = "INSERT INTO Product ( Name, Barcode, Type, AmountInStore, AmountInDepot) VALUES (@Name, @Barcode, @Type, @AmountInStore, @AmountInDepot);";
        public static string GET_ALL_PRODUCT = "SELECT ProductID, Name, Barcode, Type, price, AmountInDepot FROM Product ORDER BY ProductID;";
        public static string UPDATE_PRODUCT = "UPDATE PRODUCT SET Name = @Name, Barcode = @Barcode, Type = @Type, AmountInStore = @AmountInStore, AmountInDepot = @AmountInDepot WHERE ProductID = @ProductID;";
        public static string DELETE_PRODUCT_BY_ID = "DELETE FROM PRODUCT WHERE ProductID = @ProductID;";

        public List<Product> products;

        public ProductManagment()
        {
            products = new List<Product>();
        }

        public void ViewAllProducts()
        {
            products.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_PRODUCT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Product product;

                while (reader.Read())
                {
                    int ProductID = reader.GetInt32("ProductID");
                    string barcode = reader.GetString("Barcode");
                    string name = reader.GetString("Name");
                    string productType = reader.GetString("Type");
                    int amountInStore = reader.GetInt32("Price");
                    int amountInDepot = reader.GetInt32("AmountInDepot");

                    product = new Product(ProductID, name, productType, barcode, amountInDepot, amountInStore);

                    products.Add(product);
                }
            }
            catch (MySqlException )
            {}
            catch (Exception)
            {}
            finally
            {
                conn.Close();
            }
        }

        public void AddProduct(string Name, string Barcode, string ProductType, string AmountInStore, string AmountInDepot)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = CREATE_PRODUCT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Barcode", Barcode);
                cmd.Parameters.AddWithValue("@Type", ProductType);
                cmd.Parameters.AddWithValue("@AmountInStore", AmountInStore);
                cmd.Parameters.AddWithValue("@AmountInDepot", AmountInDepot);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();
                long id = cmd.LastInsertedId;
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

        public void EditProduct(string ID, string Name, string Barcode, string ProductType, string AmountInStore, string AmountInDepot)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_PRODUCT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", ID);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Barcode", Barcode);
                cmd.Parameters.AddWithValue("@Type", ProductType);
                cmd.Parameters.AddWithValue("@AmountInStore", AmountInStore);
                cmd.Parameters.AddWithValue("@AmountInDepot", AmountInDepot);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (MySqlException )
            { }
            catch (Exception)
            {}
            finally
            {
                conn.Close();
            }
        }

        public void DeleteProduct(string ID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = DELETE_PRODUCT_BY_ID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", ID);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();

                ViewAllProducts();
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
        }
}
