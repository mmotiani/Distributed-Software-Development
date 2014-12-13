using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HotelBookingSystem
{
    class BankService
    {
        public static bool validateCardNo(string value)
        {
            Regex regexString = new Regex("^[0-9]*$");
         //   ServiceReference1.ServiceClient sc = new ServiceReference1.ServiceClient();
            string decrypted_value = EncryptionDecryption.Decryption(value);
            if (regexString.IsMatch(decrypted_value))
                return true;
            else
            {
                throw new ArgumentException("Not a valid Card No");
            }
        }
    }

}
