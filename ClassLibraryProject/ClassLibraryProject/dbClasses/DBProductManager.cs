﻿using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace ClassLibraryProject.dbClasses
{
    public class DBProductManager: IDBProduct, IDBProductManagerPM, IDBProductManagerSM
    {
        public string CREATE_PRODUCT = "INSERT INTO Product (Name, Barcode, Type, SellingPrice, AmountInDepot, AmountInStore, Discontinued) VALUES (@Name, @Barcode, @Type, @SellingPrice, @AmountInDepot, @AmountInStore, @IsDiscontinued);";
        public string READ_PRODUCTS_PM = "SELECT * FROM Product LIMIT 50;";
        public string SEARCH_PRODUCT_PM = "SELECT * FROM Product WHERE Name LIKE @Search OR Barcode LIKE @Search;";



        public static string GET_ALL_PRODUCT = "SELECT ProductID, Name, Barcode, Type, price, AmountInDepot, SellingPrice FROM Product WHERE Name LIKE '@value%' ORDER BY ProductID;";
        public static string UPDATE_PRODUCT = "UPDATE PRODUCT SET Name = @Name, Barcode = @Barcode, Type = @Type, AmountInStore = @AmountInStore, AmountInDepot = @AmountInDepot, SellingPrice = @SellingPrice WHERE ProductID = @ProductID;";
        public static string DELETE_PRODUCT_BY_ID = "DELETE FROM PRODUCT WHERE ProductID = @ProductID;";

        public static string DISCONTINUE_PRODUCT_BY_ID = "UPDATE Product SET IsDiscontinued = @IsDiscontinued  WHERE ProductID = @ProductID";

        /* Esther Start */

        /* Product Manager */
        public bool CreateProduct(Product p)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = CREATE_PRODUCT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@Name", p.ProductName);
                cmd.Parameters.AddWithValue("@Barcode", p.Barcode);
                cmd.Parameters.AddWithValue("@Type", p.ProductType);
                cmd.Parameters.AddWithValue("@SellingPrice", p.SellingPrice);
                cmd.Parameters.AddWithValue("@AmountInDepot", p.AmountInDepot);
                cmd.Parameters.AddWithValue("@AmountInStore", p.AmountInStore);
                cmd.Parameters.AddWithValue("@IsDiscontinued", p.IsDiscontinued);

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows == 1)
                {
                    return true;
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

            return false;
        }

        public List<Product> ReadProductsPM()
        {
            List<Product> products = new List<Product>();

            MySqlConnection conn = Utils.GetConnection();
            string sql = READ_PRODUCTS_PM;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Product product;

                while (reader.Read())
                {
                    int productID = reader.GetInt32(0);
                    string productName = reader.GetString(1);
                    string barcode = reader.GetString(2);
                    string type = reader.GetString(3);
                    double sellingPrice = reader.GetDouble(4);
                    int amountInDepot = reader.GetInt32(5);
                    int amountInStore = reader.GetInt32(6);
                    bool isDiscontinued = reader.GetBoolean(7);

                    product = new Product(productID, productName, barcode, type, sellingPrice, amountInDepot, amountInStore, isDiscontinued);
                    products.Add(product);
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

            return products;
        }

        public bool UpdateProduct(Product p)
        {
            return true;
        }

        public bool DeleteProduct(Product p)
        {
            return true;
        }

        public List<Product> SearchProductsPM(string search)
        {
            List<Product> products = new List<Product>();

            MySqlConnection conn = Utils.GetConnection();
            string sql = SEARCH_PRODUCT_PM;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@Search", search + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                Product product;

                while (reader.Read())
                {
                    int productID = reader.GetInt32(0);
                    string productName = reader.GetString(1);
                    string barcode = reader.GetString(2);
                    string type = reader.GetString(3);
                    double sellingPrice = reader.GetDouble(4);
                    int amountInDepot = reader.GetInt32(5);
                    int amountInStore = reader.GetInt32(6);
                    bool isDiscontinued = reader.GetBoolean(7);

                    product = new Product(productID, productName, barcode, type, sellingPrice, amountInDepot, amountInStore, isDiscontinued);
                    products.Add(product);
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

            return products;
        }
        /* Sales Manager */

        /* Esther End */

        //MohammadStart
        public static string GET_PRODUCTS = "SELECT * FROM product";

        public List<Product> RemoteProducts { get; set; }

        public void GetProduct()
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_PRODUCTS;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

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
                    bool isDiscontinued = reader.GetBoolean(7);

                    product = new Product(productID, name, productType, barcode, sellingPrice, amountInDepot, amountInStore, isDiscontinued);
                    if (!product.IsDiscontinued)
                    {
                        RemoteProducts.Add(product);
                        Products.Add(product);
                    }
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
        }
        //MohammadEnd
        public List<Product> Products { get; set; }

        public DBProductManager()
        {
            Products = new List<Product>();
            RemoteProducts = new List<Product>();
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

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

    }
}
