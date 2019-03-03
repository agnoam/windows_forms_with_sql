using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace FinalProject_2019 {
    class DatabaseConnector {

        private static string server = "server_name";
        private static string database = "nsecurity";
        private static string user = "root";
        private static string password = "toor";
        private static string port = "3306";
        private static string sslM = "none";
        private static SqlConnection conn = null;

        public static void connect() {
            string connectionString = String.Format(
                "server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", 
                server, 
                port, 
                user, 
                password, 
                database, 
                sslM
            );

            SqlConnection connection = new SqlConnection(connectionString);
        }

        public static string read() {
            return null;
        }

        public static void write() {

        }
    }
}
