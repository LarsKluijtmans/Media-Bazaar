using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClassLibraryProject.Class;
using ClassLibraryProject;

namespace MediaBazaar
{
    public partial class SalesRepresentative : Form
    {
        int id;
        Store store;
        public SalesRepresentative(int UserID, Store s)
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

        //Product

        public void ViewAllProducts()
        {
            store.productManagment.ViewAllProducts();

            lstProduct.Items.Clear();
            lstOverviewProduct.Items.Clear();

            foreach (Product product in store.productManagment.products)
            {
                lstProduct.Items.Add(product);
                lstOverviewProduct.Items.Add(product);
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

           store.reshelfManagment.RequestReshelf( ID, Amount);
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
            SelectPreferedWorkTime();
        }
        public PreferedWorkTime SelectPreferedWorkTime()
        {
            string day = cbxPreferedDay.SelectedItem.ToString();
            string time;

            if (rbnMorningPrefered.Checked)
            {
                time = "Morning";
            }
            else if (rbnAfternoonPrefered.Checked)
            {
                time = "Afternoon";
            }
            else if (rbnEveningPrefered.Checked)
            {
                time = "Evening";
            }
            else
            {
                time = "";
            }

            PreferedWorkTime pwt = new PreferedWorkTime(id, time, day);

            return pwt;
        }
    }
}
