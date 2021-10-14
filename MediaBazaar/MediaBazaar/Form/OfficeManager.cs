using MediaBazaar.Class;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class OfficeManager : Form
    {
        int ID;
        Store store;
        public OfficeManager(int UserID, Store s)
        {
            InitializeComponent();
            ID = UserID;
            store = s;
            cbHeadDepartments.Text = "Sales";
            cbHeadDepartments.Items.Add("Sales");
            cbHeadDepartments.Items.Add("Depot");
            cbHeadDepartments.Items.Add("Office");
            cbHeadDepartments.Items.Add("Other");

            ViewAllEmployees();
            ViewAllDepartments();
            ViewCompany();
        }
        // employees
        private void lbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person tempPerson = GetTempEmployee();

            tbxEmployeeID.Text = tempPerson.EmployeeID.ToString();
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            FormNewEmployee formNewEmployee = new FormNewEmployee();
            formNewEmployee.Show();
        }
        private void btnReadEmployee_Click(object sender, EventArgs e)
        {
            ViewAllEmployees();
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
        public Contract GetTempContract(Person p)
        {
            int employeeID = p.EmployeeID;

            MySqlConnection conn = Utils.GetConnection();

            string sql = ContractManagement.CONTRACT_BY_EMPLOYEEID;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Contract c;

                while (reader.Read())
                {
                    if ( reader.GetInt32("EmployeeID") == employeeID)
                    {
                        int contractID = reader.GetInt32("ContractID");
                        string jobTitle = reader.GetString("JodTitle");
                        int workHoursPerWeek = reader.GetInt32("WorkHoursPerWeek");
                        int salaryPerHour = reader.GetInt32("SalaryPerHour");
                        string startDate = reader.GetString("StartDate");

                        c = new Contract(employeeID, jobTitle, workHoursPerWeek, salaryPerHour, startDate);

                        return c;
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

            return null;
        }
        public void ViewAllEmployees()
        {
            lbxEmployees.Items.Clear();

            MySqlConnection conn = Utils.GetConnection();

            string sql = EmployeeManagement.GET_ALL_EMPLOYEES;

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

                        employee = new ManagerDepot(employeeID, firstName, lastName, phoneNumber, email, city, dateOfBirth, bsn, username, password);
                        lbxEmployees.Items.Add(employee);
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

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            ViewEmployeeDetails();
        }
        private void lbxEmployees_DoubleClick(object sender, EventArgs e)
        {
            ViewEmployeeDetails();
        }
        public void ViewEmployeeDetails()
        {
            Person employee = GetTempEmployee();
            Contract contract = GetTempContract(employee);


            FormViewEmployee formViewEmployee = new FormViewEmployee(employee, contract);
            formViewEmployee.Show();
        }
        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            Person employee = GetTempEmployee();
            FormRemoveEmployee formRemoveEmployee = new FormRemoveEmployee(employee);
            formRemoveEmployee.Show();

            string employeeID = tbxEmployeeID.Text;
            string active = "0";

            MySqlConnection conn = Utils.GetConnection();
            string sql = "Utils.REMOVE_EMPLOYEE_BY_ID";

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
                MessageBox.Show("Something went wrong" + ex);
            }
            finally
            {
                conn.Close();
            }
            ViewAllEmployees();
        }


        //Login

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Departments
        public void ViewAllDepartments()
        {
            store.departmentManagment.ViewAllDepartments();

            dgvDepartments.DataSource = store.departmentManagment.ViewAllDepartments();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ViewAllDepartments();
            ViewAllEmployees();
        }

        //Selected index

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            string Name = tbDepartmentName.Text;
            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("'Department name' field is required.");
                return;
            }

            string Head = cbHeadDepartments.Text;
            if (string.IsNullOrEmpty(Head))
            {
                MessageBox.Show("'Head Department' field is required.");
                return;
            }

            string CompanyID = tbID.Text;
            if (string.IsNullOrEmpty(CompanyID))
            {
                MessageBox.Show("Error please restart the aplication");
                return;
            }

            store.departmentManagment.AddDepartment(Name, Head, CompanyID);
        }//Refrech datagridView

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            string Name = tbDepartmentName.Text;
            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("'Department name' field is required.");
                return;
            }

            string Head = cbHeadDepartments.Text;
            if (string.IsNullOrEmpty(Head))
            {
                MessageBox.Show("'Head Department' field is required.");
                return;
            }

            string DepartmentID = labDepartmentID.Text;
            if (string.IsNullOrEmpty(DepartmentID))
            {
                MessageBox.Show("Make sure to select a department you want to edit");
                return;
            }

            if (Convert.ToInt32(DepartmentID) == 1 || Convert.ToInt32(DepartmentID) == 2 || Convert.ToInt32(DepartmentID) == 3 || Convert.ToInt32(DepartmentID) == 4) 
            {
                MessageBox.Show("You can't edit the head Departments");
                return;
            }

            store.departmentManagment.EditDepartment(Name, Head, DepartmentID.ToString());
        }


        //Company

        private void ViewCompany()
        {
            store.companyManagment.GetCompany(ID);

            tbCompanyName.Text = store.companyManagment.company.CompanyName;
            tbAdress.Text = store.companyManagment.company.Address;
            tbBTW.Text = store.companyManagment.company.Btw;
            tbEmail.Text = store.companyManagment.company.Email;
            tbPhoneNumber.Text = store.companyManagment.company.PhoneNumber;
            tbKVK.Text = store.companyManagment.company.KVK;
            tbID.Text = store.companyManagment.company.CompanyID;
        }

        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            string ID = tbID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("'ID' field is required.");
                return;
            }

            string Name = tbCompanyName.Text;
            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("'name' field is required.");
                return;
            }

            string Adress = tbAdress.Text;
            if (string.IsNullOrEmpty(Adress))
            {
                MessageBox.Show("'Adress' field is required.");
                return;
            }

            string BTW = tbBTW.Text;
            if (string.IsNullOrEmpty(BTW))
            {
                MessageBox.Show("'BTW number' field is required.");
                return;
            }

            string Email = tbEmail.Text;
            if (string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("'Email' field is required.");
                return;
            }

            string PhoneNumber = tbPhoneNumber.Text;
            if (string.IsNullOrEmpty(PhoneNumber))
            {
                MessageBox.Show("'PhoneNumber' field is required.");
                return;
            }

            string KVK = tbKVK.Text;
            if (string.IsNullOrEmpty(KVK))
            {
                MessageBox.Show("'KVK number' field is required.");
                return;
            }

            store.companyManagment.EditCompany(Name, Adress, PhoneNumber, Email, BTW, KVK, ID);
        }

        private void Comapny_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // employee
        

        private void OfficeManager_Load(object sender, EventArgs e)
        {

        }
    }
}
