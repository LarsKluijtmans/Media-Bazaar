using System;
using MySql.Data.MySqlClient;

namespace MediaBazaar.Class
{
    public class Utils
    {
        public static string LOGIN_BY_EMPLOYEEID = " SELECT employee.employeeID, password, `contract`.`JodTitle` FROM employee INNER JOIN contract ON contract.employeeID = employee.Employeeid where employee.employeeid = @employeeid order by startdate;";

        //Product

        public static string CREATE_PRODUCT = "INSERT INTO Product ( Name, Barcode, Type, AmountInStore, AmountInDepot) VALUES (@Name, @Barcode, @Type, @AmountInStore, @AmountInDepot);";
        public static string GET_ALL_PRODUCT = "SELECT ProductID, Name, Barcode, Type, AmountInStore, AmountInDepot FROM Product ORDER BY ProductID;";
        public static string UPDATE_PRODUCT = "UPDATE PRODUCT SET Name = @Name, Barcode = @Barcode, Type = @Type, AmountInStore = @AmountInStore, AmountInDepot = @AmountInDepot WHERE ProductID = @ProductID;";
        public static string DELETE_PRODUCT_BY_ID = "DELETE FROM PRODUCT WHERE ProductID = @ProductID;";

        //Resock

        public static string CREATE_RESTOCKREPLENISHMENT = "INSERT INTO restockreplenishment ( ProductID, Amount) VALUES ( @ProductID, @Amount);";
        public static string GET_ALL_RESTOCKREPLENISHMENT = "SELECT restockreplenishmentID, product.ProductID, Amount, Name, AmountInStore, AmountInDepot FROM restockreplenishment INNER JOIN product ON product.ProductID = restockreplenishment.ProductID ORDER BY restockreplenishmentID;";
        public static string UPDATE_RESTOCKREPLENISHMENT = "UPDATE PRODUCT SET AmountInDepot = @AmountInDepot WHERE ProductID = @ProductID;";
        public static string DELETE_RESTOCKREPLENISHMENT_BY_ID = "DELETE FROM restockreplenishment WHERE RestockReplenishmentID = @RestockReplenishmentID;";

        //Reshelf

        public static string CREATE_SHELFREPLENICHMENT = "INSERT INTO shelfreplenishment ( ProductID, Amount) VALUES ( @ProductID, @Amount);";
        public static string GET_ALL_SHELFREPLENICHMENT = "SELECT ShelfReplenishmentID,shelfreplenishment.ProductID, Amount, Name, Barcode, Type, AmountInStore, AmountInDepot FROM shelfreplenishment  INNER JOIN product ON shelfreplenishment.ProductID = product.ProductID ORDER BY ShelfReplenishmentID;";
        public static string UPDATE_SHELFREPLENICHMENT = "UPDATE PRODUCT SET AmountInStore = @AmountInStore, AmountInDepot = @AmountInDepot WHERE ProductID = @ProductID;";
        public static string DELETE_SHELFREPLENICHMENT_BY_ID = "DELETE FROM shelfreplenishment WHERE ShelfReplenishmentID = @ShelfReplenishmentID;";

        //Schedule

        public static string GET_SCHEDULE = "SELECT scheduleId, department, day, morning, afternoon, evening from SCHEDULE";
        public static string GET_SCHEDULE_SALES = "SELECT scheduleId, department, day, morning, afternoon, evening from SCHEDULE where Department = 'sales';";
        public static string GET_SCHEDULE_DEPOT = "SELECT  scheduleId, department, day, morning, afternoon, evening from SCHEDULE where Department = 'depot';";
        public static string GET_SCHEDULE_OFFICE = "SELECT scheduleId, department, day, morning, afternoon, evening from SCHEDULE where Department = 'office';";
        public static string UPDATE_SCHEDULE = "UPDATE schedule SET morning = @morning, afternoon = @afternoon, evening = @evening WHERE scheduleId = @scheduleId;";

        //Planing

        public static string GET_OFFICE_EMPLOYEE = "SELECT DISTINCT EMPLOYEE.EmployeeID, FirstName, LastName, contract.JodTitle FROM `employee` INNER JOIN contract ON contract.EmployeeID = employee.EmployeeID WHERE contract.JodTitle = 'OFFICE EMPLOYEE' or contract.JodTitle = 'OFFICE MANAGER';";
        public static string GET_DEPOT_EMPLOYEE = "SELECT DISTINCT EMPLOYEE.EmployeeID, FirstName, LastName, contract.JodTitle FROM `employee` INNER JOIN contract ON contract.EmployeeID = employee.EmployeeID WHERE contract.JodTitle = 'DEPOT EMPLOYEE' or contract.JodTitle = 'DEPOT MANAGER';";
        public static string GET_SALES_EMPLOYEE = "SELECT DISTINCT EMPLOYEE.EmployeeID, FirstName, LastName, contract.JodTitle FROM `employee` INNER JOIN contract ON contract.EmployeeID = employee.EmployeeID WHERE contract.JodTitle = 'SALES EMPLOYEE' or contract.JodTitle = 'SALES MANAGER';";

        public static string GET_DEPOT_PLANING = "SELECT workID, Department, employeeID, day, time FROM schduledwork WHERE department = 'DEPOT'; ";
        public static string GET_OFFICE_PLANING = "SELECT workID, Department, employeeID, day, time FROM schduledwork WHERE department = 'OFFICE'; ";
        public static string GET_SALES_PLANING = "SELECT workID, Department, employeeID, day, time FROM schduledwork WHERE department = 'SALES'; ";

        public static string UPDATE_PLANING = "UPDATE schduledwork SET employeeID = @emplyeeID  WHERE workID = @workID;";
        public static string PLAN_AUTOPLANING = "SELECT PrefranceID, contract.EmployeeID, Prefered, DAY, Time, contract.JodTitle, contract.WorkHoursPerWeek FROM workprefrance INNER JOIN contract ON contract.EmployeeID = workprefrance.EmployeeID;";
       
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
