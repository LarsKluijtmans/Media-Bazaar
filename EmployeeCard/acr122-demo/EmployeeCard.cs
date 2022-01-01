using acr122_demo;
using acr122_demo.Class;
using MySql.Data.MySqlClient;
using Sydesoft.NfcDevice;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace CardReader
{
    public partial class EmployeeCard : Form
    {
        private static MyACR122U acr122u;

        public EmployeeCard()
        {
            InitializeComponent();
            acr122u = new MyACR122U();

            try
            {
                acr122u.Init(false, 50, 4, 4, 200);  // NTAG213
                acr122u.CardInserted += Acr122u_CardInserted;
                acr122u.CardRemoved += Acr122u_CardRemoved;
            }
            catch
            {
                MessageBox.Show("Make sure to connect the card reader");
            }

            ViewAllEmployees(tbSearch.Text);

            timer1.Start();
        }

        //Close page
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }

        // CardReader
        private void Acr122u_CardInserted(PCSC.ICardReader reader)
        {
            acr122u.ReadId = BitConverter.ToString(acr122u.GetUID(reader)).Replace("-", "");
        }
        private static void Acr122u_CardRemoved()
        { }

        //Update cart number
        private void btnConnectCardAndEmployee_Click(object sender, EventArgs e)
        {
            string ID = tbEmployeeID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show(" 'Select a employee' field is required.");
                return;
            }

            string CardNumber = tbCardNumber.Text;
            if (string.IsNullOrEmpty(CardNumber))
            {
                MessageBox.Show("Put a card that is not already in use against the card reader.");
                return;
            }

            DBPersonManager emp = new DBPersonManager();
            emp.changeID(ID, CardNumber);

            tbEmployeeID.Text = "";
            tbEmployeeName.Text = "";
            tbCardNumber.Text = "";
            tbPhoneNumber.Text = "";
            tbEmail.Text = "";
            tbAddress.Text = "";
            tbDateOfBirth.Text = "";
            tbBSN.Text = "";

            ViewAllEmployees(tbSearch.Text);
        }

        //Select employee
        private void lbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEmployee.SelectedItem is Person)
            {
                try
                {
                    Person Person = (Person)lbEmployee.SelectedItem;

                    tbEmployeeID.Text = Person.EmployeeID.ToString();
                    tbEmployeeName.Text = Person.LastName + " " + Person.FirstName;
                    tbCardNumber.Text = Person.CardNumber.ToString();
                    tbPhoneNumber.Text = Person.PhoneNumber.ToString();
                    tbEmail.Text = Person.Email;
                    tbAddress.Text = Person.City.ToString();
                    tbDateOfBirth.Text = Person.DateOfBirth.ToString();
                    tbBSN.Text = Person.BSN.ToString();
                }
                catch { MessageBox.Show("Error!"); }
            }
        }

        //timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (acr122u.ReadId != null && GetEmployeeID(acr122u.ReadId.ToString()) != 0)
            {
                ViewAllEmployees(tbSearch.Text);
                acr122u.ReadId = null;
            }
            else if (acr122u.ReadId != null)
            {
                tbCardNumber.Text = acr122u.ReadId.ToString();
                acr122u.ReadId = null;
            }
        }


        //View employees
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ViewAllEmployees(tbSearch.Text);
        }
        public void ViewAllEmployees(string search)
        {
            lbEmployee.Items.Clear();

            MySqlConnection conn = Connection.GetConnection();

            string sql = $"SELECT * FROM Employee INNER JOIN contract on contract.EmployeeID = Employee.EmployeeID where Active = 1 AND FirstName LIKE '{search}%' OR Active = 1 AND LastName LIKE '{search}%' ORDER BY Employee.EmployeeID;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Person employee;

                while (reader.Read())
                {
                    employee = new Person(
                        reader.GetInt32("EmployeeID"),
                        reader.GetString("FirstName"),
                        reader.GetString("LastName"),
                        reader.GetInt32("PhoneNumber"),
                        reader.GetString("Email"),
                        reader.GetString("Address"),
                        reader.GetString("DateOfBirth"),
                        reader.GetInt32("BSN"),
                        reader.GetString("UserName"),
                        reader.GetString("Password"),
                        reader.GetString("CardNumber"));

                    if (reader.GetString("CardNumber") != null)
                    {
                        employee.CardNumber = reader.GetString("CardNumber");
                    }

                    lbEmployee.Items.Add(employee);
                }
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        //Get employee by ID
        public int GetEmployeeID(string CardNumber)
        {
            MySqlConnection conn = Connection.GetConnection();

            string sql = "SELECT `EmployeeID` FROM `employee` WHERE `CardNumber`= @CardNumber;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@CardNumber", CardNumber);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return Convert.ToInt32(reader[0]);
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
            return 0;
        }

    }

    internal class MyACR122U : ACR122U
    {
        private string readId;
        public string ReadId
        {
            get { return readId; }
            set { readId = value; }
        }
        public MyACR122U()
        { }
    }
}
