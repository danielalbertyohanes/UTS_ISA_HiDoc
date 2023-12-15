using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapKakiTiga_LIB
{
    public class Hashing
    {
        public string Encrypt(string plaintext)
        {
            return GenerateSHA512String("Eic9xwSE7wzyMIyI2xW7Wgct" + GenerateSHA512String(plaintext));
        }

        public string GenerateSHA512String(string plainText)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(plainText);
            byte[] hash = sha512.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }

        private string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }
    }
}
