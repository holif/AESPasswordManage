using System;
using System.Collections.Generic;
using System.Security.Cryptography;  
using System.Linq;
using System.Text;

namespace KeyBox
{
    class Encrypt
    {
        //Base64加密
        public static string StringToBase64string(string key)
        {
            return System.Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(key));
        }

        //Base64解密
        public static string Base64ToString(string key) {

            return System.Text.Encoding.Default.GetString(System.Convert.FromBase64String(key));
        }

        //MD5加密  
        public static string GetMd5Hash( string input)
        {
          MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        // AES-256 加密  
        public static string AESEncrypt(string toEncrypt,string key)
        {
            // 256-AES key      
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;
            rDel.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        //AES-256 解密  
        public static string AESDecrypt(string toDecrypt,string key)
        {
            // 256-AES key      
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
            byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;
            rDel.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = rDel.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return UTF8Encoding.UTF8.GetString(resultArray);
        }  
    }
}
