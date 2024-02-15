using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Rock_Paper_Scissors
{
    public static class HMAC_Key_generator
    {
        public static string KeyGenerator()
        {
            SecureRandom sr = new SecureRandom();
            byte[] keyInBytes = sr.GenerateSeed(32);
            return BitConverter.ToString(keyInBytes).Replace("-", "");

        }
    }
}
