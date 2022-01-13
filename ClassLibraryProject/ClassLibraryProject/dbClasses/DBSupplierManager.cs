using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace ClassLibraryProject.dbClasses
{
    public class DBSupplierManager: IDBSupplierManagerPM
    {
        private string CREATE_SUPPLIER = "INSERT INTO Supplier (ID, Name, Country, BuildingNumber, PostalCode, Email, PhoneNumber, BankNumber, ProductType) VALUES (@ID, @Name, @Country, @BuildingNumber, @PostalCode, @Email, @PhoneNumber, @BankNumber, @ProductType);";
        private string READ_SUPPLIERS = "SELECT * FROM Supplier;";
        private string UPDATE_SUPPLIER = "UPDATE supplier SET Name = @Name, Country = @Country, BuildingNumber = @BuildingNumber, PostalCode = @PostalCode, Email = @Email, PhoneNumber = @PhoneNumber, BankNumber = @BankNumber WHERE ID = @ID;";
        private string DELETE_SUPPLIER = "DELETE FROM supplier WHERE ID = @ID;";

        private string GET_SUPPLIERS_FOR_PRODUCT = "SELECT * FROM Supplier WHERE ProductType = @ProductType;";
        private string GET_SUPPLIER_BY_ID = "SELECT * FROM Supplier WHERE ID = @ID;";

        public bool CreateSupplier(Supplier s)
        {
            /*if (!Regex.IsMatch(s.Email, @"[a-z0-9]+(?:\.[a-z0-9]+)*@(?:[a-z](?:[a-z]*[a-z])?\.)nl|com"))
            {
                return false;
            }*/

            MySqlConnection conn = Utils.GetConnection();
            string sql = CREATE_SUPPLIER;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@ID", s.ID);
                cmd.Parameters.AddWithValue("@Name", s.Name);
                cmd.Parameters.AddWithValue("@Country", s.Country);
                cmd.Parameters.AddWithValue("@BuildingNumber", s.BuildingNumber);
                cmd.Parameters.AddWithValue("@PostalCode", s.PostalCode);
                cmd.Parameters.AddWithValue("@Email", s.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", s.PhoneNumber);
                cmd.Parameters.AddWithValue("@BankNumber", s.BankNumber);
                cmd.Parameters.AddWithValue("@ProductType", s.ProductType);

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

        public bool DeleteSupplier(Supplier s)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> ReadSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();

            MySqlConnection conn = Utils.GetConnection();
            string sql = READ_SUPPLIERS;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Supplier supplier;

                while (reader.Read())
                {
                    int supplierID = reader.GetInt32(0);
                    string supplierName = reader.GetString(1);
                    string country = reader.GetString(2);
                    int buildingNr = reader.GetInt32(3);
                    string zipCode = reader.GetString(4);
                    string email = reader.GetString(5);
                    string phoneNumber = reader.GetString(6);
                    string bankNumber = reader.GetString(7);
                    string productType = reader.GetString(8);

                    supplier = new Supplier(supplierID, supplierName, country, buildingNr, bankNumber, zipCode, email, phoneNumber, productType);
                    suppliers.Add(supplier);
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

            return suppliers;
        }

        public List<Supplier> GetSuppliersForProduct(Product p)
        {
            List<Supplier> suppliers = new List<Supplier>();

            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_SUPPLIERS_FOR_PRODUCT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@ProductType", p.ProductType);

                MySqlDataReader reader = cmd.ExecuteReader();

                Supplier supplier;

                while (reader.Read())
                {
                    int supplierID = reader.GetInt32(0);
                    string supplierName = reader.GetString(1);
                    string country = reader.GetString(2);
                    int buildingNr = reader.GetInt32(3);
                    string postalCode = reader.GetString(4);
                    string email = reader.GetString(5);
                    string phoneNumber = reader.GetString(6);
                    string bankNumber = reader.GetString(7);
                    string productType = reader.GetString(8);

                    supplier = new Supplier(supplierID, supplierName, country, buildingNr, postalCode, email, phoneNumber, bankNumber, productType);
                    suppliers.Add(supplier);
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

            return suppliers;
        }

        public bool UpdateSupplier(Supplier s)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_SUPPLIER;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("ID", s.ID);

                cmd.Parameters.AddWithValue("@Name", s.Name);
                cmd.Parameters.AddWithValue("@Country", s.Country);
                cmd.Parameters.AddWithValue("@BuildingNumber", s.BuildingNumber);
                cmd.Parameters.AddWithValue("@PostalCode", s.PostalCode);
                cmd.Parameters.AddWithValue("@Email", s.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", s.PhoneNumber);
                cmd.Parameters.AddWithValue("@BankNumber", s.BankNumber);
                cmd.Parameters.AddWithValue("@ProductType", s.ProductType);

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
        public Supplier GetSupplierByID(int supplierID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_SUPPLIER_BY_ID;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@ID", supplierID);

                MySqlDataReader reader = cmd.ExecuteReader();

                Supplier supplier;

                while (reader.Read())
                {
                    string supplierName = reader.GetString(1);
                    string country = reader.GetString(2);
                    int buildingNr = reader.GetInt32(3);
                    string postalCode = reader.GetString(4);
                    string email = reader.GetString(5);
                    string phoneNumber = reader.GetString(6);
                    string bankNumber = reader.GetString(7);
                    string productType = reader.GetString(8);

                    supplier = new Supplier(supplierID, supplierName, country, buildingNr, postalCode, email, phoneNumber, bankNumber, productType);
                    return supplier;
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

            return null;
        }
    }
}
