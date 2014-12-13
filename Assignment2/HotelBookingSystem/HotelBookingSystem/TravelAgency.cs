using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HotelBookingSystem
{
    class TravelAgency
    {
        public static Int32 priceNow = 100;
        public static Int32 priceNew;
        public static Int32 counter = 1;

        public Int32 noofRooms;
        Random num = new Random();
        String supThread;
        public void travelAgency()
        {
            HotelSupplier hotel = new HotelSupplier();

            for (Int32 i = 0; i < 10; i++)
            {
                priceNew = hotel.getPrice();
                noofRooms = hotel.getNoofRooms();
                supThread = hotel.getThreadName();

                Int32 roomstoOrder = 1;

                //Criteria for Travel Agency to decide how many rooms to book
                if (priceNow <= priceNew && noofRooms > 0)
                {
                    roomstoOrder = num.Next(1, noofRooms);
                }
                else if (noofRooms < 0)
                {
                    Console.WriteLine("**********NO ROOMS TO BOOK****************");
                    break;
                }


                priceNow = priceNew;

                //Craetion of order class object
                OrderClass c = new OrderClass();
                c.SenderId = Thread.CurrentThread.Name;
                c.CardNo = num.Next(5000, 7000).ToString();
                c.Amount = roomstoOrder;
                c.ReceiverId = supThread;

                //Call to the encoder method
                String oderobject = Encoder.Encode(c);

                //Storing encoded order class object in a multicell buffer
                MultiCellBuffer.setOneCell(oderobject);
                Console.WriteLine("{0} has everyday low prices: ${1} for each of {2} rooms", Thread.CurrentThread.Name, hotel.getPrice(), roomstoOrder);
                //Receiving Confirmation from multicell confirmation buffer
                Confirmation.getOneCell();
                Console.WriteLine("Booking Confirmation received by Travel Agency {0}", Thread.CurrentThread.Name);



            }
        }

        public void roomsOnSale()
        {

            Console.WriteLine("******************************Price cut event************************************************");

        }

    }
}

