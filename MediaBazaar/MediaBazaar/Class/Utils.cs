using System;
using MySql.Data.MySqlClient;

namespace MediaBazaar.Class
{
    public class Utils
    {
        public static string LOGIN_BY_EMPLOYEEID = " SELECT employee.employeeID, password, `contract`.`JodTitle` FROM employee INNER JOIN contract ON contract.employeeID = employee.Employeeid where employee.employeeid = @employeeid order by startdate;";

        public static string CREATE_PRODUCT = "INSERT INTO Product ( Name, Barcode, Type, AmountInStore, AmountInDepot) VALUES (@Name, @Barcode, @Type, @AmountInStore, @AmountInDepot);";
        public static string GET_ALL_PRODUCT = "SELECT ProductID, Name, Barcode, Type, AmountInStore, AmountInDepot FROM Product ORDER BY ProductID;";
        public static string UPDATE_PRODUCT = "UPDATE PRODUCT SET Name = @Name, Barcode = @Barcode, Type = @Type, AmountInStore = @AmountInStore, AmountInDepot = @AmountInDepot WHERE ProductID = @ProductID;";
        public static string DELETE_PRODUCT_BY_ID = "DELETE FROM PRODUCT WHERE ProductID = @ProductID;";

        public static string CREATE_RESTOCKREPLENISHMENT = "INSERT INTO restockreplenishment ( ProductID, Amount) VALUES ( @ProductID, @Amount);";
        public static string GET_ALL_RESTOCKREPLENISHMENT = "SELECT restockreplenishmentID, product.ProductID, Amount, Name, AmountInStore, AmountInDepot FROM restockreplenishment INNER JOIN product ON product.ProductID = restockreplenishment.ProductID ORDER BY restockreplenishmentID;";
        public static string UPDATE_RESTOCKREPLENISHMENT = "UPDATE PRODUCT SET AmountInDepot = @AmountInDepot WHERE ProductID = @ProductID;";
        public static string DELETE_RESTOCKREPLENISHMENT_BY_ID = "DELETE FROM restockreplenishment WHERE RestockReplenishmentID = @RestockReplenishmentID;";

        public static string CREATE_SHELFREPLENICHMENT = "INSERT INTO shelfreplenishment ( ProductID, Amount) VALUES ( @ProductID, @Amount);";
        public static string GET_ALL_SHELFREPLENICHMENT = "SELECT ShelfReplenishmentID,shelfreplenishment.ProductID, Amount, Name, Barcode, Type, AmountInStore, AmountInDepot FROM shelfreplenishment  INNER JOIN product ON shelfreplenishment.ProductID = product.ProductID ORDER BY ShelfReplenishmentID;";
        public static string UPDATE_SHELFREPLENICHMENT = "UPDATE PRODUCT SET AmountInStore = @AmountInStore, AmountInDepot = @AmountInDepot WHERE ProductID = @ProductID;";
        public static string DELETE_SHELFREPLENICHMENT_BY_ID = "DELETE FROM shelfreplenishment WHERE ShelfReplenishmentID = @ShelfReplenishmentID;";

        public static string GET_SCHEDULE = "SELECT scheduleId, department, day, morning, afternoon, evening from SCHEDULE";
        public static string GET_SCHEDULE_SALES = "SELECT scheduleId, department, day, morning, afternoon, evening from SCHEDULE where Department = 'sales';";
        public static string GET_SCHEDULE_DEPOT = "SELECT  scheduleId, department, day, morning, afternoon, evening from SCHEDULE where Department = 'depot';";
        public static string GET_SCHEDULE_OFFICE = "SELECT scheduleId, department, day, morning, afternoon, evening from SCHEDULE where Department = 'office';";

        public static string UPDATE_SCHEDULE = "UPDATE schedule SET morning = @morning, afternoon = @afternoon, evening = @evening WHERE scheduleId = @scheduleId;";


        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn =
                new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi461266;Database=dbi461266;Pwd=Nijlpaard;SslMode =none;");
            return conn;
        }
    }
}
