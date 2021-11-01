using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace JsonBase64.Helpers
{
    public static class Base64Encrypter
    {
        public static string Encrypt(string dato)
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(dato))
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(dato);
                result = Convert.ToBase64String(byteArray);
            }

            return result;
        }

        public static string Decrypt(string base64)
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(base64))
            {
                byte[] byteArray = Convert.FromBase64String(base64);
                result = Encoding.UTF8.GetString(byteArray);
            }

            return result;
        }
    }
}
