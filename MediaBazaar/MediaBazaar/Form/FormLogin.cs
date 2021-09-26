using MediaBazaar.Class;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MediaBazaar
{
    public partial class FormLogin : Form
    {
        Store mb;

        public FormLogin()
        {
            InitializeComponent();
            mb = new Store(); 
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
                                case "OWNER": Form1 form1 = new Form1(Userid, mb); form1.Show(); break;
                                case "SALES_MANAGER": FormSalesManager formSalesManager = new FormSalesManager(Userid, mb); formSalesManager.Show(); break;
                                case "SALES_EMPLOYEE": FormSalesEmployee formSalesEmployee = new FormSalesEmployee(Userid, mb); formSalesEmployee.Show(); break;
                                case "OFFICE_MANAGER": FormOfficeManager formOfficeManager = new FormOfficeManager(Userid, mb); formOfficeManager.Show(); break;
                                case "OFFICE_EMPLOYE": FormOfficeEmployee formOfficeEmployee = new FormOfficeEmployee(Userid, mb); formOfficeEmployee.Show(); break;
                                case "DEPOT_MANAGER": FormDepotManager formDepotManager = new FormDepotManager(Userid, mb); formDepotManager.Show(); break;
                                case "DEPOT_EMPLOYEE": FormDepotEmployee formDepotEmployee = new FormDepotEmployee(Userid, mb); formDepotEmployee.Show(); break;
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
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                conn.Close();
            }






























            //string username = tbxUsername.Text;
            //string password = tbxPassword.Text;

            //FormSalesManager formSalesManager = new FormSalesManager(employee, mediaBazaar);
            //formSalesManager.Show();

            //foreach (Employee eee in mediaBazaar.Employees)
            //{
            //    if (eee.Username == username && eee.Password == password)
            //    {
            //            switch (eee.Type.ToString())
            //            {
            //                case "OWNER": Form1 form1 = new Form1(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); form1.Show(); break;
            //                case "SALES_MANAGER": FormSalesManager formSalesManager = new FormSalesManager(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); formSalesManager.Show(); break;
            //                case "SALES_EMPLOYEE": FormSalesEmployee formSalesEmployee = new FormSalesEmployee(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); formSalesEmployee.Show(); break;
            //                case "OFFICE_MANAGER": FormOfficeManager formOfficeManager = new FormOfficeManager(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); formOfficeManager.Show(); break;
            //                case "OFFICE_EMPLOYE": FormOfficeEmployee formOfficeEmployee = new FormOfficeEmployee(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); formOfficeEmployee.Show(); break;
            //                case "DEPOT_MANAGER": FormDepotManager formDepotManager = new FormDepotManager(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); formDepotManager.Show(); break;
            //                case "DEPOT_EMPLOYEE": FormDepotEmployee formDepotEmployee = new FormDepotEmployee(mediaBazaar.GetEmployee(eee.EmployeeID), mediaBazaar); formDepotEmployee.Show(); break;
            //            }
            //    } else
            //    {
            //        MessageBox.Show("Wrong username/password");
            //    }
            //}
        }
    }
}
