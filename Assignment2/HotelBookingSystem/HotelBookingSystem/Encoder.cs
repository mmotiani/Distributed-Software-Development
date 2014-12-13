using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    class Encoder
    {
        // Encode Method to convert the OrderClass object to string
        public static string Encode(Object myObject)
        {
            OrderClass targetObject = (OrderClass)myObject;
            string str = targetObject.CardNo + "," + targetObject.SenderId + "," + targetObject.ReceiverId + "," + targetObject.Amount;
            return str;
        }

    }
}