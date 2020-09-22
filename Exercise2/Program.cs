using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time(23,59);
            time.AddMinutes(1);
            Console.WriteLine(time);
            time.SubstractMinutes(60);
            Console.WriteLine(time);
        }
    }
}