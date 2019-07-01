using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;

namespace FinalProject_2019.Resources {

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

            if (conn != null) {
                cmd.Connection = conn;
                conn.Open();

                try {
                    // Executing the query in the SQL server
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    return true;
                } catch (MySqlException ex) {
                    Console.WriteLine(ex.ToString());

                    conn.Close();
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

                    // Closing SQL connection
                    conn.Close();
                    Console.WriteLine("new Emploeey has been created");

                    return true;
                } catch (MySqlException ex) {
                    if (ex.ErrorCode == -2147467259) {
                        conn.Close();

                        // User duplicated
                        Console.WriteLine("User duplicated -> user already created");
                        return false;
                    }

                    throw ex;
                }
            }

            return false;
        }

        public int addTrack(Track track) {
            connect();

            string query = $"INSERT INTO Tracks (is_done, date, Cars_id, Employees_id, Manager_id) VALUES ({track.is_done}, '{track.date.ToString()}', '{track.car_id}', '{track.employee_id}', '{track.manager_id}')";
            string getLastInsert = "SELECT LAST_INSERT_ID()";

            MySqlCommand getTrackID = new MySqlCommand(getLastInsert, conn);
            MySqlCommand insertCmd = new MySqlCommand(query, conn);

            getTrackID.CommandType = CommandType.Text;
            insertCmd.CommandType = CommandType.Text;

            if (conn != null) {
                try {
                    conn.Open();

                    int idToReturn = 0;
                    insertCmd.ExecuteNonQuery();
                    idToReturn = int.Parse(getTrackID.ExecuteScalar().ToString());

                    conn.Close();
                    return idToReturn;
                } catch (MySqlException ex) {
                    conn.Close();
                    throw ex;
                }
            }

            throw new Exception("Connection with database didn't established, Please try again");
        }

        public bool addAtmToTrack(int atmID, int trackID) {
            connect();

            string query = $"INSERT INTO AtmsTracks (Atms_id, Track_id) VALUES('{atmID}', '{trackID}')";
            MySqlCommand insertCmd = new MySqlCommand(query, conn);
            insertCmd.CommandType = CommandType.Text;

            if (conn != null) {
                try {
                    conn.Open();

                    insertCmd.ExecuteNonQuery();

                    conn.Close();
                    return true;
                } catch (MySqlException ex) {
                    conn.Close();
                    Console.WriteLine(ex.StackTrace);
                    throw ex;
                }
            }

            throw new Exception("Connection with database didn't established, Please try again");
        }

        public bool updateATM(ATM atm, Address originalAddr, string atmID, string addressID) {
            if (!AdditionalFunctions.isEmpty(atmID)) {
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

                        conn.Close();
                        return true;
                    } catch (MySqlException ex) {
                        Console.WriteLine(ex.ToString());
                        conn.Close();

                        return false;
                    }
                }

                return false;
            } else {
                throw new Exception("Employee's id must be defined correctly");
            }
        }

        public bool updateEmployee(Employee emp, Address originalAdrr, string addressID) {
            if (!AdditionalFunctions.isEmpty(emp.id) && emp.id.Length == 9) {
                string hashedPass = AdditionalFunctions.MD5(AdditionalFunctions.MD5(emp.password));
                string updateCmd = $"UPDATE Employees SET id = { emp.id }, name = '{ emp.name }', birth_date = '{ emp.birthDate.ToString() }', role = { emp.role }, password = '{ hashedPass }', phone_number = { emp.phone_number }, email = { emp.email }, gender = { emp.gender }, Addresses_id = { addressID } WHERE id = { emp.id }";
                MySqlCommand cmd = new MySqlCommand(updateCmd);
                cmd.CommandType = CommandType.Text;

                if (!emp.address.Equals(originalAdrr)) {
                    try {
                        // Needs to update the address
                        bool res = updateAddress(addressID, emp.address);

                        if (!res) {
                            return false;
                        }
                    } catch (Exception ex) {
                        throw ex;
                    }
                }

                if (conn != null) {
                    cmd.Connection = conn;
                    conn.Open();

                    try {
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        return true;
                    } catch (MySqlException ex) {
                        Console.WriteLine(ex.ToString());
                        conn.Close();

                        return false;
                    }
                }

                return false;
            } else {
                throw new Exception("Employee's id must be defined correctly");
            }
        }

        private bool updateAddress(string id, Address addr) {
            if (!AdditionalFunctions.isEmpty(id) && int.Parse(id) >= 0) {
                string updateCmd = $"UPDATE Addresses SET street = '{ addr.street }', house_num = '{ addr.house_num }', city = '{ addr.city }', zip_code = '{ addr.zip_code }', lat = { addr.lat.ToString() }, lng = { addr.lng.ToString() } WHERE id = { id }";
                MySqlCommand cmd = new MySqlCommand(updateCmd);
                cmd.CommandType = CommandType.Text;

                if (conn != null) {
                    cmd.Connection = conn;
                    conn.Open();

                    try {
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        return true;
                    } catch (MySqlException ex) {
                        conn.Close();
                        throw ex;
                    }
                }

                return false;
            } else {
                throw new Exception("Address's id must be defined correctly");
            }
        }

        public bool updateCar(Car car, string carID) {
            if (carID != null) {
                string updateCmd = $"UPDATE Cars SET code = '{ car.code }', model = '{ car.model }', creation_date = '{ car.creation_date.ToString() }', driver_id = '{ car.driver_id }' WHERE id = { carID }";
                MySqlCommand cmd = new MySqlCommand(updateCmd);
                cmd.CommandType = CommandType.Text;

                if (conn != null) {
                    cmd.Connection = conn;
                    conn.Open();

                    try {
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        return true;
                    } catch (MySqlException ex) {
                        Console.WriteLine(ex.ToString());
                        conn.Close();

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

            using (conn) {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn)) {
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
                        if (street == null) {
                            street = dataReader["street"].ToString();
                        }

                        if (house_num == null) {
                            house_num = dataReader["house_num"].ToString();
                        }

                        if (city == null) {
                            city = dataReader["city"].ToString();
                        }

                        if (zip_code == null) {
                            zip_code = dataReader["zip_code"].ToString();
                        }

                        if (lat == null) {
                            lat = dataReader["lat"].ToString();
                        }

                        if (lng == null) {
                            lng = dataReader["lng"].ToString();
                        }
                    }
                }

                if (street != null && house_num != null && city != null && zip_code != null && lat != null && lng != null) {
                    addressToReturn = new Address(street, int.Parse(house_num), city, zip_code, double.Parse(lat), double.Parse(lng));
                }

                dataReader.Close();
                conn.Close();
            } catch (MySqlException ex) {
                conn.Close();
                throw ex;
            }

            if (addressToReturn == null) {
                Console.WriteLine("Address not found");
            }

            return addressToReturn;
        }

        public ATM getAtmByID(string atmID) {
            connect();

            string selectAtmQuery = $"SELECT * FROM Atms WHERE id = {atmID}";
            MySqlCommand selectAtmCmd = new MySqlCommand(selectAtmQuery, conn);

            if (conn != null) {
                try {
                    conn.Open();

                    MySqlDataReader reader = selectAtmCmd.ExecuteReader();
                    ATM atm = new ATM(null, 0, 0, "", 0);

                    while (reader.Read()) {
                        atm.address = getAddressByID(reader["Addresses_id"].ToString());
                        atm.capacity = int.Parse(reader["capacity"].ToString());
                        atm.size = int.Parse(reader["atm_size"].ToString());
                        atm.brand = reader["brand"].ToString();
                        atm.live_money_avilable = int.Parse(reader["live_money_avilable"].ToString());
                    }

                    conn.Close();
                    return atm;
                } catch (MySqlException ex) {
                    conn.Close();
                    throw ex;
                }
            }

            throw new Exception("Connection with database didn't established, Please try again");
        }

        public Track getTrackByID(string trackID) {
            connect();

            string getAllATMsQuery = $"SELECT * FROM AtmsTracks WHERE Track_id = {trackID}";
            string getTrackQuery = $"SELECT * FROM Tracks WHERE id = {trackID}";

            MySqlCommand selectAllATMsCmd = new MySqlCommand(getAllATMsQuery, conn);
            MySqlCommand selectTrackCmd = new MySqlCommand(getTrackQuery, conn);

            selectTrackCmd.CommandType = CommandType.Text;
            selectAllATMsCmd.CommandType = CommandType.Text;

            if (conn != null) {
                try {
                    conn.Open();

                    // Finding all the ATMs included in this Track
                    DataTable dataTable = new DataTable();
                    dataTable.Load(selectAllATMsCmd.ExecuteReader());
                    var rows = dataTable.AsEnumerable().ToArray();

                    List<string> atmsIDs = new List<string>();
                    for (int i = 0; i < rows.Length; i++) {
                        atmsIDs.Add(rows[i]["Atms_id"].ToString());
                    }

                    // Getting the specified ATM object
                    List<ATM> includedATMs = new List<ATM>();
                    for (int i = 0; i < atmsIDs.Count; i++) {
                        includedATMs.Add(getAtmByID(atmsIDs[i]));
                    }

                    MySqlDataReader trackReader = selectTrackCmd.ExecuteReader();
                    Track trackToRetrun = new Track(includedATMs.ToArray(), false, null, "", "", "");

                    while (trackReader.Read()) {
                        trackToRetrun.is_done = int.Parse(trackReader["is_done"].ToString()) == 1;
                        trackToRetrun.date = new SqlDate(trackReader["date"].ToString());
                        trackToRetrun.car_id = trackReader["Cars_id"].ToString();
                        trackToRetrun.employee_id = trackReader["Employees_id"].ToString();
                        trackToRetrun.manager_id = trackReader["Manager_id"].ToString();
                    }

                    conn.Close();
                    return trackToRetrun;
                } catch (MySqlException ex) {
                    conn.Close();
                    throw ex;
                }
            }

            throw new Exception("Connection with database didn't established, Please try again");
        }

        public Track[] getTracksByDate(SqlDate date) {
            connect();

            string allTracksAtDateQuery = $"SELECT * FROM Tracks WHERE date = '{ date.ToString() }'";
            MySqlCommand allTracksCmd = new MySqlCommand(allTracksAtDateQuery, conn);
            allTracksCmd.CommandType = CommandType.Text;

            if (conn != null) {
                try {
                    conn.Open();

                    // Find all Tracks at specific date
                    DataTable dataTable = new DataTable();
                    dataTable.Load(allTracksCmd.ExecuteReader());
                    var rows = dataTable.AsEnumerable().ToArray();

                    List<Track> allTracks = new List<Track>();

                    for (int i = 0; i < rows.Length; i++) {
                        allTracks.Add(getTrackByID(rows[i]["id"].ToString()));
                    }

                    conn.Close();
                    return allTracks.ToArray();
                } catch (MySqlException ex) {
                    conn.Close();
                    throw ex;
                }
            }

            throw new Exception("Connection with database didn't established, Please try again");
        }

        private int getAvilableMoney(string atmID) {
            connect();

            string query = $"SELECT live_money_avilable from Atms where id = {atmID}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            if (conn != null) {
                try {
                    conn.Open();

                    int amount = int.Parse(cmd.ExecuteScalar().ToString());
                    conn.Close();

                    return amount;
                } catch (MySqlException ex) {
                    conn.Close();
                    throw ex;
                }
            }

            throw new Exception("Connection with database didn't established, Please try again");
        }

        public void makeWithdrawal(string atmID, SqlDate date, int amount) {
            connect();

            int avilableMoney = getAvilableMoney(atmID);

            if (amount < avilableMoney) {
                string createWithdrawal = $"INSERT INTO Withdrawals (amount, date, Atms_id) VALUES({ amount }, '{ date.ToString() }', { atmID })";
                string updateATMRecord = $"UPDATE atms SET live_money_avilable = { avilableMoney } - { amount } WHERE id = { atmID }";

                MySqlCommand createWithdrawalCmd = new MySqlCommand(createWithdrawal, conn);
                MySqlCommand updateAtmCmd = new MySqlCommand(updateATMRecord, conn);

                createWithdrawalCmd.CommandType = CommandType.Text;
                updateAtmCmd.CommandType = CommandType.Text;

                if (conn != null) {
                    try {
                        conn.Open();

                        createWithdrawalCmd.ExecuteNonQuery();
                        updateAtmCmd.ExecuteNonQuery();

                        conn.Close();
                    } catch (MySqlException ex) {
                        conn.Close();
                        throw ex;
                    }
                } else {
                    throw new Exception("Connection with database didn't established, Please try again");
                }
            } else {
                Console.WriteLine("Sorry but you can't withdrawal from this Atm this amount of money");
            }
        }

        public Dictionary<string, int> getAllAtms() {
            connect();

            string query = "SELECT id, live_money_avilable from Atms";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            if (conn != null) {
                try {
                    conn.Open();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(cmd.ExecuteReader());
                    var rows = dataTable.AsEnumerable().ToArray();

                    Dictionary<string, int> toReturn = new Dictionary<string, int>();
                    for (int i = 0; i < rows.Length; i++) {
                        toReturn.Add(rows[i]["id"].ToString(), int.Parse(rows[i]["live_money_avilable"].ToString()));
                    }

                    conn.Close();
                    return toReturn;
                } catch (MySqlException ex) {
                    conn.Close();
                    throw ex;
                }
            }

            throw new Exception("Connection with database didn't established, Please try again");
        }

        public int getAvgWithdrawalsOfDay(string atmID, int day) {
            if (day >= 1 && day <= 7) {
                connect();

                // Get avg sum of day between sunday and saturday of atm's withdrawls
                string query = $"SELECT SUM(WithdrawalsSum) as SumOfAll, COUNT(*) AS NumOfRows FROM ( SELECT *, SUM(`amount`) as 'WithdrawalsSum' FROM Withdrawals WHERE date != CURDATE() and Atms_id = { atmID } and DAYOFWEEK(date) = { day } GROUP BY date ) as anotherAlias;";
                MySqlCommand checkAvgCmd = new MySqlCommand(query, conn);
                checkAvgCmd.CommandType = CommandType.Text;

                if (conn != null) {
                    try {
                        conn.Open();

                        MySqlDataReader dataReader = checkAvgCmd.ExecuteReader();

                        int sumOfAll = 0;
                        int numOfRows = 1;

                        while (dataReader.Read()) {
                            Console.WriteLine(dataReader.FieldCount);
                            string sumOfAllStr = dataReader["SumOfAll"].ToString();
                            string numOfRowsStr = dataReader["NumOfRows"].ToString();

                            if (!AdditionalFunctions.isEmpty(sumOfAllStr) && !AdditionalFunctions.isEmpty(numOfRowsStr)) {
                                sumOfAll = int.Parse(sumOfAllStr);
                                numOfRows = int.Parse(numOfRowsStr);

                            }
                        }

                        conn.Close();
                        return sumOfAll / numOfRows;
                    } catch (MySqlException ex) {
                        conn.Close();
                        throw ex;
                    }
                }

                throw new Exception("Connection with database didn't established, Please try again");
            }

            throw new Exception("Inserted incorrect day, Day must be between 1 (internal) and 7 (internal)");
        }

        // DFS Algorithem
        public List<LatLng> calcShortestTrack(List<LatLng> atmPoints) {
            Console.WriteLine($"in: {atmPoints.ToString()}");

            if (atmPoints.Count != 1) {
                // Starting point to check from
                LatLng startingPoint = atmPoints[0];
                LatLng nextPoint = new LatLng(0.0, 0.0);
                double minDistance = -1.0;

                for (int i = 1; i < atmPoints.Count; i++) {
                    if (minDistance == -1.0) {
                        minDistance = startingPoint.getDistance(atmPoints[i]);
                        nextPoint = atmPoints[i];
                    } else {
                        double dis = startingPoint.getDistance(atmPoints[i]);
                        if (minDistance > dis) {
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

        public string getIdByTrack(Track track) {
            connect();

            int isDone;

            if(track.is_done) {
                isDone = 1;
            } else {
                isDone = 0;
            }

            string query = $"SELECT id FROM Tracks WHERE is_done = {isDone} and date = '{track.date}' and Cars_id = '{track.car_id}' and Employees_id = '{track.employee_id.ToString()}' and Manager_id = '{track.manager_id}'";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            if(conn != null) {
                try {
                    conn.Open();

                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    string idToReturn = null;

                    while (dataReader.Read()) {
                        idToReturn = dataReader["id"].ToString();    
                    }

                    conn.Close();
                    return idToReturn;
                } catch(MySqlException ex) {
                    conn.Close();
                    throw ex;
                }
            }

            throw new Exception("Connection with database didn't established, Please try again");
        }

        public Employee logInEmp(string username, string hashedPassword) {
            connect();

            string query = $"SELECT * FROM Employees WHERE username = '{username}'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            if(conn != null) {
                try {
                    conn.Open();

                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    Employee toReturn = null;

                    while(dataReader.Read()) {
                        string abc = dataReader["password"].ToString().ToUpper();
                        Console.WriteLine(abc);
                        Console.WriteLine(hashedPassword.ToUpper());

                        if (dataReader["password"].ToString().ToUpper() == hashedPassword.ToUpper()) {
                            toReturn = new Employee(
                                dataReader["id"].ToString(),
                                dataReader["name"].ToString(),
                                new SqlDate(dataReader["birth_date"].ToString()),
                                dataReader["role"].ToString(),
                                username,
                                dataReader["phone_number"].ToString(),
                                dataReader["gender"].ToString(),
                                getAddressByID(dataReader["Addresses_id"].ToString())
                            );
                        }
                    }

                    conn.Close();
                    return toReturn;
                } catch(MySqlException ex) {
                    conn.Close();
                    throw ex;
                }
            }

            throw new Exception("Connection with database didn't established, Please try again");
        }

        public Track[] getAllTracksForEmp(string empID) {
            connect();

            string query = $"SELECT * FROM Tracks WHERE Employees_id = {empID} or Manager_id = {empID}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            if(conn != null) {
                try {
                    conn.Open();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(cmd.ExecuteReader());
                    var rows = dataTable.AsEnumerable().ToArray();

                    List<Track> allTracks = new List<Track>();
                    for(int i = 0; i < rows.Length; i++) {
                        allTracks.Add(getTrackByID(rows[i]["id"].ToString()));
                    }

                    conn.Close();
                    return allTracks.ToArray();
                } catch(MySqlException ex) {
                    conn.Close();
                    throw ex;
                }
            }

            throw new Exception("Connection with database didn't established, Please try again");
        }

        public bool fillATM(string atmID) {
            connect();

            string query = $"SELECT * FROM Atms WHERE id = {atmID}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            if(conn != null) {
                try {
                    conn.Open();

                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    int capacity = 0;

                    while (dataReader.Read()) {
                        capacity = int.Parse(dataReader["capacity"].ToString());
                    }

                    dataReader.Close();

                    if (capacity != 0) {
                        string updateQuery = $"UPDATE Atms SET live_money_avilable = '{capacity}' WHERE id = {atmID}";
                        MySqlCommand fillCmd = new MySqlCommand(updateQuery, conn);

                        fillCmd.ExecuteNonQuery();
                    } else {
                        conn.Close();
                        return false;
                    }

                    conn.Close();
                    return true;
                } catch(MySqlException ex) {
                    conn.Close();
                    throw ex;
                }
            }

            throw new Exception("Connection with database didn't established, Please try again");
        }

        public Dictionary<string, string> getATMsData() {
            connect();

            string firstQuery = $"SELECT *, COUNT(*) as allATMs FROM Atms";
            string secondQuery = $"SELECT *, COUNT(*) as allEmptyATMs FROM Atms WHERE live_money_avilable = 0";
            string thirdQuery = $"SELECT *, SUM(live_money_avilable) as CurrentMoney, SUM(capacity) as FilledMoney FROM Atms";

            MySqlCommand allAtmsCmd = new MySqlCommand(firstQuery, conn);
            MySqlCommand allEmptyCmd = new MySqlCommand(secondQuery, conn);
            MySqlCommand allMoneyCmd = new MySqlCommand(thirdQuery, conn);

            allAtmsCmd.CommandType = CommandType.Text;
            allEmptyCmd.CommandType = CommandType.Text;
            allMoneyCmd.CommandType = CommandType.Text;

            if(conn != null) {
                try {
                    conn.Open();

                    Dictionary<string, string> toReturn = new Dictionary<string, string>();
                    MySqlDataReader allAtmsReader = allAtmsCmd.ExecuteReader();
                    while(allAtmsReader.Read()) {
                        toReturn["allATMs"] = allAtmsReader["allATMs"].ToString();
                    }
                    allAtmsReader.Close();

                    MySqlDataReader allEmptyReader = allEmptyCmd.ExecuteReader();
                    while(allEmptyReader.Read()) {
                        toReturn["emptyATMs"] = allEmptyReader["allEmptyATMs"].ToString();
                    }
                    allEmptyReader.Close();

                    MySqlDataReader allMoneyReader = allMoneyCmd.ExecuteReader();
                    while (allMoneyReader.Read()) {
                        toReturn["cuurentMoney"] = allMoneyReader["CurrentMoney"].ToString();
                        toReturn["filledMoney"] = allMoneyReader["FilledMoney"].ToString();
                    }
                    allMoneyReader.Close();

                    conn.Close();
                    return toReturn;
                } catch(MySqlException ex) {
                    conn.Close();
                    throw ex;
                }
            }

            throw new Exception("Connection with database didn't established, Please try again");
        }

        public string getRandID(RandChooser chooser) {
            connect();

            string query = "";
            if (chooser == RandChooser.Car) {
                query = "SELECT id FROM Cars";
            } else if(chooser == RandChooser.Admin) {
                query = "SELECT id FROM Employees WHERE role = 'ADMIN'";
            } else if(chooser == RandChooser.Employee) {
                query = "SELECT id FROM Employees";
            }
            
            MySqlCommand cmd = new MySqlCommand(query, conn);

            if(conn != null) {
                try {
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    List<string> allIDs = new List<string>();

                    while(reader.Read()) {
                        allIDs.Add(reader["id"].ToString());
                    }

                    conn.Close();
                    int randPos = new Random().Next(0, allIDs.Count);
                    return allIDs[randPos];
                } catch(MySqlException ex) {
                    conn.Close();
                    throw ex;
                }
            }

            throw new Exception("Connection with database didn't established, Please try again");
        }
    }

    public enum RandChooser {
        Car,
        Admin,
        Employee
    }
}