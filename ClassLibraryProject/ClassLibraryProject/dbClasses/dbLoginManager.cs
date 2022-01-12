using System;
using System.Diagnostics;
using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.AutoSchedule;
using ClassLibraryProject.Interfaces;
using ClassLibraryProject.ManagmentClasses;
using ClassLibraryProject.ManagmentClasses.IProductManager;
using MySql.Data.MySqlClient;

namespace ClassLibraryProject.dbClasses
{
     public class dbLoginManager : ILoginManagement
    {
        private string LOGIN_EMPLOYEE = " SELECT * FROM employee as e INNER JOIN contract as c ON c.employeeID = e.Employeeid where e.UserName = @UserName  AND e.Password = @Password AND e.Active = 1 ;";
        private string GET_EMPLOYEEID = " SELECT employeeID, password, userName FROM employee where UserName = @UserName";


        public Employee checkLogin(string givenUsername, string givenPassword)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = LOGIN_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@Username", givenUsername);
                cmd.Parameters.AddWithValue("@Password", givenPassword);

                MySqlDataReader reader = cmd.ExecuteReader();

                Employee employee;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32(0);
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string username = reader.GetString(3);
                    string password = reader.GetString(4);
                    int bsn = reader.GetInt32(5); 
                    string city = reader.GetString(7);
                    string email = reader.GetString(8);
                    string phoneNumber = reader.GetString(9);
                    DateTime dateOfBirth = reader.GetDateTime(10);
                    string streetName = reader.GetString(12);
                    string zipCode = reader.GetString(13);
                    string jobTitle = reader.GetString(17);
                    string personalEmail = reader.GetString(14);

                    if (jobTitle == "ADMIN")
                    {
                        IEmployeeManagerAdmin employeeManagerAdmin = new EmployeeManager();
                        IContractManager contractManager = new ContractManager();
                        IEmployeeManagerAll employeeManagerAll = new EmployeeManager();
                        IDepartment department = new DepartmentManagment(new dbDepartmentManagment());

                        employee = new Admin(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAdmin, contractManager, employeeManagerAll, department);
                        return employee;
                    }
                    else if (jobTitle == "CEO")
                    {
                        employee = new CEO(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        return employee;
                    }
                    else if (jobTitle == "DEPOT MANAGER")
                    {
                        AutoScheduleManagment autoSchedule = new AutoScheduleManagment(new AsignShiftManagment(new DbAsignShiftManagment()), new EmployeesAvailibleManagment(new DbEmployeesAvailibleManagment()), new DeletePlanningForTheWeekManagment(new DbDeletePlanningForTheWeekManagment()), new AmountOfEmployeesNeededManagment(new DbAmountOfEmployeesNeededManagment()));
                        IEmployeeManagerAll employeeManagerAll = new EmployeeManager();

                        employee = new DepotManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, new DepotDepartmentsManagment(new dbDepotDepartments()), autoSchedule, employeeManagerAll);
                        return employee;
                    }
                    else if (jobTitle == "DEPOT EMPLOYEE")
                    {
                        employee = new DepotEmployee(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        return employee;
                    }
                    else if (jobTitle == "OFFICE MANAGER")
                    {
                        IEmployeeManagerOffice employeeManagerOffice = new EmployeeManager();
                        IContractManager contractManager = new ContractManager();
                        IDepartment department = new DepartmentManagment( new dbDepartmentManagment());
                        ICompany company = new CompanyManagment( new dbCompanyManagment());
                        ICheckin checkin = new CheckinManagment(new dbCheckinManagment());

                        employee = new OfficeManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerOffice, department, company, contractManager, checkin);
                        return employee;
                    }
                    else if (jobTitle == "PRODUCT MANAGER")
                    {
                        IEmployeeManagerAll employeeManagerAll = new EmployeeManager();
                        IProductManagerPM productManagerPM = new ProductManagement();
                        ISupplierManagerPM supplierManagerPM = new SupplierManagment();

                        employee = new ProductManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, employeeManagerAll, productManagerPM, supplierManagerPM);
                        return employee;
                    }
                    else if (jobTitle == "SALES MANAGER")
                    {
                        AutoScheduleManagment autoSchedule = new AutoScheduleManagment(new AsignShiftManagment(new DbAsignShiftManagment()), new EmployeesAvailibleManagment(new DbEmployeesAvailibleManagment()), new DeletePlanningForTheWeekManagment(new DbDeletePlanningForTheWeekManagment()), new AmountOfEmployeesNeededManagment(new DbAmountOfEmployeesNeededManagment()));
                        employee = new SalesManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail, new SalesDepartmentsManagment(new dbSalesDepartments()), autoSchedule);
                        return employee;
                    }
                    else if (jobTitle == "SALES REPRESENTATIVE")
                    {
                        employee = new SalesRepresentative(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, personalEmail);
                        return employee;
                    }
                }
            }
             catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return null;
        }

        public int GetID(string UserName, string Password)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_EMPLOYEEID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@UserName", UserName);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[2].ToString() == UserName.ToString() && reader[1].ToString() == Password.ToString())
                    {
                        return Convert.ToInt32(reader[0]);
                    }
                }
                return 0;
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return 0;
        }
    }
}
