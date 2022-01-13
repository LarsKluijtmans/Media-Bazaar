using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses
{
    public class DBSupplier: IDBSupplier
    {
        private string GET_ALL_SUPPLIERS = "SELECT * FROM supplier;";
        private string ADD_SUPPLIER = "INSERT INTO supplier (ID, Name, Country, BuildingNumber, PostalCode, Email, PhoneNumber, BankNumber) VALUES (@ID, @Name, @Country, @BuildingNumber, @PostalCode, @Email, @PhoneNumber, @BankNumber);";
        private string UPDATE_SUPPLIER = "UPDATE supplier SET Name = @Name, Country = @Country, BuildingNumber = @BuildingNumber, PostalCode = @PostalCode, Email = @Email, PhoneNumber = @PhoneNumber, BankNumber = @BankNumber WHERE ID = @ID;";
        private string DELETE_SUPPLIER = "DELETE FROM supplier WHERE ID = @ID;";

        private List<Supplier> suppliers;

        public List<Supplier> GetSuppliers()
        {
            return suppliers;
        }

        public DBSupplier()
        {
            suppliers = new List<Supplier>();
            GetAllSuppliers();
        }

        private void GetAllSuppliers()
        {
            suppliers.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_SUPPLIERS;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Supplier supplier;

                while (reader.Read())
                {
                    int id = reader.GetInt32("ID");
                    string name = reader.GetString("Name");
                    string country = reader.GetString("Country");
                    int buildingNumber = reader.GetInt32("BuildingNumber");
                    string postalCode = reader.GetString("PostalCode");
                    string email = reader.GetString("Email");
                    int phoneNumber = reader.GetInt32("PhoneNumber");
                    string bankNumber = reader.GetString("BankNumber");

                    supplier = new Supplier(id, name, country, buildingNumber, postalCode, email, phoneNumber, bankNumber);
                    suppliers.Add(supplier);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
        }
        public bool AddSupplier(int id, string name, string country, int buildingNumber, string postalCode, string email, int phoneNumber, string bankNumber)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = ADD_SUPPLIER;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@BuildingNumber", buildingNumber);
                cmd.Parameters.AddWithValue("@PostalCode", postalCode);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@BankNumber", bankNumber);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    Supplier supplier = new Supplier(id, name, country, buildingNumber, postalCode, email, phoneNumber, bankNumber);
                    suppliers.Add(supplier);

                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return true;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool UpdateSupplier(int id, string name, string country, int buildingNumber, string postalCode, string email, int phoneNumber, string bankNumber)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = UPDATE_SUPPLIER;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@SupplierName", name);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@BuildingNumber", buildingNumber);
                cmd.Parameters.AddWithValue("@PostalCode", postalCode);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@BankNumber", bankNumber);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    foreach(Supplier supplier in suppliers)
                    {
                        if(supplier.ID == id)
                        {
                            supplier.Name = name;
                            supplier.Country = country;
                            supplier.BuildingNumber = buildingNumber;
                            supplier.PostalCode = postalCode;
                            supplier.Email = email;
                            supplier.PhoneNumber = phoneNumber;
                            supplier.BankNumber = bankNumber;
                        }
                    }

                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }
        public bool DeleteSupplier(int id)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = DELETE_SUPPLIER;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    foreach (Supplier supplier in suppliers)
                    {
                        if (supplier.ID == id)
                        {
                            suppliers.Remove(supplier);
                        }
                    }
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }
}
