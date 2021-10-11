using MediaBazaar.Class;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MediaBazaar
{
    public partial class FormLogin : Form
    {
        Store store = new Store();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.LOGIN_BY_EMPLOYEEID;
            try
            {
                string ID = tbxUsername.Text;
                if (string.IsNullOrEmpty(ID))
                {
                    MessageBox.Show("'id' field is required.");
                    return;
                }
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@employeeid", ID);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (Convert.ToInt32(reader[0]) == Convert.ToInt32(tbxUsername.Text))
                    {
                        if (reader[1].ToString() == tbxPassword.Text)
                        {
                           int Userid = Convert.ToInt32(reader[0]);

                            switch (reader[2].ToString())
                            {
                                case "OWNER": Form1 form1 = new Form1(Userid, store); form1.Show();break;
                                case "SALES MANAGER": FormSalesManager formSalesManager = new FormSalesManager(Userid, store); formSalesManager.Show(); break;
                                case "SALES EMPLOYEE": FormSalesEmployee formSalesEmployee = new FormSalesEmployee(Userid, store); formSalesEmployee.Show(); break;
                                case "OFFICE MANAGER": FormOfficeManager formOfficeManager = new FormOfficeManager(Userid, store); formOfficeManager.Show(); break;
                                case "OFFICE EMPLOYEE": FormOfficeEmployee formOfficeEmployee = new FormOfficeEmployee(Userid, store); formOfficeEmployee.Show(); break;
                                case "DEPOT MANAGER": FormDepotManager formDepotManager = new FormDepotManager(Userid, store); formDepotManager.Show(); break;
                                case "DEPOT EMPLOYEE": FormDepotEmployee formDepotEmployee = new FormDepotEmployee(Userid, store); formDepotEmployee.Show(); break;
                            }
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Make sure t put in the right password.");
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Make sure t put in the right ID number.");
                        break;
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
    }
}
