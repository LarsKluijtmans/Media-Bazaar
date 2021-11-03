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
        public void GetProduct(string Barcode)
        {
            Products.Clear();
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
                    int amountInStore = 23;
                    int amountInDepot = reader.GetInt32("AmountInDepot");
                    int sellingPrice = reader.GetInt32("Price");

                    product = new Product(productID, name, productType, barcode, amountInDepot, amountInStore, sellingPrice);
                    if (!product.IsDiscontinued)
                    {
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

        public void ViewAllProducts( string Value)
        {
            Products.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_PRODUCT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Value", Value);
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
                    int sellingPrice = reader.GetInt32("SellingPrice");

                    product = new Product(ProductID, name, productType, barcode, amountInDepot, amountInStore, sellingPrice);

                    if (!product.IsDiscontinued)
                    {
                        Products.Add(product);
                    }
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

        public void AddProduct(string Name, string Barcode, string ProductType, string AmountInStore, string AmountInDepot, string sellingPrice)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = CREATE_PRODUCT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Barcode", Barcode);
                cmd.Parameters.AddWithValue("@Type", ProductType);
                cmd.Parameters.AddWithValue("@AmountInDepot", AmountInDepot);
                cmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);

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

        public void EditProduct(string ID, string Name, string Barcode, string ProductType, string AmountInStore, string AmountInDepot, string sellingPrice)
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
                cmd.Parameters.AddWithValue("@AmountInDepot", AmountInDepot);
                cmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);
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
        public void DiscontinueProduct(string ID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = DISCONTINUE_PRODUCT_BY_ID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", ID);
                cmd.Parameters.AddWithValue("@IsDiscontinued", "True");
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
        public static string VIEW_ALL_PRODUCTS = "SELECT * FROM Product ORDER BY EmployeeID;";
        public void ViewProducts()
        {
            Products.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = VIEW_ALL_PRODUCTS;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Product product;

                while (reader.Read())
                {
                    if (reader.GetInt32("Discontinued") == 0)
                    {
                        int productID = reader.GetInt32("ProductID");
                        string name = reader.GetString("Name");
                        string barcode = reader.GetString("Barcode");
                        string productType = reader.GetString("Type");
                        int price = reader.GetInt32("Price");
                        int amountInDepot = reader.GetInt32("AmountInDepot");
                        int amountInStore = reader.GetInt32("AmountInStore");

                        product = new Product(productID, name, productType, barcode, amountInDepot, amountInStore, price);
                        Products.Add(product);
                    }
                }
            }
            catch (MySqlException msqEx)
            {
                //MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Something went wrong" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable ViewAllProducts()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = VIEW_ALL_PRODUCTS;

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
    }
}
