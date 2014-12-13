using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HotelBookingSystem
{
    class Confirmation
    {

        // write semaphore is created
        public static Semaphore writeSemaphore = new Semaphore(10, 10);

        // read semaphore is created & blocked the other requests untill released 
        public static Semaphore readSemaphore = new Semaphore(0, 10);

        // create buffer and the counter values to default values
        public static String[] multiCellConfirmationBuffer = new String[3];
        public static Int32 writeCount = -1;
        public static Int32 readCount = -1;

        // create a lock object to prevent simultaneous access
        public static object obj = new object();

        // method to set the buffer value from the multiCellConfirmationBuffer
        public static void setOneCell(string bufferValue)
        {
            writeSemaphore.WaitOne();

            lock (obj)
            {
                writeCount = (writeCount + 1) % 3;

                multiCellConfirmationBuffer[writeCount] = bufferValue;

            }

            readSemaphore.Release();

        }

        //method the get the buffer value from the multiCellConfirmationBuffer
        public static string getOneCell()
        {
            readSemaphore.WaitOne();

            lock (obj)
            {
                readCount = (readCount + 1) % 3;

                writeSemaphore.Release();

                string returnValue = multiCellConfirmationBuffer[readCount];

                multiCellConfirmationBuffer[readCount] = null;

                return returnValue;
            }
        }
   
    }
}
