using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    class Decoder
    {
        // Decode Method to convert the string to OrderClass Object
        public static object Decode(String mainObject)
        {
            OrderClass targetObject = new OrderClass();
            string[] str = mainObject.Split(',');
            targetObject.CardNo = str[0];
            targetObject.SenderId = str[1];
            targetObject.ReceiverId = str[2];
            targetObject.Amount = Convert.ToInt32(str[3]);

            return targetObject;
        }
    }
}