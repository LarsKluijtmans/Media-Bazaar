using MediaBazaar.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class DepotManager : Form
    {
        int ID;
        Store store;
        private List<Product> productRequests;
        private List<Product> productRestock;

        public DepotManager(int UserID, Store s)
        {
            InitializeComponent();

            store = s;
            productRequests = new List<Product>();
            productRestock = new List<Product>();
            ID = UserID;

            cbProductType.Items.Add("KITCHEN_HOME");
            cbProductType.Items.Add("PHOTO_VIDEO_NAVIGATION");
            cbProductType.Items.Add("SMARTHOME_APPLIANCES");
            cbProductType.Items.Add("GAMING_MUSIC_COMPUTERS");

            ViewAllProducts();
            ViewAllReshelfRequests();
            ViewAllRestockRequests();
            ViewAllSchedule();
        }

        // products

        public void ViewAllProducts()
        {
            store.productManagment.ViewAllProducts();

            lbProducts.Items.Clear();

            foreach (Product product in store.productManagment.products)
            {
                lbProducts.Items.Add(product);
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
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

        //Restock

        public void ViewAllRestockRequests()
        {
            store.rectockManagment.ViewAllRestockRequests();

            lbRestock.Items.Clear();

            foreach (Restock restock in store.rectockManagment.restocks)
            {
                lbRestock.Items.Add(restock);
            }
        }

        public void DeleteRestockRequest()
        {
            store.rectockManagment.ViewAllRestockRequests();

            lbRestock.Items.Clear();

            string RestokID = tbRestockID.Text;
            if (string.IsNullOrEmpty(RestokID))
            {
                MessageBox.Show("'RestokID' field is required.");
                return;
            }

            store.rectockManagment.DeleteRestockRequest(RestokID);
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
        }

        private void btnDeleteRestockReuqest_Click(object sender, EventArgs e)
        {
            DeleteRestockRequest();
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

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteRestockRequest();
        }

        //ReShelf

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

            foreach (ReShelf reShelf in store.reshelfManagment.reShelves)
            {
                lbReshelfRequest.Items.Add(reShelf);
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

        //Planning

        public void ViewDepotPlaning()
        {
            store.planingManagment.ViewDepotPlaning();

            lbPlanning.Items.Clear();

            foreach (Planing planing in store.planingManagment.planings)
            {
                lbPlanning.Items.Add(planing);
            }


            lbEmployee.Items.Clear();

            foreach (BasicEmployeeInfo employee in store.planingManagment.employees)
            {
                lbEmployee.Items.Add(employee);
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
            if (lbPlanning.SelectedIndex < 0)
            {
                return;
            }

            Object planObject = lbPlanning.SelectedItem;
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

        private void btnEditPlaning_Click(object sender, EventArgs e)
        {
            string WorkID = tbWorkId.Text;
            if (string.IsNullOrEmpty(WorkID))
            {
                MessageBox.Show("'WorkID' field is required.");
                return;
            }

            string NewEmployeeId = tbNewEmployeeId.Text;
            if (string.IsNullOrEmpty(NewEmployeeId))
            {
                MessageBox.Show("'NewEmployeeId' field is required.");
                return;
            }

            string Department = tbDep.Text;
            if (string.IsNullOrEmpty(Department))
            {
                MessageBox.Show("'Department' field is required.");
                return;
            }

            string Day = tbDay.Text;
            if (string.IsNullOrEmpty(Day))
            {
                MessageBox.Show("'Day' field is required.");
                return;
            }

            string Time = tbTime.Text;
            if (string.IsNullOrEmpty(Time))
            {
                MessageBox.Show("'Time' field is required.");
                return;
            }

            store.planingManagment.EditPlaning(WorkID, NewEmployeeId, Department, Day, Time);

            ViewDepotPlaning();

            tbNewEmployeeId.Text = "";
            tbWorkId.Text = "";
            tbNewEmployeeId.Text = "";
            tbDep.Text = "";
            tbDay.Text = "";
            tbTime.Text = "";
            tbNewEmployeeId.BackColor = Color.LightGray;
        }

        private void btnDepotPlan_Click(object sender, EventArgs e)
        {
            ViewDepotPlaning();
        }


        //Other

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
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
                    cmd.Parameters.AddWithValue("@ID", 9.ToString());
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
                    cmd.Parameters.AddWithValue("@CheckOutTime", date.ToString("HH:mm:ss"));

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
    }
}
