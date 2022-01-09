using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.dbClasses.IGetObject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses
{
    public class DBReshelf: IDBReshelf
    {
        private string GET_ALL_RESHELVES = "SELECT * FROM reshelf;";

        //For depot
        private string COMPLETE_RESHELF = "UPDATE reshelf SET Status = 'Fulfilled'  WHERE ID = @ID;";
        private string DELETE_RESHELF = "DELETE FROM reshelf WHERE ID = @ID;";
        private string CHANGE_AMOUNT = "UPDATE product SET AmountInDepot = @Amount WHERE Barcode = @Barcode;";

        //For sales
        private string REQUEST_RESHELF = "INSERT INTO reshelf (ID, ProductBarcode, Amount, Status) VALUES (@ID, @Barcode, @Amount, 'Pending');";

        private List<Reshelf> reshelves;
        private IGetProduct p;

        public List<Reshelf> GetReshelfRequests()
        {
            return reshelves;
        }

        public DBReshelf(IGetProduct product)
        {
            reshelves = new List<Reshelf>();
            p = product;

            GetAllReshelves();
        }

        private void GetAllReshelves()
        {
            reshelves.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_ALL_RESHELVES;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Reshelf reshelf;

                while (reader.Read())
                {
                    int id = reader.GetInt32("ID");
                    string barcode = reader.GetString("ProductBarcode");
                    int amount = reader.GetInt32("Amount");
                    string status = reader.GetString("Status");

                    reshelf = new Reshelf(id, p.GetProduct(barcode), amount, status);
                    reshelves.Add(reshelf);
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

        //For sales
        public bool RequestReshelf(int id, Product product, int amount)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = REQUEST_RESHELF;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Barcode", product.Barcode);
                cmd.Parameters.AddWithValue("@Amount", amount);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    Reshelf reshelf = new Reshelf(id, product, amount);
                    reshelves.Add(reshelf);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        //Depot
        public bool DeleteReshelf(int id)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = DELETE_RESHELF;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    foreach(Reshelf reshelf in reshelves)
                    {
                        if(reshelf.ID == id)
                        {
                            reshelves.Remove(reshelf);
                        }
                    }
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool CompleteReshelf(int id)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = COMPLETE_RESHELF;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    foreach (Reshelf reshelf in reshelves)
                    {
                        if (reshelf.ID == id)
                        {
                            reshelf.Status = "Fulfilled";
                        }
                    }
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool ChangeAmount(Product product, int amount)
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = CHANGE_AMOUNT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Barcode", product.Barcode);
                cmd.Parameters.AddWithValue("@Amount", amount);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows > 0)
                {
                    product.AmountInDepot = amount;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
