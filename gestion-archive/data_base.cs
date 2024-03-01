using Npgsql;
using System;

namespace data_base
{
    public class Data_base
    {
        // Connection Informations for DB
        private static string Host = "***REMOVED***";
        private static string User = "***REMOVED***";
        private static string Password = "***REMOVED***";
        private static string Port = "***REMOVED***";

        //Connection to the DB
        public static NpgsqlConnection GetDBConnection(string DBname)
        {
            string connString =
                String.Format(
                    "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);

            NpgsqlConnection conn = new NpgsqlConnection(connString);

            return conn;
        }
    }
}