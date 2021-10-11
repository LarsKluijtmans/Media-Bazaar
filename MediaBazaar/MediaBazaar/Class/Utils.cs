using System;
using MySql.Data.MySqlClient;

namespace MediaBazaar.Class
{
    public class Utils
    {
        public static string LOGIN_BY_EMPLOYEEID = " SELECT employee.employeeID, password, `contract`.`JodTitle` FROM employee INNER JOIN contract ON contract.employeeID = employee.Employeeid where employee.employeeid = @employeeid order by startdate;";


        //Planing
  
        public static string MAKE_EMPTY_SCHEDULE = "SELECT Department, Day, Morning , Afternoon, Evening FROM `schedule`;";
        public static string CREATE_SCHDULEDWORK = "INSERT INTO schduledwork (Department, EmployeeID, Day, Time) VALUE ( @depratment , @EmployeeID , @Day , @Time);";

        public static string CLEAR_PLAN = "DELETE FROM schduledwork;";

        // employees
        public static string CREATE_EMPLOYEE = "INSERT INTO Employee (FirstName, LastName, UserName, Password, BSN, Active, Address, Email, PhoneNumber) VALUES (@FirstName, @LastName, @Username, @Password, @BSN, @Active, @City, @Email, @PhoneNumber);";
        public static string GET_ALL_EMPLOYEES = "SELECT * FROM Employee ORDER BY EmployeeID;";
        public static string UPDATE_EMPLOYEE = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, Address = @City, PhoneNumber = @PhoneNumber WHERE EmployeeID = @EmployeeID;";
        public static string DELETE_EMPLOYEE_BY_ID = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";

        public static string VIEW_EMPLOYEE = "SELECT * FROM Employee WHERE EmployeeID = @EmployeeID;";
        public static string REMOVE_EMPLOYEE_BY_ID = "UPDATE Employee SET Active = @Active WHERE EmployeeID = @EmployeeID;";

        // contract
        public static string CREATE_CONTRACT = "INSERT INTO Contract (JodTitle, WorkHoursPerWeek, SalaryPerHour, StartDate) VALUES (@JobTitle, @WorkHoursPerWeek, @SalaryPerHour, @StartDate);";
        public static string GET_ALL_CONTRACTS = "SELECT * FROM Contract ORDER BY EmployeeID;";
        public static string UPDATE_CONTRACT = "UPDATE Contract SET JodTitle = @JobTitle, WorkHoursPerWeek = @WorkHoursPerWeek, SalaryPerHour = @SalaryPerHour, StartDate = @StartDate;";
        public static string DELETE_CONTRACT_BY_ID = "DELETE FROM Contract WHERE EmployeeID = @EmployeeID";

        //check
        public static string CREATE_CHECKIN = "INSERT INTO ATENDANCE(EmployeeID, CheckInTime, CheckOutTime, CheckDate) VALUES(@ID, @CheckInTime, @CheckOutTime, @CheckDate)";
        public static string CREATE_CHECKOUT = "UPDATE ATENDANCE SET CheckOutTime = @CheckOutTime WHERE CheckDate = @CheckDate && EmployeeID = @ID;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn =
                new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi461266;Database=dbi461266;Pwd=Nijlpaard;SslMode =none;");
            return conn;
        }
    }
}
