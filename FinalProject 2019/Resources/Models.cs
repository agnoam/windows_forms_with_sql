using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_2019.Resources {
    public class Address {
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

    public class ATM {
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

        public ATM(Address _address, int _capacity, int _size, string _brand, int live_money_avilable_c) {
            address = _address;
            capacity = _capacity;
            live_money_avilable = _capacity;
            size = _size;
            brand = _brand;
            live_money_avilable = live_money_avilable_c;
        }
    }

    public class Employee {
        public string id { get; set; }
        public string name { get; set; }
        public SqlDate birthDate { get; set; }
        public string role { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public Address address { get; set; }

        public Employee(string _id, string _name, SqlDate _birthDate, string _role, string _username, string _phone_number, string _gender, Address _address) {
            if (_id.Length == 9) {
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

        public Employee(
            string _id,
            string _name,
            SqlDate _birthDate,
            string _role,
            string _username,
            string _password,
            string _phone_number,
            string _gender,
            Address _address
        ) {
            id = _id;
            name = _name;
            birthDate = _birthDate;
            role = _role;
            username = _username;
            password = password;
            phone_number = _phone_number;
            email = $"{username}@nsec.com";
            gender = _gender;
            address = _address;
        }
    }

    public class Car {
        public string code { get; set; }
        public string model { get; set; }
        public SqlDate creation_date { get; set; }
        public string driver_id { get; set; }

        public Car(string _code, string _model, SqlDate _creation_date, string _driver_id) {
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

    public class SqlDate {
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }

        public SqlDate(int _day, int _month, int _year) {
            if (_day <= 31 && _month <= 12 && _year > 1900) {
                day = _day;
                month = _month;
                year = _year;
            } else {
                throw new Exception("Inserted values cannot be a valid day, Please check the values and try again");
            }
        }

        public SqlDate(string dateString) {
            // DD/MM/YYYY
            string[] splittedDate = dateString.Split('/');

            if(splittedDate.Length == 3) {
                int day_c = int.Parse(splittedDate[0]);
                int month_c = int.Parse(splittedDate[1]);
                int year_c = int.Parse(splittedDate[2].Split(' ')[0]);

                if (day_c >= 1 && day <= 31) {
                    if (month_c >= 1 && month <= 12) {
                        if (year_c > 1920 && year < 2150) {
                            day = day_c;
                            month = month_c;
                            year = year_c;
                        } else {
                            throw new Exception("Invalid year");
                        }
                    } else {
                        throw new Exception("Invalid month => have to be between 1 and 12");
                    }
                } else {
                    throw new Exception("Invalid day => have to be between 1 and 31");
                }
            }
        }

        public override string ToString() {
            if (day < 10) {
                if (month < 10) {
                    return $"{year}-0{month}-0{day}";
                }

                return $"{year}-{month}-0{day}";
            } else if (month < 10) {
                return $"{year}-0{month}-{day}";
            } else {
                return $"{year}-{month}-{day}";
            }
        }
    }

    class ConstVars {
        public static class Gender {
            public static string MALE = "M";
            public static string FEMALE = "F";
        }

        public static class Roles {
            public static string ADMIN = "ADMIN";
            public static string EMPLOYEE = "EMP";
        }
    }

    public class LatLng {
        public double lat { get; set; }
        public double lng { get; set; }

        public LatLng(double lat_c, double lng_c) {
            lat = lat_c;
            lng = lng_c;
        }

        public double getDistance(LatLng latlng) {
            double d1 = lat * (Math.PI / 180.0);
            double num1 = lng * (Math.PI / 180.0);
            double d2 = latlng.lat * (Math.PI / 180.0);
            double num2 = latlng.lng * (Math.PI / 180.0) - num1;
            double d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) + Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);

            return 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
        }

        public PointLatLng toPointLatLng() {
            return new PointLatLng(lat, lng);
        }

        public override string ToString() {
            return $"({lat}, {lng})";
        }
    }
}
