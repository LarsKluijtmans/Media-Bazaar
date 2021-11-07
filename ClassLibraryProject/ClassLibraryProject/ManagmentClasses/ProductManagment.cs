using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLibraryProject.ManagmentClasses
{
    public class ProductManagment
    {

        public static string CREATE_PRODUCT = "INSERT INTO Product ( Name, Barcode, Type, AmountInStore, AmountInDepot, SellingPrice, IsDiscontinued) VALUES (@Name, @Barcode, @Type, @AmountInStore, @AmountInDepot, @SellingPrice, @IsDiscontinued);";
        public static string GET_ALL_PRODUCT = "SELECT ProductID, Name, Barcode, Type, price, AmountInDepot, SellingPrice FROM Product WHERE Name LIKE '@value%' ORDER BY ProductID;";
        public static string UPDATE_PRODUCT = "UPDATE PRODUCT SET Name = @Name, Barcode = @Barcode, Type = @Type, AmountInStore = @AmountInStore, AmountInDepot = @AmountInDepot, SellingPrice = @SellingPrice WHERE ProductID = @ProductID;";
        public static string DELETE_PRODUCT_BY_ID = "DELETE FROM PRODUCT WHERE ProductID = @ProductID;";

        public static string DISCONTINUE_PRODUCT_BY_ID = "UPDATE Product SET IsDiscontinued = @IsDiscontinued  WHERE ProductID = @ProductID";

        //MohammadStart
        public static string GET_PRODUCTS = "SELECT * FROM product WHERE Barcode = @Barcode";

        public List<Product> RemoteProducts { get; set; }

        public void GetProduct(string Barcode)
        {
            RemoteProducts.Clear();
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_PRODUCTS;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Barcode", Barcode);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                Product product;
                while (reader.Read())
                {
                    int productID = reader.GetInt32("ProductID");
                    string barcode = reader.GetString("Barcode");
                    string name = reader.GetString("Name");
                    string productType = reader.GetString("Type");
                    int amountInStore = reader.GetInt32("AmountInStore");
                    int amountInDepot = reader.GetInt32("AmountInDepot");
                    int sellingPrice = reader.GetInt32("Price");

                    product = new Product(productID, name, productType, barcode, sellingPrice, amountInDepot, amountInStore);
                    if (!product.IsDiscontinued)
                    {
                        RemoteProducts.Add(product);
                        Products.Add(product);
                    }
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
        //MohammadEnd
        public List<Product> Products { get; set; }

        public ProductManagment()
        {
            Products = new List<Product>();
        }
        
        public void DiscontinueProduct(string ID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = DISCONTINUE_PRODUCT_BY_ID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", ID);
                cmd.Parameters.AddWithValue("@IsDiscontinued", 1);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (MySqlException msqEx)
            {

            } catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        // esther start

        // sql 
        public static string CREATE_PRODUCTS = "INSERT INTO Product (Name, Barcode, Type, Price, AmountInDepot, AmountInStore, Discontinued) VALUES (@Name, @Barcode, @Type, @Price, @AmountInDepot, @AmountInStore, @Discontinued);";
        public static string READ_PRODUCTS = "SELECT * FROM Product ORDER BY ProductID;";
        public static string UPDATE_PRODUCTS = "UPDATE Product SET Name = @Name, Barcode = @Barcode, Type = @Type WHERE ProductID = @ProductID;";
        public static string DELETE_PRODUCTS = "DELETE FROM Product WHERE ProductID = @ProductID;";
        public static string UPDATE_PRICE = "UPDATE Product SET Price = @Price WHERE ProductID = @ProductID;";
        public static string DISCONTINUE_PRODUCT = "UPDATE Product SET Discontinued = @Discontinued WHERE ProductID = @ProductID;";
        public DataTable ViewAllProducts()
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = READ_PRODUCTS;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataAdapter reader = new MySqlDataAdapter(sql, conn);

                DataTable table = new DataTable();
                reader.Fill(table);

                return table;
            }
            catch (MySqlException msqlEx)
            {
                //MessageBox.Show(msqlEx.ToString());
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return null;
        }
        public void AddProduct(string name, string barcode, string type, double price)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = CREATE_PRODUCTS;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Barcode", barcode);
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@AmountInStore", 0);
                cmd.Parameters.AddWithValue("@AmountInDepot", 0);
                cmd.Parameters.AddWithValue("@Discontinued", 0);

                conn.Open();
                int numCreatedRows = cmd.ExecuteNonQuery();
                long id = cmd.LastInsertedId;
            } catch(MySqlException mysqlEx)
            {

            } catch(Exception ex)
            {
                
            }
            finally
            {
                conn.Close();
            }
        }
        public void EditProduct(int id, string name, string barcode, string type, double price)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = UPDATE_PRODUCTS;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ProductID", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Barcode", barcode);
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@Price", price);

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
        public void DeleteProduct(int productID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = DELETE_PRODUCTS;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", productID);
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
        public void EditPrice(int id, double price)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = UPDATE_PRICE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ProductID", id);
                cmd.Parameters.AddWithValue("@Price", price);

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
        public void DiscontinueProduct(int id)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = DISCONTINUE_PRODUCT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ProductID", id);
                cmd.Parameters.AddWithValue("@Discontinued", 1);

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
