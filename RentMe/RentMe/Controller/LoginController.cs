using System;
using System.IO;
using System.Security.Cryptography;
using System.Configuration;
using System.Text;
using RentMe.DAL;
using RentMe.Models;

namespace RentMe.Controller
{
    class LoginController
    {
        public bool isValidLogin(string username, string password)
        {
            try
            {
                Login login = LoginDAL.GetLogin(username, Encrypt(password));

                if (login == null)
                {
                    return false;
                }

                else
                {
                    return true;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool IsAdminRole(string username, string password)
        {
            try
            {


                return LoginDAL.GetRole(username, Encrypt(password));

            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string GetLoginPassword(string username)
        {
            try
            {
                String password = LoginDAL.GetLoginPassword(username);
                return Decrypt(password);
                

            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool SetLoginPassword(string userID, string oldPassword, string newPassword)
        {
            try
            {


                return LoginDAL.SetLoginPassword(userID, Encrypt(oldPassword), Encrypt(newPassword));

            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string EncryptPassword(string text)
        {
            string password = Encrypt(text);
            return password;
        }

        private static string Encrypt(string text)
        {
            byte[] hashBytes = Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings["hash"]);

            byte[] plainTextBytes = Encoding.UTF8.GetBytes(text);

            PasswordDeriveBytes password = new PasswordDeriveBytes(ConfigurationManager.AppSettings["phrase"], null);

            byte[] keyBytes = password.GetBytes(256 / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();

            symmetricKey.Mode = CipherMode.CBC;

            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, hashBytes);

            MemoryStream memoryStream = new MemoryStream();

            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

            cryptoStream.FlushFinalBlock();

            byte[] cipherTextBytes = memoryStream.ToArray();

            memoryStream.Close();

            cryptoStream.Close();
            return Convert.ToBase64String(cipherTextBytes);
        }
        
        private static string Decrypt(string text)
        {
            byte[] hashBytes = Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings["hash"]);

            byte[] cipherTextBytes = Convert.FromBase64String(text);

            PasswordDeriveBytes password = new PasswordDeriveBytes(ConfigurationManager.AppSettings["phrase"], null);

            byte[] keyBytes = password.GetBytes(256 / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();

            symmetricKey.Mode = CipherMode.CBC;

            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, hashBytes);

            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);

            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);

            memoryStream.Close();

            cryptoStream.Close();

            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }
    }
}
