﻿using MediaBazaar.Class;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormDepotEmployee : Form
    {
        int ID;
        Store store;

        public FormDepotEmployee(int UserID, Store s)
        {
            InitializeComponent();
            ID = UserID;
            store = s;
            ViewAllProducts();
            ViewAllReshelfRequests();

            cbProductType.Items.Add("KITCHEN_HOME");
            cbProductType.Items.Add("PHOTO_VIDEO_NAVIGATION");
            cbProductType.Items.Add("SMARTHOME_APPLIANCES");
            cbProductType.Items.Add("GAMING_MUSIC_COMPUTERS");

            store.productManagment.ViewAllProducts();

            ViewAllProducts();
        }

        //Employee schedule

        public void EmployeeSchedule()
        {

        }

        //product
        public void ViewAllProducts()
        {
            store.productManagment.ViewAllProducts();

            lbProducts.Items.Clear();
            lbProduct.Items.Clear();
            lstOverviewProduct.Items.Clear();

            foreach (Product product in store.productManagment.products)
            {
                lbProducts.Items.Add(product);
                lbProduct.Items.Add(product);
                lstOverviewProduct.Items.Add(product);
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

            store.productManagment.AddProduct(Name, Barcode, ProductType, AmountInStore, AmountInDepot);
            ViewAllProducts();
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

            store.productManagment.EditProduct(ID, Name, Barcode, ProductType, AmountInStore, AmountInDepot);
            ViewAllProducts();
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

            store.productManagment.DeleteProduct(ID);

            tbID.Text = "";
            tbName.Text = "";
            tbBarcode.Text = "";
            cbProductType.Text = "";
            tbmountInStore.Text = "";
            tbAmountInDepot.Text = "";

            ViewAllProducts();
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

        private void btnViewAllRestockRequests_Click(object sender, EventArgs e)
        {
            ViewAllProducts();
        }

        //private void btnFufillRestockRequest_Click(object sender, EventArgs e) { }

        private void lbRestock_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbProduct.SelectedIndex < 0)
            {
                return;
            }

            Object RestockObject = lbProduct.SelectedItem;
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

            store.rectockManagment.AddRestockRequest(ID, Amount);
            ViewAllProducts();
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
            catch (Exception)
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
                    lstOverviewRequest.Items.Add(reshelf);
                }
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
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
            catch (Exception)
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
            if (btnCheck.Text == "Check Out")
            {
                var date = DateTime.Now;
                MySqlConnection conn = Utils.GetConnection();
                string sql = Utils.CREATE_CHECKOUT;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", ID.ToString());
                    cmd.Parameters.AddWithValue("@CheckOutTime", date.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                    conn.Open();
                    int n = cmd.ExecuteNonQuery();
                }
                catch (MySqlException msqEx)
                {
                    MessageBox.Show(msqEx.Message);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong");
                }
                finally
                {
                    conn.Close();
                    btnCheck.Text = "Check In";
                    MessageBox.Show("Check out successful");
                }
            }
            Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //FormEditEmployeeData editEmployeeData = new FormEditEmployeeData(s, em);
            //editEmployeeData.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (btnCheck.Text == "Check In")
            {
                var date = DateTime.Now;
                MySqlConnection conn = Utils.GetConnection();
                string sql = Utils.CREATE_CHECKIN;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", ID.ToString());
                    cmd.Parameters.AddWithValue("@CheckInTime", date.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@CheckOutTime", null);
                    cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                    conn.Open();
                    int n = cmd.ExecuteNonQuery();
                }
                catch (MySqlException msqEx)
                {
                    MessageBox.Show(msqEx.Message);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong");
                }
                finally
                {
                    conn.Close();
                    btnCheck.Text = "Check Out";
                    MessageBox.Show("Check in successful");
                }
            }
            else if (btnCheck.Text == "Check Out")
            {
                var date = DateTime.Now;
                MySqlConnection conn = Utils.GetConnection();
                string sql = Utils.CREATE_CHECKOUT;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", ID.ToString());
                    cmd.Parameters.AddWithValue("@CheckOutTime", date.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                    conn.Open();
                    int n = cmd.ExecuteNonQuery();
                }
                catch (MySqlException msqEx)
                {
                    MessageBox.Show(msqEx.Message);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong");
                }
                finally
                {
                    conn.Close();
                    btnCheck.Text = "Check In";
                    MessageBox.Show("Check out successful");
                }
            }
        }
        // availability
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string preferedWorkTime = PreferedWorkTime();
            string leastPreferedWorkTime = LeastPreferedWorkTime();

            employee.SelectWorkTime(preferedWorkTime, leastPreferedWorkTime);
        }

        public string PreferedWorkTime()
        {
            string preferedWorkTime;

            if (cbxPreferedDay.SelectedItem.ToString() == "Monday")
            {
                if (rbnMorningPrefered.Checked)
                {
                    return preferedWorkTime = "Monday - morning";
                }
                else if (rbnAfternoonPrefered.Checked)
                {
                    return preferedWorkTime = "Monday - afternoon";
                }
                else if (rbnEveningPrefered.Checked)
                {
                    return preferedWorkTime = "Monday - afternoon";
                }
            }
            else if (cbxPreferedDay.SelectedItem.ToString() == "Tuesday")
            {
                if (rbnMorningPrefered.Checked)
                {
                    return preferedWorkTime = "Tuesday - morning";
                }
                else if (rbnAfternoonPrefered.Checked)
                {
                    return preferedWorkTime = "Tuesday - afternoon";
                }
                else if (rbnEveningPrefered.Checked)
                {
                    return preferedWorkTime = "Tuesday - afternoon";
                }
            }
            else if (cbxPreferedDay.SelectedItem.ToString() == "Wednesday")
            {
                if (rbnMorningPrefered.Checked)
                {
                    return preferedWorkTime = "Wednesday - morning";
                }
                else if (rbnAfternoonPrefered.Checked)
                {
                    return preferedWorkTime = "Wednesday - afternoon";
                }
                else if (rbnEveningPrefered.Checked)
                {
                    return preferedWorkTime = "Wednesday - afternoon";
                }
            }
            else if (cbxPreferedDay.SelectedItem.ToString() == "Thurday")
            {
                if (rbnMorningPrefered.Checked)
                {
                    return preferedWorkTime = "Thurday - morning";
                }
                else if (rbnAfternoonPrefered.Checked)
                {
                    return preferedWorkTime = "Thursday - afternoon";
                }
                else if (rbnEveningPrefered.Checked)
                {
                    return preferedWorkTime = "Thursday - afternoon";
                }
            }
            else if (cbxPreferedDay.SelectedItem.ToString() == "Friday")
            {
                if (rbnMorningPrefered.Checked)
                {
                    return preferedWorkTime = "Friday - morning";
                }
                else if (rbnAfternoonPrefered.Checked)
                {
                    return preferedWorkTime = "Friday - afternoon";
                }
                else if (rbnEveningPrefered.Checked)
                {
                    return preferedWorkTime = "Friday - afternoon";
                }
            }
            else if (cbxPreferedDay.SelectedItem.ToString() == "Saturday")
            {
                if (rbnMorningPrefered.Checked)
                {
                    return preferedWorkTime = "Saturday - morning";
                }
                else if (rbnAfternoonPrefered.Checked)
                {
                    return preferedWorkTime = "Saturday - afternoon";
                }
                else if (rbnEveningPrefered.Checked)
                {
                    return preferedWorkTime = "Saturday - afternoon";
                }
            }
            else if (cbxPreferedDay.SelectedItem.ToString() == "Sunday")
            {
                if (rbnMorningPrefered.Checked)
                {
                    return preferedWorkTime = "Sunday - morning";
                }
                else if (rbnAfternoonPrefered.Checked)
                {
                    return preferedWorkTime = "Sunday - afternoon";
                }
                else if (rbnEveningPrefered.Checked)
                {
                    return preferedWorkTime = "Sunday - afternoon";
                }
            }
            return null;
        }
        public string LeastPreferedWorkTime()
        {
            string leastPreferedWorkTime;

            if (cbxLeastPreferedDay.SelectedItem.ToString() == "Monday")
            {
                if (rbnMorningLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Monday - morning";
                }
                else if (rbnAfternoonLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Monday - afternoon";
                }
                else if (rbnEveningLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Monday - afternoon";
                }
            }
            else if (cbxLeastPreferedDay.SelectedItem.ToString() == "Tuesday")
            {
                if (rbnMorningLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Tuesday - morning";
                }
                else if (rbnAfternoonLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Tuesday - afternoon";
                }
                else if (rbnEveningLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Tuesday - afternoon";
                }
            }
            else if (cbxLeastPreferedDay.SelectedItem.ToString() == "Wednesday")
            {
                if (rbnMorningLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Wednesday - morning";
                }
                else if (rbnAfternoonLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Wednesday - afternoon";
                }
                else if (rbnEveningLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Wednesday - afternoon";
                }
            }
            else if (cbxLeastPreferedDay.SelectedItem.ToString() == "Thurday")
            {
                if (rbnMorningLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Thurday - morning";
                }
                else if (rbnAfternoonLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Thursday - afternoon";
                }
                else if (rbnEveningLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Thursday - afternoon";
                }
            }
            else if (cbxLeastPreferedDay.SelectedItem.ToString() == "Friday")
            {
                if (rbnMorningLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Friday - morning";
                }
                else if (rbnAfternoonLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Friday - afternoon";
                }
                else if (rbnEveningLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Friday - afternoon";
                }
            }
            else if (cbxLeastPreferedDay.SelectedItem.ToString() == "Saturday")
            {
                if (rbnMorningLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Saturday - morning";
                }
                else if (rbnAfternoonLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Saturday - afternoon";
                }
                else if (rbnEveningLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Saturday - afternoon";
                }
            }
            else if (cbxLeastPreferedDay.SelectedItem.ToString() == "Sunday")
            {
                if (rbnMorningLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Sunday - morning";
                }
                else if (rbnAfternoonLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Sunday - afternoon";
                }
                else if (rbnEveningLeastPrefered.Checked)
                {
                    return leastPreferedWorkTime = "Sunday - afternoon";
                }
            }
            return null;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
