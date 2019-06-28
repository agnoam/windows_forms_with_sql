using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using FinalProject_2019.Resources;

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


        public bool deleteFromTable(string table, string id) {
            connect();

            MySqlCommand cmd = new MySqlCommand($"DELETE FROM { table } WHERE id = { id }");
            cmd.CommandType = CommandType.Text;

            if (conn != null) {
                cmd.Connection = conn;
                conn.Open();
            }

            try {
                // Executing the query in the SQL server
                cmd.ExecuteNonQuery();               
            } catch (MySqlException ex) {
                Console.WriteLine(ex);
                return false;
            }

            // Closing SQL connection
            conn.Close();
            return true;
        }

        public bool addNewATM(ATM newATM) {
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
            
                return true;
            }

            return false;
        }

        public bool addNewCar(Car car) {
            connect();

            string insertCmd = $"INSERT INTO Cars (code, model, creation_date, driver_id) VALUES ('{car.code}', '{car.model}', '{car.creation_date}', '{car.driver_id}')";
            MySqlCommand cmd = new MySqlCommand(insertCmd);
            cmd.CommandType = CommandType.Text;

            if(conn != null) {
                cmd.Connection = conn;
                conn.Open();

                try {
                    // Executing the query in the SQL server
                    cmd.ExecuteNonQuery();

                    return true;
                } catch (MySqlException ex) {
                    Console.WriteLine(ex.ToString());

                    return false;
                }
            }

            return false;
        }

        public bool addNewEmploeey(Employee newEmp) {
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

                try {
                    // Executing the query in the SQL server
                    addrsCommand.ExecuteNonQuery();
                    int addrsID = int.Parse(getAddressID.ExecuteScalar().ToString());

                    string newEmpString = $"INSERT INTO Employees (id, name, birth_date, role, username, password, phone_number, email, gender, Addresses_id) VALUES ('{newEmp.id}', '{newEmp.name}', '{newEmp.birthDate.ToString()}', '{newEmp.role}', '{newEmp.username}', '{newEmp.password}', '{newEmp.phone_number}', '{newEmp.email}', '{newEmp.gender}', {addrsID})";
                    newAtmCommand.CommandText = newEmpString;
                    newAtmCommand.CommandType = CommandType.Text;

                    newAtmCommand.ExecuteNonQuery();
                } catch (MySqlException ex) {
                    if (ex.ErrorCode == -2147467259) {
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

            return false;
        }

        public bool updateATM(ATM atm, Address originalAddr, string atmID, string addressID) {
            if (AdditionalFunctions.isEmpty(atmID)) {
                string updateCmd = $"UPDATE Atms SET capacity = '{ atm.capacity }', atm_size = '{ atm.size }', brand = { atm.brand }, Addresses_id = '{ addressID }', live_money_available = { atm.live_money_avilable } WHERE id = { atmID }";
                MySqlCommand cmd = new MySqlCommand(updateCmd);
                cmd.CommandType = CommandType.Text;

                if (!atm.address.Equals(originalAddr)) {
                    Console.WriteLine("Updating address");

                    try {
                        // Needs to update the address
                        bool res = updateAddress(addressID, atm.address);

                        if (!res) {
                            return false;
                        }
                    } catch (Exception ex) {
                        Console.WriteLine("Problem with address update");
                        throw ex;
                    }
                }

                if (conn != null) {
                    cmd.Connection = conn;
                    conn.Open();

                    try {
                        cmd.ExecuteNonQuery();
                        return true;
                    } catch (MySqlException ex) {
                        Console.WriteLine(ex.ToString());
                        return false;
                    }
                }

                return false;
            } else {
                throw new Exception("Employee's id must be defined correctly");
            }
        }

        public bool updateEmployee(Employee emp, Address originalAdrr, string addressID) {
            if (AdditionalFunctions.isEmpty(emp.id) && emp.id.Length == 9) {
                string hashedPass = AdditionalFunctions.MD5(AdditionalFunctions.MD5(emp.password));
                string updateCmd = $"UPDATE Employees SET id = { emp.id }, name = '{ emp.name }', birth_date = '{ emp.birthDate.ToString() }', role = { emp.role }, password = '{ hashedPass }', phone_number = { emp.phone_number }, email = { emp.email }, gender = { emp.gender }, Addresses_id = { addressID } WHERE id = { emp.id }";
                MySqlCommand cmd = new MySqlCommand(updateCmd);
                cmd.CommandType = CommandType.Text;

                if(!emp.address.Equals(originalAdrr)) {
                    try {
                        // Needs to update the address
                        bool res = updateAddress(addressID, emp.address);

                        if(!res) {
                            return false;
                        }
                    } catch(Exception ex) {
                        throw ex;
                    }
                }

                if (conn != null) {
                    cmd.Connection = conn;
                    conn.Open();

                    try {
                        cmd.ExecuteNonQuery();
                        return true;
                    } catch (MySqlException ex) {
                        Console.WriteLine(ex.ToString());
                        return false;
                    }
                }

                return false;
            } else {
                throw new Exception("Employee's id must be defined correctly");
            }
        }

        private bool updateAddress(string id, Address addr) {
            if (AdditionalFunctions.isEmpty(id) && int.Parse(id) >= 0) {
                string updateCmd = $"UPDATE Addresses SET street = '{ addr.street }', house_num = '{ addr.house_num }', city = { addr.city }, zip_code = '{ addr.zip_code }', lat = { addr.lat }, lng = { addr.lng } WHERE id = { id }";
                MySqlCommand cmd = new MySqlCommand(updateCmd);
                cmd.CommandType = CommandType.Text;

                if (conn != null) {
                    cmd.Connection = conn;
                    conn.Open();

                    try {
                        cmd.ExecuteNonQuery();
                        return true;
                    } catch (MySqlException ex) {
                        Console.WriteLine(ex.ToString());
                        return false;
                    }
                }

                return false;
            } else {
                throw new Exception("Address's id must be defined correctly");
            }
        }

        public bool updateCar(Car car, string carID) {
            if(carID != null) {
                string updateCmd = $"UPDATE Cars SET code = '{ car.code }', model = '{ car.model }', creation_date = '{ car.creation_date.ToString() }', driver_id = '{ car.driver_id }' WHERE id = { carID }";
                MySqlCommand cmd = new MySqlCommand(updateCmd);
                cmd.CommandType = CommandType.Text;

                if(conn != null) {
                    cmd.Connection = conn;
                    conn.Open();

                    try {
                        cmd.ExecuteNonQuery();
                        return true;
                    } catch(MySqlException ex) {
                        Console.WriteLine(ex.ToString());
                        return false;
                    }
                }

                return false;
            } else {
                throw new Exception("Car's id must be defined");
            }
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

        public Address getAddressByID(string id) {
            connect();

            string query = $"SELECT * FROM Addresses WHERE id = {id};";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            Address addressToReturn = null;

            try {
                conn.Open();

                MySqlDataReader dataReader = cmd.ExecuteReader();
                string street = null;
                string house_num = null;
                string city = null;
                string zip_code = null;
                string lat = null;
                string lng = null;

                while (dataReader.Read()) {
                    if (dataReader != null) {
                        if(street == null) {
                            street = dataReader["street"].ToString();
                        }
                        
                        if(house_num == null) {
                            house_num = dataReader["house_num"].ToString();
                        }

                        if(city == null) {
                            city = dataReader["city"].ToString();
                        }

                        if(zip_code == null) {
                            zip_code = dataReader["zip_code"].ToString();
                        }

                        if(lat == null) {
                            lat = dataReader["lat"].ToString();
                        }

                        if (lng == null) {
                            lng = dataReader["lng"].ToString();
                        }
                    }
                }

                if(street != null && house_num != null && city != null && zip_code != null && lat != null && lng != null) {
                    addressToReturn = new Address(street, int.Parse(house_num), city, zip_code, double.Parse(lat), double.Parse(lng));
                }

                dataReader.Close();
                conn.Close();
            } catch(MySqlException ex) {
                throw ex;
            }

            if(addressToReturn == null) {
                Console.WriteLine("Address not found");
            }

            conn.Close();

            return addressToReturn;
        }

        public void getBusyestDay(int atmID) {
            // Get avg time of atm's withdrawls
        }

        // DFS Algorithem
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
}