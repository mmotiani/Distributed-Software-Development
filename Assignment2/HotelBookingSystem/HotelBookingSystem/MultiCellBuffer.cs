using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HotelBookingSystem
{
    class MultiCellBuffer
    {
        // write semaphore is created
        public static Semaphore writeSemaphore = new Semaphore(3, 3);

        // read semaphore is created & blocked the other requests untill released 
        public static Semaphore readSemaphore = new Semaphore(0, 3);

        // create buffer and the counter values to default values
        public static String[] multiCellBuffer = new String[3];
        public static Int32 writeCount = -1;
        public static Int32 readCount = -1;

        // create a lock object to prevent simultaneous access
        public static object obj = new object();

        // method to set the buffer value from the multiCellBuffer
        public static void setOneCell(string bufferValue)
        {
            writeSemaphore.WaitOne();

            lock (obj)
            {
                writeCount = (writeCount + 1) % 3;

                multiCellBuffer[writeCount] = bufferValue;

            }

            readSemaphore.Release();

        }

        //method the get the buffer value from the multiCellBuffer
        public static string getOneCell()
        {
            readSemaphore.WaitOne();

            lock (obj)
            {
                readCount = (readCount + 1) % 3;

                writeSemaphore.Release();

                string returnValue = multiCellBuffer[readCount];

                multiCellBuffer[readCount] = null;

                return returnValue;
            }
        }
    }
}