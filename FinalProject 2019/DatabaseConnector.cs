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
                    if(dataReader != null) {
                        Console.WriteLine(String.Format("ID: {0}, address: {1}, capacity: {2}, atm_size: {3}, brand: {4}",
                            dataReader["id"].ToString(),
                            dataReader["address"].ToString(),
                            dataReader["capacity"].ToString(),
                            dataReader["atm_size"].ToString(),
                            dataReader["brand"].ToString()
                        ));
                    }
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
                // Executing the query in the SQL server
                cmd.ExecuteNonQuery();
            } catch(MySqlException ex) {
                throw ex;
            }

            // Closing SQL connection
            conn.Close();
        }

        public static void fillAtmsDatabase(ATM[] atmsToFill) {
            foreach (ATM atm in atmsToFill) {
                write("INSRT INTO Atms (address, capacity, atm_size, brand) " +
                    $"VALUES({atm.address}, {atm.capacity}, {atm.size}, {atm.brand})");
            }
        }
    }

    class ATM {

        public string address { get; set; }
        public int capacity { get; set; }
        public int size { get; set; }
        public string brand { get; set; }

        public ATM(string _address, int _capacity, int _size, string _brand) {
            address = _address;
            capacity = _capacity;
            size = _size;
            brand = _brand;
        }
    }
}