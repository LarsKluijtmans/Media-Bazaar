using acr122_demo.Class;
using MySql.Data.MySqlClient;
using Sydesoft.NfcDevice;
using System;
using System.Windows.Forms;

namespace acr122_demo
{
    public partial class Form1 : Form
    {
        string last = "";
        DateTime date;
        private static MyACR122U acr122u = new MyACR122U();
        Atendance at;

        public static string GET_ALL_EMPLOYEES = "SELECT * FROM Employee ORDER BY EmployeeID;";

        public static string CONTRACT_BY_EMPLOYEEID = "SELECT * FROM Contract WHERE EmployeeID = @EmployeeID;";

        public Form1()
        {
            InitializeComponent();
            try
            {
                acr122u.Init(false, 50, 4, 4, 200);  // NTAG213
                acr122u.CardInserted += Acr122u_CardInserted;
                acr122u.CardRemoved += Acr122u_CardRemoved;
                timer1.Start();
                timer1.Interval = 100;
            }
            catch 
            {
                MessageBox.Show("Make sure to connect the card reader");
            }
            at = new Atendance();
            try
            {
                GetAtendanceIn();
                ViewAllEmployees();
            }
            catch 
            {
                Close();
            }
        }

        // Atendace
        public void GetAtendanceIn()
        {
            lbCheck.Items.Clear();
            at.getAllAtendanceOnCheckIn();
            foreach (Ckecks k in at.check)
            {
                lbCheck.Items.Add(k);
            }
        }

        // CardReader

        private void Acr122u_CardInserted(PCSC.ICardReader reader)
        {
            acr122u.ReadId = BitConverter.ToString(acr122u.GetUID(reader)).Replace("-", "");
        }

        private static void Acr122u_CardRemoved()
        { }

        // Timer

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (acr122u.ReadId != null && at.GetEmployeeID(acr122u.ReadId.ToString()) != 0)
            {
                if ((acr122u.ReadId != null && last != acr122u.ReadId) || (acr122u.ReadId != null && date.AddSeconds(5) < DateTime.Now))
                {
                    ViewAllEmployees();
                    if (at.IsAlreadyCheckedIn(at.GetEmployeeID(acr122u.ReadId.ToString())) == false)
                    {
                        at.AddCheckIn(at.GetEmployeeID(acr122u.ReadId.ToString()));

                        last = acr122u.ReadId;
                        date = DateTime.Now;
                        acr122u.ReadId = null;

                        GetAtendanceIn();

                        return;
                    }
                    else if (at.IsAlreadyCheckedIn(at.GetEmployeeID(acr122u.ReadId.ToString())) == true)
                    {
                        at.EditCheckOutTime(at.GetEmployeeID(acr122u.ReadId.ToString()));

                        last = acr122u.ReadId;
                        date = DateTime.Now;
                        acr122u.ReadId = null;

                        GetAtendanceIn();

                        return;
                    }
                }
            }
             else if (acr122u.ReadId != null)
            {
                tbCardNumber.Text = acr122u.ReadId.ToString();
                acr122u.ReadId = null;
            }
        }

        // Conect card and employee

        public void ViewAllEmployees()
        {
            lbEmployee.Items.Clear();

            MySqlConnection conn = Connection.GetConnection();

            string sql = GET_ALL_EMPLOYEES;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Person employee;

                while (reader.Read())
                {
                    if (reader.GetInt32("Active") == 1)
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
                        string dateOfBirth = reader.GetString("DateOfBirth");

                        Contract c = GetContract(employeeID.ToString());
                        employee = new ManagerDepot(employeeID, firstName, lastName, phoneNumber, email, city, dateOfBirth, bsn, username, password);

                        if (rbnAllEmployees.Checked)
                        {
                            lbEmployee.Items.Add(employee);
                        }
                        else if (rbnAllEmployees.Checked)
                        {
                            if (c.JobTitle == "DEPOT EMPLOYEE" || c.JobTitle == "DEPOT MANAGER")
                            {
                                lbEmployee.Items.Add(employee);
                            }
                        }
                        else if (rbnOfficeEmployees.Checked)
                        {
                            if (c.JobTitle == "OFFICE MANAGER")
                            {
                                lbEmployee.Items.Add(employee);
                            }
                        }
                        else if (rbnSalesEmployees.Checked)
                        {
                            if (c.JobTitle == "SALES REPRESENTATIVE" || c.JobTitle == "SALES MANAGER")
                            {
                                lbEmployee.Items.Add(employee);

                            }
                        }
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
        }

        private void lbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Person tempPerson = getperson();

                tbEmployeeID.Text = tempPerson.EmployeeID.ToString();
                tbEmployeeName.Text = tempPerson.LastName + " " + tempPerson.FirstName;
            }
            catch { }
        }

        public Person getperson()
        {
            Object personObj = lbEmployee.SelectedItem;
            if (!(personObj is Person))
            {
                MessageBox.Show("Error");
            }

            Person tempPerson = (Person)personObj;

            return tempPerson;
        }

        //Contract

        public Contract GetContract(string employeeID)
        {
            MySqlConnection conn = Connection.GetConnection();
            string sql = CONTRACT_BY_EMPLOYEEID;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Contract c;

                while (reader.Read())
                {
                    string jobTitle = reader.GetString("JobTitle");
                    int workHours = reader.GetInt32("WorkHoursPerWeek");
                    int salary = reader.GetInt32("SalaryPerHour");
                    string startDate = reader.GetString("StartDate");

                    c = new Contract(Convert.ToInt32(employeeID), jobTitle, workHours, salary, startDate);

                    return c;
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

            return null;
        }

        private void btnConnectCardAndEmployee_Click(object sender, EventArgs e)
        {
            string ID = tbEmployeeID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show(" 'Select a employee' field is required.");
                return;
            }

            string Head = tbCardNumber.Text;
            if (string.IsNullOrEmpty(Head))
            {
                MessageBox.Show("Put a card that is not already in use against the card reader.");
                return;
            }

            Employee emp = new Employee();
            emp.changeID(tbEmployeeID.Text.ToString(), tbCardNumber.Text.ToString());

            tbEmployeeID.Text = "";
            tbEmployeeName.Text = "";
            tbCardNumber.Text = "";
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
