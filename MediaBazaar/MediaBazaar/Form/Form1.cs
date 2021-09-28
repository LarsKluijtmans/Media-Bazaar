using MediaBazaar.Class;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class Form1 : Form
    {
        int ID;
        Store MediaBazaar;
        private string productN;
        private ProductType productType;
        private int productA;
        private string firstN;
        private string lastN;
        private int phoneN;
        private int bsn;
        private string username;
        private string email;
        private string password;

        public Form1(int userID, Store mb)
        {
            InitializeComponent();
            ID = userID;
            MediaBazaar = mb;
            cbProductType.Items.Add("KITCHEN_HOME");
            cbProductType.Items.Add("PHOTO_VIDEO_NAVIGATION");
            cbProductType.Items.Add("SMARTHOME_APPLIANCES");
            cbProductType.Items.Add("GAMING_MUSIC_COMPUTERS");
        }

        public Form1(string productN, ProductType productType, int productA)
        {
            this.productN = productN;
            this.productType = productType;
            this.productA = productA;
        }

        public Form1(string firstN, string lastN, int phoneN, int bsn, string username, string email, string password)
        {
            this.firstN = firstN;
            this.lastN = lastN;
            this.phoneN = phoneN;
            this.bsn = bsn;
            this.username = username;
            this.email = email;
            this.password = password;
        }

        public static implicit operator Form1(FormDepotManager v)
        {
            throw new NotImplementedException();
        }

        //Products
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
        }// error

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

        //Schedule

        public void ViewAllSchedule()
        {
            lbSchedule.Items.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = Utils.GET_SCHEDULE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Schedule schedule;

                while (reader.Read())
                {
                    int Id = reader.GetInt32("scheduleId");
                    string Department = reader.GetString("department");
                    string Day = reader.GetString("day");
                    int MorningAmount = reader.GetInt32("morning");
                    int AfternoonAmount = reader.GetInt32("afternoon");
                    int EveningAmount = reader.GetInt32("evening");

                    schedule = new Schedule(Id, Department, Day, MorningAmount, AfternoonAmount, EveningAmount);

                    lbSchedule.Items.Add(schedule);
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

        private void btViewSchedule_Click(object sender, EventArgs e)
        {
            ViewAllSchedule();
        }

        private void btnEditschedule_Click(object sender, EventArgs e)
        {
            string Morning = lbScheduleMorning.Text;
            if (string.IsNullOrEmpty(Morning))
            {
                lbSchedule.Items.Add("'Morning' field is required.");
                return;
            }

            string Afternoon = lbScheduleAfternoon.Text;
            if (string.IsNullOrEmpty(Afternoon))
            {
                lbSchedule.Items.Add("'Afternoon' field is required.");
                return;
            }

            string Evening = lbScheduleEvening.Text;
            if (string.IsNullOrEmpty(Evening))
            {
                lbSchedule.Items.Add("'Evening' field is required.");
                return;
            }
            string ID = lbScheduleID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                lbSchedule.Items.Add("Please select a time");
                return;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.UPDATE_SCHEDULE;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@scheduleId", ID);
                cmd.Parameters.AddWithValue("@morning", Morning);
                cmd.Parameters.AddWithValue("@afternoon", Afternoon);
                cmd.Parameters.AddWithValue("@evening", Evening);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();

                ViewAllSchedule();
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

        private void lbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSchedule.SelectedIndex < 0)
            {
                return;
            }

            Object scheduleObject = lbSchedule.SelectedItem;
            if (!(scheduleObject is Schedule))
            {
                return;
            }

            Schedule schedule = (Schedule)scheduleObject;

            lbScheduleID.Text = schedule.ID.ToString();
            lbScheduleDepartment.Text = schedule.Department.ToString();
            lbScheduleDay.Text = schedule.Day;
            lbScheduleMorning.Text = schedule.MorningAmount.ToString();
            lbScheduleAfternoon.Text = schedule.AfternoonAmount.ToString();
            lbScheduleEvening.Text = schedule.EveningAmount.ToString();
        }

        //Planing 

        public void ViewSalesPlaning()
        {
            lbPlaning.Items.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = Utils.GET_SALES_PLANING;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Planing planing;

                while (reader.Read())
                {
                    int WorkId = reader.GetInt32("workID");
                    string Department = reader.GetString("Department");
                    int employeeID = reader.GetInt32("employeeID");
                    string day = reader.GetString("day");
                    string time = reader.GetString("time");


                    planing = new Planing(WorkId, Department, employeeID, day, time);

                    lbPlaning.Items.Add(planing);
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

            lbEmployee.Items.Clear();

            sql = Utils.GET_SALES_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                BasicEmployeeInfo employee;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32("EmployeeID");
                    string firstName = reader.GetString("FirstName");
                    string lastName = reader.GetString("LastName");
                    string jodTitle = reader.GetString("JodTitle");


                    employee = new BasicEmployeeInfo(employeeID, firstName, lastName, jodTitle);

                    lbEmployee.Items.Add(employee);
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

        public void ViewDepotPlaning()
        {
            lbPlaning.Items.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = Utils.GET_DEPOT_PLANING;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Planing planing;

                while (reader.Read())
                {
                    int WorkId = reader.GetInt32("workID");
                    string Department = reader.GetString("Department");
                    int employeeID = reader.GetInt32("employeeID");
                    string day = reader.GetString("day");
                    string time = reader.GetString("time");


                    planing = new Planing(WorkId, Department, employeeID, day, time);

                    lbPlaning.Items.Add(planing);
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

            lbEmployee.Items.Clear();

            sql = Utils.GET_DEPOT_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                BasicEmployeeInfo employee;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32("EmployeeID");
                    string firstName = reader.GetString("FirstName");
                    string lastName = reader.GetString("LastName");
                    string jodTitle = reader.GetString("JodTitle");


                    employee = new BasicEmployeeInfo(employeeID, firstName, lastName, jodTitle);

                    lbEmployee.Items.Add(employee);
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

        public void ViewOfficePlaning()
        {
            lbPlaning.Items.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = Utils.GET_OFFICE_PLANING;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Planing planing;

                while (reader.Read())
                {
                    int WorkId = reader.GetInt32("workID");
                    string Department = reader.GetString("Department");
                    int employeeID = reader.GetInt32("employeeID");
                    string day = reader.GetString("day");
                    string time = reader.GetString("time");


                    planing = new Planing(WorkId, Department, employeeID, day, time);

                    lbPlaning.Items.Add(planing);
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

            lbEmployee.Items.Clear();

            sql = Utils.GET_OFFICE_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                BasicEmployeeInfo employee;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32("EmployeeID");
                    string firstName = reader.GetString("FirstName");
                    string lastName = reader.GetString("LastName");
                    string jodTitle = reader.GetString("JodTitle");


                    employee = new BasicEmployeeInfo(employeeID, firstName, lastName, jodTitle);

                    lbEmployee.Items.Add(employee);
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

        private void btnViewSalesPlan_Click(object sender, EventArgs e)
        {
            ViewSalesPlaning();
        }

        private void btnDepotPlan_Click(object sender, EventArgs e)
        {
            ViewDepotPlaning();
        }

        private void btnOfficePlan_Click(object sender, EventArgs e)
        {
            ViewOfficePlaning();
        }

        private void btnEditPlaning_Click(object sender, EventArgs e)
        {

            string WorkID = tbWorkId.Text;
            if (string.IsNullOrEmpty(WorkID))
            {
                lbPlaning.Items.Add("'WorkID' field is required.");
                lbEmployee.Items.Add("'WorkID' field is required.");
                return;
            }

            string NewEmployeeId = tbNewEmployeeId.Text;
            if (string.IsNullOrEmpty(NewEmployeeId))
            {
                lbPlaning.Items.Add("'NewEmployeeId' field is required.");
                lbEmployee.Items.Add("'NewEmployeeId' field is required.");
                return;
            }

            string Department = tbDep.Text;
            if (string.IsNullOrEmpty(Department))
            {
                lbPlaning.Items.Add("'Department' field is required.");
                lbEmployee.Items.Add("'Department' field is required.");
                return;
            }

            string Day = tbDay.Text;
            if (string.IsNullOrEmpty(Day))
            {
                lbPlaning.Items.Add("'Day' field is required.");
                lbEmployee.Items.Add("'Day' field is required.");
                return;
            }

            string Time = tbTime.Text;
            if (string.IsNullOrEmpty(Time))
            {
                lbPlaning.Items.Add("'Time' field is required.");
                lbEmployee.Items.Add("'Time' field is required.");
                return;
            }
            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.UPDATE_PLANING;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@emplyeeID", NewEmployeeId);
                cmd.Parameters.AddWithValue("@workID", WorkID);

                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();

                if (Department == "Sales")
                {
                    ViewSalesPlaning();
                }
                else if (Department == "Office")
                {
                    ViewOfficePlaning();
                }
                else if (Department == "Depot")
                {
                    ViewDepotPlaning();
                }

                tbNewEmployeeId.Text = "";
                tbWorkId.Text = "";
                tbNewEmployeeId.Text = "";
                tbDep.Text = "";
                tbDay.Text = "";
                tbTime.Text = "";
                tbNewEmployeeId.BackColor = Color.LightGray;


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

        private void lbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEmployee.SelectedIndex < 0)
            {
                return;
            }

            Object employeeObject = lbEmployee.SelectedItem;
            if (!(employeeObject is BasicEmployeeInfo))
            {
                return;
            }

            BasicEmployeeInfo EmployeeInfo = (BasicEmployeeInfo)employeeObject;

            tbNewEmployeeId.Text = EmployeeInfo.EmployeeID.ToString();
            tbNewEmployeeId.BackColor = Color.LightBlue;

        }

        private void lbPlaning_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPlaning.SelectedIndex < 0)
            {
                return;
            }

            Object planObject = lbPlaning.SelectedItem;
            if (!(planObject is Planing))
            {
                return;
            }

            Planing planing = (Planing)planObject;

            tbWorkId.Text = planing.WorkID.ToString();
            tbNewEmployeeId.Text = planing.EmployeeID.ToString();
            tbDep.Text = planing.Department;
            tbDay.Text = planing.Day.ToString();
            tbTime.Text = planing.Time.ToString();

        }

        private void btnEmpltySchedule_Click(object sender, EventArgs e)
        {
            lbPlaning.Items.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = Utils.CLEAR_PLAN;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
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

            sql = Utils.MAKE_EMPTY_SCHEDULE;

            int count = 1;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Planing planing;

                while (reader.Read())
                {
                    count = 1;
                    int Morning = reader.GetInt32("Morning");
                    int Afternoon = reader.GetInt32("Afternoon");
                    int Evening = reader.GetInt32("Evening");
                    while (count <= Morning)
                    {
                        string Department = reader.GetString("Department");
                        int employeeID = 0;
                        string day = reader.GetString("day");
                        string time = "Morning";

                        planing = new Planing(Department, employeeID, day, time);

                        lbPlaning.Items.Add(planing);
                        count++;
                    }

                    count = 1;

                    while ( count <= Afternoon)
                    {
                        string Department = reader.GetString("Department");
                        int employeeID = 0;
                        string day = reader.GetString("day");
                        string time = "Afternoon";

                        planing = new Planing(Department, employeeID, day, time);

                        lbPlaning.Items.Add(planing);
                        count++;
                    }

                    count = 1;

                    while (count <= Evening)
                    {
                        string Department = reader.GetString("Department");
                        int employeeID = 0;
                        string day = reader.GetString("day");
                        string time = "Evening";

                        planing = new Planing(Department, employeeID, day, time);

                        lbPlaning.Items.Add(planing);
                        count++;
                    }
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

            int count2 = Convert.ToInt32( lbPlaning.Items.Count) ;
            count = 0;


            sql = Utils.CREATE_SCHDULEDWORK;

            while (count < count2 )
            {

                Planing plan = (Planing)lbPlaning.Items[count];

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                   

                    cmd.Parameters.AddWithValue("@depratment", plan.Department);
                    cmd.Parameters.AddWithValue("@EmployeeID", plan.EmployeeID);
                    cmd.Parameters.AddWithValue("@Day", plan.Day);
                    cmd.Parameters.AddWithValue("@Time", plan.Time);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    count++;
                }
                catch (MySqlException msqEx)
                {
                    MessageBox.Show(msqEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show( $"Something went wrong {ex}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
