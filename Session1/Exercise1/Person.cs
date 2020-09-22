using System;

namespace Exercise1
{
    public class Person
    {
        public string name { get; set; }

        public void Introduce()
        {
            Console.WriteLine("Hi, i am " + name);
        }
    }
}