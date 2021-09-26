﻿using MediaBazaar.Class;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormDepotEmployee : Form, IReplenishment
    {
        Store s;
        Employee em;
        public FormDepotEmployee(Store store, Employee employee)
        {
            InitializeComponent();
            s = store;
            em = employee;
        }

        //product
        public void ViewAllProducts()
        {
            lbProducts.Items.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = Utils.GET_ALL_PRODUCT;

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
                    int amountInStore = reader.GetInt32("AmountInStore");
                    int amountInDepot = reader.GetInt32("AmountInDepot");

                    product = new Product(ProductID, name, productType, barcode, amountInDepot, amountInStore);

                    lbProducts.Items.Add(product);
                }
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            ViewAllProducts();
        }

        private void btnAddPorduct_Click(object sender, EventArgs e)
        {
            lbProducts.Items.Clear();

            string Name = tbName.Text;
            if (string.IsNullOrEmpty(Name))
            {
                lbProducts.Items.Add("'name' field is required.");
                return;
            }

            string Barcode = tbBarcode.Text;
            if (string.IsNullOrEmpty(Barcode))
            {
                lbProducts.Items.Add("'Barcode' field is required.");
                return;
            }

            string ProductType = cbProductType.Text;
            if (string.IsNullOrEmpty(ProductType))
            {
                lbProducts.Items.Add("'ProductType' field is required.");
                return;
            }

            string AmountInStore = tbmountInStore.Text;
            if (string.IsNullOrEmpty(AmountInStore))
            {
                lbProducts.Items.Add("'AmountInStore' field is required.");
                return;
            }

            string AmountInDepot = tbAmountInDepot.Text;
            if (string.IsNullOrEmpty(AmountInDepot))
            {
                lbProducts.Items.Add("'AmountInDepot' field is required.");
                return;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.CREATE_PRODUCT;
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

                tbID.Text = id.ToString();
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                ViewAllProducts();
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string Name = tbName.Text;
            if (string.IsNullOrEmpty(Name))
            {
                lbProducts.Items.Add("'name' field is required.");
                return;
            }

            string Barcode = tbBarcode.Text;
            if (string.IsNullOrEmpty(Barcode))
            {
                lbProducts.Items.Add("'Barcode' field is required.");
                return;
            }

            string ProductType = cbProductType.Text;
            if (string.IsNullOrEmpty(ProductType))
            {
                lbProducts.Items.Add("'ProductType' field is required.");
                return;
            }

            string AmountInStore = tbmountInStore.Text;
            if (string.IsNullOrEmpty(AmountInStore))
            {
                lbProducts.Items.Add("'AmountInStore' field is required.");
                return;
            }

            string AmountInDepot = tbAmountInDepot.Text;
            if (string.IsNullOrEmpty(AmountInDepot))
            {
                lbProducts.Items.Add("'AmountInDepot' field is required.");
                return;
            }
            string ID = tbID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                lbProducts.Items.Add("Please select a product");
                return;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.UPDATE_PRODUCT;
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

                lbProducts.Items.Insert(0, $"users updated: {numAffectedRows}.");
                ViewAllProducts();
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lbProducts.Items.Clear();

            string ID = tbID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                lbProducts.Items.Clear();
                lbProducts.Items.Add("'id' field is required.");
                return;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.DELETE_PRODUCT_BY_ID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", ID);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();

                ViewAllProducts();
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                tbID.Text = "";
                tbName.Text = "";
                tbBarcode.Text = "";
                cbProductType.Text = "";
                tbmountInStore.Text = "";
                tbAmountInDepot.Text = "";
                conn.Close();
            }
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex < 0)
            {
                return;
            }

            Object ProductObject = lbProducts.SelectedItem;
            if (!(ProductObject is Product))
            {
                return;
            }

            Product product = (Product)ProductObject;
            tbID.Text = product.ProductID.ToString();
            tbName.Text = product.Name;
            tbBarcode.Text = product.Barcode;
            cbProductType.Text = product.ProductType;
            tbmountInStore.Text = product.AmountInStore.ToString();
            tbAmountInDepot.Text = product.AmountInDepot.ToString();
        }

        //Restock
        public void ViewAllRestockRequests()
        {
            lbRestock.Items.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = Utils.GET_ALL_RESTOCKREPLENISHMENT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Restock restock;

                while (reader.Read())
                {
                    int restockReplenishmentID = reader.GetInt32("restockreplenishmentID");
                    int productID = reader.GetInt32("ProductID");
                    int amount = reader.GetInt32("Amount");
                    string name = reader.GetString("Name");
                    int amountInStore = reader.GetInt32("AmountInStore");
                    int amountInDepot = reader.GetInt32("AmountInDepot");

                    restock = new Restock(restockReplenishmentID, productID, amount, name, amountInDepot, amountInStore);

                    lbRestock.Items.Add(restock);
                }
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteRestockRequest()
        {
            lbRestock.Items.Clear();

            string RestokID = tbRestockID.Text;
            if (string.IsNullOrEmpty(RestokID))
            {
                lbRestock.Items.Clear();
                lbRestock.Items.Add("'RestokID' field is required.");
                return;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.DELETE_RESTOCKREPLENISHMENT_BY_ID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RestockReplenishmentID", RestokID);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();

                lbRestock.Items.Clear();
                ViewAllRestockRequests();
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnViewAllRestockRequests_Click(object sender, EventArgs e)
        {
            ViewAllRestockRequests();
        }

        private void btnFufillRestockRequest_Click(object sender, EventArgs e)
        {
            string amount = tbRestockAmount.Text;
            if (string.IsNullOrEmpty(amount))
            {
                lbRestock.Items.Add("'amount' field is required.");
                return;
            }

            string AmountInDepot = RestockAmountDepot.Text;
            if (string.IsNullOrEmpty(AmountInDepot))
            {
                lbRestock.Items.Add("'AmountInDepot' field is required.");
                return;
            }
            string ID = tbProductID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                lbRestock.Items.Add("Please select a product");
                return;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.UPDATE_RESTOCKREPLENISHMENT;
            try
            {
                int Depot = Convert.ToInt32(AmountInDepot);
                Depot += Convert.ToInt32(amount);
                if (Depot < 0)
                {
                    MessageBox.Show("nooooo don't do that you fool");
                    return;
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ProductID", ID);
                    cmd.Parameters.AddWithValue("@AmountInDepot", Depot.ToString());
                    conn.Open();

                    int numAffectedRows = cmd.ExecuteNonQuery();

                    ViewAllRestockRequests();
                    DeleteRestockRequest();
                }

            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                conn.Close();
            }
        } // doesn't work

        private void lbRestock_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbRestock.SelectedIndex < 0)
            {
                return;
            }

            Object RestockObject = lbRestock.SelectedItem;
            if (!(RestockObject is Restock))
            {
                return;
            }

            Restock restock = (Restock)RestockObject;

            tbProductID.Text = restock.ProductID.ToString();
            tbRestockID.Text = restock.RestockReplenishmentID.ToString();
            tbRestockName.Text = restock.Name;
            tbRestockAmountSales.Text = restock.AmountInStore.ToString();
            RestockAmountDepot.Text = restock.AmountInDepot.ToString();
            tbRestockAmount.Text = restock.Amount.ToString();
        }

        private void btnAddRestockRequest_Click(object sender, EventArgs e)
        {
            string ID = tbID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                lbProducts.Items.Add("'ID' field is required.");
                return;
            }

            string Amount = tbRestockAmount.Text;
            if (string.IsNullOrEmpty(Amount))
            {
                lbProducts.Items.Add("'Amount' field is required.");
                return;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.CREATE_RESTOCKREPLENISHMENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", ID);
                cmd.Parameters.AddWithValue("@Amount", Amount);


                conn.Open();
                int numCreatedRows = cmd.ExecuteNonQuery();
                ViewAllRestockRequests();
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {

                conn.Close();
            }
        }
        //Reshelf

        public void DeleteReshelfRequest()
        {
            lbReshelfRequest.Items.Clear();

            string ReShelfID = tbRequestID.Text;
            if (string.IsNullOrEmpty(ReShelfID))
            {
                lbReshelfRequest.Items.Clear();
                lbReshelfRequest.Items.Add("'ReShelfID' field is required.");
                return;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.DELETE_SHELFREPLENICHMENT_BY_ID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ShelfReplenishmentID", ReShelfID);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();

                ViewAllReshelfRequests();
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                tbRID.Text = "";
                tbRequestID.Text = "";
                tbRName.Text = "";
                tbRamountInStore.Text = "";
                tbRAmountInDepot.Text = "";
                tbReshelfReqAmount.Text = "";
                conn.Close();
            }
        }

        public void ViewAllReshelfRequests()
        {
            lbReshelfRequest.Items.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = Utils.GET_ALL_SHELFREPLENICHMENT;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                ReShelf reshelf;

                while (reader.Read())
                {
                    int shelfReplenishmentID = reader.GetInt32("ShelfReplenishmentID");
                    int productID = reader.GetInt32("ProductID");
                    int amount = reader.GetInt32("Amount");
                    string name = reader.GetString("Name");
                    int amountInStore = reader.GetInt32("AmountInStore");
                    int amountInDepot = reader.GetInt32("AmountInDepot");

                    reshelf = new ReShelf(shelfReplenishmentID, productID, amount, name, amountInDepot, amountInStore);

                    lbReshelfRequest.Items.Add(reshelf);
                }
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnViewAllReShelftReq_Click(object sender, EventArgs e)
        {
            ViewAllReshelfRequests();
        }

        private void btnFufillReshelftRequest_Click(object sender, EventArgs e)
        {
            string amount = tbReshelfReqAmount.Text;
            if (string.IsNullOrEmpty(amount))
            {
                lbProducts.Items.Add("'amount' field is required.");
                return;
            }

            string AmountInStore = tbRamountInStore.Text;
            if (string.IsNullOrEmpty(AmountInStore))
            {
                lbProducts.Items.Add("'AmountInStore' field is required.");
                return;
            }

            string AmountInDepot = tbRAmountInDepot.Text;
            if (string.IsNullOrEmpty(AmountInDepot))
            {
                lbProducts.Items.Add("'AmountInDepot' field is required.");
                return;
            }
            string ID = tbRID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                lbProducts.Items.Add("Please select a product");
                return;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.UPDATE_SHELFREPLENICHMENT;
            try
            {
                int Depot = Convert.ToInt32(AmountInDepot);
                Depot -= Convert.ToInt32(amount);
                if (Depot < 0)
                {
                    MessageBox.Show("The Dpot does not have that many of this type of product");
                    return;
                }
                else
                {

                    int Store = Convert.ToInt32(AmountInStore);
                    Store += Convert.ToInt32(amount);
                    if (Store < 0)
                    {
                        MessageBox.Show("NOOOOOO what have you done!!!!!!!!!!!");
                        return;
                    }
                    else
                    {
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@ProductID", ID);
                        cmd.Parameters.AddWithValue("@AmountInStore", Store.ToString());
                        cmd.Parameters.AddWithValue("@AmountInDepot", Depot.ToString());
                        conn.Open();

                        int numCreatedRows = cmd.ExecuteNonQuery();

                        ViewAllReshelfRequests();
                        DeleteReshelfRequest();
                    }
                }
            }

            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDeleteRequest_Click(object sender, EventArgs e)
        {
            DeleteReshelfRequest();
        }

        private void lbReshelfRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbReshelfRequest.SelectedIndex < 0)
            {
                return;
            }

            Object ShelfObject = lbReshelfRequest.SelectedItem;
            if (!(ShelfObject is ReShelf))
            {
                return;
            }

            ReShelf Shelf = (ReShelf)ShelfObject;

            tbRID.Text = Shelf.ProductID.ToString();
            tbRequestID.Text = Shelf.ShelfReplenishmentID.ToString();
            tbRName.Text = Shelf.Name;
            tbRamountInStore.Text = Shelf.AmountInStore.ToString();
            tbRAmountInDepot.Text = Shelf.AmountInDepot.ToString();
            tbReshelfReqAmount.Text = Shelf.Amount.ToString();
        }



        // other
        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FormEditEmployeeData editEmployeeData = new FormEditEmployeeData(s, em);
            editEmployeeData.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
        }

        public void Requested(Product p)
        {
            throw new NotImplementedException();
        }

        public void Replenish(Product p)
        {
            throw new NotImplementedException();
        }


    }
}
