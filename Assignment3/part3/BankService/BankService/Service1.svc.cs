using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//For Convinience of Grader: 
//For master card: Card length should be 16 and first digit must be 5 and second digit should be between 1 and 5. 
//For Visa card: Card length can be 13 or 16 and first digit must be 4

//Website reference : http://en.wikipedia.org/wiki/Bank_card_number

namespace BankService
{
   // enum card  {Master_Card, Visa_Card};
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public bool bank(string Card, string card_no)// bank method to validate the card
        {
            try
            {
                string str1 = "Master_card";   //string variable declaration
                string str2 = "Visa_card";

                byte[] digit = new byte[16]; //byte array to store the card no.
                if (card_no.Equals(null))
                {
                    return false;
                }
                int length = 0;
                while (length < card_no.Length)
                {
                    if (char.IsDigit(card_no, length)) //if statement to check if the entered no.s are digit or not
                    {
                        digit[length] = byte.Parse(card_no[length].ToString());
                    }
                    else
                    {
                        return false;
                    }
                    length++;
                }

                if (Card.Equals(str1)) //if statement to validate the Master Card
                {
                    if (length != 16)
                        return false;
                    if (digit[0] != 5 || digit[1] == 0 || digit[1] > 5)
                        return false;


                }
                if (Card.Equals(str2))   //if statement to validate the Visa Card
                {
                    if (length != 16 && length != 13)
                        return false;
                    if (digit[0] != 4)
                        return false;

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }

}
