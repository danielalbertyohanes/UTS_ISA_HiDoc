using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace CapKakiTiga_LIB
{
    public class EnkripsiAES
    {
        AesManaged aesCrypto;
        private string password;
        private static byte[] IV = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public EnkripsiAES()
        {
            aesCrypto = new AesManaged();
            password = "3464818668596667";
        }

        public string Encryption(string plainTxt)
        {
            byte[] kunci = Encoding.UTF8.GetBytes(password);

            aesCrypto.Key = kunci;
            aesCrypto.IV = IV;

            MemoryStream memory = new MemoryStream();
            CryptoStream crypto = new CryptoStream(memory, aesCrypto.CreateEncryptor(), CryptoStreamMode.Write);

            byte[] plainBytes = Encoding.UTF8.GetBytes(plainTxt);
            crypto.Write(plainBytes, 0, plainBytes.Length);
            crypto.FlushFinalBlock();

            byte[] encryptedText = memory.ToArray();
            return Convert.ToBase64String(encryptedText);
        }

        public string Decryption(string cypherTxt)
        {
            byte[] kunci = Encoding.UTF8.GetBytes(password);

            aesCrypto.Key = kunci;
            aesCrypto.IV = IV;

            MemoryStream memory = new MemoryStream();
            CryptoStream crypto = new CryptoStream(memory, aesCrypto.CreateDecryptor(), CryptoStreamMode.Write);

            byte[] cypherBytes = Convert.FromBase64String(cypherTxt);
            crypto.Write(cypherBytes, 0, cypherBytes.Length);
            crypto.FlushFinalBlock();

            byte[] decryptedText = memory.ToArray();
            return UTF8Encoding.UTF8.GetString(decryptedText, 0, decryptedText.Length);
        }
    }
}
