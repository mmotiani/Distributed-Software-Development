using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HotelBookingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE HOTEL BOOKING SYSTEM BY DARE DEVILS");
            Console.WriteLine("The Number of Rooms availble to book ----->>> 500");
            Console.WriteLine("Total Number of Price Cut Events ------>>> 10");
            Console.WriteLine("AFter Successfull Order Processing the Hotel supplier thread will send a confirmation to the Travel Agency &" + "\n" +
                "the Program Terminates When there are no Rooms to book  & Displays NO ROOMS TO BOOK Message ");
            Console.WriteLine("Please Press 'Y' to start the program");

            string startProgram = Console.ReadLine();

            if (startProgram == "Y")
            {

                HotelSupplier hotel = new HotelSupplier();
                TravelAgency travel = new TravelAgency();
                Int32 count = 1;
                HotelSupplier.pricecut += new priceCutEvent(travel.roomsOnSale);
                
                while (count < 10)
                {
                    //Call to pricing model
                    hotel.changeprice();

                    //Generating Travel Agency threads
                    Thread[] travelAgencyThread = new Thread[5];
                    for (int j = 0; j < 5; j++)
                    {
                        travelAgencyThread[j] = new Thread(new ThreadStart(travel.travelAgency));
                        travelAgencyThread[j].Name = "TRAVEL AGENCY" + (j + 1).ToString();
                        travelAgencyThread[j].Start();

                    }

                    //Generating Hotel Supplier threads
                    Thread[] hotelThread = new Thread[3];
                    for (int i = 0; i < 3; i++)
                    {
                        hotelThread[i] = new Thread(new ThreadStart(hotel.initateOrderProcessing));
                        hotelThread[i].Name = (i + 1).ToString();
                        hotelThread[i].Start();

                    }
                    count++;

                }

                

            }
        }

    }
}