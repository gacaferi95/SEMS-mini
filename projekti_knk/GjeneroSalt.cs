using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Projekti_KNK
{
    static class GjeneroSalt
    {
        public static string GjeneroSAltPAsswod(string Salt, string Password)
        {
            string SAltPass = Salt + Password;
            SHA1CryptoServiceProvider objHash = new SHA1CryptoServiceProvider();
            byte[] bajtSaltHashPassword = Encoding.UTF8.GetBytes(SAltPass);
            byte[] bajHashVlera = objHash.ComputeHash(bajtSaltHashPassword);

            return Convert.ToBase64String(bajHashVlera);
        }
    }
}
