using MediaBazaar.Class;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class DepotEmployee : Form
    {
        int ID;
        Store store;

        public DepotEmployee(int UserID, Store s)
        {
            InitializeComponent();
            ID = UserID;
            store = s;

            cbProductType.Items.Add("KITCHEN_HOME");
            cbProductType.Items.Add("PHOTO_VIDEO_NAVIGATION");
            cbProductType.Items.Add("SMARTHOME_APPLIANCES");
            cbProductType.Items.Add("GAMING_MUSIC_COMPUTERS");

            ViewAllProducts();
            ViewAllReshelfRequests();
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
               MessageBox.Show("'name' field is required.");
                return;
            }

            string Barcode = tbBarcode.Text;
            if (string.IsNullOrEmpty(Barcode))
            {
                MessageBox.Show("'Barcode' field is required.");
                return;
            }

            string ProductType = cbProductType.Text;
            if (string.IsNullOrEmpty(ProductType))
            {
                MessageBox.Show("'ProductType' field is required.");
                return;
            }

            string AmountInStore = tbmountInStore.Text;
            if (string.IsNullOrEmpty(AmountInStore))
            {
                MessageBox.Show("'AmountInStore' field is required.");
                return;
            }

            string AmountInDepot = tbAmountInDepot.Text;
            if (string.IsNullOrEmpty(AmountInDepot))
            {
                MessageBox.Show("'AmountInDepot' field is required.");
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
                MessageBox.Show("'name' field is required.");
                return;
            }

            string Barcode = tbBarcode.Text;
            if (string.IsNullOrEmpty(Barcode))
            {
                MessageBox.Show("'Barcode' field is required.");
                return;
            }

            string ProductType = cbProductType.Text;
            if (string.IsNullOrEmpty(ProductType))
            {
                MessageBox.Show("'ProductType' field is required.");
                return;
            }

            string AmountInStore = tbmountInStore.Text;
            if (string.IsNullOrEmpty(AmountInStore))
            {
                MessageBox.Show("'AmountInStore' field is required.");
                return;
            }

            string AmountInDepot = tbAmountInDepot.Text;
            if (string.IsNullOrEmpty(AmountInDepot))
            {
                MessageBox.Show("'AmountInDepot' field is required.");
                return;
            }
            string ID = tbID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please select a product");
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
                MessageBox.Show("'id' field is required.");
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

            Object ProductObject = lbProduct.SelectedItem;
            if (!(ProductObject is Product))
            {
                return;
            }

            Product product = (Product)ProductObject;

            tbProductID.Text = product.ProductID.ToString();
            tbRestockID.Text = "Next number";
            tbRestockName.Text = product.Name;
            tbRestockAmountSales.Text = product.AmountInStore.ToString();
            RestockAmountDepot.Text = product.AmountInDepot.ToString();
            tbRestockAmount.Text = "";
        }

        private void btnAddRestockRequest_Click(object sender, EventArgs e)
        {
            string ID = tbProductID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("'ID' field is required.");
                return;
            }

            string Amount = tbRestockAmount.Text;
            if (string.IsNullOrEmpty(Amount))
            {
                MessageBox.Show("'Amount' field is required.");
                return;
            }

            store.rectockManagment.AddRestockRequest(ID, Amount);
            ViewAllProducts();
        }
        
        //Reshelf

        public void DeleteReshelfRequest()
        {
            store.reshelfManagment.ViewAllReshelfRequests();

            lbReshelfRequest.Items.Clear();

            string ReShelfID = tbRequestID.Text;
            if (string.IsNullOrEmpty(ReShelfID))
            {
               MessageBox.Show("'ReShelfID' field is required.");
                return;
            }

            store.reshelfManagment.DeleteReshelfRequest(ReShelfID);
            ViewAllReshelfRequests();
            
                tbRID.Text = "";
                tbRequestID.Text = "";
                tbRName.Text = "";
                tbRamountInStore.Text = "";
                tbRAmountInDepot.Text = "";
                tbReshelfReqAmount.Text = "";
        }

        public void ViewAllReshelfRequests()
        {
            store.reshelfManagment.ViewAllReshelfRequests();

            lbReshelfRequest.Items.Clear();
            lstOverviewRequest.Items.Clear();

            foreach (ReShelf reShelf in store.reshelfManagment.reShelves)
            {
                lbReshelfRequest.Items.Add(reShelf);
                lstOverviewRequest.Items.Add(reShelf);
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
                MessageBox.Show("'amount' field is required.");
                return;
            }

            string AmountInStore = tbRamountInStore.Text;
            if (string.IsNullOrEmpty(AmountInStore))
            {
                MessageBox.Show("'AmountInStore' field is required.");
                return;
            }

            string AmountInDepot = tbRAmountInDepot.Text;
            if (string.IsNullOrEmpty(AmountInDepot))
            {
                MessageBox.Show("'AmountInDepot' field is required.");
                return;
            }
            string ID = tbRID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please select a product");
                return;
            }

            store.reshelfManagment.FufillReshelftRequest(AmountInDepot, AmountInStore, amount, ID);

            ViewAllReshelfRequests();
            DeleteReshelfRequest();
            ViewAllProducts();
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

           // employee.SelectWorkTime(preferedWorkTime, leastPreferedWorkTime);
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
