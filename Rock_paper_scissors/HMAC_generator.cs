using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Rock_Paper_Scissors
{
    public class HMAC_generator
    {
        public static string GetHMAC(string text, string key)
        {


            using (var hmacsha256 = new HMACSHA256(Encoding.UTF8.GetBytes(key)))
            {
                var HashCode = hmacsha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(HashCode).Replace("-", "");
            }

        }
    }

}
