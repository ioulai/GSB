using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Security.Cryptography;

namespace RapportVisite
{
    class CRYPTAGE
    {
        public static string GetMD5Hash(MD5 md5Hash, string lePassword)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(lePassword));
            StringBuilder motCrypte = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                motCrypte.Append(data[i].ToString("x2"));
            }
            return motCrypte.ToString();
        }
    }
}