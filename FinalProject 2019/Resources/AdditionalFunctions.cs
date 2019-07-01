using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_2019.Resources {
    class AdditionalFunctions {
        public static bool isEmpty(string str) {
            if (str == null || str == "" || str == " ") {
                return true;
            }

            return false;
        }

        // Fl = FirstLast
        public static string trimFlWhitespaces(string str) {
            if (str[0] == ' ') {
                str.TrimEnd();
            }

            if(str[str.Length - 1] == ' ') {
                str.TrimStart();
            }

            return str;
        }

        public static string MD5(string text) {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(text));

            for (int i = 0; i < bytes.Length; i++) {
                hash.Append(bytes[i].ToString("x2"));
            }

            return hash.ToString();
        }
    }
}
