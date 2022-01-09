using ClassLibraryProject;
using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace AdminBackups
{
    public partial class FormOfficeManager : Form
    {
        OfficeManager officeManager;
        Store store;

        public FormOfficeManager(OfficeManager officeManager, Store store)
        {
            InitializeComponent();

            this.officeManager = officeManager;
            this.store = store;

            cbHeadDepartments.Text = "Sales";
            cbHeadDepartments.Items.Add("Sales");
            cbHeadDepartments.Items.Add("Depot");
            cbHeadDepartments.Items.Add("Office");
            cbHeadDepartments.Items.Add("Other");

            labYear.Text = DateTime.Now.Year.ToString();
            labMonth.Text = DateTime.Now.Month.ToString();

            ViewCompany();
            ReadEmployees();
            GetAtendeance();
            ViewAllDepartments();

            int year, month;

            year = Convert.ToInt32(labYear.Text);
            month = Convert.ToInt32(labMonth.Text);
            dgvAtendance.DataSource = store.checkinManagment.getAtendanceData(year, month);
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
        /* Start Employee */
        private void CreateEmployee()
        {
            FormNewEmployee formNewEmployee = new FormNewEmployee(officeManager);
            formNewEmployee.Show();
        }
        public void ReadEmployees()
        {
            List<Employee> employees = officeManager.EmployeeManagerOffice.ReadEmployees();
            List<Employee> departmentEmployees = new List<Employee>();

            if (cbxEmployeeType.SelectedIndex == 1)
            {
                departmentEmployees.Clear();
                foreach (Employee e in employees)
                {
                    if (e is CEO)
                    {
                        departmentEmployees.Add(e);
                    }
                }
            } else if (cbxEmployeeType.SelectedIndex == 2)
            {
                departmentEmployees.Clear();
                foreach (Employee e in employees)
                {
                    if (e is Admin)
                    {
                        departmentEmployees.Add(e);
                    }
                }
            } else if (cbxEmployeeType.SelectedIndex == 3)
            {
                departmentEmployees.Clear();
                foreach (Employee e in employees)
                {
                    if (e is DepotManager)
                    {
                        departmentEmployees.Add(e);
                    }
                }
            }
            else if (cbxEmployeeType.SelectedIndex == 4)
            {
                departmentEmployees.Clear();
                foreach (Employee e in employees)
                {
                    if (e is DepotEmployee)
                    {
                        departmentEmployees.Add(e);
                    }
                }
            }
            else if (cbxEmployeeType.SelectedIndex == 5)
            {
                departmentEmployees.Clear();
                foreach (Employee e in employees)
                {
                    if (e is SalesManager)
                    {
                        departmentEmployees.Add(e);
                    }
                }
            }
            else if (cbxEmployeeType.SelectedIndex == 6)
            {
                departmentEmployees.Clear();
                foreach (Employee e in employees)
                {
                    if (e is SalesRepresentative)
                    {
                        departmentEmployees.Add(e);
                    }
                }
            }
            else if (cbxEmployeeType.SelectedIndex == 7)
            {
                departmentEmployees.Clear();
                foreach (Employee e in employees)
                {
                    if (e is ProductManager)
                    {
                        departmentEmployees.Add(e);
                    }
                }
            }
            else if (cbxEmployeeType.SelectedIndex == 8)
            {
                departmentEmployees.Clear();
                foreach (Employee e in employees)
                {
                    if (e is OfficeManager)
                    {
                        departmentEmployees.Add(e);
                    }
                }
            }
            dgvEmployees.DataSource = departmentEmployees;

            if (cbxEmployeeType.SelectedIndex == 0)
            {
                dgvEmployees.DataSource = employees;
            }

            dgvEmployees.Columns["Password"].Visible = false;
        }
        private void UpdateEmployee()
        {
            // get selected employee
            int employeeID = Convert.ToInt32(tbxActiveEmployeeID.Text);
            if (string.IsNullOrEmpty(tbxActiveEmployeeID.Text))
            {
                MessageBox.Show("Please select an employee");
                return;
            }

            Employee activeEmployee = officeManager.EmployeeManagerOffice.GetEmployeeByID(employeeID);

            // get active contract of employee

            // open new update employee form
            //FormViewEmployee formViewEmployee = new FormViewEmployee(officeManager, activeEmployee, activeContract)
            // formViewEmployee.Show();

        }
        private void DeleteEmployee()
        {

        }
        private void cbxEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadEmployees();
        }
        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            CreateEmployee();
        }
        private void btnReadEmployees_Click(object sender, EventArgs e)
        {
            ReadEmployees();
        }
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];

                string employeeID = row.Cells["EmployeeID"].Value.ToString();

                tbxActiveEmployeeID.Text = employeeID;
            }
        }
        /* End Employees*/


        //Atendance
        private void btnDecreaseYear_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt16(labYear.Text);

            year--;
            labYear.Text = year.ToString();
            GetAtendeance();
        }
        private void btnIncreaseYear_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt16(labYear.Text);

            year++;
            labYear.Text = year.ToString();
            GetAtendeance();
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
            GetAtendeance();
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
            GetAtendeance();
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

            int year, month;

            year = Convert.ToInt32(labYear.Text);
            month = Convert.ToInt32(labMonth.Text);

            int i = 2;
            foreach (TimeWorked c in store.checkinManagment.getAllAtendanceTime(year, month))
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
            int year, month;

            year = Convert.ToInt32(labYear.Text);
            month = Convert.ToInt32(labMonth.Text);
            dgvAtendance.DataSource = store.checkinManagment.getAtendanceData(year, month);

            store.checkinManagment.getAllAtendanceTime(year, month);
        }

        //Departments
        public void ViewAllDepartments()
        {
            if (officeManager is OfficeManager)
            {
                ((OfficeManager)officeManager).departmentManagment.ViewAllDepartments();
                dgvDepartments.DataSource = ((OfficeManager)officeManager).departmentManagment.ViewAllDepartments();
            }
            else
            {
                MessageBox.Show("type casting failed");
            }
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

            if (officeManager is OfficeManager)
            {
                ((OfficeManager)officeManager).departmentManagment.AddDepartment(Name, Head, CompanyID);
            }
            else
            {
                MessageBox.Show("type casting failed");
            }

            ViewAllDepartments();
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
            if (officeManager is OfficeManager)
            {
                ((OfficeManager)officeManager).departmentManagment.EditDepartment(Name, Head, DepartmentID.ToString());
            }
            else
            {
                MessageBox.Show("type casting failed");
            }

            ViewAllDepartments();
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
        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labDepartmentID.Text) > 4)
            {
                if (officeManager is OfficeManager)
                {
                    try
                    {
                        ((OfficeManager)officeManager).departmentManagment.DeleteDepartment(Convert.ToInt32(labDepartmentID.Text));
                    }
                    catch
                    { 
                        MessageBox.Show("Select a department to delete"); 
                    }
                }
                else
                {
                    MessageBox.Show("type casting failed");
                }
            }
            else
            {
                MessageBox.Show("You can't delete the head departments");
            }
            ViewAllDepartments();
        }

        //Company
        private void ViewCompany()
        {
            Company company = new Company();
            if (officeManager is OfficeManager)
            {
                company = ((OfficeManager)officeManager).companyManagment.GetCompany(officeManager.EmployeeID);
            }
            else
            { MessageBox.Show("type casting failed."); }

            tbCompanyName.Text = company.CompanyName;
            tbAdress.Text = company.Address;
            tbBTW.Text = company.Btw;
            tbEmail.Text = company.Email;
            tbPhoneNumber.Text = company.PhoneNumber;
            tbKVK.Text = company.KVK;
            tbID.Text = company.CompanyID;
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
            try
            {
                Convert.ToInt32(BTW);
            }
            catch
            {
                MessageBox.Show("'BTW number' field must be only numbers.");
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
            try
            {
                Convert.ToInt32(PhoneNumber);
            }
            catch
            {
                MessageBox.Show("'PhoneNumber' field must be only numbers.");
                return;
            }

            string KVK = tbKVK.Text;
            if (string.IsNullOrEmpty(KVK))
            {
                MessageBox.Show("'KVK number' field is required.");
                return;
            }
            try
            {
                Convert.ToInt32(KVK);
            }
            catch
            {
                MessageBox.Show("'KVK number' field is required.");
                return;
            }
            if (officeManager is OfficeManager)
            {
                ((OfficeManager)officeManager).companyManagment.EditCompany(Name, Adress, PhoneNumber, Email, BTW, KVK, ID);
            }
            else
            { MessageBox.Show("type casting failed."); }
        }


        //Search bar
        private void tbxSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            /*string nameSearched = tbxSearchEmployee.Text;

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
                //ViewAllEmployees();
            }*/
        }

        
    }
}
