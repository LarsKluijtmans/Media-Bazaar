using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ClassLibraryProject.dbClasses
{
    public class DBSupplierManager: IDBSupplierManagerPM
    {
        private string GET_ALL_SUPPLIERS = "SELECT * FROM supplier;";
        private string ADD_SUPPLIER = "INSERT INTO supplier (ID, Name, Country, BuildingNumber, PostalCode, Email, PhoneNumber, BankNumber) VALUES (@ID, @Name, @Country, @BuildingNumber, @PostalCode, @Email, @PhoneNumber, @BankNumber);";
        private string UPDATE_SUPPLIER = "UPDATE supplier SET Name = @Name, Country = @Country, BuildingNumber = @BuildingNumber, PostalCode = @PostalCode, Email = @Email, PhoneNumber = @PhoneNumber, BankNumber = @BankNumber WHERE ID = @ID;";
        private string DELETE_SUPPLIER = "DELETE FROM supplier WHERE ID = @ID;";

        private string GET_SUPPLIERS_FOR_PRODUCT = "SELECT * FROM Supplier WHERE ProductType = @ProductType;";

        public bool CreateSupplier(Supplier s)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSupplier(Supplier s)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> ReadSuppliers()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
