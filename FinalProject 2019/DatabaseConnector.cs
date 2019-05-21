using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using FinalProject_2019.UI;

namespace FinalProject_2019 {
    class DatabaseConnector {

        private static string server = "localhost";
        private static string database = "nsecurity";
        private static string user = "root";
        private static string password = "toor";
        // private static string port = "3306";
        // private static string sslM = "none";
        private static string allowVariables = "True";
        private static MySqlConnection conn;

        public static void connect() {
            string connectionString = String.Format(
                "Server={0};Database={3};User Id={1};Password={2};AllowUserVariables={4};", 
                server, 
                user, 
                password, 
                database,
                allowVariables
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

        public void addNewATM(ATM newATM) {
            connect();

            string addressInsertCommand = $"INSERT INTO Addresses (street, house_num, city, zip_code, lat, lng) VALUES ('{newATM.address.street}', {newATM.address.house_num}, '{newATM.address.city}', '{newATM.address.zip_code}', {newATM.address.lat}, {newATM.address.lng})";
            string getLastInsert = "SELECT LAST_INSERT_ID()";

            MySqlCommand getAddressID = new MySqlCommand(getLastInsert);
            MySqlCommand addrsCommand = new MySqlCommand(addressInsertCommand);
            MySqlCommand newAtmCommand = new MySqlCommand();

            getAddressID.CommandType = CommandType.Text;
            addrsCommand.CommandType = CommandType.Text;

            if (conn != null) {
                addrsCommand.Connection = conn;
                getAddressID.Connection = conn;
                newAtmCommand.Connection = conn;

                conn.Open();
            }

            try {
                // Executing the query in the SQL server
                addrsCommand.ExecuteNonQuery();
                int addrsID = int.Parse(getAddressID.ExecuteScalar().ToString());
                
                string newAtmString = $"INSERT INTO Atms (capacity, atm_size, brand, Addresses_id) VALUES ('{newATM.capacity}', '{newATM.size}', '{newATM.brand}', '{addrsID}')";
                newAtmCommand.CommandText = newAtmString;
                newAtmCommand.CommandType = CommandType.Text;

                newAtmCommand.ExecuteNonQuery();
            } catch (MySqlException ex) {
                throw ex;
            }

            // Closing SQL connection
            conn.Close();

            Console.WriteLine("new ATM has been created");
        }

        public void addNewEmploeey(Emploeey newEmp) {
            connect();

            string addressInsertCommand = $"INSERT INTO Addresses (street, house_num, city, zip_code, lat, lng) VALUES ('{newEmp.address.street}', {newEmp.address.house_num}, '{newEmp.address.city}', '{newEmp.address.zip_code}', {newEmp.address.lat}, {newEmp.address.lng})";
            string getLastInsert = "SELECT LAST_INSERT_ID()";

            MySqlCommand getAddressID = new MySqlCommand(getLastInsert);
            MySqlCommand addrsCommand = new MySqlCommand(addressInsertCommand);
            MySqlCommand newAtmCommand = new MySqlCommand();

            getAddressID.CommandType = CommandType.Text;
            addrsCommand.CommandType = CommandType.Text;

            if (conn != null) {
                addrsCommand.Connection = conn;
                getAddressID.Connection = conn;
                newAtmCommand.Connection = conn;

                conn.Open();
            }

            try {
                // Executing the query in the SQL server
                addrsCommand.ExecuteNonQuery();
                int addrsID = int.Parse(getAddressID.ExecuteScalar().ToString());

                string newEmpString = $"INSERT INTO Employees (name, birth_date, role, username, password, phone_number, email, gender, Addresses_id) VALUES ('{newEmp.name}', '{newEmp.birthDate.ToString()}', '{newEmp.role}', '{newEmp.username}', '{newEmp.password}', '{newEmp.phone_number}', '{newEmp.email}', '{newEmp.gender}', {addrsID})";
                newAtmCommand.CommandText = newEmpString;
                newAtmCommand.CommandType = CommandType.Text;

                newAtmCommand.ExecuteNonQuery();
            } catch (MySqlException ex) {
                throw ex;
            }

            // Closing SQL connection
            conn.Close();

            Console.WriteLine("new Emploeey has been created");
        }
    }

    class Address {
        public string street { get; set; }
        public int house_num { get; set; }
        public string city { get; set; }
        public string zip_code { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }

        public Address(string _street, int _house_num, string _city, string _zip_code, double _lat, double _lng) {
            street = _street;
            house_num = _house_num;
            city = _city;
            zip_code = _zip_code;
            lat = _lat;
            lng = _lng;


            if (lat == 0.0 || lng == 0.0) {
                // Fetch from the internet the real latLng of the address
            }
        }
    }

    class ATM {
        public Address address { get; set; }
        public int capacity { get; set; }
        public int size { get; set; }
        public string brand { get; set; }

        public ATM(Address _address, int _capacity, int _size, string _brand) {
            address = _address;
            capacity = _capacity;
            size = _size;
            brand = _brand;
        }
    }

    class Emploeey {
        public string name { get; set; }
        public SqlDate birthDate {get; set;}
        public string role { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public Address address { get; set; }

        public Emploeey(string _name, SqlDate _birthDate, string _role, string _username, string _gender, Address _address) {
            name = _name;
            birthDate = _birthDate;
            role = _role;
            username = _username;
            password = "1234abcd";
            email = $"{username}@nsec.com";
            gender = _gender;
            address = _address;
        }
    }

    class SqlDate {
        public string year { get; set; }
        public string month { get; set; }
        public string day { get; set; }

        public SqlDate(string _year, string _month, string _day) {
            int[] yearArr = toIntArr(_year);
            int[] monthArr = toIntArr(_month);
            int[] dayArr = toIntArr(_day);

            if (yearArr.Length != 4) {
                throw new Exception("Year must be 4 digits");
            } else if (monthArr.Length != 2) {
                throw new Exception("Month must be 2 digits");
            } else if(dayArr.Length != 2) {
                throw new Exception("Day must be 2 digits");
            } else {
                if (monthArr[0] <= 1) {
                    if(monthArr[0] == 1 && monthArr[1] > 2) {
                        throw new Exception("Month cannot be more than 12");
                    }
                } else if(monthArr[0] == 0 && monthArr[1] == 0) {
                    throw new Exception("Month cannot be 00");
                }

                if(dayArr[0] != 0 && dayArr[1] > 7) {
                    throw new Exception("Day cannot be more than 7");
                }
            }
        }

        private int[] toIntArr(string str) {
            char[] arr = str.ToArray();
            int[] returnArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++) {
                returnArr[i] = int.Parse(arr[i].ToString());
            }

            return returnArr;
        }

        public override string ToString() {
            return $"{year}-{month}-{day}";
        }
    }
}