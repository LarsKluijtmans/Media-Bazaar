using MediaBazaar.Class;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class Admin : Form
    {
        int ID;
        Store store;

        public Admin(int userID, Store s)
        {
            InitializeComponent();
            ID = userID;
            store = s;
            cbProductType.Items.Add("KITCHEN_HOME");
            cbProductType.Items.Add("PHOTO_VIDEO_NAVIGATION");
            cbProductType.Items.Add("SMARTHOME_APPLIANCES");
            cbProductType.Items.Add("GAMING_MUSIC_COMPUTERS");

            ViewAllProducts();
            ViewAllReshelfRequests();
            ViewAllRestockRequests();
            ViewAllSchedule();
            ViewSalesPlaning();
            dgvSchedule.DataSource = store.scheduleManagment.ViewSalesSchedule();
        }

        //Products

        public void ViewAllProducts()
        {
            store.productManagment.ViewAllProducts();

            lbProducts.Items.Clear();
            lstOverviewProduct.Items.Clear();

            foreach (Product product in store.productManagment.products)
            {
                lbProducts.Items.Add(product);
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

        public void ViewAllRestockRequests()
        {
            store.rectockManagment.ViewAllRestockRequests();

            lbRestock.Items.Clear();
            lstOverviewAnnoucement.Items.Clear();

            foreach (Restock restock in store.rectockManagment.restocks)
            {
                lbRestock.Items.Add(restock);
                lstOverviewAnnoucement.Items.Add(restock);
            }
        }

        public void DeleteRestockRequest()
        {
            store.rectockManagment.ViewAllRestockRequests();

            lbRestock.Items.Clear();

            string RestokID = tbRestockID.Text;
            if (string.IsNullOrEmpty(RestokID))
            {
                lbRestock.Items.Clear();
                lbRestock.Items.Add("'RestokID' field is required.");
                return;
            }

            store.rectockManagment.DeleteRestockRequest(RestokID);
            lbRestock.Items.Clear();
            ViewAllRestockRequests();
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
                MessageBox.Show("'amount' field is required.");
                return;
            }

            string AmountInDepot = RestockAmountDepot.Text;
            if (string.IsNullOrEmpty(AmountInDepot))
            {
                MessageBox.Show("'AmountInDepot' field is required.");
                return;
            }
            string ID = tbProductID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please select a product");
                return;
            }

            store.rectockManagment.FufillRestockRequest(AmountInDepot, amount, ID);

            ViewAllRestockRequests();
            DeleteRestockRequest();
            ViewAllProducts();

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
            store.reshelfManagment.ViewAllReshelfRequests();

            lbReshelfRequest.Items.Clear();

            string ReShelfID = tbRequestID.Text;
            if (string.IsNullOrEmpty(ReShelfID))
            {
                lbReshelfRequest.Items.Clear();
                lbReshelfRequest.Items.Add("'ReShelfID' field is required.");
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
            lstOverviewComplaint.Items.Clear();

            foreach (ReShelf reShelf in store.reshelfManagment.reShelves)
            {
                lbReshelfRequest.Items.Add(reShelf);
                lstOverviewComplaint.Items.Add(reShelf);
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

        //Schedule

        public void ViewAllSchedule()
        {
            dgvSchedule.DataSource = store.scheduleManagment.ViewSalesSchedule();
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
                MessageBox.Show("'Morning' field is required.");
                return;
            }

            string Afternoon = lbScheduleAfternoon.Text;
            if (string.IsNullOrEmpty(Afternoon))
            {
                MessageBox.Show("'Afternoon' field is required.");
                return;
            }

            string Evening = lbScheduleEvening.Text;
            if (string.IsNullOrEmpty(Evening))
            {
                MessageBox.Show("'Evening' field is required.");
                return;
            }
            string ID = lbScheduleID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please select a time");
                return;
            }

            store.scheduleManagment.Editschedule(ID, Morning, Afternoon, Evening);

            ViewAllSchedule();
        }

        

        //Planing 

        public void ViewSalesPlaning()
        {
            store.planingManagment.ViewSalesPlaning();

            lbPlaning.Items.Clear();

            foreach (Planing planing in store.planingManagment.planings)
            {
                lbPlaning.Items.Add(planing);
            }


            lbEmployee.Items.Clear();

            foreach (BasicEmployeeInfo employee in store.planingManagment.employees)
            {
                lbEmployee.Items.Add(employee);
            }
        }

        public void ViewDepotPlaning()
        {
            store.planingManagment.ViewDepotPlaning();

            lbPlaning.Items.Clear();

            foreach (Planing planing in store.planingManagment.planings)
            {
                lbPlaning.Items.Add(planing);
            }


            lbEmployee.Items.Clear();

            foreach (BasicEmployeeInfo employee in store.planingManagment.employees)
            {
                lbEmployee.Items.Add(employee);
            }
        }

        public void ViewOfficePlaning()
        {
            store.planingManagment.ViewOfficePlaning();

            lbPlaning.Items.Clear();

            foreach (Planing planing in store.planingManagment.planings)
            {
                lbPlaning.Items.Add(planing);
            }


            lbEmployee.Items.Clear();

            foreach (BasicEmployeeInfo employee in store.planingManagment.employees)
            {
                lbEmployee.Items.Add(employee);
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
                MessageBox.Show("'WorkID' field is required.");
                MessageBox.Show("'WorkID' field is required.");
                return;
            }

            string NewEmployeeId = tbNewEmployeeId.Text;
            if (string.IsNullOrEmpty(NewEmployeeId))
            {
                MessageBox.Show("'NewEmployeeId' field is required.");
                MessageBox.Show("'NewEmployeeId' field is required.");
                return;
            }

            string Department = tbDep.Text;
            if (string.IsNullOrEmpty(Department))
            {
                MessageBox.Show("'Department' field is required.");
                MessageBox.Show("'Department' field is required.");
                return;
            }

            string Day = tbDay.Text;
            if (string.IsNullOrEmpty(Day))
            {
                MessageBox.Show("'Day' field is required.");
                MessageBox.Show("'Day' field is required.");
                return;
            }

            string Time = tbTime.Text;
            if (string.IsNullOrEmpty(Time))
            {
                MessageBox.Show("'Time' field is required.");
                MessageBox.Show("'Time' field is required.");
                return;
            }

            store.planingManagment.EditPlaning(WorkID, NewEmployeeId, Department, Day, Time);

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
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
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

                    while (count <= Afternoon)
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
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                conn.Close();
            }

            int count2 = Convert.ToInt32(lbPlaning.Items.Count);
            count = 0;


            sql = Utils.CREATE_SCHDULEDWORK;

            while (count < count2)
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
                catch (Exception)
                {
                    MessageBox.Show($"Something went wrong");
                }
                finally
                {
                    conn.Close();
                }
            }
        }//To do, it's a bit complicated so I couldn't move it to the PlaningManager class
    }
}
