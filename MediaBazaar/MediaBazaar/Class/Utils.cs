using System;
using MySql.Data.MySqlClient;

namespace MediaBazaar.Class
{
    class Utils
    {

        public static string CREATE_PRODUCT = "INSERT INTO PRODUCT(name, email) VALUES (@name, @email);";
        public static string GET_ALL_PRODUCT = "SELECT id, name, email FROM user2 ORDER BY id;";
        public static string UPDATE_PRODUCT = "UPDATE PRODUCT SET name = @name, email = @email WHERE id = @id;";
        public static string DELETE_PRODUCT_BY_ID = "DELETE FROM PRODUCT WHERE id = @id;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn =
                new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi874073;Database=dbi874073;Pwd=dbi874073;SslMode=none;");
            return conn;
        }
    }
}
