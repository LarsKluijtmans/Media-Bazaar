﻿using MySql.Data.MySqlClient;
using System;


namespace acr122_demo
{
    class Connection
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn =
                new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi461266;Database=dbi461266;Pwd=Nijlpaard;SslMode =none;");
            return conn;
        }
    }
}
