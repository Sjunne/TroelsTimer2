using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitingRoom wr = new WaitingRoom();
            Patient one = new Patient(wr);
            Patient two = new Patient(wr);
            Patient three = new Patient(wr);
            Patient four = new Patient(wr);
            
            wr.RunWaitingRoom();



        }
    }
}