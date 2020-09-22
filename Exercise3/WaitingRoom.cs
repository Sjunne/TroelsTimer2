using System;
using System.Threading;

namespace Exercise3
{
    public class WaitingRoom
    {
        public Action<int> NumberChange;
        private int currentNumber = 0;
        private int ticketCount = 0;

        public void RunWaitingRoom()
        {
            while (currentNumber < ticketCount)
            {
                Console.WriteLine(currentNumber + "is now entering");
                NumberChange?.Invoke(currentNumber);
                currentNumber++;
                Thread.Sleep(1000);
            }
        }

        public int DrawNumber()
        {
            ticketCount++;
            return ticketCount;
        }
    }
}