using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;

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
                
                string newAtmString = $"INSERT INTO Atms (capacity, live_money_avilable, atm_size, brand, Addresses_id) VALUES ('{newATM.capacity}', '{newATM.live_money_avilable}', '{newATM.size}', '{newATM.brand}', {addrsID})";
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

        public bool addNewEmploeey(Emploeey newEmp) {
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

                string newEmpString = $"INSERT INTO Employees (id, name, birth_date, role, username, password, phone_number, email, gender, Addresses_id) VALUES ('{newEmp.id}', '{newEmp.name}', '{newEmp.birthDate.ToString()}', '{newEmp.role}', '{newEmp.username}', '{newEmp.password}', '{newEmp.phone_number}', '{newEmp.email}', '{newEmp.gender}', {addrsID})";
                newAtmCommand.CommandText = newEmpString;
                newAtmCommand.CommandType = CommandType.Text;

                newAtmCommand.ExecuteNonQuery();
            } catch (MySqlException ex) {
                if(ex.ErrorCode == -2147467259) {
                    // User duplicated
                    Console.WriteLine("User duplicated -> user already created");
                    return false;
                }

                throw ex;
            }

            // Closing SQL connection
            conn.Close();

            Console.WriteLine("new Emploeey has been created");
            return true;
        }

        public DataSet getAllTable(string tableName) {
            connect();

            string query = $"SELECT * FROM {tableName};";

            using(conn) {
                using(MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn)) {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    return ds;
                }
            }
        }

        public void getBusyestDay(int atmID) {
            
        }

        public List<LatLng> calcShortestTrack(List<LatLng> atmPoints) {
            Console.WriteLine($"in: {atmPoints.ToString()}");
            if (atmPoints.Count != 1) {
                // Starting point to check from
                LatLng startingPoint = atmPoints[0];
                LatLng nextPoint = new LatLng(0.0, 0.0);
                double minDistance = -1.0;

                for(int i = 1; i < atmPoints.Count; i++) {
                    if(minDistance == -1.0) {
                        minDistance = startingPoint.getDistance(atmPoints[i]);
                        nextPoint = atmPoints[i];
                    } else {
                        double dis = startingPoint.getDistance(atmPoints[i]);
                        if(minDistance > dis) {
                            minDistance = dis;
                            nextPoint = atmPoints[i];
                        }
                    }
                }

                // Removing the starting point
                atmPoints.Remove(startingPoint);
                
                // Moving the next point to the top of the list
                atmPoints.Remove(nextPoint);
                atmPoints.Insert(0, nextPoint);

                Console.WriteLine($"out: {atmPoints.ToString()}");

                List<LatLng> toReturn = calcShortestTrack(atmPoints);
                toReturn.Insert(0, startingPoint);
                return toReturn;
            }

            return atmPoints;
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
        public int live_money_avilable { get; set; }

        public ATM(Address _address, int _capacity, int _size, string _brand) {
            address = _address;
            capacity = _capacity;
            live_money_avilable = _capacity;
            size = _size;
            brand = _brand;
        }
    }

    class Emploeey {
        public string id { get; set; }
        public string name { get; set; }
        public SqlDate birthDate {get; set;}
        public string role { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public Address address { get; set; }

        public Emploeey(string _id,  string _name, SqlDate _birthDate, string _role, string _username, string _phone_number, string _gender, Address _address) {
            if(_id.Length == 9) {
                id = _id;
            } else {
                throw new Exception("Inserted id is not vaild");
            }

            name = _name;
            birthDate = _birthDate;
            role = _role;
            username = _username;
            password = "1234abcd";
            phone_number = _phone_number;
            email = $"{username}@nsec.com";
            gender = _gender;
            address = _address;
        }
    }

    class Car {
        public string code { get; set; }
        public string model { get; set; }
        public SqlDate creation_date { get; set; }
        public int driver_id { get; set; }

        public Car(string _code, string _model, SqlDate _creation_date, int _driver_id) {
            code = _code;
            model = _model;
            creation_date = _creation_date;
            driver_id = _driver_id;
        }
    }

    class Track {
        public ATM[] atms { get; set; }
        public bool is_done { get; set; }
        public SqlDate date { get; set; }
        public string car_id { get; set; }
        public string employee_id { get; set; }
        public string manager_id { get; set; }

        public Track(ATM[] atms_c, bool idDone_c, SqlDate date_C, string carID_c, string empID_c, string mgrID_c) {
            atms = atms_c;
            is_done = idDone_c;
            date = date_C;
            car_id = carID_c;
            employee_id = empID_c;
            manager_id = mgrID_c;
        }
    }

    class SqlDate {
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }

        public SqlDate(int _day, int _month, int _year) {
            if(_day <= 31 && _month <= 12 && _year > 1900) {
                day = _day;
                month = _month;
                year = _year;
            } else {
                throw new Exception("Inserted values cannot be a valid day, Please check the values and try again");
            }
        }

        public override string ToString() {
            if(day < 10) {
                if(month < 10) {
                    return $"{year}-0{month}-0{day}";
                }

                return $"{year}-{month}-0{day}";
            } else if(month < 10) {
                return $"{year}-0{month}-{day}";
            } else {
                return $"{year}-{month}-{day}";
            }
        }
    }

    class Gender {
        public static string MALE = "M";
        public static string FEMALE = "F";
    }

    class Roles {
        public static string ADMIN = "ADMIN";
        public static string EMPLOYEE = "EMP";
    }

    class LatLng {
        public double lat { get; set; }
        public double lng { get; set; }

        public LatLng(double lat_c, double lng_c) {
            lat = lat_c;
            lng = lng_c;
        }

        public static double getDistance(LatLng point1, LatLng point2) {
            var d1 = point1.lat * (Math.PI / 180.0);
            var num1 = point1.lng * (Math.PI / 180.0);
            var d2 = point2.lat * (Math.PI / 180.0);
            var num2 = point2.lng * (Math.PI / 180.0) - num1;
            var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) + Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);

            return 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
        }

        public double getDistance(LatLng latlng) {
            var d1 = lat * (Math.PI / 180.0);
            var num1 = lng * (Math.PI / 180.0);
            var d2 = latlng.lat * (Math.PI / 180.0);
            var num2 = latlng.lng * (Math.PI / 180.0) - num1;
            var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) + Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);

            return 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
        }

        public override string ToString() {
            return $"({lat}, {lng})";
        }
    }
}