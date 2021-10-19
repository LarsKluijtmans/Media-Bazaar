using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class ProductManager : Form
    {
        int id;
        Store store;

        public ProductManager(int UserID, Store s)
        {
            InitializeComponent();
            id = UserID;
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
                    cmd.Parameters.AddWithValue("@ID", id.ToString());
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
                    cmd.Parameters.AddWithValue("@ID", id.ToString());
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGet_Click(object sender, EventArgs e)
        {

        }
    }
}
