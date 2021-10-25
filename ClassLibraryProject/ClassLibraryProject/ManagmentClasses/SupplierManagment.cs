using System;
using System.Data;
using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses
{
    public class SupplierManagment
    {
        private static string ADD_SUPPLIER = "INSERT INTO supplier (SupplierName, Country, BuildingNumber, PostalCode, Email, PhoneNumber, BankNumber) VALUES (@SupplierName, @Country, @BuildingNumber, @PostalCode, @Email, @PhoneNumber, @BankNumber);";
        private static string GET_SUPPLIERS = "SELECT * FROM supplier;";
        private static string DELETE_SUPPLIER_BY_ID = "DELETE FROM supplier WHERE SupplierID = @SupplierID;";
        private static string UPDATE_SUPPLIER = "UPDATE supplier SET SupplierName = @SupplierName, Country = @Country, BuildingNumber = @BuildingNumber, PostalCode = @PostalCode, Email = @Email, PhoneNumber = @PhoneNumber, BankNumber = @BankNumber WHERE SupplierID = @SupplierID;";

        public DataTable ViewAllSuppliers()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_SUPPLIERS;

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
        public void AddSupplier(string name, string country, int buildingNumber, int postalCode, string email, int phoneNumber, string bankNumber)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = ADD_SUPPLIER;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SupplierName", name);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@BuildingNumber", buildingNumber);
                cmd.Parameters.AddWithValue("@PostalCode", postalCode);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@BankNumber", bankNumber);

                conn.Open();
                int numCreatedRows = cmd.ExecuteNonQuery();
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
        public void EditSupplier(int id, string name, string country, int buildingNumber, int postalCode, string email, int phoneNumber, string bankNumber)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = UPDATE_SUPPLIER;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SupplierID", id);
                cmd.Parameters.AddWithValue("@SupplierName", name);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@BuildingNumber", buildingNumber);
                cmd.Parameters.AddWithValue("@PostalCode", postalCode);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@BankNumber", bankNumber);

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
        public void DeleteSupplier(string supplierID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = DELETE_SUPPLIER_BY_ID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SupplierID", supplierID);
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
