using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new StringReturner();
            Console.WriteLine(test.StringReturnerMethod("hi", "bye"));
        }
    }
}