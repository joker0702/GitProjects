using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RSAAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            UTF8Encoding byteConverter = new UTF8Encoding();

            byte[] dataToEncrypt = byteConverter.GetBytes("Data to Encrypt");
            byte[] encryptData = null;
            byte[] decryptData = null;

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(rsa.ExportParameters(true));
                encryptData = rsa.Encrypt(dataToEncrypt, false);

                rsa.ImportParameters(rsa.ExportParameters(true));
                decryptData = rsa.Decrypt(encryptData, false);
            }
            
            string encryptedString = byteConverter.GetString(encryptData, 0, encryptData.Length);
            string decryptedString = UTF8Encoding.ASCII.GetString(decryptData, 0, decryptData.Length);
            Console.WriteLine("-------------- Encrypted Data: ----------------\n" + encryptedString + "\n");
            Console.WriteLine("-------------- Decrypted Data: ----------------\n" + decryptData);

            Console.ReadLine();
        }
    }
}
