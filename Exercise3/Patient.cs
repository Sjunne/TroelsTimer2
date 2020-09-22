using System;

namespace Exercise3
{
    public class Patient
    {
        public int numberInQueue { get; set; }
        public WaitingRoom WaitingRoom;

        public Patient(WaitingRoom wr)
        {
            this.WaitingRoom = wr;
            numberInQueue = wr.DrawNumber();
            WaitingRoom.NumberChange += this.ReactToNumber;
        }

        private void ReactToNumber(int number)
        {
            if(number == numberInQueue)
                Console.WriteLine("MY TURN LOL");
            else
                Console.WriteLine("Back on phone not my turn");
        }
    }
}