using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MediaBazaar.Class;
using MySql.Data.MySqlClient;

namespace MediaBazaar
{
    public partial class FormSalesEmployee : Form
    {
        int ID;
        Store store;
        public FormSalesEmployee(int UserID, Store s)
        {
            InitializeComponent();
            int ID = UserID;
            store = s;
            ViewAllProducts();
        }
       

        private void btnLogout_Click(object sender, EventArgs e)
        {
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
                    cmd.Parameters.AddWithValue("@ID", 9.ToString());
                    cmd.Parameters.AddWithValue("@CheckInTime", date.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@CheckOutTime", null);
                    cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                    conn.Open();
                    int n = cmd.ExecuteNonQuery();
                    MessageBox.Show(n.ToString());
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
                    MessageBox.Show(n.ToString());
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

        public void ViewAllProducts()
        {
            lstProduct.Items.Clear();

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

                    lstProduct.Items.Add(product);
                    lstOverviewProduct.Items.Add(product);
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

        private void btnViewPorducts_Click(object sender, EventArgs e)
        {
            ViewAllProducts();
        }

        private void btnRequestReplenishment_Click(object sender, EventArgs e)
        {

            string ID = tbID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("'ID' field is required.");
                return;
            }

            string Amount = tbAmount.Text;
            if (string.IsNullOrEmpty(Amount))
            {
                MessageBox.Show("'Amount' field is required.");
                return;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.CREATE_SHELFREPLENICHMENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", ID);
                cmd.Parameters.AddWithValue("@Amount", Amount);


                conn.Open();
                int numCreatedRows = cmd.ExecuteNonQuery();
                MessageBox.Show("Request was succesfull");
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

        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProduct.SelectedIndex < 0)
            {
                return;
            }

            Object ProductObject = lstProduct.SelectedItem;
            if (!(ProductObject is Product))
            {
                return;
            }

            Product product = (Product)ProductObject;
            tbID.Text = product.ProductID.ToString();
            tbName.Text = product.Name;
            tbBarcode.Text = product.Barcode;
            lbProductType.Text = product.ProductType;
            tbmountInStore.Text = product.AmountInStore.ToString();
            tbAmountInDepot.Text = product.AmountInDepot.ToString();
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
    }
}
