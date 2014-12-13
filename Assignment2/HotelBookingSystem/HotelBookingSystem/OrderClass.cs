using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HotelBookingSystem
{
    class OrderClass
    {
        // Order class members to store the input/output
        private string senderId;
        private string receiverId;
        private string cardNo;
        private Int32 amount;

        // Getter and setter methods to get and set values

        public string SenderId
        {
           get{return senderId; }
           set{senderId=value;}
        }

       
        public string ReceiverId
        {
            get { return receiverId; }
            set { receiverId = value; }
        }

        public string CardNo
        {
            get{return cardNo;}
            set { cardNo = value; }
        }

        
        public Int32 Amount
        {
            get { return amount; }
            set { amount = value; }
        }

       
    }
}