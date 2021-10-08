using MediaBazaar.Class;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormOfficeEmployee : Form
    {
        int ID;
        Store store;

        public FormOfficeEmployee(int UserID, Store s)
        {
            InitializeComponent();
            ID = UserID;
            store = s;

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //iD

            //FormEditEmployeeData editEmployeeData = new FormEditEmployeeData();
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

        // Products

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

        private void btnViewAllProducts_Click(object sender, EventArgs e)
        {
            ViewAllProducts();
        }

        private void btnDeletePorducts_Click(object sender, EventArgs e)
        {
            lbProducts.Items.Clear();

            string ID = tbID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("'id' field is required.");
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
                MessageBox.Show("Something went wrong" + ex);
            }
            finally
            {
                tbID.Text = "";
                tbName.Text = "";
                tbBarcode.Text = "";
                tbProductType.Text = "";
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
            tbProductType.Text = product.ProductType;
            tbmountInStore.Text = product.AmountInStore.ToString();
            tbAmountInDepot.Text = product.AmountInDepot.ToString();
        }

        // Restock

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
                MessageBox.Show("'RestokID' field is required.");
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
                MessageBox.Show("Something went wrong" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

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

        private void btnViewAllRestockRequests_Click(object sender, EventArgs e)
        {
            ViewAllRestockRequests();
        }

        private void tbnDeleterRestock_Click(object sender, EventArgs e)
        {
            DeleteRestockRequest();
        }

        //Reshelf

        public void DeleteReshelfRequest()
        {
            lbReshelfRequest.Items.Clear();

            string ReShelfID = tbRequestID.Text;
            if (string.IsNullOrEmpty(ReShelfID))
            {
                MessageBox.Show("'ReShelfID' field is required.");
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
                MessageBox.Show("Something went wrong" + ex);
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

        private void btnViewAllReShelftReq_Click(object sender, EventArgs e)
        {
            ViewAllReshelfRequests();
        }

        private void btnDeleteRequest_Click(object sender, EventArgs e)
        {
            DeleteReshelfRequest();
        }
        // availability
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string preferedWorkTime = PreferedWorkTime();
            string leastPreferedWorkTime = LeastPreferedWorkTime();

            MessageBox.Show(preferedWorkTime);

          //  employee.SelectWorkTime(preferedWorkTime, leastPreferedWorkTime);
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
    }
}
