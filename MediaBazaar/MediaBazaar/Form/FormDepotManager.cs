﻿using MediaBazaar.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormDepotManager : Form
    {
        int ID;
        Store mediaBazaar;
        private List<Product> productRequests;
        private List<Product> productRestock;

        public FormDepotManager(int UserID, Store mb)
        {
            InitializeComponent();
            productRequests = new List<Product>();
            productRestock = new List<Product>();
            this.mediaBazaar = mb;
            ID = UserID;

            cbProductType.Items.Add("KITCHEN_HOME");
            cbProductType.Items.Add("PHOTO_VIDEO_NAVIGATION");
            cbProductType.Items.Add("SMARTHOME_APPLIANCES");
            cbProductType.Items.Add("GAMING_MUSIC_COMPUTERS");

            UpdateListbox();
        }


        public void AddRequesteProduct(int amount, int productid)
        {
            foreach (Product p in mediaBazaar.Products)
            {
                if (p.ProductID == productid)
                {
                    // Product prod = new Product(p.Barcode, p.Name, p.ProductType, amount);
                    /*add p to listbox*/
                }
            }
        }
        // employees
        public void UpdateListbox()
        {
            lbxEmployees.Items.Clear();
            foreach (Employee e in mediaBazaar.Employees)
            {
                if (rbnAllEmployees.Checked)
                {
                    lbxEmployees.Items.Add(e);
                }
                else if (rbnDepotEmployees.Checked)
                {
                    if (e.Type == JobTitle.DEPOT_EMPLOYEE || e.Type == JobTitle.DEPOT_MANAGER)
                    {
                        lbxEmployees.Items.Add(e);
                    }
                }
            }
        }

        private void btnCreateNewEmployee_Click(object sender, EventArgs e)
        {
            FormNewEmployee formNewEmployee = new FormNewEmployee();
            formNewEmployee.Show();
        }

        private void btnReadEmployees_Click(object sender, EventArgs e)
        {
            ViewAllEmployees();
        }

        private void btnUpdateEmployees_Click(object sender, EventArgs e)
        {
            Person employee = GetTempEmployee();

            FormViewEmployee formViewEmployee = new FormViewEmployee(employee);
            formViewEmployee.Show();
        }

        private void btnDeleteEmployees_Click(object sender, EventArgs e)
        {
            Person employee = GetTempEmployee();
            FormRemoveEmployee formRemoveEmployee = new FormRemoveEmployee(employee);
            formRemoveEmployee.Show();

            string employeeID = tbxEmployeeID.Text;
            string active = "0";

            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.REMOVE_EMPLOYEE_BY_ID;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@Active", active);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();
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

        private void lbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person tempPerson = GetTempEmployee();

            tbxEmployeeID.Text = tempPerson.ID.ToString();
        }
        private Person GetTempEmployee()
        {
            Object personObj = lbxEmployees.SelectedItem;

            if (!(personObj is Person))
            {
                MessageBox.Show("Error");
            }

            Person tempPerson = (Person)personObj;

            return tempPerson;
        }

        public void ViewAllEmployees()
        {
            lbxEmployees.Items.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = Utils.GET_ALL_EMPLOYEES;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Person employee;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32("EmployeeID");
                    string firstName = reader.GetString("FirstName");
                    string lastName = reader.GetString("LastName");
                    string username = reader.GetString("UserName");
                    string password = reader.GetString("Password");
                    int bsn = reader.GetInt32("BSN");
                    string city = reader.GetString("Address");
                    string email = reader.GetString("Email");
                    int phoneNumber = reader.GetInt32("PhoneNumber");
                    string dateOfBirth = "01-01-1998";

                    employee = new ManagerDepot(employeeID, firstName, lastName, phoneNumber, email, city, dateOfBirth, bsn, username, password);
                    lbxEmployees.Items.Add(employee);

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


        // products

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
        }//error

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

        //Schedule

        public void ViewAllSchedule()
        {
            lbSchedule.Items.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = Utils.GET_SCHEDULE_DEPOT;

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

        // shedule

        public void ViewDepotSchedule()
        {
            lbDepotSchedule.Items.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = Utils.GET_SCHEDULE_DEPOT;

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

                    lbDepotSchedule.Items.Add(schedule);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDepotSchedule.SelectedIndex < 0)
            {
                return;
            }

            Object scheduleObject = lbDepotSchedule.SelectedItem;
            if (!(scheduleObject is Schedule))
            {
                return;
            }

            Schedule schedule = (Schedule)scheduleObject;

            tbDepotSheduleID.Text = schedule.ID.ToString();
            tbDepotSheduleDepartment.Text = schedule.Department.ToString();
            tbDepotSheduleDay.Text = schedule.Day;
            tbDepotSheduleMorning.Text = schedule.MorningAmount.ToString();
            tbDepotSheduleAfternoon.Text = schedule.AfternoonAmount.ToString();
            tbDepotSheduleEvening.Text = schedule.EveningAmount.ToString();
        }

        private void btnEditDepotSchedule_Click(object sender, EventArgs e)
        {
            string Morning = tbDepotSheduleMorning.Text;
            if (string.IsNullOrEmpty(Morning))
            {
                lbDepotSchedule.Items.Add("'Morning' field is required.");
                return;
            }

            string Afternoon = tbDepotSheduleAfternoon.Text;
            if (string.IsNullOrEmpty(Afternoon))
            {
                lbDepotSchedule.Items.Add("'Afternoon' field is required.");
                return;
            }

            string Evening = tbDepotSheduleEvening.Text;
            if (string.IsNullOrEmpty(Evening))
            {
                lbDepotSchedule.Items.Add("'Evening' field is required.");
                return;
            }
            string ID = tbDepotSheduleID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                lbDepotSchedule.Items.Add("Please select a time");
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

                ViewDepotSchedule();
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

        private void btnViewDepotSchedule_Click(object sender, EventArgs e)
        {
            ViewDepotSchedule();
        }

        //Planing

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

                    ViewDepotPlaning();
 
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

        private void btnDepotPlan_Click(object sender, EventArgs e)
        {
            ViewDepotPlaning();
        }
    }
}
