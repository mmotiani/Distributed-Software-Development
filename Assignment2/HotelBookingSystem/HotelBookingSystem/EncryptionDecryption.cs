using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    class EncryptionDecryption
    {
        // Call to Encryption Service to Encrypt the String
        public static string Encryption(String s)
        {
            ServiceReference2.ServiceClient sc2 = new ServiceReference2.ServiceClient();
            string s1 = sc2.Encrypt(s);
            return s1;
        }

        // Call to Decryption Service to Decrypt the String
        public static string Decryption(String s)
        {
            ServiceReference2.ServiceClient sc2 = new ServiceReference2.ServiceClient();
            string s1 = sc2.Decrypt(s);
            return s1;
        }
    }
}
