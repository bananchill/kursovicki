using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory.Models
{
    class CryptographyPassword
    {
        public static string GetMD5(string value)
        {
            MD5CryptoServiceProvider my_pass = new MD5CryptoServiceProvider();
            byte[] data = Encoding.ASCII.GetBytes(value);
            data = my_pass.ComputeHash(data);
            return Encoding.ASCII.GetString(data);
        }
    }
}
