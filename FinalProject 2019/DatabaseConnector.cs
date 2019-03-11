using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;

namespace FinalProject_2019 {
    class DatabaseConnector {

        private static string server = "localhost";
        private static string database = "nsecurity";
        private static string user = "root";
        private static string password = "toor";
        private static string port = "3306";
        private static string sslM = "none";
        private static MySqlConnection conn;

        public static void connect() {
            string connectionString = String.Format(
                "Server={0};Database={3};User Id={1};Password={2};", 
                server, 
                user, 
                password, 
                database
            );

            MySqlConnection connection = new MySqlConnection(connectionString);
            conn = connection;
        }

        public static void read() {
            connect();

            MySqlCommand cmd = new MySqlCommand("select * from atms;");
            cmd.CommandType = CommandType.Text;

            if (conn != null) {
                cmd.Connection = conn;
                conn.Open();
            }

            try {
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read()) {
                    Console.WriteLine(String.Format("ID: {0}, address: {1}, capacity: {2}, atm_size: {3}, brand: {4}",
                        dataReader["id"].ToString(),
                        dataReader["address"].ToString(),
                        dataReader["capacity"].ToString(),
                        dataReader["atm_size"].ToString(),
                        dataReader["brand"].ToString()
                    ));
                }

                dataReader.Close();
                conn.Close();
            } catch(MySqlException ex) {
                throw ex;
            }

            conn.Close();
        }

        public static void write(string sqlCommand) {
            connect();

            MySqlCommand cmd = new MySqlCommand(sqlCommand);
            cmd.CommandType = CommandType.Text;

            if (conn != null) {
                cmd.Connection = conn;
                conn.Open();
            }

            try {
                
            } catch(MySqlException ex) {
                throw ex;
            }

            conn.Close();
        }
    }
}