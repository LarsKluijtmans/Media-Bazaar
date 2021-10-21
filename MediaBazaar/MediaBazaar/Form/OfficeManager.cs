using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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

            labYear.Text = DateTime.Now.Year.ToString();

            labMonth.Text = DateTime.Now.Month.ToString();

            timer1.Start();
            timer2.Start();

            ViewCompany();
            ViewAllEmployees();
            GetAtendeance();
            ViewAllDepartments();
        }

        //Login

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
        }


        //Timer

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ActiveControl == tbxSearchEmployee)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            ViewAllEmployees();
            ViewAllDepartments();
            GetAtendeance();
        }

        //Atendance
        private void btnDecreaseYear_Click(object sender, EventArgs e)
        {
          int year = Convert.ToInt16(labYear.Text);

            year--;
            labYear.Text = year.ToString();
        }

        private void btnIncreaseYear_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt16(labYear.Text);

            year++;
            labYear.Text = year.ToString();
        }

        private void btnMonthDecrease_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt16(labMonth.Text);

            if (month == 1)
            {
                month = 12;
                labMonth.Text = month.ToString();
            }
            else
            {
                month--;
                labMonth.Text = month.ToString();
            }
        }

        private void btnMonthIncrease_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt16(labMonth.Text);

            if (month == 12)
            {
                month = 1;
                labMonth.Text = month.ToString();
            }
            else
            {
                month++;
                labMonth.Text = month.ToString();
            }
        }

        private void btnMakeExcelSheet_Click_1(object sender, EventArgs e)
        {
            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;


            //Start Excel and get Application object.
            oXL = new Excel.Application();
            oXL.Visible = true;

            //Get a new workbook.
            oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
            oSheet = (Excel._Worksheet)oWB.ActiveSheet;

            //Add table headers going cell by cell.
            oSheet.Cells[1, 1] = " EmployeeID ";
            oSheet.Cells[1, 2] = " Name ";
            oSheet.Cells[1, 3] = " Hours worked ";
            oSheet.Cells[1, 4] = " Work hours per week ";
            oSheet.Cells[1, 5] = " Salary per hour ";
            oSheet.Cells[1, 6] = " Job ";

            //Format A1:D1 as bold, vertical alignment = center.

            oSheet.get_Range("A1", "F1").Font.Bold = true;
            oSheet.get_Range("A1", "F1").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            //AutoFit columns A:D.
            oRng = oSheet.get_Range("A1", "F1");
            oRng.EntireColumn.AutoFit();

            int i = 2;
            foreach (TimeWorked c in store.checkinManagment.times)
            {
                oSheet.Cells[i, 1] = c.EmployeeID.ToString();
                oSheet.Cells[i, 2] = c.Name.ToString(); ;
                oSheet.Cells[i, 3] = c.TimeWork.ToString();
                oSheet.Cells[i, 4] = c.WorkHoursPerWeek.ToString(); ;
                oSheet.Cells[i, 5] = c.SalaryPerHour.ToString();
                oSheet.Cells[i, 6] = c.JobTitle.ToString(); ;

                //AutoFit columns A:F.
                oRng = oSheet.get_Range("A" + i, "F" + i);
                oRng.EntireColumn.AutoFit();

                i++;
            }
        }

        public void GetAtendeance()
        {
            string year, month;

            year = labYear.Text;
            month = labMonth.Text;


            store.checkinManagment.getAllAtendanceTime(year, month);
            lbAttendance.Items.Clear();

            foreach (TimeWorked c in store.checkinManagment.times)
            {
                    lbAttendance.Items.Add(c);
            }
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
        public void ViewAllEmployees()
        {
            lbxEmployees.Items.Clear();
            //lbEmployee.Items.Clear();

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

                        Contract c = GetContract(employeeID.ToString());
                        employee = new ManagerDepot(employeeID, firstName, lastName, phoneNumber, email, city, dateOfBirth, bsn, username, password);

                        if (rbnAllEmployees.Checked)
                        {
                            lbxEmployees.Items.Add(employee);
                        }
                        else if (rbnDepotEmployees.Checked)
                        {
                            if (c.JobTitle == "DEPOT EMPLOYEE" || c.JobTitle == "DEPOT MANAGER")
                            {
                                lbxEmployees.Items.Add(employee);
                            }
                        }
                        else if (rbnOfficeEmployees.Checked)
                        {
                            if (c.JobTitle == "OFFICE MANAGER")
                            {
                                lbxEmployees.Items.Add(employee);
                            }
                        }
                        else if (rbnSalesEmployees.Checked)
                        {
                            if (c.JobTitle == "SALES REPRESENTATIVE" || c.JobTitle == "SALES MANAGER")
                            {
                                lbxEmployees.Items.Add(employee);

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
            Contract contract = GetContract(employee.EmployeeID.ToString());

            FormViewEmployee formViewEmployee = new FormViewEmployee(employee, contract);
            formViewEmployee.Show();
        }
        // get contract
        public Contract GetContract(string employeeID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = ContractManagement.CONTRACT_BY_EMPLOYEEID;

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

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            Person employee = GetTempEmployee();
            Contract contract = GetContract(employee.EmployeeID.ToString());
            FormRemoveEmployee formRemoveEmployee = new FormRemoveEmployee(employee, contract);
            formRemoveEmployee.Show();

            string employeeID = tbxEmployeeID.Text;
            string active = "0";

            MySqlConnection conn = Utils.GetConnection();
            string sql = EmployeeManagement.REMOVE_EMPLOYEE_BY_ID;

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
        // view employees
        private void rbnAllEmployees_CheckedChanged(object sender, EventArgs e)
        {
            ViewAllEmployees();
        }

        private void rbnOfficeEmployees_CheckedChanged(object sender, EventArgs e)
        {
            ViewAllEmployees();
        }

        private void rbnSalesEmployees_CheckedChanged(object sender, EventArgs e)
        {
            ViewAllEmployees();
        }

        private void rbnDepotEmployees_CheckedChanged(object sender, EventArgs e)
        {
            ViewAllEmployees();
        }

        //Departments
        public void ViewAllDepartments()
        {
            store.departmentManagment.ViewAllDepartments();

            dgvDepartments.DataSource = store.departmentManagment.ViewAllDepartments();
        }

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
        } 

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

        private void dgvDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDepartments.Rows[e.RowIndex];
                labDepartmentID.Text = row.Cells["departmentID"].Value.ToString();
                tbDepartmentName.Text = row.Cells["DepartmentName"].Value.ToString();
                cbHeadDepartments.Text = row.Cells["HeadDepatment"].Value.ToString();
            }
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


        //Connect card to employee

        private void lbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person tempPerson = getperson();

            tbxEmployeeID.Text = tempPerson.EmployeeID.ToString();
        }

        public Person getperson()
        {
            Object personObj = lbxEmployees.SelectedItem;
            if (!(personObj is Person))
            {
                MessageBox.Show("Error");
            }

            Person tempPerson = (Person)personObj;

            return tempPerson;
        }

        private void tbxSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            string nameSearched = tbxSearchEmployee.Text;

            if (!String.IsNullOrEmpty(nameSearched))
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

                            Contract c = GetContract(employeeID.ToString());
                            employee = new ManagerDepot(employeeID, firstName, lastName, phoneNumber, email, city, dateOfBirth, bsn, username, password);

                            if (employee.FirstName.StartsWith(nameSearched) || employee.FirstName.StartsWith(nameSearched.ToUpper()))
                            {
                                lbxEmployees.Items.Add(employee);
                            }
                            else if (employee.LastName.StartsWith(nameSearched) || employee.LastName.StartsWith(nameSearched.ToUpper()))
                            {
                                lbxEmployees.Items.Add(employee);
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
            else if (tbxSearchEmployee.Text == "")
            {
                ViewAllEmployees();
            }
        }

        private void btnMakeExcelSheet_Click(object sender, EventArgs e)
        {}
    }
}
