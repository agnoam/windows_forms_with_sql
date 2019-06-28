using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_2019.Resources {
    class AdditionalFunctions {
        public static bool isEmpty(string str) {
            if (str == null && str == "" && str == " ") {
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
            string key = "MY_SUPER_KEY#@!*32678324_!47327";

            using (var md5 = new MD5CryptoServiceProvider()) {
                using (var tdes = new TripleDESCryptoServiceProvider()) {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateEncryptor()) {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(text);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }

    }
}
